## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-70],rax
       mov       rbx,rcx
       call      qword ptr [7FFA02F8F108]; System.Reflection.Assembly.GetExecutingAssembly()
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
       mov       [rbp-58],rsi
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rsi,[rbp-58]
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rdi,rsi
       mov       ecx,[rdi+30]
       test      ecx,ecx
       je        short M00_L05
       cmp       ecx,1
       jne       near ptr M00_L57
       mov       dword ptr [rdi+30],0FFFFFFFF
M00_L02:
       inc       dword ptr [rdi+38]
M00_L03:
       mov       ecx,[rdi+38]
       mov       rax,[rdi+28]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L36
       cmp       ecx,[rax+8]
       jae       near ptr M00_L56
       mov       ecx,ecx
       mov       r14,[rax+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M00_L07
       mov       rcx,[r14+18]
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
       mov       dword ptr [rdi+30],0FFFFFFFF
       mov       r14,[rdi+10]
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L52
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M00_L39
       call      qword ptr [7FFA02A70218]; System.Reflection.Assembly.GetTypes()
M00_L06:
       mov       rcx,189C4AC7000
       mov       [rdi+20],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+38],ecx
       jmp       near ptr M00_L03
M00_L07:
       mov       rcx,r14
       mov       rax,[r15+70]
       call      qword ptr [rax+18]
       test      al,20
       jne       near ptr M00_L02
       cmp       r15,r13
       jne       near ptr M00_L41
M00_L08:
       mov       rcx,r14
       call      00007FFA62568EB0
M00_L09:
       test      al,80
       jne       near ptr M00_L02
       cmp       r15,r13
       jne       near ptr M00_L43
       mov       rcx,[r14+18]
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
       movzx     r12d,al
M00_L12:
       test      r12d,r12d
       jne       near ptr M00_L02
       mov       r12,[rdi+20]
       cmp       [r12],r13
       jne       near ptr M00_L48
       mov       rax,r12
       mov       [rbp-60],rax
       cmp       r14,rax
       je        near ptr M00_L24
       cmp       r15,r13
       jne       near ptr M00_L44
       mov       rdx,r14
M00_L13:
       test      rdx,rdx
       je        near ptr M00_L22
       cmp       [rdx],r13
       jne       near ptr M00_L22
       mov       r12,rdx
       mov       [rbp-68],r12
       mov       rcx,[r12+18]
       mov       rdx,rcx
       mov       rax,[rbp-60]
       mov       r8,[rax+18]
       mov       r10,r8
       cmp       rdx,r10
       je        near ptr M00_L45
       test      cl,2
       jne       short M00_L14
       test      r8b,2
       jne       near ptr M00_L46
M00_L14:
       mov       rcx,1492F800038
       mov       rcx,[rcx]
       add       rcx,10
       rorx      r8,rdx,20
       xor       r8,r10
       mov       r9,9E3779B97F4A7C15
       imul      r8,r9
       mov       r9d,[rcx]
       shrx      r8,r8,r9
       xor       r9d,r9d
       mov       [rbp-44],r9d
M00_L15:
       lea       r11d,[r8+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rcx+r11*8]
       mov       r9d,[r11]
       mov       r12,[r11+8]
       and       r9d,0FFFFFFFE
       cmp       r12,rdx
       jne       short M00_L19
       mov       r12,r10
       xor       r12,[r11+10]
       cmp       r12,1
       ja        short M00_L19
       cmp       r9d,[r11]
       jne       near ptr M00_L47
       mov       ecx,r12d
M00_L16:
       test      ecx,ecx
       jne       short M00_L20
       xor       r9d,r9d
M00_L17:
       movzx     r12d,r9b
M00_L18:
       test      r12d,r12d
       je        near ptr M00_L02
       jmp       near ptr M00_L24
M00_L19:
       test      r9d,r9d
       je        near ptr M00_L47
       mov       r9d,[rbp-44]
       inc       r9d
       add       r8d,r9d
       and       r8d,[rcx+4]
       cmp       r9d,8
       mov       [rbp-44],r9d
       jl        short M00_L15
       jmp       near ptr M00_L47
M00_L20:
       cmp       ecx,1
       je        short M00_L21
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,1
       call      qword ptr [7FFA0293E868]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r9d,eax
       jmp       short M00_L17
M00_L21:
       mov       r9d,1
       jmp       short M00_L17
