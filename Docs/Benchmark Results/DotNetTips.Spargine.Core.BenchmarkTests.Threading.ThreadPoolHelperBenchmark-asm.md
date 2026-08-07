## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunAsyncAction()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE1FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-38],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-40],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-48],rdx
       lea       rcx,[rbp-30]
       call      qword ptr [7FFE2D22E1D8]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncAction>d__7.MoveNext()
       nop
       mov       rdx,[rbp-48]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-40]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-40],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-40]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE2D2BCD98]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2B74E0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D2BCE28]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-48]
       mov       rax,[rbp-38]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-38]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-40]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-40],0
       je        short M00_L13
       mov       rdx,[rbp-40]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE2D2BCD98]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 356
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE2D2B4360]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncAction>d__7.MoveNext()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp+10],rcx
       mov       eax,[rcx]
       test      eax,eax
       je        near ptr M03_L09
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rax,217C0000D48
       mov       rax,[rax]
       mov       [rbp-50],rax
       mov       dword ptr [rbp-44],3E8
       xor       eax,eax
       mov       [rbp-38],rax
       mov       dword ptr [rbp-48],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L11
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M03_L01
       call      qword ptr [7FFE2CE1FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M03_L01:
       mov       [rbp-60],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-68],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-70],rdx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE2D22E4A8]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunAsync>d__5.MoveNext()
       nop
       mov       rdx,[rbp-70]
       cmp       rdx,[rbx+10]
       je        short M03_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L03
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L03:
       cmp       qword ptr [rbp-68],0
       jne       short M03_L07
M03_L04:
       mov       rax,[rbp-40]
       test      rax,rax
       je        near ptr M03_L12
M03_L05:
       cmp       [rax],al
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       [rbp-18],ecx
       test      byte ptr [rbp-18],4
       jne       short M03_L06
       mov       rcx,[rbp-20]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L10
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-18]
       mov       rax,[rbp+10]
       mov       [rax+18],edx
       lea       rdx,[rax+8]
       mov       rcx,rax
       call      qword ptr [7FFE2D2B4120]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncAction>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<RunAsyncAction>d__7 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE2D2B4138]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter, System.Private.CoreLib]](ConfiguredTaskAwaiter ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FFE2D2BCD98]
       jmp       near ptr M03_L04
M03_L09:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+10]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-20],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx],0FFFFFFFF
M03_L10:
       mov       rdx,[rbp-20]
       mov       eax,[rbp-18]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       je        short M03_L14
       jmp       short M03_L13
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFE2D2B74E0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D2BCE28]
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFE2D2B4360]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       nop
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx],0FFFFFFFE
       add       rcx,8
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,217C0002290
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-54],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-54]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BCE88]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,217C0000BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE2D22FA68]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M03_L19:
       mov       rdx,217C0000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2B4168]
       mov       edx,eax
       mov       rcx,217C0002290
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2BCF90]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2BCE70]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFE2D2BCFA8]
       int       3
M03_L23:
       call      qword ptr [7FFE2D2BDA88]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFE2D2B7AF8]
       int       3
       sub       rsp,28
       mov       rdx,[rbp-70]
       mov       rax,[rbp-60]
       cmp       rdx,[rax+10]
       je        short M03_L25
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
M03_L25:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rsi
       je        short M03_L28
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L26
       cmp       qword ptr [rsi+10],0
       jne       short M03_L27
