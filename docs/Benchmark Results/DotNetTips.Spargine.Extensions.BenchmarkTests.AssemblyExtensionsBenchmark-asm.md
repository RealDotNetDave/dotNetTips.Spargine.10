## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       call      qword ptr [7FFF7890D7A0]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rdi+30],0FFFFFFFE
       jne       near ptr M00_L59
       mov       esi,[rdi+34]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       esi,eax
       jne       near ptr M00_L59
       xor       ecx,ecx
       mov       [rdi+30],ecx
       mov       rsi,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       [rbp-50],rcx
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rax,[rbp-50]
       cmp       [rax],rcx
       jne       near ptr M00_L51
       mov       rsi,rax
       mov       ecx,[rsi+30]
       test      ecx,ecx
       je        short M00_L05
       cmp       ecx,1
       jne       near ptr M00_L57
       mov       dword ptr [rsi+30],0FFFFFFFF
M00_L02:
       mov       rax,[rbp-50]
       inc       dword ptr [rsi+38]
M00_L03:
       mov       ecx,[rsi+38]
       mov       rax,[rsi+28]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L36
       cmp       ecx,[rax+8]
       jae       near ptr M00_L56
       mov       ecx,ecx
       mov       rdi,[rax+rcx*8+10]
       mov       r14,[rdi]
       mov       r15,offset MT_System.RuntimeType
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L40
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M00_L04:
       test      ecx,ecx
       jne       short M00_L02
       jmp       short M00_L08
M00_L05:
       mov       dword ptr [rsi+30],0FFFFFFFF
       mov       rdi,[rsi+10]
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L52
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M00_L39
       call      qword ptr [7FFF78420218]; System.Reflection.Assembly.GetTypes()
M00_L06:
       mov       rcx,23DFF687000
       mov       [rsi+20],rcx
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+38],ecx
       jmp       near ptr M00_L03
M00_L07:
       mov       rcx,rdi
       mov       rax,[r14+70]
       call      qword ptr [rax+18]
       test      al,20
       jne       near ptr M00_L02
       cmp       r14,r15
       jne       near ptr M00_L41
M00_L08:
       mov       rcx,rdi
       call      00007FFFD7F04600
M00_L09:
       test      al,80
       jne       near ptr M00_L02
       cmp       r14,r15
       jne       near ptr M00_L43
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L42
       test      dword ptr [rcx],80000000
       je        short M00_L10
       xor       eax,eax
       jmp       short M00_L11
M00_L10:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M00_L11:
       movzx     r13d,al
M00_L12:
       test      r13d,r13d
       jne       near ptr M00_L02
       mov       r13,[rsi+20]
       cmp       [r13],r15
       jne       near ptr M00_L48
       mov       r12,r13
       cmp       rdi,r12
       je        near ptr M00_L24
       cmp       r14,r15
       jne       near ptr M00_L44
       mov       rax,rdi
M00_L13:
       test      rax,rax
       je        near ptr M00_L22
       cmp       [rax],r15
       jne       near ptr M00_L22
       mov       r13,rax
       mov       rcx,[r13+18]
       mov       rdx,rcx
       mov       r8,[r12+18]
       mov       rax,r8
       cmp       rdx,rax
       je        near ptr M00_L45
       test      cl,2
       jne       short M00_L14
       test      r8b,2
       jne       near ptr M00_L46
M00_L14:
       mov       rcx,1FD6A800038
       mov       rcx,[rcx]
       add       rcx,10
       rorx      r8,rdx,20
       xor       r8,rax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rcx]
       shrx      r8,r8,r10
       xor       r10d,r10d
       mov       [rbp-44],r10d
M00_L15:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rcx+r9*8]
       mov       r11d,[r9]
       mov       r10,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r10,rdx
       jne       short M00_L19
       mov       r10,rax
       xor       r10,[r9+10]
       cmp       r10,1
       ja        short M00_L19
       cmp       r11d,[r9]
       jne       near ptr M00_L47
       mov       ecx,r10d
M00_L16:
       test      ecx,ecx
       jne       short M00_L20
       xor       r10d,r10d
M00_L17:
       movzx     r13d,r10b
M00_L18:
       test      r13d,r13d
       je        near ptr M00_L02
       jmp       near ptr M00_L24
M00_L19:
       test      r11d,r11d
       je        near ptr M00_L47
       mov       r10d,[rbp-44]
       inc       r10d
       add       r8d,r10d
       and       r8d,[rcx+4]
       cmp       r10d,8
       mov       [rbp-44],r10d
       jl        short M00_L15
       jmp       near ptr M00_L47
M00_L20:
       cmp       ecx,1
       je        short M00_L21
       mov       rcx,rdx
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFF782EEDA8]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r10d,eax
       jmp       short M00_L17
M00_L21:
       mov       r10d,1
       jmp       short M00_L17