M00_L22:
       mov       rdx,r14
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       mov       rcx,r14
       mov       rdx,r12
       mov       rax,[r15+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L24
       mov       rcx,r12
       call      qword ptr [7FFA0293D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L28
       mov       rcx,r12
       call      00007FFA62589010
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,r12
       call      qword ptr [7FFA0287A400]
       mov       r12,rax
       xor       eax,eax
       cmp       dword ptr [r12+8],0
       jle       short M00_L24
M00_L23:
       mov       [rbp-50],rax
       mov       rcx,[r12+rax*8+10]
       mov       rdx,r14
       mov       r8,[rcx]
       mov       r8,[r8+0B0]
       call      qword ptr [r8+20]
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,[rbp-50]
       inc       ecx
       cmp       [r12+8],ecx
       mov       rax,rcx
       jg        short M00_L23
M00_L24:
       cmp       r15,r13
       jne       near ptr M00_L49
M00_L25:
       test      r14,r14
       jne       short M00_L29
M00_L26:
       xor       r14d,r14d
M00_L27:
       test      r14,r14
       je        near ptr M00_L53
       cmp       qword ptr [r14+10],0
       je        short M00_L30
       mov       rcx,[r14+10]
       mov       r15,[rcx]
       test      r15,r15
       je        short M00_L30
       mov       rax,r15
       jmp       short M00_L31
M00_L28:
       mov       rcx,r14
       mov       rdx,r12
       call      qword ptr [7FFA03016A60]
       mov       r12d,eax
       jmp       near ptr M00_L18
M00_L29:
       cmp       [r14],r13
       jne       short M00_L26
       jmp       short M00_L27
M00_L30:
       mov       rcx,r14
       call      qword ptr [7FFA02937C30]; System.RuntimeType.InitializeCache()
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
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M00_L37
       jmp       short M00_L33
M00_L32:
       mov       r15,rdx
M00_L33:
       cmp       byte ptr [r15+28],0
       je        near ptr M00_L54
       mov       rcx,[r14+18]
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
       mov       rax,[r15+8]
       mov       rcx,[r15+10]
       call      rax
       mov       r13,rax
       mov       rax,[r15+18]
       mov       rcx,r13
       call      rax
       nop
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       rdx,r13
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+30],1
       mov       r14,[rsi+8]
M00_L35:
       mov       [rbp-40],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       jmp       near ptr M00_L01
M00_L36:
       xor       eax,eax
       mov       [rdi+28],rax
       jmp       near ptr M00_L57
M00_L37:
       mov       rdx,r14
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFA0293C4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       r15,rax
       jmp       near ptr M00_L33
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFA02880AD8
       call      qword ptr [r11]
       mov       r14,rax
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
       mov       rcx,r14
       mov       rax,[r15+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L09
M00_L42:
       xor       eax,eax
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,r14
       mov       rax,[r15+60]
       call      qword ptr [rax+8]
       mov       r12d,eax
       jmp       near ptr M00_L12
M00_L44:
       mov       rcx,r14
       mov       rdx,[r15+58]
       call      qword ptr [rdx]
       mov       rdx,rax
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
       mov       rcx,r12
       mov       rdx,r14
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       mov       r12d,eax
       jmp       near ptr M00_L18
M00_L49:
       mov       rcx,r14
       mov       rax,[r15+58]
       call      qword ptr [rax]
       mov       r14,rax
       jmp       near ptr M00_L25
M00_L50:
       xor       ecx,ecx
       jmp       near ptr M00_L34
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFA02880AD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L38
       jmp       near ptr M00_L57
M00_L52:
       call      qword ptr [7FFA02EBE4C0]
       mov       ecx,49
       mov       rdx,7FFA02D08C38
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C04878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D08C38
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA03017F00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA03017210]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA03016DC0]
       mov       rdi,rax
       mov       ecx,37B
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA02CB6010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA03016D00]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFA03016D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA03016D30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA03016D48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02B577B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       cmp       [rsi],rcx
       jne       short M00_L60
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       [rsi+28],rcx
       mov       dword ptr [rsi+30],0FFFFFFFE
M00_L58:
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
M00_L59:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA02F8F120]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L60:
       mov       rcx,rsi
       mov       r11,7FFA02880AE0
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
       mov       [rbp-70],rax
       mov       eax,1
