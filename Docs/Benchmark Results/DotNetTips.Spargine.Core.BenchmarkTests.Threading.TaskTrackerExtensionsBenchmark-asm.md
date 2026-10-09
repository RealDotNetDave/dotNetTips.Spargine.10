## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark.RegisterItemWithTracker()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       ebx,ebx
       mov       [rbp-40],rbx
       mov       [rbp-48],rbx
       xor       esi,esi
       mov       rax,[rcx+1A8]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L40
       mov       edi,[rax+10]
       mov       r14,[rcx+1B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass0_0<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1654EC00D48
       mov       r13,[rcx]
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],edi
       mov       rdx,r13
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M00_L28
M00_L00:
       mov       rcx,offset MT_System.Action
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass0_0`1[[System.Int32, System.Private.CoreLib]].<RegisterItemWithTracker>b__0()
       mov       [rdi+18],rcx
       mov       rcx,16564C001D8
       mov       r15,[rcx]
       mov       r13,r15
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+10],rcx
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r12+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M00_L29
M00_L01:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L02
       call      qword ptr [7FFD573EFF48]; System.Threading.Thread.InitializeCurrentThread()
M00_L02:
       mov       r13,[rax+8]
       test      r13,r13
       je        short M00_L03
       xor       ecx,ecx
       cmp       byte ptr [r13+18],0
       cmovne    r13,rcx
       jmp       short M00_L04
M00_L03:
       mov       rcx,16564C001E8
       mov       r13,[rcx]
M00_L04:
       test      r13,r13
       je        short M00_L06
       mov       rcx,16564C001E8
       cmp       r13,[rcx]
       je        short M00_L07
       mov       rax,[r12+28]
       test      rax,rax
       jne       short M00_L05
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r12+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-58]
M00_L05:
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L07
M00_L06:
       or        dword ptr [r12+34],20000000
M00_L07:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFD577FE640]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker
       cmp       [r14],rcx
       jne       near ptr M00_L39
       mov       r13,r14
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       [rax+10],rcx
       cmp       byte ptr [r13+10],0
       jne       near ptr M00_L30
       mov       rcx,[r13+8]
       cmp       [rcx],cl
       mov       edx,0FFFFFFFF
M00_L08:
       test      rbx,rbx
       jne       short M00_L11
       mov       r8,rsi
       test      r8,r8
       je        short M00_L10
M00_L09:
       inc       edx
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M00_L12
       mov       r10d,edx
       mov       rbx,[r8+r10*8+10]
       jmp       short M00_L08
M00_L10:
       mov       r8,[rcx+8]
       mov       rsi,[r8+10]
       mov       r8,rsi
       jmp       short M00_L09
M00_L11:
       mov       r8,[rbx+20]
       mov       r10,[rbx+8]
       mov       rbx,[rbx+10]
       cmp       r10,r12
       jne       short M00_L08
       jmp       near ptr M00_L31
M00_L12:
       mov       r14,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1
M00_L13:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFD577FEFB8]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+8]
       mov       r8,[rbx+10]
       mov       rdx,[rcx+8]
       mov       [rsp+20],r12
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       xor       r9d,r9d
       call      qword ptr [7FFD577FF690]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       test      eax,eax
       je        short M00_L13
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
       mov       [rsi+18],rcx
       mov       r14,r15
       mov       rcx,offset MT_System.Threading.Tasks.ContinuationTaskFromTask
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r13+10],rax
       mov       [r13+18],rax
       mov       dword ptr [r13+34],2000200
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L14
       call      qword ptr [7FFD573EFF48]; System.Threading.Thread.InitializeCurrentThread()
M00_L14:
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        short M00_L15
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       short M00_L16
M00_L15:
       mov       rcx,16564C001E8
       mov       rsi,[rcx]
M00_L16:
       test      rsi,rsi
       je        short M00_L18
       mov       rcx,16564C001E8
       cmp       rsi,[rcx]
       je        short M00_L19
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L17
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r13+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L17:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L19
M00_L18:
       or        dword ptr [r13+34],20000000
M00_L19:
       lea       rcx,[r13+38]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,offset MT_System.Threading.Tasks.ContinueWithTaskContinuation
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+18],80000
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,16564C001F8
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L32
M00_L20:
       cmp       byte ptr [7FFD5710B0CC],0
       jne       near ptr M00_L33
M00_L21:
       cmp       qword ptr [rbp-48],0
       jne       near ptr M00_L34
M00_L22:
       test      dword ptr [r13+34],1600000
       jne       short M00_L26
       test      word ptr [r12+34],400
       jne       near ptr M00_L37
M00_L23:
       test      dword ptr [r12+34],1600000
       jne       short M00_L25
       cmp       qword ptr [r12+20],0
       jne       short M00_L24
       lea       rcx,[r12+20]
       test      rcx,rcx
       je        near ptr M00_L38
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       test      rax,rax
       je        short M00_L26
M00_L24:
       mov       rcx,r12
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD578751A0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L26
M00_L25:
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8d,1
       call      qword ptr [7FFD57861048]; System.Threading.Tasks.ContinueWithTaskContinuation.Run(System.Threading.Tasks.Task, Boolean)
M00_L26:
       mov       rax,[rbx+10]
M00_L27:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerFacade
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16564C00368
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFD575442A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L29:
       mov       ecx,4
       call      qword ptr [7FFD57876A60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r14
       call      qword ptr [7FFD57877B88]
       int       3
M00_L31:
       mov       [rbp-68],r8
       mov       rax,[rbp-68]
       jmp       short M00_L27
M00_L32:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD578776C0]
       mov       edi,eax
       mov       rcx,[r13+8]
       call      qword ptr [7FFD578779C0]
       mov       rdx,rax
       mov       rcx,1A5E3C82B08
       call      qword ptr [7FFD571C7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,edi
       mov       rcx,16564C001F8
       mov       rcx,[rcx]
       xor       r9d,r9d
       call      qword ptr [7FFD578779D8]
       jmp       near ptr M00_L20
M00_L33:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFD578779A8]
       jmp       near ptr M00_L21
M00_L34:
       test      dword ptr [r12+34],1600000
       jne       short M00_L35
       lea       rcx,[rbp-48]
       call      qword ptr [7FFD57877540]
       test      eax,eax
       je        short M00_L36
M00_L35:
       mov       rcx,r13
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD57877528]
       jmp       near ptr M00_L22
M00_L36:
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       r8,r12
       mov       r9,rsi
       call      qword ptr [7FFD57877528]
       jmp       near ptr M00_L22
M00_L37:
       mov       rax,16564C001F8
       mov       rdi,[rax]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L23
       call      qword ptr [7FFD578775B8]
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFD577FE5B0]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       r14d,eax
       call      qword ptr [7FFD57877C00]
       mov       [rbp-50],rax
       mov       rcx,r13
       call      qword ptr [7FFD578776C0]
       mov       r9d,eax
       mov       edx,r14d
       mov       r8d,[rbp-4C]
       mov       rcx,rdi
       call      qword ptr [7FFD57877C18]
       jmp       near ptr M00_L23
M00_L38:
       call      qword ptr [7FFD57877180]
       int       3
M00_L39:
       mov       rcx,r14
       mov       rdx,r12
       mov       r11,7FFD57110A68
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1586
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass0_0`1[[System.Int32, System.Private.CoreLib]].<RegisterItemWithTracker>b__0()
; 		var task = Task.Run(() => action(item));
; 		                          ^^^^^^^^^^^^
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark+<>c.<.cctor>b__12_0(Int32)
       cmp       [rax+18],rcx
       jne       short M01_L00
       ret
M01_L00:
       mov       rcx,[rax+8]
       jmp       qword ptr [rax+18]
; Total bytes of code 32
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
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFD9C99AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD9C998FE8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [7FFD5710B0CC],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,16564C001F8
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
       mov       rdx,16564C00200
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      sil,1
       jne       short M03_L06
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],9
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
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
       je        short M03_L08
       test      eax,eax
       jge       short M03_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD57877B40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M03_L09
M03_L08:
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
M03_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M03_L18
       mov       rcx,16564C00228
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD577FEAD8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rdx,rsi
       call      qword ptr [7FFD57877A68]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16564C00308
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD5787D050]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD577FEC40]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,1A5E3C80C48
       call      qword ptr [7FFD577FED48]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFD5787D068]
       jmp       near ptr M03_L18
M03_L12:
       mov       rdx,16564C00218
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M03_L04
       mov       rdx,16564C00218
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD57877B10]
       jmp       near ptr M03_L04
M03_L13:
       mov       ecx,9
       call      qword ptr [7FFD57876A60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877B28]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FFD577FECB8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       mov       eax,[rcx+34]
       mov       [rbp-1C],eax
       test      eax,410000
       jne       short M03_L18
       lea       rdx,[rcx+34]
       mov       r8d,eax
       or        r8d,10000
       lock cmpxchg [rdx],r8d
       cmp       eax,[rbp-1C]
       je        near ptr M03_L00
       mov       edx,10000
       mov       r8d,410000
       call      qword ptr [7FFD57877990]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7FFD578779A8]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M03_L02
       call      qword ptr [7FFD578776C0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFD578779C0]
       mov       rdx,rax
       mov       rcx,1A5E3C80BC0
       call      qword ptr [7FFD571C7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFD578779D8]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD578779F0]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FFD57877A08]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFD57877A20]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD57877A38]
       test      eax,200
       jne       short M03_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877A50]
M03_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 931
```
```assembly
; DotNetTips.Spargine.Core.Ulid.NewUlid()
; 		Span<char> ulidChars = stackalloc char[UlidLength];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> timestampBytes = stackalloc byte[6];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new Ulid(new string(ulidChars));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,9905CAC52250
       mov       [rbp+48],rax
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       mov       rbx,rcx
       lea       rsi,[rbp+40]
       lea       rdi,[rbp+30]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD577F56E0]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rcx,rcx,[rbp+28]
       shr       rcx,0B
       mov       rdx,0FFFFC77CEDD32800
       add       rcx,rdx
       mov       rdx,rcx
       sar       rdx,28
       mov       [rsi],dl
       mov       rdx,rcx
       sar       rdx,20
       mov       [rsi+1],dl
       mov       rdx,rcx
       sar       rdx,18
       mov       [rsi+2],dl
       mov       rdx,rcx
       sar       rdx,10
       mov       [rsi+3],dl
       mov       rdx,rcx
       sar       rdx,8
       mov       [rsi+4],dl
       mov       [rsi+5],cl
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
M04_L00:
       cmp       ecx,6
       jae       near ptr M04_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       mov       r10d,3
       sub       r10d,edx
       jo        near ptr M04_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M04_L14
       cmp       edx,8
       jge       near ptr M04_L03