M00_L22:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       mov       rcx,rdi
       mov       rdx,r13
       mov       rax,[r14+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L24
       mov       rcx,r13
       call      qword ptr [7FFF782ED398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L28
       mov       rcx,r13
       call      00007FFFD7F428C0
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,r13
       call      qword ptr [7FFF7822A400]
       mov       r13,rax
       xor       r12d,r12d
       cmp       dword ptr [r13+8],0
       jle       short M00_L24
M00_L23:
       mov       rcx,[r13+r12*8+10]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M00_L02
       inc       r12d
       cmp       [r13+8],r12d
       jg        short M00_L23
M00_L24:
       cmp       r14,r15
       jne       near ptr M00_L49
M00_L25:
       test      rdi,rdi
       jne       short M00_L29
M00_L26:
       xor       edi,edi
M00_L27:
       test      rdi,rdi
       je        near ptr M00_L53
       cmp       qword ptr [rdi+10],0
       je        short M00_L30
       mov       rcx,[rdi+10]
       mov       r14,[rcx]
       test      r14,r14
       je        short M00_L30
       mov       rax,r14
       jmp       short M00_L31
M00_L28:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFF789B4B28]
       mov       r13d,eax
       jmp       near ptr M00_L18
M00_L29:
       cmp       [rdi],r15
       jne       short M00_L26
       jmp       short M00_L27
M00_L30:
       mov       rcx,rdi
       call      qword ptr [7FFF782E7C30]; System.RuntimeType.InitializeCache()
M00_L31:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        near ptr M00_L37
       mov       rcx,offset MT_System.RuntimeType+ActivatorCache
       cmp       [rdx],rcx
       je        short M00_L32
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rdx],rcx
       jne       near ptr M00_L37
       mov       r14,[rdx+8]
       test      r14,r14
       je        near ptr M00_L37
       jmp       short M00_L33
M00_L32:
       mov       r14,rdx
M00_L33:
       cmp       byte ptr [r14+28],0
       je        near ptr M00_L54
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L50
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
M00_L34:
       test      ecx,ecx
       jne       near ptr M00_L55
       mov       rax,[r14+8]
       mov       rcx,[r14+10]
       call      rax
       mov       r15,rax
       mov       rax,[r14+18]
       mov       rcx,r15
       call      rax
       nop
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       rdx,r15
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],1
       mov       rax,[rbp-50]
       mov       rdi,[rax+8]
M00_L35:
       mov       [rbp-40],rdi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       jmp       near ptr M00_L01
M00_L36:
       xor       eax,eax
       mov       [rsi+28],rax
       jmp       near ptr M00_L57
M00_L37:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFF782EC4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       r14,rax
       jmp       near ptr M00_L33
M00_L38:
       mov       rcx,[rbp-50]
       mov       r11,7FFF782309D8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M00_L35
M00_L39:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L06
M00_L40:
       xor       ecx,ecx
       jmp       near ptr M00_L04
M00_L41:
       mov       rcx,rdi
       mov       rax,[r14+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L09
M00_L42:
       xor       eax,eax
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,rdi
       mov       rax,[r14+60]
       call      qword ptr [rax+8]
       mov       r13d,eax
       jmp       near ptr M00_L12
M00_L44:
       mov       rcx,rdi
       mov       rax,[r14+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L13
M00_L45:
       mov       ecx,1
       jmp       near ptr M00_L16
M00_L46:
       xor       ecx,ecx
       jmp       near ptr M00_L16
M00_L47:
       mov       ecx,2
       jmp       near ptr M00_L16
M00_L48:
       mov       rcx,r13
       mov       rdx,rdi
       mov       rax,[r13]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       mov       r13d,eax
       jmp       near ptr M00_L18
M00_L49:
       mov       rcx,rdi
       mov       rax,[r14+58]
       call      qword ptr [rax]
       mov       rdi,rax
       jmp       near ptr M00_L25
M00_L50:
       xor       ecx,ecx
       jmp       near ptr M00_L34
M00_L51:
       mov       rcx,rax
       mov       r11,7FFF782309D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L38
       jmp       near ptr M00_L57
M00_L52:
       call      qword ptr [7FFF7887F150]
       mov       ecx,49
       mov       rdx,7FFF786BC218
       call      qword ptr [7FFF785077B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFF785B5550
       call      qword ptr [7FFF785077B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF782E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF786BC218
       call      qword ptr [7FFF785077B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF782E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF789B6208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF789B5440]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF789B4F30]
       mov       rsi,rax
       mov       ecx,37B
       mov       rdx,7FFF78224000
       call      qword ptr [7FFF785077B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF78666130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF789B4E70]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFF789B4E88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF789B4EA0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF789B4EB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF785077C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rax,[rbp-50]
       cmp       [rax],rcx
       jne       short M00_L60
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       mov       dword ptr [rax+30],0FFFFFFFE
M00_L58:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L59:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF7890D7B8]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L60:
       mov       rcx,rax
       mov       r11,7FFF782309E0
       call      qword ptr [r11]
       jmp       short M00_L58
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,offset MT_System.Exception
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M00_L61
       xor       eax,eax
       jmp       short M00_L62
M00_L61:
       mov       [rbp-58],rax
       mov       eax,1
M00_L62:
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFF789B4ED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rax,[rbp-50]
       cmp       [rax],rcx
       jne       short M00_L63
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       mov       dword ptr [rax+30],0FFFFFFFE
       jmp       short M00_L64
M00_L63:
       mov       rcx,rax
       mov       r11,7FFF782309E0
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
; Total bytes of code 2089
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       dword ptr [rbp-3C],1
       lea       rcx,[rbp-3C]
       lea       rdx,[rbp-48]
       mov       rax,7FFF7840F7E8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFD7F19620
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M01_L01
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-78]
       mov       [rbx+8],rax
       mov       rax,[rbp-48]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 171
```
```assembly
; System.Reflection.Assembly.GetTypes()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       near ptr M02_L08
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-58],xmm0
       lea       rcx,[rbp-48]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M02_L07
       mov       rcx,[rcx+20]