M03_L26:
       cmp       qword ptr [rbp-68],0
       je        short M03_L28
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M03_L28
M03_L27:
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FFE2D2BCD98]
M03_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx],0FFFFFFFE
       add       rcx,8
       call      qword ptr [7FFE2D22E2B0]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 947
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2B4378]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BD428]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BD398]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BDB90]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunAsyncBoundedParallelism()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE3FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D24E430]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncBoundedParallelism>d__8.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DCD08]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2D7F00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D2DD188]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DCD08]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 376
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2D52D8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncBoundedParallelism>d__8.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L09
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,25A1E800D68
       mov       rax,[rax]
       mov       [rbp-70],rax
       mov       dword ptr [rbp-54],2
       mov       dword ptr [rbp-50],3E8
       xor       eax,eax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-58],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FFE2CE3FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-88],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-90],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-98],rdx
       lea       rcx,[rbp-70]
       call      qword ptr [7FFE2D24E850]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunAsync>d__6`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-98]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-90]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L08
M03_L03:
       cmp       qword ptr [rbp-90],0
       jne       near ptr M03_L07
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L06
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L10
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8d,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],r8d
       lea       r8,[rax+10]
       mov       rdx,rax
       mov       rcx,7FFE2D2F1420
       call      qword ptr [7FFE2D2D50E0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncBoundedParallelism>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<RunAsyncBoundedParallelism>d__8 ByRef, System.Threading.Tasks.Task`1<System.__Canon> ByRef)
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FFE2D2F1C70
       call      qword ptr [7FFE2D2D5110]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<System.__Canon> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L07:
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D2DCD08]
       jmp       near ptr M03_L04
M03_L09:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L10:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M03_L14
M03_L11:
       mov       rdx,[rbp-28]
       mov       rsi,[rdx+38]
       mov       [rbp-78],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-78]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       short M03_L15
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2D7F00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-48]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D2DD188]
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2D52D8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M03_L11
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       cmp       qword ptr [rbx],0
       je        near ptr M03_L20
       mov       rbx,[rbx]
       mov       rcx,25A34800278
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L25
M03_L16:
       mov       eax,[rbx+34]
       mov       [rbp-7C],eax
       test      eax,5600000
       jne       near ptr M03_L27
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-7C]
       jne       near ptr M03_L26
M03_L17:
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L18
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DCFF0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L28
M03_L18:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L29
       mov       rdx,25A1E800BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE2D2D4018]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L20:
       test      rsi,rsi
       jne       short M03_L24
       jmp       short M03_L22
M03_L21:
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L19
M03_L22:
       test      byte ptr [7FFE2D2AADD8],1
       jne       short M03_L23
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M03_L23:
       mov       rcx,25A348004F0
       mov       rdi,[rcx]
       jmp       short M03_L21
M03_L24:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2D2DF720]; System.Threading.Tasks.Task..ctor(Boolean, System.Threading.Tasks.TaskCreationOptions, System.Threading.CancellationToken)
       lea       rcx,[rdi+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L21
M03_L25:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2D4420]
       mov       edx,eax
       mov       rcx,25A34800278
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2DD080]
       jmp       near ptr M03_L16
M03_L26:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2DCFD8]
       test      eax,eax
       jne       near ptr M03_L17
M03_L27:
       mov       ecx,18
       call      qword ptr [7FFE2D2DD098]
       int       3
M03_L28:
       call      qword ptr [7FFE2D2DD5A8]
       jmp       near ptr M03_L18
M03_L29:
       call      qword ptr [7FFE2D2DC5E8]
       int       3
       sub       rsp,28
       mov       rdx,[rbp-98]
       mov       rax,[rbp-88]
       cmp       rdx,[rax+10]
       je        short M03_L30
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
M03_L30:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-90]
       cmp       rdx,rbx
       je        short M03_L33
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L31
       cmp       qword ptr [rbx+10],0
       jne       short M03_L32
M03_L31:
       cmp       qword ptr [rbp-90],0
       je        short M03_L33
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+10],0
       je        short M03_L33
M03_L32:
       mov       rcx,rbx
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D2DCD08]
M03_L33:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D24E550]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1213
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2D52F0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD7B8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD5C0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DF7C8]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunAsyncTaskFunc()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE2FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D23E4C0]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncTaskFunc>d__11.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2CC198]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2C7570]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D2CC270]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2CC198]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2C4828]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncTaskFunc>d__11.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       jne       short M03_L02
       lea       rax,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rax],rdx
       mov       [rax+8],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L00:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L01:
       mov       rax,[rbp-28]
       mov       esi,[rax+38]
       mov       rax,[rbx+88]
       mov       [rax+38],esi
       jmp       near ptr M03_L15