M04_L01:
       mov       r10d,eax
       lea       r10,[rbx+r10*2]
       mov       r14,1A5E3C82A24
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       eax,1
       jo        near ptr M04_L14
       cmp       eax,0A
       jge       near ptr M04_L05
       cmp       edx,3
       jle       short M04_L00
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M04_L14
       cmp       r8d,6
       jge       short M04_L04
       mov       r10d,r8d
       cmp       r10d,6
       jae       near ptr M04_L13
       movzx     r10d,byte ptr [rsi+r10]
M04_L02:
       cmp       ecx,6
       jae       near ptr M04_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rsi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,edx
       jo        near ptr M04_L14
       sub       r10d,5
       jo        near ptr M04_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       edx,5
       jo        near ptr M04_L14
       and       edx,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M04_L01
M04_L03:
       sub       edx,8
       jo        near ptr M04_L14
       add       ecx,1
       jo        near ptr M04_L14
       jmp       near ptr M04_L01
M04_L04:
       xor       r10d,r10d
       jmp       short M04_L02
M04_L05:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFD575F51E8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       xor       eax,eax
       xor       edx,edx
M04_L06:
       cmp       ecx,0A
       jae       near ptr M04_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       mov       r10d,3
       sub       r10d,eax
       jo        near ptr M04_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M04_L14
       cmp       eax,8
       jge       near ptr M04_L09
M04_L07:
       mov       r10d,edx
       add       r10d,0A
       jo        near ptr M04_L14
       lea       r10,[rbx+r10*2]
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       edx,1
       jo        near ptr M04_L14
       cmp       edx,10
       jge       near ptr M04_L11
       cmp       eax,3
       jle       short M04_L06
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M04_L14
       cmp       r8d,0A
       jge       short M04_L10
       mov       r10d,r8d
       cmp       r10d,0A
       jae       near ptr M04_L13
       movzx     r10d,byte ptr [rdi+r10]
M04_L08:
       cmp       ecx,0A
       jae       near ptr M04_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rdi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,eax
       jo        near ptr M04_L14
       sub       r10d,5
       jo        near ptr M04_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       eax,5
       jo        short M04_L14
       and       eax,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M04_L07
M04_L09:
       sub       eax,8
       jo        short M04_L14
       add       ecx,1
       jo        short M04_L14
       jmp       near ptr M04_L07
M04_L10:
       xor       r10d,r10d
       jmp       short M04_L08
M04_L11:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFD577FF618]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,9905CAC52250
       cmp       [rbp+48],r8
       je        short M04_L12
       call      CORINFO_HELP_FAIL_FAST
M04_L12:
       nop
       lea       rsp,[rbp+50]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rdx,r8
       movzx     r9d,r9b
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M05_L33
       cmp       qword ptr [rbp-48],0
       jne       near ptr M05_L28
       cmp       [rdx],dl
       mov       rcx,1654EC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M05_L32
       lea       rcx,[rdx+0C]
       mov       eax,[rdx+8]
       add       eax,eax
       mov       r8d,0B16F52AF
       mov       r10d,160467A6
       cmp       eax,8
       jb        near ptr M05_L29
       mov       r9d,eax
       shr       r9d,3
       nop       dword ptr [rax]
M05_L00:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M05_L00
       test      al,4
       je        short M05_L02
M05_L01:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
M05_L02:
       mov       r9d,eax
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       eax
       shl       eax,3
       shrx      ecx,ecx,eax
M05_L03:
       add       ecx,r8d
       mov       eax,r10d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M05_L04:
       mov       [rbp-34],eax
M05_L05:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],ebx
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,[rbp-34]
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-38],edx
       cmp       r10d,r9d
       jae       near ptr M05_L40
       mov       ecx,r10d
       lea       rsi,[r8+rcx*8+10]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       byte ptr [rbp+40],0
       je        short M05_L07
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M05_L23
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M05_L11
       mov       rcx,r14
       call      00007FFDB6E4E120
       test      eax,eax
       je        near ptr M05_L12
M05_L06:
       mov       dword ptr [rbp-3C],1
M05_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[rbx+8]
       jne       near ptr M05_L13
       mov       r14,[rsi]
       test      r14,r14
       jne       near ptr M05_L16
M05_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M05_L10
M05_L09:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15,[rsi]
       lea       rcx,[r14+20]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-34]
       mov       [r14+18],ecx
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       edx,[rcx+8]
       cmp       [rbp-38],edx
       jae       near ptr M05_L23
       mov       edx,[rbp-38]
       lea       rcx,[rcx+rdx*4+10]
       mov       edx,[rcx]
       add       edx,1
       jo        near ptr M05_L24
       mov       [rcx],edx
       mov       ecx,1
       cmp       edx,[rbx+10]
       cmovg     edi,ecx
       jmp       near ptr M05_L25
M05_L10:
       mov       rdx,7FFD57846558
       call      qword ptr [7FFD571CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M05_L09
M05_L11:
       xor       ecx,ecx
       call      qword ptr [7FFD57876790]
       int       3
M05_L12:
       mov       rcx,r14
       call      qword ptr [7FFD57874438]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M05_L06
M05_L13:
       mov       rcx,[rbx+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-48]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        near ptr M05_L36
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M05_L14
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r11,7FFD57110AB0
       call      qword ptr [r11]
       jmp       short M05_L15
M05_L14:
       mov       rdx,[rbp+20]
       cmp       [rdx],dl
       mov       ecx,4
       call      qword ptr [7FFD577FF768]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rcx,rax
       mov       rdx,[rbp+20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
M05_L15:
       mov       [rbp-34],eax
       jmp       near ptr M05_L36
M05_L16:
       mov       ecx,[rbp-34]
       cmp       ecx,[r14+18]
       jne       short M05_L19
       cmp       qword ptr [rbp-48],0
       je        short M05_L17
       mov       rdx,[r14+20]
       mov       rcx,[rbp-48]
       mov       r8,[rbp+20]
       mov       r11,7FFD57110AB8
       call      qword ptr [r11]
       jmp       short M05_L18
M05_L17:
       mov       rcx,[r14+20]
       mov       rdx,[rbp+20]
       mov       r8d,4
       call      qword ptr [7FFD57334B40]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L18:
       test      eax,eax
       jne       short M05_L20
M05_L19:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M05_L16
       jmp       near ptr M05_L08
M05_L20:
       cmp       byte ptr [rbp+38],0
       je        short M05_L21
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L22
M05_L21:
       mov       rdx,[r14+8]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L22:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       near ptr M05_L37
M05_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M05_L25:
       cmp       dword ptr [rbp-3C],0
       je        short M05_L26
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M05_L40
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rcx,[rcx+rax*8+10]
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M05_L34
       mov       rcx,rsi
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M05_L35
M05_L26:
       test      edi,edi
       jne       near ptr M05_L38
M05_L27:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L28:
       mov       rcx,[rbp-48]
       mov       r11,7FFD57110AA8
       call      qword ptr [r11]
       mov       rdx,[rbp+20]
       jmp       near ptr M05_L04
M05_L29:
       cmp       eax,4
       jae       near ptr M05_L01
       mov       r9d,80
       test      al,1
       je        short M05_L30
       mov       r9d,eax
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M05_L30:
       test      al,2
       je        short M05_L31
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M05_L03
M05_L31:
       mov       ecx,r9d
       jmp       near ptr M05_L03
M05_L32:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,[rbp+20]
       jmp       near ptr M05_L04
M05_L33:
       mov       eax,ebx
       jmp       near ptr M05_L04
M05_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD57876790]
       int       3
M05_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFD57876898]
       jmp       near ptr M05_L26
M05_L36:
       call      M05_L41
       jmp       near ptr M05_L05
M05_L37:
       call      M05_L41
       jmp       short M05_L39
M05_L38:
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       mov       r8d,edi
       xor       r9d,r9d
       call      qword ptr [7FFD577FF720]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M05_L27
M05_L39:
       mov       eax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L41:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M05_L42
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       short M05_L44
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M05_L43
       mov       rcx,rdi
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M05_L42
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFD57876898]
M05_L42:
       nop
       add       rsp,28
       ret
M05_L43:
       xor       ecx,ecx
       call      qword ptr [7FFD57876790]
       int       3
M05_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1413
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
; 				_ = this._tasksByKey.TryRemove(key, out _);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (t.IsFaulted && t.Exception is not null)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						onException?.Invoke(t.Exception);
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					catch (Exception)
; 					^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       mov       rcx,[r8+8]
       mov       rdx,[rbx+10]
       cmp       [rcx],cl
       xor       r8d,r8d
       mov       [rsp+20],r8
       lea       r8,[rbp-18]
       xor       r9d,r9d
       call      qword ptr [7FFD577FF990]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryRemoveInternal(DotNetTips.Spargine.Core.Ulid, System.__Canon ByRef, Boolean, System.__Canon)
       test      dword ptr [rsi+34],200000
       jne       short M06_L01
M06_L00:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L01:
       mov       rcx,rsi
       call      qword ptr [7FFD577FF978]
       test      rax,rax
       je        short M06_L00
       mov       rcx,[rbx+8]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M06_L00
       mov       rcx,rsi
       call      qword ptr [7FFD577FF978]
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M06_L00
       sub       rsp,28
       lea       rax,[M06_L00]
       add       rsp,28
       ret
; Total bytes of code 144
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,1654EC00BF0
       cmp       r14,[rdx]
       jne       short M07_L01
M07_L00:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M07_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD573EDA40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M07_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L02
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      qword ptr [7FFD571C57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L03
M07_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M07_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L04
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      qword ptr [7FFD571C57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L09
M07_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L09
M07_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L06
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      qword ptr [7FFD571C57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L07
M07_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M07_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      qword ptr [7FFD571C57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L09
M07_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M07_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M07_L10
       call      qword ptr [7FFD57877180]
       int       3
M07_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FFDB6DF21C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M07_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M07_L00
M07_L11:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FFD571C5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,1654EC00BF0
       cmp       rcx,[rax]
       jne       short M07_L12
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M07_L18
M07_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M07_L14
       mov       rcx,1654EC00C48
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M07_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1654EC00C18
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FFD57879140
       call      qword ptr [7FFD571C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1654EC00C48
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M07_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787CFC0]
M07_L14:
       test      dil,dil
       je        short M07_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFD572B35F0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       jmp       short M07_L19
M07_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L16
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      qword ptr [7FFD571C57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L19
M07_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L19
M07_L17:
       mov       rcx,r15
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M07_L20
M07_L18:
       call      M07_L22
       jmp       short M07_L21
M07_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M07_L17
M07_L20:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M07_L23
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M07_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 707
```
```assembly
; System.Threading.Tasks.ContinueWithTaskContinuation.Run(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       esi,r8d
       mov       rdi,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       r14d,[rbx+18]
       mov       ecx,[rdx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M08_L02
       test      r14d,10000
       jne       near ptr M08_L06
M08_L00:
       mov       rcx,16564C001F8
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       short M08_L04
M08_L01:
       mov       rdx,[rbx+10]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       test      sil,sil
       je        near ptr M08_L05
       test      r14d,80000
       je        short M08_L05
       mov       rcx,rdi
       mov       edx,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD577FF858]; System.Threading.Tasks.TaskContinuation.InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task, Boolean)
M08_L02:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        short M08_L03
       test      r14d,20000
       jne       short M08_L06
       jmp       short M08_L00
M08_L03:
       test      r14d,40000
       jne       short M08_L06
       jmp       short M08_L00
M08_L04:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787D0F8]
       test      eax,eax
       jne       short M08_L01
       mov       rcx,rdi
       call      qword ptr [7FFD578776C0]
       mov       edx,eax
       mov       rcx,16564C001F8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD57877C30]
       jmp       near ptr M08_L01
M08_L05:
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFD577FE640]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       jmp       short M08_L09
M08_L06:
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M08_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       jne       short M08_L08
M08_L07:
       mov       rcx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD5787D110]
M08_L08:
       mov       rcx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD57877C48]