M02_L00:
       mov       [rbp-50],rcx
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-0B0],xmm0
       lea       rcx,[rbp-0B0]
       lea       r9,[rbp-40]
       mov       edx,1
       xor       r8d,r8d
       mov       rax,7FFF78421170
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFD7F58210
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M02_L02
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       rax,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
M02_L03:
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jne       near ptr M02_L10
       mov       rcx,[rax+10]
       mov       rdx,offset MT_System.Reflection.RuntimeModule
       cmp       [rcx],rdx
       jne       near ptr M02_L09
       xor       edx,edx
       mov       [rbp-60],rdx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-68]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0C0]
       lea       rdx,[rbp-60]
       mov       rax,7FFF7840F178
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFD7E7C110
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M02_L05
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M02_L05:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       rax,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M02_L06:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L08:
       mov       rcx,rbx
       xor       edx,edx
       mov       rax,[rbx]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M02_L03
M02_L09:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M02_L06
M02_L10:
       xor       esi,esi
       mov       edx,edi
       mov       rcx,offset MT_System.Type[][]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       jmp       short M02_L12
M02_L11:
       cmp       r15d,edi
       jae       near ptr M02_L15
       mov       rcx,[rbx+r15*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+r15*8+10]
       add       esi,[rdx+8]
       inc       r15d
M02_L12:
       cmp       [r14+8],r15d
       jg        short M02_L11
       xor       ebx,ebx
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       jmp       short M02_L14
M02_L13:
       mov       rcx,[r14+rdi*8+10]
       mov       r15d,[rcx+8]
       mov       [rsp+20],r15d
       mov       rcx,[r14+rdi*8+10]
       mov       r8,rsi
       mov       r9d,ebx
       xor       edx,edx
       call      qword ptr [7FFF787FD650]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       add       ebx,r15d
       inc       edi
M02_L14:
       cmp       [r14+8],edi
       jg        short M02_L13
       mov       rax,rsi
       jmp       near ptr M02_L06
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 691
```
```assembly
; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
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
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       test      sil,2
       jne       short M03_L01
       test      bl,2
       jne       near ptr M03_L08
       mov       ecx,[rbx]
       and       ecx,0F0000
       cmp       ecx,50000
       je        near ptr M03_L05
M03_L00:
       mov       rcx,7FFF789D1F44
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFF789D1F4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFF783C6208
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFFD7E25F50
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M03_L03
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M03_L03:
       mov       rcx,[rbp-68]
       mov       [r14+8],rcx
       test      eax,eax
       setne     dil
       movzx     edi,dil
M03_L04:
       movzx     eax,dil
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
M03_L05:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       rcx,rsi
       jne       short M03_L07
M03_L06:
       mov       rcx,7FFF789D1F40
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFF789B4B58]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFF789D1F48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L01
; Total bytes of code 317
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
; Total bytes of code 88
```
```assembly
; System.RuntimeType.get_IsActualInterface()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M05_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M05_L00:
       ret
M05_L01:
       xor       eax,eax
       jmp       short M05_L00
; Total bytes of code 31
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M06_L08
M06_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M06_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M06_L09
M06_L01:
       test      rdi,rdi
       jne       near ptr M06_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFFD7F3FE50
       mov       r14,rax
       test      r14,r14
       je        near ptr M06_L10
M06_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M06_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFF78421B50
       mov       [rbp-78],rax
       lea       rax,[M06_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFD7EE5A20
       call      rax
M06_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M06_L04
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M06_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M06_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFFD7F5C1F0
       mov       rdx,rax
       test      rdx,rdx
       je        short M06_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M06_L11
M06_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M06_L07:
       mov       rax,rdi
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
M06_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFF789B6388]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M06_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFF789B5458]
       jmp       near ptr M06_L00
M06_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFF782E7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M06_L02
M06_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
M07_L00:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M07_L04
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M07_L04
M07_L01:
       cmp       [rdi],dil
       add       rdi,80
       mov       rbp,[rdi]
       test      rbp,rbp
       jne       short M07_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M07_L03
M07_L02:
       mov       rcx,rsi
       call      rax
       mov       r14,rax
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFFD7F3CC60
       test      rax,rax
       jne       short M07_L00
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rcx,rbx
       mov       rdx,7FFF78410BC8
       call      qword ptr [7FFF782EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M07_L02
M07_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF782E7C30]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M07_L01
M07_L05:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M07_L06
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       short M07_L07
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rbp
       mov       rdx,r15
       mov       r11,7FFF78230A78
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rbp
       call      00007FFFD7F3CC60
       cmp       rax,rbp
       jne       near ptr M07_L00
       jmp       short M07_L07
M07_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L07:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M07_L08
       jmp       short M07_L09
