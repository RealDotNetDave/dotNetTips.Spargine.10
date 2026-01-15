<# 
.SYNOPSIS
  Runs dotnet format, grabs the JSON report, and exports findings to Excel (skipping ENDOFLINE).

.DESCRIPTION
  - Runs: dotnet format <solution> --report <reportDir> --no-restore
    (NOTE: --report produces a JSON report per Microsoft docs; it is NOT SARIF.)
  - Converts the report JSON to an .xlsx using ImportExcel
  - Ignores DiagnosticId = ENDOFLINE (configurable)

PREREQS
  Install ImportExcel once:
    Install-Module ImportExcel -Scope CurrentUser

USAGE
  .\Run-DotNetFormat-To-Excel.ps1
  .\Run-DotNetFormat-To-Excel.ps1 -SolutionPath .\dotnettips.spargine.10.sln -ExcelPath .\CodeAnalysisResults.xlsx
#>

[CmdletBinding()]
param(
  [string]$SolutionPath = "dotnettips.spargine.10.sln",
  [string]$ReportDir    = (Join-Path $env:TEMP "dotnet-format-analyzers-report"),
  [string]$ExcelPath    = "CodeAnalysisResults.xlsx",
  [string[]]$IgnoreDiagnosticIds = @("ENDOFLINE")
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Require-Command([string]$Name) {
  if (-not (Get-Command $Name -ErrorAction SilentlyContinue)) {
    throw "Required command not found: $Name"
  }
}

Require-Command "dotnet"

if (-not (Get-Module -ListAvailable -Name ImportExcel)) {
  throw "Missing module 'ImportExcel'. Install it with: Install-Module ImportExcel -Scope CurrentUser"
}

# Prep report directory
if (Test-Path $ReportDir) { Remove-Item $ReportDir -Recurse -Force }
New-Item -ItemType Directory -Path $ReportDir | Out-Null

Write-Host "Running: dotnet format analyzers ..."
Write-Host "  Solution : $SolutionPath"
Write-Host "  ReportDir: $ReportDir"

& dotnet format analyzers $SolutionPath --report $ReportDir --no-restore
$exitCode = $LASTEXITCODE

# Find JSON report (dotnet format writes format-report.json in this mode too)
$reportFile = Join-Path $ReportDir "format-report.json"
if (-not (Test-Path $reportFile)) {
  $reportFile = Get-ChildItem -Path $ReportDir -Filter *.json |
    Sort-Object LastWriteTime -Descending |
    Select-Object -First 1 |
    ForEach-Object { $_.FullName }

  if (-not $reportFile) {
    throw "No JSON report found in '$ReportDir'."
  }
}

Write-Host "Parsing report: $reportFile"
$data = Get-Content -Path $reportFile -Raw -Encoding UTF8 | ConvertFrom-Json

# Convert to rows (supports the same file+diagnostics structure)
$rows = New-Object System.Collections.Generic.List[object]

foreach ($fileEntry in @($data)) {
  $fileName = $fileEntry.FileName
  $filePath = $fileEntry.FilePath

  foreach ($chg in @($fileEntry.FileChanges)) {
    $diag = $chg.DiagnosticId
    if ($IgnoreDiagnosticIds -contains $diag) { continue }

    $rows.Add([pscustomobject]@{
      FileName     = $fileName
      FilePath     = $filePath
      LineNumber   = $chg.LineNumber
      CharNumber   = $chg.CharNumber
      DiagnosticId = $diag
      Description  = $chg.FormatDescription
    })
  }
}

Write-Host ("Extracted {0} findings (after ignores)." -f $rows.Count)

# Summaries
$summaryByDiag = $rows |
  Group-Object DiagnosticId |
  Sort-Object Count -Descending |
  Select-Object @{n="DiagnosticId";e={$_.Name}}, Count

$summaryByFile = $rows |
  Group-Object FilePath |
  Sort-Object Count -Descending |
  Select-Object @{n="FilePath";e={$_.Name}}, Count

# Write Excel
if (Test-Path $ExcelPath) { Remove-Item $ExcelPath -Force }

$rows | Export-Excel -Path $ExcelPath -WorksheetName "Findings" -AutoSize -BoldTopRow -FreezeTopRow -AutoFilter
$summaryByDiag | Export-Excel -Path $ExcelPath -WorksheetName "SummaryByDiagnostic" -AutoSize -BoldTopRow -FreezeTopRow -AutoFilter
$summaryByFile | Export-Excel -Path $ExcelPath -WorksheetName "SummaryByFile" -AutoSize -BoldTopRow -FreezeTopRow -AutoFilter

Write-Host "Excel written: $ExcelPath"
exit $exitCode