M03_L02:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,22628C00D58
       mov       rax,[rax]
       mov       [rbp-58],rax
       mov       dword ptr [rbp-4C],3E8
       xor       eax,eax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L03:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L04
       call      qword ptr [7FFE2CE2FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
       mov       rcx,[rbp+10]
M03_L04:
       mov       [rbp-68],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-70],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-78],rdx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE2D23E7A8]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunAsync>d__4`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-78]
       cmp       rdx,[rsi+10]
       je        short M03_L05
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-70]
       cmp       rdx,rdi
       je        short M03_L07
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L06
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L06:
       cmp       qword ptr [rbp-70],0
       jne       short M03_L10
M03_L07:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L13
M03_L08:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L09
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L09:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFE2D2C4588]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncTaskFunc>d__11, DotNetTips.Spargine.Core.BenchmarkTests]](<RunAsyncTaskFunc>d__11 ByRef, System.Threading.Tasks.Task`1<Int32> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D23FD20]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-70]
       cmp       qword ptr [rdx+10],0
       je        short M03_L07
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFE2D2CC198]
       jmp       near ptr M03_L07
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2C7570]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L13:
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE2D2CC270]
       jmp       near ptr M03_L08
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2C4828]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L20
       mov       rcx,2263EC002B8
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L23
M03_L16:
       mov       eax,[rdi+34]
       mov       [rbp-5C],eax
       test      eax,5600000
       jne       near ptr M03_L25
       lea       rcx,[rdi+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-5C]
       jne       near ptr M03_L24
M03_L17:
       mov       [rdi+38],esi
       lea       rcx,[rdi+34]
       mov       eax,[rdi+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rdi+28]
       test      rsi,rsi
       jne       near ptr M03_L26
M03_L18:
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M03_L27
       mov       rdx,22628C00BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE2D2C40F0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L20:
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M03_L21
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2263EC00380
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       near ptr M03_L28
       inc       esi
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       jmp       short M03_L22
M03_L21:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2D2CDE60]; System.Threading.Tasks.Task..ctor(Boolean, System.Threading.Tasks.TaskCreationOptions, System.Threading.CancellationToken)
       mov       [rdi+38],esi
M03_L22:
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L19
M03_L23:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2C45B8]
       mov       edx,eax
       mov       rcx,2263EC002B8
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2CC3A8]
       jmp       near ptr M03_L16
M03_L24:
       mov       rcx,rdi
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2C7E40]
       test      eax,eax
       jne       near ptr M03_L17
M03_L25:
       mov       ecx,18
       call      qword ptr [7FFE2D2CC3C0]
       int       3
M03_L26:
       mov       rcx,rdi
       call      qword ptr [7FFE2D2C7E58]
       mov       rcx,rsi
       call      qword ptr [7FFE2D2C7E70]
       jmp       near ptr M03_L18
M03_L27:
       call      qword ptr [7FFE2D2C7AF8]
       int       3
M03_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rdx,[rbp-78]
       mov       rax,[rbp-68]
       cmp       rdx,[rax+10]
       je        short M03_L29
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
M03_L29:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-70]
       cmp       rdx,rbx
       je        short M03_L32
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L30
       cmp       qword ptr [rbx+10],0
       jne       short M03_L31
M03_L30:
       cmp       qword ptr [rbp-70],0
       je        short M03_L32
       mov       rdx,[rbp-70]
       cmp       qword ptr [rdx+10],0
       je        short M03_L32
M03_L31:
       mov       rcx,rbx
       mov       rdx,[rbp-70]
       call      qword ptr [7FFE2D2CC198]
M03_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFE2D23E5B0]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1084
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2C4840]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CCBA0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CC9A8]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CE0E8]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunAsyncFunc()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE0FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D21E4D8]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncFunc>d__9.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2AC210]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2A7390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D2AC330]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2AC210]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2A4630]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncFunc>d__9.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       jne       short M03_L02
       lea       rax,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rax],rdx
       mov       [rax+8],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L00:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L01:
       mov       rax,[rbp-30]
       mov       esi,[rax+38]
       mov       rax,[rbx+88]
       mov       [rax+38],esi
       jmp       near ptr M03_L15