M08_L09:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       lea       rax,[M08_L09]
       add       rsp,28
       ret
; Total bytes of code 333
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFD571C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M10_L00
       mov       rax,[rcx+18]
       ret
M10_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       jmp       qword ptr [rax]
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD9C9B1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M11_L01
       cmp       [rax],ecx
       jle       short M11_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M11_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M11_L00
M11_L02:
       cmp       [rax+4],edx
       jle       short M11_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M11_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M11_L03
       jmp       short M11_L00
M11_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
       je        near ptr M12_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M12_L01
       test      rsi,rsi
       je        short M12_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M12_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFDB6E452E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD571C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD571C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M12_L00:
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
M12_L01:
       test      rsi,rsi
       je        short M12_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L03
M12_L02:
       mov       rax,1A5E3C70008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
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
M12_L04:
       call      qword ptr [7FFD57876BF8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Threading.Tasks.TaskScheduler.get_Id()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       eax,[rbx+8]
       test      eax,eax
       jne       short M13_L01
       call      qword ptr [7FFD9C999530]
M13_L00:
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       je        short M13_L00
       lea       rdx,[rbx+8]
       xor       eax,eax
       lock cmpxchg [rdx],ecx
       mov       eax,[rbx+8]
M13_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 53
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark.RegisterItemWithTrackerAsync()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       ebx,ebx
       mov       [rbp-40],rbx
       xor       esi,esi
       mov       rax,[rcx+1A8]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L33
       mov       edi,[rax+10]
       mov       r14,[rcx+1B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass1_0<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2B2E2800D50
       mov       r13,[rcx]
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],edi
       mov       rdx,r13
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M00_L21
M00_L00:
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass1_0`1[[System.Int32, System.Private.CoreLib]].<RegisterItemWithTrackerAsync>b__0()
       mov       [rdi+18],rcx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       call      qword ptr [7FFD577FE5F8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rcx,2B2E28021E0
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r13+34],2008
       call      qword ptr [7FFD577FE748]; System.Threading.ExecutionContext.Capture()
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L01
       mov       rcx,2B2E28021F0
       cmp       rdi,[rcx]
       je        short M00_L02
       mov       rcx,r13
       call      qword ptr [7FFD57877768]
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L02
M00_L01:
       or        dword ptr [r13+34],20000000
M00_L02:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFD577FE790]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Threading.Tasks.VoidTaskResult>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       jne       near ptr M00_L20
       test      r15b,4
       je        short M00_L04
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0C
       jle       near ptr M00_L22
       mov       rcx,[rcx+240]
       mov       rax,[rcx+60]
       test      rax,rax
       je        near ptr M00_L22
M00_L03:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L04
       mov       rcx,rdi
       call      qword ptr [7FFD57877768]
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L04:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],rcx
       mov       [rdi+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L20
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [rdi+34],ecx
       mov       rcx,[rdi+28]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L05:
       mov       byte ptr [rdi+3A],1
       mov       rax,2B2E2802200
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M00_L07
       cmp       dword ptr [rdi+30],0
       jne       short M00_L06
       call      qword ptr [7FFD57877828]
       mov       edx,eax
       lea       rcx,[rdi+30]
       xor       eax,eax
       lock cmpxchg [rcx],edx
M00_L06:
       mov       edx,[rdi+30]
       mov       rcx,2B2E2802200
       mov       rcx,[rcx]
       mov       r8,2F377861998
       xor       r9d,r9d
       call      qword ptr [7FFD57877DB0]
M00_L07:
       cmp       byte ptr [7FFD5710B0CC],0
       je        short M00_L08
       mov       rcx,rdi
       call      qword ptr [7FFD57877DC8]
M00_L08:
       test      dword ptr [r13+34],1600000
       jne       short M00_L11
       test      dword ptr [r13+34],1600000
       je        short M00_L10
M00_L09:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFD57857600]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L14
       nop       dword ptr [rax]
M00_L10:
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L29
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L28
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       test      rax,rax
       je        short M00_L14
       jmp       near ptr M00_L29
M00_L11:
       mov       byte ptr [rdi+39],1
       mov       rcx,r13
       call      qword ptr [7FFD577FF5E8]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M00_L24
       mov       ecx,[r13+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M00_L25
       mov       rdx,[r13+38]
M00_L12:
       test      rdx,rdx
       je        near ptr M00_L26
       test      dword ptr [rdx+34],1600000
       je        near ptr M00_L27
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD577FF618]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M00_L13:
       mov       byte ptr [rdi+39],2
M00_L14:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker
       cmp       [r14],rcx
       jne       near ptr M00_L32
       mov       r15,r14
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_0
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       cmp       byte ptr [r15+10],0
       jne       near ptr M00_L30
       mov       rcx,[r15+8]
       cmp       [rcx],cl
       mov       eax,0FFFFFFFF
M00_L15:
       test      rbx,rbx
       jne       near ptr M00_L31
       mov       rdx,rsi
       test      rdx,rdx
       je        short M00_L17
M00_L16:
       inc       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L18
       mov       r8d,eax
       mov       rbx,[rdx+r8*8+10]
       jmp       short M00_L15
M00_L17:
       mov       rdx,[rcx+8]
       mov       rsi,[rdx+10]
       mov       rdx,rsi
       jmp       short M00_L16
M00_L18:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFD577FF168]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       r8,[r14+10]
       mov       rdx,[rcx+8]
       mov       [rsp+20],rdi
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       xor       r9d,r9d
       call      qword ptr [7FFD577FF960]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       test      eax,eax
       je        short M00_L18
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
       mov       [rbx+18],rcx
       mov       rcx,2B2E28021E0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.ContinuationTaskFromTask
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],ecx
       mov       dword ptr [rsp+30],200
       mov       [rsp+38],rcx
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD577FE718]; System.Threading.Tasks.Task..ctor(System.Delegate, System.Object, System.Threading.Tasks.Task, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[r15+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsp+20],80000
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD577FFAB0]; System.Threading.Tasks.Task.ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
       mov       rax,[r14+10]
M00_L19:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       ecx,2D
       call      qword ptr [7FFD573E78D0]
       int       3
M00_L21:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerFacade
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B2E2802390
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFD575442A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L22:
       mov       ecx,0C
       call      qword ptr [7FFD57876D18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L05
       test      r15b,4
       je        near ptr M00_L05
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L05
       call      qword ptr [7FFD57877708]
       jmp       near ptr M00_L05
M00_L24:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L14
       movzx     r8d,byte ptr [rdi+3A]
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFD577FF618]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L14
M00_L25:
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FFD5787D290]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L26:
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5787C150]
       jmp       near ptr M00_L13
M00_L27:
       mov       rcx,rdx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD5787D2A8]
       jmp       near ptr M00_L14
M00_L28:
       call      qword ptr [7FFD578773F0]
       int       3
M00_L29:
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD57875368]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L14
       jmp       near ptr M00_L09
M00_L30:
       mov       rcx,r14
       call      qword ptr [7FFD57877F00]
       int       3
M00_L31:
       mov       rdx,[rbx+20]
       mov       r8,[rbx+8]
       mov       rbx,[rbx+10]
       cmp       r8,rdi
       jne       near ptr M00_L15
       mov       [rbp-48],rdx
       mov       rax,[rbp-48]
       jmp       near ptr M00_L19
M00_L32:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFD57110A48
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1523
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass1_0`1[[System.Int32, System.Private.CoreLib]].<RegisterItemWithTrackerAsync>b__0()
; 		var task = Task.Run(() => action(item));
; 		                          ^^^^^^^^^^^^
       mov       r8,[rcx+8]
       mov       edx,[rcx+10]
       mov       rax,offset DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark+<>c.<.cctor>b__12_1(Int32)
       cmp       [r8+18],rax
       jne       short M01_L00
       mov       rax,2B2E2800C08
       mov       rax,[rax]
       ret
M01_L00:
       mov       rcx,[r8+8]
       jmp       qword ptr [r8+18]
; Total bytes of code 45
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFD578C8EA8
       call      qword ptr [7FFD571CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L04
       call      qword ptr [7FFD578773F0]
       int       3
M02_L04:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       test      rax,rax
       jne       short M02_L00
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       jmp       short M02_L00
; Total bytes of code 140
```
```assembly
; System.Threading.ExecutionContext.Capture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       short M03_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        short M03_L03
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFD573EFF48]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M03_L04
       mov       rax,2B2E28021F0
       mov       rax,[rax]
M03_L02:
       add       rsp,28
       ret
M03_L03:
       mov       ecx,4
       call      qword ptr [7FFD57876D18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L04:
       xor       ecx,ecx
       cmp       byte ptr [rax+18],0
       cmovne    rax,rcx
       jmp       short M03_L02
; Total bytes of code 109
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
       jne       near ptr M04_L19
       or        dword ptr [rcx+34],10000
M04_L00:
       cmp       byte ptr [7FFD5710B0CC],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,2B2E2802200
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L10
M04_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M04_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M04_L11
       mov       rdx,2B2E2802208
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      sil,1
       jne       short M04_L06
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],9
       jle       near ptr M04_L13
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M04_L13
M04_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M04_L14
M04_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M04_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M04_L08
       test      eax,eax
       jge       short M04_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD5787C0F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M04_L09
M04_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M04_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M04_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M04_L18
       mov       rcx,2B2E2802230
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD577FEC28]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rdx,rsi
       call      qword ptr [7FFD57877ED0]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L03
M04_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B2E2802348
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD5787D320]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD577FED90]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,2F377860C48
       call      qword ptr [7FFD577FEE98]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFD5787D338]
       jmp       near ptr M04_L18
M04_L12:
       mov       rdx,2B2E2802220
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M04_L04
       mov       rdx,2B2E2802220
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD5787C0C0]
       jmp       near ptr M04_L04
M04_L13:
       mov       ecx,9
       call      qword ptr [7FFD57876D18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787C0D8]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rcx,rbx
       call      qword ptr [7FFD577FEE08]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7FFD5787D308]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7FFD57877DC8]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M04_L02
       call      qword ptr [7FFD578779D8]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFD57877E40]
       mov       rdx,rax
       mov       rcx,2F377860BC0
       call      qword ptr [7FFD571C7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFD57877DB0]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD57877E58]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FFD57877E70]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFD57877E88]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD57877EA0]
       test      eax,200
       jne       short M04_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877EB8]
