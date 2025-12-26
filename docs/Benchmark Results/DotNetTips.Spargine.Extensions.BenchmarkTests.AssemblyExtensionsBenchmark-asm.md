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
       call      qword ptr [7FFF805AEEE0]; System.Reflection.Assembly.GetExecutingAssembly()
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
       mov       rax,7FFF7FF8BEA8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFDFA0EF60
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFFDFD7F778],0
       je        short M01_L01
       call      qword ptr [7FFFDFD6D608]; CORINFO_HELP_STOP_FOR_GC
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
       sub       rsp,28
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       call      qword ptr [7FFF8059EDD8]; System.Reflection.Assembly.GetExecutingAssembly()
       test      rax,rax
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rax],rcx
       jne       near ptr M00_L20
       mov       rcx,rax
       call      qword ptr [7FFF7FF7C858]; System.Reflection.Assembly.GetTypes()
       mov       rsi,rax
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M00_L21
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
       jne       short M00_L05
       mov       r12d,1
       jmp       near ptr M00_L15
M00_L05:
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       mov       r8d,1
       call      qword ptr [7FFF800F4BE8]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r12d,eax
       jmp       near ptr M00_L15
M00_L06:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,r15
       mov       rdx,22833FE7000
       mov       rax,[r13+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L08
       mov       rcx,22833FE7000
       call      qword ptr [7FFF800F69A0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L17
       mov       rcx,22833FE7000
       call      00007FFFDFA22C30
       test      eax,eax
       je        short M00_L09
       mov       rcx,22833FE7000
       call      qword ptr [7FFF7FD6A400]
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
       jbe       near ptr M00_L25
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
       jne       near ptr M00_L22
       mov       rcx,r15
       call      00007FFFDF9FADD0
M00_L11:
       test      al,80
       jne       short M00_L09
       mov       rcx,22833FE7000
       cmp       r15,rcx
       je        short M00_L08
       cmp       r13,r12
       jne       near ptr M00_L23
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
       je        near ptr M00_L24
       mov       rdx,1E79F000038
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
       mov       rdx,22833FE7000
       movzx     r13d,r12b
M00_L16:
       test      r13d,r13d
       je        near ptr M00_L09
       jmp       near ptr M00_L08
M00_L17:
       mov       rcx,r15
       mov       rdx,22833FE7000
       call      qword ptr [7FFF80676A60]
       mov       r13d,eax
       jmp       short M00_L16
M00_L18:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       call      qword ptr [7FFF804EE130]
       mov       ecx,3F
       mov       rdx,7FFF80346880
       call      qword ptr [7FFF7FE2F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF80346880
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF80677F30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF80677198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,1E79F001AF0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,r15
       mov       rax,[r13+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,r15
       mov       rax,[r13+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L12
M00_L24:
       mov       r11d,1
       jmp       near ptr M00_L14
M00_L25:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF7FE271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L09
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 1071
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
       mov       rax,7FFF7FF7BEA8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFDFA0EF60
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFFDFD7F778],0
       je        short M01_L01
       call      qword ptr [7FFFDFD6D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFF8012BBD0
       mov       [rbp-90],rax
       lea       rax,[M02_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFDFA61FE0
       call      rax
M02_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFDFD7F778],0
       je        short M02_L02
       call      qword ptr [7FFFDFD6D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FFF8012A8B8
       mov       [rbp-90],rax
       lea       rax,[M02_L04]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFDFA43D30
       call      rax
M02_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFFDFD7F778],0
       je        short M02_L05
       call      qword ptr [7FFFDFD6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF8046C7B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,7FFF806BA7B4
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FFF806BA7BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FFF7FF34948
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFFDF9EDBD0
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFFDFD7F778],0
       je        short M03_L03
       call      qword ptr [7FFFDFD6D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFF806BA7B0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FFF80676A78]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FFF806BA7B8
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
       mov       rcx,7FFF806B8594
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FFF806B8590
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
       jmp       qword ptr [7FFF800F6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FFF80674690]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFFDFA67B10
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
       call      00007FFFDFA68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22833FE0008
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
       call      qword ptr [7FFF80677120]
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
       call      qword ptr [7FFFDF89DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFFDF877FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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