M00_L62:
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-70]
       call      qword ptr [7FFA03016D60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       short M00_L63
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       mov       dword ptr [rax+30],0FFFFFFFE
       jmp       short M00_L64
M00_L63:
       mov       rcx,rax
       mov       r11,7FFA02880AE0
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
; Total bytes of code 2101
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
       mov       rax,7FFA02A5F7E8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA624FF440
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M01_L01
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA02A71170
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA625AA8E0
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA02A5F178
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA6255DD40
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L05
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA02E3C9F0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,7FFA03056E9C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFA03056EA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFA02A16208
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA624787B0
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M03_L03
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFA03056E98
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFA03016A78]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFA03056EA0
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
       call      00007FFA62585510
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
       mov       rax,7FFA02A71B50
       mov       [rbp-78],rax
       lea       rax,[M06_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA624E2CB0
       call      rax
M06_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M06_L04
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFA625ABB40
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
       call      qword ptr [7FFA0301C048]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M06_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA03017228]
       jmp       near ptr M06_L00
M06_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA02937C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      00007FFA62569D60
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
       mov       rdx,7FFA02A60BC8
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M07_L02
M07_L04:
       mov       rcx,rsi
       call      qword ptr [7FFA02937C30]; System.RuntimeType.InitializeCache()
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
       mov       r11,7FFA02880AF8
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rbp
       call      00007FFA62569D60
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
       mov       rdx,7FFA02A60BC8
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA02A60BE8
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M07_L11:
       mov       rcx,r15
       call      rax
       test      rax,rax
       jne       short M07_L12
       call      qword ptr [7FFA03016418]
       int       3
M07_L12:
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFA62569D60
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,189C4AC0008
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
       call      qword ptr [7FFA03017198]
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFA02F873F0]; System.Reflection.Assembly.GetExecutingAssembly()
       test      rax,rax
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rax],rcx
       jne       near ptr M00_L39
       mov       rcx,rax
       call      qword ptr [7FFA02AA0218]; System.Reflection.Assembly.GetTypes()
       mov       rsi,rax
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M00_L40
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
       call      qword ptr [7FFA0296E868]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
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
       mov       rdx,2E00B6A7000
       mov       rax,[r13+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L08
       mov       rcx,2E00B6A7000
       call      qword ptr [7FFA0296D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L17
       mov       rcx,2E00B6A7000
       call      00007FFA62589010
       test      eax,eax
       je        short M00_L09
       mov       rcx,2E00B6A7000
       call      qword ptr [7FFA028AA400]
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
       jbe       near ptr M00_L44
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
       jne       near ptr M00_L41
       mov       rcx,r15
       call      00007FFA62568EB0
M00_L11:
       test      al,80
       jne       short M00_L09
       mov       rcx,2E00B6A7000
       cmp       r15,rcx
       je        short M00_L08
       cmp       r13,r12
       jne       near ptr M00_L42
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
       je        near ptr M00_L43
       mov       rdx,29F76400038
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
       mov       rdx,2E00B6A7000
       movzx     r13d,r12b
M00_L16:
       test      r13d,r13d
       je        near ptr M00_L09
       jmp       near ptr M00_L08
M00_L17:
       mov       rcx,r15
       mov       rdx,2E00B6A7000
       call      qword ptr [7FFA02F8FD08]
       mov       r13d,eax
       jmp       short M00_L16
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,29F76401B00
       mov       r14,[rcx]
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,[rdi+10]
       test      r15d,r15d
       jle       near ptr M00_L34
       mov       edx,[r14+8]
       mov       r13d,[rsi+10]
       sub       edx,r13d
       cmp       edx,r15d
       jge       short M00_L21
       mov       edx,r13d
       add       edx,r15d
       jo        near ptr M00_L58
       cmp       dword ptr [r14+8],0
       jne       near ptr M00_L27
       mov       ecx,4
M00_L19:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       ecx,r13d
       jl        near ptr M00_L45
       cmp       [r14+8],ecx
       je        short M00_L21
       test      ecx,ecx
       jle       near ptr M00_L47
       mov       edx,ecx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       test      r13d,r13d
       jg        near ptr M00_L46
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
       je        near ptr M00_L28
       test      r14,r14
       je        short M00_L22
       mov       rax,[r12]
       cmp       rax,[r14]
       jne       short M00_L22
       cmp       dword ptr [rax+4],18
       jne       short M00_L22
       mov       ecx,edi
       or        ecx,r13d
       jge       near ptr M00_L29
M00_L22:
       test      r14,r14
       je        near ptr M00_L50
       mov       rcx,[r12]
       cmp       rcx,[r14]
       je        short M00_L23
       mov       rcx,[r12]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[r14]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M00_L51
M00_L23:
       test      edi,edi
       jl        near ptr M00_L52
       mov       rcx,[r12]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M00_L30
       xor       eax,eax
M00_L24:
       test      eax,eax
       jg        near ptr M00_L53
       neg       eax
       mov       [rbp-3C],eax
       test      eax,eax
       jl        near ptr M00_L54
       lea       ecx,[rax+rdi]
       cmp       ecx,[r12+8]
       ja        near ptr M00_L54
       mov       rcx,[r14]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M00_L31
       xor       r8d,r8d
M00_L25:
       cmp       r13d,r8d
       jl        near ptr M00_L55
       sub       r13d,r8d
       js        near ptr M00_L56
       lea       ecx,[rdi+r13]
       cmp       ecx,[r14+8]
       ja        near ptr M00_L56
       mov       rcx,[r12]
       cmp       rcx,[r14]
       je        short M00_L26
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFA030244C8]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M00_L32
M00_L26:
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
       je        near ptr M00_L35
       cmp       r8,4000
       ja        near ptr M00_L37
       mov       rcx,r10
       mov       rdx,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L33
       jmp       near ptr M00_L57
M00_L27:
       mov       ecx,[r14+8]
       add       ecx,ecx
       jmp       near ptr M00_L19
M00_L28:
       mov       ecx,12D
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rcx,rax
       call      qword ptr [7FFA02F8FFD8]
       int       3
M00_L29:
       cmp       edi,[r12+8]
       ja        near ptr M00_L22
       jmp       near ptr M00_L48
M00_L30:
       movsxd    rax,ecx
       mov       eax,[r12+rax*4+10]
       jmp       near ptr M00_L24
M00_L31:
       movsxd    r8,ecx
       mov       r8d,[r14+r8*4+10]
       jmp       near ptr M00_L25
M00_L32:
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,r12
       mov       edx,[rbp-3C]
       mov       r8,r14
       mov       r9d,r13d
       call      qword ptr [7FFA030244E0]
M00_L33:
       add       [rsi+10],r15d
       inc       dword ptr [rsi+14]
M00_L34:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-50]
       mov       rdx,7FFA02FDB090
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F878B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L35:
       cmp       r8,40
       je        short M00_L36
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L33
M00_L36:
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymm1,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [r10],ymm0
       vmovdqu   ymmword ptr [r10+20],ymm1
       jmp       short M00_L33