M07_L08:
       mov       rcx,rbx
       mov       rdx,7FFF78410BC8
       call      qword ptr [7FFF782EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M07_L09:
       mov       rcx,rsi
       call      rax
       mov       rsi,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M07_L10
       jmp       short M07_L11
M07_L10:
       mov       rcx,rbx
       mov       rdx,7FFF78410BE8
       call      qword ptr [7FFF782EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M07_L11:
       mov       rcx,r15
       call      rax
       test      rax,rax
       jne       short M07_L12
       call      qword ptr [7FFF789B4DF8]
       int       3
M07_L12:
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFFD7F3CC60
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 409
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
       je        near ptr M08_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M08_L01
       test      rsi,rsi
       je        short M08_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M08_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFFD7F99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF782E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF782E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M08_L00:
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
M08_L01:
       test      rsi,rsi
       je        short M08_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L03
M08_L02:
       mov       rax,23DFF680008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L03:
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
M08_L04:
       call      qword ptr [7FFF789B53B0]
       int       3
; Total bytes of code 244
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       [rbx+30],edx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+34],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 25
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetTypes()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       call      qword ptr [7FFF78925950]; System.Reflection.Assembly.GetExecutingAssembly()
       test      rax,rax
       je        near ptr M00_L36
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rax],rcx
       jne       near ptr M00_L37
       mov       rcx,rax
       call      qword ptr [7FFF78450218]; System.Reflection.Assembly.GetTypes()
       mov       rsi,rax
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M00_L38
       mov       edx,r14d
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       jmp       near ptr M00_L10
M00_L02:
       test      r9d,r9d
       je        short M00_L03
       inc       eax
       add       r8d,eax
       and       r8d,[rdx+4]
       cmp       eax,8
       jl        near ptr M00_L13
M00_L03:
       mov       r11d,2
       jmp       near ptr M00_L14
M00_L04:
       cmp       r11d,1
       je        short M00_L05
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       mov       r8d,1
       call      qword ptr [7FFF7831EDA8]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r12d,eax
       jmp       near ptr M00_L15
M00_L05:
       mov       r12d,1
       jmp       near ptr M00_L15
