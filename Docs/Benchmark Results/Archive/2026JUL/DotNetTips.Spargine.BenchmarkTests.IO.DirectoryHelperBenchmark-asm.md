## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FF9F0FE5650]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-68],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-70],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-78],rdx
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F127E910]; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5.MoveNext()
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
       call      qword ptr [7FF9F14357B8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9F12FF078]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-48]
       call      qword ptr [7FF9F14370F0]
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
       call      qword ptr [7FF9F14357B8]
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
       jmp       qword ptr [7FF9F12F50C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA4CA24030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA4CA24038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA4CA25EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA4CA23FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,1F1F24001B0
       mov       r15,[rcx]
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+138]
       inc       dword ptr [r14+14]
       mov       r13d,[r14+10]
       cmp       [r15+8],r13d
       ja        near ptr M03_L36
       mov       rcx,r14
       call      qword ptr [7FF9F0C471C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L00:
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [r15+8],ecx
       mov       rcx,r15
       call      qword ptr [7FF9F0E16670]; System.Object.GetType()
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F0B8A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22
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
       mov       rcx,23271430B18
       mov       [r15+30],rcx
       xor       ecx,ecx
       mov       [r15+44],ecx
       mov       [r15+88],rcx
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9F12CF9A0]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22.System.Collections.Generic.IAsyncEnumerable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>>.GetAsyncEnumerator(System.Threading.CancellationToken)
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
       call      qword ptr [7FF9F14357B8]
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
       mov       r11,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22
       cmp       [rcx],r11
       jne       near ptr M03_L16
       mov       rdi,[rcx+8]
M03_L09:
       mov       [rbp-60],rdi
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-60]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
M03_L10:
       lea       rdi,[rsi+20]
       mov       r14,[rdi]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22
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
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FF9F0FE5650]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M03_L12:
       mov       [rbp-90],r15
       mov       rcx,[r15+8]
       mov       [rbp-98],rcx
       mov       rcx,[r15+10]
       mov       [rbp-0A0],rcx
       mov       rcx,r14
       call      qword ptr [7FF9F12CF990]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22.MoveNext()
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
       mov       r11,7FF9F0B90B48
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
       call      qword ptr [7FF9F12FF078]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L11
M03_L19:
       call      qword ptr [7FF9F1435530]
       int       3
M03_L20:
       mov       rax,[r13+18]
       mov       rax,[rax+8]
       jmp       near ptr M03_L04
M03_L21:
       call      qword ptr [7FF9F14358F0]
       int       3
M03_L22:
       lea       rdx,[rbp-70]
       mov       rcx,r14
       mov       r11,7FF9F0B90B50
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
       mov       r11,7FF9F0B90B60
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
       call      qword ptr [7FF9F12F4648]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5, DotNetTips.Spargine.BenchmarkTests]](<LoadFilesAsync>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FF9F12F4660]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredValueTaskAwaiter<Boolean> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9F12F50C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
M03_L27:
       movzx     r14d,byte ptr [r14+38]
       jmp       near ptr M03_L08
M03_L28:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-40]
       mov       r11,7FF9F0B90B68
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M03_L08
M03_L29:
       mov       rsi,[rbp+10]
       lea       rdi,[rsi+20]
       mov       rcx,[rdi]
       mov       rdx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22
       cmp       [rcx],rdx
       jne       near ptr M03_L37
       lea       rdx,[rbp-80]
       call      qword ptr [7FF9F12CF9E8]; DotNetTips.Spargine.IO.DirectoryHelper+<LoadFilesAsyncCore>d__22.System.IAsyncDisposable.DisposeAsync()
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
       mov       r11,7FF9F0B90B70
       call      qword ptr [r11]
       jmp       near ptr M03_L30
M03_L38:
       test      dword ptr [rax+34],1600000
       jne       near ptr M03_L31
       jmp       short M03_L41
M03_L39:
       movsx     rdx,word ptr [rbp-50]
       lea       rcx,[rdi+18]
       call      qword ptr [7FF9F1437828]
       jmp       near ptr M03_L34
M03_L40:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       mov       r11,7FF9F0B90B78
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
       call      qword ptr [7FF9F12F4648]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark+<LoadFilesAsync>d__5, DotNetTips.Spargine.BenchmarkTests]](<LoadFilesAsync>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F1437CA8]
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
       call      qword ptr [7FF9F12F50C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L32
M03_L44:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       call      qword ptr [7FF9F130F4E8]
       jmp       near ptr M03_L32
M03_L45:
       mov       rcx,rdi
       movsx     rdx,word ptr [rbp-50]
       mov       r11,7FF9F0B90B80
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
       call      qword ptr [7FF9F127EAD8]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F127EAF0]
       int       3
M03_L48:
       mov       dword ptr [rsi+10],0FFFFFFFE
       lea       rcx,[rsi+18]
       cmp       qword ptr [rcx],0
       je        near ptr M03_L53
       mov       rdi,[rcx]
       mov       rcx,1F1F2400228
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
       call      qword ptr [7FF9F1435980]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L57
M03_L51:
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M03_L58
       mov       rdx,1F1DC400218
       mov       rdx,[rdx]
       call      00007FFA50878250
       test      rax,rax
       je        short M03_L52
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FF9F12F4E40]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1F1DC400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L52
M03_L54:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F12F5188]
       mov       edx,eax
       mov       rcx,1F1F2400228
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9F1435938]
       jmp       near ptr M03_L49
M03_L55:
       mov       rcx,rdi
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9F1435950]
       test      eax,eax
       jne       near ptr M03_L50
M03_L56:
       mov       ecx,18
       call      qword ptr [7FF9F1435968]
       int       3
M03_L57:
       call      qword ptr [7FF9F1437720]
       jmp       near ptr M03_L51
M03_L58:
       call      qword ptr [7FF9F12FF1C8]
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
       call      qword ptr [7FF9F14357B8]
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
       call      qword ptr [7FF9F127EB20]
       lea       rax,[M03_L52]
       add       rsp,28
       ret
; Total bytes of code 2323
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA4CA3CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9F12F50E0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9F14378D0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9F1437108]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9F1437E10]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+3C],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2A89E850B18
       mov       [rdi+28],rcx
       xor       ecx,ecx
       mov       [rdi+44],ecx
       mov       [rdi+50],rcx
       mov       [rsp+28],rdi
       mov       rbx,[rbx+60]
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
; Total bytes of code 129
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,388
       vzeroupper
       lea       rbp,[rsp+3C0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFCD0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rax,4D7BDBEBDC8C
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-338]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-320],rcx
       mov       rcx,rbp
       mov       [rbp-310],rcx
       mov       rbx,[rbx+138]
       mov       [rbp-358],rbx
       test      rbx,rbx
       je        near ptr M00_L59
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9F126DF20]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L54
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9F126DF20]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L60
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M00_L18
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbx+30],ymm1
       vmovdqu   xmmword ptr [rbx+44],xmm1
       mov       rdi,[rbx+8]
       lea       r14,[rbx+30]
       mov       [rbp-378],r14
       xor       r15d,r15d
       test      rdi,rdi
       je        short M00_L02
       cmp       dword ptr [rdi+8],0
       je        short M00_L02
       mov       r13d,[rdi+8]
       dec       r13d
       cmp       r13d,[rdi+8]
       jae       near ptr M00_L72
       mov       ecx,r13d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M00_L58
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L62
M00_L02:
       mov       [rbp-388],rdi
M00_L03:
       xor       ecx,ecx
       mov       [rbp-2A8],rcx
       mov       [rbp-2A4],ecx
       mov       rax,7FFA942C5FF0
       call      rax
       lea       rdx,[rbp-2A4]
       mov       ecx,1
       mov       rax,7FFA942CBE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       mov       ecx,eax
       call      00007FFA508C6B40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2A8],al
       movzx     eax,byte ptr [rbp-2A8]
       mov       [rbp-33C],al
       mov       eax,[rbp-2A4]
       mov       [rbp-340],eax
       cmp       dword ptr [7FFA50B839A0],0
       jne       near ptr M00_L63
