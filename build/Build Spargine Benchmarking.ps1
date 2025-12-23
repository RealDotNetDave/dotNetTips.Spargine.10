dotnet clean D:\src\GitHub\dotNetTips.Spargine.10\dotNetTips.Spargine.10.Benchmarking.sln

dotnet build D:\src\GitHub\dotNetTips.Spargine.10\dotNetTips.Spargine.10.Benchmarking.sln --configuration Release

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.10\source\Benchmarking\dotNetTips.Spargine.10.Benchmarking\DotNetTips.Spargine.10.Benchmarking.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