M00_L06:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,r15
       mov       rdx,2AC5D747000
       mov       rax,[r13+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L08
       mov       rcx,2AC5D747000
       call      qword ptr [7FFF7831D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L17
       mov       rcx,2AC5D747000
       call      00007FFFD7F428C0
       test      eax,eax
       je        short M00_L09
       mov       rcx,2AC5D747000
       call      qword ptr [7FFF7825A400]
       mov       r13d,[rax+8]
       test      r13d,r13d
       jle       short M00_L08
       lea       r12,[rax+10]
M00_L07:
       mov       rcx,[r12]
       mov       rdx,r15
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M00_L09
       add       r12,8
       dec       r13d
       jne       short M00_L07
M00_L08:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L42
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L09:
       inc       r14d
M00_L10:
       mov       ecx,[rsi+8]
       cmp       ecx,r14d
       jle       near ptr M00_L18
       mov       r15,[rsi+r14*8+10]
       mov       r13,[r15]
       mov       r12,offset MT_System.RuntimeType
       cmp       r13,r12
       jne       near ptr M00_L39
       mov       rcx,r15
       call      00007FFFD7F04600
M00_L11:
       test      al,80
       jne       short M00_L09
       mov       rcx,2AC5D747000
       cmp       r15,rcx
       je        short M00_L08
       cmp       r13,r12
       jne       near ptr M00_L40
       mov       rax,r15
M00_L12:
       test      rax,rax
       je        near ptr M00_L06
       cmp       [rax],r12
       jne       near ptr M00_L06
       mov       r13,rax
       mov       rcx,[r13+18]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       cmp       rcx,rdx
       je        near ptr M00_L41
       mov       rdx,26BC8800038
       mov       rdx,[rdx]
       add       rdx,10
       rorx      r8,rcx,20
       mov       rax,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       eax,[rdx]
       shrx      r8,r8,rax
       xor       eax,eax
M00_L13:
       lea       r10d,[r8+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rdx+r10*8]
       mov       r9d,[r10]
       mov       r11,[r10+8]
       and       r9d,0FFFFFFFE
       cmp       r11,rcx
       jne       near ptr M00_L02
       mov       r11,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       xor       r11,[r10+10]
       cmp       r11,1
       ja        near ptr M00_L02
       cmp       r9d,[r10]
       jne       near ptr M00_L03
M00_L14:
       test      r11d,r11d
       jne       near ptr M00_L04
       xor       r12d,r12d
M00_L15:
       mov       rdx,2AC5D747000
       movzx     r13d,r12b
M00_L16:
       test      r13d,r13d
       je        near ptr M00_L09
       jmp       near ptr M00_L08
M00_L17:
       mov       rcx,r15
       mov       rdx,2AC5D747000
       call      qword ptr [7FFF7892E3E8]
       mov       r13d,eax
       jmp       short M00_L16
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,26BC8801B70
       mov       r14,[rcx]
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,[rdi+10]
       test      r15d,r15d
       jle       near ptr M00_L35
       mov       edx,[r14+8]
       mov       r13d,[rsi+10]
       sub       edx,r13d
       cmp       edx,r15d
       jge       short M00_L21
       mov       edx,r13d
       add       edx,r15d
       jo        near ptr M00_L58
       cmp       dword ptr [r14+8],0
       jne       near ptr M00_L25
       mov       ecx,4
M00_L19:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       ecx,r13d
       jl        near ptr M00_L43
       cmp       [r14+8],ecx
       je        short M00_L21
       test      ecx,ecx
       jle       near ptr M00_L45
       mov       edx,ecx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       test      r13d,r13d
       jg        near ptr M00_L44
M00_L20:
       lea       rcx,[rsi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       r14,[rsi+8]
       mov       r13d,[rsi+10]
       mov       r12,[rdi+8]
       mov       edi,[rdi+10]
       test      r12,r12
       je        near ptr M00_L26
       test      r14,r14
       je        short M00_L22
       mov       rax,[r12]
       cmp       rax,[r14]
       jne       short M00_L22
       cmp       dword ptr [rax+4],18
       jne       short M00_L22
       mov       ecx,edi
       or        ecx,r13d
       jge       near ptr M00_L27
M00_L22:
       test      r14,r14
       je        near ptr M00_L48
       mov       rcx,[r12]
       cmp       rcx,[r14]
       je        short M00_L23
       mov       rcx,[r12]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       eax,1
       test      ecx,ecx
       cmove     ecx,eax
       mov       rax,[r14]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       edx,1
       test      eax,eax
       cmove     eax,edx
       cmp       ecx,eax
       jne       near ptr M00_L49
M00_L23:
       test      edi,edi
       jl        near ptr M00_L50
       mov       rcx,[r12]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L28
       xor       eax,eax
M00_L24:
       mov       [rbp-40],eax
       test      eax,eax
       jle       short M00_L29
       mov       ecx,167
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       r8,rax
       mov       edx,[rbp-40]
       xor       ecx,ecx
       call      qword ptr [7FFF7892EAC0]
       int       3
M00_L25:
       mov       ecx,[r14+8]
       add       ecx,ecx
       jmp       near ptr M00_L19
M00_L26:
       mov       ecx,12D
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       rcx,rax
       call      qword ptr [7FFF7892E340]
       int       3
M00_L27:
       cmp       edi,[r12+8]
       ja        near ptr M00_L22
       jmp       near ptr M00_L46
M00_L28:
       movsxd    rax,ecx
       mov       eax,[r12+rax*4+10]
       jmp       short M00_L24
M00_L29:
       mov       eax,[rbp-40]
       neg       eax
       mov       [rbp-3C],eax
       test      eax,eax
       jl        near ptr M00_L51
       lea       ecx,[rax+rdi]
       cmp       ecx,[r12+8]
       ja        near ptr M00_L51
       mov       rcx,[r14]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L31
       xor       r8d,r8d
M00_L30:
       mov       [rbp-44],r8d
       cmp       r13d,r8d
       jge       short M00_L32
       mov       ecx,17F
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       r8,rax
       mov       edx,[rbp-44]
       mov       ecx,r13d
       call      qword ptr [7FFF7892EAC0]
       int       3
M00_L31:
       movsxd    r8,ecx
       mov       r8d,[r14+r8*4+10]
       jmp       short M00_L30
M00_L32:
       sub       r13d,[rbp-44]
       js        near ptr M00_L52
       lea       ecx,[rdi+r13]
       cmp       ecx,[r14+8]
       ja        near ptr M00_L52
       mov       rcx,[r12]
       cmp       rcx,[r14]
       je        short M00_L33
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFF7892EB80]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M00_L57
M00_L33:
       mov       rcx,[r12]
       movzx     edx,word ptr [rcx]
       mov       r8d,edi
       imul      r8,rdx
       mov       eax,[rbp-3C]
       imul      rax,rdx
       lea       rax,[r12+rax+10]
       mov       r10d,r13d
       imul      rdx,r10
       lea       r10,[r14+rdx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L55
       cmp       r8,4000
       ja        near ptr M00_L54
       mov       rcx,r10
       mov       rdx,rax
       call      00007FFFD7F31380
       cmp       dword ptr [7FFFD8253A10],0
       jne       near ptr M00_L53
M00_L34:
       add       [rsi+10],r15d
       inc       dword ptr [rsi+14]
M00_L35:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-50]
       mov       rdx,7FFF789632C8
       cmp       [rcx],ecx
       call      qword ptr [7FFF78925F98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L36:
       call      qword ptr [7FFF788A73F0]
       mov       ecx,49
       mov       rdx,7FFF786EC218
       call      qword ptr [7FFF785377B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFF785E5550
       call      qword ptr [7FFF785377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF786EC218
       call      qword ptr [7FFF785377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7892EA30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7892EA48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L38:
       mov       rcx,26BC8801B70
       mov       r14,[rcx]
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L39:
       mov       rcx,r15
       mov       rax,[r13+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L11
M00_L40:
       mov       rcx,r15
       mov       rax,[r13+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L12
M00_L41:
       mov       r11d,1
       jmp       near ptr M00_L14
M00_L42:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF7848E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L09
M00_L43:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFF788A66B8]
       int       3
M00_L44:
       mov       rcx,r14
       mov       r8d,r13d
       mov       rdx,r12
       call      qword ptr [7FFF78485050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M00_L20
M00_L45:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L46:
       lea       ecx,[rdi+r13]
       cmp       ecx,[r14+8]
       ja        near ptr M00_L22
       movzx     ecx,word ptr [rax]
       mov       r8d,edi
       imul      r8,rcx
       lea       rdx,[r12+10]
       mov       r10d,r13d
       imul      rcx,r10
       lea       rcx,[r14+rcx+10]
       test      dword ptr [rax],1000000
       je        short M00_L47
       call      qword ptr [7FFF783157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L34
M00_L47:
       call      qword ptr [7FFF78315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L34
M00_L48:
       mov       ecx,145
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       rcx,rax
       call      qword ptr [7FFF7892E340]
       int       3
M00_L49:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7892EB20]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7892EB38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       mov       ecx,0B3
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF7892EA90]
       int       3
M00_L51:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFF7892EB50]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      qword ptr [7FFF78696130]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7892EB68]
       mov       r12,rax
       mov       ecx,145
       mov       rdx,7FFF78254000
       call      qword ptr [7FFF785377B0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rdi
       call      qword ptr [7FFF78696130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L34
M00_L54:
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFF7892E688]
       jmp       near ptr M00_L34
M00_L55:
       cmp       r8,40
       jne       short M00_L56
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymm1,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [r10],ymm0
       vmovdqu   ymmword ptr [r10+20],ymm1
       jmp       near ptr M00_L34
M00_L56:
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFF78315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L34
M00_L57:
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,r12
       mov       edx,[rbp-3C]
       mov       r8,r14
       mov       r9d,r13d
       call      qword ptr [7FFF7892EB98]
       jmp       near ptr M00_L34
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2260
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       dword ptr [rbp-3C],1
       lea       rcx,[rbp-3C]
       lea       rdx,[rbp-48]
       mov       rax,7FFF7843F7E8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFD7F19620
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M01_L01
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-78]
       mov       [rbx+8],rax
       mov       rax,[rbp-48]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 171
```
```assembly
; System.Reflection.Assembly.GetTypes()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       near ptr M02_L08
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-58],xmm0
       lea       rcx,[rbp-48]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M02_L07
       mov       rcx,[rcx+20]
M02_L00:
       mov       [rbp-50],rcx
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-0B0],xmm0
       lea       rcx,[rbp-0B0]
       lea       r9,[rbp-40]
       mov       edx,1
       xor       r8d,r8d
       mov       rax,7FFF78451170
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFD7F58210
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M02_L02
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       rax,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
M02_L03:
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jne       near ptr M02_L10
       mov       rcx,[rax+10]
       mov       rdx,offset MT_System.Reflection.RuntimeModule
       cmp       [rcx],rdx
       jne       near ptr M02_L09
       xor       edx,edx
       mov       [rbp-60],rdx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-68]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0C0]
       lea       rdx,[rbp-60]
       mov       rax,7FFF7843F178
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFD7E7C110
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFD8253A10],0
       je        short M02_L05
       call      qword ptr [7FFFD8241648]; CORINFO_HELP_STOP_FOR_GC
M02_L05:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       rax,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M02_L06:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L08:
       mov       rcx,rbx
       xor       edx,edx
       mov       rax,[rbx]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M02_L03
M02_L09:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M02_L06
M02_L10:
       xor       esi,esi
       mov       edx,edi
       mov       rcx,offset MT_System.Type[][]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       jmp       short M02_L12
M02_L11:
       cmp       r15d,edi
       jae       near ptr M02_L15
       mov       rcx,[rbx+r15*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+r15*8+10]
       add       esi,[rdx+8]
       inc       r15d
M02_L12:
       cmp       [r14+8],r15d
       jg        short M02_L11
       xor       ebx,ebx
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       jmp       short M02_L14
M02_L13:
       mov       rcx,[r14+rdi*8+10]
       mov       r15d,[rcx+8]
       mov       [rsp+20],r15d
       mov       rcx,[r14+rdi*8+10]
       mov       r8,rsi
       mov       r9d,ebx
       xor       edx,edx
       call      qword ptr [7FFF7882D650]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       add       ebx,r15d
       inc       edi
M02_L14:
       cmp       [r14+8],edi
       jg        short M02_L13
       mov       rax,rsi
       jmp       near ptr M02_L06
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 691
```
```assembly
; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
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
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       ecx,esi
       and       ecx,2
       mov       edx,ebx
       and       edx,2
       or        ecx,edx
       jne       short M03_L00
       mov       ecx,[rbx]
       and       ecx,0F0000
       cmp       ecx,50000
       je        short M03_L02
M03_L00:
       mov       rcx,rsi
       mov       [rbp-98],rcx
       mov       rdx,rbx
       mov       [rbp-0A0],rdx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFFC9764030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-0A0]
       call      qword ptr [rax]
       mov       edi,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFFC9764038]; CORINFO_HELP_JIT_PINVOKE_END
       test      edi,edi
       setne     dil
       movzx     edi,dil
