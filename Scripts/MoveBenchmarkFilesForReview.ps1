<# 
Spargine benchmark file mover (copy only if missing/older + summary)

Step 1:
- Copy *-report.csv files that have the Archive attribute set
  from: D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results
  to:   D:\src\GitHub\dotNetTips.Spargine.10\docs\Charts\Data
- Copy ONLY if destination is missing OR destination LastWriteTime is older than source.
- After a successful copy, clear the Archive bit on the source file.

Step 2:
- OLD (Archive\2026JAN):
  - Copy *-report-full.json to D:\temp\sparginereview as *-report-full-old.json
  - Copy *-report.csv       to D:\temp\sparginereview as *-report-old.csv
- NEW (Current Benchmark Results):
  - Copy *-report-full.json to D:\temp\sparginereview as *-report-full-new.json
  - Copy *-report.csv       to D:\temp\sparginereview as *-report-new.csv
- Copy ONLY if destination is missing OR destination LastWriteTime is older than source.

Summary:
- Counts and lists of Copied / Skipped / Failed for each sub-step.
#>

$ErrorActionPreference = 'Stop'

# ----------------------------
# Paths
# ----------------------------
$sourceRoot          = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results'
$destCsv             = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Charts\Data'

$archiveSource       = Join-Path $sourceRoot 'Archive\2026JAN'
$currentSource       = $sourceRoot
$reviewDest          = 'D:\temp\sparginebenchmarkreview'

# ----------------------------
# Helpers
# ----------------------------
function Ensure-Directory {
	param([Parameter(Mandatory)][string]$Path)
	if (-not (Test-Path -LiteralPath $Path)) {
		New-Item -ItemType Directory -Path $Path | Out-Null
	}
}

function Rename-Suffix {
	param(
		[Parameter(Mandatory)][string]$FileName,
		[Parameter(Mandatory)][string]$OldSuffix,
		[Parameter(Mandatory)][string]$NewSuffix
	)

	if ($FileName.EndsWith($OldSuffix, [System.StringComparison]::OrdinalIgnoreCase)) {
		return $FileName.Substring(0, $FileName.Length - $OldSuffix.Length) + $NewSuffix
	}

	# Fallback: if it doesn't match expected suffix, append new suffix
	return "$FileName$NewSuffix"
}

function Should-CopyFile {
	param(
		[Parameter(Mandatory)][System.IO.FileInfo]$SourceFile,
		[Parameter(Mandatory)][string]$DestinationPath
	)

	if (-not (Test-Path -LiteralPath $DestinationPath)) {
		return $true
	}

	$destItem = Get-Item -LiteralPath $DestinationPath
	return ($destItem.LastWriteTime -lt $SourceFile.LastWriteTime)
}

function Copy-IfMissingOrOlder {
	param(
		[Parameter(Mandatory)][System.IO.FileInfo]$SourceFile,
		[Parameter(Mandatory)][string]$DestinationPath
	)

	if (Should-CopyFile -SourceFile $SourceFile -DestinationPath $DestinationPath) {
		Copy-Item -LiteralPath $SourceFile.FullName -Destination $DestinationPath -Force
		return $true
	}

	return $false
}

function New-StepSummary {
	return [ordered]@{
		Copied  = New-Object System.Collections.Generic.List[string]
		Skipped = New-Object System.Collections.Generic.List[string]
		Failed  = New-Object System.Collections.Generic.List[string]
	}
}

function Print-StepSummary {
	param(
		[Parameter(Mandatory)][string]$Title,
		[Parameter(Mandatory)]$Summary
	)

	Write-Host ""
	Write-Host "=== Summary: $Title ==="
	Write-Host ("Copied : {0}" -f $Summary.Copied.Count)
	Write-Host ("Skipped: {0}" -f $Summary.Skipped.Count)
	Write-Host ("Failed : {0}" -f $Summary.Failed.Count)

	if ($Summary.Copied.Count -gt 0) {
		Write-Host "`n-- Copied --"
		$Summary.Copied | ForEach-Object { Write-Host $_ }
	}
	if ($Summary.Skipped.Count -gt 0) {
		Write-Host "`n-- Skipped --"
		$Summary.Skipped | ForEach-Object { Write-Host $_ }
	}
	if ($Summary.Failed.Count -gt 0) {
		Write-Host "`n-- Failed --"
		$Summary.Failed | ForEach-Object { Write-Host $_ }
	}
}

Ensure-Directory -Path $destCsv
Ensure-Directory -Path $reviewDest

# ----------------------------
# Step 1
# ----------------------------
$step1 = New-StepSummary

Write-Host "=== Step 1: Copy archived CSV reports (Archive bit set) - only if missing/older ==="

$csvFiles = Get-ChildItem -LiteralPath $sourceRoot -File -Filter '*-report.csv' |
	Where-Object { ($_.Attributes -band [IO.FileAttributes]::Archive) -ne 0 }

if (-not $csvFiles -or $csvFiles.Count -eq 0) {
	Write-Host "No '*-report.csv' files found with Archive bit set."
}
else {
	foreach ($file in $csvFiles) {
		$destPath = Join-Path $destCsv $file.Name

		try {
			$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath

			if ($copied) {
				# Clear archive bit after successful copy
				$newAttrs = $file.Attributes -bxor ([IO.FileAttributes]::Archive)
				Set-ItemProperty -LiteralPath $file.FullName -Name Attributes -Value $newAttrs

				$step1.Copied.Add("$($file.Name)  ->  $destPath")
				Write-Host "Copied + cleared Archive bit: $($file.Name)"
			}
			else {
				$step1.Skipped.Add("$($file.Name)  (destination up-to-date)")
				Write-Host "Skipped (up-to-date): $($file.Name)"
			}
		}
		catch {
			$step1.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
			Write-Warning "FAILED: $($file.FullName). Error: $($_.Exception.Message)"
		}
	}
}

