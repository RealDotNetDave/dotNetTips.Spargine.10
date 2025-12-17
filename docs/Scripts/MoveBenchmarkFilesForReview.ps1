# Destination path
$DestinationPath = "D:\temp\benchmarkreview"

# Ensure destination directory exists
if (-not (Test-Path -Path $DestinationPath)) {
    New-Item -Path $DestinationPath -ItemType Directory -Force | Out-Null
}

# -------- .NET 8 --------
$SourcePath8 = "D:\src\GitHub\dotNetTips.Spargine.8\docs\Benchmark Results"

Get-ChildItem -Path $SourcePath8 -Filter "*-report.csv" -File |
    ForEach-Object {
        $NewName = $_.Name -replace '-report\.csv$', '-report.8.csv'
        Copy-Item -Path $_.FullName -Destination (Join-Path $DestinationPath $NewName) -Force
    }

# -------- .NET 10 --------
$SourcePath10 = "D:\src\GitHub\dotNetTips.Spargine.10\docs\Benchmark Results"

Get-ChildItem -Path $SourcePath10 -Filter "*-report.csv" -File |
    ForEach-Object {
        $NewName = $_.Name -replace '-report\.csv$', '-report.10.csv'
        Copy-Item -Path $_.FullName -Destination (Join-Path $DestinationPath $NewName) -Force
    }
