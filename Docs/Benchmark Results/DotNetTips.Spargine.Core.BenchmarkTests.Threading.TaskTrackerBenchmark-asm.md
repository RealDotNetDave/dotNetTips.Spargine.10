## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.RegisterDuplicatePending()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B8]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577C69A0]; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFD574C1DE0]; Precode of DotNetTips.Spargine.Core.Threading.TaskTracker.Register(System.Threading.Tasks.Task, System.Action`1<System.Exception>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 88
```
```assembly
; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.RegisterPendingWithCallback()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B0]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57806E50]; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       [rbp-18],rax
       mov       rax,1C573C001E8
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-10],0
       jne       short M00_L00
       mov       rcx,7FFD57A0B7E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Action<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rax,1C573C001E0
       mov       rdx,[rax]
       mov       rcx,[rbp-38]
       mov       r8,7FFD5780B2B8
       call      qword ptr [7FFD571C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       rcx,1C573C001E8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-38]
       mov       [rbp-30],rax
M00_L00:
       mov       rcx,7FFD57A0B7EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFD574E1DE0]; Precode of DotNetTips.Spargine.Core.Threading.TaskTracker.Register(System.Threading.Tasks.Task, System.Action`1<System.Exception>)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 256
```
```assembly
; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FFD5799BEFC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FFD5799BEF8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFD579A4618]
       int       3
; Total bytes of code 82
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.RegisterPending()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B0]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577D6E80]; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFD574B1DE0]; Precode of DotNetTips.Spargine.Core.Threading.TaskTracker.Register(System.Threading.Tasks.Task, System.Action`1<System.Exception>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 88
```
```assembly
; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.UnregisterByTask()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B8]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577E69E8]; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD574D1D08]; Precode of DotNetTips.Spargine.Core.Threading.TaskTracker.Unregister(System.Threading.Tasks.Task)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.TaskCompletionSource.get_Task()
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.UnregisterByKey()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+1C0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD574B22F0]; Precode of DotNetTips.Spargine.Core.Threading.TaskTracker.Unregister(DotNetTips.Spargine.Core.Ulid)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 51
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.WaitEmptyAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFD5780F330]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD5780F318]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitEmptyAsync>d__14, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitEmptyAsync>d__14 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD5780F348]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Boolean, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Boolean>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5780F7F8]; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFD5780F810]; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitEmptyAsync>d__14, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitEmptyAsync>d__14 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD5780F360]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitEmptyAsync>d__14, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitEmptyAsync>d__14 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFD579FFB80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFD579FFB84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFD579FFB80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFD579A7228]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L01
M06_L00:
       mov       rax,[rbx]
       movzx     eax,byte ptr [rax+38]
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       xor       edx,edx
       call      qword ptr [7FFD579A7990]
       jmp       short M06_L00
; Total bytes of code 51
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.WaitForPendingCompletionAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFD577EF2D0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD577EF2B8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitForPendingCompletionAsync>d__15, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitForPendingCompletionAsync>d__15 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD577EF2E8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Boolean, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Boolean>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577EFED0]; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFD577EFEE8]; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitForPendingCompletionAsync>d__15, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitForPendingCompletionAsync>d__15 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD577EF300]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitForPendingCompletionAsync>d__15, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitForPendingCompletionAsync>d__15 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFD579EB8E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFD579EB8EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFD579EB8E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFD57987D38]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L01
M06_L00:
       mov       rax,[rbx]
       movzx     eax,byte ptr [rax+38]
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       xor       edx,edx
       call      qword ptr [7FFD5798CF48]
       jmp       short M06_L00
; Total bytes of code 51
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark.WaitPendingZeroTimeoutAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFD577FF2E8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD577FF2D0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitPendingZeroTimeoutAsync>d__16, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitPendingZeroTimeoutAsync>d__16 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFD577FF300]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Boolean, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Boolean>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577FF8D0]; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFD577FF8E8]; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitPendingZeroTimeoutAsync>d__16, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitPendingZeroTimeoutAsync>d__16 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD577FF318]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerBenchmark+<WaitPendingZeroTimeoutAsync>d__16, DotNetTips.Spargine.Core.BenchmarkTests]](<WaitPendingZeroTimeoutAsync>d__16 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Boolean, System.Private.CoreLib]].get_Task()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,7FFD579F1278
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,7FFD579F127C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFD579F1278
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFD57997558]
; Total bytes of code 87
```
```assembly
; System.Threading.Tasks.Task`1[[System.Boolean, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Boolean, System.Private.CoreLib]].GetResult()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L01
M06_L00:
       mov       rax,[rbx]
       movzx     eax,byte ptr [rax+38]
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       xor       edx,edx
       call      qword ptr [7FFD57997FA8]
       jmp       short M06_L00
; Total bytes of code 51
```

