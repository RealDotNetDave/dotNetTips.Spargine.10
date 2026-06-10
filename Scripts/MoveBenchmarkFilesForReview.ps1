<#
Spargine benchmark file mover

This version does NOT depend on the Windows Archive file attribute.
BenchmarkDotNet does not reliably set that bit when it generates report files.

Important JSON behavior:
- Older BenchmarkDotNet JSON files can end with:  -report-full.json
- Newer/current BenchmarkDotNet JSON files can end with: -report.json
- This script supports both.

Step 1:
- Copy current *-report.csv files from Benchmark Results into docs\Charts\Data.
- Current files are discovered recursively under Benchmark Results.
- Anything under Benchmark Results\Archive is excluded.

Step 2:
- OLD reports are copied from Benchmark Results\Archive\2026APR into D:\temp\sparginebenchmarkreview.
  - *-report-full.json becomes *-report-full-old.json
  - *-report.json      becomes *-report-old.json
  - *-report.csv       becomes *-report-old.csv
- NEW reports are copied from Benchmark Results into D:\temp\sparginebenchmarkreview.
  - *-report-full.json becomes *-report-full-new.json
  - *-report.json      becomes *-report-new.json
  - *-report.csv       becomes *-report-new.csv
- NEW reports are discovered recursively under Benchmark Results.
- Anything under Benchmark Results\Archive is excluded from the NEW report set.

By default, files are copied only when the destination is missing or older than the source.
Use -ForceCopy to overwrite matching destination files regardless of timestamp.
#>

[CmdletBinding()]
param(
	[string]$SourceRoot = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results',
	[string]$ChartsDataDestination = 'D:\src\GitHub\dotNetTips.Spargine.10\docs\Charts\Data',
	[string]$ArchiveFolderName = '2026APR',
	[string]$ReviewDestination = 'D:\temp\sparginebenchmarkreview',
	[switch]$ForceCopy
)

$ErrorActionPreference = 'Stop'

# ----------------------------
# Paths
# ----------------------------
$archiveRoot = Join-Path $SourceRoot 'Archive'
$oldSource = Join-Path $archiveRoot $ArchiveFolderName
$currentSource = $SourceRoot

# ----------------------------
# Helpers
# ----------------------------
function Ensure-Directory {
	param(
		[Parameter(Mandatory = $true)]
		[string]$Path
	)

	if (-not (Test-Path -LiteralPath $Path)) {
		New-Item -ItemType Directory -Path $Path | Out-Null
	}
}

function Rename-Suffix {
	param(
		[Parameter(Mandatory = $true)]
		[string]$FileName,

		[Parameter(Mandatory = $true)]
		[string]$OldSuffix,

		[Parameter(Mandatory = $true)]
		[string]$NewSuffix
	)

	if ($FileName.EndsWith($OldSuffix, [System.StringComparison]::OrdinalIgnoreCase)) {
		return $FileName.Substring(0, $FileName.Length - $OldSuffix.Length) + $NewSuffix
	}

	return $null
}

function Get-ReviewJsonName {
	param(
		[Parameter(Mandatory = $true)]
		[string]$FileName,

		[Parameter(Mandatory = $true)]
		[ValidateSet('old', 'new')]
		[string]$Kind
	)

	# Match the most specific suffix first.
	if ($FileName.EndsWith('-report-full.json', [System.StringComparison]::OrdinalIgnoreCase)) {
		return (Rename-Suffix -FileName $FileName -OldSuffix '-report-full.json' -NewSuffix "-report-full-$Kind.json")
	}

	if ($FileName.EndsWith('-report.json', [System.StringComparison]::OrdinalIgnoreCase)) {
		return (Rename-Suffix -FileName $FileName -OldSuffix '-report.json' -NewSuffix "-report-$Kind.json")
	}

	return $null
}

function Get-ReviewCsvName {
	param(
		[Parameter(Mandatory = $true)]
		[string]$FileName,

		[Parameter(Mandatory = $true)]
		[ValidateSet('old', 'new')]
		[string]$Kind
	)

	return (Rename-Suffix -FileName $FileName -OldSuffix '-report.csv' -NewSuffix "-report-$Kind.csv")
}