M03_L02:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rax,24B12400D78
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       dword ptr [rbp-54],3E8
       xor       eax,eax
       mov       [rbp-48],rax
       mov       dword ptr [rbp-58],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L03:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L04
       call      qword ptr [7FFE2CE0FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
       mov       rcx,[rbp+10]
M03_L04:
       mov       [rbp-70],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-78],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-80],rdx
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE2D21E7C0]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunAsync>d__2`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-80]
       cmp       rdx,[rsi+10]
       je        short M03_L05
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-78]
       cmp       rdx,rdi
       je        short M03_L07
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L06
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L06:
       cmp       qword ptr [rbp-78],0
       jne       short M03_L10
M03_L07:
       mov       rax,[rbp-50]
       test      rax,rax
       je        near ptr M03_L13
M03_L08:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L09
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L09:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFE2D2A4408]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncFunc>d__9, DotNetTips.Spargine.Core.BenchmarkTests]](<RunAsyncFunc>d__9 ByRef, System.Threading.Tasks.Task`1<Int32> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFE2D21FCD8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L07
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2AC210]
       jmp       near ptr M03_L07
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2A7390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L13:
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE2D2AC330]
       jmp       near ptr M03_L08
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2A4630]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L20
       mov       rcx,24B124022B0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L24
M03_L16:
       mov       eax,[rdi+34]
       mov       [rbp-64],eax
       test      eax,5600000
       jne       near ptr M03_L26
       lea       rcx,[rdi+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-64]
       jne       near ptr M03_L25
M03_L17:
       mov       [rdi+38],esi
       lea       rcx,[rdi+34]
       mov       eax,[rdi+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rdi+28]
       test      rsi,rsi
       jne       near ptr M03_L27
M03_L18:
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M03_L28
       mov       rdx,24B12400BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE2D21FD50]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L20:
       lea       edi,[rsi+1]
       cmp       edi,0A
       jae       short M03_L22
       test      byte ptr [7FFE2D390130],1
       jne       short M03_L21
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M03_L21:
       mov       rcx,24B12402378
       mov       rcx,[rcx]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L29
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       jmp       short M03_L23
M03_L22:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2D2ADC38]; System.Threading.Tasks.Task..ctor(Boolean, System.Threading.Tasks.TaskCreationOptions, System.Threading.CancellationToken)
       mov       [r14+38],esi
M03_L23:
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L19
M03_L24:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2A4450]
       mov       edx,eax
       mov       rcx,24B124022B0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2AC450]
       jmp       near ptr M03_L16
M03_L25:
       mov       rcx,rdi
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2A7D80]
       test      eax,eax
       jne       near ptr M03_L17
M03_L26:
       mov       ecx,18
       call      qword ptr [7FFE2D2AC468]
       int       3
M03_L27:
       mov       rcx,rdi
       call      qword ptr [7FFE2D2A7D98]
       mov       rcx,rsi
       call      qword ptr [7FFE2D2A7DB0]
       jmp       near ptr M03_L18
M03_L28:
       call      qword ptr [7FFE2D2A7750]
       int       3
M03_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rdx,[rbp-80]
       mov       rax,[rbp-70]
       cmp       rdx,[rax+10]
       je        short M03_L30
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
M03_L30:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-78]
       cmp       rdx,rbx
       je        short M03_L33
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L31
       cmp       qword ptr [rbx+10],0
       jne       short M03_L32
M03_L31:
       cmp       qword ptr [rbp-78],0
       je        short M03_L33
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L33
M03_L32:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2AC210]
M03_L33:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFE2D21E5C8]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1086
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2A4648]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2ACAF8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AC8E8]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2ADE18]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunAsyncMultiple()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE3FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D24E568]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncMultiple>d__10.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DCAE0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2D7CC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D2DCD68]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DCAE0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 376
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2D4E70]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncMultiple>d__10.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L09
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,18E1D800D60
       mov       rax,[rax]
       mov       [rbp-58],rax
       mov       dword ptr [rbp-4C],3E8
       xor       eax,eax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FFE2CE3FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-70],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-78],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-80],rdx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE2D24E988]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunAsync>d__3`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-80]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-78]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L08
M03_L03:
       cmp       qword ptr [rbp-78],0
       jne       near ptr M03_L07
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L06
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L10
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8d,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],r8d
       lea       r8,[rax+10]
       mov       rdx,rax
       mov       rcx,7FFE2D2CF328
       call      qword ptr [7FFE2D2D4C18]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunAsyncMultiple>d__10, DotNetTips.Spargine.Core.BenchmarkTests]](<RunAsyncMultiple>d__10 ByRef, System.Threading.Tasks.Task`1<System.__Canon> ByRef)
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FFE2D2CE420
       call      qword ptr [7FFE2D2D47C8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<System.__Canon> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L07:
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2DCAE0]
       jmp       near ptr M03_L04