M00_L04:
       mov       rdi,[rbp-388]
       test      rdi,rdi
       je        short M00_L05
       mov       ecx,[rdi+8]
       cmp       ecx,104
       jge       near ptr M00_L10
       test      ecx,ecx
       je        short M00_L05
       dec       ecx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M00_L10
       cmp       ecx,2E
       je        near ptr M00_L10
M00_L05:
       mov       [rbp-388],rdi
       mov       rax,rdi
M00_L06:
       mov       r14,[rbp-378]
       mov       [rbp-2B0],r14
       mov       rbx,r14
       test      rax,rax
       je        near ptr M00_L11
       add       rax,0C
       mov       r13,rax
M00_L07:
       mov       [rbp-2B8],r13
       xor       ecx,ecx
       mov       rax,7FFA942C5FF0
       call      rax
       mov       rcx,r13
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FF9F0DBEDE8
       mov       [rbp-328],rax
       lea       rax,[M00_L08]
       mov       [rbp-318],rax
       lea       rax,[rbp-338]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D5090
       call      rax
M00_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M00_L09
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M00_L09:
       mov       rcx,[rbp-330]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       mov       [rbp-2B0],rax
       call      00007FFA508C6B40
       test      ebx,ebx
       jne       near ptr M00_L15
       jmp       short M00_L12
M00_L10:
       mov       rcx,rdi
       call      qword ptr [7FF9F1265F68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-388],rdi
       jmp       near ptr M00_L06
M00_L11:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L12:
       call      00007FFA508C6B20
       mov       r15d,eax
       mov       ecx,r15d
       call      qword ptr [7FF9F1265EF0]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M00_L15
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FF9F0C457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-388]
       call      qword ptr [7FF9F1306118]
       mov       [rbp-380],rax
       mov       rcx,[rbp-380]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F0DB7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M00_L13
       call      00007FFA508C6B20
       mov       r15d,eax
       jmp       short M00_L14
M00_L13:
       xor       r15d,r15d
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-378]
       call      qword ptr [7FF9F1306130]
       nop
M00_L14:
       mov       rcx,[rbp-380]
       mov       edx,1
       call      qword ptr [7FF9F0C4DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-380]
       call      qword ptr [7FF9F0E15590]; System.GC.SuppressFinalize(System.Object)
       nop
M00_L15:
       cmp       byte ptr [rbp-33C],0
       je        short M00_L16
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9F0C38C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-340]
       call      00007FF9F0C38C18
       call      00007FF9F0C38C30
       mov       ecx,eax
       call      00007FFA508C6B40
M00_L16:
       test      r15d,r15d
       jne       near ptr M00_L64
M00_L17:
       mov       rbx,[rbp-358]
       mov       [rbx+28],r15d
M00_L18:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M00_L66
       mov       edi,[rbx+30]
       and       edi,0FFFFFFFE
       mov       r14,[rbx+8]
       mov       [rbp-390],r14
       test      r14,r14
       je        short M00_L19
       mov       ecx,[r14+8]
       cmp       ecx,104
       jge       near ptr M00_L56
       test      ecx,ecx
       je        short M00_L19
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M00_L56
       cmp       ecx,2E
       je        near ptr M00_L56
M00_L19:
       mov       rax,r14
M00_L20:
       test      rax,rax
       je        near ptr M00_L57
       add       rax,0C
       mov       r15,rax
M00_L21:
       mov       [rbp-2C8],r15
       xor       ecx,ecx
       mov       rax,7FFA942C5FF0
       call      rax
       mov       rcx,r15
       mov       edx,edi
       mov       rax,7FF9F0DBF580
       mov       [rbp-328],rax
       lea       rax,[M00_L22]
       mov       [rbp-318],rax
       lea       rax,[rbp-338]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D5290
       call      rax
M00_L22:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M00_L23
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M00_L23:
       mov       rcx,[rbp-330]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2C8],rax
       call      00007FFA508C6B40
       test      ebx,ebx
       je        near ptr M00_L67
       mov       rbx,[rbp-358]
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       r8,[rbx+8]
       mov       [rbp-2D8],r8
       mov       r8,22500970B18
       mov       [rbp-2D0],r8
       mov       r8,1E46B8021B0
       mov       rdi,[r8]
       mov       r8,[rbp-2D0]
       test      r8,r8
       je        near ptr M00_L69
       movzx     r14d,byte ptr [rbx+54]
       mov       r8d,[rdi+14]
       lea       rdx,[rbp-2D0]
       lea       rcx,[rbp-2D8]
       call      qword ptr [7FF9F126E0A0]; System.IO.Enumeration.FileSystemEnumerableFactory.NormalizeInputs(System.String ByRef, System.String ByRef, System.IO.MatchType)
       and       eax,r14d
       mov       [rbx+54],al
       movzx     r9d,byte ptr [rbx+54]
       mov       rcx,[rbp-2D8]
       mov       rdx,[rbp-2D0]
       mov       r8,rdi
       call      qword ptr [7FF9F126E0E8]; System.IO.Enumeration.FileSystemEnumerableFactory.FileSystemInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>
       cmp       [rbx],rcx
       jne       near ptr M00_L71
       lea       rcx,[rbx+8]
       xor       eax,eax
       xchg      rax,[rcx]
       test      rax,rax
       je        near ptr M00_L70
M00_L24:
       mov       [rbp-360],rax
       cmp       qword ptr [rbp-360],0
       je        near ptr M00_L41
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rax,[rbp-360]
       cmp       [rax],rcx
       jne       near ptr M00_L41
       jmp       near ptr M00_L31
M00_L25:
       cmp       r15d,2E
       je        near ptr M00_L33
M00_L26:
       mov       [rbp-398],r14
       mov       rax,r14
M00_L27:
       test      rax,rax
       je        near ptr M00_L34
       add       rax,0C
       mov       r13,rax
M00_L28:
       mov       [rbp-2E0],r13
       xor       ecx,ecx
       mov       rax,7FFA942C5FF0
       call      rax
       mov       rcx,r13
       mov       edx,80
       mov       rax,7FF9F0DBF580
       mov       [rbp-328],rax
       lea       rax,[M00_L29]
       mov       [rbp-318],rax
       lea       rax,[rbp-338]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D5290
       call      rax
M00_L29:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M00_L30
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M00_L30:
       mov       rcx,[rbp-330]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       xor       ecx,ecx
       mov       [rbp-2E0],rcx
       mov       ecx,eax
       call      00007FFA508C6B40
       test      ebx,ebx
       je        near ptr M00_L50
       mov       rbx,[rbp-368]
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rax,[rbp-360]
M00_L31:
       mov       rcx,rax
       call      qword ptr [7FF9F12C9C70]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L53
       mov       rcx,[rbp-360]
       mov       rbx,[rcx+28]
       cmp       qword ptr [rbp-298],0
       je        short M00_L32
       mov       rdi,[rbp-298]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M00_L49
M00_L32:
       mov       [rbp-368],rbx
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M00_L26
       mov       eax,[r14+8]
       cmp       eax,104
       jge       short M00_L33
       test      eax,eax
       je        near ptr M00_L26
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M00_L52
       mov       eax,edx
       movzx     r15d,word ptr [r14+rax*2+0C]
       cmp       r15d,20
       jne       near ptr M00_L25
M00_L33:
       mov       rcx,r14
       call      qword ptr [7FF9F1265F68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-398],r14
       jmp       near ptr M00_L27
M00_L34:
       xor       r13d,r13d
       jmp       near ptr M00_L28
M00_L35:
       cmp       r15d,2E
       je        near ptr M00_L45
M00_L36:
       mov       [rbp-398],r14
       mov       rcx,r14