M04_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       call      00007FFDB6E00B20
       test      eax,eax
       je        near ptr M05_L19
       movzx     edi,byte ptr [rbx+39]
       test      edi,edi
       jne       near ptr M05_L06
       mov       byte ptr [rbx+39],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M05_L07
       test      edx,400000
       jne       near ptr M05_L08
       test      edx,1000000
       je        near ptr M05_L09
       mov       edi,5
M05_L00:
       cmp       edi,5
       jne       near ptr M05_L12
       mov       rcx,rsi
       mov       rdx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rdx
       jne       near ptr M05_L13
       xor       ecx,ecx
M05_L01:
       test      rcx,rcx
       jne       near ptr M05_L16
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       jne       near ptr M05_L14
M05_L02:
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M05_L15
       mov       rdx,[rcx+38]
M05_L03:
       test      rdx,rdx
       je        near ptr M05_L17
       test      dword ptr [rdx+34],1600000
       je        near ptr M05_L18
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD577FF618]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M05_L04:
       mov       byte ptr [rbx+39],2
M05_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L06:
       cmp       edi,1
       jne       short M05_L05
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD577FF618]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M05_L04
M05_L07:
       mov       edi,7
       jmp       near ptr M05_L00
M05_L08:
       mov       edi,6
       jmp       near ptr M05_L00
M05_L09:
       test      edx,800000
       je        short M05_L10
       mov       edi,4
       jmp       near ptr M05_L00
M05_L10:
       test      edx,20000
       je        short M05_L11
       mov       edi,3
       jmp       near ptr M05_L00
M05_L11:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M05_L00
M05_L12:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        short M05_L05
       movzx     r8d,byte ptr [rbx+3A]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD577FF618]; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M05_L05
M05_L13:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Threading.Tasks.VoidTaskResult>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M05_L01
M05_L14:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L15:
       mov       edx,1
       call      qword ptr [7FFD5787D290]
       mov       rdx,rax
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFD5787C138]
       mov       rdx,rax
       jmp       near ptr M05_L03
M05_L17:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5787C150]
       jmp       near ptr M05_L04
M05_L18:
       mov       rcx,rdx
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD5787D2A8]
M05_L19:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD57877DF8]
; Total bytes of code 501
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       mov       eax,[rcx+34]
       test      eax,200000
       jne       short M06_L01
       test      eax,400000
       jne       short M06_L02
       test      eax,1000000
       je        short M06_L03
       mov       eax,5
M06_L00:
       ret
M06_L01:
       mov       eax,7
       jmp       short M06_L00
M06_L02:
       mov       eax,6
       jmp       short M06_L00
M06_L03:
       test      eax,800000
       je        short M06_L04
       mov       eax,4
       jmp       short M06_L00
M06_L04:
       test      eax,20000
       je        short M06_L05
       mov       eax,3
       jmp       short M06_L00
M06_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M06_L00
; Total bytes of code 100
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M07_L00:
       mov       rcx,2B2E2802200
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M07_L21
M07_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M07_L22
       test      ecx,400000
       jne       near ptr M07_L23
       test      ecx,1000000
       je        near ptr M07_L24
       mov       edx,5
M07_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M07_L27
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M07_L29
M07_L03:
       cmp       byte ptr [7FFD5710B0CC],0
       jne       near ptr M07_L30
M07_L04:
       mov       rdi,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.VoidTaskResult>
       cmp       [rdi],rcx
       jne       near ptr M07_L31
M07_L05:
       test      rdi,rdi
       je        near ptr M07_L32
       mov       ecx,[rdi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        near ptr M07_L11
       test      dword ptr [rdi+34],1600000
       jne       short M07_L06
       mov       rcx,rdi
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFD5787C108]
M07_L06:
       test      dword ptr [rdi+34],10000000
       jne       near ptr M07_L33
M07_L07:
       mov       ecx,[rdi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr M07_L11
       xor       esi,esi
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M07_L08
       mov       rcx,offset MT_System.Threading.Tasks.TaskCanceledException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD5787D440]
       mov       rcx,rsi
       call      qword ptr [7FFD5787D458]
M07_L08:
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M07_L09
       cmp       qword ptr [rcx+18],0
       jne       near ptr M07_L18
M07_L09:
       test      rsi,rsi
       je        near ptr M07_L19
       mov       rcx,offset MT_System.Exception[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFD5787D488]
       mov       rbp,rsi
M07_L10:
       test      rbp,rbp
       jne       near ptr M07_L35
M07_L11:
       mov       sil,[rdi+38]
M07_L12:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M07_L16
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M07_L36
M07_L13:
       mov       [rbx+38],sil
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M07_L37
M07_L14:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M07_L38
       mov       rdx,2B2E2800BF0
       mov       rdx,[rdx]
       call      00007FFDB6DFC330
       test      rax,rax
       jne       short M07_L20
M07_L15:
       mov       edi,1
M07_L16:
       mov       eax,edi
M07_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L18:
       mov       rcx,[rcx+18]
       cmp       qword ptr [rcx+10],0
       je        near ptr M07_L09
       jmp       near ptr M07_L34
M07_L19:
       xor       ebp,ebp
       jmp       near ptr M07_L10
M07_L20:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFD577FF540]; System.Threading.Tasks.Task.RunContinuations(System.Object)
       jmp       short M07_L15
M07_L21:
       mov       rcx,rbx
       call      qword ptr [7FFD578779D8]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FFD57877F48]
       jmp       near ptr M07_L01
M07_L22:
       mov       edx,7
       jmp       near ptr M07_L02
M07_L23:
       mov       edx,6
       jmp       near ptr M07_L02
M07_L24:
       test      ecx,800000
       je        short M07_L25
       mov       edx,4
       jmp       near ptr M07_L02
M07_L25:
       test      ecx,20000
       je        short M07_L26
       mov       edx,3
       jmp       near ptr M07_L02
M07_L26:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M07_L02
M07_L27:
       cmp       edx,2
       ja        near ptr M07_L17
       mov       ecx,edx
       lea       rax,[7FFD579056B0]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M07_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FFD5787D3F8]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5787D410]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5787C150]
       jmp       near ptr M07_L17
       mov       rcx,rsi
       call      qword ptr [7FFD5787D428]
       mov       rsi,rax
       test      dil,dil
       je        short M07_L28
       cmp       dword ptr [rsi+10],0
       jle       short M07_L28
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD572B3578]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rbp,rax
       test      rbp,rbp
       je        short M07_L28
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L28
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD5787C150]
       jmp       near ptr M07_L17
M07_L28:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5787C1B0]
       jmp       near ptr M07_L17
M07_L29:
       mov       rcx,rbx
       call      qword ptr [7FFD578779D8]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FFD578779F0]
       jmp       near ptr M07_L03
M07_L30:
       mov       rcx,rbx
       call      qword ptr [7FFD57877A20]
       jmp       near ptr M07_L04
M07_L31:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M07_L05
M07_L32:
       xor       esi,esi
       jmp       near ptr M07_L12
M07_L33:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M07_L07
       mov       rcx,rdi
       call      qword ptr [7FFD5787C030]
       jmp       near ptr M07_L07
M07_L34:
       mov       rcx,[rdi+28]
       mov       rcx,[rcx+18]
       mov       r8,rsi
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787D470]
       mov       rbp,rax
       jmp       near ptr M07_L10
M07_L35:
       mov       rcx,rdi
       call      qword ptr [7FFD5787D4A0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M07_L36:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFD57877E28]
       test      eax,eax
       je        near ptr M07_L16
       jmp       near ptr M07_L13
M07_L37:
       mov       rcx,rbx
       call      qword ptr [7FFD57877A68]
       mov       rcx,rdi
       call      qword ptr [7FFD5787C1E0]
       jmp       near ptr M07_L14
M07_L38:
       call      qword ptr [7FFD578773F0]
       int       3
; Total bytes of code 1081
```
```assembly
; DotNetTips.Spargine.Core.Ulid.NewUlid()
; 		Span<char> ulidChars = stackalloc char[UlidLength];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> timestampBytes = stackalloc byte[6];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new Ulid(new string(ulidChars));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,0DD79090D30FD
       mov       [rbp+48],rax
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       mov       rbx,rcx
       lea       rsi,[rbp+40]
       lea       rdi,[rbp+30]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD577F57B8]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rcx,rcx,[rbp+28]
       shr       rcx,0B
       mov       rdx,0FFFFC77CEDD32800
       add       rcx,rdx
       mov       rdx,rcx
       sar       rdx,28
       mov       [rsi],dl
       mov       rdx,rcx
       sar       rdx,20
       mov       [rsi+1],dl
       mov       rdx,rcx
       sar       rdx,18
       mov       [rsi+2],dl
       mov       rdx,rcx
       sar       rdx,10
       mov       [rsi+3],dl
       mov       rdx,rcx
       sar       rdx,8
       mov       [rsi+4],dl
       mov       [rsi+5],cl
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
M08_L00:
       cmp       ecx,6
       jae       near ptr M08_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       mov       r10d,3
       sub       r10d,edx
       jo        near ptr M08_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M08_L14
       cmp       edx,8
       jge       near ptr M08_L03
M08_L01:
       mov       r10d,eax
       lea       r10,[rbx+r10*2]
       mov       r14,2F377862A54
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       eax,1
       jo        near ptr M08_L14
       cmp       eax,0A
       jge       near ptr M08_L05
       cmp       edx,3
       jle       short M08_L00
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M08_L14
       cmp       r8d,6
       jge       short M08_L04
       mov       r10d,r8d
       cmp       r10d,6
       jae       near ptr M08_L13
       movzx     r10d,byte ptr [rsi+r10]
M08_L02:
       cmp       ecx,6
       jae       near ptr M08_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rsi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,edx
       jo        near ptr M08_L14
       sub       r10d,5
       jo        near ptr M08_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       edx,5
       jo        near ptr M08_L14
       and       edx,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M08_L01
M08_L03:
       sub       edx,8
       jo        near ptr M08_L14
       add       ecx,1
       jo        near ptr M08_L14
       jmp       near ptr M08_L01
M08_L04:
       xor       r10d,r10d
       jmp       short M08_L02
M08_L05:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFD575F51E8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       xor       eax,eax
       xor       edx,edx
M08_L06:
       cmp       ecx,0A
       jae       near ptr M08_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       mov       r10d,3
       sub       r10d,eax
       jo        near ptr M08_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M08_L14
       cmp       eax,8
       jge       near ptr M08_L09