M00_L37:
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFA02F8FFA8]
       jmp       near ptr M00_L33
M00_L38:
       call      qword ptr [7FFA02EE67D8]
       mov       ecx,49
       mov       rdx,7FFA02D38C38
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D38C38
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03024390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030243A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L40:
       mov       rcx,29F76401B00
       mov       r14,[rcx]
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,r15
       mov       rax,[r13+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L11
M00_L42:
       mov       rcx,r15
       mov       rax,[r13+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L12
M00_L43:
       mov       r11d,1
       jmp       near ptr M00_L14
M00_L44:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFA02ADE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L09
M00_L45:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EE5AA0]
       int       3
M00_L46:
       mov       rcx,r14
       mov       r8d,r13d
       mov       rdx,r12
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M00_L20
M00_L47:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L48:
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
       je        short M00_L49
       call      qword ptr [7FFA029657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L33
M00_L49:
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L33
M00_L50:
       mov       ecx,145
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rcx,rax
       call      qword ptr [7FFA02F8FFD8]
       int       3
M00_L51:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA03024468]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA03024480]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       ecx,0B3
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFA030243D8]
       int       3
M00_L53:
       mov       [rbp-40],eax
       mov       ecx,167
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       r8,rax
       mov       edx,[rbp-40]
       xor       ecx,ecx
       call      qword ptr [7FFA03024408]
       int       3
M00_L54:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA03024498]
       mov       r14,rax
       mov       ecx,12D
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFA02CE6010]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       [rbp-44],r8d
       mov       ecx,17F
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       r8,rax
       mov       edx,[rbp-44]
       mov       ecx,r13d
       call      qword ptr [7FFA03024408]
       int       3
