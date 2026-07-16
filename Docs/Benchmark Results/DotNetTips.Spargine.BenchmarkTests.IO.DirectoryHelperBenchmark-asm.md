## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.LoadFilesAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,90
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-50],0FFFFFFFF
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
       call      qword ptr [7FF9C1ADFCC0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-68],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-70],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-78],rdx
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9C1E6EC10]; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5.MoveNext()
       nop
       mov       rdx,[rbp-78]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-70]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-70],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,90
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-70]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9C1EFF198]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9C1EFC2A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-48]
       call      qword ptr [7FF9C2024D38]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-78]
       mov       rax,[rbp-68]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-70]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-70],0
       je        short M00_L13
       mov       rdx,[rbp-70]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9C1EFF198]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 379
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
       jmp       qword ptr [7FF9C1EF5320]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF9E93D9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF9E93D9038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF9E93DAEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9E93D8FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5.MoveNext()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       mov       rbx,[rsi]
       test      edi,edi
       je        near ptr M03_L01
       cmp       edi,1
       je        near ptr M03_L42
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.DirectoryInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1E1DE4021B0
       mov       r15,[rcx]
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+198]
       inc       dword ptr [r14+14]
       mov       r13d,[r14+10]
       cmp       [r15+8],r13d
       ja        near ptr M03_L36
       mov       rcx,r14
       call      qword ptr [7FF9C18471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L00:
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+8],ecx
       mov       rcx,r15
       call      qword ptr [7FF9C1A161C0]; System.Object.GetType()
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9C178A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       eax,eax
       mov       [r15+50],rax
       mov       dword ptr [r15+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+3C],eax
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,222732F0EB0
       mov       [r15+30],rcx
       xor       ecx,ecx
       mov       [r15+44],ecx
       mov       [r15+88],rcx
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9C1ED4688]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23.System.Collections.Generic.IAsyncEnumerable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>>.GetAsyncEnumerator(System.Threading.CancellationToken)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rsi+28],0
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       [rsi+14],edx
M03_L01:
       test      edi,edi
       jne       near ptr M03_L10
       vmovdqu   xmm0,xmmword ptr [rsi+30]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rsi+30],rdx
       mov       [rsi+38],rdx
       mov       dword ptr [rsi+10],0FFFFFFFF
       jmp       short M03_L07
M03_L02:
       mov       rcx,r13
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1EFF198]
M03_L03:
       movsx     r15,word ptr [r14+78]
       lea       r13,[r14+58]
       movsx     rcx,word ptr [r13+20]
       cmp       r15d,ecx
       jne       near ptr M03_L19
       cmp       qword ptr [r13],0
       jne       near ptr M03_L15
M03_L04:
       mov       r12,r14
       xor       eax,eax
M03_L05:
       mov       [rbp-70],r12
       mov       [rbp-68],r15w
       mov       [rbp-66],al
M03_L06:
       movzx     edx,byte ptr [rdi+8]
       movzx     ecx,byte ptr [rbp-66]
       movsx     rax,word ptr [rbp-68]
       mov       r8,[rbp-70]
       mov       [rbp-48],r8
       mov       [rbp-40],ax
       mov       [rbp-3E],cl
       mov       [rbp-3D],dl
       mov       rdi,[rbp-48]
       test      rdi,rdi
       jne       near ptr M03_L23
M03_L07:
       mov       rdi,[rbp-48]
       test      rdi,rdi
       jne       near ptr M03_L26
       movzx     r14d,byte ptr [rbp-3E]
M03_L08:
       test      r14d,r14d
       je        near ptr M03_L29
       mov       rcx,[rsi+20]
       mov       r11,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23
       cmp       [rcx],r11
       jne       near ptr M03_L16
       mov       rdi,[rcx+8]
M03_L09:
       mov       [rbp-60],rdi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-60]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
M03_L10:
       lea       rdi,[rsi+20]
       mov       r14,[rdi]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23
       cmp       [r14],rcx
       jne       near ptr M03_L22
       cmp       dword ptr [r14+38],0FFFFFFFE
       je        near ptr M03_L17
       lea       rcx,[r14+58]
       inc       word ptr [rcx+20]
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       word ptr [rcx+22],0
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L18
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L18
M03_L11:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M03_L12
       call      qword ptr [7FF9C1ADFCC0]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M03_L12:
       mov       [rbp-90],r15
       mov       rcx,[r15+8]
       mov       [rbp-98],rcx
       mov       rcx,[r15+10]
       mov       [rbp-0A0],rcx
       mov       rcx,r14
       call      qword ptr [7FF9C1ED4678]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23.MoveNext()
       nop
       mov       rcx,[rbp-0A0]
       cmp       rcx,[r15+10]
       je        short M03_L13
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L13:
       mov       rcx,[r15+8]
       mov       r13,rcx
       cmp       [rbp-98],r13
       je        near ptr M03_L03
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        short M03_L14
       cmp       qword ptr [r13+10],0
       jne       near ptr M03_L02
M03_L14:
       cmp       qword ptr [rbp-98],0
       je        near ptr M03_L03
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],0
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L15:
       cmp       byte ptr [r13+23],0
       je        near ptr M03_L04
       cmp       qword ptr [r13+18],0
       jne       short M03_L20
       lea       rcx,[r14+58]
       movsx     rax,word ptr [rcx+20]
       cmp       r15d,eax
       jne       short M03_L21
       movzx     eax,byte ptr [rcx+22]
       xor       r12d,r12d
       xor       r15d,r15d
       jmp       near ptr M03_L05
M03_L16:
       mov       r11,7FF9C1790B00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L09
M03_L17:
       xor       r12d,r12d
       xor       r15d,r15d
       xor       eax,eax
       jmp       near ptr M03_L05
M03_L18:
       mov       ecx,4
       call      qword ptr [7FF9C1EFC2A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L11
M03_L19:
       call      qword ptr [7FF9C1EFEB98]
       int       3
M03_L20:
       mov       rax,[r13+18]
       mov       rax,[rax+8]
       jmp       near ptr M03_L04
M03_L21:
       call      qword ptr [7FF9C1EFEFA0]
       int       3
M03_L22:
       lea       rdx,[rbp-70]
       mov       rcx,r14
       mov       r11,7FF9C1790B08
       call      qword ptr [r11]
       jmp       near ptr M03_L06
M03_L23:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Boolean>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L24
       test      dword ptr [rax+34],1600000
       setne     r14b
       movzx     r14d,r14b
       jmp       short M03_L25
M03_L24:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-40]
       mov       r11,7FF9C1790B18
       call      qword ptr [r11]
       test      eax,eax
       setne     r14b
       movzx     r14d,r14b
M03_L25:
       test      r14d,r14d
       jne       near ptr M03_L07
       xor       eax,eax
       mov       [rsi+10],eax
       lea       rdi,[rsi+30]
       lea       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rsi,[rbp+10]
       lea       rdx,[rsi+18]
       mov       rcx,rsi
       call      qword ptr [7FF9C1EF4978]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5, DotNetTips.Spargine.BenchmarkTests]](<LoadFilesAsync>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FF9C1EF4990]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredValueTaskAwaiter<Boolean> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L52
M03_L26:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Boolean>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M03_L28
       mov       ecx,[r14+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        short M03_L27
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1EF5320]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
M03_L27:
       movzx     r14d,byte ptr [r14+38]
       jmp       near ptr M03_L08
M03_L28:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-40]
       mov       r11,7FF9C1790B20
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M03_L08
M03_L29:
       mov       rsi,[rbp+10]
       lea       rdi,[rsi+20]
       mov       rcx,[rdi]
       mov       rdx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23
       cmp       [rcx],rdx
       jne       near ptr M03_L37
       lea       rdx,[rbp-80]
       call      qword ptr [7FF9C1ED46D0]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__23.System.IAsyncDisposable.DisposeAsync()
M03_L30:
       movzx     edx,byte ptr [rdi+8]
       mov       rcx,[rbp-80]
       movsx     rax,word ptr [rbp-78]
       mov       [rbp-58],rcx
       mov       [rbp-50],ax
       mov       [rbp-4E],dl
       mov       rdi,[rbp-58]
       test      rdi,rdi
       jne       short M03_L33
M03_L31:
       mov       rdi,[rbp-58]
       test      rdi,rdi
       jne       short M03_L35
M03_L32:
       mov       rdi,[rsi+8]
       test      rdi,rdi
       jne       near ptr M03_L46
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+20],rcx
       mov       [rsi+28],rcx
       jmp       near ptr M03_L48
M03_L33:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L38
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rdi],rcx
       jne       near ptr M03_L40
       jmp       short M03_L39
M03_L34:
       test      eax,eax
       jne       short M03_L31
       jmp       near ptr M03_L41
M03_L35:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L43
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rdi],rcx
       jne       near ptr M03_L45
       jmp       near ptr M03_L44
M03_L36:
       lea       ecx,[r13+1]
       mov       [r14+10],ecx
       mov       ecx,r13d
       lea       rcx,[r15+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L37:
       lea       rdx,[rbp-80]
       mov       r11,7FF9C1790B28
       call      qword ptr [r11]
       jmp       near ptr M03_L30
M03_L38:
       test      dword ptr [rax+34],1600000
       jne       near ptr M03_L31
       jmp       short M03_L41
M03_L39:
       movsx     rdx,word ptr [rbp-50]
       lea       rcx,[rdi+18]
       call      qword ptr [7FF9C1EFF5E8]
       jmp       near ptr M03_L34
M03_L40:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       mov       r11,7FF9C1790B30
       call      qword ptr [r11]
       jmp       near ptr M03_L34
M03_L41:
       mov       dword ptr [rsi+10],1
       lea       rdi,[rsi+40]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rsi,[rbp+10]
       lea       rdx,[rsi+18]
       mov       rcx,rsi
       call      qword ptr [7FF9C1EF4978]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5, DotNetTips.Spargine.BenchmarkTests]](<LoadFilesAsync>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9C2025890]
       jmp       near ptr M03_L52
M03_L42:
       vmovdqu   xmm0,xmmword ptr [rsi+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       xor       edx,edx
       mov       [rsi+40],rdx
       mov       [rsi+48],rdx
       mov       dword ptr [rsi+10],0FFFFFFFF
       jmp       near ptr M03_L31
M03_L43:
       mov       ecx,[rax+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        near ptr M03_L32
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9C1EF5320]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L32
M03_L44:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       call      qword ptr [7FF9C1F14838]
       jmp       near ptr M03_L32
M03_L45:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       mov       r11,7FF9C1790B38
       call      qword ptr [r11]
       jmp       near ptr M03_L32
M03_L46:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Exception
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M03_L47
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L47:
       mov       rcx,rax
       call      qword ptr [7FF9C1E6EDD8]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E6EDF0]
       int       3
M03_L48:
       mov       dword ptr [rsi+10],0FFFFFFFE
       lea       rcx,[rsi+18]
       cmp       qword ptr [rcx],0
       je        near ptr M03_L53
       mov       rdi,[rcx]
       mov       rcx,1E1DE402230
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L54
M03_L49:
       mov       eax,[rdi+34]
       mov       [rbp-84],eax
       test      eax,5600000
       jne       near ptr M03_L56
       lea       rcx,[rdi+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-84]
       jne       near ptr M03_L55
M03_L50:
       mov       byte ptr [rdi+38],0
       lea       rcx,[rdi+34]
       mov       eax,[rdi+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rdi+28]
       test      rsi,rsi
       je        short M03_L51
       mov       rcx,rdi
       call      qword ptr [7FF9C1EFF030]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L57
M03_L51:
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M03_L58
       mov       rdx,1E1DE400218
       mov       rdx,[rdx]
       call      00007FFA2149A300
       test      rax,rax
       je        short M03_L52
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FF9C1EF5200]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L52:
       nop
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
M03_L53:
       mov       rdx,1E1DE400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L52
M03_L54:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EF5608]
       mov       edx,eax
       mov       rcx,1E1DE402230
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9C1EFEFE8]
       jmp       near ptr M03_L49
M03_L55:
       mov       rcx,rdi
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9C1EFF000]
       test      eax,eax
       jne       near ptr M03_L50
M03_L56:
       mov       ecx,18
       call      qword ptr [7FF9C1EFF018]
       int       3
M03_L57:
       call      qword ptr [7FF9C1EFF4C8]
       jmp       near ptr M03_L51
M03_L58:
       call      qword ptr [7FF9C1EFD290]
       int       3
       sub       rsp,28
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-90]
       cmp       rcx,[rdx+10]
       je        short M03_L59
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L59:
       mov       rcx,[rbp-90]
       mov       r14,[rcx+8]
       cmp       [rbp-98],r14
       je        short M03_L62
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M03_L60
       cmp       qword ptr [r14+10],0
       jne       short M03_L61
M03_L60:
       cmp       qword ptr [rbp-98],0
       je        short M03_L62
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],0
       je        short M03_L62
M03_L61:
       mov       rcx,r14
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1EFF198]
M03_L62:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rax,[M03_L29]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+10],0FFFFFFFE
       lea       rcx,[rsi+18]
       call      qword ptr [7FF9C1E6EE20]
       lea       rax,[M03_L52]
       add       rsp,28
       ret
; Total bytes of code 2326
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF9E93F1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       lea       rax,[System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)]
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
       call      qword ptr [7FF9C1EF5338]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9C1EFF6C0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9C2024D50]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9C2025A58]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__15
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+3C],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2F973D60EB0
       mov       [rdi+28],rcx
       xor       ecx,ecx
       mov       [rdi+44],ecx
       mov       [rdi+50],rcx
       mov       [rsp+28],rdi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 132
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L41
       mov       rcx,[rsi+8]
       call      qword ptr [7FF9C1E9EBF8]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L42
       mov       rdi,1D1A7D10EB0
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       xor       edx,edx
       mov       [rax+8],edx
       mov       rdx,rax
       mov       rcx,1D1A7D10F60
       call      qword ptr [7FF9C17BA5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L44
       cmp       qword ptr [rbp-40],0
       je        short M00_L00
       mov       rcx,[rbp-40]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M00_L46
M00_L00:
       mov       rcx,19128C001C8
       mov       r14,[rcx]
       mov       r15,[rsi+8]
       mov       r13,1D1A7D10EB0
       movzx     r12d,byte ptr [rsi+54]
       mov       eax,[r14+14]
       mov       [rbp-48],eax
       mov       r10,1D1A7D10EBC
       mov       [rbp-0A8],r10
       mov       rcx,r10
       mov       r8d,3
       xor       edx,edx
       call      qword ptr [7FF9C1B0F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L47
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       xor       edx,edx
       call      qword ptr [7FF9C1B0F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L48
       mov       rax,[rbp-0A8]
       mov       [rbp-0A0],rax
       xor       ecx,ecx
       mov       edx,3
M00_L01:
       cmp       word ptr [rax+rcx],20
       je        near ptr M00_L49
       mov       rcx,rax
       mov       [rbp-68],rcx
       mov       dword ptr [rbp-60],3
       lea       rcx,[rbp-68]
       call      qword ptr [7FF9C1E96BE0]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       ecx,3
       cmp       eax,3
       jl        short M00_L02
       mov       eax,0FFFFFFFF
       jmp       short M00_L07
M00_L02:
       dec       ecx
       cmp       ecx,3
       jae       near ptr M00_L69
       mov       edx,ecx
       mov       r8,[rbp-0A0]
       movzx     edx,word ptr [r8+rdx*2]
       cmp       edx,5C
       je        short M00_L03
       cmp       edx,2F
       je        short M00_L03
       cmp       ecx,eax
       jg        short M00_L02
M00_L03:
       cmp       ecx,eax
       jle       short M00_L06
M00_L04:
       lea       edx,[rcx-1]
       cmp       edx,3
       jae       near ptr M00_L69
       lea       edx,[rcx-1]
       movzx     edx,word ptr [r8+rdx*2]
       cmp       edx,5C
       je        short M00_L05
       cmp       edx,2F
       jne       short M00_L06
M00_L05:
       dec       ecx
       cmp       ecx,eax
       jg        short M00_L04
M00_L06:
       mov       eax,ecx
M00_L07:
       test      eax,eax
       jl        near ptr M00_L50
       cmp       eax,3
       ja        near ptr M00_L51
       mov       r8,[rbp-0A0]
       mov       edx,eax
M00_L08:
       mov       eax,1
       test      edx,edx
       jne       near ptr M00_L52
M00_L09:
       mov       ecx,[rbp-48]
       test      ecx,ecx
       jne       near ptr M00_L53
M00_L10:
       and       eax,r12d
       mov       [rsi+54],al
       movzx     esi,byte ptr [rsi+54]
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19128C00210
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L58
M00_L11:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rdi+10]
       mov       rax,[rdi+8]
       mov       [rbp-80],rax
       test      r15,r15
       je        near ptr M00_L60
       lea       rcx,[r13+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r12
       test      rdx,rdx
       jne       short M00_L13
       test      byte ptr [7FF9C1EFFB88],1
       je        near ptr M00_L59
M00_L12:
       mov       rcx,19128C002A0
       mov       rdx,[rcx]
M00_L13:
       lea       rcx,[r13+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+28]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       mov       rcx,r15
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       r12,[r13+20]
       mov       rax,[r13+18]
       mov       [rbp-88],rax
       mov       rax,[r13+28]
       mov       [rbp-90],rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+69],1
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       test      esi,esi
       je        near ptr M00_L61
M00_L14:
       test      r12,r12
       je        short M00_L16
       cmp       dword ptr [r12+8],0
       je        short M00_L16
       mov       esi,[r12+8]
       dec       esi
       cmp       esi,[r12+8]
       jae       near ptr M00_L69
       mov       ecx,esi
       movzx     ecx,word ptr [r12+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M00_L22
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L15:
       test      ecx,ecx
       jne       near ptr M00_L62
M00_L16:
       mov       rax,r12
M00_L17:
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-88]
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M00_L63
M00_L18:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+18]
       mov       ecx,[rcx+8]
       mov       [r14+60],ecx
       mov       rcx,r14
       call      qword ptr [7FF9C1E9F180]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       mov       rcx,[r14+18]
       cmp       byte ptr [rcx+1C],0
       jne       near ptr M00_L64
       mov       rsi,[rbp-90]
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0FF
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M00_L24
       mov       rax,1D1A7D01310
       cmp       rsi,rax
       je        short M00_L23
       cmp       dword ptr [rsi+8],1
       jne       short M00_L19
       cmp       word ptr [rsi+0C],2A
       je        short M00_L23
M00_L19:
       mov       rax,1D1A7D00C80
       cmp       rsi,rax
       je        short M00_L23
       cmp       dword ptr [rsi+8],1
       jne       short M00_L20
       cmp       word ptr [rsi+0C],2E
       je        short M00_L23
M00_L20:
       mov       rax,1D1A7D110A0
       cmp       rsi,rax
       je        short M00_L23
       cmp       dword ptr [rsi+8],2
       jne       short M00_L21
       cmp       dword ptr [rsi+0C],2E002E
       je        short M00_L23
M00_L21:
       xor       eax,eax
       jmp       short M00_L24
M00_L22:
       mov       ecx,1
       jmp       near ptr M00_L15
M00_L23:
       mov       eax,1
M00_L24:
       test      eax,eax
       jne       near ptr M00_L64
       cmp       dword ptr [rcx+14],0
       jne       short M00_L25
       mov       rcx,rsi
       call      qword ptr [7FF9C1E9F1B0]; System.IO.Enumeration.FileSystemName.EscapeExpression(System.String)
       mov       rsi,rax
M00_L25:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+70]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+FindPredicate
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0.<FileInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       mov       [rsi+18],rcx
       lea       rcx,[r13+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,19128C00228
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       xor       eax,eax
       mov       rdi,rax
       xchg      rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L65
M00_L26:
       mov       [rbp-98],rdi
       cmp       qword ptr [rbp-98],0
       je        short M00_L27
       mov       rdi,[rbp-98]
       cmp       [rdi],r15
       je        short M00_L33
M00_L27:
       mov       rdi,[rbp-98]
       cmp       [rdi],edi
       jmp       short M00_L29
M00_L28:
       mov       rcx,rsi
       call      qword ptr [7FF9C18771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L29:
       cmp       [rdi],r15
       jne       near ptr M00_L34
       mov       rcx,rdi
       call      qword ptr [7FF9C1F03528]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L30:
       test      eax,eax
       je        near ptr M00_L37
       cmp       [rdi],r15
       jne       near ptr M00_L35
       mov       rdx,[rdi+30]
M00_L31:
       inc       dword ptr [rsi+14]
       mov       r14,[rsi+8]
       mov       r13d,[rsi+10]
       cmp       [r14+8],r13d
       jbe       short M00_L28
       lea       ecx,[r13+1]
       mov       [rsi+10],ecx
       cmp       r13d,[r14+8]
       jae       near ptr M00_L36
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L29
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FF9C18771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L33:
       mov       rcx,rdi
       call      qword ptr [7FF9C1F03528]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L37
       mov       rdx,[rdi+30]
       inc       dword ptr [rsi+14]
       mov       r14,[rsi+8]
       mov       r13d,[rsi+10]
       mov       r12d,[r14+8]
       cmp       r12d,r13d
       jbe       short M00_L32
       lea       ecx,[r13+1]
       mov       [rsi+10],ecx
       cmp       r13d,r12d
       jae       short M00_L36
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L33
M00_L34:
       mov       rcx,rdi
       mov       r11,7FF9C17C09C8
       call      qword ptr [r11]
       jmp       near ptr M00_L30
M00_L35:
       mov       rcx,rdi
       mov       r11,7FF9C17C09D0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L31
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       cmp       [rdi],r15
       jne       near ptr M00_L66
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9C1E9F378]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M00_L38
       mov       rcx,rdi
       call      00007FFA2149D4D0
M00_L38:
       mov       edi,[rsi+10]
       test      edi,edi
       je        near ptr M00_L67
       movsxd    rdx,edi
       mov       rcx,offset MT_System.IO.FileInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF9C187F588]; System.Array.Copy(System.Array, System.Array, Int32)
