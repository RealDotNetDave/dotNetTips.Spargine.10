## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark.GetRecordCountAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB5887BE8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB5887BD0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountAsync>d__12 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB5887C00]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C26430]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFBB4C26448]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountAsync>d__12 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBB5887C18]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountAsync>d__12 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFBB613CA38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFBB613CA3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFBB613CA38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB6056388]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFBB5E9E0A0]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark.GetRecordCountWithPredicateAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB5897348]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB5897330]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountWithPredicateAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountWithPredicateAsync>d__13 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB5897360]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C363B8]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFBB4C363D0]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountWithPredicateAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountWithPredicateAsync>d__13 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBB5897378]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<GetRecordCountWithPredicateAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<GetRecordCountWithPredicateAsync>d__13 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFBB626FD88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFBB626FD8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFBB626FD88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB6234BB8]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFBB6006DF0]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark.HasRecordsAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB58D77C8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB58D77B0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsAsync>d__15, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsAsync>d__15 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB58D77E0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C66820]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFBB4C66838]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsAsync>d__15, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsAsync>d__15 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBB58D77F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsAsync>d__15, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsAsync>d__15 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFBB6231540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFBB6231544
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFBB6231540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB6117768]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFBB5F7E7C0]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark.HasRecordsWithPredicateAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB58B7C48]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB58B7C30]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsWithPredicateAsync>d__16, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsWithPredicateAsync>d__16 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB58B7C60]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C46CA0]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFBB4C46CB8]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsWithPredicateAsync>d__16, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsWithPredicateAsync>d__16 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBB58B7C78]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<HasRecordsWithPredicateAsync>d__16, DotNetTips.Spargine.Extensions.BenchmarkTests]](<HasRecordsWithPredicateAsync>d__16 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFBB6242EF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFBB6242EF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFBB6242EF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB5FEF2A0]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFBB5FE55D8]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark.AddAndSaveAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB56E65E0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB56E65C8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<AddAndSaveAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<AddAndSaveAsync>d__7 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFBB56E65F8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C66CE8]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFBB4C66D00]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<AddAndSaveAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<AddAndSaveAsync>d__7 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBB56E6610]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DbContextExtensionsBenchmark+<AddAndSaveAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<AddAndSaveAsync>d__7 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFBB5DF3420
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFBB5DF3424
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFBB5DF3420
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB5B67A80]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFBB581F900]
; Total bytes of code 29
```