M00_L37:
       test      rcx,rcx
       je        near ptr M00_L46
       lea       r13,[rcx+0C]
M00_L38:
       mov       [rbp-2E0],r13
       xor       ecx,ecx
       mov       rdx,7FFA942C5FF0
       call      rdx
       mov       rcx,r13
       mov       edx,80
       mov       rax,7FF9F0DBF580
       mov       [rbp-328],rax
       lea       rax,[M00_L39]
       mov       [rbp-318],rax
       lea       rax,[rbp-338]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D5290
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M00_L40
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rcx,[rbp-330]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       xor       ecx,ecx
       mov       [rbp-2E0],rcx
       mov       ecx,eax
       call      00007FFA508C6B40
       test      ebx,ebx
       je        near ptr M00_L50
       mov       rbx,[rbp-368]
       mov       dword ptr [rbx+28],0FFFFFFFF
M00_L41:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rax,[rbp-360]
       cmp       [rax],rcx
       jne       near ptr M00_L47
       mov       rcx,rax
       call      qword ptr [7FF9F12C9C70]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       je        near ptr M00_L53
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rax,[rbp-360]
       cmp       [rax],rcx
       jne       near ptr M00_L48
       mov       rbx,[rax+28]
M00_L43:
       cmp       qword ptr [rbp-298],0
       je        short M00_L44
       mov       rdi,[rbp-298]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M00_L49
M00_L44:
       mov       [rbp-368],rbx
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M00_L36
       mov       ecx,[r14+8]
       cmp       ecx,104
       jge       short M00_L45
       test      ecx,ecx
       je        near ptr M00_L36
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       near ptr M00_L52
       mov       ecx,edx
       movzx     r15d,word ptr [r14+rcx*2+0C]
       cmp       r15d,20
       jne       near ptr M00_L35
M00_L45:
       mov       rcx,r14
       call      qword ptr [7FF9F1265F68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-398],r14
       mov       rcx,rax
       mov       rax,[rbp-360]
       jmp       near ptr M00_L37
M00_L46:
       xor       r13d,r13d
       jmp       near ptr M00_L38
M00_L47:
       mov       rcx,rax
       mov       r11,7FF9F0B90918
       call      qword ptr [r11]
       jmp       near ptr M00_L42
M00_L48:
       mov       rcx,rax
       mov       r11,7FF9F0B90920
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-360]
       jmp       near ptr M00_L43
M00_L49:
       lea       rcx,[rbp-298]
       call      qword ptr [7FF9F1306928]
       int       3
M00_L50:
       call      00007FFA508C6B20
       cmp       eax,57
       jne       short M00_L51
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F1306940]
       mov       rsi,rax
       mov       ecx,1C44A
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       ecx,eax
       mov       rdx,[rbp-398]
       xor       r8d,r8d
       call      qword ptr [7FF9F1305458]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      M00_L75
       nop
M00_L54:
       mov       r8,4D7BDBEBDC8C
       cmp       [rbp-40],r8
       je        short M00_L55
       call      CORINFO_HELP_FAIL_FAST
M00_L55:
       nop
       add       rsp,388
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L56:
       mov       rcx,r14
       call      qword ptr [7FF9F1265F68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M00_L20
M00_L57:
       xor       r15d,r15d
       jmp       near ptr M00_L21
M00_L58:
       mov       ecx,1
       jmp       near ptr M00_L01
M00_L59:
       call      qword ptr [7FF9F11CECE8]
       mov       ecx,2047
       mov       rdx,7FF9F0F15AB8
       call      qword ptr [7FF9F0C4F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9F0F15AB8
       call      qword ptr [7FF9F0C4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF9F0F15AB8
       call      qword ptr [7FF9F0C4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F1306D00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F1306D18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L60:
       call      qword ptr [7FF9F126DF98]
       mov       rcx,rax
       mov       r8,[rbx+8]
       mov       rdx,22500970B38
       call      qword ptr [7FF9F0E15488]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,22500967DF8
       mov       rdx,22500960390
       call      qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22500960008
       call      qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L61
       call      qword ptr [7FF9F1306D30]
       mov       rsi,rax
M00_L61:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FF9F1306D48]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L62:
       lea       rcx,[rdi+0C]
       mov       r12d,[rdi+8]
       mov       [rbp-350],rcx
       mov       [rbp-348],r12d
       lea       rcx,[rbp-350]
       call      qword ptr [7FF9F1265F20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M00_L02
       mov       r8d,r13d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F0ED7450]; System.String.Substring(Int32, Int32)
       mov       [rbp-388],rax
       jmp       near ptr M00_L03
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L64:
       lea       ecx,[r15-2]
       cmp       ecx,1
       jbe       short M00_L65
       cmp       r15d,15
       jne       near ptr M00_L17
M00_L65:
       mov       r14,[rbp-378]
       mov       dword ptr [r14],0FFFFFFFF
       xor       r15d,r15d
       jmp       near ptr M00_L17
M00_L66:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FF9F1305458]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      00007FFA508C6B20
       cmp       eax,57
       jne       short M00_L68
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F1306940]
       mov       rsi,rax
       mov       ecx,1C44A
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-390]
       xor       r8d,r8d
       call      qword ptr [7FF9F1305458]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L69:
       mov       ecx,1C2C6
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       rcx,rax
       call      qword ptr [7FF9F1304D98]
       int       3
M00_L70:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F1306CB8]
       mov       rax,rdi
       jmp       near ptr M00_L24
M00_L71:
       mov       rcx,rbx
       mov       r11,7FF9F0B90910
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L73:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-2E4],0
       je        short M00_L74
       mov       rcx,[rbp-3A0]
       call      qword ptr [7FF9F0C46820]; System.Threading.Monitor.Exit(System.Object)
M00_L74:
       nop
       add       rsp,28
       ret
M00_L75:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-360],0
       je        near ptr M00_L83
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       mov       rax,[rbp-360]
       cmp       [rax],rcx
       jne       near ptr M00_L84
       mov       [rbp-370],rax
       mov       rax,[rbp-370]
       cmp       qword ptr [rax+20],0
       je        near ptr M00_L82
       mov       rcx,[rax+20]
       mov       [rbp-3A0],rcx
       xor       ecx,ecx
       mov       [rbp-2E4],ecx
       mov       rcx,[rbp-3A0]
       call      00007FFA508D2B50
       test      eax,eax
       jne       short M00_L76
       mov       rcx,[rbp-3A0]
       call      qword ptr [7FF9F1305338]
M00_L76:
       mov       dword ptr [rbp-2E4],1
       mov       rax,[rbp-370]
       mov       byte ptr [rax+60],1
       lea       rcx,[rax+50]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        short M00_L77
       mov       rcx,rdx
       call      qword ptr [7FF9F12662C8]; Interop+Kernel32.CloseHandle(IntPtr)
M00_L77:
       mov       rax,[rbp-370]
       cmp       qword ptr [rax+38],0
       je        short M00_L80
       mov       rcx,[rax+38]
       cmp       dword ptr [rcx+18],0
       jle       short M00_L79
M00_L78:
       mov       rcx,[rax+38]
       lea       rdx,[rbp-300]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F1306A48]
       mov       rcx,[rbp-2F8]
       call      qword ptr [7FF9F12662C8]; Interop+Kernel32.CloseHandle(IntPtr)
       mov       rax,[rbp-370]
       mov       rcx,[rax+38]
       cmp       dword ptr [rcx+18],0
       jg        short M00_L78
M00_L79:
       xor       ecx,ecx
       mov       [rax+38],rcx
M00_L80:
       cmp       qword ptr [rax+48],0
       je        short M00_L81
       mov       rcx,[rax+48]
       test      rcx,0FFFFFFFFFFFF0000
       je        short M00_L81
       call      00007FF9F0C32A18
M00_L81:
       mov       rax,[rbp-370]
       xor       ecx,ecx
       mov       [rax+48],rcx
       call      M00_L73
       nop
