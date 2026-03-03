dotnet clean D:\src\GitHub\dotNetTips.Spargine.10\dotNetTips.Spargine.10.sln

dotnet build D:\src\GitHub\dotNetTips.Spargine.10\dotNetTips.Spargine.10.sln --configuration Release

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.10\source\dotNetTips.Spargine.10.Core\DotNetTips.Spargine.10.Core.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.10\source\dotNetTips.Spargine.10.Extensions\DotNetTips.Spargine.10.Extensions.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.10\source\dotNetTips.Spargine.10.Tester\DotNetTips.Spargine.10.Tester.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.10\source\dotNetTips.Spargine.10\DotNetTips.Spargine.10.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"