M03_L09:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L10:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M03_L14
M03_L11:
       mov       rdx,[rbp-28]
       mov       rsi,[rdx+38]
       mov       [rbp-60],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       short M03_L15
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2D7CC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-48]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D2DCD68]
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2D4E70]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M03_L11
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       cmp       qword ptr [rbx],0
       je        near ptr M03_L20
       mov       rbx,[rbx]
       mov       rcx,18E33800260
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L25
M03_L16:
       mov       eax,[rbx+34]
       mov       [rbp-64],eax
       test      eax,5600000
       jne       near ptr M03_L27
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-64]
       jne       near ptr M03_L26
M03_L17:
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       jne       near ptr M03_L28
M03_L18:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L29
       mov       rdx,18E1D800BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE2D24FEA0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L20:
       test      rsi,rsi
       je        short M03_L22
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+34],1000000
       lea       rcx,[rdi+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L21:
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L19
M03_L22:
       test      byte ptr [7FFE2D2AB550],1
       je        short M03_L24
M03_L23:
       mov       rcx,18E338003F0
       mov       rdi,[rcx]
       jmp       short M03_L21
M03_L24:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M03_L23
M03_L25:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D24FB10]
       mov       edx,eax
       mov       rcx,18E33800260
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2D46D8]
       jmp       near ptr M03_L16
M03_L26:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2DCB58]
       test      eax,eax
       jne       near ptr M03_L17
M03_L27:
       mov       ecx,18
       call      qword ptr [7FFE2D2DCED0]
       int       3
M03_L28:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DCB70]
       mov       rcx,rsi
       call      qword ptr [7FFE2D2DCB88]
       jmp       near ptr M03_L18
M03_L29:
       call      qword ptr [7FFE2D2DC468]
       int       3
       sub       rsp,28
       mov       rdx,[rbp-80]
       mov       rax,[rbp-70]
       cmp       rdx,[rax+10]
       je        short M03_L30
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
M03_L30:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-78]
       cmp       rdx,rbx
       je        short M03_L33
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L31
       cmp       qword ptr [rbx+10],0
       jne       short M03_L32
M03_L31:
       cmp       qword ptr [rbp-78],0
       je        short M03_L33
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L33
M03_L32:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2DCAE0]
M03_L33:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32[]>
       call      qword ptr [7FFE2D24E688]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1134
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2D4E88]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD488]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD278]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DE868]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.GetStatistics()
       mov       rcx,rdx
       jmp       qword ptr [7FFE2D23E448]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper.GetStatistics()
