<# 
Spargine benchmark file mover (copy only if missing/older + summary)

Step 1:
- Copy *-report.csv files that have the Archive attribute set
  from: D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results
  to:   D:\src\GitHub\dotNetTips.Spargine.10\docs\Charts\Data
- Copy ONLY if destination is missing OR destination LastWriteTime is older than source.
- After a successful copy, clear the Archive bit on the source file.

Step 2:
- Copy *-report-full.json files from Archive\2026JAN to D:\temp\sparginereview as *-report-full-old.json
- Copy *-report-full.json files from current Benchmark Results to D:\temp\sparginereview as *-report-full-new.json
- Copy ONLY if destination is missing OR destination LastWriteTime is older than source.

Summary:
- Counts and lists of Copied / Skipped / Failed for each step.
#>

$ErrorActionPreference = 'Stop'

# ----------------------------
# Paths
# ----------------------------
$sourceRoot          = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results'
$destCsv             = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Charts\Data'

$archiveJsonSource   = Join-Path $sourceRoot 'Archive\2026JAN'
$currentJsonSource   = $sourceRoot
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
	# Copy if destination is older than source (strictly)
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
		Copied = New-Object System.Collections.Generic.List[string]
		Skipped = New-Object System.Collections.Generic.List[string]
		Failed = New-Object System.Collections.Generic.List[string]
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
# Step 2 - OLD
# ----------------------------
$step2Old = New-StepSummary

Write-Host ""
Write-Host "=== Step 2a: Copy OLD full JSON reports (Archive\\2026JAN) - only if missing/older ==="

if (Test-Path -LiteralPath $archiveJsonSource) {
	$oldJsonFiles = Get-ChildItem -LiteralPath $archiveJsonSource -File -Filter '*-report-full.json'

	if (-not $oldJsonFiles -or $oldJsonFiles.Count -eq 0) {
		Write-Host "No '*-report-full.json' found in archive folder: $archiveJsonSource"
	}
	else {
		foreach ($file in $oldJsonFiles) {
			$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report-full.json' -NewSuffix '-report-full-old.json'
			$destPath = Join-Path $reviewDest $newName

			try {
				$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath

				if ($copied) {
					$step2Old.Copied.Add("$($file.Name)  ->  $newName")
					Write-Host "Copied OLD: $($file.Name) -> $newName"
				}
				else {
					$step2Old.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
					Write-Host "Skipped OLD (up-to-date): $($file.Name)"
				}
			}
			catch {
				$step2Old.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
				Write-Warning "FAILED (OLD): $($file.FullName). Error: $($_.Exception.Message)"
			}
		}
	}
}
else {
	$step2Old.Failed.Add("Archive folder not found: $archiveJsonSource")
	Write-Warning "Archive folder not found: $archiveJsonSource"
}

# ----------------------------
# Step 2 - NEW
# ----------------------------
$step2New = New-StepSummary

Write-Host ""
Write-Host "=== Step 2b: Copy NEW full JSON reports (current) - only if missing/older ==="

if (Test-Path -LiteralPath $currentJsonSource) {
	$newJsonFiles = Get-ChildItem -LiteralPath $currentJsonSource -File -Filter '*-report-full.json'

	if (-not $newJsonFiles -or $newJsonFiles.Count -eq 0) {
		Write-Host "No '*-report-full.json' found in current folder: $currentJsonSource"
	}
	else {
		foreach ($file in $newJsonFiles) {
			$newName  = Rename-Suffix -FileName $file.Name -OldSuffix '-report-full.json' -NewSuffix '-report-full-new.json'
			$destPath = Join-Path $reviewDest $newName

			try {
				$copied = Copy-IfMissingOrOlder -SourceFile $file -DestinationPath $destPath

				if ($copied) {
					$step2New.Copied.Add("$($file.Name)  ->  $newName")
					Write-Host "Copied NEW: $($file.Name) -> $newName"
				}
				else {
					$step2New.Skipped.Add("$($file.Name)  ->  $newName  (destination up-to-date)")
					Write-Host "Skipped NEW (up-to-date): $($file.Name)"
				}
			}
			catch {
				$step2New.Failed.Add("$($file.FullName)  Error: $($_.Exception.Message)")
				Write-Warning "FAILED (NEW): $($file.FullName). Error: $($_.Exception.Message)"
			}
		}
	}
}
else {
	$step2New.Failed.Add("Current folder not found: $currentJsonSource")
	Write-Warning "Current folder not found: $currentJsonSource"
}

# ----------------------------
# Print summaries
# ----------------------------
Print-StepSummary -Title "Step 1 (CSV -report.csv with Archive bit)" -Summary $step1
Print-StepSummary -Title "Step 2a (OLD JSON -report-full-old.json)" -Summary $step2Old
Print-StepSummary -Title "Step 2b (NEW JSON -report-full-new.json)" -Summary $step2New

Write-Host "`nDone."