M03_L01:
       movzx     eax,dil
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
M03_L02:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       rcx,rsi
       jne       short M03_L04
M03_L03:
       movzx     edi,dil
       jmp       short M03_L01
M03_L04:
       mov       rdx,rsi
       call      qword ptr [7FFFC977FD18]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L03
; Total bytes of code 211
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
; Total bytes of code 88
```
```assembly
; System.RuntimeType.get_IsActualInterface()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M05_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M05_L00:
       ret
M05_L01:
       xor       eax,eax
       jmp       short M05_L00
; Total bytes of code 31
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       je        short M06_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M06_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFF7831D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FFF7892E478]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFD7F98D10
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Array.CanAssignArrayType(System.Array, System.Array)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[rcx]
       mov       rcx,[rax+30]
       mov       rbx,rcx
       mov       rax,[rdx]
       mov       rsi,[rax+30]
       mov       rdi,rsi
       cmp       rbx,rdi
       je        near ptr M07_L04
       mov       eax,ecx
       and       eax,2
       mov       edx,esi
       and       edx,2
       or        eax,edx
       jne       near ptr M07_L13
       mov       rbp,rbx
       mov       r14,rdi
       mov       r15d,[rcx]
       mov       eax,r15d
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M07_L20
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M07_L27
M07_L00:
       and       r15d,0E0000
       cmp       r15d,60000
       je        near ptr M07_L41