M00_L39:
       cmp       dword ptr [r14+8],0
       je        near ptr M00_L68
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       [rbp-50],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FF9C1F05B98
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E9F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L41:
       call      qword ptr [7FF9C1DFF048]
       mov       ecx,2047
       mov       rdx,7FF9C1B44C98
       call      qword ptr [7FF9C187F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9C1B44C98
       call      qword ptr [7FF9C187F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF9C1B44C98
       call      qword ptr [7FF9C187F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1F2C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1F271C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       call      qword ptr [7FF9C1E9EBC8]
       mov       rcx,rax
       mov       r8,[rsi+8]
       mov       rdx,1D1A7D10F30
       call      qword ptr [7FF9C1A45470]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,1D1A7D07DF8
       mov       rdx,1D1A7D00390
       call      qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1D1A7D00008
       call      qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L43
       call      qword ptr [7FF9C1F2C8A0]
       mov       rbx,rax
M00_L43:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF9C1F2C8B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       call      qword ptr [7FF9C1E9EC70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L45
       call      qword ptr [7FF9C1F2C8D0]
       mov       rbx,rax
M00_L45:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D1A7D10F00
       call      qword ptr [7FF9C1B0DA10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L46:
       lea       rcx,[rbp-40]
       call      qword ptr [7FF9C1F2C3A8]
       int       3
M00_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26478]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1D1A7D10EB0
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26478]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,r15
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       add       rcx,2
       dec       edx
       jne       near ptr M00_L01
M00_L50:
       xor       r8d,r8d
       xor       edx,edx
       jmp       near ptr M00_L08
M00_L51:
       call      qword ptr [7FF9C1A4F210]
       int       3
M00_L52:
       lea       rcx,[r15+0C]
       mov       eax,[r15+8]
       mov       [rbp-68],rcx
       mov       [rbp-60],eax
       mov       [rbp-78],r8
       mov       [rbp-54],edx
       mov       [rbp-70],edx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FF9C1E9F2D0]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13d,[rbp-54]
       lea       edx,[r13+1]
       mov       rcx,1D1A7D10EB0
       call      qword ptr [7FF9C1BF4378]; System.String.Substring(Int32)
       mov       r13,rax
       xor       eax,eax
       mov       [rbp-44],eax
       mov       eax,[rbp-44]
       jmp       near ptr M00_L09
M00_L53:
       cmp       ecx,1
       jne       near ptr M00_L57
       mov       [rbp-44],eax
       mov       rcx,r13
       mov       rdx,1D1A7D01310
       call      qword ptr [7FF9C1876E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L54
       test      r13,r13
       je        short M00_L55
       cmp       dword ptr [r13+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L55
       jmp       short M00_L56
M00_L54:
       mov       eax,[rbp-44]
       jmp       near ptr M00_L10
M00_L55:
       mov       r13,1D1A7D01310
       mov       eax,[rbp-44]
       jmp       near ptr M00_L10
M00_L56:
       mov       rcx,r13
       mov       rdx,1D1A7D00C80
       call      qword ptr [7FF9C1876E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L55
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FF9C1876E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L55
       mov       rcx,r13
       call      qword ptr [7FF9C1F2C420]
       mov       r13,rax
       mov       eax,[rbp-44]
       jmp       near ptr M00_L10
M00_L57:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1C6C4
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L58:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,19128C001F0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileInfos>b__5_0(System.IO.Enumeration.FileSystemEntry ByRef)
       call      qword ptr [7FF9C1876BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19128C00210
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L59:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L12
M00_L60:
       mov       ecx,1C67E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1F25BD8]
       int       3
M00_L61:
       mov       rcx,r12
       call      qword ptr [7FF9C1B0F060]; System.IO.Path.GetFullPath(System.String)
       mov       r12,rax
       jmp       near ptr M00_L14
M00_L62:
       lea       rcx,[r12+0C]
       mov       eax,[r12+8]
       mov       [rbp-58],eax
       mov       [rbp-68],rcx
       mov       [rbp-60],eax
       lea       rcx,[rbp-68]
       call      qword ptr [7FF9C1E96BE0]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,[rbp-58]
       je        near ptr M00_L16
       mov       r8d,esi
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF9C1B07438]; System.String.Substring(Int32, Int32)
       jmp       near ptr M00_L17
M00_L63:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19128C002A0
       mov       rdx,[rcx]
       jmp       near ptr M00_L18
M00_L64:
       xor       esi,esi
       jmp       near ptr M00_L25
M00_L65:
       mov       rcx,r15
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF9C1F2C810]
       jmp       near ptr M00_L26
M00_L66:
       mov       rcx,rdi
       mov       r11,7FF9C17C09D8
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L67:
       mov       rcx,19128C00228
       mov       r14,[rcx]
       jmp       near ptr M00_L39
M00_L68:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19128C002C0
       mov       rsi,[rcx]
       jmp       near ptr M00_L40
M00_L69:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-98],0
       je        short M00_L70
       mov       r15,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       mov       rdi,[rbp-98]
       cmp       [rdi],r15
       jne       short M00_L71
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9C1E9F378]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rsi,[rdi]
       test      dword ptr [rsi],100000
       je        short M00_L70
       mov       rcx,rdi
       call      00007FFA2149D4D0
M00_L70:
       nop
       add       rsp,28
       ret
M00_L71:
       mov       rcx,rdi
       mov       r11,7FF9C17C09D8
       call      qword ptr [r11]
       jmp       short M00_L70
; Total bytes of code 2896
```
```assembly
; System.IO.Directory.Exists(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2E0
       vzeroupper
       lea       rbp,[rsp+300]
       xor       eax,eax
       mov       [rbp-2D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2D0],ymm4
       mov       rax,0DE367401FC67
       mov       [rbp-28],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L20
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M01_L20
       lea       rdi,[rbx+0C]
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
M01_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M01_L21
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF9C1B0F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M01_L22
       cmp       esi,4
       jl        short M01_L01
       cmp       word ptr [rdi],5C
       je        near ptr M01_L23
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FF9C1B0F0F0]; System.IO.PathHelper.Normalize(System.String)
       mov       rbx,rax
M01_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-2A0],ymm0
       vmovdqu   xmmword ptr [rbp-28C],xmm0
       xor       esi,esi
       test      rbx,rbx
       je        short M01_L04
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       edi,[rbx+8]
       dec       edi
       cmp       edi,[rbx+8]
       jae       near ptr M01_L26
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L19
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L03:
       test      ecx,ecx
       jne       near ptr M01_L25
M01_L04:
       mov       rdi,rbx
M01_L05:
       xor       ecx,ecx
       mov       [rbp-2B0],rcx
       mov       [rbp-2AC],ecx
       call      00007FF9C1868C00
       lea       rdx,[rbp-2AC]
       mov       ecx,1
       call      00007FF9C1868C18
       mov       ebx,eax
       call      00007FF9C1868C30
       mov       ecx,eax
       call      00007FFA214E1F40
       test      ebx,ebx
       setne     cl
       movzx     ecx,cl
       mov       [rbp-2B0],cl
       movzx     ecx,byte ptr [rbp-2B0]
       mov       [rbp-2C4],cl
       mov       ecx,[rbp-2AC]
       mov       [rbp-2C8],ecx
       test      rdi,rdi
       je        short M01_L06
       mov       ecx,[rdi+8]
       cmp       ecx,104
       jge       short M01_L09
       test      ecx,ecx
       je        short M01_L06
       dec       ecx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,20
       je        short M01_L09
       cmp       ecx,2E
       je        short M01_L09
M01_L06:
       mov       rax,rdi
M01_L07:
       test      rax,rax
       je        short M01_L10
       add       rax,0C
       mov       rbx,rax
M01_L08:
       mov       [rbp-2B8],rbx
       xor       ecx,ecx
       call      00007FF9C1868C00
       lea       r8,[rbp-2A0]
       mov       rcx,rbx
       xor       edx,edx
       call      00007FF9C1868C60
       mov       ebx,eax
       call      00007FF9C1868C30
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       call      00007FFA214E1F40
       test      ebx,ebx
       jne       near ptr M01_L14
       jmp       short M01_L11
M01_L09:
       mov       rcx,rdi
       call      qword ptr [7FF9C1E96C28]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       short M01_L07
M01_L10:
       xor       ebx,ebx
       jmp       short M01_L08
M01_L11:
       call      00007FFA214E1F20
       mov       esi,eax
       mov       ecx,esi
       call      qword ptr [7FF9C1E96BB0]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L14
       lea       rcx,[rbp-278]
       mov       edx,250
       call      qword ptr [7FF9C18757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-278]
       mov       rcx,rdi
       call      qword ptr [7FF9C1F26F58]
       mov       [rbp-2E0],rax
       mov       rcx,[rbp-2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C19E7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L12
       call      00007FFA214E1F20
       mov       esi,eax
       jmp       short M01_L13
M01_L12:
       xor       esi,esi
       lea       rcx,[rbp-2A0]
       lea       rdx,[rbp-278]
       call      qword ptr [7FF9C1F26F70]
       nop
M01_L13:
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FF9C187DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FF9C1A45578]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L14:
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L15
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9C1868C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FF9C1868C18
       call      00007FF9C1868C30
       mov       ecx,eax
       call      00007FFA214E1F40
M01_L15:
       test      esi,esi
       je        short M01_L18
M01_L16:
       xor       eax,eax
M01_L17:
       jmp       near ptr M01_L27
M01_L18:
       cmp       dword ptr [rbp-2A0],0FFFFFFFF
       je        short M01_L16
       test      byte ptr [rbp-2A0],10
       setne     al
       movzx     eax,al
       jmp       short M01_L17
M01_L19:
       mov       ecx,1
       jmp       near ptr M01_L03
M01_L20:
       xor       eax,eax
       jmp       near ptr M01_L27
M01_L21:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M01_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26460]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26478]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L23:
       cmp       word ptr [rdi+2],5C
       je        short M01_L24
       cmp       word ptr [rdi+2],3F
       jne       near ptr M01_L01
M01_L24:
       cmp       word ptr [rdi+4],3F
       jne       near ptr M01_L01
       cmp       word ptr [rdi+6],5C
       jne       near ptr M01_L01
       jmp       near ptr M01_L02
M01_L25:
       lea       rcx,[rbx+0C]
       mov       r14d,[rbx+8]
       mov       [rbp-2D8],rcx
       mov       [rbp-2D0],r14d
       lea       rcx,[rbp-2D8]
       call      qword ptr [7FF9C1E96BE0]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r14d
       je        near ptr M01_L04
       mov       r8d,edi
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1B07438]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       jmp       near ptr M01_L05
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L27:
       mov       r8,0DE367401FC67
       cmp       [rbp-28],r8
       je        short M01_L28
       call      CORINFO_HELP_FAIL_FAST
M01_L28:
       nop
       add       rsp,2E0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L29:
       xor       eax,eax
       mov       r8,0DE367401FC67
       cmp       [rbp-28],r8
       je        short M01_L30
       call      CORINFO_HELP_FAIL_FAST
M01_L30:
       nop
       add       rsp,2E0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2E0],0
       je        short M01_L31
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FF9C187DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FF9C1A45578]; System.GC.SuppressFinalize(System.Object)
M01_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9C1868C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FF9C1868C18
       call      00007FF9C1868C30
       mov       ecx,eax
       call      00007FFA214E1F40
M01_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L29]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L29]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L29]
       add       rsp,28
       ret
; Total bytes of code 1231
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L27
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M02_L07
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M02_L01:
       test      ecx,ecx
       je        near ptr M02_L29
       mov       rcx,rsi
       call      qword ptr [7FF9C1A461C0]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M02_L08
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
M02_L02:
       test      ecx,ecx
       je        short M02_L05
       cmp       rbx,rdi
       jne       near ptr M02_L28
M02_L03:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      al,2
       jne       near ptr M02_L09
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M02_L04:
       test      eax,eax
       je        near ptr M02_L29
       call      00007FFA2149E010
       mov       rcx,19112C00B10
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M02_L62
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M02_L05:
       mov       rcx,1D1A7D00020
       cmp       rdi,rcx
       je        near ptr M02_L30
       mov       rcx,1D1A7D03E20
       cmp       rdi,rcx
       jne       near ptr M02_L31
M02_L06:
       mov       rcx,[rbx+18]
       call      00007FFA2149E010
       mov       rcx,19112C00B10
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M02_L62
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M02_L32
       cmp       qword ptr [rdi+10],0
       je        short M02_L10
       mov       rcx,[rdi+10]
       mov       rbp,[rcx]
       test      rbp,rbp
       je        short M02_L10
       mov       rax,rbp
       jmp       short M02_L11
M02_L07:
       xor       ecx,ecx
       jmp       near ptr M02_L01
M02_L08:
       xor       ecx,ecx
       jmp       near ptr M02_L02
M02_L09:
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       rcx,rdi
       call      qword ptr [7FF9C1A456C8]; System.RuntimeType.InitializeCache()
M02_L11:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        short M02_L14
M02_L12:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M02_L51
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M02_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M02_L13:
       mov       esi,[rsi+8]
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L19
       mov       rcx,[rbx+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M02_L19
       mov       rax,rdi
       jmp       near ptr M02_L20
M02_L14:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FF9C1B072D0]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       jne       near ptr M02_L33
M02_L15:
       mov       rcx,1D1A7D06098
       cmp       rbp,rcx
       je        near ptr M02_L35
       mov       rcx,1D1A7D03BD0
       cmp       rbp,rcx
       je        near ptr M02_L36
       mov       rcx,1D1A7D060C0
       cmp       rbp,rcx
       je        near ptr M02_L37
       mov       rcx,1D1A7D03D70
       cmp       rbp,rcx
       je        near ptr M02_L38
       mov       rcx,1D1A7D03E20
       cmp       rbp,rcx
       je        near ptr M02_L39
       mov       rcx,1D1A7D03B58
       cmp       rbp,rcx
       je        near ptr M02_L40
       mov       rcx,1D1A7D060E8
       cmp       rbp,rcx
       je        near ptr M02_L41
       mov       rcx,1D1A7D03950
       cmp       rbp,rcx
       je        near ptr M02_L42
       mov       rcx,1D1A7D06048
       cmp       rbp,rcx
       je        near ptr M02_L43
       mov       rcx,1D1A7D06070
       cmp       rbp,rcx
       je        near ptr M02_L44
       mov       rcx,1D1A7D06110
       cmp       rbp,rcx
       je        near ptr M02_L45
       mov       rcx,1D1A7D06138
       cmp       rbp,rcx
       je        near ptr M02_L46
       mov       rcx,1D1A7D06DB8
       cmp       rbp,rcx
       je        near ptr M02_L47
       mov       rcx,1D1A7D037C8
       cmp       rbp,rcx
       je        near ptr M02_L48
       mov       rcx,1D1A7D00020
       cmp       rbp,rcx
       je        near ptr M02_L49
       mov       rcx,1D1A7D11138
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M02_L16:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M02_L17
       mov       r14,[rcx]
       test      r14,r14
       jne       near ptr M02_L50
