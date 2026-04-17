## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFA06FCEF70]; System.Reflection.Assembly.GetExecutingAssembly()
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
       mov       [rbp-48],rsi
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rsi,[rbp-48]
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
       call      qword ptr [7FFA06AE3088]; System.Reflection.Assembly.GetTypes()
M00_L06:
       mov       rcx,232CA8B7000
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
       call      00007FFA66594600
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
       mov       [rbp-50],rax
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
       mov       rcx,[r12+18]
       mov       rdx,rcx
       mov       rax,[rbp-50]
       mov       r8,[rax+18]
       mov       r10,r8
       cmp       rdx,r10
       je        near ptr M00_L45
       test      cl,2
       jne       short M00_L14
       test      r8b,2
       jne       near ptr M00_L46
M00_L14:
       mov       rcx,1F235800038
       mov       rcx,[rcx]
       add       rcx,10
       rorx      r8,rdx,20
       xor       r8,r10
       mov       r9,9E3779B97F4A7C15
       imul      r8,r9
       mov       r9d,[rcx]
       shrx      r8,r8,r9
       xor       r9d,r9d
M00_L15:
       lea       r11d,[r8+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rcx+r11*8]
       mov       r15d,[r11]
       mov       r13,[r11+8]
       and       r15d,0FFFFFFFE
       cmp       r13,rdx
       jne       short M00_L19
       mov       r13,r10
       xor       r13,[r11+10]
       cmp       r13,1
       ja        short M00_L19
       cmp       r15d,[r11]
       jne       near ptr M00_L47
       mov       ecx,r13d
M00_L16:
       test      ecx,ecx
       jne       short M00_L20
       xor       r15d,r15d
M00_L17:
       movzx     r15d,r15b
M00_L18:
       test      r15d,r15d
       je        near ptr M00_L02
       jmp       near ptr M00_L24
M00_L19:
       test      r15d,r15d
       je        near ptr M00_L47
       inc       r9d
       add       r8d,r9d
       and       r8d,[rcx+4]
       cmp       r9d,8
       jl        short M00_L15
       jmp       near ptr M00_L47
M00_L20:
       cmp       ecx,1
       je        short M00_L21
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,1
       call      qword ptr [7FFA06B44C00]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r15d,eax
       jmp       short M00_L17
M00_L21:
       mov       r15d,1
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
       call      qword ptr [7FFA06B469B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L28
       mov       rcx,r12
       call      00007FFA665D28C0
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,r12
       call      qword ptr [7FFA068BA400]
       mov       r12,rax
       xor       r15d,r15d
       cmp       dword ptr [r12+8],0
       jle       short M00_L24
M00_L23:
       mov       rcx,[r12+r15*8+10]
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M00_L02
       inc       r15d
       cmp       [r12+8],r15d
       jg        short M00_L23
M00_L24:
       mov       r15,[r14]
       mov       r13,offset MT_System.RuntimeType
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
       call      qword ptr [7FFA07046910]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L29:
       cmp       [r14],r13
       jne       short M00_L26
       jmp       short M00_L27
M00_L30:
       mov       rcx,r14
       call      qword ptr [7FFA06B456E0]; System.RuntimeType.InitializeCache()
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
       mov       [rbp-58],rdx
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
       call      qword ptr [7FFA06B45F38]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       r15,rax
       jmp       near ptr M00_L33
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFA068C0A78
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
       mov       r15d,eax
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
       mov       r11,7FFA068C0A70
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L38
       jmp       near ptr M00_L57
M00_L52:
       call      qword ptr [7FFA06EFE700]
       mov       ecx,49
       mov       rdx,7FFA06D48C38
       call      qword ptr [7FFA0697F228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C44F18
       call      qword ptr [7FFA0697F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0697D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D48C38
       call      qword ptr [7FFA0697F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0697D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA07047ED0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA07046FE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA07046C70]
       mov       rdi,rax
       mov       ecx,37B
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA0697F228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA06CF6028]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA07046BB0]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFA07046BC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA07046BE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA07046BF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0697F240]
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
       call      qword ptr [7FFA06FCEF88]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L60:
       mov       rcx,rsi
       mov       r11,7FFA068C0A80
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
       call      qword ptr [7FFA07046C10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       mov       rsi,[rbp-48]
       cmp       [rsi],rcx
       jne       short M00_L63
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       [rsi+28],rcx
       mov       dword ptr [rsi+30],0FFFFFFFE
       jmp       short M00_L64
M00_L63:
       mov       rcx,rsi
       mov       r11,7FFA068C0A80
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
; Total bytes of code 2088
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
       mov       rax,7FFA06AE26D8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA665A9620
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M01_L01
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA06B68260
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA665E8210
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M02_L02
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA06B66F48
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA6650C110
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M02_L05
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA06E7CCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,7FFA070866FC
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFA07086704
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFA06A56208
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA664B5F50
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M03_L03
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFA070866F8
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFA07046940]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFA07086700
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
       call      00007FFA665CFE50
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
       mov       rax,7FFA06B68C30
       mov       [rbp-78],rax
       lea       rax,[M06_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA66575A20
       call      rax
M06_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M06_L04
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFA665EC1F0
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
       call      qword ptr [7FFA0704C018]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M06_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA07047000]
       jmp       near ptr M06_L00