function Should-CopyFile {
	param(
		[Parameter(Mandatory = $true)]
		[System.IO.FileInfo]$SourceFile,

		[Parameter(Mandatory = $true)]
		[string]$DestinationPath,

		[switch]$ForceCopy
	)

	if ($ForceCopy) {
		return $true
	}

	if (-not (Test-Path -LiteralPath $DestinationPath)) {
		return $true
	}

	$destinationFile = Get-Item -LiteralPath $DestinationPath
	return $destinationFile.LastWriteTime -lt $SourceFile.LastWriteTime
}

function Copy-IfNeeded {
	param(
		[Parameter(Mandatory = $true)]
		[System.IO.FileInfo]$SourceFile,

		[Parameter(Mandatory = $true)]
		[string]$DestinationPath,

		[switch]$ForceCopy
	)

	if (Should-CopyFile -SourceFile $SourceFile -DestinationPath $DestinationPath -ForceCopy:$ForceCopy) {
		Copy-Item -LiteralPath $SourceFile.FullName -Destination $DestinationPath -Force
		return $true
	}

	return $false
}

function Test-IsUnderDirectory {
	param(
		[Parameter(Mandatory = $true)]
		[string]$Path,

		[Parameter(Mandatory = $true)]
		[string]$Directory
	)

	if ([string]::IsNullOrWhiteSpace($Directory)) {
		return $false
	}

	$fullPath = [System.IO.Path]::GetFullPath($Path)
	$fullDirectory = [System.IO.Path]::GetFullPath($Directory).TrimEnd(
		[System.IO.Path]::DirectorySeparatorChar,
		[System.IO.Path]::AltDirectorySeparatorChar
	)

	$directoryPrefix = $fullDirectory + [System.IO.Path]::DirectorySeparatorChar

	return $fullPath.StartsWith($directoryPrefix, [System.StringComparison]::OrdinalIgnoreCase)
}

function Get-BenchmarkReportFiles {
	param(
		[Parameter(Mandatory = $true)]
		[string]$Path,

		[Parameter(Mandatory = $true)]
		[string[]]$Filters,

		[string]$ExcludeDirectory
	)

	if (-not (Test-Path -LiteralPath $Path)) {
		return
	}

	$resultsByPath = [ordered]@{}

	foreach ($filter in $Filters) {
		Get-ChildItem -LiteralPath $Path -File -Filter $filter -Recurse -ErrorAction Stop |
			Where-Object {
				[string]::IsNullOrWhiteSpace($ExcludeDirectory) -or
				-not (Test-IsUnderDirectory -Path $_.FullName -Directory $ExcludeDirectory)
			} |
			ForEach-Object {
				if (-not $resultsByPath.Contains($_.FullName)) {
					$resultsByPath.Add($_.FullName, $_)
				}
			}
	}

	foreach ($entry in $resultsByPath.GetEnumerator()) {
		$entry.Value
	}
}

function New-StepSummary {
	return [ordered]@{
		Copied  = New-Object System.Collections.Generic.List[string]
		Skipped = New-Object System.Collections.Generic.List[string]
		Failed  = New-Object System.Collections.Generic.List[string]
	}
}

function Add-CopyResult {
	param(
		[Parameter(Mandatory = $true)]
		$Summary,

		[Parameter(Mandatory = $true)]
		[System.IO.FileInfo]$SourceFile,

		[Parameter(Mandatory = $true)]
		[string]$DestinationPath,

		[Parameter(Mandatory = $true)]
		[string]$DisplayName,

		[switch]$ForceCopy
	)

	try {
		$copied = Copy-IfNeeded -SourceFile $SourceFile -DestinationPath $DestinationPath -ForceCopy:$ForceCopy

		if ($copied) {
			$Summary.Copied.Add("$($SourceFile.FullName)  ->  $DestinationPath")
			Write-Host "Copied ${DisplayName}: $($SourceFile.FullName) -> $DestinationPath"
		}
		else {
			$Summary.Skipped.Add("$($SourceFile.FullName)  ->  $DestinationPath  (destination up-to-date)")
			Write-Host "Skipped ${DisplayName}: destination is up-to-date: $($SourceFile.FullName)"
		}
	}
	catch {
		$Summary.Failed.Add("$($SourceFile.FullName)  Error: $($_.Exception.Message)")
		Write-Warning "FAILED ${DisplayName}: $($SourceFile.FullName). Error: $($_.Exception.Message)"
	}
}