M08_L07:
       mov       r10d,edx
       add       r10d,0A
       jo        near ptr M08_L14
       lea       r10,[rbx+r10*2]
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       edx,1
       jo        near ptr M08_L14
       cmp       edx,10
       jge       near ptr M08_L11
       cmp       eax,3
       jle       short M08_L06
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M08_L14
       cmp       r8d,0A
       jge       short M08_L10
       mov       r10d,r8d
       cmp       r10d,0A
       jae       near ptr M08_L13
       movzx     r10d,byte ptr [rdi+r10]
M08_L08:
       cmp       ecx,0A
       jae       near ptr M08_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rdi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,eax
       jo        near ptr M08_L14
       sub       r10d,5
       jo        near ptr M08_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       eax,5
       jo        short M08_L14
       and       eax,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M08_L07
M08_L09:
       sub       eax,8
       jo        short M08_L14
       add       ecx,1
       jo        short M08_L14
       jmp       near ptr M08_L07
M08_L10:
       xor       r10d,r10d
       jmp       short M08_L08
M08_L11:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFD577FF8E8]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,0DD79090D30FD
       cmp       [rbp+48],r8
       je        short M08_L12
       call      CORINFO_HELP_FAIL_FAST
M08_L12:
       nop
       lea       rsp,[rbp+50]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M08_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rdx,r8
       movzx     r9d,r9b
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M09_L33
       cmp       qword ptr [rbp-48],0
       jne       near ptr M09_L28
       cmp       [rdx],dl
       mov       rcx,2B2E2800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M09_L32
       lea       rcx,[rdx+0C]
       mov       eax,[rdx+8]
       add       eax,eax
       mov       r8d,0D43C1380
       mov       r10d,610DCDB3
       cmp       eax,8
       jb        near ptr M09_L29
       mov       r9d,eax
       shr       r9d,3
       nop       dword ptr [rax]
M09_L00:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M09_L00
       test      al,4
       je        short M09_L02
M09_L01:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
M09_L02:
       mov       r9d,eax
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       eax
       shl       eax,3
       shrx      ecx,ecx,eax
M09_L03:
       add       ecx,r8d
       mov       eax,r10d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M09_L04:
       mov       [rbp-34],eax
M09_L05:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],ebx
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,[rbp-34]
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-38],edx
       cmp       r10d,r9d
       jae       near ptr M09_L40
       mov       ecx,r10d
       lea       rsi,[r8+rcx*8+10]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       byte ptr [rbp+40],0
       je        short M09_L07
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M09_L23
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M09_L11
       mov       rcx,r14
       call      00007FFDB6E4E120
       test      eax,eax
       je        near ptr M09_L12
M09_L06:
       mov       dword ptr [rbp-3C],1
M09_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[rbx+8]
       jne       near ptr M09_L13
       mov       r14,[rsi]
       test      r14,r14
       jne       near ptr M09_L16
M09_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M09_L10
M09_L09:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15,[rsi]
       lea       rcx,[r14+20]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-34]
       mov       [r14+18],ecx
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       edx,[rcx+8]
       cmp       [rbp-38],edx
       jae       near ptr M09_L23
       mov       edx,[rbp-38]
       lea       rcx,[rcx+rdx*4+10]
       mov       edx,[rcx]
       add       edx,1
       jo        near ptr M09_L24
       mov       [rcx],edx
       mov       ecx,1
       cmp       edx,[rbx+10]
       cmovg     edi,ecx
       jmp       near ptr M09_L25
M09_L10:
       mov       rdx,7FFD578494D8
       call      qword ptr [7FFD571CC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M09_L09
M09_L11:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A48]
       int       3
M09_L12:
       mov       rcx,r14
       call      qword ptr [7FFD57877168]
       jmp       near ptr M09_L06
M09_L13:
       mov       rcx,[rbx+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-48]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        near ptr M09_L36
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M09_L14
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r11,7FFD57110A90
       call      qword ptr [r11]
       jmp       short M09_L15
M09_L14:
       mov       rdx,[rbp+20]
       cmp       [rdx],dl
       mov       ecx,4
       call      qword ptr [7FFD577FFA38]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rcx,rax
       mov       rdx,[rbp+20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
M09_L15:
       mov       [rbp-34],eax
       jmp       near ptr M09_L36
M09_L16:
       mov       ecx,[rbp-34]
       cmp       ecx,[r14+18]
       jne       short M09_L19
       cmp       qword ptr [rbp-48],0
       je        short M09_L17
       mov       rdx,[r14+20]
       mov       rcx,[rbp-48]
       mov       r8,[rbp+20]
       mov       r11,7FFD57110A98
       call      qword ptr [r11]
       jmp       short M09_L18
M09_L17:
       mov       rcx,[r14+20]
       mov       rdx,[rbp+20]
       mov       r8d,4
       call      qword ptr [7FFD57334B40]; System.String.Equals(System.String, System.String, System.StringComparison)
M09_L18:
       test      eax,eax
       jne       short M09_L20
M09_L19:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M09_L16
       jmp       near ptr M09_L08
M09_L20:
       cmp       byte ptr [rbp+38],0
       je        short M09_L21
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M09_L22
M09_L21:
       mov       rdx,[r14+8]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M09_L22:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       near ptr M09_L37
M09_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M09_L25:
       cmp       dword ptr [rbp-3C],0
       je        short M09_L26
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M09_L40
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rcx,[rcx+rax*8+10]
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M09_L34
       mov       rcx,rsi
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M09_L35
M09_L26:
       test      edi,edi
       jne       near ptr M09_L38
M09_L27:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L28:
       mov       rcx,[rbp-48]
       mov       r11,7FFD57110A88
       call      qword ptr [r11]
       mov       rdx,[rbp+20]
       jmp       near ptr M09_L04
M09_L29:
       cmp       eax,4
       jae       near ptr M09_L01
       mov       r9d,80
       test      al,1
       je        short M09_L30
       mov       r9d,eax
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M09_L30:
       test      al,2
       je        short M09_L31
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M09_L03
M09_L31:
       mov       ecx,r9d
       jmp       near ptr M09_L03
M09_L32:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,[rbp+20]
       jmp       near ptr M09_L04
M09_L33:
       mov       eax,ebx
       jmp       near ptr M09_L04
M09_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A48]
       int       3
M09_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFD57876B50]
       jmp       near ptr M09_L26
M09_L36:
       call      M09_L41
       jmp       near ptr M09_L05
M09_L37:
       call      M09_L41
       jmp       short M09_L39
M09_L38:
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       mov       r8d,edi
       xor       r9d,r9d
       call      qword ptr [7FFD577FF9F0]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M09_L27
M09_L39:
       mov       eax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L41:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M09_L42
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       short M09_L44
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M09_L43
       mov       rcx,rdi
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M09_L42
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFD57876B50]
M09_L42:
       nop
       add       rsp,28
       ret
M09_L43:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A48]
       int       3
M09_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1413
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
; 				_ = this._tasksByKey.TryRemove(key, out _);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (t.IsFaulted && t.Exception is not null)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						onException?.Invoke(t.Exception);
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					catch (Exception)
; 					^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       mov       rcx,[r8+8]
       mov       rdx,[rbx+10]
       cmp       [rcx],cl
       xor       r8d,r8d
       mov       [rsp+20],r8
       lea       r8,[rbp-18]
       xor       r9d,r9d
       call      qword ptr [7FFD577FFC30]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryRemoveInternal(DotNetTips.Spargine.Core.Ulid, System.__Canon ByRef, Boolean, System.__Canon)
       test      dword ptr [rsi+34],200000
       jne       short M10_L01
M10_L00:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M10_L01:
       mov       rcx,rsi
       call      qword ptr [7FFD577FFC18]
       test      rax,rax
       je        short M10_L00
       mov       rcx,[rbx+8]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M10_L00
       mov       rcx,rsi
       call      qword ptr [7FFD577FFC18]
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M10_L00
       sub       rsp,28
       lea       rax,[M10_L00]
       add       rsp,28
       ret
; Total bytes of code 144
```
```assembly
; System.Threading.Tasks.Task..ctor(System.Delegate, System.Object, System.Threading.Tasks.Task, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       rdi,r9
       mov       r14d,[rsp+88]
       mov       r15d,[rsp+90]
       test      rsi,rsi
       je        near ptr M11_L10
       test      rdi,rdi
       jne       near ptr M11_L11
M11_L00:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,0FFFFFFA0
       jne       near ptr M11_L12
       mov       ecx,r14d
       or        ecx,r15d
       mov       eax,ecx
       or        eax,2000000
       test      r15d,200
       cmove     eax,ecx
       mov       [rbx+34],eax
       mov       rcx,[rbx+28]
       test      rcx,rcx
       jne       near ptr M11_L13
M11_L01:
       mov       rsi,[rsp+80]
       test      rsi,rsi
       jne       near ptr M11_L14
M11_L02:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M11_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M11_L15
M11_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M11_L04
       call      qword ptr [7FFD573EFF48]; System.Threading.Thread.InitializeCurrentThread()
M11_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        short M11_L05
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       short M11_L06
M11_L05:
       mov       rcx,2B2E28021F0
       mov       rsi,[rcx]
M11_L06:
       test      rsi,rsi
       je        short M11_L08
       mov       rcx,2B2E28021F0
       cmp       rsi,[rcx]
       je        short M11_L09
       mov       rax,[rbx+28]
       test      rax,rax
       jne       short M11_L07
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M11_L07:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L09
M11_L08:
       or        dword ptr [rbx+34],20000000
M11_L09:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L10:
       mov       ecx,1C
       call      qword ptr [7FFD573EC228]
       int       3
M11_L11:
       test      r14b,4
       je        near ptr M11_L00
       mov       rcx,rbx
       call      qword ptr [7FFD57877768]
       lea       rcx,[rax+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L00
M11_L12:
       mov       ecx,2D
       call      qword ptr [7FFD573E78D0]
       int       3
M11_L13:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M11_L01
       test      r14b,4
       je        near ptr M11_L01
       test      byte ptr [rcx+34],8
       jne       near ptr M11_L01
       call      qword ptr [7FFD57877708]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD57877720]
       jmp       near ptr M11_L02
M11_L15:
       mov       ecx,4
       call      qword ptr [7FFD57876D18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M11_L03
; Total bytes of code 509
```
```assembly
; System.Threading.Tasks.Task.ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+78],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_System.Threading.Tasks.ContinueWithTaskContinuation
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rsp+80]
       mov       [rbp+18],r14d
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2B2E2802200
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M12_L08
M12_L00:
       cmp       byte ptr [7FFD5710B0CC],0
       jne       near ptr M12_L09
M12_L01:
       cmp       qword ptr [rsp+78],0
       jne       near ptr M12_L10
M12_L02:
       test      dword ptr [rsi+34],1600000
       jne       short M12_L06
       test      word ptr [rbx+34],400
       je        short M12_L04
       mov       rax,rbx
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Threading.Tasks.VoidTaskResult>
       cmp       [rax],rdx
       jne       near ptr M12_L13
M12_L03:
       test      rax,rax
       je        near ptr M12_L14
M12_L04:
       test      dword ptr [rbx+34],1600000
       je        short M12_L07