M06_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA06B45728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      00007FFA665CCC60
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
       mov       rdx,7FFA06B2C6A0
       call      qword ptr [7FFA0697F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M07_L02
M07_L04:
       mov       rcx,rsi
       call      qword ptr [7FFA06B456E0]; System.RuntimeType.InitializeCache()
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
       mov       r11,7FFA068C0AF8
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rbp
       call      00007FFA665CCC60
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
       mov       rdx,7FFA06B2C6A0
       call      qword ptr [7FFA0697F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFA06B2C6C0
       call      qword ptr [7FFA0697F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M07_L11:
       mov       rcx,r15
       call      rax
       test      rax,rax
       jne       short M07_L12
       call      qword ptr [7FFA070462C8]
       int       3
M07_L12:
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFA665CCC60
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,232CA8B0008
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
       call      qword ptr [7FFA07046F58]
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       [rbp-40],rax
       mov       rbx,rcx
       call      qword ptr [7FFA06FFEF40]; System.Reflection.Assembly.GetExecutingAssembly()
       test      rax,rax
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rax],rcx
       jne       near ptr M00_L26
       mov       rcx,rax
       call      qword ptr [7FFA06B13088]; System.Reflection.Assembly.GetTypes()
       mov       rsi,rax
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rsi+8]
       mov       edx,r14d
       test      edx,edx
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       r15d,10
       inc       r14d
       jmp       near ptr M00_L08
M00_L02:
       cmp       r11d,1
       je        short M00_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       mov       r8d,1
       call      qword ptr [7FFA06B74C00]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       jmp       near ptr M00_L13
M00_L03:
       mov       eax,1
       jmp       near ptr M00_L13
M00_L04:
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       rcx,r13
       mov       rdx,1F08C927000
       mov       rax,[r12+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L06
       mov       rcx,1F08C927000
       call      qword ptr [7FFA06B769B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L17
       mov       rcx,1F08C927000
       call      00007FFA665D28C0
       test      eax,eax
       je        short M00_L07
       mov       rcx,1F08C927000
       call      qword ptr [7FFA068EA400]
       mov       r12d,[rax+8]
       test      r12d,r12d
       jle       short M00_L06
       add       rax,10
M00_L05:
       mov       [rbp-50],rax
       mov       rcx,[rax]
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0B0]
       call      qword ptr [r8+20]
       test      eax,eax
       je        short M00_L07
       mov       rax,[rbp-50]
       add       rax,8
       dec       r12d
       jne       short M00_L05
M00_L06:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L31
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       add       r15,8
M00_L08:
       dec       r14d
       je        near ptr M00_L18
       mov       r13,[rsi+r15]
       mov       r12,[r13]
       mov       rax,offset MT_System.RuntimeType
       mov       [rbp-48],rax
       cmp       r12,rax
       jne       near ptr M00_L28
       mov       rcx,r13
       call      00007FFA66594600
M00_L09:
       test      al,80
       jne       short M00_L07
       mov       rcx,1F08C927000
       cmp       r13,rcx
       je        short M00_L06
       mov       rax,[rbp-48]
       cmp       r12,rax
       jne       near ptr M00_L29
       mov       rdx,r13
M00_L10:
       test      rdx,rdx
       je        near ptr M00_L04
       mov       rax,[rbp-48]
       cmp       [rdx],rax
       jne       near ptr M00_L04
       mov       r12,rdx
       mov       rcx,[r12+18]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       cmp       rcx,rdx
       je        near ptr M00_L30
       mov       rdx,1AFF7800038
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
M00_L11:
       lea       r10d,[r8+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rdx+r10*8]
       mov       r9d,[r10]
       mov       r11,[r10+8]
       and       r9d,0FFFFFFFE
       cmp       r11,rcx
       jne       short M00_L15
       mov       r11,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       xor       r11,[r10+10]
       cmp       r11,1
       ja        short M00_L15
       cmp       r9d,[r10]
       jne       short M00_L16
M00_L12:
       test      r11d,r11d
       jne       near ptr M00_L02
       xor       eax,eax
M00_L13:
       mov       rdx,1F08C927000
       movzx     r12d,al
M00_L14:
       test      r12d,r12d
       je        near ptr M00_L07
       jmp       near ptr M00_L06
M00_L15:
       test      r9d,r9d
       je        short M00_L16
       inc       eax
       add       r8d,eax
       and       r8d,[rdx+4]
       cmp       eax,8
       jl        short M00_L11
M00_L16:
       mov       r11d,2
       jmp       short M00_L12
M00_L17:
       mov       rcx,r13
       mov       rdx,1F08C927000
       call      qword ptr [7FFA07076820]
       mov       r12d,eax
       jmp       short M00_L14
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1AFF7801B08
       mov       r15,[rcx]
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+10]
       test      r14d,r14d
       jle       near ptr M00_L23
       mov       edx,[r15+8]
       mov       r13d,[rsi+10]
       sub       edx,r13d
       cmp       edx,r14d
       jge       short M00_L21
       mov       edx,r13d
       add       edx,r14d
       jo        near ptr M00_L39
       cmp       dword ptr [r15+8],0
       jne       near ptr M00_L24
       mov       ecx,4
M00_L19:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       ecx,r13d
       jl        near ptr M00_L32
       cmp       [r15+8],ecx
       je        short M00_L21
       test      ecx,ecx
       jle       near ptr M00_L34
       mov       edx,ecx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       test      r13d,r13d
       jg        near ptr M00_L33
M00_L20:
       lea       rcx,[rsi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       r8,[rsi+8]
       mov       r9d,[rsi+10]
       mov       rcx,[rdi+8]
       mov       edi,[rdi+10]
       test      rcx,rcx
       je        near ptr M00_L38
       test      r8,r8
       je        near ptr M00_L38
       mov       rdx,[rcx]
       cmp       rdx,[r8]
       jne       near ptr M00_L38
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L38
       mov       eax,edi
       or        eax,r9d
       jl        near ptr M00_L38
       cmp       edi,[rcx+8]
       ja        near ptr M00_L38
       lea       eax,[r9+rdi]
       cmp       eax,[r8+8]
       ja        near ptr M00_L38
       movzx     eax,word ptr [rdx]
       mov       r10d,edi
       imul      r10,rax
       add       rcx,10
       mov       r11,rcx
       mov       ecx,r9d
       imul      rcx,rax
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L37
       cmp       r10,4000
       ja        near ptr M00_L36
       mov       rdx,r11
       mov       r8,r10
       call      00007FFA665C1380
       cmp       dword ptr [7FFA668E3A10],0
       jne       near ptr M00_L35
M00_L22:
       add       [rsi+10],r14d
       inc       dword ptr [rsi+14]
M00_L23:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],rdi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L24:
       mov       ecx,[r15+8]
       add       ecx,ecx
       jmp       near ptr M00_L19
M00_L25:
       call      qword ptr [7FFA06F2E748]
       mov       ecx,49
       mov       rdx,7FFA06D79450
       call      qword ptr [7FFA069AF228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C752A8
       call      qword ptr [7FFA069AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA069AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D79450
       call      qword ptr [7FFA069AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA069AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA07077B88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA07076E50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,1AFF7801B08
       mov       r15,[rcx]
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r13
       mov       rdx,[r12+70]
       call      qword ptr [rdx+18]
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,r13
       mov       rdx,[r12+58]
       call      qword ptr [rdx]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L30:
       mov       r11d,1
       jmp       near ptr M00_L12
M00_L31:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFA069A71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L07
M00_L32:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA06F25D70]
       int       3
M00_L33:
       mov       rcx,r15
       mov       r8d,r13d
       mov       rdx,r12
       call      qword ptr [7FFA069AF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M00_L20
M00_L34:
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFA06F2E100]
       jmp       near ptr M00_L22
M00_L37:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L22
M00_L38:
       mov       [rsp+20],edi
       xor       edx,edx
       mov       [rsp+28],edx
       call      qword ptr [7FFA070754D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L22
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1570
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
       mov       rax,7FFA06B126D8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA665A9620
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M01_L01
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA06B98260
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA665E8210
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M02_L02
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFA06B96F48
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA6650C110
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M02_L05
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA06EACCF0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,7FFA070B4084
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFA070B408C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFA06A86208
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA664B5F50
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M03_L03
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFA070B4080
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFA07076838]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFA070B4088
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
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M05_L01
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      sil
       movzx     esi,sil
M05_L00:
       mov       rcx,7FFA070B1E2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FFA070B1E28
       call      CORINFO_HELP_COUNTPROFILE32
       xor       esi,esi
       jmp       short M05_L00
; Total bytes of code 83
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
       jmp       qword ptr [7FFA06B76EE0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FFA07074648]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFA66628D10
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,1F08C920008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FFA07076CD0]
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
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFA66419D08]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFA663F4008]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M08_L00
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
       je        near ptr M09_L10
       test      rbx,rbx
       je        near ptr M09_L09
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M09_L08
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L07
       cmp       edi,[rsi+8]
       ja        near ptr M09_L06
       cmp       edi,[rbx+8]
       ja        near ptr M09_L05
       mov       edi,edi
       movzx     ebp,word ptr [rcx]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M09_L01
       mov       rcx,7FFA0708FB00
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M09_L04
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA665C1380
       cmp       dword ptr [7FFA668E3A10],0
       jne       short M09_L03
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFA0708FB18
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       je        short M09_L02
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       short M09_L00
M09_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFA06F2E100]
M09_L05:
       mov       rcx,7FFA0708FB04
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L11
M09_L06:
       mov       rcx,7FFA0708FB08
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L11
M09_L07:
       mov       rcx,7FFA0708FB0C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L11