M07_L01:
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbp
       rol       r8,20
       xor       r8,r14
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M07_L02:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbp
       jne       short M07_L05
       mov       r9,r14
       xor       r9,[rax+10]
       cmp       r9,1
       ja        short M07_L05
       cmp       r10d,[rax]
       jne       short M07_L06
M07_L03:
       test      r9d,r9d
       je        short M07_L07
       cmp       r9d,1
       jne       near ptr M07_L44
M07_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       test      r10d,r10d
       je        short M07_L06
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L02
M07_L06:
       mov       r9d,2
       jmp       short M07_L03
M07_L07:
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       mov       r8,r14
       mov       rax,rbp
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M07_L08:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,r14
       jne       short M07_L12
       mov       r9,rbp
       xor       r9,[rax+10]
       cmp       r9,1
       ja        short M07_L12
       cmp       r10d,[rax]
       jne       near ptr M07_L45
M07_L09:
       test      r9d,r9d
       je        near ptr M07_L47
       cmp       r9d,1
       jne       near ptr M07_L46
M07_L10:
       mov       eax,2
M07_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L12:
       test      r10d,r10d
       je        near ptr M07_L45
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L08
       jmp       near ptr M07_L45
M07_L13:
       mov       rdi,rsi
       test      cl,2
       jne       short M07_L14
       test      sil,2
       je        short M07_L14
       xor       esi,esi
       jmp       near ptr M07_L19
M07_L14:
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbx
       rol       r8,20
       xor       r8,rdi
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
       cmp       ecx,8
       jge       short M07_L18
M07_L15:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M07_L16
       mov       rsi,rdi
       xor       rsi,[rax+10]
       cmp       rsi,1
       jbe       short M07_L17
M07_L16:
       test      r10d,r10d
       je        short M07_L18
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L15
       jmp       short M07_L18
M07_L17:
       cmp       r10d,[rax]
       jne       short M07_L18
       jmp       short M07_L19
M07_L18:
       mov       esi,2
M07_L19:
       test      esi,esi
       je        near ptr M07_L39
       cmp       esi,1
       je        near ptr M07_L04
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M07_L39
       jmp       near ptr M07_L04
M07_L20:
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M07_L00
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       mov       r8,rsi
       add       rdx,10
       mov       rax,rbx
       rol       rax,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
       cmp       ecx,8
       jge       short M07_L24
M07_L21:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M07_L22
       mov       r9,rsi
       xor       r9,[rax+10]
       cmp       r9,1
       jbe       short M07_L23
M07_L22:
       test      r10d,r10d
       je        short M07_L24
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L21
       jmp       short M07_L24
M07_L23:
       cmp       r10d,[rax]
       jne       short M07_L24
       jmp       short M07_L25
M07_L24:
       mov       r9d,2
M07_L25:
       test      r9d,r9d
       je        near ptr M07_L39
       cmp       r9d,1
       je        short M07_L26
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M07_L39
M07_L26:
       mov       eax,3
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L27:
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       mov       r8,rbx
       mov       rax,rdi
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
       cmp       ecx,8
       jge       short M07_L31
M07_L28:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M07_L29
       mov       r9,rdi
       xor       r9,[rax+10]
       cmp       r9,1
       jbe       short M07_L30
M07_L29:
       test      r10d,r10d
       je        short M07_L31
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L28
       jmp       short M07_L31
M07_L30:
       cmp       r10d,[rax]
       jne       short M07_L31
       jmp       short M07_L32
M07_L31:
       mov       r9d,2
M07_L32:
       test      r9d,r9d
       je        short M07_L33
       cmp       r9d,1
       je        near ptr M07_L40
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M07_L40
M07_L33:
       call      qword ptr [7FFFC9764C18]
       mov       rdx,[rax]
       mov       r8,rdi
       mov       rax,rbx
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
       cmp       ecx,8
       jge       short M07_L37
M07_L34:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rdi
       jne       short M07_L35
       mov       r9,rbx
       xor       r9,[rax+10]
       cmp       r9,1
       jbe       short M07_L36
M07_L35:
       test      r10d,r10d
       je        short M07_L37
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L34
       jmp       short M07_L37