M02_L17:
       mov       rcx,rdi
       call      qword ptr [7FF9C1A456C8]; System.RuntimeType.InitializeCache()
M02_L18:
       mov       [rax+98],ebp
       jmp       near ptr M02_L12
M02_L19:
       mov       rcx,rbx
       call      qword ptr [7FF9C1A456C8]; System.RuntimeType.InitializeCache()
M02_L20:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M02_L25
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M02_L21
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M02_L25
       mov       rax,[rcx+28]
       jmp       short M02_L22
M02_L21:
       mov       rax,rcx
M02_L22:
       test      rax,rax
       je        short M02_L26
M02_L23:
       mov       rcx,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M02_L53
       mov       edx,esi
       mov       ecx,[rcx+8]
       cmp       rcx,rdx
       seta      al
       movzx     eax,al
M02_L24:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L25:
       xor       eax,eax
       jmp       short M02_L22
M02_L26:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1B0DEF0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M02_L23
M02_L27:
       mov       ecx,3AD
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1F25BD8]
       int       3
M02_L28:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF9C1F26FA0]
       test      eax,eax
       jne       near ptr M02_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9C1F27F00]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FF9C1F26D48]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9C1BF4360]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M02_L29:
       call      qword ptr [7FF9C1F27EE8]
       int       3
M02_L30:
       mov       rcx,rbx
       call      qword ptr [7FF9C1E9CC90]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FF9C1F00048
       call      qword ptr [7FF9C1E9EC88]
       not       eax
       shr       eax,1F
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       mov       rcx,1D1A7D060C0
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D03D70
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D03BD0
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D06098
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D03B58
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D060E8
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D03950
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,1D1A7D06070
       cmp       rdi,rcx
       je        near ptr M02_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F27F18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L32:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F27F30]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FF9C1F26D48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF4360]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L33:
       mov       rcx,rdi
       call      qword ptr [7FF9C17BA588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L34
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       je        short M02_L34
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L34:
       jmp       near ptr M02_L15
M02_L35:
       mov       ebp,5
       jmp       near ptr M02_L16
M02_L36:
       mov       ebp,6
       jmp       near ptr M02_L16
M02_L37:
       mov       ebp,7
       jmp       near ptr M02_L16
M02_L38:
       mov       ebp,8
       jmp       near ptr M02_L16
M02_L39:
       mov       ebp,9
       jmp       near ptr M02_L16
M02_L40:
       mov       ebp,0A
       jmp       near ptr M02_L16
M02_L41:
       mov       ebp,0B
       jmp       near ptr M02_L16
M02_L42:
       mov       ebp,0C
       jmp       near ptr M02_L16
M02_L43:
       mov       ebp,3
       jmp       near ptr M02_L16
M02_L44:
       mov       ebp,4
       jmp       near ptr M02_L16
M02_L45:
       mov       ebp,0D
       jmp       near ptr M02_L16
M02_L46:
       mov       ebp,0E
       jmp       near ptr M02_L16
M02_L47:
       mov       ebp,0F
       jmp       near ptr M02_L16
M02_L48:
       mov       ebp,10
       jmp       near ptr M02_L16
M02_L49:
       mov       ebp,12
       jmp       near ptr M02_L16
M02_L50:
       mov       rax,r14
       jmp       near ptr M02_L18
M02_L51:
       cmp       ebp,0A
       ja        short M02_L52
       mov       edx,ebp
       lea       rcx,[7FF9C1F90330]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M02_L00]
       add       rcx,rax
       jmp       rcx
M02_L52:
       mov       rdx,1D1A7D03D48
       cmp       rdi,rdx
       je        near ptr M02_L60
       jmp       near ptr M02_L58
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27B28]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27B28]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27B10]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27B10]
       jmp       near ptr M02_L24
M02_L53:
       test      rcx,rcx
       jne       short M02_L54
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M02_L55
M02_L54:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M02_L55:
       cmp       dword ptr [rcx+8],20
       jle       short M02_L56
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,esi
       call      qword ptr [7FF9C1F2C180]
       jmp       short M02_L57
M02_L56:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FF9C1F2C390]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M02_L57:
       not       eax
       shr       eax,1F
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1E9ECE8]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AF8]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AF8]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AE0]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AC8]
       jmp       near ptr M02_L24
       mov       rdx,rsi
       mov       rcx,offset MT_System.Char
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27B40]
       jmp       near ptr M02_L24
M02_L58:
       mov       rdx,1D1A7D06160
       cmp       rdi,rdx
       je        short M02_L59
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1F27F18]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9C1BF61A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L59:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AB0]
       jmp       short M02_L61
M02_L60:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27AB0]
M02_L61:
       jmp       near ptr M02_L24
M02_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2189
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M03_L03
       cmp       r8d,10
       jl        near ptr M03_L09
       movsx     rax,dx
       vmovd     xmm0,eax
       vpbroadcastw ymm0,xmm0
       lea       edx,[r8-10]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M03_L11
       nop       word ptr [rax+rax]
M03_L00:
       add       rcx,20
       cmp       rcx,rax
       ja        short M03_L01
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M03_L11
       jmp       short M03_L00
M03_L01:
       mov       r8d,r8d
       test      r8b,0F
       je        short M03_L02
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M03_L11
M03_L02:
       xor       eax,eax
       vzeroupper
       ret
M03_L03:
       xor       eax,eax
       cmp       r8d,8
       jge       short M03_L07
M03_L04:
       cmp       r8d,4
       jge       near ptr M03_L08
M03_L05:
       test      r8d,r8d
       jle       short M03_L02
       movsx     r9,dx
       add       rax,rax
M03_L06:
       dec       r8d
       movsx     rdx,word ptr [rcx+rax]
       cmp       edx,r9d
       je        near ptr M03_L11
       add       rax,2
       test      r8d,r8d
       jg        short M03_L06
       jmp       short M03_L02
M03_L07:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+8]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+0A]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+0C]
       cmp       r10d,r9d
       je        near ptr M03_L11
       movsx     r10,word ptr [rcx+rax*2+0E]
       cmp       r10d,r9d
       je        near ptr M03_L11
       add       rax,8
       cmp       r8d,8
       jge       near ptr M03_L07
       jmp       near ptr M03_L04
M03_L08:
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       cmp       r10d,r9d
       je        short M03_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       cmp       r10d,r9d
       je        short M03_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       cmp       r10d,r9d
       je        short M03_L11
       add       rax,4
       jmp       near ptr M03_L05
M03_L09:
       movsx     rax,dx
       vmovd     xmm0,eax
       vpbroadcastw xmm0,xmm0
       lea       edx,[r8-8]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
M03_L10:
       vpcmpeqw  xmm1,xmm0,[rcx]
       vptest    xmm1,xmm1
       jne       short M03_L11
       add       rcx,10
       cmp       rcx,rax
       jbe       short M03_L10
       mov       r8d,r8d
       test      r8b,7
       je        near ptr M03_L02
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M03_L02
M03_L11:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 464
```
```assembly
; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       mov       edi,esi
       xor       ebp,ebp
       cmp       edi,4
       jl        short M04_L00
       cmp       word ptr [rbx],5C
       je        near ptr M04_L19
M04_L00:
       cmp       edi,4
       jl        short M04_L04
M04_L01:
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M04_L02
       cmp       ecx,2F
       jne       short M04_L04
M04_L02:
       movzx     ecx,word ptr [rbx+2]
       cmp       ecx,5C
       je        short M04_L03
       cmp       ecx,2F
       jne       short M04_L04
M04_L03:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,2E
       je        short M04_L09
       cmp       ecx,3F
       je        short M04_L09
M04_L04:
       xor       r14d,r14d
M04_L05:
       test      r14d,r14d
       jne       near ptr M04_L23
       xor       r15d,r15d
M04_L06:
       movzx     eax,r15b
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       or        ecx,eax
       je        short M04_L07
       test      edi,edi
       jle       short M04_L07
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M04_L11
       cmp       ecx,2F
       je        short M04_L11
M04_L07:
       test      r14d,r14d
       jne       near ptr M04_L24
       cmp       esi,2
       jl        short M04_L08
       cmp       word ptr [rbx+2],3A
       je        near ptr M04_L30
M04_L08:
       mov       eax,ebp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L09:
       movzx     ecx,word ptr [rbx+6]
       cmp       ecx,5C
       je        near ptr M04_L21
       cmp       ecx,2F
       sete      r14b
       movzx     r14d,r14b
M04_L10:
       jmp       short M04_L05
M04_L11:
       test      eax,eax
       jne       short M04_L14
       cmp       edi,1
       jle       short M04_L13
       movzx     eax,word ptr [rbx+2]
       cmp       eax,5C
       je        short M04_L12
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L13
M04_L12:
       mov       eax,2
       jmp       short M04_L15
M04_L13:
       mov       ebp,1
       jmp       short M04_L08
M04_L14:
       mov       eax,8
M04_L15:
       mov       ebp,eax
       mov       eax,2
       jmp       short M04_L18
M04_L16:
       dec       eax
       test      eax,eax
       jle       short M04_L08
M04_L17:
       inc       ebp
M04_L18:
       cmp       ebp,esi
       jge       short M04_L08
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M04_L16
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M04_L17
       jmp       short M04_L16
M04_L19:
       cmp       word ptr [rbx+2],5C
       je        short M04_L20
       cmp       word ptr [rbx+2],3F
       jne       near ptr M04_L00
M04_L20:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,3F
       jne       near ptr M04_L00
       cmp       word ptr [rbx+6],5C
       je        short M04_L22
       jmp       near ptr M04_L01
M04_L21:
       mov       r14d,1
       jmp       near ptr M04_L10
M04_L22:
       mov       r14d,1
       jmp       near ptr M04_L05
M04_L23:
       mov       [rsp+28],rbx
       mov       [rsp+30],edi
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9C1F279F0]
       mov       r15d,eax
       jmp       near ptr M04_L06
M04_L24:
       mov       ebp,4
       jmp       short M04_L26
M04_L25:
       inc       ebp
M04_L26:
       cmp       ebp,esi
       jge       near ptr M04_L08
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M04_L27
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L25
       jmp       short M04_L28
M04_L27:
       cmp       ebp,4
       jle       near ptr M04_L08
       jmp       short M04_L29
M04_L28:
       cmp       ebp,4
       jle       near ptr M04_L08
M04_L29:
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M04_L31
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M04_L08
       jmp       short M04_L31
M04_L30:
       movzx     eax,word ptr [rbx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M04_L08
       mov       ebp,2
       cmp       esi,2
       jle       near ptr M04_L08
       movzx     eax,word ptr [rbx+4]
       cmp       eax,5C
       je        short M04_L31
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M04_L08
M04_L31:
       inc       ebp
       jmp       near ptr M04_L08
; Total bytes of code 553
```
```assembly
; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-60],rcx
       mov       rcx,rbp
       mov       [rbp-50],rcx
       mov       rax,[rbp+10]
       mov       rsi,[rax+10]
       mov       [rbp-80],rsi
       test      rsi,rsi
       je        short M05_L00
       mov       ecx,[rsi+8]
       cmp       ecx,104
       jge       near ptr M05_L11
       test      ecx,ecx
       je        short M05_L00
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M05_L11
       cmp       ecx,2E
       je        near ptr M05_L11
M05_L00:
       mov       rdi,rsi
M05_L01:
       test      rdi,rdi
       je        near ptr M05_L12
       add       rdi,0C
M05_L02:
       mov       [rbp-40],rdi
       xor       ecx,ecx
       mov       rdx,7FFA5D535FF0
       call      rdx
       mov       dword ptr [rsp+20],3
       mov       dword ptr [rsp+28],2000000
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,rdi
       mov       edx,1
       mov       r8d,7
       xor       r9d,r9d
       mov       rax,7FF9C19EEB68
       mov       [rbp-68],rax
       lea       rax,[M05_L03]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA5D544EA0
       call      rax
M05_L03:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M05_L04
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M05_L04:
       mov       rcx,[rbp-70]
       mov       [rbx+8],rcx
       mov       rbx,rax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-40],rax
       call      00007FFA214E1F40
       test      rbx,rbx
       je        short M05_L05
       cmp       rbx,0FFFFFFFFFFFFFFFF
       jne       near ptr M05_L13
M05_L05:
       call      00007FFA214E1F20
       mov       ebx,eax
       cmp       ebx,5
       jne       short M05_L06
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       cmp       byte ptr [rcx+1D],0
       jne       short M05_L07
M05_L06:
       mov       rax,[rbp+10]
       mov       rcx,rax
       mov       edx,ebx
       mov       r8,[rax]
       mov       r8,[r8+48]
       call      qword ptr [r8]
       test      eax,eax
       mov       rax,[rbp+10]
       je        short M05_L14
M05_L07:
       xor       ebx,ebx
M05_L08:
       mov       [rax+58],rbx
       cmp       qword ptr [rax+58],0
       je        near ptr M05_L18
M05_L09:
       mov       rdx,[rax+10]
       lea       rcx,[rax+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rdx,[rax+18]
       mov       edx,[rdx+0C]
       test      edx,edx
       jg        near ptr M05_L19
       mov       ecx,1000
M05_L10:
       mov       [rax+64],ecx
       jmp       short M05_L15
M05_L11:
       mov       rcx,rsi
       call      qword ptr [7FF9C1E96C28]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L12:
       xor       edi,edi
       jmp       near ptr M05_L02
M05_L13:
       mov       rax,[rbp+10]
       jmp       short M05_L08
M05_L14:
       mov       ecx,3
       cmp       ebx,2
       cmove     ebx,ecx
       mov       ecx,ebx
       mov       rdx,[rbp-80]
       xor       r8d,r8d
       call      qword ptr [7FF9C1F26298]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L15:
       movsxd    rdx,dword ptr [rax+64]
       xor       ecx,ecx
       call      00007FF9C1868C48
       test      rax,rax
       je        short M05_L16
       mov       rbx,[rbp+10]
       mov       [rbx+50],rax
       jmp       short M05_L17
M05_L16:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9C1F26FB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L17:
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
M05_L18:
       mov       byte ptr [rax+68],1
       jmp       near ptr M05_L09
M05_L19:
       mov       ecx,400
       cmp       edx,400
       cmovg     ecx,edx
       jmp       near ptr M05_L10
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9C1E9F348]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].CloseDirectoryHandle()
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 630
```
```assembly
; System.IO.Enumeration.FileSystemName.EscapeExpression(System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       mov       rax,0DE367401FC67
       mov       [rbp+40],rax
       mov       rbx,rcx
       test      rbx,rbx
       jne       short M06_L03
       xor       esi,esi
       xor       edi,edi
M06_L00:
       mov       dword ptr [rsp+20],3E
       mov       [rsp+28],edi
       mov       r8d,22
       mov       r9d,3C
       mov       edx,5C
       mov       rcx,rsi
       call      qword ptr [7FF9C1E9F1C8]; System.SpanHelpers.IndexOfAnyValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int16, Int32)
       mov       r14d,eax
       test      r14d,r14d
       jge       short M06_L04
M06_L01:
       mov       rax,rbx
       mov       r8,0DE367401FC67
       cmp       [rbp+40],r8
       je        short M06_L02
       call      CORINFO_HELP_FAIL_FAST
M06_L02:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L03:
       lea       rsi,[rbx+0C]
       mov       edi,[rbx+8]
       jmp       short M06_L00
M06_L04:
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+30]
       mov       [rbp+10],rdx
       mov       dword ptr [rbp+18],100
       lea       rdx,[rbp+10]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9C1F2CA08]