M12_L05:
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFD57869BF8]; System.Threading.Tasks.ContinueWithTaskContinuation.Run(System.Threading.Tasks.Task, Boolean)
M12_L06:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L07:
       cmp       qword ptr [rbx+20],0
       jne       near ptr M12_L16
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M12_L15
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       test      rax,rax
       je        short M12_L06
       jmp       near ptr M12_L16
M12_L08:
       mov       rcx,[rbp+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD578779D8]
       mov       edi,eax
       mov       rcx,[rsi+8]
       call      qword ptr [7FFD57877E40]
       mov       rdx,rax
       mov       rcx,2F377862B38
       call      qword ptr [7FFD571C7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,edi
       mov       rcx,2B2E2802200
       mov       rcx,[rcx]
       xor       r9d,r9d
       call      qword ptr [7FFD57877DB0]
       jmp       near ptr M12_L00
M12_L09:
       mov       rcx,[rbp+8]
       call      qword ptr [7FFD57877DC8]
       jmp       near ptr M12_L01
M12_L10:
       test      dword ptr [rbx+34],1600000
       jne       short M12_L11
       lea       rcx,[rsp+78]
       call      qword ptr [7FFD578777F8]
       test      eax,eax
       je        short M12_L12
M12_L11:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877720]
       jmp       near ptr M12_L02
M12_L12:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r8,rbx
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877720]
       jmp       near ptr M12_L02
M12_L13:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.ITaskCompletionAction
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M12_L03
M12_L14:
       mov       rax,2B2E2802200
       mov       rdi,[rax]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M12_L04
       call      qword ptr [7FFD57877870]
       mov       rcx,rax
       mov       rax,2B2E28021E0
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFD577FE700]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       r14d,eax
       call      qword ptr [7FFD57877F18]
       mov       [rsp+28],rax
       mov       rcx,rsi
       call      qword ptr [7FFD578779D8]
       mov       r9d,eax
       mov       edx,r14d
       mov       r8d,[rsp+2C]
       mov       rcx,rdi
       call      qword ptr [7FFD57877F30]
       jmp       near ptr M12_L04
M12_L15:
       call      qword ptr [7FFD578773F0]
       int       3
M12_L16:
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFD57875368]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M12_L06
       jmp       near ptr M12_L05
; Total bytes of code 595
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFD571C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M14_L00
       mov       rax,[rcx+18]
       ret
M14_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       jmp       qword ptr [rax]
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD9C9B1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M15_L01
       cmp       [rax],ecx
       jle       short M15_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M15_L03
M15_L00:
       add       rsp,20
       pop       rbx
       ret
M15_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M15_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M15_L00
M15_L02:
       cmp       [rax+4],edx
       jle       short M15_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M15_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M15_L03
       jmp       short M15_L00
M15_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,2B2E2800BF0
       cmp       r14,[rdx]
       jne       short M16_L01
M16_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M16_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD573EDA40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M16_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M16_L02
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M16_L03
M16_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M16_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M16_L04
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M16_L09
M16_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M16_L09
M16_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M16_L06
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M16_L07
M16_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M16_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M16_L08
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M16_L09
M16_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M16_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M16_L10
       call      qword ptr [7FFD578773F0]
       int       3
M16_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FFDB6DF21C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M16_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M16_L00
M16_L11:
       mov       [rbp-48],r15
       xor       edx,edx
       mov       [rbp-38],edx
       lea       rdx,[rbp-38]
       mov       rcx,r15
       call      qword ptr [7FFD571C5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,2B2E2800BF0
       cmp       rcx,[rax]
       jne       short M16_L12
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       near ptr M16_L18
M16_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M16_L14
       mov       rcx,2B2E2800C48
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M16_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B2E2800C18
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FFD578797B8
       call      qword ptr [7FFD571C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B2E2800C48
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M16_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787D1D0]
M16_L14:
       test      dil,dil
       je        short M16_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFD572B35F0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       jmp       short M16_L19
M16_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       ebx,[r15+10]
       cmp       [rcx+8],ebx
       jbe       short M16_L16
       lea       edx,[rbx+1]
       mov       [r15+10],edx
       mov       edx,ebx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M16_L19
M16_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5733E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M16_L19
M16_L17:
       mov       rcx,r15
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M16_L20
M16_L18:
       call      M16_L22
       jmp       short M16_L21
M16_L19:
       cmp       byte ptr [rbp-38],0
       jne       short M16_L17
M16_L20:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L21:
       mov       eax,[rbp-3C]
       movzx     eax,al
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-38],0
       je        short M16_L23
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M16_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 727
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark.RegisterManyWithTracker()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,[rcx+1A8]
       test      rax,rax
       je        near ptr M00_L32
       lea       rbx,[rax+10]
       mov       esi,[rax+8]
M00_L00:
       mov       [rbp-0C0],rbx
       mov       [rbp-54],esi
       mov       rbx,[rcx+1B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass2_0<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,20812800D50
       mov       rdi,[rcx]
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M00_L33
M00_L01:
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      esi,esi
       je        near ptr M00_L34
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Ulid[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       [rbp-70],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       near ptr M00_L19
M00_L03:
       mov       rcx,[r13+8]
       mov       r8,[rcx+10]
       mov       [rbp-98],r8
       lea       rcx,[rax+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-98]
       mov       rax,[rbp-78]
       jmp       near ptr M00_L29
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFD577FF678]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       lea       rcx,[r13+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       mov       r8,[r13+10]
       mov       rdx,[rcx+8]
       mov       [rsp+20],r15
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       xor       r9d,r9d
       call      qword ptr [7FFD577FFD38]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      eax,eax
       je        short M00_L04
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
       mov       [r12+18],rcx
       mov       [rbp-0A0],rbx
       mov       rcx,offset MT_System.Threading.Tasks.ContinuationTaskFromTask
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       r12,[rbp-0A8]
       mov       [r12+10],rax
       mov       [r12+18],rax
       mov       dword ptr [r12+34],2000200
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L05
       call      qword ptr [7FFD573DFF48]; System.Threading.Thread.InitializeCurrentThread()
M00_L05:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        short M00_L06
       cmp       byte ptr [rdi+18],0
       je        short M00_L07
       xor       edi,edi
       jmp       short M00_L07
M00_L06:
       mov       rcx,208288001F0
       mov       rdi,[rcx]
M00_L07:
       test      rdi,rdi
       je        short M00_L09
       mov       rcx,208288001F0
       cmp       rdi,[rcx]
       je        short M00_L10
       mov       rax,[r12+28]
       test      rax,rax
       jne       short M00_L08
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r12+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
M00_L08:
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       or        dword ptr [r12+34],20000000
M00_L10:
       lea       rcx,[r12+38]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Tasks.ContinueWithTaskContinuation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],80000
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20828800200
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L37
M00_L11:
       cmp       byte ptr [7FFD570FB0CC],0
       jne       near ptr M00_L38
M00_L12:
       test      dword ptr [r12+34],1600000
       jne       short M00_L16
       test      word ptr [r15+34],400
       jne       near ptr M00_L39
M00_L13:
       test      dword ptr [r15+34],1600000
       jne       short M00_L15
       cmp       qword ptr [r15+20],0
       jne       short M00_L14
       lea       rcx,[r15+20]
       test      rcx,rcx
       je        near ptr M00_L44
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       test      rax,rax
       je        short M00_L16
M00_L14:
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD57877810]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L16
M00_L15:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,1
       call      qword ptr [7FFD57866180]; System.Threading.Tasks.ContinueWithTaskContinuation.Run(System.Threading.Tasks.Task, Boolean)
M00_L16:
       mov       rdx,[r13+10]