M07_L36:
       cmp       r10d,[rax]
       jne       short M07_L37
       jmp       short M07_L38
M07_L37:
       mov       r9d,2
M07_L38:
       test      r9d,r9d
       je        short M07_L39
       cmp       r9d,1
       je        short M07_L40
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       short M07_L40
M07_L39:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L40:
       mov       eax,4
       jmp       near ptr M07_L11
M07_L41:
       mov       eax,[rsi]
       and       eax,0E0000
       cmp       eax,60000
       jne       near ptr M07_L01
       call      qword ptr [7FFFC977FE58]
       mov       ebp,eax
       mov       rcx,rsi
       call      qword ptr [7FFFC977FE58]
       mov       r14d,eax
       mov       ecx,ebp
       call      qword ptr [7FFFC9775290]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       mov       esi,eax
       mov       ecx,r14d
       call      qword ptr [7FFFC9775290]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       cmp       esi,eax
       je        near ptr M07_L04
       cmp       ebp,0E
       jl        short M07_L42
       cmp       ebp,r14d
       sete      al
       movzx     eax,al
       jmp       short M07_L43
M07_L42:
       cmp       ebp,0E
       jae       near ptr M07_L48
       mov       eax,ebp
       lea       rcx,[7FFFC8AF7AC0]
       movsx     rax,word ptr [rcx+rax*2]
       bt        eax,r14d
       setb      al
       movzx     eax,al
M07_L43:
       test      eax,eax
       je        near ptr M07_L39
       mov       eax,5
       jmp       near ptr M07_L11
M07_L44:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M07_L04
       jmp       near ptr M07_L07
M07_L45:
       mov       r9d,2
       jmp       near ptr M07_L09
M07_L46:
       mov       rcx,r14
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFFC977FE78]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M07_L10
M07_L47:
       mov       rcx,r14
       call      qword ptr [7FFFC977FE20]
       test      eax,eax
       jne       near ptr M07_L10
       mov       rcx,rbp
       call      qword ptr [7FFFC977FE20]
       test      eax,eax
       je        near ptr M07_L39
       jmp       near ptr M07_L10
M07_L48:
       call      qword ptr [7FFFC9763FD8]
       int       3
; Total bytes of code 1426
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M09_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rsi,rsi
       je        short M09_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M09_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFFD7F99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF78315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF78315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       test      rsi,rsi
       je        short M09_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M09_L03
M09_L02:
       mov       rax,2AC5D740008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       call      qword ptr [7FFF7892EEB0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M10_L01
       mov       edx,4
M10_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFFC9789D08]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFFC9764008]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M10_L00
; Total bytes of code 105
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
       je        near ptr M11_L05
       test      rbx,rbx
       je        near ptr M11_L06
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M11_L06
       cmp       dword ptr [rcx+4],18
       jne       near ptr M11_L06
       cmp       edi,[rsi+8]
       ja        near ptr M11_L06
       cmp       edi,[rbx+8]
       ja        near ptr M11_L06
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M11_L01
       cmp       r8,4000
       ja        short M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFFC9775618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M11_L03
M11_L00:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       cmp       r8,19
       je        short M11_L02
       mov       rcx,rbx
       call      qword ptr [7FFFC97788E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M11_L00
M11_L02:
       movups    xmm0,[rdx]
       movups    xmm1,[rdx+9]
       movups    [rbx],xmm0
       movups    [rbx+9],xmm1
       jmp       short M11_L00
M11_L03:
       call      qword ptr [7FFFC9764040]; CORINFO_HELP_POLL_GC
       jmp       short M11_L00
M11_L04:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M11_L05:
       xor       ebp,ebp
       jmp       short M11_L07
M11_L06:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFFC9775378]; Precode of System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M11_L07:
       test      rbx,rbx
       jne       short M11_L08
       xor       eax,eax
       jmp       short M11_L09
M11_L08:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFFC9775378]; Precode of System.Array.GetLowerBound(Int32)
M11_L09:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,eax
       call      qword ptr [7FFFC9775310]
       jmp       near ptr M11_L00
; Total bytes of code 271
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M12_L02
       call      00007FFFD7F31380
       cmp       dword ptr [7FFFD8253A10],0
       jne       short M12_L01
M12_L00:
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFF7892E688]
; Total bytes of code 49
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M13_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M13_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M13_L02
       test      r8b,18
       je        short M13_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M13_L05
M13_L00:
       test      r8b,4
       je        short M13_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M13_L05
M13_L01:
       test      r8,r8
       je        short M13_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M13_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M13_L05
M13_L02:
       cmp       r8,40
       ja        short M13_L06
M13_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M13_L10
M13_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M13_L05:
       vzeroupper
       ret
M13_L06:
       cmp       r8,800
       ja        near ptr M13_L12
       cmp       r8,100
       jae       short M13_L09
M13_L07:
       mov       r9,r8
       shr       r9,6
M13_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M13_L08
       and       r8,3F
       cmp       r8,10
       ja        short M13_L03
       jmp       short M13_L04
M13_L09:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
       jmp       short M13_L07
M13_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M13_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M13_L04
M13_L11:
       cmp       rcx,rdx
       jne       short M13_L12
       cmp       [rdx],dl
       jmp       near ptr M13_L05
M13_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFF783166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
```

