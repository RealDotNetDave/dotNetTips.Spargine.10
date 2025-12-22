## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFCC703ED60]; System.Reflection.Assembly.GetExecutingAssembly()
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
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
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
; Total bytes of code 108
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
       mov       rax,7FFCC6A14AA8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFD2646EF60
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M01_L01
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFCC702ED48]; System.Reflection.Assembly.GetExecutingAssembly()
       test      rax,rax
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rax],rcx
       jne       near ptr M00_L26
       mov       rcx,rax
       call      qword ptr [7FFCC6A05458]; System.Reflection.Assembly.GetTypes()
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
       jne       short M00_L05
       mov       eax,1
       jmp       near ptr M00_L15
M00_L05:
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       mov       r8d,1
       call      qword ptr [7FFCC68AE820]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       jmp       near ptr M00_L15
M00_L06:
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,r13
       mov       rdx,2AB664F7000
       mov       rax,[r12+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L08
       mov       rcx,2AB664F7000
       call      qword ptr [7FFCC68AD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L17
       mov       rcx,2AB664F7000
       call      00007FFD26482C30
       test      eax,eax
       je        short M00_L09
       mov       rcx,2AB664F7000
       call      qword ptr [7FFCC67EA400]
       mov       r12d,[rax+8]
       test      r12d,r12d
       jle       short M00_L08
       add       rax,10
M00_L07:
       mov       [rbp-50],rax
       mov       rcx,[rax]
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0B0]
       call      qword ptr [r8+20]
       test      eax,eax
       je        short M00_L09
       mov       rax,[rbp-50]
       add       rax,8
       dec       r12d
       jne       short M00_L07
M00_L08:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L31
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L09:
       add       r15,8
M00_L10:
       dec       r14d
       je        near ptr M00_L18
       mov       r13,[rsi+r15]
       mov       r12,[r13]
       mov       rax,offset MT_System.RuntimeType
       mov       [rbp-48],rax
       cmp       r12,rax
       jne       near ptr M00_L28
       mov       rcx,r13
       call      00007FFD2645ADD0
M00_L11:
       test      al,80
       jne       short M00_L09
       mov       rcx,2AB664F7000
       cmp       r13,rcx
       je        short M00_L08
       mov       rax,[rbp-48]
       cmp       r12,rax
       jne       near ptr M00_L29
       mov       rdx,r13
M00_L12:
       test      rdx,rdx
       je        near ptr M00_L06
       mov       rax,[rbp-48]
       cmp       [rdx],rax
       jne       near ptr M00_L06
       mov       r12,rdx
       mov       rcx,[r12+18]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       cmp       rcx,rdx
       je        near ptr M00_L30
       mov       rdx,26AD1400038
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
       xor       eax,eax
M00_L15:
       mov       rdx,2AB664F7000
       movzx     r12d,al
M00_L16:
       test      r12d,r12d
       je        near ptr M00_L09
       jmp       near ptr M00_L08
M00_L17:
       mov       rcx,r13
       mov       rdx,2AB664F7000
       call      qword ptr [7FFCC70E68B0]
       mov       r12d,eax
       jmp       short M00_L16
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,26AD1401AF0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+10]
       test      r14d,r14d
       jle       near ptr M00_L23
       mov       r15,[rsi+8]
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
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
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
       mov       rbx,[rbx+18]
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
       call      qword ptr [7FFCC6F7E088]
       mov       ecx,3F
       mov       rdx,7FFCC6DC6880
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DC6880
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC70E7DB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC70E6EE0]
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
       mov       rcx,26AD1401AF0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r13
       mov       rdx,[r12+70]
       call      qword ptr [rdx+18]
       jmp       near ptr M00_L11
M00_L29:
       mov       rcx,r13
       mov       rdx,[r12+58]
       call      qword ptr [rdx]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L30:
       mov       r11d,1
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFCC6A4E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L09
M00_L32:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F75830]
       int       3
M00_L33:
       mov       rcx,r15
       mov       r8d,r13d
       mov       rdx,r12
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M00_L20
M00_L34:
       mov       rcx,26AD1401AF0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFCC6F7DAB8]
       jmp       near ptr M00_L22
M00_L37:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L22
M00_L38:
       mov       [rsp+20],edi
       xor       edx,edx
       mov       [rsp+28],edx
       call      qword ptr [7FFCC70E4E88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L22
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       int       3
; Total bytes of code 1603
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
       mov       rax,7FFCC6A04AA8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFD2646EF60
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M01_L01
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFCC6A063B0
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD264C1FE0
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M02_L02
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFCC6A04438
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD264A3D30
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M02_L05
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFCC6EFC780]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,7FFCC7147DDC
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFCC7147DE4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFCC69B4948
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFD2644DBD0
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M03_L03
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFCC7147DD8
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFCC70E68C8]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFCC7147DE0
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
       mov       rcx,7FFCC7145B64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FFCC7145B60
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
       jmp       qword ptr [7FFCC68AD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FFCC70E4540]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
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
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AB664F0008
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
       call      qword ptr [7FFCC70E6D60]
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
       call      qword ptr [7FFD262FDD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFD262D7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M09_L01
       xor       ebp,ebp
       xor       r14d,r14d
M09_L00:
       test      rbx,rbx
       jne       near ptr M09_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M09_L10
M09_L01:
       test      rbx,rbx
       jne       short M09_L04
       mov       rcx,7FFCC71126F4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L02:
       mov       rcx,7FFCC71126FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M09_L08
       xor       r14d,r14d
M09_L03:
       mov       rbp,rsi
       jmp       short M09_L00
M09_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M09_L05
       mov       rcx,7FFCC71126F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L02
M09_L05:
       cmp       dword ptr [r15+4],18
       je        short M09_L06
       mov       rcx,7FFCC71126EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L02
M09_L06:
       cmp       edi,[rsi+8]
       jbe       short M09_L07
       mov       rcx,7FFCC71126E8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L02
M09_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M09_L13
       mov       rcx,7FFCC71126E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L02
M09_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M09_L03
M09_L09:
       mov       rcx,7FFCC7112700
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M09_L12
       xor       r15d,r15d
M09_L10:
       mov       rcx,7FFCC7112704
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFCC70E4E88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M09_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M09_L10
M09_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M09_L15
       mov       rcx,7FFCC71126E0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M09_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       je        short M09_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L11
M09_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFCC6F7DAB8]
M09_L15:
       mov       rcx,7FFCC71126F8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M09_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M09_L11
M09_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L11
; Total bytes of code 488
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
       ja        short M10_L09
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
       jae       short M10_L10
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M10_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M10_L04
M10_L10:
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
M10_L11:
       cmp       rcx,rdx
       jne       short M10_L12
       cmp       [rdx],dl
       jmp       near ptr M10_L05
M10_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M11_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M11_L08
M11_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M11_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M11_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M11_L01:
       sub       edi,eax
       js        near ptr M11_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M11_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M11_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M11_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M11_L16
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
       jne       short M11_L04
       cmp       r8,14
       jne       near ptr M11_L15
       jmp       near ptr M11_L14
M11_L04:
       cmp       r8,4000
       ja        near ptr M11_L13
       jmp       near ptr M11_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M11_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M11_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M11_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M11_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M11_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M11_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M11_L05
M11_L13:
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
M11_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M11_L05
M11_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L05
M11_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