M00_L82:
       mov       rax,[rbp-370]
       mov       rcx,[rax]
       test      dword ptr [rcx],100000
       je        short M00_L83
       mov       rcx,rax
       call      00007FFA50880DD0
M00_L83:
       nop
       add       rsp,28
       ret
M00_L84:
       mov       rcx,rax
       mov       r11,7FF9F0B90928
       call      qword ptr [r11]
       jmp       short M00_L83
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-380],0
       je        short M00_L85
       mov       rcx,[rbp-380]
       mov       edx,1
       call      qword ptr [7FF9F0C4DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-380]
       call      qword ptr [7FF9F0E15590]; System.GC.SuppressFinalize(System.Object)
M00_L85:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-33C],0
       je        short M00_L86
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9F0C38C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-340]
       call      00007FF9F0C38C18
       call      00007FF9F0C38C30
       mov       ecx,eax
       call      00007FFA508C6B40
M00_L86:
       nop
       add       rsp,28
       ret
; Total bytes of code 3571
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
       mov       rax,4D7BDBEBDC8C
       mov       [rbp-28],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L19
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M01_L19
       lea       rdi,[rbx+0C]
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
M01_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M01_L20
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF9F0EDF048]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       esi,4
       jl        short M01_L01
       cmp       word ptr [rdi],5C
       je        near ptr M01_L22
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FF9F0EDF090]; System.IO.PathHelper.Normalize(System.String)
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
       jae       near ptr M01_L25
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L18
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L03:
       test      ecx,ecx
       jne       near ptr M01_L24
M01_L04:
       xor       ecx,ecx
       mov       [rbp-2B0],rcx
       mov       [rbp-2AC],ecx
       call      00007FF9F0C38C00
       lea       rdx,[rbp-2AC]
       mov       ecx,1
       call      00007FF9F0C38C18
       mov       edi,eax
       call      00007FF9F0C38C30
       mov       ecx,eax
       call      00007FFA508C6B40
       test      edi,edi
       setne     cl
       movzx     ecx,cl
       mov       [rbp-2B0],cl
       movzx     ecx,byte ptr [rbp-2B0]
       mov       [rbp-2C4],cl
       mov       ecx,[rbp-2AC]
       mov       [rbp-2C8],ecx
       test      rbx,rbx
       je        short M01_L05
       mov       ecx,[rbx+8]
       cmp       ecx,104
       jge       short M01_L08
       test      ecx,ecx
       je        short M01_L05
       dec       ecx
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,20
       je        short M01_L08
       cmp       ecx,2E
       je        short M01_L08
M01_L05:
       mov       rax,rbx
M01_L06:
       test      rax,rax
       je        short M01_L09
       add       rax,0C
       mov       rdi,rax
M01_L07:
       mov       [rbp-2B8],rdi
       xor       ecx,ecx
       call      00007FF9F0C38C00
       lea       r8,[rbp-2A0]
       mov       rcx,rdi
       xor       edx,edx
       call      00007FF9F0C38C60
       mov       edi,eax
       call      00007FF9F0C38C30
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       call      00007FFA508C6B40
       test      edi,edi
       jne       near ptr M01_L13
       jmp       short M01_L10
M01_L08:
       mov       rcx,rbx
       call      qword ptr [7FF9F1265F68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       short M01_L06
M01_L09:
       xor       edi,edi
       jmp       short M01_L07
M01_L10:
       call      00007FFA508C6B20
       mov       esi,eax
       mov       ecx,esi
       call      qword ptr [7FF9F1265EF0]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L13
       lea       rcx,[rbp-278]
       mov       edx,250
       call      qword ptr [7FF9F0C457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-278]
       mov       rcx,rbx
       call      qword ptr [7FF9F1306118]
       mov       [rbp-2E0],rax
       mov       rcx,[rbp-2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F0DB7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L11
       call      00007FFA508C6B20
       mov       esi,eax
       jmp       short M01_L12
M01_L11:
       xor       esi,esi
       lea       rcx,[rbp-2A0]
       lea       rdx,[rbp-278]
       call      qword ptr [7FF9F1306130]
       nop
M01_L12:
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FF9F0C4DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FF9F0E15590]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L13:
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L14
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9F0C38C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FF9F0C38C18
       call      00007FF9F0C38C30
       mov       ecx,eax
       call      00007FFA508C6B40
M01_L14:
       test      esi,esi
       je        short M01_L17
M01_L15:
       xor       eax,eax
M01_L16:
       jmp       near ptr M01_L26
M01_L17:
       cmp       dword ptr [rbp-2A0],0FFFFFFFF
       je        short M01_L15
       test      byte ptr [rbp-2A0],10
       setne     al
       movzx     eax,al
       jmp       short M01_L16
M01_L18:
       mov       ecx,1
       jmp       near ptr M01_L03
M01_L19:
       xor       eax,eax
       jmp       near ptr M01_L26
M01_L20:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M01_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F1305620]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F1305638]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       cmp       word ptr [rdi+2],5C
       je        short M01_L23
       cmp       word ptr [rdi+2],3F
       jne       near ptr M01_L01
M01_L23:
       cmp       word ptr [rdi+4],3F
       jne       near ptr M01_L01
       cmp       word ptr [rdi+6],5C
       jne       near ptr M01_L01
       jmp       near ptr M01_L02
M01_L24:
       lea       rcx,[rbx+0C]
       mov       r14d,[rbx+8]
       mov       [rbp-2D8],rcx
       mov       [rbp-2D0],r14d
       lea       rcx,[rbp-2D8]
       call      qword ptr [7FF9F1265F20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r14d
       je        near ptr M01_L04
       mov       r8d,edi
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F0ED7450]; System.String.Substring(Int32, Int32)
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L26:
       mov       r8,4D7BDBEBDC8C
       cmp       [rbp-28],r8
       je        short M01_L27
       call      CORINFO_HELP_FAIL_FAST
M01_L27:
       nop
       add       rsp,2E0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L28:
       xor       eax,eax
       mov       r8,4D7BDBEBDC8C
       cmp       [rbp-28],r8
       je        short M01_L29
       call      CORINFO_HELP_FAIL_FAST
M01_L29:
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
       je        short M01_L30
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FF9F0C4DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FF9F0E15590]; System.GC.SuppressFinalize(System.Object)
M01_L30:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L31
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FF9F0C38C00
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FF9F0C38C18
       call      00007FF9F0C38C30
       mov       ecx,eax
       call      00007FFA508C6B40
M01_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
; Total bytes of code 1228
```
```assembly
; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L00
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M02_L01
M02_L00:
       xor       ecx,ecx
       xor       eax,eax
M02_L01:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFA4CA42B78]; Precode of System.IO.PathInternal.IsPartiallyQualified(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L05
       test      rbx,rbx
       je        short M02_L02
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M02_L03
M02_L02:
       xor       ecx,ecx
       xor       eax,eax
M02_L03:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFA4CA42B58]; Precode of System.IO.PathInternal.IsDevice(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L05
       cmp       dword ptr [rbx+8],2
       jl        short M02_L04
       cmp       dword ptr [rbx+0C],5C005C
       je        short M02_L06
M02_L04:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFA4CA36B50]; Precode of System.String.Concat(System.String, System.String)
       nop
       add       rsp,30
       pop       rbx
       ret
M02_L05:
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       ret
M02_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FFA4CA36C18]
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 180
```
```assembly
; System.IO.FileSystem.IsPathUnreachableError(Int32)
       cmp       ecx,41
       jg        short M03_L04
       cmp       ecx,6
       jg        short M03_L03
       lea       eax,[rcx-2]
       cmp       eax,1
       ja        short M03_L02
M03_L00:
       mov       eax,1
M03_L01:
       ret
M03_L02:
       cmp       ecx,6
       je        short M03_L00
       jmp       short M03_L05