M00_L17:
       mov       rcx,[rbp-70]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rax+8],r8d
       jbe       near ptr M00_L42
       lea       r10d,[r8+1]
       mov       [rcx+10],r10d
       lea       rcx,[rax+r8*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L18:
       mov       eax,[rbp-3C]
       add       eax,1
       jo        near ptr M00_L45
       mov       [rbp-3C],eax
M00_L19:
       mov       ecx,[rbp-3C]
       cmp       ecx,[rbp-54]
       jge       near ptr M00_L31
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass2_1<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       rsi,[rbp-0C0]
       mov       ecx,[rsi+rcx*4]
       mov       [rbx+10],ecx
       mov       rcx,offset MT_System.Action
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass2_1`1[[System.Int32, System.Private.CoreLib]].<RegisterManyWithTracker>b__0()
       mov       [rdi+18],rcx
       mov       rcx,208288001E0
       mov       rbx,[rcx]
       mov       r14,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L35
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L20:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L21
       call      qword ptr [7FFD573DFF48]; System.Threading.Thread.InitializeCurrentThread()
M00_L21:
       mov       r14,[rax+8]
       test      r14,r14
       je        short M00_L22
       cmp       byte ptr [r14+18],0
       je        short M00_L23
       xor       r14d,r14d
       jmp       short M00_L23
M00_L22:
       mov       rcx,208288001F0
       mov       r14,[rcx]
M00_L23:
       test      r14,r14
       je        short M00_L25
       mov       rcx,208288001F0
       cmp       r14,[rcx]
       je        short M00_L26
       mov       rax,[r15+28]
       test      rax,rax
       jne       short M00_L24
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r15+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M00_L24:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L25:
       or        dword ptr [r15+34],20000000
M00_L26:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFD577FECE8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker
       mov       r14,[rbp-68]
       cmp       [r14],rcx
       jne       near ptr M00_L41
       mov       r13,r14
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+10],rcx
       cmp       byte ptr [r13+10],0
       jne       near ptr M00_L43
       mov       r13,[r13+8]
       mov       rax,r13
       mov       [rbp-80],rax
       cmp       [rax],al
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<DotNetTips.Spargine.Core.Ulid, System.Threading.Tasks.Task>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       [rbp-78],rax
M00_L27:
       mov       r8,[rax+18]
       test      r8,r8
       jne       short M00_L30
M00_L28:
       mov       r8,[rax+10]
       test      r8,r8
       je        near ptr M00_L03
M00_L29:
       mov       r10d,[rax+20]
       inc       r10d
       mov       [rbp-40],r10d
       mov       ecx,[r8+8]
       cmp       ecx,r10d
       jbe       near ptr M00_L04
       mov       ecx,r10d
       mov       r8,[r8+rcx*8+10]
       mov       [rbp-0D8],r8
       lea       rcx,[rax+18]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       ecx,[rbp-40]
       mov       [rax+20],ecx
       mov       r8,[rbp-0D8]
       test      r8,r8
       je        short M00_L28
M00_L30:
       mov       r10,[r8+20]
       mov       [rbp-0D0],r10
       mov       [rbp-90],r8
       mov       rdx,[r8+8]
       lea       rcx,[rax+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+30]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       mov       rdx,[rcx+10]
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-78]
       mov       rax,[rcx+28]
       mov       rdx,[rcx+30]
       cmp       rax,r15
       mov       rax,rcx
       jne       near ptr M00_L27
       jmp       near ptr M00_L36
M00_L31:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-70]
       call      qword ptr [7FFD578742A0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core]]..ctor(System.Collections.Generic.IList`1<DotNetTips.Spargine.Core.Ulid>)
       mov       rax,rbx
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L32:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M00_L00
M00_L33:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Threading.TaskTrackerFacade
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20828800370
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFD575442A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L34:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Core.Ulid>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,208288001D0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L35:
       mov       ecx,4
       call      qword ptr [7FFD57876CD0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L20
M00_L36:
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L37:
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877AC8]
       mov       [rbp-58],eax
       mov       rcx,[r12+8]
       call      qword ptr [7FFD57877D38]
       mov       rdx,rax
       mov       rcx,248A7762B08
       call      qword ptr [7FFD571B7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,[rbp-58]
       mov       rcx,20828800200
       mov       rcx,[rcx]
       xor       r9d,r9d
       call      qword ptr [7FFD57877D50]
       jmp       near ptr M00_L11
M00_L38:
       mov       rcx,[rdi+8]
       call      qword ptr [7FFD57877D68]
       jmp       near ptr M00_L12
M00_L39:
       mov       rax,20828800200
       mov       rax,[rax]
       mov       [rbp-0B8],rax
       cmp       byte ptr [rax+9D],0
       je        near ptr M00_L13
       call      qword ptr [7FFD578779A8]
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L40
       mov       rcx,rbx
M00_L40:
       cmp       [rcx],ecx
       call      qword ptr [7FFD577FEC58]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       ebx,eax
       call      qword ptr [7FFD57877CD8]
       mov       [rbp-50],rax
       mov       rcx,r12
       call      qword ptr [7FFD57877AC8]
       mov       r9d,eax
       mov       edx,ebx
       mov       r8d,[rbp-4C]
       mov       rcx,[rbp-0B8]
       call      qword ptr [7FFD57877CF0]
       jmp       near ptr M00_L13
M00_L41:
       mov       rcx,r14
       mov       rdx,r15
       mov       r11,7FFD57100A48
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L42:
       call      qword ptr [7FFD578741C8]
       jmp       near ptr M00_L18
M00_L43:
       mov       rcx,r14
       call      qword ptr [7FFD57877CC0]
       int       3
M00_L44:
       call      qword ptr [7FFD578773D8]
       int       3
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2075
```
```assembly
; DotNetTips.Spargine.Core.Ulid.NewUlid()
; 		Span<char> ulidChars = stackalloc char[UlidLength];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> timestampBytes = stackalloc byte[6];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new Ulid(new string(ulidChars));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,14AF0F470BFB
       mov       [rbp+48],rax
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       mov       rbx,rcx
       lea       rsi,[rbp+40]
       lea       rdi,[rbp+30]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD577F58A8]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rcx,rcx,[rbp+28]
       shr       rcx,0B
       mov       rdx,0FFFFC77CEDD32800
       add       rcx,rdx
       mov       rdx,rcx
       sar       rdx,28
       mov       [rsi],dl
       mov       rdx,rcx
       sar       rdx,20
       mov       [rsi+1],dl
       mov       rdx,rcx
       sar       rdx,18
       mov       [rsi+2],dl
       mov       rdx,rcx
       sar       rdx,10
       mov       [rsi+3],dl
       mov       rdx,rcx
       sar       rdx,8
       mov       [rsi+4],dl
       mov       [rsi+5],cl
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
M01_L00:
       cmp       ecx,6
       jae       near ptr M01_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       mov       r10d,3
       sub       r10d,edx
       jo        near ptr M01_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M01_L14
       cmp       edx,8
       jge       near ptr M01_L03
M01_L01:
       mov       r10d,eax
       lea       r10,[rbx+r10*2]
       mov       r14,248A7762A24
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       eax,1
       jo        near ptr M01_L14
       cmp       eax,0A
       jge       near ptr M01_L05
       cmp       edx,3
       jle       short M01_L00
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L14
       cmp       r8d,6
       jge       short M01_L04
       mov       r10d,r8d
       cmp       r10d,6
       jae       near ptr M01_L13
       movzx     r10d,byte ptr [rsi+r10]
M01_L02:
       cmp       ecx,6
       jae       near ptr M01_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rsi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,edx
       jo        near ptr M01_L14
       sub       r10d,5
       jo        near ptr M01_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       edx,5
       jo        near ptr M01_L14
       and       edx,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M01_L01
M01_L03:
       sub       edx,8
       jo        near ptr M01_L14
       add       ecx,1
       jo        near ptr M01_L14
       jmp       near ptr M01_L01
M01_L04:
       xor       r10d,r10d
       jmp       short M01_L02
M01_L05:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFD575E51E8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       xor       eax,eax
       xor       edx,edx
M01_L06:
       cmp       ecx,0A
       jae       near ptr M01_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       mov       r10d,3
       sub       r10d,eax
       jo        near ptr M01_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M01_L14
       cmp       eax,8
       jge       near ptr M01_L09
M01_L07:
       mov       r10d,edx
       add       r10d,0A
       jo        near ptr M01_L14
       lea       r10,[rbx+r10*2]
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       edx,1
       jo        near ptr M01_L14
       cmp       edx,10
       jge       near ptr M01_L11
       cmp       eax,3
       jle       short M01_L06
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L14
       cmp       r8d,0A
       jge       short M01_L10
       mov       r10d,r8d
       cmp       r10d,0A
       jae       near ptr M01_L13
       movzx     r10d,byte ptr [rdi+r10]
M01_L08:
       cmp       ecx,0A
       jae       near ptr M01_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rdi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,eax
       jo        near ptr M01_L14
       sub       r10d,5
       jo        near ptr M01_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       eax,5
       jo        short M01_L14
       and       eax,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M01_L07
M01_L09:
       sub       eax,8
       jo        short M01_L14
       add       ecx,1
       jo        short M01_L14
       jmp       near ptr M01_L07
M01_L10:
       xor       r10d,r10d
       jmp       short M01_L08
M01_L11:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFD577FFCC0]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,14AF0F470BFB
       cmp       [rbp+48],r8
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+50]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, DotNetTips.Spargine.Core.Ulid, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rdx,r8
       movzx     r9d,r9b
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M02_L34
       cmp       qword ptr [rbp-48],0
       jne       near ptr M02_L29
       cmp       [rdx],dl
       mov       rcx,20812800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M02_L33
       lea       rcx,[rdx+0C]
       mov       eax,[rdx+8]
       add       eax,eax
       mov       r8d,0B82835B0
       mov       r10d,1D529B5D
       cmp       eax,8
       jb        near ptr M02_L28
       mov       r9d,eax
       shr       r9d,3
       nop       dword ptr [rax]
M02_L00:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M02_L00
       test      al,4
       je        short M02_L02
M02_L01:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
M02_L02:
       mov       r9d,eax
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       eax
       shl       eax,3
       shrx      ecx,ecx,eax
M02_L03:
       add       ecx,r8d
       mov       eax,r10d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M02_L04:
       mov       [rbp-34],eax
M02_L05:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],ebx
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,[rbp-34]
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-38],edx
       cmp       r10d,r9d
       jae       near ptr M02_L41
       mov       ecx,r10d
       lea       rsi,[r8+rcx*8+10]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       byte ptr [rbp+40],0
       je        short M02_L07
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M02_L23
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,r14
       call      00007FFDB6E4E120
       test      eax,eax
       je        near ptr M02_L12
M02_L06:
       mov       dword ptr [rbp-3C],1
M02_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[rbx+8]
       jne       near ptr M02_L13
       mov       r14,[rsi]
       test      r14,r14
       jne       near ptr M02_L16
M02_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M02_L10
M02_L09:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15,[rsi]
       lea       rcx,[r14+20]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-34]
       mov       [r14+18],ecx
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       edx,[rcx+8]
       cmp       [rbp-38],edx
       jae       near ptr M02_L23
       mov       edx,[rbp-38]
       lea       rcx,[rcx+rdx*4+10]
       mov       edx,[rcx]
       add       edx,1
       jo        near ptr M02_L24
       mov       [rcx],edx
       mov       ecx,1
       cmp       edx,[rbx+10]
       cmovg     edi,ecx
       jmp       near ptr M02_L25
M02_L10:
       mov       rdx,7FFD57849E40
       call      qword ptr [7FFD571BC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L09
M02_L11:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A00]
       int       3
M02_L12:
       mov       rcx,r14
       call      qword ptr [7FFD57877120]
       jmp       near ptr M02_L06
M02_L13:
       mov       rcx,[rbx+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-48]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        near ptr M02_L37
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M02_L14
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r11,7FFD57100A00
       call      qword ptr [r11]
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp+20]
       cmp       [rdx],dl
       mov       ecx,4
       call      qword ptr [7FFD577FFE10]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rcx,rax
       mov       rdx,[rbp+20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
M02_L15:
       mov       [rbp-34],eax
       jmp       near ptr M02_L37
M02_L16:
       mov       ecx,[rbp-34]
       cmp       ecx,[r14+18]
       jne       short M02_L19
       cmp       qword ptr [rbp-48],0
       je        short M02_L17
       mov       rdx,[r14+20]
       mov       rcx,[rbp-48]
       mov       r8,[rbp+20]
       mov       r11,7FFD57100A08
       call      qword ptr [r11]
       jmp       short M02_L18
M02_L17:
       mov       rcx,[r14+20]
       mov       rdx,[rbp+20]
       mov       r8d,4
       call      qword ptr [7FFD57324B40]; System.String.Equals(System.String, System.String, System.StringComparison)
M02_L18:
       test      eax,eax
       jne       short M02_L20
M02_L19:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M02_L16
       jmp       near ptr M02_L08
M02_L20:
       cmp       byte ptr [rbp+38],0
       je        short M02_L21
       lea       rcx,[r14+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M02_L22
M02_L21:
       mov       rdx,[r14+8]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L22:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       near ptr M02_L38
M02_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L25:
       cmp       dword ptr [rbp-3C],0
       je        short M02_L26
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       near ptr M02_L41
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rcx,[rcx+rax*8+10]
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M02_L35
       mov       rcx,rsi
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M02_L36
M02_L26:
       test      edi,edi
       jne       near ptr M02_L39
M02_L27:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L28:
       cmp       eax,4
       jb        short M02_L30
       jmp       near ptr M02_L01
M02_L29:
       mov       rcx,[rbp-48]
       mov       r11,7FFD571009F8
       call      qword ptr [r11]
       mov       rdx,[rbp+20]
       jmp       near ptr M02_L04
M02_L30:
       mov       r9d,80
       test      al,1
       je        short M02_L31
       mov       r9d,eax
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M02_L31:
       test      al,2
       je        short M02_L32
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M02_L03
M02_L32:
       mov       ecx,r9d
       jmp       near ptr M02_L03
M02_L33:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,[rbp+20]
       jmp       near ptr M02_L04
M02_L34:
       mov       eax,ebx
       jmp       near ptr M02_L04
M02_L35:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A00]
       int       3
M02_L36:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFD57876B08]
       jmp       near ptr M02_L26