; Total bytes of code 9
```
```assembly
; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper.GetStatistics()
; 		ThreadPool.GetMinThreads(out var minWorkerThreads, out var minCompletionPortThreads);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		ThreadPool.GetMaxThreads(out var maxWorkerThreads, out var maxCompletionPortThreads);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		ThreadPool.GetAvailableThreads(out var availableWorkerThreads, out var availableCompletionPortThreads);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new ThreadPoolStatistics(
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ThreadPool.ThreadCount,
; 			                       
; 			ThreadPool.PendingWorkItemCount,
; 			                                
; 			ThreadPool.CompletedWorkItemCount,
; 			                                  
; 			minWorkerThreads,
; 			                 
; 			maxWorkerThreads,
; 			                 
; 			availableWorkerThreads,
; 			                       
; 			minCompletionPortThreads,
; 			                         
; 			maxCompletionPortThreads,
; 			                         
; 			availableCompletionPortThreads);
; 			                                
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,24DF0C001F8
       mov       rsi,[rax]
       mov       rax,rsi
       movsx     rdi,word ptr [rax+64]
       movsx     rbp,word ptr [rax+68]
       mov       rax,rsi
       movsx     r14,word ptr [rax+66]
       movsx     r15,word ptr [rax+6A]
       mov       rax,rsi
       mov       rcx,[rax+0B8]
       movsx     rdx,word ptr [rax+66]
       movsx     rcx,cx
       sub       edx,ecx
       xor       r13d,r13d
       test      edx,edx
       cmovg     r13d,edx
       movsx     r12,word ptr [rax+6A]
       mov       rax,rsi
       mov       rax,[rax+0B8]
       shr       rax,10
       cwde
       mov       [rsp+2C],eax
       call      qword ptr [7FFE2D23E8B0]; System.Threading.ThreadPoolWorkQueue.get_LocalCount()
       mov       [rsp+30],rax
       mov       rcx,24DF0C001D0
       mov       rcx,[rcx]
       call      qword ptr [7FFE2D23E8E0]; System.Threading.ThreadPoolWorkQueue.get_GlobalCount()
       add       rax,[rsp+30]
       mov       [rsp+20],rax
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D23E940]; System.Threading.ThreadInt64PersistentCounter.get_Count()
       mov       esi,[rsp+2C]
       mov       [rbx],esi
       mov       rsi,[rsp+20]
       mov       [rbx+8],rsi
       mov       [rbx+10],rax
       mov       [rbx+18],edi
       mov       [rbx+1C],r14d
       mov       [rbx+20],r13d
       mov       [rbx+24],ebp
       mov       [rbx+28],r15d
       mov       [rbx+2C],r12d
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 225
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.RunWhenAnyAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE2FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D23E460]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunWhenAnyAsync>d__12.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2CC678]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2C76F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D2CC810]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2CC678]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2C4900]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunWhenAnyAsync>d__12.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L11
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,156D3400D70
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       dword ptr [rbp-5C],3E8
       xor       eax,eax
       mov       [rbp-50],rax
       mov       dword ptr [rbp-60],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FFE2CE2FC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-70],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-78],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-80],rdx
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE2D23E778]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<RunWhenAnyAsync>d__7`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-80]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-78]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       short M03_L09
M03_L03:
       cmp       qword ptr [rbp-78],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-58]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        short M03_L10
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       esi,[rdx+38]
       mov       rdx,[rbx+88]
       mov       [rdx+38],esi
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2CC678]
       jmp       short M03_L04
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFE2D2C46A8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<RunWhenAnyAsync>d__12, DotNetTips.Spargine.Core.BenchmarkTests]](<RunWhenAnyAsync>d__12 ByRef, System.Threading.Tasks.Task`1<Int32> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE2D2C46C0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L17
M03_L11:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2C76F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE2D2CC810]
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2C4900]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       cmp       qword ptr [rbx],0
       jne       short M03_L19
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        short M03_L18
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       dword ptr [rdx+34],1000000
       mov       [rdx+38],esi
M03_L16:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L17:
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       lea       edx,[rsi+1]
       mov       rcx,156E94002F0
       mov       rcx,[rcx]
       cmp       edx,0A
       jae       short M03_L20
       inc       esi
       mov       edx,esi
       mov       rdx,[rcx+rdx*8+10]
       jmp       short M03_L16
M03_L19:
       mov       rcx,[rbx]
       mov       edx,esi
       call      qword ptr [7FFE2D2C4840]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Int32, System.Private.CoreLib]].SetExistingTaskResult(System.Threading.Tasks.Task`1<Int32>, Int32)
       jmp       short M03_L17
M03_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rdx,[rbp-80]
       mov       rax,[rbp-70]
       cmp       rdx,[rax+10]
       je        short M03_L21
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
M03_L21:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-78]
       cmp       rdx,rbx
       je        short M03_L24
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L22
       cmp       qword ptr [rbx+10],0
       jne       short M03_L23
M03_L22:
       cmp       qword ptr [rbp-78],0
       je        short M03_L24
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L24
M03_L23:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2CC678]
M03_L24:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFE2D23E550]
       lea       rax,[M03_L17]
       add       rsp,28
       ret
; Total bytes of code 793
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2C4918]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CD140]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CCF30]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2CE580]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark.TryRunAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE2CE3FC78]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE2D24E568]; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<TryRunAsync>d__13.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DD0C8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFE2D2DC120]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FFE2D2DD158]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2DD0C8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 376
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D2D4CD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE8C66AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE8C668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<TryRunAsync>d__13.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L09
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,17F29800D78
       mov       rax,[rax]
       mov       [rbp-58],rax
       mov       dword ptr [rbp-4C],3E8
       xor       eax,eax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FFE2CE3FC78]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-70],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-78],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-80],rdx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE2D24E928]; DotNetTips.Spargine.Core.Threading.ThreadPoolHelper+<TryRunAsync>d__8`1[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-80]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-78]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L08
