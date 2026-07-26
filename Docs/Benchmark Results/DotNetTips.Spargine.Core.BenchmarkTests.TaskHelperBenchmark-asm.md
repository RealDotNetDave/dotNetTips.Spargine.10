## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TaskHelperBenchmark.RunSyncValueTaskTResult()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+1A0]
       mov       rsi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TaskHelper+<>c__DisplayClass4_0<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M00_L07
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.TaskHelper+<>c__DisplayClass4_0`1[[System.Int32, System.Private.CoreLib]].<RunSync>b__0()
       mov       [rbx+18],rcx
       mov       rcx,17F204001D8
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+34],2000
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L01
       call      qword ptr [7FF8ABC4FD98]; System.Threading.Thread.InitializeCurrentThread()
M00_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rcx,17F204001E8
       mov       rbx,[rcx]
M00_L02:
       test      rbx,rbx
       je        short M00_L04
       mov       rcx,17F204001E8
       cmp       rbx,[rcx]
       je        short M00_L05
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+3C],1
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L03:
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L05
M00_L04:
       or        dword ptr [rdi+34],20000000
M00_L05:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8AC04E7A8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       ecx,[rdi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M00_L10
M00_L06:
       mov       eax,[rdi+38]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FF8ABFAF018]
       mov       ecx,2ADD
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC0DD140]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC0D7F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF8AC0D6A60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8AC04EF40]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M00_L06
; Total bytes of code 597
```
```assembly
; DotNetTips.Spargine.Core.TaskHelper+<>c__DisplayClass4_0`1[[System.Int32, System.Private.CoreLib]].<RunSync>b__0()
; 		var result = _taskFactory.StartNew(() => taskFunction().AsTask().GetAwaiter().GetResult(), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
; 		                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.TaskHelperBenchmark+<>c.<Setup>b__4_1()
       cmp       [rbx+18],rcx
       jne       short M01_L04
       mov       rcx,[rbx+8]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF8ABDAE4F0]; DotNetTips.Spargine.Core.BenchmarkTests.TaskHelperBenchmark+<>c.<Setup>b__4_1()
M01_L00:
       mov       rbx,[rsp+28]
       test      rbx,rbx
       je        short M01_L05
       mov       rsi,rbx
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32>+AsyncStateMachineBox<DotNetTips.Spargine.Core.BenchmarkTests.TaskHelperBenchmark+<>c+<<Setup>b__4_1>d>
       cmp       [rsi],rdx
       jne       near ptr M01_L08
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L09
M01_L02:
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M01_L10
M01_L03:
       mov       eax,[rsi+38]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M01_L00
M01_L05:
       mov       esi,[rsp+30]
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jae       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F20400370
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       inc       esi
       mov       edx,esi
       mov       rbx,[rcx+rdx*8+10]
       jmp       short M01_L07
M01_L06:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8AC0DD080]
M01_L07:
       mov       rsi,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L09:
       lea       rcx,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF8AC0D7D50]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8AC04EF40]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M01_L03
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 305
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
       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF90A67AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF90A678FE8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M03_L19
       or        dword ptr [rcx+34],10000
M03_L00:
       cmp       byte ptr [7FF8AB96B0CC],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,17F204001F8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L10
M03_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M03_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M03_L11
       mov       rdx,17F20400200
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      sil,1
       jne       short M03_L06
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],9
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       near ptr M03_L14
M03_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M03_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       jne       short M03_L08
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M03_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       short M03_L09
M03_L08:
       test      eax,eax
       jge       short M03_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF8AC0D7648]
M03_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M03_L18
       mov       rcx,17F20400228
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF8AC04EC40]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rdx,rsi
       call      qword ptr [7FF8AC0D79D8]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F20400318
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8AC0DD170]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF8AC04EDA8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,1BF9F3F0B98
       call      qword ptr [7FF8AC04EEB0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF8AC0DD188]
       jmp       near ptr M03_L18
M03_L12:
       mov       rdx,17F20400218
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M03_L04
       mov       rdx,17F20400218
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF8AC0D7618]
       jmp       near ptr M03_L04
M03_L13:
       mov       ecx,9
       call      qword ptr [7FF8AC0D6A60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,[rsi+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0D7630]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FF8AC04EE20]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7FF8AC0DD158]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7FF8AC04F9F0]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M03_L02
       call      qword ptr [7FF8AC04FC78]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF8AC0D7960]
       mov       rdx,rax
       mov       rcx,1BF9F3F0B10
       call      qword ptr [7FF8ABA27840]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8AC0D7978]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8AC0D7750]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF8AC0D7990]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF8AC0D79A8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0D79C0]
       test      eax,200
       jne       short M03_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0D76D8]
M03_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8ABA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8ABA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1BF9F3E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       call      qword ptr [7FF8AC0D6DD8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF90A691D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
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
       jne       short M06_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF8AC04EF70]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M06_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M06_L03
M06_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L04
M06_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M06_L01
       mov       rcx,rbx
       call      qword ptr [7FF8AC0D7870]
       jmp       short M06_L01
M06_L04:
       test      sil,2
       jne       short M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF8AC0D76C0]
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FF8AC0DD098]
       jmp       short M06_L02
; Total bytes of code 124
```