# ----------------------------
# Step 2a: OLD (Archive\2026JAN) JSON + CSV (renamed)
# ----------------------------
$step2OldJson = New-StepSummary
$step2OldCsv  = New-StepSummary

Write-Host ""
Write-Host "=== Step 2a: Copy OLD reports from Archive\\2026JAN (JSON + CSV) - only if missing/older ==="

if (Test-Path -LiteralPath $archiveSource) {

	# OLD JSON
	$oldJsonFiles = Get-ChildItem -LiteralPath $archiveSource -File -Filter '*-report-full.json'
	foreach ($file in ($oldJsonFiles | Where-Object { $_ -ne $null })) {
		$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report-full.json' -NewSuffix '-report-full-old.json'
		$destPath = Join-Path $reviewDest $newName

		try {
			$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath
			if ($copied) {
				$step2OldJson.Copied.Add("$($file.Name)  ->  $newName")
				Write-Host "Copied OLD JSON: $($file.Name) -> $newName"
			}
			else {
				$step2OldJson.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
				Write-Host "Skipped OLD JSON (up-to-date): $($file.Name)"
			}
		}
		catch {
			$step2OldJson.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
			Write-Warning "FAILED (OLD JSON): $($file.FullName). Error: $($_.Exception.Message)"
		}
	}

	# OLD CSV (rename to *-report-old.csv)
	$oldCsvFiles = Get-ChildItem -LiteralPath $archiveSource -File -Filter '*-report.csv'
	foreach ($file in ($oldCsvFiles | Where-Object { $_ -ne $null })) {
		$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report.csv' -NewSuffix '-report-old.csv'
		$destPath = Join-Path $reviewDest $newName

		try {
			$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath
			if ($copied) {
				$step2OldCsv.Copied.Add("$($file.Name)  ->  $newName")
				Write-Host "Copied OLD CSV: $($file.Name) -> $newName"
			}
			else {
				$step2OldCsv.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
				Write-Host "Skipped OLD CSV (up-to-date): $($file.Name)"
			}
		}
		catch {
			$step2OldCsv.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
			Write-Warning "FAILED (OLD CSV): $($file.FullName). Error: $($_.Exception.Message)"
		}
	}
}
else {
	$msg = "Archive folder not found: $archiveSource"
	$step2OldJson.Failed.Add($msg)
	$step2OldCsv.Failed.Add($msg)
	Write-Warning $msg
}

# ----------------------------
# Step 2b: NEW (Current) JSON + CSV (renamed)
# ----------------------------
$step2NewJson = New-StepSummary
$step2NewCsv  = New-StepSummary

Write-Host ""
Write-Host "=== Step 2b: Copy NEW reports from current folder (JSON + CSV) - only if missing/older ==="

if (Test-Path -LiteralPath $currentSource) {

	# NEW JSON
	$newJsonFiles = Get-ChildItem -LiteralPath $currentSource -File -Filter '*-report-full.json'
	foreach ($file in ($newJsonFiles | Where-Object { $_ -ne $null })) {
		$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report-full.json' -NewSuffix '-report-full-new.json'
		$destPath = Join-Path $reviewDest $newName

		try {
			$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath
			if ($copied) {
				$step2NewJson.Copied.Add("$($file.Name)  ->  $newName")
				Write-Host "Copied NEW JSON: $($file.Name) -> $newName"
			}
			else {
				$step2NewJson.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
				Write-Host "Skipped NEW JSON (up-to-date): $($file.Name)"
			}
		}
		catch {
			$step2NewJson.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
			Write-Warning "FAILED (NEW JSON): $($file.FullName). Error: $($_.Exception.Message)"
		}
	}

	# NEW CSV (rename to *-report-new.csv)
	$newCsvFiles = Get-ChildItem -LiteralPath $currentSource -File -Filter '*-report.csv'
	foreach ($file in ($newCsvFiles | Where-Object { $_ -ne $null })) {
		$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report.csv' -NewSuffix '-report-new.csv'
		$destPath = Join-Path $reviewDest $newName

		try {
			$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath
			if ($copied) {
				$step2NewCsv.Copied.Add("$($file.Name)  ->  $newName")
				Write-Host "Copied NEW CSV: $($file.Name) -> $newName"
			}
			else {
				$step2NewCsv.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
				Write-Host "Skipped NEW CSV (up-to-date): $($file.Name)"
			}
		}
		catch {
			$step2NewCsv.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
			Write-Warning "FAILED (NEW CSV): $($file.FullName). Error: $($_.Exception.Message)"
		}
	}
}
else {
	$msg = "Current folder not found: $currentSource"
	$step2NewJson.Failed.Add($msg)
	$step2NewCsv.Failed.Add($msg)
	Write-Warning $msg
}

# ----------------------------
# Print summaries
# ----------------------------
Print-StepSummary -Title "Step 1 (CSV -report.csv with Archive bit -> Charts\\Data)" -Summary $step1

Print-StepSummary -Title "Step 2a OLD JSON (*-report-full-old.json)" -Summary $step2OldJson
Print-StepSummary -Title "Step 2a OLD CSV  (*-report-old.csv)"      -Summary $step2OldCsv

Print-StepSummary -Title "Step 2b NEW JSON (*-report-full-new.json)" -Summary $step2NewJson
Print-StepSummary -Title "Step 2b NEW CSV  (*-report-new.csv)"       -Summary $step2NewCsv

Write-Host "`nDone."