M09_L08:
       mov       rcx,7FFA0708FB10
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L11
M09_L09:
       mov       rcx,7FFA0708FB14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L11
M09_L10:
       xor       esi,esi
       xor       ebp,ebp
       jmp       short M09_L12
M09_L11:
       mov       rcx,7FFA0708FB1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA070754B8]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M09_L12:
       test      rbx,rbx
       jne       short M09_L13
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M09_L14
M09_L13:
       mov       rcx,7FFA0708FB20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA070754B8]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M09_L14:
       mov       rcx,7FFA0708FB24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,r14d
       call      qword ptr [7FFA070754D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M09_L00
; Total bytes of code 457
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M10_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M10_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M10_L02
       test      r8b,18
       je        short M10_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M10_L05
M10_L00:
       test      r8b,4
       je        short M10_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M10_L05
M10_L01:
       test      r8,r8
       je        short M10_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M10_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M10_L05
M10_L02:
       cmp       r8,40
       ja        short M10_L06
M10_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M10_L10
M10_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M10_L05:
       vzeroupper
       ret
M10_L06:
       cmp       r8,800
       ja        near ptr M10_L12
       cmp       r8,100
       jae       short M10_L09
M10_L07:
       mov       r9,r8
       shr       r9,6
M10_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M10_L08
       and       r8,3F
       cmp       r8,10
       ja        short M10_L03
       jmp       short M10_L04
M10_L09:
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
       jmp       short M10_L07
M10_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M10_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M10_L04
M10_L11:
       cmp       rcx,rdx
       jne       short M10_L12
       cmp       [rdx],dl
       jmp       near ptr M10_L05
M10_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA069A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M11_L07
       test      rsi,rsi
       je        near ptr M11_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M11_L00
       mov       rax,[rbx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,1
       test      eax,eax
       cmove     eax,ecx
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       cmp       eax,ecx
       jne       near ptr M11_L08
M11_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M11_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA66405378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M11_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA6641C8F8]
       int       3
M11_L01:
       sub       edi,eax
       js        near ptr M11_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M11_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA66405378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M11_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA6641C8F8]
       int       3