M03_L03:
       cmp       ecx,15
       je        short M03_L00
       cmp       ecx,35
       je        short M03_L00
       add       ecx,0FFFFFFC0
       cmp       ecx,1
       jbe       short M03_L00
       jmp       short M03_L05
M03_L04:
       cmp       ecx,7B
       jg        short M03_L06
       cmp       ecx,43
       je        short M03_L00
       cmp       ecx,57
       je        short M03_L00
       cmp       ecx,7B
       je        short M03_L00
M03_L05:
       xor       eax,eax
       jmp       short M03_L01
M03_L06:
       cmp       ecx,0A1
       je        short M03_L00
       cmp       ecx,0CE
       je        short M03_L00
       cmp       ecx,4CF
       jne       short M03_L05
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       rcx,7FF9F13EDB1C
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
       mov       rcx,7FF9F13EDB28
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
       mov       rcx,7FF9F13EDB24
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
       mov       rcx,7FF9F13EDB04
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF9F13EDB00
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
       mov       rcx,7FF9F13EDB20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L05
M04_L08:
       mov       rcx,7FF9F13EDB2C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F130CFF0]
M04_L09:
       mov       rcx,7FF9F13EDAFC
       call      CORINFO_HELP_COUNTPROFILE32
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx+20],xmm0
       jmp       short M04_L04
M04_L10:
       test      sil,18
       je        short M04_L11
       mov       rcx,7FF9F13EDB08
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       [rdi-8],rcx
       jmp       short M04_L06
M04_L11:
       test      sil,4
       je        short M04_L13
       mov       rcx,7FF9F13EDB0C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],ecx
       mov       [rdi-4],ecx
       jmp       near ptr M04_L06
M04_L12:
       mov       rcx,7FF9F13EDAF8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L06
M04_L13:
       mov       byte ptr [rbx],0
       test      sil,2
       jne       short M04_L14
       mov       rcx,7FF9F13EDB14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L06
M04_L14:
       mov       rcx,7FF9F13EDB18
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
       call      qword ptr [7FF9F0DB7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
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
       call      00007FFA508C6B20
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFindHandle
       cmp       [rbx],rcx
       jne       short M05_L16
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9F1457750]; Interop+Kernel32.FindClose(IntPtr)
M05_L13:
       mov       ecx,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr 00007FFA508C6B40
M05_L14:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M05_L09
M05_L15:
       mov       rcx,rbx
       call      qword ptr [7FF9F13051D0]
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
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M06_L01
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M06_L00
       mov       rcx,7FF9F12FED34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9F12FED30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       near ptr 00007FFA50880DD0
M06_L00:
       mov       rcx,7FF9F12FED30
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       mov       ecx,707
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       rcx,rax
       call      qword ptr [7FF9F1304D98]
       int       3
; Total bytes of code 120
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.NormalizeInputs(System.String ByRef, System.String ByRef, System.IO.MatchType)
       push      r15
       push      r14
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
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rbx]
       mov       rcx,rbp
       test      rcx,rcx
       je        short M07_L03
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M07_L00
       movzx     edx,word ptr [rax]
       cmp       edx,5C
       je        near ptr M07_L08
       cmp       edx,2F
       je        near ptr M07_L08
M07_L00:
       cmp       ecx,2
       jl        short M07_L01
       movzx     ecx,word ptr [rax]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       jbe       near ptr M07_L07
M07_L01:
       xor       ecx,ecx
M07_L02:
       test      ecx,ecx
       jne       near ptr M07_L14
M07_L03:
       lea       rcx,[rbp+0C]
       mov       r8d,[rbp+8]
       xor       edx,edx
       call      qword ptr [7FF9F0EDF048]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M07_L15
       mov       rcx,[rsi]
       lea       r8,[rcx+0C]
       mov       edx,[rcx+8]
       mov       rcx,r8
       mov       r8d,edx
       xor       edx,edx
       call      qword ptr [7FF9F0EDF048]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M07_L16
       mov       rcx,[rbx]
       test      rcx,rcx
       jne       short M07_L09
       xor       ebp,ebp
       xor       r14d,r14d
M07_L04:
       test      r14d,r14d
       je        short M07_L06
       xor       ecx,ecx