function Print-StepSummary {
	param(
		[Parameter(Mandatory = $true)]
		[string]$Title,

		[Parameter(Mandatory = $true)]
		$Summary
	)

	Write-Host ''
	Write-Host "=== Summary: $Title ==="
	Write-Host ('Copied : {0}' -f $Summary.Copied.Count)
	Write-Host ('Skipped: {0}' -f $Summary.Skipped.Count)
	Write-Host ('Failed : {0}' -f $Summary.Failed.Count)

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

function Print-DiscoveredFiles {
	param(
		[Parameter(Mandatory = $true)]
		[string]$Label,

		[AllowNull()]
		[object[]]$Files
	)

	if ($null -eq $Files) {
		$safeFiles = @()
	}
	else {
		$safeFiles = @($Files | Where-Object { $null -ne $_ })
	}

	Write-Host ('{0}: {1} file(s) found.' -f $Label, $safeFiles.Count)

	foreach ($file in $safeFiles) {
		Write-Host "  $($file.FullName)"
	}
}

# ----------------------------
# Setup
# ----------------------------
Write-Host '=== Spargine benchmark file mover ==='
Write-Host "Source root       : $SourceRoot"
Write-Host "Archive root      : $archiveRoot"
Write-Host "Old source        : $oldSource"
Write-Host "Charts/Data dest  : $ChartsDataDestination"
Write-Host "Review destination: $ReviewDestination"
Write-Host "Force copy        : $ForceCopy"
Write-Host ''

Ensure-Directory -Path $ChartsDataDestination
Ensure-Directory -Path $ReviewDestination

# ----------------------------
# Step 1: current CSV reports -> Charts\Data
# ----------------------------
$step1 = New-StepSummary

Write-Host '=== Step 1: Copy current CSV reports to Charts\Data ==='
Write-Host 'Current CSV discovery is recursive and excludes Benchmark Results\Archive.'

$currentCsvFiles = @(Get-BenchmarkReportFiles -Path $currentSource -Filters @('*-report.csv') -ExcludeDirectory $archiveRoot)
Print-DiscoveredFiles -Label 'Current CSV reports' -Files $currentCsvFiles

foreach ($file in $currentCsvFiles) {
	$destinationPath = Join-Path $ChartsDataDestination $file.Name
	Add-CopyResult -Summary $step1 -SourceFile $file -DestinationPath $destinationPath -DisplayName 'current CSV for Charts/Data' -ForceCopy:$ForceCopy
}

# ----------------------------
# Step 2a: OLD reports from Archive\2026APR
# ----------------------------
$step2OldJson = New-StepSummary
$step2OldCsv  = New-StepSummary

Write-Host ''
Write-Host "=== Step 2a: Copy OLD reports from Archive\$ArchiveFolderName ==="

if (-not (Test-Path -LiteralPath $oldSource)) {
	$message = "Old benchmark source folder not found: $oldSource"
	$step2OldJson.Failed.Add($message)
	$step2OldCsv.Failed.Add($message)
	Write-Warning $message
}
else {
	$oldJsonFiles = @(Get-BenchmarkReportFiles -Path $oldSource -Filters @('*-report-full.json', '*-report.json'))
	Print-DiscoveredFiles -Label 'OLD JSON reports' -Files $oldJsonFiles

	foreach ($file in $oldJsonFiles) {
		$newName = Get-ReviewJsonName -FileName $file.Name -Kind 'old'

		if ([string]::IsNullOrWhiteSpace($newName)) {
			$step2OldJson.Skipped.Add("$($file.FullName)  (unsupported JSON report suffix)")
			Write-Host "Skipped OLD JSON with unsupported suffix: $($file.FullName)"
			continue
		}

		$destinationPath = Join-Path $ReviewDestination $newName
		Add-CopyResult -Summary $step2OldJson -SourceFile $file -DestinationPath $destinationPath -DisplayName 'OLD JSON' -ForceCopy:$ForceCopy
	}

	$oldCsvFiles = @(Get-BenchmarkReportFiles -Path $oldSource -Filters @('*-report.csv'))
	Print-DiscoveredFiles -Label 'OLD CSV reports' -Files $oldCsvFiles

	foreach ($file in $oldCsvFiles) {
		$newName = Get-ReviewCsvName -FileName $file.Name -Kind 'old'
		$destinationPath = Join-Path $ReviewDestination $newName
		Add-CopyResult -Summary $step2OldCsv -SourceFile $file -DestinationPath $destinationPath -DisplayName 'OLD CSV' -ForceCopy:$ForceCopy
	}
}

# ----------------------------
# Step 2b: NEW reports from current Benchmark Results folder, recursive, excluding Archive
# ----------------------------
$step2NewJson = New-StepSummary
$step2NewCsv  = New-StepSummary

Write-Host ''
Write-Host '=== Step 2b: Copy NEW reports from current Benchmark Results folder ==='
Write-Host 'NEW report discovery is recursive and excludes Benchmark Results\Archive.'
Write-Host 'NEW JSON discovery supports both *-report-full.json and *-report.json.'

$newJsonFiles = @(Get-BenchmarkReportFiles -Path $currentSource -Filters @('*-report-full.json', '*-report.json') -ExcludeDirectory $archiveRoot)
Print-DiscoveredFiles -Label 'NEW JSON reports' -Files $newJsonFiles

foreach ($file in $newJsonFiles) {
	$newName = Get-ReviewJsonName -FileName $file.Name -Kind 'new'

	if ([string]::IsNullOrWhiteSpace($newName)) {
		$step2NewJson.Skipped.Add("$($file.FullName)  (unsupported JSON report suffix)")
		Write-Host "Skipped NEW JSON with unsupported suffix: $($file.FullName)"
		continue
	}

	$destinationPath = Join-Path $ReviewDestination $newName
	Add-CopyResult -Summary $step2NewJson -SourceFile $file -DestinationPath $destinationPath -DisplayName 'NEW JSON' -ForceCopy:$ForceCopy
}

$newCsvFiles = @(Get-BenchmarkReportFiles -Path $currentSource -Filters @('*-report.csv') -ExcludeDirectory $archiveRoot)
Print-DiscoveredFiles -Label 'NEW CSV reports' -Files $newCsvFiles

foreach ($file in $newCsvFiles) {
	$newName = Get-ReviewCsvName -FileName $file.Name -Kind 'new'
	$destinationPath = Join-Path $ReviewDestination $newName
	Add-CopyResult -Summary $step2NewCsv -SourceFile $file -DestinationPath $destinationPath -DisplayName 'NEW CSV' -ForceCopy:$ForceCopy
}

# ----------------------------
# Print summaries
# ----------------------------
Print-StepSummary -Title 'Step 1 current CSV -> Charts\Data' -Summary $step1

Print-StepSummary -Title 'Step 2a OLD JSON -> *-report-full-old.json or *-report-old.json' -Summary $step2OldJson
Print-StepSummary -Title 'Step 2a OLD CSV  -> *-report-old.csv' -Summary $step2OldCsv

Print-StepSummary -Title 'Step 2b NEW JSON -> *-report-full-new.json or *-report-new.json' -Summary $step2NewJson
Print-StepSummary -Title 'Step 2b NEW CSV  -> *-report-new.csv' -Summary $step2NewCsv

Write-Host "`nDone."
