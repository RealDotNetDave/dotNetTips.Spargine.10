#Requires -Version 5.1

<#
.SYNOPSIS
Runs Spargine maintenance commands and generates reports for the current directory.

.DESCRIPTION
Uses the PowerShell working directory when the script is invoked, regardless of
where the script itself is stored. Creates docs\reports if it does not exist.
Runs every command in order and reports any failures after all commands finish.

.EXAMPLE
Set-Location 'C:\Source\MyProject'
& 'C:\Scripts\Invoke-SpargineReports.ps1'
#>

[CmdletBinding()]
param()

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$workingDirectory = Get-Location
if ($workingDirectory.Provider.Name -ne 'FileSystem') {
    throw 'Run this script from a filesystem directory.'
}

$spargineCommand = Get-Command -Name 'spargine' -CommandType Application -ErrorAction Stop
$reportsDirectory = Join-Path -Path (Join-Path -Path $workingDirectory.Path -ChildPath 'Docs') -ChildPath 'Reports'
New-Item -Path $reportsDirectory -ItemType Directory -Force | Out-Null

$commands = @(
    @{ Name = 'audit'; Arguments = @('audit', '--output', (Join-Path $reportsDirectory 'audit-report.md')) }
    @{ Name = 'disk'; Arguments = @('disk', '--output', (Join-Path $reportsDirectory 'disk-report.md')) }
    @{ Name = 'git-status'; Arguments = @('git-status', '--output', (Join-Path $reportsDirectory 'git-status-report.md')) }
    @{ Name = 'gitignore'; Arguments = @('gitignore', '--merge') }
    @{ Name = 'graph'; Arguments = @('graph', '--output', (Join-Path $reportsDirectory 'dependency-graph.mmd')) }
    @{ Name = 'health'; Arguments = @('health', '--output', (Join-Path $reportsDirectory 'health-report.md')) }
    @{ Name = 'metrics'; Arguments = @('metrics', '--output', (Join-Path $reportsDirectory 'metrics-report.md')) }
    @{ Name = 'nuget'; Arguments = @('nuget', '--clear-cache', '--consolidate', '--output', (Join-Path $reportsDirectory 'nuget-report.md')) }
    @{ Name = 'secrets'; Arguments = @('secrets', '--output', (Join-Path $reportsDirectory 'secrets-report.md')) }
)

$failures = [System.Collections.Generic.List[string]]::new()

Write-Host "Working directory: $($workingDirectory.Path)"
Write-Host "Report directory: $reportsDirectory"

foreach ($command in $commands) {
    Write-Host "`nRunning spargine $($command.Name)..."
    $commandArguments = $command.Arguments

    try {
        # Array splatting preserves output paths that contain spaces.
        & $spargineCommand.Source @commandArguments

        if ($LASTEXITCODE -ne 0) {
            $failure = "$($command.Name) (exit code $LASTEXITCODE)"
            $failures.Add($failure)
            Write-Warning "Spargine failed: $failure"
        }
    }
    catch {
        $failure = "$($command.Name): $($_.Exception.Message)"
        $failures.Add($failure)
        Write-Warning "Spargine failed: $failure"
    }
}

if ($failures.Count -gt 0) {
    throw "Spargine finished with $($failures.Count) failed command(s): $($failures -join '; ')"
}

Write-Host "`nAll Spargine commands completed successfully. Reports: $reportsDirectory"