M07_L05:
       cmp       word ptr [rbp+rcx*2],20
       je        near ptr M07_L17
       mov       [rsp+38],rbp
       mov       [rsp+40],r14d
       lea       rcx,[rsp+38]
       call      qword ptr [7FF9F126E0D0]; System.IO.Path.GetDirectoryNameOffset(System.ReadOnlySpan`1<Char>)
       mov       r15d,eax
       test      r15d,r15d
       jge       short M07_L10
M07_L06:
       xor       ebp,ebp
       xor       r15d,r15d
       jmp       short M07_L11
M07_L07:
       cmp       word ptr [rax+2],3A
       sete      cl
       movzx     ecx,cl
       jmp       near ptr M07_L02
M07_L08:
       mov       ecx,1
       jmp       near ptr M07_L02
M07_L09:
       lea       rbp,[rcx+0C]
       mov       r14d,[rcx+8]
       jmp       short M07_L04
M07_L10:
       cmp       r15d,r14d
       ja        near ptr M07_L18
M07_L11:
       mov       r14d,1
       test      r15d,r15d
       jne       near ptr M07_L19
M07_L12:
       test      edi,edi
       jne       near ptr M07_L22
M07_L13:
       mov       eax,r14d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L14:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F1306AC0]
       mov       rsi,rax
       mov       ecx,1C6A4
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M07_L15:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F1305638]
       mov       rdx,rax
       mov       r8,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F1305638]
       mov       rdx,rax
       mov       r8,[rsi]
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC61F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L17:
       inc       ecx
       cmp       ecx,r14d
       jl        near ptr M07_L05
       jmp       near ptr M07_L06
M07_L18:
       call      qword ptr [7FF9F0E1F228]
       int       3
M07_L19:
       mov       rcx,[rsi]
       test      rcx,rcx
       jne       short M07_L20
       xor       edx,edx
       xor       eax,eax
       jmp       short M07_L21
M07_L20:
       lea       rdx,[rcx+0C]
       mov       eax,[rcx+8]
M07_L21:
       mov       [rsp+38],rdx
       mov       [rsp+40],eax
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9F126E550]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       lea       edx,[r15+1]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F0FC4318]; System.String.Substring(Int32)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       r14d,r14d
       jmp       near ptr M07_L12
M07_L22:
       cmp       edi,1
       jne       near ptr M07_L25
       mov       rcx,[rbx]
       mov       rdx,22500961310
       call      qword ptr [7FF9F0C46E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M07_L13
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M07_L23
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L24
M07_L23:
       mov       rax,22500961310
       mov       [rbx],rax
       jmp       near ptr M07_L13
M07_L24:
       mov       rcx,[rbx]
       mov       rdx,22500960C80
       call      qword ptr [7FF9F0C46E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M07_L23
       mov       rcx,[rbx]
       mov       rdx,22500970B18
       call      qword ptr [7FF9F0C46E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M07_L23
       mov       rcx,[rbx]
       call      qword ptr [7FF9F1306AD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M07_L13
M07_L25:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C6DE
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F13062B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 826
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.FileSystemInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rcx,1E46B8021E8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M08_L11
M08_L00:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[r14+10]
       test      rbx,rbx
       je        near ptr M08_L13
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       test      rdx,rdx
       jne       short M08_L02
       test      byte ptr [7FF9F12C6FF8],1
       je        near ptr M08_L12
M08_L01:
       mov       rcx,1E46B802258
       mov       rdx,[rcx]
M08_L02:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rsi,[rdi+20]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      bpl,bpl
       je        short M08_L03
       jmp       short M08_L04
M08_L03:
       mov       rcx,rsi
       call      qword ptr [7FF9F0EDF000]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
M08_L04:
       test      rsi,rsi
       je        short M08_L06
       cmp       dword ptr [rsi+8],0
       je        short M08_L06
       mov       ebp,[rsi+8]
       dec       ebp
       cmp       ebp,[rsi+8]
       jae       near ptr M08_L16
       mov       ecx,ebp
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M08_L10
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M08_L05:
       test      ecx,ecx
       jne       near ptr M08_L14
M08_L06:
       mov       rdx,rsi
M08_L07:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       test      rdx,rdx
       jne       short M08_L09
       test      byte ptr [7FF9F12C6FF8],1
       je        near ptr M08_L15
M08_L08:
       mov       rcx,1E46B802258
       mov       rdx,[rcx]
M08_L09:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
       mov       rcx,rbx
       call      qword ptr [7FF9F126E448]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       lea       rcx,[rbx+68]
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
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L10:
       mov       ecx,1
       jmp       near ptr M08_L05
M08_L11:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E46B8021B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileSystemInfos>b__7_0(System.IO.Enumeration.FileSystemEntry ByRef)
       call      qword ptr [7FF9F0C46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E46B8021E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L00
M08_L12:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      qword ptr [7FF9F0C45728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L01
M08_L13:
       mov       ecx,1C67C
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       rcx,rax
       call      qword ptr [7FF9F1304D98]
       int       3
M08_L14:
       lea       rcx,[rsi+0C]
       mov       r13d,[rsi+8]
       mov       [rsp+20],rcx
       mov       [rsp+28],r13d
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9F1265F20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M08_L06
       mov       r8d,ebp
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9F0ED7450]; System.String.Substring(Int32, Int32)
       mov       rdx,rax
       jmp       near ptr M08_L07
M08_L15:
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      qword ptr [7FF9F0C45728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L08
M08_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M09_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M09_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0C0],rcx
       mov       rcx,rbp
       mov       [rbp-0B0],rcx
       cmp       byte ptr [rbx+60],0
       jne       near ptr M09_L66
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-70],ymm1
       vmovdqu   ymmword ptr [rbp-58],ymm1
       mov       rax,[rbx+20]
       mov       [rbp-128],rax
       xor       ecx,ecx
       mov       [rbp-74],ecx
       test      rax,rax
       je        near ptr M09_L42
       mov       rcx,rax
       call      00007FFA508D2B50
       test      eax,eax
       jne       short M09_L01
       mov       rcx,[rbp-128]
       call      qword ptr [7FF9F1305338]
M09_L01:
       mov       dword ptr [rbp-74],1
       cmp       byte ptr [rbx+60],0
       jne       near ptr M09_L43
M09_L02:
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        near ptr M09_L11
       mov       edx,[rcx]
       test      edx,edx
       je        near ptr M09_L11
       mov       edx,edx
       add       rcx,rdx
M09_L03:
       mov       [rbx+40],rcx
       cmp       qword ptr [rbx+40],0
       jne       near ptr M09_L06
       lea       rcx,[rbp-90]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+48]
       mov       [rsp+28],rcx
       mov       ecx,[rbx+5C]
       mov       [rsp+30],ecx
       mov       dword ptr [rsp+38],2
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],ecx
       mov       [rbp+10],rbx
       mov       rcx,[rbx+50]
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       mov       rax,7FF9F0DDAC90
       mov       [rbp-0C8],rax
       lea       rax,[M09_L04]
       mov       [rbp-0B8],rax
       lea       rax,[rbp-0D8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA9446DCE0
       call      rax
M09_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M09_L05
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M09_L05:
       mov       rcx,[rbp-0D0]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M09_L12
       mov       rbx,[rbp+10]
       mov       rax,[rbx+48]
       mov       [rbx+40],rax
M09_L06:
       cmp       byte ptr [rbx+60],0
       jne       near ptr M09_L43
       mov       rdx,[rbx+40]
       mov       rcx,rdx
       mov       rax,[rbx+30]
       test      rax,rax
       jne       near ptr M09_L19
       xor       r8d,r8d
       xor       r10d,r10d
M09_L07:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M09_L20
       xor       r9d,r9d
       xor       r11d,r11d
M09_L08:
       mov       rax,[rbx+8]
       test      rax,rax
       jne       near ptr M09_L21
       xor       edi,edi
       xor       r14d,r14d
M09_L09:
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
       jne       near ptr M09_L52
M09_L10:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M09_L59
       mov       rcx,[rbx+68]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        near ptr M09_L26
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0.<FileSystemInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rdi+18],rcx
       jne       near ptr M09_L58
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
       je        near ptr M09_L22
       cmp       dword ptr [rcx+18],2
       sete      r8b
       movzx     r8d,r8b
       jmp       near ptr M09_L23
M09_L11:
       xor       ecx,ecx
       jmp       near ptr M09_L03
M09_L12:
       cmp       eax,80000006
       jne       near ptr M09_L44
       xor       ecx,ecx
       mov       rbx,[rbp+10]
       mov       [rbx+40],rcx
       mov       [rbp+10],rbx
       lea       rcx,[rbx+50]
       xor       eax,eax
       mov       rdi,rax
       xchg      rdi,[rcx]
       test      rdi,rdi
       je        near ptr M09_L15
       xor       ecx,ecx
       mov       rax,7FFA942C5FF0
       call      rax
       mov       rcx,rdi
       mov       rax,7FF9F0DBF918
       mov       [rbp-0C8],rax
       lea       rax,[M09_L13]
       mov       [rbp-0B8],rax
       lea       rax,[rbp-0D8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D4C20
       call      rax
M09_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M09_L14
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M09_L14:
       mov       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       rax,7FFA942C5F30
       call      rax
       mov       ecx,eax
       call      00007FFA508C6B40
M09_L15:
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+30]
       test      rdx,rdx
       jne       short M09_L17
       xor       ecx,ecx
       xor       eax,eax
M09_L16:
       mov       [rbp-0E8],rcx
       mov       [rbp-0E0],eax
       lea       rdx,[rbp-0E8]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rbx
       call      qword ptr [7FF9F126E628]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].DequeueNextDirectory()
       test      eax,eax
       jne       short M09_L18
       mov       [rbp+10],rbx
       mov       byte ptr [rbx+60],1
       mov       rbx,[rbp+10]
       jmp       near ptr M09_L06
M09_L17:
       lea       rcx,[rdx+0C]
       mov       eax,[rdx+8]
       jmp       short M09_L16
M09_L18:
       mov       rcx,rbx
       call      qword ptr [7FF9F126E4F0]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].FindNextEntry()
       jmp       near ptr M09_L06
M09_L19:
       lea       r8,[rax+0C]
       mov       r10d,[rax+8]
       jmp       near ptr M09_L07
M09_L20:
       lea       r9,[rax+0C]
       mov       r11d,[rax+8]
       jmp       near ptr M09_L08
M09_L21:
       lea       rdi,[rax+0C]
       mov       r14d,[rax+8]
       jmp       near ptr M09_L09
M09_L22:
       mov       r8d,1
M09_L23:
       mov       r15d,[rcx+14]
       test      r15d,r15d
       jne       near ptr M09_L29
       test      rdi,rdi
       jne       near ptr M09_L28
       xor       ecx,ecx
       xor       edx,edx
M09_L24:
       mov       [rbp-0E8],rcx
       mov       [rbp-0E0],edx
       mov       [rbp-0F8],r14
       mov       [rbp-0F0],eax
       lea       rcx,[rbp-0E8]
       lea       rdx,[rbp-0F8]
       xor       r9d,r9d
       call      qword ptr [7FF9F126E520]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
M09_L25:
       test      eax,eax
       je        near ptr M09_L02
M09_L26:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileSystemInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       near ptr M09_L63
       mov       rcx,[rbx+68]
       mov       rsi,[rcx+10]
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileSystemInfos>b__7_0(System.IO.Enumeration.FileSystemEntry ByRef)
       cmp       [rsi+18],rcx
       jne       near ptr M09_L62
       mov       rcx,[rbp-68]
       mov       edx,[rbp-60]
       mov       r8,[rbp-70]
       lea       rsi,[r8+44]
       mov       eax,[r8+3C]
       mov       r10d,eax
       shr       r10d,1F
       add       eax,r10d
       sar       eax,1
       mov       [rbp-0A0],rcx
       mov       [rbp-98],edx
       cmp       dword ptr [rbp-98],0
       jne       near ptr M09_L33
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],eax
       lea       rcx,[rbp-0E8]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M09_L27:
       mov       rcx,[rbp-70]
       test      byte ptr [rcx+38],10
       jne       near ptr M09_L39
       mov       rcx,[rbp-70]
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rbp-0E8],rax
       mov       [rbp-0E0],ecx
       lea       rcx,[rbp-0E8]
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
       jmp       near ptr M09_L40
M09_L28:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
       jmp       near ptr M09_L24
M09_L29:
       cmp       r15d,1
       jne       short M09_L32
       test      rdi,rdi
       jne       short M09_L31
       xor       ecx,ecx
       xor       edx,edx
M09_L30:
       mov       [rbp-0E8],rcx
       mov       [rbp-0E0],edx
       mov       [rbp-0F8],r14
       mov       [rbp-0F0],eax
       lea       rcx,[rbp-0E8]
       lea       rdx,[rbp-0F8]
       mov       r9d,1
       call      qword ptr [7FF9F126E520]; System.IO.Enumeration.FileSystemName.MatchPattern(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Boolean, Boolean)
       jmp       near ptr M09_L25
M09_L31:
       lea       rcx,[rdi+0C]
       mov       edx,[rdi+8]
       jmp       short M09_L30
M09_L32:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F0B84000
       call      qword ptr [7FF9F0C4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F13062B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L33:
       test      eax,eax
       je        near ptr M09_L38
       mov       rdi,[rbp-0A0]
       mov       r14d,[rbp-98]
       lea       ecx,[r14-1]
       cmp       ecx,r14d
       jae       near ptr M09_L61
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M09_L37
       cmp       ecx,2F
       je        short M09_L37
       movzx     ecx,word ptr [rsi]
       cmp       ecx,5C
       je        short M09_L36
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M09_L34:
       test      ecx,ecx
       jne       short M09_L37
       mov       rcx,225009681EC
       mov       [rbp-0E8],rdi
       mov       [rbp-0E0],r14d
       mov       [rbp-0F8],rcx
       mov       dword ptr [rbp-0F0],1
       mov       [rbp-120],rsi
       mov       [rbp-118],eax
       lea       rcx,[rbp-0E8]
       lea       rdx,[rbp-0F8]
       lea       r8,[rbp-120]
       call      qword ptr [7FF9F1266028]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M09_L35:
       jmp       near ptr M09_L27
M09_L36:
       mov       ecx,1
       jmp       short M09_L34
M09_L37:
       mov       [rbp-0E8],rdi
       mov       [rbp-0E0],r14d
       mov       [rbp-0F8],rsi
       mov       [rbp-0F0],eax
       lea       rcx,[rbp-0E8]
       lea       rdx,[rbp-0F8]
       call      qword ptr [7FF9F0FCD980]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       jmp       short M09_L35
M09_L38:
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF9F0E1F768]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       jmp       near ptr M09_L27
M09_L39:
       mov       rcx,[rbp-70]
       lea       rax,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       edx,ecx
       shr       edx,1F
       add       ecx,edx
       sar       ecx,1
       mov       [rbp-0E8],rax
       mov       [rbp-0E0],ecx
       lea       rcx,[rbp-0E8]
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
M09_L40:
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
M09_L41:
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,1
       jmp       near ptr M09_L64
M09_L42:
       xor       ecx,ecx
       call      qword ptr [7FF9F1304D98]
       int       3
M09_L43:
       xor       ebx,ebx
       jmp       near ptr M09_L64
M09_L44:
       cmp       eax,0C000000F
       je        short M09_L47
       mov       ecx,eax
       mov       rax,7FF9F0DDAC50
       mov       [rbp-0C8],rax
       lea       rax,[M09_L45]
       mov       [rbp-0B8],rax
       lea       rax,[rbp-0D8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9F0DDAC70]
M09_L45:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M09_L46
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M09_L46:
       mov       rcx,[rbp-0D0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       cmp       ebx,5
       je        short M09_L49
       mov       rdi,[rbp+10]
       jmp       short M09_L50
M09_L47:
       mov       rbx,[rbp+10]
M09_L48:
       mov       rcx,rbx
       call      qword ptr [7FF9F126E5F8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].DirectoryFinished()
       jmp       near ptr M09_L06
M09_L49:
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+18]
       cmp       byte ptr [rcx+1D],0
       jne       short M09_L51
M09_L50:
       mov       rcx,rdi
       mov       edx,ebx
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M09_L60
       mov       rbx,rdi
       jmp       short M09_L48
M09_L51:
       mov       rbx,rdi
       jmp       short M09_L48
M09_L52:
       mov       rcx,rdx
       mov       ecx,[rcx+3C]
       mov       eax,ecx
       shr       eax,1F
       add       ecx,eax
       sar       ecx,1
       mov       eax,ecx
       cmp       eax,2
       jg        short M09_L54
       add       rdx,44
       mov       rax,rdx
       mov       r8d,ecx
       test      r8d,r8d
       je        near ptr M09_L61
       cmp       word ptr [rax],2E
       jne       short M09_L54
       mov       eax,ecx
       cmp       eax,2
       jne       short M09_L53
       cmp       ecx,1
       jbe       near ptr M09_L61
       cmp       word ptr [rdx+2],2E
       jne       short M09_L54
M09_L53:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1E],0
       jne       near ptr M09_L10
       jmp       near ptr M09_L02
M09_L54:
       mov       rdx,[rbx+18]
       cmp       byte ptr [rdx+1C],0
       je        near ptr M09_L10
       cmp       dword ptr [rbx+58],0
       jle       near ptr M09_L10
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       je        near ptr M09_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       jne       short M09_L55
       xor       edx,edx
       xor       eax,eax
       jmp       short M09_L56
M09_L55:
       lea       rdx,[rcx+0C]
       mov       eax,[rcx+8]
M09_L56:
       mov       rcx,[rbx+40]
       lea       r8,[rcx+44]
       mov       ecx,[rcx+3C]
       mov       r10d,ecx
       shr       r10d,1F
       add       ecx,r10d
       sar       ecx,1
       mov       [rbp-0E8],rdx
       mov       [rbp-0E0],eax
       mov       [rbp-0F8],r8
       mov       [rbp-0F0],ecx
       lea       rcx,[rbp-0E8]
       lea       rdx,[rbp-0F8]
       call      qword ptr [7FF9F126E550]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+40]
       lea       rcx,[rdx+44]
       mov       edx,[rdx+3C]
       mov       r8d,edx
       shr       r8d,1F
       add       edx,r8d
       sar       edx,1
       mov       [rbp-0E8],rcx
       mov       [rbp-0E0],edx
       lea       rdx,[rbp-0E8]
       mov       rcx,rbx
       mov       r8,rdi
       call      qword ptr [7FF9F1306238]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        near ptr M09_L10
       cmp       qword ptr [rbx+38],0
       jne       short M09_L57
       mov       rcx,offset MT_System.Collections.Generic.Queue<System.ValueTuple<System.IntPtr, System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF9F1306250]
       lea       rcx,[rbx+38]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L57:
       mov       rcx,[rbx+38]
       mov       edx,[rbx+58]
       dec       edx
       mov       [rbp-110],rdi
       mov       rax,[rbp-80]
       mov       [rbp-108],rax
       mov       [rbp-100],edx
       lea       rdx,[rbp-110]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F1306268]
       jmp       near ptr M09_L10
M09_L58:
       lea       rdx,[rbp-70]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       jmp       near ptr M09_L25
M09_L59:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M09_L25
M09_L60:
       mov       [rbp+10],rdi
       mov       esi,ebx
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+30]
       mov       ecx,esi
       xor       r8d,r8d
       call      qword ptr [7FF9F1305458]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M09_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L62:
       lea       rdx,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdi,rax
       jmp       near ptr M09_L41
M09_L63:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M09_L41
M09_L64:
       mov       rcx,[rbp-128]
       call      00007FFA508D2A70
       test      eax,eax
       jne       short M09_L67
M09_L65:
       movzx     eax,bl
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L66:
       xor       ebx,ebx
       jmp       short M09_L65
M09_L67:
       mov       ecx,eax
       mov       rdx,[rbp-128]
       call      qword ptr [7FF9F1304F30]
       jmp       short M09_L65
       sub       rsp,58
       vzeroupper
       mov       rcx,[rbp-80]
       call      qword ptr [7FF9F12662C8]; Interop+Kernel32.CloseHandle(IntPtr)
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,58
       vzeroupper
       cmp       dword ptr [rbp-74],0
       je        short M09_L69
       cmp       qword ptr [rbp-128],0
       jne       short M09_L68
       xor       ecx,ecx
       call      qword ptr [7FF9F1304D98]
       int       3
M09_L68:
       mov       rcx,[rbp-128]
       call      00007FFA508D2A70
       test      eax,eax
       je        short M09_L69
       mov       ecx,eax
       mov       rdx,[rbp-128]
       call      qword ptr [7FF9F1304F30]
M09_L69:
       nop
       add       rsp,58
       ret
; Total bytes of code 2801
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
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA508C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,22500960008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9F13051B8]
       int       3
; Total bytes of code 244
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
       je        near ptr M11_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M11_L02
       test      rsi,rsi
       je        near ptr M11_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M11_L01
       test      rdi,rdi
       je        near ptr M11_L00
       cmp       dword ptr [rdi+8],0
       je        near ptr M11_L00
       mov       r15d,ebp
       mov       r13d,r14d
       add       r13,r15
       mov       r12d,[rdi+8]
       add       r13,r12
       cmp       r13,7FFFFFFF
       jg        near ptr M11_L03
       mov       rcx,7FF9F12FE9B0
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFA508C9D30
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M11_L00:
       mov       rcx,7FF9F12FE9A8
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
       jmp       qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
M11_L01:
       mov       rcx,7FF9F12FE9A4
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
       jmp       qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
M11_L02:
       mov       rcx,7FF9F12FE9A0
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
       jmp       qword ptr [7FF9F0C4D9C8]; System.String.Concat(System.String, System.String)
M11_L03:
       mov       rcx,7FF9F12FE9AC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F13051B8]
       int       3
; Total bytes of code 396
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
       jl        short M12_L00
       cmp       word ptr [rbx],5C
       je        near ptr M12_L20
M12_L00:
       cmp       edi,4
       jl        short M12_L04
M12_L01:
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M12_L02
       cmp       ecx,2F
       jne       short M12_L04
M12_L02:
       movzx     ecx,word ptr [rbx+2]
       cmp       ecx,5C
       je        short M12_L03
       cmp       ecx,2F
       jne       short M12_L04
M12_L03:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,2E
       je        short M12_L09
       cmp       ecx,3F
       je        short M12_L09
M12_L04:
       xor       r14d,r14d
M12_L05:
       test      r14d,r14d
       jne       near ptr M12_L22
       xor       r15d,r15d
M12_L06:
       movzx     eax,r15b
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       or        ecx,eax
       je        short M12_L07
       test      edi,edi
       jle       short M12_L07
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M12_L12
       cmp       ecx,2F
       je        short M12_L12
M12_L07:
       test      r14d,r14d
       jne       near ptr M12_L23
       cmp       esi,2
       jl        short M12_L08
       cmp       word ptr [rbx+2],3A
       je        near ptr M12_L29
M12_L08:
       mov       eax,ebp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L09:
       movzx     ecx,word ptr [rbx+6]
       cmp       ecx,5C
       je        short M12_L11
       cmp       ecx,2F
       sete      r14b
       movzx     r14d,r14b
M12_L10:
       jmp       short M12_L05
M12_L11:
       mov       r14d,1
       jmp       short M12_L10
M12_L12:
       test      eax,eax
       jne       short M12_L15
       cmp       edi,1
       jle       short M12_L14
       movzx     eax,word ptr [rbx+2]
       cmp       eax,5C
       je        short M12_L13
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L14
M12_L13:
       mov       eax,2
       jmp       short M12_L16
M12_L14:
       mov       ebp,1
       jmp       short M12_L08
M12_L15:
       mov       eax,8
M12_L16:
       mov       ebp,eax
       mov       eax,2
       jmp       short M12_L19
M12_L17:
       dec       eax
       test      eax,eax
       jle       short M12_L08
M12_L18:
       inc       ebp
M12_L19:
       cmp       ebp,esi
       jge       short M12_L08
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M12_L17
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M12_L18
       jmp       short M12_L17
M12_L20:
       cmp       word ptr [rbx+2],5C
       je        short M12_L21
       cmp       word ptr [rbx+2],3F
       jne       near ptr M12_L00
M12_L21:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,3F
       jne       near ptr M12_L00
       cmp       word ptr [rbx+6],5C
       jne       near ptr M12_L01
       mov       r14d,1
       jmp       near ptr M12_L05
M12_L22:
       mov       [rsp+28],rbx
       mov       [rsp+30],edi
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F1306AF0]
       mov       r15d,eax
       jmp       near ptr M12_L06
M12_L23:
       mov       ebp,4
       jmp       short M12_L25
M12_L24:
       inc       ebp
M12_L25:
       cmp       ebp,esi
       jge       near ptr M12_L08
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M12_L26
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L24
       jmp       short M12_L27
M12_L26:
       cmp       ebp,4
       jle       near ptr M12_L08
       jmp       short M12_L28
M12_L27:
       cmp       ebp,4
       jle       near ptr M12_L08
M12_L28:
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M12_L30
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M12_L08
       jmp       short M12_L30
M12_L29:
       movzx     eax,word ptr [rbx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M12_L08
       mov       ebp,2
       cmp       esi,2
       jle       near ptr M12_L08
       movzx     eax,word ptr [rbx+4]
       cmp       eax,5C
       je        short M12_L30
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M12_L08
M12_L30:
       inc       ebp
       jmp       near ptr M12_L08
; Total bytes of code 545
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
       ja        short M13_L02
       test      r8d,r8d
       je        short M13_L01
       cmp       eax,r8d
       je        short M13_L00
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FFA4CA369D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,esi
       lea       rdx,[rbx+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FFA4CA388E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M13_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M13_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M13_L02:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFA4CA36D18]
       int       3
; Total bytes of code 136
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M14_L00
       mov       rcx,rbx
       call      00007FFA508D2A70
       test      eax,eax
       jne       short M14_L01
       add       rsp,20
       pop       rbx
       ret
M14_L00:
       xor       ecx,ecx
       call      qword ptr [7FF9F1304D98]
       int       3
M14_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F1304F30]
; Total bytes of code 56
```
```assembly
; Interop+Kernel32.CloseHandle(IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       rbx,rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       rax,7FFA942C5FF0
       call      rax
       mov       rcx,rbx
       mov       rax,7FF9F0DBF918
       mov       [rbp-60],rax
       lea       rax,[M15_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA942D4C20
       call      rax
M15_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA50B839A0],0
       je        short M15_L01
       call      qword ptr [7FFA50B71648]; CORINFO_HELP_STOP_FOR_GC
M15_L01:
       mov       rcx,[rbp-68]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA942C5F30
       call      rax
       mov       ecx,eax
       call      00007FFA508C6B40
       test      ebx,ebx
       setne     al
       movzx     eax,al
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
; Total bytes of code 195
```