M03_L03:
       cmp       qword ptr [rbp-78],0
       jne       near ptr M03_L07
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L06
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L10
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8d,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],r8d
       lea       r8,[rax+10]
       mov       rdx,rax
       mov       rcx,7FFE2D2CE630
       call      qword ptr [7FFE2D2D4AC8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.Threading.ThreadPoolHelperBenchmark+<TryRunAsync>d__13, DotNetTips.Spargine.Core.BenchmarkTests]](<TryRunAsync>d__13 ByRef, System.Threading.Tasks.Task`1<System.__Canon> ByRef)
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FFE2D2CEE60
       call      qword ptr [7FFE2D2D4AF8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<System.__Canon> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L07:
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2DD0C8]
       jmp       near ptr M03_L04
M03_L09:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L10:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M03_L14
M03_L11:
       mov       rdx,[rbp-28]
       mov       rsi,[rdx+38]
       mov       [rbp-60],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       short M03_L15
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFE2D2DC120]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-48]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FFE2D2DD158]
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFE2D2D4CD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M03_L11
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       lea       rbx,[rcx+10]
       cmp       qword ptr [rbx],0
       je        near ptr M03_L20
       mov       rbx,[rbx]
       mov       rcx,17F3F8002B8
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L24
M03_L16:
       mov       eax,[rbx+34]
       mov       [rbp-64],eax
       test      eax,5600000
       jne       near ptr M03_L26
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-64]
       jne       near ptr M03_L25
M03_L17:
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L18
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DCE28]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L27
M03_L18:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L28
       mov       rdx,17F29800BF0
       mov       rdx,[rdx]
       call      00007FFE8C84A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE2D2D40F0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L20:
       test      rsi,rsi
       je        short M03_L22
       mov       rcx,offset MT_System.Threading.Tasks.Task<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+34],1000000
       lea       rcx,[rdi+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L21:
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L19
M03_L22:
       test      byte ptr [7FFE2D2ABC40],1
       jne       short M03_L23
       mov       rcx,offset MT_System.Threading.Tasks.Task<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M03_L23:
       mov       rcx,17F3F800438
       mov       rdi,[rcx]
       jmp       short M03_L21
M03_L24:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2D4840]
       mov       edx,eax
       mov       rcx,17F3F8002B8
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFE2D2DD2C0]
       jmp       near ptr M03_L16
M03_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFE2D2DCE10]
       test      eax,eax
       jne       near ptr M03_L17
M03_L26:
       mov       ecx,18
       call      qword ptr [7FFE2D2DD2D8]
       int       3
M03_L27:
       call      qword ptr [7FFE2D2DEB80]
       jmp       near ptr M03_L18
M03_L28:
       call      qword ptr [7FFE2D2DC900]
       int       3
       sub       rsp,28
       mov       rdx,[rbp-80]
       mov       rax,[rbp-70]
       cmp       rdx,[rax+10]
       je        short M03_L29
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
M03_L29:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-78]
       cmp       rdx,rbx
       je        short M03_L32
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L30
       cmp       qword ptr [rbx+10],0
       jne       short M03_L31
M03_L30:
       cmp       qword ptr [rbp-78],0
       je        short M03_L32
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+10],0
       je        short M03_L32
M03_L31:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE2D2DD0C8]
M03_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FFE2D24E688]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1138
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFE2D2D4CF0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD9C8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DD818]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2DEDF0]
       jmp       short M05_L02
; Total bytes of code 124
```

