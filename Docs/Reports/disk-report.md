# Disk Usage Report

```text

Crank it up! Auditing disk hogs in 'D:\src\GitHub\dotNetTips.Spargine.10': NuGet cache, bin/obj folders, global tools, 
and Docker...


                NuGet Package Cache                 
╭────────────────────────────────────────┬─────────╮
│ NuGet Package Cache                    │ Size    │
├────────────────────────────────────────┼─────────┤
│ azure.core                             │ 0 Bytes │
│ azure.monitor.opentelemetry.exporter   │ 0 Bytes │
│ bouncycastle.cryptography              │ 0 Bytes │
│ dotnettips.spargine.10                 │ 0 Bytes │
│ dotnettips.spargine.10.core            │ 0 Bytes │
│ dotnettips.spargine.10.extensions      │ 0 Bytes │
│ idisposableanalyzers                   │ 0 Bytes │
│ konscious.security.cryptography.argon2 │ 0 Bytes │
│ konscious.security.cryptography.blake2 │ 0 Bytes │
│ linq2db                                │ 0 Bytes │
╰────────────────────────────────────────┴─────────╯

Total NuGet cache: 0 Bytes across 88 package(s)

          Global .NET Tools          
╭───────────────────────┬───────────╮
│ Global .NET Tools     │ Size      │
├───────────────────────┼───────────┤
│ complog.exe           │ 157 KB    │
│ dotnet-coverage.exe   │ 159 KB    │
│ dotnet-format.exe     │ 145.38 KB │
│ reportgenerator.exe   │ 177 KB    │
│ spargine.exe          │ 159 KB    │
│ upgrade-assistant.exe │ 138 KB    │
╰───────────────────────┴───────────╯

Total global tools: 935.38 KB

                                                   bin / obj Folders                                                    
╭──────────────────────────────────────────────────────────────────────────────────────────────────────────┬───────────╮
│ Folder                                                                                                   │ Size      │
├──────────────────────────────────────────────────────────────────────────────────────────────────────────┼───────────┤
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\DotNetTips.Spargine.10.Benchmarking.Tests\obj     │ 615.09 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Benchmarking\dotNetTips.Spargine.10.Benchmarking\obj         │ 451.81 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Benchmarking\dotNetTips.Spargine.BenchmarkTests\obj          │ 401.89 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Benchmarking\dotNetTips.Spargine.Extensions.BenchmarkTests\o │ 390.4 KB  │
│ bj                                                                                                       │           │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Benchmarking\dotNetTips.Spargine.Tester.Benchmarking\obj     │ 370.61 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Benchmarking\dotNetTips.Spargine.Core.BenchmarkTests\obj     │ 370.59 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\dotNetTips.Spargine.Tests\obj                     │ 370.43 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\dotNetTips.Spargine.Extensions.Tests\obj          │ 354.42 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\dotNetTips.Spargine.Tester.Tests\obj              │ 334.43 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\dotNetTips.Spargine.Core.Tests\obj                │ 301.56 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\dotNetTips.Spargine.10.Tester\obj                            │ 232.14 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\dotNetTips.Spargine.10\obj                                   │ 229.98 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\dotNetTips.Spargine.10.Extensions\obj                        │ 211.66 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\dotNetTips.Spargine.10.Core\obj                              │ 131.33 KB │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-12\bin                                    │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-2\bin                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-4\bin                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-5\bin                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-7\bin                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\Source\Unit Tests\DotNetTips.Spargine.10.Benchmarking.Tests\bin     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-12\obj                                    │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-2\obj                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-4\obj                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-5\obj                                     │ 0 Bytes   │
│ D:\src\GitHub\dotNetTips.Spargine.10\AppBin\net10.0\Job-PSYKRA-7\obj                                     │ 0 Bytes   │
╰──────────────────────────────────────────────────────────────────────────────────────────────────────────┴───────────╯

Total across 25 bin/obj folder(s): 4.65 MB
Docker's asleep backstage — the engine isn't running. Fire up Docker Desktop and try again.

Disk audit is in the vault — rocked out in 0.8 seconds.
```