M02_L37:
       call      M02_L42
       jmp       near ptr M02_L05
M02_L38:
       call      M02_L42
       jmp       short M02_L40
M02_L39:
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       mov       r8d,edi
       xor       r9d,r9d
       call      qword ptr [7FFD577FFDC8]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<DotNetTips.Spargine.Core.Ulid,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M02_L27
M02_L40:
       mov       eax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L42:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M02_L43
       mov       rcx,[rbp-50]
       mov       ecx,[rcx+8]
       cmp       [rbp-38],ecx
       jae       short M02_L45
       mov       rcx,[rbp-50]
       mov       eax,[rbp-38]
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M02_L44
       mov       rcx,rdi
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M02_L43
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFD57876B08]
M02_L43:
       nop
       add       rsp,28
       ret
M02_L44:
       xor       ecx,ecx
       call      qword ptr [7FFD57876A00]
       int       3
M02_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1414
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTracker+<>c__DisplayClass7_1.<Register>b__0(System.Threading.Tasks.Task)
; 				_ = this._tasksByKey.TryRemove(key, out _);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (t.IsFaulted && t.Exception is not null)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						onException?.Invoke(t.Exception);
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					catch (Exception)
; 					^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       mov       rcx,[r8+8]
       mov       rdx,[rbx+10]
       cmp       [rcx],cl
       xor       r8d,r8d
       mov       [rsp+20],r8
       lea       r8,[rbp-18]
       xor       r9d,r9d
       call      qword ptr [7FFD57874048]; System.Collections.Concurrent.ConcurrentDictionary`2[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core],[System.__Canon, System.Private.CoreLib]].TryRemoveInternal(DotNetTips.Spargine.Core.Ulid, System.__Canon ByRef, Boolean, System.__Canon)
       test      dword ptr [rsi+34],200000
       jne       short M03_L01
M03_L00:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M03_L01:
       mov       rcx,rsi
       call      qword ptr [7FFD57874030]
       test      rax,rax
       je        short M03_L00
       mov       rcx,[rbx+8]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M03_L00
       mov       rcx,rsi
       call      qword ptr [7FFD57874030]
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M03_L00
       sub       rsp,28
       lea       rax,[M03_L00]
       add       rsp,28
       ret
; Total bytes of code 144
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
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFD9C99AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD9C998FE8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,20812800BF0
       cmp       r14,[rdx]
       jne       short M05_L01
M05_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M05_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD573DDA58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M05_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M05_L02
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,rsi
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L03
M05_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5732E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M05_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M05_L04
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,r14
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L09
M05_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5732E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L09
M05_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M05_L06
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,r14
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L07
M05_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD5732E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M05_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       r13d,[r15+10]
       cmp       [rcx+8],r13d
       jbe       short M05_L08
       lea       edx,[r13+1]
       mov       [r15+10],edx
       mov       edx,r13d
       mov       r8,rsi
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L09
M05_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5732E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M05_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L10
       call      qword ptr [7FFD578773D8]
       int       3
M05_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FFDB6DF21C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M05_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M05_L00
M05_L11:
       mov       [rbp-48],r15
       xor       edx,edx
       mov       [rbp-38],edx
       lea       rdx,[rbp-38]
       mov       rcx,r15
       call      qword ptr [7FFD571B5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,20812800BF0
       cmp       rcx,[rax]
       jne       short M05_L12
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       near ptr M05_L18
M05_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M05_L14
       mov       rcx,20812800C48
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M05_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20812800C18
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FFD57879260
       call      qword ptr [7FFD571B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20812800C48
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M05_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787C3A8]
M05_L14:
       test      dil,dil
       je        short M05_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFD572A35F0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       jmp       short M05_L19
M05_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       ebx,[r15+10]
       cmp       [rcx+8],ebx
       jbe       short M05_L16
       lea       edx,[rbx+1]
       mov       [r15+10],edx
       mov       edx,ebx
       mov       r8,rsi
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L19
M05_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD5732E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M05_L19
M05_L17:
       mov       rcx,r15
       call      qword ptr [7FFD571B6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M05_L20
M05_L18:
       call      M05_L22
       jmp       short M05_L21
M05_L19:
       cmp       byte ptr [rbp-38],0
       jne       short M05_L17
M05_L20:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       eax,[rbp-3C]
       movzx     eax,al
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-38],0
       je        short M05_L23
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD571B6820]; System.Threading.Monitor.Exit(System.Object)
M05_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 732
```
```assembly
; System.Threading.Tasks.ContinueWithTaskContinuation.Run(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       esi,r8d
       mov       rdi,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       r14d,[rbx+18]
       mov       ecx,[rdx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L02
       test      r14d,10000
       jne       near ptr M06_L06
M06_L00:
       mov       rcx,20828800200
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       short M06_L04
M06_L01:
       mov       rdx,[rbx+10]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       test      sil,sil
       je        near ptr M06_L05
       test      r14d,80000
       je        short M06_L05
       mov       rcx,rdi
       mov       edx,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD577FFF00]; System.Threading.Tasks.TaskContinuation.InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task, Boolean)
M06_L02:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        short M06_L03
       test      r14d,20000
       jne       short M06_L06
       jmp       short M06_L00
M06_L03:
       test      r14d,40000
       jne       short M06_L06
       jmp       short M06_L00
M06_L04:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD5787C4F8]
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rdi
       call      qword ptr [7FFD57877AC8]
       mov       edx,eax
       mov       rcx,20828800200
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD57877D80]
       jmp       near ptr M06_L01
M06_L05:
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFD577FECE8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       jmp       short M06_L09
M06_L06:
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M06_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       jne       short M06_L08
M06_L07:
       mov       rcx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD5787C510]
M06_L08:
       mov       rcx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       qword ptr [7FFD57877D98]
M06_L09:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       lea       rax,[M06_L09]
       add       rsp,28
       ret
; Total bytes of code 333
```
```assembly
; DotNetTips.Spargine.Core.Threading.TaskTrackerExtensions+<>c__DisplayClass2_1`1[[System.Int32, System.Private.CoreLib]].<RegisterManyWithTracker>b__0()
; 			var task = Task.Run(() => action(item));
; 			                          ^^^^^^^^^^^^
       mov       rdx,[rcx+8]
       mov       rax,[rdx+8]
       mov       edx,[rcx+10]
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.Threading.TaskTrackerExtensionsBenchmark+<>c.<.cctor>b__12_0(Int32)
       cmp       [rax+18],rcx
       jne       short M07_L00
       ret
M07_L00:
       mov       rcx,[rax+8]
       jmp       qword ptr [rax+18]
; Total bytes of code 36
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
       jne       near ptr M08_L19
       or        dword ptr [rcx+34],10000
M08_L00:
       cmp       byte ptr [7FFD570FB0CC],0
       jne       near ptr M08_L20
M08_L01:
       mov       rax,20828800200
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M08_L21
M08_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M08_L10
M08_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M08_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M08_L11
       mov       rdx,20828800208
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M08_L12
M08_L04:
       test      sil,1
       jne       short M08_L06
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],9
       jle       near ptr M08_L13
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M08_L13
M08_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M08_L14
M08_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M08_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M08_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M08_L08
       test      eax,eax
       jge       short M08_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD57874B10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M08_L09
M08_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M08_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M08_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M08_L18
       mov       rcx,20828800230
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD577FF180]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M08_L18
       jmp       near ptr M08_L16
M08_L10:
       mov       rdx,rsi
       call      qword ptr [7FFD57877E10]
       mov       rcx,[rbp+10]
       jmp       near ptr M08_L03
M08_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20828800330
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD5787C558]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD577FF2E8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,248A7760C48
       call      qword ptr [7FFD577FF3F0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFD5787C570]
       jmp       near ptr M08_L18
M08_L12:
       mov       rdx,20828800220
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M08_L04
       mov       rdx,20828800220
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFD57877FA8]
       jmp       near ptr M08_L04
M08_L13:
       mov       ecx,9
       call      qword ptr [7FFD57876CD0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L05
M08_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877FC0]
       jmp       near ptr M08_L09
M08_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L16:
       mov       rcx,rbx
       call      qword ptr [7FFD577FF360]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M08_L18
M08_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M08_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M08_L19:
       mov       eax,[rcx+34]
       mov       [rbp-1C],eax
       test      eax,410000
       jne       short M08_L18
       lea       rdx,[rcx+34]
       mov       r8d,eax
       or        r8d,10000
       lock cmpxchg [rdx],r8d
       cmp       eax,[rbp-1C]
       je        near ptr M08_L00
       mov       edx,10000
       mov       r8d,410000
       call      qword ptr [7FFD57877DB0]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M08_L00
       jmp       short M08_L18
M08_L20:
       call      qword ptr [7FFD57877D68]
       mov       rcx,[rbp+10]
       jmp       near ptr M08_L01
M08_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M08_L02
       call      qword ptr [7FFD57877AC8]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFD57877D38]
       mov       rdx,rax
       mov       rcx,248A7760BC0
       call      qword ptr [7FFD571B7858]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFD57877D50]
       mov       rcx,[rbp+10]
       jmp       near ptr M08_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD57877DC8]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FFD57877DE0]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFD57877DF8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD57877EE8]
       test      eax,200
       jne       short M08_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFD57877F00]
M08_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 931
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Core.Ulid, DotNetTips.Spargine.10.Core]]..ctor(System.Collections.Generic.IList`1<DotNetTips.Spargine.Core.Ulid>)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M09_L00:
       mov       ecx,14
       call      qword ptr [7FFD573DC228]
       int       3
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFD571B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M11_L00
       mov       rax,[rcx+18]
       ret
M11_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       jmp       qword ptr [rax]
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD9C9B1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M12_L01
       cmp       [rax],ecx
       jle       short M12_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M12_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M12_L00
M12_L02:
       cmp       [rax+4],edx
       jle       short M12_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M12_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M12_L03
       jmp       short M12_L00
M12_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
       je        near ptr M13_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M13_L01
       test      rsi,rsi
       je        short M13_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M13_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M13_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFDB6E452E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD571B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD571B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M13_L00:
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
M13_L01:
       test      rsi,rsi
       je        short M13_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M13_L03
M13_L02:
       mov       rax,248A7750008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L03:
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
M13_L04:
       call      qword ptr [7FFD57876E68]
       int       3
; Total bytes of code 244
```
```assembly
; System.Threading.Tasks.TaskScheduler.get_Id()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       eax,[rbx+8]
       test      eax,eax
       jne       short M14_L01
       call      qword ptr [7FFD9C999530]
M14_L00:
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       je        short M14_L00
       lea       rdx,[rbx+8]
       xor       eax,eax
       lock cmpxchg [rdx],ecx
       mov       eax,[rbx+8]
M14_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 53
```