M00_L56:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA030244B0]
       mov       r12,rax
       mov       ecx,145
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rdi
       call      qword ptr [7FFA02CE6010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L57:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L33
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2268
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
       mov       rax,7FFA02A8F7E8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA624FF440
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M01_L01
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA02AA1170
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA625AA8E0
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA02A8F178
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA6255DD40
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L05
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA02E6C9F0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-0A0]
       call      qword ptr [rax]
       mov       edi,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFA54403D08]
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
       jmp       qword ptr [7FFA0296D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FFA02F8FD98]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFA625E3AA0
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Array.CanAssignArrayType(System.Array, System.Array)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rax,[rcx]
       mov       rcx,[rax+30]
       mov       rbx,rcx
       mov       rax,[rdx]
       mov       rsi,[rax+30]
       mov       rdi,rsi
       cmp       rbx,rdi
       je        near ptr M07_L32
       mov       eax,ecx
       and       eax,2
       mov       edx,esi
       and       edx,2
       or        eax,edx
       jne       near ptr M07_L28
       mov       rbp,rbx
       mov       r14,rdi
       mov       eax,[rcx]
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M07_L04
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M07_L05
       call      qword ptr [7FFA543E8C00]
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
M07_L00:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       near ptr M07_L15
       mov       r9,rdi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M07_L15
       cmp       r10d,[rax]
       jne       near ptr M07_L39
M07_L01:
       test      r9d,r9d
       je        near ptr M07_L16
       cmp       r9d,1
       je        short M07_L02
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M07_L16
M07_L02:
       mov       eax,4
       jmp       near ptr M07_L14
M07_L03:
       test      r10d,r10d
       je        near ptr M07_L40
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M07_L17
       jmp       near ptr M07_L40
M07_L04:
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M07_L23
M07_L05:
       mov       eax,[rcx]
       and       eax,0E0000
       cmp       eax,60000
       jne       short M07_L06
       mov       eax,[rsi]
       and       eax,0E0000
       cmp       eax,60000
       je        near ptr M07_L20
M07_L06:
       call      qword ptr [7FFA543E8C00]
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
M07_L07:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbp
       jne       near ptr M07_L34
       mov       r9,r14
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M07_L34
       cmp       r10d,[rax]
       jne       near ptr M07_L41
M07_L08:
       test      r9d,r9d
       je        short M07_L09
       cmp       r9d,1
       je        near ptr M07_L32
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M07_L32
M07_L09:
       call      qword ptr [7FFA543E8C00]
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
M07_L10:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,r14
       jne       near ptr M07_L35
       mov       r9,rbp
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M07_L35
       cmp       r10d,[rax]
       jne       near ptr M07_L42
M07_L11:
       test      r9d,r9d
       je        short M07_L12
       cmp       r9d,1
       je        short M07_L13
       mov       rcx,r14
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       short M07_L13
M07_L12:
       mov       ecx,[r14]
       and       ecx,0F0000
       cmp       ecx,0C0000
       je        short M07_L13
       mov       ecx,[rbp]
       and       ecx,0F0000
       cmp       ecx,0C0000
       jne       near ptr M07_L19
M07_L13:
       mov       eax,2
M07_L14:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L15:
       test      r10d,r10d
       je        near ptr M07_L39
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M07_L00
       jmp       near ptr M07_L39
M07_L16:
       call      qword ptr [7FFA543E8C00]
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
M07_L17:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rdi
       jne       near ptr M07_L03
       mov       r9,rbx
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M07_L03
       cmp       r10d,[rax]
       jne       near ptr M07_L40
M07_L18:
       test      r9d,r9d
       je        short M07_L19
       cmp       r9d,1
       je        near ptr M07_L02
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M07_L02
M07_L19:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L20:
       call      qword ptr [7FFA54403E40]
       mov       ebx,eax
       mov       rcx,rsi
       call      qword ptr [7FFA54403E40]
       mov       esi,eax
       mov       ecx,ebx
       call      qword ptr [7FFA543F9280]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       mov       edi,eax
       mov       ecx,esi
       call      qword ptr [7FFA543F9280]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       cmp       edi,eax
       je        near ptr M07_L32
       cmp       ebx,0E
       jge       short M07_L21
       cmp       ebx,0E
       jae       near ptr M07_L43
       mov       eax,ebx
       lea       rcx,[7FFA537783C8]
       movsx     rax,word ptr [rcx+rax*2]
       bt        eax,esi
       jae       short M07_L19
       jmp       short M07_L22
M07_L21:
       cmp       ebx,esi
       jne       short M07_L19
M07_L22:
       mov       eax,5
       jmp       near ptr M07_L14
M07_L23:
       call      qword ptr [7FFA543E8C00]
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
M07_L24:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M07_L27
       mov       r9,rsi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        short M07_L27
       cmp       r10d,[rax]
       jne       near ptr M07_L38
