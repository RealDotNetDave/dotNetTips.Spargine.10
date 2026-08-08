## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperDownloadFileFromWebAsyncBenchmark.DownloadFileFromWebAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFB3565EE68]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFB357070F0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.BenchmarkTests.IO.FileHelperDownloadFileFromWebAsyncBenchmark+<DownloadFileFromWebAsync>d__11, DotNetTips.Spargine.BenchmarkTests]](<DownloadFileFromWebAsync>d__11 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFB3565EE80]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
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
       call      qword ptr [7FFB3570DE00]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFB3570DE18]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
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
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.BenchmarkTests.IO.FileHelperDownloadFileFromWebAsyncBenchmark+<DownloadFileFromWebAsync>d__11, DotNetTips.Spargine.BenchmarkTests]](<DownloadFileFromWebAsync>d__11 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFB35707108]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.BenchmarkTests.IO.FileHelperDownloadFileFromWebAsyncBenchmark+<DownloadFileFromWebAsync>d__11, DotNetTips.Spargine.BenchmarkTests]](<DownloadFileFromWebAsync>d__11 ByRef)
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
       mov       rcx,7FFB35A0A080
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFB35A0A084
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFB35A0A080
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB3596F708]
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
       jmp       qword ptr [7FFB3570DE60]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```