M06_L05:
       cmp       r14d,edi
       ja        near ptr M06_L10
       mov       [rbp],rsi
       mov       [rbp+8],r14d
       lea       rdx,[rbp]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9C1DFF690]; System.Text.ValueStringBuilder.Append(System.ReadOnlySpan`1<Char>)
       mov       ecx,[rbp+28]
       mov       rdx,[rbp+30]
       mov       eax,[rbp+38]
       cmp       ecx,eax
       jae       short M06_L06
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],5C
       inc       ecx
       mov       [rbp+28],ecx
       jmp       short M06_L07
M06_L06:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FF9C1F2C5E8]
M06_L07:
       cmp       r14d,edi
       jae       near ptr M06_L12
       mov       ecx,r14d
       movzx     edx,word ptr [rsi+rcx*2]
       mov       ecx,[rbp+28]
       mov       rax,[rbp+30]
       mov       r8d,[rbp+38]
       cmp       ecx,r8d
       jae       short M06_L08
       mov       r8d,ecx
       mov       [rax+r8*2],dx
       inc       ecx
       mov       [rbp+28],ecx
       jmp       short M06_L09
M06_L08:
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9C1F2C5E8]
M06_L09:
       inc       r14d
       cmp       r14d,edi
       ja        short M06_L10
       mov       edx,r14d
       lea       rbx,[rsi+rdx*2]
       sub       edi,r14d
       mov       rsi,rbx
       mov       r14d,edi
       mov       dword ptr [rsp+20],3E
       mov       [rsp+28],r14d
       mov       edx,5C
       mov       r8d,22
       mov       r9d,3C
       mov       rcx,rsi
       call      qword ptr [7FF9C1E9F1C8]; System.SpanHelpers.IndexOfAnyValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int16, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M06_L11
       mov       edi,r14d
       mov       r14d,r15d
       jmp       near ptr M06_L05
M06_L10:
       call      qword ptr [7FF9C1A4F210]
       int       3
M06_L11:
       mov       [rbp],rbx
       mov       [rbp+8],edi
       lea       rdx,[rbp]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9C1DFF690]; System.Text.ValueStringBuilder.Append(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9C1BF5410]; System.Text.ValueStringBuilder.ToString()
       mov       rbx,rax
       jmp       near ptr M06_L01
M06_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 456
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0.<FileInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rdx,[rdx]
       test      byte ptr [rdx+38],10
       jne       near ptr M07_L10
       mov       rbx,[rcx+8]
       lea       rsi,[rdx+44]
       mov       eax,[rdx+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+18],0
       jne       short M07_L03
       mov       r8d,1
M07_L00:
       mov       edi,[rcx+14]
       test      edi,edi
       jne       short M07_L05
       test      rbx,rbx
       jne       short M07_L04
       xor       ecx,ecx
       xor       edx,edx
M07_L01:
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       mov       [rsp+20],rsi
       mov       [rsp+28],eax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       xor       r9d,r9d
       call      qword ptr [7FF9C1E9F2A0]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
M07_L02:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L03:
       cmp       dword ptr [rcx+18],2
       sete      r8b
       movzx     r8d,r8b
       jmp       short M07_L00
M07_L04:
       lea       rcx,[rbx+0C]
       mov       edx,[rbx+8]
       jmp       short M07_L01
M07_L05:
       cmp       edi,1
       jne       short M07_L07
       test      rbx,rbx
       jne       short M07_L09
       jmp       short M07_L08
M07_L06:
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       mov       [rsp+20],rsi
       mov       [rsp+28],eax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       mov       r9d,1
       call      qword ptr [7FF9C1E9F2A0]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
       jmp       short M07_L02
M07_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L08:
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M07_L06
M07_L09:
       lea       rcx,[rbx+0C]
       mov       edx,[rbx+8]
       jmp       short M07_L06
M07_L10:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 293
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       r14d,4
M08_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M08_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF9C1DF65F8]
       int       3
M08_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M08_L00
M08_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M08_L08
       test      r14d,r14d
       jg        short M08_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M08_L04
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L08
M08_L04:
       mov       rdx,7FF9C1F56058
       call      qword ptr [7FF9C187F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L03
M08_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+80]
       test      rax,rax
       je        short M08_L09
       mov       rcx,rax
M08_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M08_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF9C187F588]; System.Array.Copy(System.Array, System.Array, Int32)
M08_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L09:
       mov       rdx,7FF9C1F112B8
       call      qword ptr [7FF9C187F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L06
; Total bytes of code 309
```
```assembly
; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,178
       vzeroupper
       lea       rbp,[rsp+1B0]
       xor       eax,eax
       mov       [rbp-148],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M09_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M09_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-100]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0E8],rcx
       mov       rcx,rbp
       mov       [rbp-0D8],rcx
       cmp       byte ptr [rbx+68],0
       jne       near ptr M09_L69
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rax,[rbx+28]
       mov       [rbp-150],rax
       xor       ecx,ecx
       mov       [rbp-74],ecx
       test      rax,rax
       je        near ptr M09_L47
       mov       rcx,rax
       call      00007FFA214EDF30
       test      eax,eax
       jne       short M09_L01
       mov       rcx,[rbp-150]
       call      qword ptr [7FF9C1F26178]
M09_L01:
       mov       dword ptr [rbp-74],1
       cmp       byte ptr [rbx+68],0
       jne       near ptr M09_L46
M09_L02:
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        short M09_L04
       mov       edx,[rcx]
       test      edx,edx
       je        short M09_L04
       mov       edx,edx
       add       rcx,rdx
M09_L03:
       mov       [rbx+48],rcx
       cmp       qword ptr [rbx+48],0
       jne       near ptr M09_L23
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M09_L05
       xor       ecx,ecx
       jmp       short M09_L06
M09_L04:
       xor       ecx,ecx
       jmp       short M09_L03
M09_L05:
       add       rcx,0C
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
M09_L06:
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-98],xmm0
       cmp       byte ptr [rbx+69],0
       je        short M09_L07
       mov       byte ptr [rbx+69],0
       cmp       qword ptr [rbx+20],0
       je        short M09_L07
       mov       rdx,[rbx+20]
       mov       edx,[rdx+8]
       add       edx,edx
       movzx     edx,dx
       mov       [rbp-96],dx
       mov       [rbp-98],dx
       mov       [rbp-90],rcx
       lea       rdx,[rbp-98]
M09_L07:
       lea       rcx,[rbp-0A8]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+50]
       mov       [rsp+28],rcx
       mov       ecx,[rbx+64]
       mov       [rsp+30],ecx
       mov       dword ptr [rsp+38],2
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+48],rdx
       mov       [rsp+50],ecx
       mov       [rbp+10],rbx
       mov       rcx,[rbx+58]
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       mov       rax,7FF9C1A0AC90
       mov       [rbp-0F0],rax
       lea       rax,[M09_L08]
       mov       [rbp-0E0],rax
       lea       rax,[rbp-100]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5D7ADCA0
       call      rax
M09_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M09_L09
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M09_L09:
       mov       rcx,[rbp-0F8]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-88],rcx
       cmp       eax,80000006
       jbe       near ptr M09_L13
       cmp       eax,0C000000F
       je        near ptr M09_L15
       cmp       eax,0C0000033
       je        near ptr M09_L15
M09_L10:
       mov       ecx,eax
       mov       rax,7FF9C1A0AC50
       mov       [rbp-0F0],rax
       lea       rax,[M09_L11]
       mov       [rbp-0E0],rax
       lea       rax,[rbp-100]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9C1A0AC70]
M09_L11:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M09_L12
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M09_L12:
       mov       rcx,[rbp-0F8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       cmp       ebx,5
       jne       near ptr M09_L20
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+18]
       cmp       byte ptr [rcx+1D],0
       jne       near ptr M09_L22
       jmp       near ptr M09_L21
M09_L13:
       test      eax,eax
       jne       short M09_L14
       mov       rbx,[rbp+10]
       mov       rax,[rbx+50]
       mov       [rbx+48],rax
       jmp       near ptr M09_L23
M09_L14:
       cmp       eax,80000006
       jne       near ptr M09_L10
M09_L15:
       xor       ecx,ecx
       mov       rbx,[rbp+10]
       mov       [rbx+48],rcx
       lea       rcx,[rbx+58]
       xor       eax,eax
       xchg      rax,[rcx]
       test      rax,rax
       je        short M09_L16
       mov       rcx,rax
       call      qword ptr [7FF9C1E96F88]; Interop+Kernel32.CloseHandle(IntPtr)
M09_L16:
       mov       rdx,[rbx+38]
       test      rdx,rdx
       jne       short M09_L18
       xor       ecx,ecx
       xor       eax,eax
M09_L17:
       mov       [rbp-110],rcx
       mov       [rbp-108],eax
       lea       rdx,[rbp-110]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rbx
       call      qword ptr [7FF9C1E9F360]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].DequeueNextDirectory()
       test      eax,eax
       jne       short M09_L19
       mov       [rbp+10],rbx
       mov       byte ptr [rbx+68],1
       mov       rbx,[rbp+10]
       jmp       short M09_L23
M09_L18:
       lea       rcx,[rdx+0C]
       mov       eax,[rdx+8]
       jmp       short M09_L17
M09_L19:
       mov       rcx,rbx
       call      qword ptr [7FF9C1E9F270]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].FindNextEntry()
       jmp       short M09_L23
M09_L20:
       mov       rdi,[rbp+10]
M09_L21:
       mov       rcx,rdi
       mov       edx,ebx
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M09_L60
M09_L22:
       mov       rcx,rdi
       call      qword ptr [7FF9C1E9F330]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].DirectoryFinished()
       mov       rbx,rdi
M09_L23:
       cmp       byte ptr [rbx+68],0
       jne       near ptr M09_L46
       mov       rdx,[rbx+48]
       mov       rcx,rdx
       mov       rax,[rbx+38]
       test      rax,rax
       jne       near ptr M09_L35
       xor       r8d,r8d
       xor       r10d,r10d
M09_L24:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M09_L36
       xor       r9d,r9d
       xor       r11d,r11d
M09_L25:
       mov       rax,[rbx+8]
       test      rax,rax
       jne       near ptr M09_L37
       xor       edi,edi
       xor       r14d,r14d
M09_L26:
       mov       [rbp-70],rcx
       mov       [rbp-68],r8
       mov       [rbp-60],r10d
       mov       [rbp-58],r9
       mov       [rbp-50],r11d
       mov       [rbp-48],rdi
       mov       [rbp-40],r14d
       mov       ecx,[rdx+38]
       mov       rax,[rbx+18]
       test      [rax+10],ecx
       jne       near ptr M09_L02
       test      cl,10
       jne       near ptr M09_L48
M09_L27:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M09_L59
       mov       rcx,[rbx+70]
       mov       rdi,[rcx+30]
       test      rdi,rdi
       je        near ptr M09_L31
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0.<FileInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rdi+18],rcx
       jne       near ptr M09_L58
       mov       rcx,[rdi+8]
       mov       rdx,[rbp-70]
       test      byte ptr [rdx+38],10
       jne       near ptr M09_L57
       mov       rdi,[rcx+8]
       mov       rdx,[rbp-70]
       lea       r14,[rdx+44]
       mov       eax,[rdx+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+18],0
       jne       near ptr M09_L38
       mov       r8d,1
M09_L28:
       mov       r15d,[rcx+14]
       test      r15d,r15d
       jne       near ptr M09_L54
       test      rdi,rdi
       jne       near ptr M09_L39
       xor       ecx,ecx
       xor       edx,edx
M09_L29:
       mov       [rbp-110],rcx
       mov       [rbp-108],edx
       mov       [rbp-120],r14
       mov       [rbp-118],eax
       lea       rcx,[rbp-110]
       lea       rdx,[rbp-120]
       xor       r9d,r9d
       call      qword ptr [7FF9C1E9F2A0]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
M09_L30:
       test      eax,eax
       je        near ptr M09_L02
M09_L31:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M09_L66
       mov       rcx,[rbx+70]
       mov       rsi,[rcx+10]
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileInfos>b__5_0(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rsi+18],rcx
       jne       near ptr M09_L65
       mov       rcx,[rbp-68]
       mov       edx,[rbp-60]
       mov       r8,[rbp-70]
       lea       rsi,[r8+44]
       mov       eax,[r8+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       [rbp-0B8],rcx
       mov       [rbp-0B0],edx
       cmp       dword ptr [rbp-0B0],0
       jne       near ptr M09_L40
       mov       [rbp-110],rsi
       mov       [rbp-108],eax
       lea       rcx,[rbp-110]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M09_L32:
       mov       rcx,[rbp-70]
       test      byte ptr [rcx+38],10
       jne       near ptr M09_L62
       mov       rcx,[rbp-70]
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rbp-0C8],rax
       mov       [rbp-0C0],ecx
       mov       rcx,[rbp-0C8]
       mov       eax,[rbp-0C0]
       mov       [rbp-110],rcx
       mov       [rbp-108],eax
       lea       rcx,[rbp-110]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       xor       ecx,ecx
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M09_L33:
       mov       rdx,[rbp-70]
       mov       ecx,[rdx+38]
       mov       [rdi+30],ecx
       mov       rcx,[rdx+8]
       mov       [rdi+34],rcx
       mov       rcx,[rdx+10]
       mov       [rdi+3C],rcx
       mov       rcx,[rdx+18]
       mov       [rdi+44],rcx
       mov       rcx,[rdx+28]
       sar       rcx,20
       mov       [rdi+4C],ecx
       mov       edx,[rdx+28]
       mov       [rdi+50],edx
       xor       edx,edx
       mov       [rdi+28],edx
       mov       rdx,rdi
       mov       rcx,offset MT_System.IO.FileInfo
       cmp       [rdx],rcx
       jne       near ptr M09_L63
M09_L34:
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,1
       jmp       near ptr M09_L67
M09_L35:
       lea       r8,[rax+0C]
       mov       r10d,[rax+8]
       jmp       near ptr M09_L24
M09_L36:
       lea       r9,[rax+0C]
       mov       r11d,[rax+8]
       jmp       near ptr M09_L25
M09_L37:
       lea       rdi,[rax+0C]
       mov       r14d,[rax+8]
       jmp       near ptr M09_L26
M09_L38:
       cmp       dword ptr [rcx+18],2
       sete      r8b
       movzx     r8d,r8b
       jmp       near ptr M09_L28
M09_L39:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
       jmp       near ptr M09_L29
M09_L40:
       test      eax,eax
       je        near ptr M09_L45
       mov       rdi,[rbp-0B8]
       mov       r14d,[rbp-0B0]
       lea       ecx,[r14-1]
       cmp       ecx,r14d
       jae       near ptr M09_L64
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M09_L44
       cmp       ecx,2F
       je        short M09_L44
       movzx     ecx,word ptr [rsi]
       cmp       ecx,5C
       je        short M09_L43
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M09_L41:
       test      ecx,ecx
       jne       short M09_L44
       mov       rcx,1D1A7D081EC
       mov       [rbp-110],rdi
       mov       [rbp-108],r14d
       mov       [rbp-120],rcx
       mov       dword ptr [rbp-118],1
       mov       [rbp-148],rsi
       mov       [rbp-140],eax
       lea       rcx,[rbp-110]
       lea       rdx,[rbp-120]
       lea       r8,[rbp-148]
       call      qword ptr [7FF9C1E96CE8]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M09_L42:
       jmp       near ptr M09_L32
M09_L43:
       mov       ecx,1
       jmp       short M09_L41
M09_L44:
       mov       [rbp-110],rdi
       mov       [rbp-108],r14d
       mov       [rbp-120],rsi
       mov       [rbp-118],eax
       lea       rcx,[rbp-110]
       lea       rdx,[rbp-120]
       call      qword ptr [7FF9C1BFD9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       jmp       short M09_L42
M09_L45:
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       jmp       near ptr M09_L32
M09_L46:
       xor       esi,esi
       jmp       near ptr M09_L67
M09_L47:
       xor       ecx,ecx
       call      qword ptr [7FF9C1F25BD8]
       int       3
M09_L48:
       mov       rcx,rdx
       mov       ecx,[rcx+3C]
       mov       eax,ecx
       shr       eax,1F
       add       ecx,eax
       sar       ecx,1
       mov       eax,ecx
       cmp       eax,2
       jg        short M09_L50
       add       rdx,44
       mov       rax,rdx
       mov       r8d,ecx
       test      r8d,r8d
       je        near ptr M09_L64
       cmp       word ptr [rax],2E
       jne       short M09_L50
       mov       eax,ecx
       cmp       eax,2
       jne       short M09_L49
       cmp       ecx,1
       jbe       near ptr M09_L64
       cmp       word ptr [rdx+2],2E
       jne       short M09_L50
M09_L49:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1E],0
       jne       near ptr M09_L27
       jmp       near ptr M09_L02
M09_L50:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1C],0
       je        near ptr M09_L27
       cmp       dword ptr [rbx+60],0
       jle       near ptr M09_L27
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       je        near ptr M09_L27
       mov       rcx,[rbx+38]
       test      rcx,rcx
       jne       short M09_L51
       xor       edx,edx
       xor       eax,eax
       jmp       short M09_L52
M09_L51:
       lea       rdx,[rcx+0C]
       mov       eax,[rcx+8]
M09_L52:
       mov       rcx,[rbx+48]
       lea       r8,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       r10d,ecx
       shr       r10d,1F
       add       ecx,r10d
       sar       ecx,1
       mov       [rbp-110],rdx
       mov       [rbp-108],eax
       mov       [rbp-120],r8
       mov       [rbp-118],ecx
       lea       rcx,[rbp-110]
       lea       rdx,[rbp-120]
       call      qword ptr [7FF9C1E9F2D0]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+48]
       lea       rcx,[rdx+44]
       mov       edx,[rdx+3C]
       mov       r8d,edx
       shr       r8d,1F
       add       edx,r8d
       sar       edx,1
       mov       [rbp-110],rcx
       mov       [rbp-108],edx
       lea       rdx,[rbp-110]
       mov       rcx,rbx
       mov       r8,rdi
       call      qword ptr [7FF9C1F272D0]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        near ptr M09_L27
       cmp       qword ptr [rbx+40],0
       jne       short M09_L53
       mov       rcx,offset MT_System.Collections.Generic.Queue<System.ValueTuple<System.IntPtr, System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF9C1F272E8]
       lea       rcx,[rbx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L53:
       mov       rcx,[rbx+40]
       mov       edx,[rbx+60]
       dec       edx
       mov       [rbp-138],rdi
       mov       rax,[rbp-80]
       mov       [rbp-130],rax
       mov       [rbp-128],edx
       lea       rdx,[rbp-138]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1F27300]
       jmp       near ptr M09_L27
M09_L54:
       cmp       r15d,1
       jne       near ptr M09_L61
       test      rdi,rdi
       jne       short M09_L55
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M09_L56
M09_L55:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
M09_L56:
       mov       [rbp-110],rcx
       mov       [rbp-108],edx
       mov       [rbp-120],r14
       mov       [rbp-118],eax
       lea       rcx,[rbp-110]
       lea       rdx,[rbp-120]
       mov       r9d,1
       call      qword ptr [7FF9C1E9F2A0]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
       jmp       near ptr M09_L30
M09_L57:
       xor       eax,eax
       jmp       near ptr M09_L30
M09_L58:
       lea       rdx,[rbp-70]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       jmp       near ptr M09_L30
M09_L59:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M09_L30
M09_L60:
       mov       rdx,[rdi+38]
       mov       ecx,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9C1F26298]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M09_L61:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1F27318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L62:
       lea       rdx,[rbp-0C8]
       mov       rcx,[rbp-70]
       call      qword ptr [7FF9C1F272B8]
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r9,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r15
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9C1F279A8]
       jmp       near ptr M09_L33
M09_L63:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M09_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L65:
       lea       rdx,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       near ptr M09_L34
M09_L66:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M09_L34
M09_L67:
       mov       rcx,[rbp-150]
       call      00007FFA214EDE50
       test      eax,eax
       jne       short M09_L70
M09_L68:
       movzx     eax,sil
       add       rsp,178
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L69:
       xor       esi,esi
       jmp       short M09_L68
M09_L70:
       mov       ecx,eax
       mov       rdx,[rbp-150]
       call      qword ptr [7FF9C1F25CE0]
       jmp       short M09_L68
       sub       rsp,58
       vzeroupper
       mov       rcx,[rbp-80]
       call      qword ptr [7FF9C1E96F88]; Interop+Kernel32.CloseHandle(IntPtr)
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,58
       vzeroupper
       cmp       dword ptr [rbp-74],0
       je        short M09_L72
       cmp       qword ptr [rbp-150],0
       jne       short M09_L71
       xor       ecx,ecx
       call      qword ptr [7FF9C1F25BD8]
       int       3
M09_L71:
       mov       rcx,[rbp-150]
       call      00007FFA214EDE50
       test      eax,eax
       je        short M09_L72
       mov       ecx,eax
       mov       rdx,[rbp-150]
       call      qword ptr [7FF9C1F25CE0]
M09_L72:
       nop
       add       rsp,58
       ret
; Total bytes of code 2816
```
```assembly
; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M10_L11
       mov       [rbp-98],rax
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,rax
       call      00007FFA214EDF30
       test      eax,eax
       jne       short M10_L00
       mov       rcx,[rbp-98]
       call      qword ptr [7FF9C1F26178]
M10_L00:
       mov       dword ptr [rbp-3C],1
       mov       byte ptr [rbx+68],1
       mov       [rbp+10],rbx
       lea       rcx,[rbx+58]
       xor       eax,eax
       mov       r14,rax
       xchg      r14,[rcx]
       test      r14,r14
       je        short M10_L03
       xor       ecx,ecx
       mov       rax,7FFA5D535FF0
       call      rax
       mov       rcx,r14
       mov       rax,7FF9C19EF918
       mov       [rbp-80],rax
       lea       rax,[M10_L01]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA5D544C20
       call      rax
M10_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M10_L02
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M10_L02:
       mov       rax,[rbp-88]
       mov       [rdi+8],rax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       call      00007FFA214E1F40
M10_L03:
       mov       rbx,[rbp+10]
       cmp       qword ptr [rbx+40],0
       jne       short M10_L08
M10_L04:
       mov       [rbp+10],rbx
       mov       rcx,[rbx+50]
       test      rcx,rcx
       je        short M10_L07
       test      rcx,0FFFFFFFFFFFF0000
       je        short M10_L07
       mov       rax,7FF9C19EDA58
       mov       [rbp-80],rax
       lea       rax,[M10_L05]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA5D537EA0
       call      rax
M10_L05:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M10_L06
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M10_L06:
       mov       rcx,[rbp-88]
       mov       [rdi+8],rcx
M10_L07:
       xor       ecx,ecx
       mov       rbx,[rbp+10]
       mov       [rbx+50],rcx
       jmp       short M10_L10
M10_L08:
       mov       rcx,[rbx+40]
       cmp       dword ptr [rcx+18],0
       jle       short M10_L09
       mov       rcx,[rbx+40]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1F27A98]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C1E96F88]; Interop+Kernel32.CloseHandle(IntPtr)
       jmp       short M10_L08
M10_L09:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       jmp       near ptr M10_L04
M10_L10:
       mov       rcx,[rbp-98]
       call      00007FFA214EDE50
       test      eax,eax
       jne       short M10_L13
M10_L11:
       mov       rdx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rbx],rdx
       jne       short M10_L14
M10_L12:
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
M10_L13:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1F25CE0]
       jmp       short M10_L11
M10_L14:
       movzx     edx,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M10_L12
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       je        short M10_L15
       mov       rcx,[rbp-98]
       call      00007FFA214EDE50
       test      eax,eax
       je        short M10_L15
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1F25CE0]
M10_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 592
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M11_L06
       test      rbx,rbx
       je        near ptr M11_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M11_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M11_L07
       cmp       edi,[rsi+8]
       ja        short M11_L07
       cmp       edi,[rbx+8]
       ja        short M11_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M11_L05
       cmp       r8,4000
       ja        short M11_L04
       mov       rcx,rbx
       call      00007FFA2146A2B0
       cmp       dword ptr [7FFA217A4A90],0
       jne       short M11_L02
M11_L00:
       cmp       dword ptr [7FFA217A4A90],0
       jne       short M11_L03
M11_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L00
M11_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L01
M11_L04:
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9C1DFE610]
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M11_L00
M11_L06:
       xor       ebp,ebp
       jmp       short M11_L08
M11_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9C1E966E8]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M11_L08:
       test      rbx,rbx
       jne       short M11_L09
       xor       r9d,r9d
       jmp       short M11_L10
M11_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1E966E8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M11_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FF9C1E96700]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M11_L00
; Total bytes of code 246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M13_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M13_L00
       test      rbx,rbx
       je        near ptr M13_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M13_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M13_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       test      rbx,rbx
       je        short M13_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M13_L02
M13_L01:
       mov       rax,1D1A7D00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L04:
       call      qword ptr [7FF9C1F25FF8]
       int       3
; Total bytes of code 235
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M14_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M14_L02
       test      rsi,rsi
       je        near ptr M14_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M14_L01
       test      rdi,rdi
       je        near ptr M14_L00
       cmp       dword ptr [rdi+8],0
       je        near ptr M14_L00
       mov       r15d,ebp
       mov       r13d,r14d
       add       r13,r15
       mov       r12d,[rdi+8]
       add       r13,r12
       cmp       r13,7FFFFFFF
       jg        near ptr M14_L03
       mov       rcx,7FF9C1F48540
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L00:
       mov       rcx,7FF9C1F48538
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
M14_L01:
       mov       rcx,7FF9C1F48534
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
M14_L02:
       mov       rcx,7FF9C1F48530
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9C187D9C8]; System.String.Concat(System.String, System.String)
M14_L03:
       mov       rcx,7FF9C1F4853C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9C1F25FF8]
       int       3
; Total bytes of code 396
```
```assembly
; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       dword ptr [rbx+8],0
       je        near ptr M15_L05
       cmp       dword ptr [rsi+8],0
       je        near ptr M15_L06
       mov       rcx,7FF9C1F78140
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx]
       mov       ebx,[rbx+8]
       mov       rbp,[rsi]
       mov       esi,[rsi+8]
       lea       edx,[rbx-1]
       cmp       edx,ebx
       jae       near ptr M15_L08
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,5C
       je        near ptr M15_L04
       cmp       edx,2F
       je        near ptr M15_L04
       test      esi,esi
       je        near ptr M15_L08
       movzx     edx,word ptr [rbp]
       cmp       edx,5C
       je        short M15_L01
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M15_L00:
       test      edx,edx
       jne       near ptr M15_L04
       mov       edx,ebx
       add       edx,1
       jo        near ptr M15_L09
       add       edx,esi
       jo        near ptr M15_L09
       test      edx,edx
       jne       short M15_L02
       mov       r14,1D1A7D00008
       jmp       short M15_L03
M15_L01:
       mov       edx,1
       jmp       short M15_L00
M15_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebx,r13d
       ja        near ptr M15_L07
       mov       r12d,ebx
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15,r12
       sub       r13d,ebx
       je        near ptr M15_L07
       mov       word ptr [r15],5C
       lea       rcx,[r15+2]
       dec       r13d
       cmp       esi,r13d
       ja        near ptr M15_L07
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbp
       call      qword ptr [7FF9C1875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L03:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L04:
       mov       [rsp+38],rdi
       mov       [rsp+40],ebx
       mov       [rsp+28],rbp
       mov       [rsp+30],esi
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9C1BFD9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       jmp       short M15_L03
M15_L05:
       mov       rcx,7FF9C1F78138
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L06:
       mov       rcx,7FF9C1F7813C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L07:
       call      qword ptr [7FF9C1C8D0E0]
       int       3
M15_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 470
```
```assembly
; System.String.Substring(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       je        short M16_L00
       mov       ecx,[rsi+8]
       mov       r8d,ecx
       sub       r8d,ebx
       je        short M16_L01
       cmp       ecx,ebx
       jb        short M16_L02
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FF9E93EB9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,ebx
       lea       rdx,[rsi+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FF9E93ED928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L02:
       mov       rcx,rsi
       mov       edx,ebx
       call      qword ptr [7FF9E93EBD30]
       int       3
; Total bytes of code 127
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        short M17_L02
       test      rbx,rbx
       je        short M17_L00
       test      rsi,rsi
       je        short M17_L03
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M17_L01
       mov       rcx,7FF9C1F3D3A4
       call      CORINFO_HELP_COUNTPROFILE32
M17_L00:
       mov       rcx,7FF9C1F3D3A8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L01:
       mov       rcx,7FF9C1F3D3B0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       call      qword ptr [7FF9C187C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L02:
       mov       rcx,7FF9C1F3D3A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L03:
       mov       rcx,7FF9C1F3D3AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M17_L00
; Total bytes of code 162
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileInfos>b__5_0(System.IO.Enumeration.FileSystemEntry ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,rdx
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       mov       r8,[rbx]
       lea       rsi,[r8+44]
       mov       eax,[r8+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       [rsp+70],rcx
       mov       [rsp+78],edx
       cmp       dword ptr [rsp+78],0
       je        near ptr M18_L05
       test      eax,eax
       je        near ptr M18_L04
       mov       rdi,[rsp+70]
       mov       ebp,[rsp+78]
       lea       ecx,[rbp-1]
       cmp       ecx,ebp
       jae       near ptr M18_L10
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M18_L03
       cmp       ecx,2F
       je        short M18_L03
       movzx     ecx,word ptr [rsi]
       cmp       ecx,5C
       je        short M18_L02
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M18_L00:
       test      ecx,ecx
       jne       short M18_L03
       mov       rcx,1D1A7D081EC
       mov       [rsp+50],rdi
       mov       [rsp+58],ebp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1
       mov       [rsp+30],rsi
       mov       [rsp+38],eax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       call      qword ptr [7FF9C1E96CE8]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
M18_L01:
       jmp       short M18_L06
M18_L02:
       mov       ecx,1
       jmp       short M18_L00
M18_L03:
       mov       [rsp+50],rdi
       mov       [rsp+58],ebp
       mov       [rsp+40],rsi
       mov       [rsp+48],eax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       call      qword ptr [7FF9C1BFD9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       jmp       short M18_L01
M18_L04:
       lea       rcx,[rsp+70]
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r14,rax
       jmp       short M18_L06
M18_L05:
       mov       [rsp+50],rsi
       mov       [rsp+58],eax
       lea       rcx,[rsp+50]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
M18_L06:
       mov       rcx,[rbx]
       test      byte ptr [rcx+38],10
       jne       near ptr M18_L08
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rsp+60],rax
       mov       [rsp+68],ecx
       mov       rcx,[rsp+60]
       mov       eax,[rsp+68]
       mov       [rsp+50],rcx
       mov       [rsp+58],eax
       lea       rcx,[rsp+50]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFF
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       xor       ecx,ecx
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M18_L07:
       mov       rax,[rbx]
       mov       edx,[rax+38]
       mov       [rdi+30],edx
       mov       rdx,[rax+8]
       mov       [rdi+34],rdx
       mov       rdx,[rax+10]
       mov       [rdi+3C],rdx
       mov       rdx,[rax+18]
       mov       [rdi+44],rdx
       mov       rdx,[rax+28]
       sar       rdx,20
       mov       [rdi+4C],edx
       mov       eax,[rax+28]
       mov       [rdi+50],eax
       xor       eax,eax
       mov       [rdi+28],eax
       mov       rax,rdi
       mov       rcx,offset MT_System.IO.FileInfo
       cmp       [rax],rcx
       jne       short M18_L09
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L08:
       lea       rdx,[rsp+60]
       call      qword ptr [7FF9C1F272B8]
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+60]
       call      qword ptr [7FF9C1A4F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r9,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9C1F279A8]
       jmp       near ptr M18_L07
M18_L09:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M18_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M19_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L00:
       call      qword ptr [7FF9C1F26A60]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M20_L00
       ret
M20_L00:
       jmp       qword ptr [7FF9C1875C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M21_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C1B0F078]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M21_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9C1B0F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M21_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C1B0F0D8]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M21_L00
       mov       rcx,rbx
       call      qword ptr [7FF9C1B0F0F0]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M21_L01
M21_L00:
       mov       rax,rbx
M21_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M21_L02:
       mov       ecx,1AC3E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1F25BD8]
       int       3
M21_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26460]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M21_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1F26478]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C17B4000
       call      qword ptr [7FF9C187F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BF6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       eax,r8d
       add       rcx,rax
       mov       eax,[rbx+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M22_L02
       test      r8d,r8d
       je        short M22_L01
       cmp       eax,r8d
       je        short M22_L00
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FF9E93EB9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,esi
       lea       rdx,[rbx+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FF9E93ED928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M22_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M22_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M22_L02:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF9E93EBD30]
       int       3
; Total bytes of code 136
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,358
       vzeroupper
       lea       rbp,[rsp+390]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-330],xmm4
       vmovdqa   xmmword ptr [rbp-320],xmm4
       mov       rax,0FFFFFFFFFFFFFD30
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rax,6022C429E2B
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-300]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-2E8],rcx
       mov       rcx,rbp
       mov       [rbp-2D8],rcx
       mov       rbx,[rbx+198]
       mov       [rbp-338],rbx
       test      rbx,rbx
       je        near ptr M00_L51
       mov       rdi,rbx
       mov       [rbp-340],rdi
       mov       rcx,rdi
       call      qword ptr [7FF9C1C0E3F8]; System.IO.DirectoryInfo.get_Exists()
       test      eax,eax
       je        near ptr M00_L48
       cmp       dword ptr [rdi+28],0FFFFFFFF
       jne       near ptr M00_L19
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rdi+30],ymm1
       vmovdqu   xmmword ptr [rdi+44],xmm1
       mov       r14,[rdi+8]
       lea       r15,[rdi+30]
       mov       [rbp-350],r15
       xor       r13d,r13d
       test      r14,r14
       je        short M00_L02
       cmp       dword ptr [r14+8],0
       je        short M00_L02
       mov       r12d,[r14+8]
       dec       r12d
       cmp       r12d,[r14+8]
       jae       near ptr M00_L71
       mov       ecx,r12d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M00_L50
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L52
M00_L02:
       mov       [rbp-360],r14
M00_L03:
       xor       ecx,ecx
       mov       [rbp-2A8],rcx
       mov       [rbp-2A4],ecx
       mov       rax,7FFA5D535FF0
       call      rax
       lea       rdx,[rbp-2A4]
       mov       ecx,1
       mov       rax,7FFA5D53BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       call      00007FFA214E1F40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2A8],al
       movzx     eax,byte ptr [rbp-2A8]
       mov       [rbp-304],al
       mov       eax,[rbp-2A4]
       mov       [rbp-308],eax
       cmp       dword ptr [7FFA217A4A90],0
       jne       near ptr M00_L53
M00_L04:
       mov       r14,[rbp-360]
       test      r14,r14
       je        short M00_L05
       mov       ecx,[r14+8]
       cmp       ecx,104
       jge       near ptr M00_L10
       test      ecx,ecx
       je        short M00_L05
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M00_L10
       cmp       ecx,2E
       je        near ptr M00_L10
M00_L05:
       mov       [rbp-360],r14
       mov       rax,r14
M00_L06:
       mov       r15,[rbp-350]
       mov       [rbp-2B0],r15
       mov       rbx,r15
       test      rax,rax
       je        near ptr M00_L11
       add       rax,0C
       mov       rdi,rax
M00_L07:
       mov       [rbp-2B8],rdi
       xor       ecx,ecx
       mov       rax,7FFA5D535FF0
       call      rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FF9C19AEDE8
       mov       [rbp-2F0],rax
       lea       rax,[M00_L08]
       mov       [rbp-2E0],rax
       lea       rax,[rbp-300]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5D545090
       call      rax
M00_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M00_L09
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M00_L09:
       mov       rcx,[rbp-2F8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       mov       [rbp-2B0],rax
       call      00007FFA214E1F40
       test      ebx,ebx
       jne       near ptr M00_L15
       call      00007FFA214E1F20
       mov       r13d,eax
       mov       ecx,r13d
       call      qword ptr [7FF9C1E56BC8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M00_L15
       jmp       short M00_L12
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF9C1E56C40]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-360],r14
       jmp       near ptr M00_L06
M00_L11:
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L12:
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FF9C18357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-360]
       call      qword ptr [7FF9C1ED79C0]
       mov       [rbp-358],rax
       mov       rcx,[rbp-358]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C19A7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M00_L13
       call      00007FFA214E1F20
       mov       r13d,eax
       jmp       short M00_L14
M00_L13:
       xor       r13d,r13d
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-350]
       call      qword ptr [7FF9C1ED79D8]
       nop
M00_L14:
       mov       rcx,[rbp-358]
       mov       edx,1
       call      qword ptr [7FF9C183DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-358]
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
       nop
M00_L15:
       cmp       byte ptr [rbp-304],0
       je        short M00_L16
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9C1828C18
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-308]
       call      00007FF9C1828C30
       call      00007FF9C1828C48
       mov       ecx,eax
       call      00007FFA214E1F40
M00_L16:
       test      r13d,r13d
       jne       near ptr M00_L22
M00_L17:
       mov       ecx,r13d
M00_L18:
       mov       rdi,[rbp-340]
       mov       [rdi+28],ecx
M00_L19:
       cmp       dword ptr [rdi+28],0
       jne       near ptr M00_L55
       test      byte ptr [rdi+30],1
       jne       near ptr M00_L56
M00_L20:
       mov       rbx,[rdi+8]
       mov       rsi,2CB095B0EB0
       mov       r14,rsi
       mov       rcx,28A8A4001E0
       mov       r15,[rcx]
       movzx     r13d,byte ptr [rdi+54]
       mov       r12d,[r15+14]
       lea       rax,[rsi+0C]
       mov       [rbp-370],rax
       mov       rcx,rax
       mov       r8d,3
       xor       edx,edx
       call      qword ptr [7FF9C1ACF0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L57
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FF9C1ACF0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L58
       mov       rax,[rbp-370]
       mov       [rbp-368],rax
       xor       ecx,ecx
       mov       edx,3
M00_L21:
       cmp       word ptr [rax+rcx],20
       je        near ptr M00_L59
       mov       rcx,rax
       mov       [rbp-320],rcx
       mov       dword ptr [rbp-318],3
       lea       rcx,[rbp-320]
       call      qword ptr [7FF9C1E56BF8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       ecx,3
       cmp       eax,3
       jl        short M00_L24
       mov       eax,0FFFFFFFF
       jmp       short M00_L29
M00_L22:
       lea       ecx,[r13-2]
       cmp       ecx,1
       ja        near ptr M00_L54
M00_L23:
       mov       r15,[rbp-350]
       mov       dword ptr [r15],0FFFFFFFF
       xor       ecx,ecx
       jmp       near ptr M00_L18
M00_L24:
       dec       ecx
       cmp       ecx,3
       jae       near ptr M00_L71
       mov       edx,ecx
       mov       r8,[rbp-368]
       movzx     edx,word ptr [r8+rdx*2]
       cmp       edx,5C
       je        short M00_L25
       cmp       edx,2F
       je        short M00_L25
       cmp       ecx,eax
       jg        short M00_L24
M00_L25:
       cmp       ecx,eax
       jle       short M00_L28
M00_L26:
       lea       edx,[rcx-1]
       cmp       edx,3
       jae       near ptr M00_L71
       lea       edx,[rcx-1]
       movzx     edx,word ptr [r8+rdx*2]
       cmp       edx,5C
       je        short M00_L27
       cmp       edx,2F
       jne       short M00_L28
M00_L27:
       dec       ecx
       cmp       ecx,eax
       jg        short M00_L26
M00_L28:
       mov       eax,ecx
M00_L29:
       test      eax,eax
       jl        near ptr M00_L60
       cmp       eax,3
       ja        near ptr M00_L61
       mov       r8,[rbp-368]
       mov       edx,eax
M00_L30:
       mov       eax,1
       test      edx,edx
       jne       near ptr M00_L62
M00_L31:
       test      r12d,r12d
       jne       near ptr M00_L63
M00_L32:
       and       eax,r13d
       mov       [rdi+54],al
       movzx     r9d,byte ptr [rdi+54]
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,r15
       call      qword ptr [7FF9C1E5EC88]; System.IO.Enumeration.FileSystemEnumerableFactory.FileSystemInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>
       cmp       [rbx],rcx
       jne       near ptr M00_L69
       lea       rcx,[rbx+8]
       xor       eax,eax
       mov       rsi,rax
       xchg      rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L68
M00_L33:
       mov       [rbp-348],rsi
       cmp       qword ptr [rbp-348],0
       je        short M00_L34
       mov       rdi,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rsi,[rbp-348]
       cmp       [rsi],rdi
       je        near ptr M00_L41
M00_L34:
       mov       rsi,[rbp-348]
       cmp       [rsi],esi
       mov       rdi,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       jmp       short M00_L36
M00_L35:
       cmp       [rbx],bl
       mov       rcx,rbx
       call      qword ptr [7FF9C1E5EB68]; System.IO.FileSystemInfo.EnsureDataInitialized()
       cmp       dword ptr [rbx+30],80
       jne       near ptr M00_L45
M00_L36:
       cmp       [rsi],rdi
       jne       near ptr M00_L43
       mov       rcx,rsi
       call      qword ptr [7FF9C1EC2A50]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L37:
       test      eax,eax
       je        near ptr M00_L47
       cmp       [rsi],rdi
       jne       near ptr M00_L44
       mov       rbx,[rsi+30]
M00_L38:
       cmp       qword ptr [rbp-298],0
       je        short M00_L35
       mov       r14,[rbp-298]
       cmp       dword ptr [r14+20],0
       je        short M00_L35
       jmp       near ptr M00_L46
M00_L39:
       mov       r14,[rbp-298]
       cmp       dword ptr [r14+20],0
       jne       near ptr M00_L46
M00_L40:
       cmp       [rbx],bl
       mov       rcx,rbx
       call      qword ptr [7FF9C1E5EB68]; System.IO.FileSystemInfo.EnsureDataInitialized()
       cmp       dword ptr [rbx+30],80
       jne       short M00_L42
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF9C1EC2A50]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L47
       mov       rbx,[rsi+30]
       cmp       qword ptr [rbp-298],0
       je        short M00_L40
       jmp       short M00_L39
M00_L42:
       mov       rcx,rbx
       mov       edx,80
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E5EB08]; System.IO.FileSystemInfo.set_Attributes(System.IO.FileAttributes)
       jmp       short M00_L41
M00_L43:
       mov       rcx,rsi
       mov       r11,7FF9C17809D0
       call      qword ptr [r11]
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,rsi
       mov       r11,7FF9C17809D8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L38
M00_L45:
       mov       rcx,rbx
       mov       edx,80
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E5EB08]; System.IO.FileSystemInfo.set_Attributes(System.IO.FileAttributes)
       jmp       near ptr M00_L36
M00_L46:
       lea       rcx,[rbp-298]
       call      qword ptr [7FF9C1ED75E8]
       int       3
M00_L47:
       cmp       [rsi],rdi
       jne       near ptr M00_L70
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF9C1E5F228]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rcx,rsi
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
M00_L48:
       mov       r8,6022C429E2B
       cmp       [rbp-40],r8
       je        short M00_L49
       call      CORINFO_HELP_FAIL_FAST
M00_L49:
       nop
       add       rsp,358
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L50:
       mov       ecx,1
       jmp       near ptr M00_L01
M00_L51:
       call      qword ptr [7FF9C1DBF078]
       mov       ecx,7E9
       mov       rdx,7FF9C1EBE398
       call      qword ptr [7FF9C183F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9C1B04C98
       call      qword ptr [7FF9C183F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C183D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9C1EBE398
       call      qword ptr [7FF9C183F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C183D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1ED7A20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1ED7A38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       lea       rcx,[r14+0C]
       mov       eax,[r14+8]
       mov       [rbp-30C],eax
       mov       [rbp-320],rcx
       mov       [rbp-318],eax
       lea       rcx,[rbp-320]
       call      qword ptr [7FF9C1E56BF8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,[rbp-30C]
       je        near ptr M00_L02
       mov       r8d,r12d
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1AC7438]; System.String.Substring(Int32, Int32)
       mov       [rbp-360],rax
       jmp       near ptr M00_L03
M00_L53:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L54:
       cmp       r13d,15
       jne       near ptr M00_L17
       jmp       near ptr M00_L23
M00_L55:
       mov       rbx,[rbp-338]
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FF9C1ED6040]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L56:
       mov       rcx,rdi
       call      qword ptr [7FF9C1E5EAF0]; System.IO.FileSystemInfo.get_Attributes()
       mov       edx,eax
       and       edx,0FFFFFFFE
       mov       rcx,rdi
       call      qword ptr [7FF9C1E5EB08]; System.IO.FileSystemInfo.set_Attributes(System.IO.FileAttributes)
       jmp       near ptr M00_L20
M00_L57:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1ED6220]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FF9C1BB6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L58:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1ED6220]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF9C1BB6250]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L59:
       add       rcx,2
       dec       edx
       jne       near ptr M00_L21
M00_L60:
       xor       r8d,r8d
       xor       edx,edx
       jmp       near ptr M00_L30
M00_L61:
       call      qword ptr [7FF9C1A0F210]
       int       3
M00_L62:
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       mov       [rbp-320],rcx
       mov       [rbp-318],eax
       mov       [rbp-330],r8
       mov       [rbp-310],edx
       mov       [rbp-328],edx
       lea       rcx,[rbp-320]
       lea       rdx,[rbp-330]
       call      qword ptr [7FF9C1E5F108]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       r14d,[rbp-310]
       lea       edx,[r14+1]
       mov       rcx,2CB095B0EB0
       call      qword ptr [7FF9C1BB4378]; System.String.Substring(Int32)
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-2C4],eax
       mov       eax,[rbp-2C4]
       jmp       near ptr M00_L31
M00_L63:
       cmp       r12d,1
       jne       near ptr M00_L67
       mov       [rbp-2C4],eax
       mov       rcx,r14
       mov       rdx,2CB095A1310
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L64
       test      r14,r14
       je        short M00_L65
       cmp       dword ptr [r14+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L65
       jmp       short M00_L66
M00_L64:
       mov       eax,[rbp-2C4]
       jmp       near ptr M00_L32
M00_L65:
       mov       r14,2CB095A1310
       mov       eax,[rbp-2C4]
       jmp       near ptr M00_L32
M00_L66:
       mov       rcx,r14
       mov       rdx,2CB095A0C80
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L65
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L65
       mov       rcx,r14
       call      qword ptr [7FF9C1ED7660]
       mov       r14,rax
       mov       eax,[rbp-2C4]
       jmp       near ptr M00_L32
M00_L67:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1C6C4
       mov       rdx,7FF9C1774000
       call      qword ptr [7FF9C183F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1ED6F70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       mov       rdi,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9C1ED7870]
       jmp       near ptr M00_L33
M00_L69:
       mov       rcx,rbx
       mov       r11,7FF9C17809C8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L70:
       mov       rcx,rsi
       mov       r11,7FF9C17809E0
       call      qword ptr [r11]
       jmp       near ptr M00_L48
M00_L71:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-348],0
       je        short M00_L73
       mov       rdi,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rsi,[rbp-348]
       cmp       [rsi],rdi
       jne       short M00_L72
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF9C1E5F228]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rcx,rsi
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
       jmp       short M00_L73
M00_L72:
       mov       rcx,rsi
       mov       r11,7FF9C17809E0
       call      qword ptr [r11]
M00_L73:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-358],0
       je        short M00_L74
       mov       rcx,[rbp-358]
       mov       edx,1
       call      qword ptr [7FF9C183DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-358]
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
M00_L74:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-304],0
       je        short M00_L75
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9C1828C18
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-308]
       call      00007FF9C1828C30
       call      00007FF9C1828C48
       mov       ecx,eax
       call      00007FFA214E1F40
M00_L75:
       nop
       add       rsp,28
       ret
; Total bytes of code 2844
```
```assembly
; System.IO.DirectoryInfo.get_Exists()
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        short M01_L02
M01_L00:
       cmp       dword ptr [rbx+28],0
       jne       short M01_L03
       mov       eax,[rbx+30]
       cmp       eax,0FFFFFFFF
       je        short M01_L03
       test      al,10
       setne     al
       movzx     eax,al
M01_L01:
       mov       [rbp-0C],eax
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FF9C1ED6E08]; System.IO.FileSystemInfo.RefreshCore()
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
M01_L04:
       mov       eax,[rbp-0C]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       xor       eax,eax
       mov       [rbp-0C],eax
       lea       rax,[M01_L04]
       add       rsp,28
       ret
; Total bytes of code 93
```
```assembly
; System.IO.FileSystem.IsPathUnreachableError(Int32)
       cmp       ecx,41
       jle       short M02_L03
       cmp       ecx,7B
       jle       short M02_L00
       cmp       ecx,0A1
       je        short M02_L01
       cmp       ecx,0CE
       je        short M02_L01
       cmp       ecx,4CF
       jne       short M02_L05
       jmp       short M02_L01
M02_L00:
       sub       ecx,43
       cmp       ecx,38
       ja        short M02_L05
       mov       rax,100000000100001
       bt        rax,rcx
       jae       short M02_L05
M02_L01:
       mov       eax,1
M02_L02:
       ret
M02_L03:
       cmp       ecx,6
       jle       short M02_L04
       cmp       ecx,15
       je        short M02_L01
       cmp       ecx,35
       je        short M02_L01
       add       ecx,0FFFFFFC0
       cmp       ecx,1
       jbe       short M02_L01
       jmp       short M02_L05
M02_L04:
       lea       eax,[rcx-2]
       cmp       eax,1
       jbe       short M02_L01
       cmp       ecx,6
       je        short M02_L01
M02_L05:
       xor       eax,eax
       jmp       short M02_L02
; Total bytes of code 108
```
```assembly
; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M03_L00
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M03_L01
M03_L00:
       xor       ecx,ecx
       xor       eax,eax
M03_L01:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9E93F7BA0]; Precode of System.IO.PathInternal.IsPartiallyQualified(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M03_L05
       test      rbx,rbx
       je        short M03_L02
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M03_L03
M03_L02:
       xor       ecx,ecx
       xor       eax,eax
M03_L03:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9E93F7B80]; Precode of System.IO.PathInternal.IsDevice(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M03_L05
       cmp       dword ptr [rbx+8],2
       jl        short M03_L04
       cmp       dword ptr [rbx+0C],5C005C
       je        short M03_L06
M03_L04:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF9E93EBB68]; Precode of System.String.Concat(System.String, System.String)
       nop
       add       rsp,30
       pop       rbx
       ret
M03_L05:
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       ret
M03_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FF9E93EBC30]
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 180
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L12
       lea       rdi,[rbx+rsi]
       cmp       rsi,10
       jbe       near ptr M04_L10
       cmp       rsi,40
       jbe       near ptr M04_L03
       cmp       rsi,400
       ja        near ptr M04_L08
       cmp       rsi,100
       jb        short M04_L00
       mov       rcx,7FF9C1FFCF64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       and       rcx,3F
       neg       rcx
       add       rcx,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx],ymm0
       vmovdqu   ymmword ptr [rbx+20],ymm0
       add       rbx,rcx
       sub       rsi,rcx
M04_L00:
       mov       rbp,rsi
       shr       rbp,6
       jmp       short M04_L02
M04_L01:
       mov       rcx,7FF9C1FFCF70
       call      CORINFO_HELP_COUNTPROFILE32
M04_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx],ymm0
       vmovdqu   ymmword ptr [rbx+20],ymm0
       add       rbx,40
       dec       rbp
       jne       short M04_L01
       and       rsi,3F
       cmp       rsi,10
       jbe       short M04_L07
       mov       rcx,7FF9C1FFCF6C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx],xmm0
       cmp       rsi,20
       jbe       short M04_L04
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx+10],xmm0
       cmp       rsi,30
       ja        short M04_L09
       mov       rcx,7FF9C1FFCF4C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF9C1FFCF48
       call      CORINFO_HELP_COUNTPROFILE32
M04_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rdi-10],xmm0
M04_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       rcx,7FF9C1FFCF68
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L05
M04_L08:
       mov       rcx,7FF9C1FFCF74
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9C1EDDE78]
M04_L09:
       mov       rcx,7FF9C1FFCF44
       call      CORINFO_HELP_COUNTPROFILE32
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx+20],xmm0
       jmp       short M04_L04
M04_L10:
       test      sil,18
       je        short M04_L11
       mov       rcx,7FF9C1FFCF50
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       [rdi-8],rcx
       jmp       short M04_L06
M04_L11:
       test      sil,4
       je        short M04_L13
       mov       rcx,7FF9C1FFCF54
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],ecx
       mov       [rdi-4],ecx
       jmp       near ptr M04_L06
M04_L12:
       mov       rcx,7FF9C1FFCF40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L06
M04_L13:
       mov       byte ptr [rbx],0
       test      sil,2
       jne       short M04_L14
       mov       rcx,7FF9C1FFCF5C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L06
M04_L14:
       mov       rcx,7FF9C1FFCF60
       call      CORINFO_HELP_COUNTPROFILE32
       mov       word ptr [rdi-2],0
       jmp       near ptr M04_L06
; Total bytes of code 485
```
```assembly
; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
M05_L00:
       mov       edi,[rbx+10]
       movzx     ebp,sil
       test      ebp,ebp
       jne       short M05_L07
M05_L01:
       mov       r14d,edi
       and       r14d,0FFFFFFFC
       je        near ptr M05_L15
       mov       ecx,edi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       je        short M05_L08
M05_L02:
       xor       ecx,ecx
M05_L03:
       lea       edx,[rdi-4]
       cmp       r14d,4
       je        short M05_L10
M05_L04:
       test      ebp,ebp
       jne       short M05_L11
M05_L05:
       lea       r8,[rbx+10]
       mov       eax,edi
       lock cmpxchg [r8],edx
       cmp       eax,edi
       jne       short M05_L00
       test      ecx,ecx
       jne       short M05_L12
M05_L06:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L07:
       test      dil,2
       je        short M05_L01
       jmp       short M05_L06
M05_L08:
       cmp       byte ptr [rbx+14],0
       je        short M05_L02
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFindHandle
       cmp       [rbx],rcx
       jne       short M05_L14
       mov       rcx,rbx
       call      qword ptr [7FF9C19A7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
M05_L09:
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       jmp       short M05_L03
M05_L10:
       or        edx,1
       jmp       short M05_L04
M05_L11:
       or        edx,2
       jmp       short M05_L05
M05_L12:
       call      00007FFA214E1F20
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFindHandle
       cmp       [rbx],rcx
       jne       short M05_L16
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9C204C240]; Interop+Kernel32.FindClose(IntPtr)
M05_L13:
       mov       ecx,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr 00007FFA214E1F40
M05_L14:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M05_L09
M05_L15:
       mov       rcx,rbx
       call      qword ptr [7FF9C1ED5DB8]
       int       3
M05_L16:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M05_L13
; Total bytes of code 241
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M06_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M06_L01
       add       rsp,28
       jmp       near ptr 00007FFA2149D4D0
M06_L00:
       mov       ecx,707
       mov       rdx,7FF9C1774000
       call      qword ptr [7FF9C183F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1ED5980]
       int       3
M06_L01:
       add       rsp,28
       ret
; Total bytes of code 65
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M07_L03
       cmp       r8d,10
       jl        near ptr M07_L09
       movsx     rax,dx
       vmovd     xmm0,eax
       vpbroadcastw ymm0,xmm0
       lea       edx,[r8-10]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M07_L11
       nop       word ptr [rax+rax]
M07_L00:
       add       rcx,20
       cmp       rcx,rax
       ja        short M07_L01
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M07_L11
       jmp       short M07_L00
M07_L01:
       mov       r8d,r8d
       test      r8b,0F
       je        short M07_L02
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M07_L11
M07_L02:
       xor       eax,eax
       vzeroupper
       ret
M07_L03:
       xor       eax,eax
       cmp       r8d,8
       jge       short M07_L07
M07_L04:
       cmp       r8d,4
       jge       near ptr M07_L08
M07_L05:
       test      r8d,r8d
       jle       short M07_L02
       movsx     r9,dx
       add       rax,rax
M07_L06:
       dec       r8d
       movsx     rdx,word ptr [rcx+rax]
       cmp       edx,r9d
       je        near ptr M07_L11
       add       rax,2
       test      r8d,r8d
       jg        short M07_L06
       jmp       short M07_L02
M07_L07:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+8]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+0A]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+0C]
       cmp       r10d,r9d
       je        near ptr M07_L11
       movsx     r10,word ptr [rcx+rax*2+0E]
       cmp       r10d,r9d
       je        near ptr M07_L11
       add       rax,8
       cmp       r8d,8
       jge       near ptr M07_L07
       jmp       near ptr M07_L04
M07_L08:
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M07_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       cmp       r10d,r9d
       je        short M07_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       cmp       r10d,r9d
       je        short M07_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       cmp       r10d,r9d
       je        short M07_L11
       add       rax,4
       jmp       near ptr M07_L05
M07_L09:
       movsx     rax,dx
       vmovd     xmm0,eax
       vpbroadcastw xmm0,xmm0
       lea       edx,[r8-8]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
M07_L10:
       vpcmpeqw  xmm1,xmm0,[rcx]
       vptest    xmm1,xmm1
       jne       short M07_L11
       add       rcx,10
       cmp       rcx,rax
       jbe       short M07_L10
       mov       r8d,r8d
       test      r8b,7
       je        near ptr M07_L02
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M07_L02
M07_L11:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 464
```
```assembly
; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       mov       edi,esi
       xor       ebp,ebp
       cmp       edi,4
       jge       near ptr M08_L19
M08_L00:
       cmp       edi,4
       jl        short M08_L04
M08_L01:
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M08_L02
       cmp       ecx,2F
       jne       short M08_L04
M08_L02:
       movzx     ecx,word ptr [rbx+2]
       cmp       ecx,5C
       je        short M08_L03
       cmp       ecx,2F
       jne       short M08_L04
M08_L03:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,2E
       je        short M08_L09
       cmp       ecx,3F
       je        short M08_L09
M08_L04:
       xor       r14d,r14d
M08_L05:
       test      r14d,r14d
       jne       near ptr M08_L23
       xor       r15d,r15d
M08_L06:
       movzx     eax,r15b
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       or        ecx,eax
       je        short M08_L07
       test      edi,edi
       jle       short M08_L07
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M08_L11
       cmp       ecx,2F
       je        short M08_L11
M08_L07:
       test      r14d,r14d
       jne       near ptr M08_L24
       cmp       esi,2
       jl        short M08_L08
       cmp       word ptr [rbx+2],3A
       je        near ptr M08_L30
M08_L08:
       mov       eax,ebp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L09:
       movzx     ecx,word ptr [rbx+6]
       cmp       ecx,5C
       je        near ptr M08_L21
       cmp       ecx,2F
       sete      r14b
       movzx     r14d,r14b
M08_L10:
       jmp       short M08_L05
M08_L11:
       test      eax,eax
       jne       short M08_L14
       cmp       edi,1
       jle       short M08_L13
       movzx     eax,word ptr [rbx+2]
       cmp       eax,5C
       je        short M08_L12
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L13
M08_L12:
       mov       eax,2
       jmp       short M08_L15
M08_L13:
       mov       ebp,1
       jmp       short M08_L08
M08_L14:
       mov       eax,8
M08_L15:
       mov       ebp,eax
       mov       eax,2
       jmp       short M08_L18
M08_L16:
       dec       eax
       test      eax,eax
       jle       short M08_L08
M08_L17:
       inc       ebp
M08_L18:
       cmp       ebp,esi
       jge       short M08_L08
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M08_L16
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M08_L17
       jmp       short M08_L16
M08_L19:
       cmp       word ptr [rbx],5C
       jne       near ptr M08_L00
       cmp       word ptr [rbx+2],5C
       je        short M08_L20
       cmp       word ptr [rbx+2],3F
       jne       near ptr M08_L00
M08_L20:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,3F
       jne       near ptr M08_L00
       cmp       word ptr [rbx+6],5C
       je        short M08_L22
       jmp       near ptr M08_L01
M08_L21:
       mov       r14d,1
       jmp       near ptr M08_L10
M08_L22:
       mov       r14d,1
       jmp       near ptr M08_L05
M08_L23:
       mov       [rsp+28],rbx
       mov       [rsp+30],edi
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9C1ED7678]
       mov       r15d,eax
       jmp       near ptr M08_L06
M08_L24:
       mov       ebp,4
       jmp       short M08_L26
M08_L25:
       inc       ebp
M08_L26:
       cmp       ebp,esi
       jge       near ptr M08_L08
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M08_L27
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L25
       jmp       short M08_L28
M08_L27:
       cmp       ebp,4
       jle       near ptr M08_L08
       jmp       short M08_L29
M08_L28:
       cmp       ebp,4
       jle       near ptr M08_L08
M08_L29:
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M08_L31
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M08_L08
       jmp       short M08_L31
M08_L30:
       movzx     eax,word ptr [rbx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M08_L08
       mov       ebp,2
       cmp       esi,2
       jle       near ptr M08_L08
       movzx     eax,word ptr [rbx+4]
       cmp       eax,5C
       je        short M08_L31
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M08_L08
M08_L31:
       inc       ebp
       jmp       near ptr M08_L08
; Total bytes of code 557
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.FileSystemInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28A8A400220
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M09_L11
M09_L00:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[r14+10]
       mov       r13,[r14+8]
       mov       r12,r13
       test      rbx,rbx
       je        near ptr M09_L13
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       test      rdx,rdx
       jne       short M09_L02
       test      byte ptr [7FF9C1EBF180],1
       je        near ptr M09_L12
M09_L01:
       mov       rcx,28A8A400290
       mov       rdx,[rcx]
M09_L02:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rsi,[rdi+20]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+69],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      bpl,bpl
       je        near ptr M09_L14
M09_L03:
       test      rsi,rsi
       je        short M09_L05
       cmp       dword ptr [rsi+8],0
       je        short M09_L05
       mov       ebp,[rsi+8]
       dec       ebp
       cmp       ebp,[rsi+8]
       jae       near ptr M09_L21
       mov       ecx,ebp
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M09_L10
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M09_L04:
       test      ecx,ecx
       jne       near ptr M09_L15
M09_L05:
       mov       rdx,rsi
M09_L06:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       test      rdx,rdx
       je        near ptr M09_L16
M09_L07:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       mov       [rbx+60],ecx
       mov       rcx,rbx
       call      qword ptr [7FF9C1E5F000]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       mov       rcx,[rbx+18]
       cmp       byte ptr [rcx+1C],0
       je        near ptr M09_L17
M09_L08:
       xor       r13d,r13d
M09_L09:
       lea       rcx,[rbx+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+FindPredicate
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0.<FileSystemInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       mov       [rbx+18],rcx
       lea       rcx,[rdi+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
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
M09_L10:
       mov       ecx,1
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28A8A4001F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileSystemInfos>b__7_0(System.IO.Enumeration.FileSystemEntry ByRef)
       call      qword ptr [7FF9C1836BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28A8A400220
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L00
M09_L12:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M09_L01
M09_L13:
       mov       ecx,1C67E
       mov       rdx,7FF9C1774000
       call      qword ptr [7FF9C183F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1ED5980]
       int       3
M09_L14:
       mov       rcx,rsi
       call      qword ptr [7FF9C1ACF060]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
       jmp       near ptr M09_L03
M09_L15:
       lea       rcx,[rsi+0C]
       mov       r12d,[rsi+8]
       mov       [rsp+28],rcx
       mov       [rsp+30],r12d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9C1E56BF8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M09_L05
       mov       r8d,ebp
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9C1AC7438]; System.String.Substring(Int32, Int32)
       mov       rdx,rax
       jmp       near ptr M09_L06
M09_L16:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A8A400290
       mov       rdx,[rcx]
       jmp       near ptr M09_L07
M09_L17:
       test      r13,r13
       je        near ptr M09_L09
       cmp       dword ptr [r13+8],0FF
       setg      sil
       movzx     esi,sil
       test      esi,esi
       jne       short M09_L20
       mov       rcx,r13
       mov       rdx,2CB095A1310
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M09_L18
       mov       rcx,r13
       mov       rdx,2CB095A0C80
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M09_L18
       mov       rcx,r13
       mov       rdx,2CB095B1018
       call      qword ptr [7FF9C1836E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M09_L19
M09_L18:
       mov       esi,1
       jmp       short M09_L20
M09_L19:
       xor       esi,esi
M09_L20:
       test      esi,esi
       jne       near ptr M09_L08
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+14],0
       jne       near ptr M09_L09
       mov       rcx,r13
       call      qword ptr [7FF9C1ED77F8]
       mov       r13,rax
       jmp       near ptr M09_L09
M09_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 929
```
```assembly
; System.IO.FileSystemInfo.EnsureDataInitialized()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        short M10_L01
M10_L00:
       cmp       dword ptr [rbx+28],0
       jne       short M10_L02
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FF9C1ED6E08]; System.IO.FileSystemInfo.RefreshCore()
       jmp       short M10_L00
M10_L02:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FF9C1ED6040]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 76
```
```assembly
; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,168
       vzeroupper
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M11_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M11_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0F0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0D8],rcx
       mov       rcx,rbp
       mov       [rbp-0C8],rcx
       cmp       byte ptr [rbx+68],0
       jne       near ptr M11_L68
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rax,[rbx+28]
       mov       [rbp-140],rax
       xor       ecx,ecx
       mov       [rbp-74],ecx
       test      rax,rax
       je        near ptr M11_L41
       mov       rcx,rax
       call      00007FFA214EDF30
       test      eax,eax
       jne       short M11_L01
       mov       rcx,[rbp-140]
       call      qword ptr [7FF9C1ED5F20]
M11_L01:
       mov       dword ptr [rbp-74],1
       cmp       byte ptr [rbx+68],0
       jne       near ptr M11_L40
M11_L02:
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M11_L09
       mov       edx,[rcx]
       test      edx,edx
       je        near ptr M11_L09
       mov       edx,edx
       add       rcx,rdx
M11_L03:
       mov       [rbx+48],rcx
       cmp       qword ptr [rbx+48],0
       je        near ptr M11_L10
M11_L04:
       cmp       byte ptr [rbx+68],0
       jne       near ptr M11_L40
       mov       rdx,[rbx+48]
       mov       rcx,rdx
       mov       rax,[rbx+38]
       test      rax,rax
       jne       near ptr M11_L18
       xor       r8d,r8d
       xor       r10d,r10d
M11_L05:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M11_L19
       xor       r9d,r9d
       xor       r11d,r11d
M11_L06:
       mov       rax,[rbx+8]
       test      rax,rax
       jne       near ptr M11_L20
       xor       edi,edi
       xor       r14d,r14d
M11_L07:
       mov       [rbp-70],rcx
       mov       [rbp-68],r8
       mov       [rbp-60],r10d
       mov       [rbp-58],r9
       mov       [rbp-50],r11d
       mov       [rbp-48],rdi
       mov       [rbp-40],r14d
       mov       ecx,[rdx+38]
       mov       rax,[rbx+18]
       test      [rax+10],ecx
       jne       near ptr M11_L02
       test      cl,10
       jne       near ptr M11_L53
M11_L08:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M11_L60
       mov       rcx,[rbx+70]
       mov       rdi,[rcx+30]
       test      rdi,rdi
       je        near ptr M11_L25
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0.<FileSystemInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rdi+18],rcx
       jne       near ptr M11_L59
       mov       rcx,[rdi+8]
       mov       rdi,[rcx+8]
       mov       rdx,[rbp-70]
       lea       r14,[rdx+44]
       mov       eax,[rdx+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+18],0
       je        near ptr M11_L21
       cmp       dword ptr [rcx+18],2
       sete      r8b
       movzx     r8d,r8b
       jmp       near ptr M11_L22
M11_L09:
       xor       ecx,ecx
       jmp       near ptr M11_L03
M11_L10:
       mov       rcx,[rbx+20]
       mov       rdx,rcx
       test      rdx,rdx
       je        short M11_L11
       add       rdx,0C
       mov       [rbp-88],rdx
       mov       rdx,[rbp-88]
       jmp       short M11_L12
M11_L11:
       xor       edx,edx
M11_L12:
       xor       r8d,r8d
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-98],xmm0
       cmp       byte ptr [rbx+69],0
       je        short M11_L13
       mov       byte ptr [rbx+69],0
       test      rcx,rcx
       jne       near ptr M11_L42
M11_L13:
       lea       rcx,[rbp-0A8]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+50]
       mov       [rsp+28],rcx
       mov       ecx,[rbx+64]
       mov       [rsp+30],ecx
       mov       dword ptr [rsp+38],2
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+48],r8
       mov       [rsp+50],ecx
       mov       [rbp+10],rbx
       mov       rcx,[rbx+58]
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       mov       rax,7FF9C19CAC90
       mov       [rbp-0E0],rax
       lea       rax,[M11_L14]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5D7ADCA0
       call      rax
M11_L14:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M11_L15
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M11_L15:
       mov       rcx,[rbp-0E8]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-88],rcx
       cmp       eax,80000006
       jbe       short M11_L16
       cmp       eax,0C000000F
       je        near ptr M11_L49
       jmp       near ptr M11_L44
M11_L16:
       test      eax,eax
       je        near ptr M11_L50
       jmp       near ptr M11_L43
M11_L17:
       mov       rcx,rdi
       call      qword ptr [7FF9C1E5F1E0]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].DirectoryFinished()
       mov       rbx,rdi
       jmp       near ptr M11_L04
M11_L18:
       lea       r8,[rax+0C]
       mov       r10d,[rax+8]
       jmp       near ptr M11_L05
M11_L19:
       lea       r9,[rax+0C]
       mov       r11d,[rax+8]
       jmp       near ptr M11_L06
M11_L20:
       lea       rdi,[rax+0C]
       mov       r14d,[rax+8]
       jmp       near ptr M11_L07
M11_L21:
       mov       r8d,1
M11_L22:
       mov       r15d,[rcx+14]
       test      r15d,r15d
       jne       near ptr M11_L28
       test      rdi,rdi
       jne       near ptr M11_L27
       xor       ecx,ecx
       xor       edx,edx
M11_L23:
       mov       [rbp-100],rcx
       mov       [rbp-0F8],edx
       mov       [rbp-110],r14
       mov       [rbp-108],eax
       lea       rcx,[rbp-100]
       lea       rdx,[rbp-110]
       xor       r9d,r9d
       call      qword ptr [7FF9C1E5F0D8]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
M11_L24:
       test      eax,eax
       je        near ptr M11_L02
M11_L25:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M11_L65
       mov       rcx,[rbx+70]
       mov       rsi,[rcx+10]
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileSystemInfos>b__7_0(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rsi+18],rcx
       jne       near ptr M11_L64
       mov       rcx,[rbp-68]
       mov       edx,[rbp-60]
       mov       r8,[rbp-70]
       lea       rsi,[r8+44]
       mov       eax,[r8+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       [rbp-0B8],rcx
       mov       [rbp-0B0],edx
       cmp       dword ptr [rbp-0B0],0
       jne       near ptr M11_L32
       mov       [rbp-100],rsi
       mov       [rbp-0F8],eax
       lea       rcx,[rbp-100]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M11_L26:
       mov       rcx,[rbp-70]
       test      byte ptr [rcx+38],10
       jne       near ptr M11_L37
       mov       rcx,[rbp-70]
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rbp-100],rax
       mov       [rbp-0F8],ecx
       lea       rcx,[rbp-100]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       xor       ecx,ecx
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rsi
       jmp       near ptr M11_L38
M11_L27:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
       jmp       near ptr M11_L23
M11_L28:
       cmp       r15d,1
       jne       short M11_L31
       test      rdi,rdi
       jne       short M11_L30
       xor       ecx,ecx
       xor       edx,edx
M11_L29:
       mov       [rbp-100],rcx
       mov       [rbp-0F8],edx
       mov       [rbp-110],r14
       mov       [rbp-108],eax
       lea       rcx,[rbp-100]
       lea       rdx,[rbp-110]
       mov       r9d,1
       call      qword ptr [7FF9C1E5F0D8]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
       jmp       near ptr M11_L24
M11_L30:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
       jmp       short M11_L29
M11_L31:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9C1774000
       call      qword ptr [7FF9C183F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1ED6F70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L32:
       test      eax,eax
       je        near ptr M11_L36
       mov       rdi,[rbp-0B8]
       mov       r14d,[rbp-0B0]
       lea       ecx,[r14-1]
       cmp       ecx,r14d
       jae       near ptr M11_L62
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M11_L34
       cmp       ecx,2F
       je        short M11_L34
       movzx     ecx,word ptr [rsi]
       cmp       ecx,5C
       je        near ptr M11_L63
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M11_L33:
       test      ecx,ecx
       jne       short M11_L34
       mov       rcx,2CB095A81EC
       mov       [rbp-100],rdi
       mov       [rbp-0F8],r14d
       mov       [rbp-110],rcx
       mov       dword ptr [rbp-108],1
       mov       [rbp-138],rsi
       mov       [rbp-130],eax
       lea       rcx,[rbp-100]
       lea       rdx,[rbp-110]
       lea       r8,[rbp-138]
       call      qword ptr [7FF9C1E56D00]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       jmp       short M11_L35
M11_L34:
       mov       [rbp-100],rdi
       mov       [rbp-0F8],r14d
       mov       [rbp-110],rsi
       mov       [rbp-108],eax
       lea       rcx,[rbp-100]
       lea       rdx,[rbp-110]
       call      qword ptr [7FF9C1BBD9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M11_L35:
       jmp       near ptr M11_L26
M11_L36:
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FF9C1A0F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       jmp       near ptr M11_L26
M11_L37:
       mov       rcx,[rbp-70]
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rbp-100],rax
       mov       [rbp-0F8],ecx
       lea       rcx,[rbp-100]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+54],1
M11_L38:
       mov       rdx,[rbp-70]
       mov       ecx,[rdx+38]
       mov       [rdi+30],ecx
       mov       rcx,[rdx+8]
       mov       [rdi+34],rcx
       mov       rcx,[rdx+10]
       mov       [rdi+3C],rcx
       mov       rcx,[rdx+18]
       mov       [rdi+44],rcx
       mov       rcx,[rdx+28]
       sar       rcx,20
       mov       [rdi+4C],ecx
       mov       edx,[rdx+28]
       mov       [rdi+50],edx
       xor       edx,edx
       mov       [rdi+28],edx
M11_L39:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,1
       jmp       near ptr M11_L66
M11_L40:
       xor       esi,esi
       jmp       near ptr M11_L66
M11_L41:
       xor       ecx,ecx
       call      qword ptr [7FF9C1ED5980]
       int       3
M11_L42:
       mov       r8d,[rcx+8]
       add       r8d,r8d
       movzx     ecx,r8w
       mov       [rbp-96],cx
       mov       [rbp-98],cx
       mov       [rbp-90],rdx
       lea       r8,[rbp-98]
       jmp       near ptr M11_L13
M11_L43:
       cmp       eax,80000006
       jne       short M11_L45
       mov       rdi,[rbp+10]
       jmp       near ptr M11_L17
M11_L44:
       cmp       eax,0C0000033
       je        short M11_L48
M11_L45:
       mov       ecx,eax
       mov       rax,7FF9C19CAC50
       mov       [rbp-0E0],rax
       lea       rax,[M11_L46]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9C19CAC70]
M11_L46:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M11_L47
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M11_L47:
       mov       rcx,[rbp-0E8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       cmp       ebx,5
       je        short M11_L51
       mov       rdi,[rbp+10]
       jmp       short M11_L52
M11_L48:
       mov       rdi,[rbp+10]
       jmp       near ptr M11_L17
M11_L49:
       mov       rdi,[rbp+10]
       jmp       near ptr M11_L17
M11_L50:
       mov       rbx,[rbp+10]
       mov       rax,[rbx+50]
       mov       [rbp+10],rbx
       mov       [rbx+48],rax
       mov       rbx,[rbp+10]
       jmp       near ptr M11_L04
M11_L51:
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+18]
       cmp       byte ptr [rcx+1D],0
       jne       near ptr M11_L17
M11_L52:
       mov       rcx,rdi
       mov       edx,ebx
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M11_L17
       jmp       near ptr M11_L61
M11_L53:
       mov       rcx,rdx
       mov       ecx,[rcx+3C]
       mov       eax,ecx
       shr       eax,1F
       add       ecx,eax
       sar       ecx,1
       mov       eax,ecx
       cmp       eax,2
       jg        short M11_L55
       add       rdx,44
       mov       rax,rdx
       mov       r8d,ecx
       test      r8d,r8d
       je        near ptr M11_L62
       cmp       word ptr [rax],2E
       jne       short M11_L55
       mov       eax,ecx
       cmp       eax,2
       jne       short M11_L54
       cmp       ecx,1
       jbe       near ptr M11_L62
       cmp       word ptr [rdx+2],2E
       jne       short M11_L55
M11_L54:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1E],0
       jne       near ptr M11_L08
       jmp       near ptr M11_L02
M11_L55:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1C],0
       je        near ptr M11_L08
       cmp       dword ptr [rbx+60],0
       jle       near ptr M11_L08
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       je        near ptr M11_L08
       mov       rcx,[rbx+38]
       test      rcx,rcx
       jne       short M11_L56
       xor       edx,edx
       xor       eax,eax
       jmp       short M11_L57
M11_L56:
       lea       rdx,[rcx+0C]
       mov       eax,[rcx+8]
M11_L57:
       mov       rcx,[rbx+48]
       lea       r8,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       r10d,ecx
       shr       r10d,1F
       add       ecx,r10d
       sar       ecx,1
       mov       [rbp-100],rdx
       mov       [rbp-0F8],eax
       mov       [rbp-110],r8
       mov       [rbp-108],ecx
       lea       rcx,[rbp-100]
       lea       rdx,[rbp-110]
       call      qword ptr [7FF9C1E5F108]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+48]
       lea       rcx,[rdx+44]
       mov       edx,[rdx+3C]
       mov       r8d,edx
       shr       r8d,1F
       add       edx,r8d
       sar       edx,1
       mov       [rbp-100],rcx
       mov       [rbp-0F8],edx
       lea       rdx,[rbp-100]
       mov       rcx,rbx
       mov       r8,rdi
       call      qword ptr [7FF9C1ED6EF8]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        near ptr M11_L08
       cmp       qword ptr [rbx+40],0
       jne       short M11_L58
       mov       rcx,offset MT_System.Collections.Generic.Queue<System.ValueTuple<System.IntPtr, System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF9C1ED6F10]
       lea       rcx,[rbx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M11_L58:
       mov       rcx,[rbx+40]
       mov       edx,[rbx+60]
       dec       edx
       mov       [rbp-128],rdi
       mov       rax,[rbp-80]
       mov       [rbp-120],rax
       mov       [rbp-118],edx
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED6F28]
       jmp       near ptr M11_L08
M11_L59:
       lea       rdx,[rbp-70]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       jmp       near ptr M11_L24
M11_L60:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M11_L24
M11_L61:
       mov       [rbp+10],rdi
       mov       esi,ebx
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+38]
       mov       ecx,esi
       xor       r8d,r8d
       call      qword ptr [7FF9C1ED6040]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L63:
       mov       ecx,1
       jmp       near ptr M11_L33
M11_L64:
       lea       rdx,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdi,rax
       jmp       near ptr M11_L39
M11_L65:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M11_L39
M11_L66:
       mov       rcx,[rbp-140]
       call      00007FFA214EDE50
       test      eax,eax
       jne       short M11_L69
M11_L67:
       movzx     eax,sil
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L68:
       xor       esi,esi
       jmp       short M11_L67
M11_L69:
       mov       ecx,eax
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9C1ED5A88]
       jmp       short M11_L67
       sub       rsp,58
       vzeroupper
       mov       rcx,[rbp-80]
       call      qword ptr [7FF9C1E56FA0]; Interop+Kernel32.CloseHandle(IntPtr)
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,58
       vzeroupper
       cmp       dword ptr [rbp-74],0
       je        short M11_L71
       cmp       qword ptr [rbp-140],0
       jne       short M11_L70
       xor       ecx,ecx
       call      qword ptr [7FF9C1ED5980]
       int       3
M11_L70:
       mov       rcx,[rbp-140]
       call      00007FFA214EDE50
       test      eax,eax
       je        short M11_L71
       mov       ecx,eax
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9C1ED5A88]
M11_L71:
       nop
       add       rsp,58
       ret
; Total bytes of code 2723
```
```assembly
; System.IO.FileSystemInfo.set_Attributes(System.IO.FileAttributes)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9E93F70C8]; Precode of System.IO.FileSystem.SetAttributes(System.String, System.IO.FileAttributes)
       mov       dword ptr [rbx+28],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 31
```
```assembly
; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M13_L11
       mov       [rbp-98],rax
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,rax
       call      00007FFA214EDF30
       test      eax,eax
       jne       short M13_L00
       mov       rcx,[rbp-98]
       call      qword ptr [7FF9C1ED5F20]
M13_L00:
       mov       dword ptr [rbp-3C],1
       mov       byte ptr [rbx+68],1
       mov       [rbp+10],rbx
       lea       rcx,[rbx+58]
       xor       eax,eax
       mov       r14,rax
       xchg      r14,[rcx]
       test      r14,r14
       je        short M13_L03
       xor       ecx,ecx
       mov       rax,7FFA5D535FF0
       call      rax
       mov       rcx,r14
       mov       rax,7FF9C19AF918
       mov       [rbp-80],rax
       lea       rax,[M13_L01]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA5D544C20
       call      rax
M13_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M13_L02
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M13_L02:
       mov       rax,[rbp-88]
       mov       [rdi+8],rax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       call      00007FFA214E1F40
M13_L03:
       mov       rbx,[rbp+10]
       cmp       qword ptr [rbx+40],0
       jne       short M13_L08
M13_L04:
       mov       [rbp+10],rbx
       mov       rcx,[rbx+50]
       test      rcx,rcx
       je        short M13_L07
       test      rcx,0FFFFFFFFFFFF0000
       je        short M13_L07
       mov       rax,7FF9C19ADA58
       mov       [rbp-80],rax
       lea       rax,[M13_L05]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA5D537EA0
       call      rax
M13_L05:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M13_L06
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M13_L06:
       mov       rcx,[rbp-88]
       mov       [rdi+8],rcx
M13_L07:
       xor       ecx,ecx
       mov       rbx,[rbp+10]
       mov       [rbx+50],rcx
       jmp       short M13_L10
M13_L08:
       mov       rcx,[rbx+40]
       cmp       dword ptr [rcx+18],0
       jle       short M13_L09
       mov       rcx,[rbx+40]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED7930]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C1E56FA0]; Interop+Kernel32.CloseHandle(IntPtr)
       jmp       short M13_L08
M13_L09:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       jmp       near ptr M13_L04
M13_L10:
       mov       rcx,[rbp-98]
       call      00007FFA214EDE50
       test      eax,eax
       jne       short M13_L13
M13_L11:
       mov       rdx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       cmp       [rbx],rdx
       jne       short M13_L14
M13_L12:
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
M13_L13:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1ED5A88]
       jmp       short M13_L11
M13_L14:
       movzx     edx,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M13_L12
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       je        short M13_L15
       mov       rcx,[rbp-98]
       call      00007FFA214EDE50
       test      eax,eax
       je        short M13_L15
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FF9C1ED5A88]
M13_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 592
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,2CB095A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FF9C1ED5DA0]
       int       3
; Total bytes of code 244
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       eax,r8d
       add       rcx,rax
       mov       eax,[rbx+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M15_L02
       test      r8d,r8d
       je        short M15_L01
       cmp       eax,r8d
       je        short M15_L00
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FF9E93EB9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,esi
       lea       rdx,[rbx+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FF9E93ED928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L02:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF9E93EBD30]
       int       3
; Total bytes of code 136
```
```assembly
; System.IO.FileSystemInfo.get_Attributes()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,318
       vzeroupper
       lea       rbp,[rsp+350]
       xor       eax,eax
       mov       [rbp-308],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-300],ymm4
       vmovdqu   ymmword ptr [rbp-2E0],ymm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       rax,6022C429E2B
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-2F0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-2D8],rcx
       mov       rcx,rbp
       mov       [rbp-2C8],rcx
       mov       [rbp-328],rbx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M16_L18
       lea       rdi,[rbx+30]
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rdi],ymm1
       vmovdqu   xmmword ptr [rdi+14],xmm1
       mov       r14,[rbx+8]
       mov       [rbp-310],rdi
       xor       r15d,r15d
       test      r14,r14
       je        short M16_L01
       cmp       dword ptr [r14+8],0
       je        short M16_L01
       mov       r13d,[r14+8]
       dec       r13d
       cmp       r13d,[r14+8]
       jae       near ptr M16_L27
       mov       ecx,r13d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M16_L22
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M16_L00:
       test      ecx,ecx
       jne       near ptr M16_L23
M16_L01:
       mov       [rbp-320],r14
M16_L02:
       xor       ecx,ecx
       mov       [rbp-2A0],rcx
       mov       [rbp-29C],ecx
       mov       rax,7FFA5D535FF0
       call      rax
       lea       rdx,[rbp-29C]
       mov       ecx,1
       mov       rax,7FFA5D53BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       call      00007FFA214E1F40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2A0],al
       movzx     eax,byte ptr [rbp-2A0]
       mov       [rbp-2F4],al
       mov       eax,[rbp-29C]
       mov       [rbp-2F8],eax
       cmp       dword ptr [7FFA217A4A90],0
       jne       near ptr M16_L24
M16_L03:
       mov       r14,[rbp-320]
       test      r14,r14
       je        short M16_L04
       mov       ecx,[r14+8]
       cmp       ecx,104
       jge       near ptr M16_L09
       test      ecx,ecx
       je        short M16_L04
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M16_L09
       cmp       ecx,2E
       je        near ptr M16_L09
M16_L04:
       mov       [rbp-320],r14
       mov       rax,r14
M16_L05:
       mov       rdi,[rbp-310]
       mov       [rbp-2A8],rdi
       mov       rbx,rdi
       test      rax,rax
       je        near ptr M16_L10
       add       rax,0C
       mov       r13,rax
M16_L06:
       mov       [rbp-2B0],r13
       xor       ecx,ecx
       mov       rax,7FFA5D535FF0
       call      rax
       mov       rcx,r13
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FF9C19AEDE8
       mov       [rbp-2E0],rax
       lea       rax,[M16_L07]
       mov       [rbp-2D0],rax
       lea       rax,[rbp-2F0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5D545090
       call      rax
M16_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M16_L08
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M16_L08:
       mov       rcx,[rbp-2E8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA5D535F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B0],rax
       mov       [rbp-2A8],rax
       call      00007FFA214E1F40
       test      ebx,ebx
       jne       near ptr M16_L14
       call      00007FFA214E1F20
       mov       r15d,eax
       mov       ecx,r15d
       call      qword ptr [7FF9C1E56BC8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M16_L14
       jmp       short M16_L11
M16_L09:
       mov       rcx,r14
       call      qword ptr [7FF9C1E56C40]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-320],r14
       jmp       near ptr M16_L05
M16_L10:
       xor       r13d,r13d
       jmp       near ptr M16_L06
M16_L11:
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FF9C18357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-320]
       call      qword ptr [7FF9C1ED79C0]
       mov       [rbp-318],rax
       mov       rcx,[rbp-318]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C19A7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M16_L12
       call      00007FFA214E1F20
       mov       r15d,eax
       jmp       short M16_L13
M16_L12:
       xor       r15d,r15d
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-310]
       call      qword ptr [7FF9C1ED79D8]
       nop
M16_L13:
       mov       rcx,[rbp-318]
       mov       edx,1
       call      qword ptr [7FF9C183DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-318]
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
       nop
M16_L14:
       cmp       byte ptr [rbp-2F4],0
       je        short M16_L15
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FF9C1828C18
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FF9C1828C30
       call      00007FF9C1828C48
       mov       ecx,eax
       call      00007FFA214E1F40
M16_L15:
       test      r15d,r15d
       jne       short M16_L20
M16_L16:
       mov       eax,r15d
M16_L17:
       mov       rbx,[rbp-328]
       mov       [rbx+28],eax
M16_L18:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M16_L26
       mov       eax,[rbx+30]
       mov       r8,6022C429E2B
       cmp       [rbp-40],r8
       je        short M16_L19
       call      CORINFO_HELP_FAIL_FAST
M16_L19:
       nop
       add       rsp,318
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L20:
       lea       eax,[r15-2]
       cmp       eax,1
       ja        short M16_L25
M16_L21:
       mov       rdi,[rbp-310]
       mov       dword ptr [rdi],0FFFFFFFF
       xor       eax,eax
       jmp       short M16_L17
M16_L22:
       mov       ecx,1
       jmp       near ptr M16_L00
M16_L23:
       lea       rcx,[r14+0C]
       mov       r12d,[r14+8]
       mov       [rbp-308],rcx
       mov       [rbp-300],r12d
       lea       rcx,[rbp-308]
       call      qword ptr [7FF9C1E56BF8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M16_L01
       mov       r8d,r13d
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1AC7438]; System.String.Substring(Int32, Int32)
       mov       [rbp-320],rax
       jmp       near ptr M16_L02
M16_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L25:
       cmp       r15d,15
       jne       near ptr M16_L16
       jmp       short M16_L21
M16_L26:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FF9C1ED6040]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-318],0
       je        short M16_L28
       mov       rcx,[rbp-318]
       mov       edx,1
       call      qword ptr [7FF9C183DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-318]
       call      qword ptr [7FF9C1A05578]; System.GC.SuppressFinalize(System.Object)
M16_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2F4],0
       je        short M16_L29
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FF9C1828C18
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FF9C1828C30
       call      00007FF9C1828C48
       mov       ecx,eax
       call      00007FFA214E1F40
M16_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1214
```
```assembly
; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L04
       cmp       dword ptr [rsi+8],0
       je        near ptr M17_L05
       mov       rcx,7FF9C1F34D38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx]
       mov       ebx,[rbx+8]
       mov       rbp,[rsi]
       mov       esi,[rsi+8]
       lea       edx,[rbx-1]
       cmp       edx,ebx
       jae       near ptr M17_L08
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,5C
       je        near ptr M17_L03
       cmp       edx,2F
       je        near ptr M17_L03
       test      esi,esi
       je        near ptr M17_L08
       movzx     edx,word ptr [rbp]
       cmp       edx,5C
       je        near ptr M17_L02
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M17_L00:
       test      edx,edx
       jne       near ptr M17_L03
       mov       edx,ebx
       add       edx,1
       jo        near ptr M17_L09
       add       edx,esi
       jo        near ptr M17_L09
       test      edx,edx
       je        near ptr M17_L06
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebx,r13d
       ja        near ptr M17_L07
       mov       r12d,ebx
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9C1835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15,r12
       sub       r13d,ebx
       je        near ptr M17_L07
       mov       word ptr [r15],5C
       lea       rcx,[r15+2]
       dec       r13d
       cmp       esi,r13d
       ja        near ptr M17_L07
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbp
       call      qword ptr [7FF9C1835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M17_L01:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L02:
       mov       edx,1
       jmp       near ptr M17_L00
M17_L03:
       mov       [rsp+38],rdi
       mov       [rsp+40],ebx
       mov       [rsp+28],rbp
       mov       [rsp+30],esi
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9C1BBD9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       jmp       short M17_L01
M17_L04:
       mov       rcx,7FF9C1F34D30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      qword ptr [7FF9C1A0F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L05:
       mov       rcx,7FF9C1F34D34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF9C1A0F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L06:
       mov       r14,2CB095A0008
       jmp       near ptr M17_L01
M17_L07:
       call      qword ptr [7FF9C1C4D0E0]
       int       3
M17_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 484
```
```assembly
; System.String.Substring(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       je        short M18_L00
       mov       ecx,[rsi+8]
       mov       r8d,ecx
       sub       r8d,ebx
       je        short M18_L01
       cmp       ecx,ebx
       jb        short M18_L02
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FF9E93EB9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,ebx
       lea       rdx,[rsi+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FF9E93ED928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L02:
       mov       rcx,rsi
       mov       edx,ebx
       call      qword ptr [7FF9E93EBD30]
       int       3
; Total bytes of code 127
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        short M19_L02
       test      rbx,rbx
       je        short M19_L00
       test      rsi,rsi
       je        short M19_L03
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M19_L01
       mov       rcx,7FF9C1EFC434
       call      CORINFO_HELP_COUNTPROFILE32
M19_L00:
       mov       rcx,7FF9C1EFC438
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L01:
       mov       rcx,7FF9C1EFC440
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       call      qword ptr [7FF9C183C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L02:
       mov       rcx,7FF9C1EFC430
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L03:
       mov       rcx,7FF9C1EFC43C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M19_L00
; Total bytes of code 162
```