M07_L25:
       test      r9d,r9d
       je        near ptr M07_L19
       cmp       r9d,1
       je        short M07_L26
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M07_L19
M07_L26:
       mov       eax,3
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L27:
       test      r10d,r10d
       je        near ptr M07_L38
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M07_L24
       jmp       near ptr M07_L38
M07_L28:
       mov       rdi,rsi
       test      cl,2
       jne       short M07_L29
       test      sil,2
       jne       near ptr M07_L36
M07_L29:
       call      qword ptr [7FFA543E8C00]
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
M07_L30:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M07_L33
       mov       rsi,rdi
       xor       rsi,[rax+10]
       cmp       rsi,1
       ja        short M07_L33
       cmp       r10d,[rax]
       jne       near ptr M07_L37
M07_L31:
       test      esi,esi
       je        near ptr M07_L19
       cmp       esi,1
       je        short M07_L32
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA54403E60]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M07_L19
M07_L32:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L33:
       test      r10d,r10d
       je        short M07_L37
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M07_L30
       jmp       short M07_L37
M07_L34:
       test      r10d,r10d
       je        short M07_L41
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M07_L07
       jmp       short M07_L41
M07_L35:
       test      r10d,r10d
       je        short M07_L42
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M07_L10
       jmp       short M07_L42
M07_L36:
       xor       esi,esi
       jmp       short M07_L31
M07_L37:
       mov       esi,2
       jmp       near ptr M07_L31
M07_L38:
       mov       r9d,2
       jmp       near ptr M07_L25
M07_L39:
       mov       r9d,2
       jmp       near ptr M07_L01
M07_L40:
       mov       r9d,2
       jmp       near ptr M07_L18
M07_L41:
       mov       r9d,2
       jmp       near ptr M07_L08
M07_L42:
       mov       r9d,2
       jmp       near ptr M07_L11
M07_L43:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 1451
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
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M09_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M09_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M09_L02
       test      r8b,18
       je        short M09_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M09_L05
M09_L00:
       test      r8b,4
       je        short M09_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M09_L05
M09_L01:
       test      r8,r8
       je        short M09_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M09_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M09_L05
M09_L02:
       cmp       r8,40
       ja        short M09_L06
M09_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M09_L10
M09_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M09_L05:
       vzeroupper
       ret
M09_L06:
       cmp       r8,800
       ja        near ptr M09_L12
       cmp       r8,100
       jae       short M09_L09
M09_L07:
       mov       r9,r8
       shr       r9,6
M09_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M09_L08
       and       r8,3F
       cmp       r8,10
       ja        short M09_L03
       jmp       short M09_L04
M09_L09:
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
       jmp       short M09_L07
M09_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M09_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M09_L04
M09_L11:
       cmp       rcx,rdx
       jne       short M09_L12
       cmp       [rdx],dl
       jmp       near ptr M09_L05
M09_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E00B6A0008
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
       call      qword ptr [7FFA03024810]
       int       3
; Total bytes of code 244
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
       jne       short M11_L01
       mov       edx,4
M11_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFA5440DCB8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFA543E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M11_L00
; Total bytes of code 105
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M12_L01
       xor       ebp,ebp
M12_L00:
       test      rbx,rbx
       jne       short M12_L03
       xor       eax,eax
       jmp       short M12_L04
M12_L01:
       test      rbx,rbx
       je        short M12_L02
       mov       r14,[rsi]
       cmp       r14,[rbx]
       jne       short M12_L02
       cmp       dword ptr [r14+4],18
       jne       short M12_L02
       cmp       edi,[rsi+8]
       ja        short M12_L02
       cmp       edi,[rbx+8]
       jbe       short M12_L06
M12_L02:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       mov       ebp,eax
       jmp       short M12_L00
M12_L03:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
M12_L04:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,eax
       call      qword ptr [7FFA543F9300]
M12_L05:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L06:
       mov       r8d,edi
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       je        short M12_L08
       cmp       r8,4000
       ja        short M12_L07
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M12_L05
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       short M12_L05
M12_L07:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M12_L08:
       cmp       r8,19
       jne       short M12_L09
       movups    xmm0,[rdx]
       movups    xmm1,[rdx+9]
       movups    [rcx],xmm0
       movups    [rcx+9],xmm1
       jmp       short M12_L05
M12_L09:
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M12_L05
; Total bytes of code 243
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M13_L02
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M13_L01
M13_L00:
       add       rsp,28
       ret
M13_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M13_L00
M13_L02:
       add       rsp,28
       jmp       qword ptr [7FFA02F8FFA8]
; Total bytes of code 49
```