M11_L02:
       sub       ebp,eax
       js        near ptr M11_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M11_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M11_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA66405298]
       test      eax,eax
       jne       near ptr M11_L16
M11_L03:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       je        near ptr M11_L15
       cmp       r8,4000
       ja        near ptr M11_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA66405618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M11_L12
M11_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M11_L13
M11_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M11_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA664071F0]
       int       3
M11_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA664071F0]
       int       3
M11_L08:
       call      qword ptr [7FFA663FE770]
       mov       rbx,rax
       call      qword ptr [7FFA66409D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA66408778]
       mov       rcx,rbx
       call      qword ptr [7FFA663F3FC0]; CORINFO_HELP_THROW
       int       3
M11_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA6641C8E0]
       int       3
M11_L10:
       call      qword ptr [7FFA663FE538]
       mov       rbx,rax
       call      qword ptr [7FFA66408BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFA664071A0]
       mov       rcx,rbx
       call      qword ptr [7FFA663F3FC0]; CORINFO_HELP_THROW
       int       3
M11_L11:
       call      qword ptr [7FFA663FE538]
       mov       r14,rax
       call      qword ptr [7FFA66408BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFA664071A0]
       mov       rcx,r14
       call      qword ptr [7FFA663F3FC0]; CORINFO_HELP_THROW
       int       3
M11_L12:
       call      qword ptr [7FFA663F4040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M11_L04
M11_L13:
       call      qword ptr [7FFA663F4040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M11_L05
M11_L14:
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M11_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA664088E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L04
M11_L16:
       cmp       byte ptr [rsp+78],0
       je        short M11_L17
       call      qword ptr [7FFA663FE560]
       mov       rbx,rax
       call      qword ptr [7FFA66409698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA66407218]
       mov       rcx,rbx
       call      qword ptr [7FFA663F3FC0]; CORINFO_HELP_THROW
       int       3
M11_L17:
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
; Total bytes of code 738
```

