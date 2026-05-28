## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L09
       mov       rcx,rsi
       mov       r11,7FFB20470DF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DB04A0],1
       je        near ptr M00_L10
M00_L00:
       mov       rdx,1A395000A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20470DF8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L11
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L12
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L04
       mov       rdx,rsi
       call      qword ptr [7FFB20D07C90]
       jmp       short M00_L05
M00_L04:
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L13
M00_L05:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      qword ptr [7FFB20ADF2E8]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2052F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2052F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2052F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D0C738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D0C750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L08
       call      qword ptr [7FFB2052F570]
       int       3
M00_L08:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D05A28]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L11:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A395000A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L05
M00_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
; Total bytes of code 641
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1E4141A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D0E1C0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20470DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DAFBC0],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,21B3D000A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20470DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ACEFD0]
       mov       ecx,65
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207F5AC0
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D0C1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D0C210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2052F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D05830]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21B3D000A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ACE9A0]
       jmp       near ptr M00_L04
; Total bytes of code 650
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,25BBBFB0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D0E190]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20460DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20D9FC88],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,229C5002A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20460DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ABF000]
       mov       ecx,65
       mov       rdx,7FFB20918D68
       call      qword ptr [7FFB2051F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207E5AC0
       call      qword ptr [7FFB2051F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2051D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20918D68
       call      qword ptr [7FFB2051F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2051D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20CFC1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20CFC210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2051F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20CF5860]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20515728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20515728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,229C5002A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ABE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 650
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,26A59F50008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20CFE208]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20515C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20480DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DBFD88],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,25FA0C00A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20480DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ADEFB8]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D1C210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D1C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2053F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D15740]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25FA0C00A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ADE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 650
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,2A01FC90008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D1E1A8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20490DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DCF470],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,223B0002A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20490DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20AEEFA0]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2C1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2C210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2054F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D25800]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,223B0002A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20AEEE38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 650
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,26445150008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D2E190]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20470DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DB0648],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1A6DC800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20470DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ACEFE8]
       mov       ecx,65
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207F5AC0
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D0C1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D0C210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2052F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D05860]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A6DC800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ACE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 650
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1E75B820008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D0E190]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB204A0F98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20E229B8],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,27F29802AF0
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB204A0FA0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20AFF000]
       mov       ecx,65
       mov       rdx,7FFB20958D68
       call      qword ptr [7FFB2055F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20825AC0
       call      qword ptr [7FFB2055F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2055D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20958D68
       call      qword ptr [7FFB2055F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2055D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20C3D230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20C3D248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2055F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D37E40]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27F29802AF0
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20AFE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 648
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20555818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20555818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,2BFBE5F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D3E970]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20555C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB80159170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20491208
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20E87C28],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1FADEC02AF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20491210
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+30],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20AEEAC0]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20C24D98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20C24DB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M00_L07
       call      qword ptr [7FFB2054F498]
       int       3
M00_L07:
       add       rcx,10
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Span<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20D7DDD0]
       mov       rsi,[rsp+38]
       mov       edi,[rsp+40]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FADEC02AF8
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20B75FC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 648
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,23B73AF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFB20D7E5B0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB80159170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20490DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DD0530],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1AAA3C00A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20490DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20AEEFA0]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2C168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2054F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AAA3C00A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20AEE988]
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1EB22D30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D2E0E8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20470DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DAF4A0],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,27EF9C00A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20470DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ACF000]
       mov       ecx,65
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207F5AC0
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D0C150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D0C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2052F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27EF9C00A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ACE9A0]
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,2BF78BC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D0E0E8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20470DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DAF4A0],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1B34F000A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20470DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ACEFD0]
       mov       ecx,65
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207F5AC0
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D0C150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D0C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2052F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20525728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B34F000A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ACE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1F3CDEC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D0E0E8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20480DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DBF3E0],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1AF32800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20480DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ADF000]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D1C150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D1C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2053F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AF32800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ADE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1EFB18D0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D1E160]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20490DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DCED50],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1AE4C002A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20490DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20AEF000]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2054F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20545728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AE4C002A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20AEE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1EEE0E80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D2E190]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20480DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DBF2F0],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1F957400A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20480DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ADEFA0]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D1C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D1C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2053F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20535728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F957400A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ADE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,239D6480008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20D1E118]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB77185618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFB77174040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20460F98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20DE3628],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1B96CC00AF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20460FA0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ABF000]
       mov       ecx,65
       mov       rdx,7FFB20918D68
       call      qword ptr [7FFB2051F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207E5AC0
       call      qword ptr [7FFB2051F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2051D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20918D68
       call      qword ptr [7FFB2051F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2051D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20BFD218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20BFD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2051F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B96CC00AF8
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ABE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 591
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1F9EBCD0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFB20CFE928]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20515C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB80159170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,rsi
       mov       r11,7FFB20471208
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB20E66D28],1
       je        near ptr M00_L09
M00_L00:
       mov       rdx,1FCE7800B00
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB20471210
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L11
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rsi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       near ptr M00_L12
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFB20ACEAF0]
       mov       ecx,65
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB207F5AC0
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20928D68
       call      qword ptr [7FFB2052F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2052D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20C04DC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20C04DE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,[rax+10]
       mov       rsi,[rax+8]
       cmp       [rsi+8],edi
       jae       short M00_L07
       call      qword ptr [7FFB2052F498]
       int       3
M00_L07:
       add       rsi,10
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L10:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FCE7800B00
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       call      qword ptr [7FFB20ACE9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 591
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,23D665E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFB20D5E538]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFB20525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB80159170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB80159170
       cmp       dword ptr [7FFB804839A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,1EF11400A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207CC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,1EEFB400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],0D4039B21
       mov       dword ptr [rbp-58],0CB726647
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20480D40
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20707750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20480D58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20480D60
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D1FAF8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208AD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20480D38
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2053F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D401D8
       call      qword ptr [7FFB20D15818]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D4AF48
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D16B38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20ADF000]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D1D500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D1D518]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20480D18
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20480D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D161A8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DD5278]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D1FB58]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20480D28
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20480D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EF11400AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20480D50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20480D30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20480D48
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D1FB70]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EF11400AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1EF11400AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E067D0
       xor       edx,edx
       call      qword ptr [7FFB20DD5308]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20480D48
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D1EA90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208A5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D1EAA8]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFB2053FC60]
       int       3
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DAB970
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20DA6598
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207077F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DA65B0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2053F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L54
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L57
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L60
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L89
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L34
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L92
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L95
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L35
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L36
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0CC],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L98
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L154
       mov       [rsp+0C0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L07:
       mov       rax,[rsp+0C0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EEFB401D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B46F90]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0B8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L99
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L50
M08_L10:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FFB20D168B0]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B46F90]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A0],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L11:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L12:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L110
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L14
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L13
M08_L14:
       mov       r11,[rsp+140]
       test      r11b,20
       jne       near ptr M08_L109
M08_L15:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L16:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L19
       cmp       edi,r12d
       jg        near ptr M08_L38
       jmp       short M08_L17
M08_L17:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L17
M08_L18:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       mov       r8d,[rax+8]
       mov       [rsp+0C8],r8d
       test      r8d,r8d
       jle       near ptr M08_L114
       mov       r10d,[rsp+100]
       cmp       r8d,r10d
       jg        near ptr M08_L41
       xor       edx,edx
       jmp       near ptr M08_L22
M08_L19:
       mov       r13,[rsp+150]
       jmp       short M08_L18
       nop       dword ptr [rax]
M08_L20:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       ebp,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       r12d,ecx
       mov       [rbx+r12*4+10],ebp
       mov       [rax],ecx
       inc       ecx
       inc       r10d
       mov       r12d,[rsp+0FC]
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L20
       lea       r11d,[r13+r10-1]
       mov       rax,[rsp+98]
       lea       r10,[rax+rdx*2+10]
       mov       [r10],r13d
       mov       [r10+4],r11d
       mov       r13,[rsp+150]
M08_L21:
       add       rdx,4
       dec       r8d
       je        short M08_L23
M08_L22:
       mov       r9,[rsp+58]
       mov       r11d,[r9+rdx]
       test      r11d,r11d
       jl        short M08_L21
       xor       r10d,r10d
       mov       r13d,ecx
       jmp       near ptr M08_L20
M08_L23:
       mov       rax,[rsp+98]
M08_L24:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A0]
       test      r8,r8
       je        near ptr M08_L136
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L116
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L115
M08_L25:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L117
M08_L26:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+13C]
       cmp       edx,r10d
       jbe       near ptr M08_L27
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A0]
       cmp       [r8+8],edx
       jne       near ptr M08_L118
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L119
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L27:
       mov       rdx,1EEFB400C90
       mov       rdx,[rdx]
       mov       [rsp+38],rdx
       mov       r11,rdx
       mov       [rsp+88],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L132
M08_L28:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L30
       mov       ebp,[rsp+0CC]
       cmp       ebp,edi
       jl        near ptr M08_L43
       xor       ebx,ebx
M08_L29:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L29
M08_L30:
       mov       rbx,[rsp+0B8]
       test      rbx,rbx
       je        near ptr M08_L136
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L137
M08_L31:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L32
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L138
       cmp       edi,ecx
       jae       near ptr M08_L154
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L139
M08_L32:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L151
M08_L33:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L34:
       mov       rcx,rsi
       mov       rdx,7FFB20DAEB60
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L35:
       mov       rdx,7FFB20DF05D8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L36:
       mov       rdx,7FFB20DF0500
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L37:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L38:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L154
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L37
       jmp       near ptr M08_L113
M08_L39:
       mov       rax,[rsp+98]
M08_L40:
       mov       edx,[rsp+14C]
       inc       edx
       cmp       r8d,edx
       jle       near ptr M08_L24
M08_L41:
       cmp       edx,r10d
       jae       near ptr M08_L154
       mov       [rsp+14C],edx
       mov       r11d,edx
       mov       r9,[rsp+58]
       mov       r11d,[r9+r11*4]
       test      r11d,r11d
       jl        short M08_L39
       xor       r8d,r8d
       mov       eax,ecx
M08_L42:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       edx,r11d
       lea       rdx,[r15+rdx*4]
       mov       r13d,[rdx]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r13d
       mov       [rdx],ecx
       inc       ecx
       inc       r8d
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L42
       mov       r13,[rsp+150]
       lea       r11d,[rax+r8-1]
       mov       r8d,[rsp+14C]
       mov       rdx,[rsp+98]
       lea       r8,[rdx+r8*8+10]
       mov       [r8],eax
       mov       [r8+4],r11d
       mov       rax,[rsp+98]
       mov       r8d,[rsp+0C8]
       jmp       near ptr M08_L40
M08_L43:
       cmp       ebx,edi
       jae       near ptr M08_L154
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L154
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L43
       jmp       near ptr M08_L30
M08_L44:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,1EEFB400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0D4039B21
       mov       r8d,0CB726647
       cmp       edx,8
       jb        near ptr M08_L51
       mov       r9d,edx
       shr       r9d,3
M08_L45:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L45
       test      dl,4
       jne       near ptr M08_L52
M08_L46:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L47:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L48:
       mov       r10,[rsp+0A8]
M08_L49:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L10
       mov       ebp,[rsp+0CC]
M08_L50:
       cmp       r12d,edi
       jae       near ptr M08_L154
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B0],r8
       mov       [rsp+0A8],rax
       test      r8,r8
       je        short M08_L53
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       jne       near ptr M08_L44
       mov       rdx,7FFB20DF0508
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L44
M08_L51:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L52:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L46
M08_L53:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L49
M08_L54:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L55
       jmp       short M08_L56
M08_L55:
       mov       rdx,7FFB20DAB7D8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L56:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L57:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L58
       jmp       short M08_L59
M08_L58:
       mov       rdx,7FFB20DAB7E8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L60:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L61
       jmp       short M08_L62
M08_L61:
       mov       rcx,rsi
       mov       rdx,7FFB20DAFA18
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L62:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L63
       mov       rdx,1EEFB400068
       cmp       rdi,[rdx]
       je        short M08_L63
       mov       rdx,1EEFB400070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L63:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208ADA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L67
M08_L64:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L65
       mov       ebx,[rdx+8]
M08_L65:
       cmp       [rdx+8],r14d
       jle       short M08_L66
       mov       r14d,[rdx+8]
M08_L66:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L67:
       cmp       [rbp+8],ecx
       jg        short M08_L64
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DD4C30]
       mov       r13,rax
       test      r13,r13
       je        short M08_L70
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L68
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L68
       jmp       short M08_L69
M08_L68:
       mov       rcx,rsi
       mov       rdx,7FFB20DAFE10
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L70:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,1EEFB400070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DD4C48]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L82
       test      r13d,r13d
       jge       near ptr M08_L76
       test      r14d,r14d
       je        near ptr M08_L73
       test      r12d,r12d
       jne       short M08_L71
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
       jmp       short M08_L72
M08_L71:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
M08_L72:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L73:
       cmp       ebx,1
       je        short M08_L74
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
       jmp       short M08_L75
M08_L74:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
M08_L75:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L76:
       test      r14d,r14d
       je        near ptr M08_L79
       test      r12d,r12d
       jne       short M08_L77
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
       jmp       short M08_L78
M08_L77:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
M08_L78:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L79:
       cmp       ebx,1
       je        short M08_L80
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
       jmp       short M08_L81
M08_L80:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C60]
M08_L81:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L82:
       test      r14d,r14d
       je        short M08_L85
       test      r12d,r12d
       jne       short M08_L83
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C78]
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4C90]
M08_L84:
       jmp       short M08_L86
M08_L85:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DD4CA8]
M08_L86:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L87
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L87
       jmp       short M08_L88
M08_L87:
       mov       rcx,rsi
       mov       rdx,7FFB20DAFE10
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L88:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L89:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L90
       jmp       short M08_L91
M08_L90:
       mov       rcx,rsi
       mov       rdx,7FFB20DAF8F8
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L91:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DD53C8]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L92:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L93
       jmp       short M08_L94
M08_L93:
       mov       rdx,7FFB20DAB7D8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L94:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L95:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L96
       jmp       short M08_L97
M08_L96:
       mov       rdx,7FFB20DAB7E8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L98:
       mov       ecx,28F
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D1DB60]
       int       3
M08_L99:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L48
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L47
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L47
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L48
M08_L105:
       mov       r8,[rsp+0B0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L48
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L11
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L12
M08_L108:
       call      qword ptr [7FFB2070F228]
       int       3
M08_L109:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L15
M08_L110:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L111:
       test      cl,2
       je        short M08_L112
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L112:
       test      cl,1
       je        near ptr M08_L16
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L16
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L18
M08_L114:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L24
M08_L115:
       mov       ecx,7
       call      qword ptr [7FFB20D1DDB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L25
M08_L116:
       jmp       short M08_L115
M08_L117:
       mov       rcx,rdx
       call      qword ptr [7FFB20ADF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L26
M08_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B6EEB0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L119:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L121
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D1FC90]
       mov       r9,rax
M08_L120:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FFB20B6F480]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L128
M08_L121:
       jmp       short M08_L120
M08_L122:
       cmp       eax,[r8+8]
       jae       near ptr M08_L154
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A5DF98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L124
       test      r8d,r8d
       jne       short M08_L125
       xor       edx,edx
       mov       [rax+14],edx
M08_L123:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L124:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L126
       jmp       short M08_L129
M08_L125:
       jmp       short M08_L123
M08_L126:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L127
       xor       ecx,ecx
M08_L127:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L128:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L122
       jmp       short M08_L130
M08_L129:
       mov       edx,1
       jmp       short M08_L131
M08_L130:
       xor       edx,edx
M08_L131:
       mov       eax,edx
       mov       [rsp+134],eax
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L27
M08_L132:
       mov       r8,[rsp+0A0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L28
       mov       rcx,r8
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A0]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FFB20D1F8A0]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L133
       mov       rcx,[rsp+0A0]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A0]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L134
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L135
M08_L133:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L134:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FFB20B6EF28]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L136:
       mov       ecx,2
       call      qword ptr [7FFB2053FD50]
       int       3
M08_L137:
       mov       rcx,r12
       call      qword ptr [7FFB20ADF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L31
M08_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B6EEB0]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L139:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L140
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D1FC90]
M08_L140:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B6F480]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L147
M08_L141:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L154
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A5DF98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L143
       test      r8d,r8d
       jne       short M08_L144
       xor       edx,edx
       mov       [rax+14],edx
M08_L142:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L143:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L145
       jmp       short M08_L148
M08_L144:
       jmp       short M08_L142
M08_L145:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L146
       xor       r15d,r15d
M08_L146:
       mov       eax,[rsp+10C]
       inc       eax
M08_L147:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L141
       jmp       short M08_L149
M08_L148:
       mov       r14d,1
       jmp       short M08_L150
M08_L149:
       xor       r14d,r14d
M08_L150:
       jmp       near ptr M08_L32
M08_L151:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FFB20D1F8A0]
       test      r14d,ebp
       jne       near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L152
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L153
M08_L152:
       mov       ecx,edi
       xor       edx,edx
M08_L153:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B6EF28]
       jmp       near ptr M08_L33
M08_L154:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6096
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22F902B0008
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
       call      qword ptr [7FFB20D1F5B8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DAB7D8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FCA8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DAB7E8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,25E54400A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207DC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,25E3E400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],4618BD0F
       mov       dword ptr [rbp-58],84AB3850
       cmp       r8d,8
       jb        near ptr M00_L20
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L17
M00_L15:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L16:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L15
M00_L17:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L18:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L19:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L20:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L21:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5368]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L22:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L19
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20490D38
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20717750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L21
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20490D50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20490D58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L16
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D2FAF8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L18
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20490D30
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2054F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D506D0
       call      qword ptr [7FFB20D258D8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D5B440
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D26BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20AEF000]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2D398]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2D3B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20490D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20490D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D26268]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DE5278]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D2FB58]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20490D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20490D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25E54400AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20490D48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20490D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D2FB70]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25E54400AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,25E54400AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E165C0
       xor       edx,edx
       call      qword ptr [7FFB20DE5308]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2501
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D2EA60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208B5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D2EA78]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2054FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DBBA08
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L07
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M07_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M07_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L06
M07_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
       mov       eax,0FFFFFFFF
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
M07_L07:
       mov       rdx,7FFB20DB6508
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FFB207177F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M07_L09
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L02
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DB6520
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2054F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0E0],ymm4
       mov       [rsp+190],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L54
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L57
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L60
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L89
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L10
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L92
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L95
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L11
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L12
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0DC],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L98
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L156
       mov       [rsp+0C0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+16C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+16C]
M08_L07:
       mov       rax,[rsp+0C0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25E3E401D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B572C0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0B8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L99
       cmp       [rbx+8],edi
       jb        near ptr M08_L109
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L20
       jmp       near ptr M08_L100
M08_L10:
       mov       rcx,rsi
       mov       rdx,7FFB20DBEC90
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L11:
       mov       rdx,7FFB20E006C8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L12:
       mov       rdx,7FFB20E005F0
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L13:
       mov       rdx,7FFB20E005F8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L14:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L106
       mov       r8,[rsp+0B0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L101
       mov       rcx,25E3E400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L105
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4618BD0F
       mov       r8d,84AB3850
       cmp       edx,8
       jb        near ptr M08_L21
       mov       r9d,edx
       shr       r9d,3
M08_L15:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L15
       test      dl,4
       jne       near ptr M08_L22
M08_L16:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L17:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L18:
       mov       r10,[rsp+0A8]
M08_L19:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L24
       mov       ebp,[rsp+0DC]
M08_L20:
       cmp       r12d,edi
       jae       near ptr M08_L156
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B0],r8
       mov       [rsp+0A8],rax
       test      r8,r8
       je        short M08_L23
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L13
       jmp       near ptr M08_L14
M08_L21:
       cmp       edx,4
       jb        near ptr M08_L102
M08_L22:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L16
       nop       dword ptr [rax]
M08_L23:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L19
M08_L24:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0F0],rcx
       mov       [rsp+0F8],r12d
       lea       rcx,[rsp+0F0]
       xor       edx,edx
       call      qword ptr [7FFB20D26970]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+168],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       r10d,r8d
       mov       [rsp+0D0],r10
       xor       edx,edx
       div       r10
       inc       rax
       mov       [rsp+160],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B572C0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A0],rax
       test      rax,rax
       je        near ptr M08_L107
       mov       edx,[rsp+168]
       cmp       [rax+8],edx
       jb        near ptr M08_L109
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L25:
       mov       [rsp+58],r8
       mov       [rsp+110],r10d
       test      rax,rax
       je        near ptr M08_L108
       mov       edx,r12d
       mov       rcx,[rsp+0D0]
       add       rdx,rcx
       mov       r9d,[rax+8]
       cmp       rdx,r9
       ja        near ptr M08_L109
       lea       r9,[rax+rcx*4+10]
M08_L26:
       mov       [rsp+50],r9
       mov       [rsp+10C],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L111
       lea       r11,[rcx*4]
       mov       [rsp+150],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L28
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L27
M08_L28:
       mov       r11,[rsp+150]
       test      r11b,20
       jne       near ptr M08_L110
M08_L29:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L30:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L114
       cmp       edi,r12d
       jg        near ptr M08_L45
       jmp       short M08_L31
M08_L31:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+160]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L156
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L31
M08_L32:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+110]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       mov       r8d,[rax+8]
       mov       [rsp+0CC],r8d
       test      r8d,r8d
       jle       near ptr M08_L116
       mov       r10d,[rsp+110]
       cmp       r8d,r10d
       jg        near ptr M08_L51
       xor       edx,edx
       jmp       near ptr M08_L48
M08_L33:
       mov       rax,[rsp+98]
M08_L34:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A0]
       test      r8,r8
       je        near ptr M08_L138
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+14C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L118
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L117
M08_L35:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L119
M08_L36:
       xor       ecx,ecx
       mov       dword ptr [rsp+144],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+14C]
       cmp       edx,r10d
       jbe       near ptr M08_L37
       mov       dword ptr [rsp+148],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A0]
       cmp       [r8+8],edx
       jne       near ptr M08_L120
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L121
       mov       rax,[rsp+98]
       mov       ecx,[rsp+148]
       mov       r10d,[rsp+14C]
M08_L37:
       mov       rdx,25E3E400C90
       mov       rdx,[rdx]
       mov       [rsp+38],rdx
       mov       r11,rdx
       mov       [rsp+88],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L134
M08_L38:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L40
       mov       ebp,[rsp+0DC]
       cmp       ebp,edi
       jl        near ptr M08_L53
       xor       ebx,ebx
M08_L39:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L39
M08_L40:
       mov       rbx,[rsp+0B8]
       test      rbx,rbx
       je        near ptr M08_L138
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L139
M08_L41:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L42
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L140
       cmp       edi,ecx
       jae       near ptr M08_L156
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L141
M08_L42:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L153
M08_L43:
       mov       rax,rsi
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L44:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+110]
M08_L45:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+160]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L156
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L156
       mov       ebx,ecx
       mov       [rsp+188],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+188]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+10C]
       jl        short M08_L44
       jmp       near ptr M08_L115
M08_L46:
       cmp       r11d,edi
       jae       near ptr M08_L156
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       ebp,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L156
       mov       r12d,ecx
       mov       [rbx+r12*4+10],ebp
       mov       [rax],ecx
       inc       ecx
       inc       r10d
       mov       r12d,[rsp+10C]
       cmp       r11d,r12d
       jae       near ptr M08_L156
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L46
       lea       r11d,[r13+r10-1]
       mov       rax,[rsp+98]
       lea       r10,[rax+rdx*2+10]
       mov       [r10],r13d
       mov       [r10+4],r11d
       mov       r13,[rsp+160]
M08_L47:
       add       rdx,4
       dec       r8d
       je        near ptr M08_L33
M08_L48:
       mov       r9,[rsp+58]
       mov       r11d,[r9+rdx]
       test      r11d,r11d
       jl        short M08_L47
       xor       r10d,r10d
       mov       r13d,ecx
       jmp       near ptr M08_L46
M08_L49:
       mov       rax,[rsp+98]
M08_L50:
       mov       edx,[rsp+15C]
       inc       edx
       cmp       r8d,edx
       jle       near ptr M08_L34
M08_L51:
       cmp       edx,r10d
       jae       near ptr M08_L156
       mov       [rsp+15C],edx
       mov       r11d,edx
       mov       r9,[rsp+58]
       mov       r11d,[r9+r11*4]
       test      r11d,r11d
       jl        short M08_L49
       xor       r8d,r8d
       mov       edx,ecx
M08_L52:
       cmp       r11d,edi
       jae       near ptr M08_L156
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       r13d,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L156
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r13d
       mov       [rax],ecx
       inc       ecx
       inc       r8d
       cmp       r11d,r12d
       jae       near ptr M08_L156
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L52
       mov       r13,[rsp+160]
       lea       r11d,[rdx+r8-1]
       mov       r8d,[rsp+15C]
       mov       rax,[rsp+98]
       lea       r8,[rax+r8*8+10]
       mov       [r8],edx
       mov       [r8+4],r11d
       mov       rax,[rsp+98]
       mov       r8d,[rsp+0CC]
       jmp       near ptr M08_L50
M08_L53:
       cmp       ebx,edi
       jae       near ptr M08_L156
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L156
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L53
       jmp       near ptr M08_L40
M08_L54:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L55
       jmp       short M08_L56
M08_L55:
       mov       rdx,7FFB20DBB870
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L56:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L57:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L58
       jmp       short M08_L59
M08_L58:
       mov       rdx,7FFB20DBB880
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L60:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L61
       jmp       short M08_L62
M08_L61:
       mov       rcx,rsi
       mov       rdx,7FFB20DBFB48
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L62:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L63
       mov       rdx,25E3E400068
       cmp       rdi,[rdx]
       je        short M08_L63
       mov       rdx,25E3E400070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L63:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208BDA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L67
M08_L64:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L65
       mov       ebx,[rdx+8]
M08_L65:
       cmp       [rdx+8],r14d
       jle       short M08_L66
       mov       r14d,[rdx+8]
M08_L66:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L67:
       cmp       [rbp+8],ecx
       jg        short M08_L64
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DE4C30]
       mov       r13,rax
       test      r13,r13
       je        short M08_L70
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L68
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L68
       jmp       short M08_L69
M08_L68:
       mov       rcx,rsi
       mov       rdx,7FFB20DBFF40
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L70:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0E0],rdx
       mov       [rsp+0E8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0E0]
       mov       r8,25E3E400070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+170]
       mov       r9d,ebx
       call      qword ptr [7FFB20DE4C48]
       mov       ebx,[rsp+178]
       movzx     r14d,byte ptr [rsp+170]
       movzx     r12d,byte ptr [rsp+171]
       mov       r13d,[rsp+174]
       mov       eax,[rsp+17C]
       mov       [rsp+108],eax
       mov       edx,[rsp+180]
       mov       [rsp+104],edx
       test      ebx,ebx
       je        near ptr M08_L82
       test      r13d,r13d
       jge       near ptr M08_L76
       test      r14d,r14d
       je        near ptr M08_L73
       test      r12d,r12d
       jne       short M08_L71
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
       jmp       short M08_L72
M08_L71:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
M08_L72:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L73:
       cmp       ebx,1
       je        short M08_L74
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
       jmp       short M08_L75
M08_L74:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
M08_L75:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L76:
       test      r14d,r14d
       je        near ptr M08_L79
       test      r12d,r12d
       jne       short M08_L77
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
       jmp       short M08_L78
M08_L77:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
M08_L78:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L79:
       cmp       ebx,1
       je        short M08_L80
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
       jmp       short M08_L81
M08_L80:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
M08_L81:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L82:
       test      r14d,r14d
       je        short M08_L85
       test      r12d,r12d
       jne       short M08_L83
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C78]
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C90]
M08_L84:
       jmp       short M08_L86
M08_L85:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4CA8]
M08_L86:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L87
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L87
       jmp       short M08_L88
M08_L87:
       mov       rcx,rsi
       mov       rdx,7FFB20DBFF40
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L88:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L89:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L90
       jmp       short M08_L91
M08_L90:
       mov       rcx,rsi
       mov       rdx,7FFB20DBFA28
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L91:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DE53C8]
       mov       rax,rsi
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L92:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L93
       jmp       short M08_L94
M08_L93:
       mov       rdx,7FFB20DBB870
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L94:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FCA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L95:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L96
       jmp       short M08_L97
M08_L96:
       mov       rdx,7FFB20DBB880
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L98:
       mov       ecx,28F
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D2DB60]
       int       3
M08_L99:
       test      edi,edi
       jne       near ptr M08_L109
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L100:
       jmp       near ptr M08_L24
M08_L101:
       xor       eax,eax
       jmp       near ptr M08_L18
M08_L102:
       mov       r9d,80
       test      dl,1
       je        short M08_L103
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L103:
       test      dl,2
       je        short M08_L104
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L17
M08_L104:
       mov       ecx,r9d
       jmp       near ptr M08_L17
M08_L105:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L18
M08_L106:
       mov       r8,[rsp+0B0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L18
M08_L107:
       mov       edx,[rsp+168]
       test      edx,edx
       jne       short M08_L109
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L25
M08_L108:
       or        edx,r12d
       jne       short M08_L109
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L26
M08_L109:
       call      qword ptr [7FFB2071F228]
       int       3
M08_L110:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L29
M08_L111:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L112
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L112:
       test      cl,2
       je        short M08_L113
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L113:
       test      cl,1
       je        near ptr M08_L30
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L30
M08_L114:
       mov       r13,[rsp+160]
       jmp       near ptr M08_L32
M08_L115:
       mov       r13,[rsp+160]
       jmp       near ptr M08_L32
M08_L116:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L34
M08_L117:
       mov       ecx,7
       call      qword ptr [7FFB20D2DDB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L35
M08_L118:
       jmp       short M08_L117
M08_L119:
       mov       rcx,rdx
       call      qword ptr [7FFB20AEF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L36
M08_L120:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B7EE98]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L121:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+14C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L156
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L123
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D2FC90]
       mov       r9,rax
M08_L122:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FFB20B7F468]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L130
M08_L123:
       jmp       short M08_L122
M08_L124:
       cmp       eax,[r8+8]
       jae       near ptr M08_L156
       mov       [rsp+130],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+128],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A6E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+124],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L126
       test      r8d,r8d
       jne       short M08_L127
       xor       edx,edx
       mov       [rax+14],edx
M08_L125:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+124]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+128],1
M08_L126:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+128],0
       je        short M08_L128
       jmp       short M08_L131
M08_L127:
       jmp       short M08_L125
M08_L128:
       mov       eax,[rsp+130]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L129
       xor       ecx,ecx
M08_L129:
       mov       edx,[rsp+12C]
       inc       edx
       mov       eax,ecx
M08_L130:
       mov       r8,[rsp+70]
       mov       [rsp+12C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L124
       jmp       short M08_L132
M08_L131:
       mov       edx,1
       jmp       short M08_L133
M08_L132:
       xor       edx,edx
M08_L133:
       mov       eax,edx
       mov       [rsp+144],eax
       mov       rax,[rsp+98]
       mov       ecx,[rsp+148]
       mov       r10d,[rsp+14C]
       jmp       near ptr M08_L37
M08_L134:
       mov       r8,[rsp+0A0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+148],ecx
       je        near ptr M08_L38
       mov       rcx,r8
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+140],eax
       mov       rdx,[rsp+0A0]
       mov       r8d,[rdx+8]
       mov       [rsp+13C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+140]
       mov       r9d,[rsp+13C]
       mov       edx,3
       call      qword ptr [7FFB20D2F8A0]
       mov       eax,[rsp+148]
       test      [rsp+144],eax
       jne       short M08_L135
       mov       rcx,[rsp+0A0]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rcx,[rsp+0A0]
       mov       edx,[rcx+8]
       mov       [rsp+134],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+148],0
       jne       short M08_L136
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L137
M08_L135:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L38
M08_L136:
       mov       ecx,[rsp+14C]
       xor       edx,edx
M08_L137:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+138]
       mov       r8d,[rsp+134]
       call      qword ptr [7FFB20B7EF10]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L38
M08_L138:
       mov       ecx,2
       call      qword ptr [7FFB2054FD50]
       int       3
M08_L139:
       mov       rcx,r12
       call      qword ptr [7FFB20AEF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L41
M08_L140:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B7EE98]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L141:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L156
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L142
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D2FC90]
M08_L142:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B7F468]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L149
M08_L143:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L156
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+118],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A6E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L145
       test      r8d,r8d
       jne       short M08_L146
       xor       edx,edx
       mov       [rax+14],edx
M08_L144:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L145:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L147
       jmp       short M08_L150
M08_L146:
       jmp       short M08_L144
M08_L147:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L148
       xor       r15d,r15d
M08_L148:
       mov       eax,[rsp+11C]
       inc       eax
M08_L149:
       mov       [rsp+11C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L143
       jmp       short M08_L151
M08_L150:
       mov       r14d,1
       jmp       short M08_L152
M08_L151:
       xor       r14d,r14d
M08_L152:
       jmp       near ptr M08_L42
M08_L153:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L43
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+120],eax
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+120]
       mov       edx,3
       call      qword ptr [7FFB20D2F8A0]
       test      r14d,ebp
       jne       near ptr M08_L43
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L154
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L155
M08_L154:
       mov       ecx,edi
       xor       edx,edx
M08_L155:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B7EF10]
       jmp       near ptr M08_L43
M08_L156:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6117
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29ED3620008
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
       call      qword ptr [7FFB20D2F5B8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DBB870
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FCA8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DBB880
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,1ABB8000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207DC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,1ABA2000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],35C0504F
       mov       dword ptr [rbp-58],68C5C88A
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF52C0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF52C0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF52C0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20490D38
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20717750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20490D50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20490D58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D1FAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20490D30
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2054F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D2E560
       call      qword ptr [7FFB20D15338]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D49368
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D16658]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20AEEAF0]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D1D968]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D1D980]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20490D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20490D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D15CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DF51D0]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D1FB28]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20490D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20490D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ABB8000AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20490D48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20490D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D1FB40]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ABB8000AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1ABB8000AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E16240
       xor       edx,edx
       call      qword ptr [7FFB20DF5260]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D1EA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208B5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D1EA30]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2054FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DAEEE0
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L07
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M07_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M07_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L06
M07_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
       mov       eax,0FFFFFFFF
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
M07_L07:
       mov       rdx,7FFB20DA9910
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FFB207177F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M07_L09
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L02
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DA9928
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2054F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L39
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L40
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L41
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1ABA2001D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B45908]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L107
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L49
M08_L08:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FFB20D163D0]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B45908]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L105
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L107
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L09:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L106
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L107
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L10:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L12
       nop       dword ptr [rax]
M08_L11:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L11
M08_L12:
       mov       r11,[rsp+140]
       test      r11b,20
       jne       near ptr M08_L108
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L14:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L35
       jmp       short M08_L15
M08_L15:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L15
M08_L16:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       [rsp+0A0],rbx
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L24
       mov       r8d,[rsp+100]
       cmp       [rax+8],r8d
       jg        near ptr M08_L22
       jmp       short M08_L18
M08_L17:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L24
M08_L18:
       mov       r8d,edx
       mov       r10,[rsp+58]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L17
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r11d,ecx
M08_L19:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r12d,r8d
       lea       r12,[r15+r12*4]
       mov       r13d,[r12]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+rbx*4+10],r13d
       mov       [r12],ecx
       inc       ecx
       mov       r12d,[rsp+14C]
       inc       r12d
       cmp       r8d,[rsp+0FC]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       r13,[rsp+50]
       mov       r8d,[r13+r8*4]
       test      r8d,r8d
       mov       [rsp+14C],r12d
       mov       rbx,[rsp+0A0]
       jge       short M08_L19
       mov       r12d,[rsp+0FC]
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L17
M08_L20:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       ebx,r11d
       lea       rbx,[r15+rbx*4]
       mov       r13d,[rbx]
       mov       r8,[rsp+0A0]
       cmp       ecx,[r8+8]
       jae       near ptr M08_L153
       mov       r8d,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+r8*4+10],r13d
       mov       [rbx],ecx
       inc       ecx
       mov       r8d,[rsp+14C]
       inc       r8d
       mov       ebx,[rsp+0FC]
       cmp       r11d,ebx
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+50]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       mov       [rsp+14C],r8d
       jge       short M08_L20
       mov       rbx,r9
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+0FC]
M08_L21:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+98]
       mov       r8d,[rsp+100]
       jle       short M08_L24
M08_L22:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+58]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L21
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r12d,ecx
       jmp       near ptr M08_L20
M08_L23:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L23
       jmp       near ptr M08_L30
M08_L24:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L25:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L26:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       r10d,[rsp+13C]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L27
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L118
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L27:
       mov       r11,1ABA2000C90
       mov       r11,[r11]
       mov       [rsp+38],r11
       mov       rdx,r11
       mov       [rsp+88],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L28:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L30
       cmp       ebp,edi
       jl        near ptr M08_L23
       xor       ebx,ebx
M08_L29:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L29
M08_L30:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L31:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L32
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L32:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L33:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L34:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L35:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L34
       jmp       near ptr M08_L113
M08_L36:
       cmp       edx,4
       jb        near ptr M08_L100
M08_L37:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L45
M08_L38:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L48
M08_L39:
       mov       rcx,rsi
       mov       rdx,7FFB20DE21F8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L40:
       mov       rdx,7FFB20DE3C20
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L41:
       mov       rdx,7FFB20DE3B48
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L42:
       mov       rdx,7FFB20DE3B50
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L43:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L104
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L99
       mov       rcx,1ABA2000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L103
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,35C0504F
       mov       r8d,68C5C88A
       cmp       edx,8
       jb        near ptr M08_L36
       mov       r9d,edx
       shr       r9d,3
M08_L44:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L44
       test      dl,4
       jne       near ptr M08_L37
M08_L45:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L46:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L47:
       mov       r10,[rsp+0B0]
M08_L48:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L08
M08_L49:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        near ptr M08_L38
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L42
       jmp       near ptr M08_L43
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FFB20DAED48
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FC78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FFB20DAED58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FFB20DE30B0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,1ABA2000068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,1ABA2000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208BDA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DF4C00]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FFB20DE34A8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,1ABA2000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DF4C18]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C30]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C48]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C60]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FFB20DF4C78]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FFB20DE34A8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FFB20DE2F90
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DF5320]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FFB20DAED48
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FC78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FFB20DAED58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D1DB18]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L107
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       xor       eax,eax
       jmp       near ptr M08_L47
M08_L100:
       mov       r9d,80
       test      dl,1
       je        short M08_L101
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L101:
       test      dl,2
       je        short M08_L102
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L46
M08_L102:
       mov       ecx,r9d
       jmp       near ptr M08_L46
M08_L103:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L47
M08_L104:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L47
M08_L105:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L107
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L09
M08_L106:
       or        edx,r12d
       jne       short M08_L107
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L10
M08_L107:
       call      qword ptr [7FFB2071F228]
       int       3
M08_L108:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L13
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L14
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L14
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L16
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L16
M08_L114:
       mov       ecx,7
       call      qword ptr [7FFB20D1DD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L25
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FFB20AEEF70]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L26
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B6E9D0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D1FC60]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FFB20B6EFA0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A6DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+134],edx
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L27
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L28
       mov       rcx,r8
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FFB20D1F858]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L133:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FFB20B6EA48]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L135:
       mov       ecx,2
       call      qword ptr [7FFB2054FD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FFB20AEEF70]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L31
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B6E9D0]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D1FC60]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B6EFA0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A6DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+10C]
       inc       eax
M08_L146:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L32
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FFB20D1F858]
       test      r14d,ebp
       jne       near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B6EA48]
       jmp       near ptr M08_L33
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6135
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EC37120008
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
       call      qword ptr [7FFB20D1F570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DAED48
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D1FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DAED58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,2C708800A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207DC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,2C6F2800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],7E097850
       mov       dword ptr [rbp-58],0B40C4C73
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5350]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5350]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE5350]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20490D38
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20717750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20490D50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20490D58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D2FAE0]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20490D30
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2054F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D506D0
       call      qword ptr [7FFB20D258C0]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D5B440
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D26BE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20AEEFB8]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2D548]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2D560]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20490D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20490D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D26250]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DE5290]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D2FC30]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20490D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20490D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C708800AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20490D48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20490D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D2FC48]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C708800AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2C708800AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E17070
       xor       edx,edx
       call      qword ptr [7FFB20DE52F0]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D2EA30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208B5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D2EA48]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2054FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DBC880
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M07_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       cmp       r13d,[rdi+8]
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20DB63F8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207177F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DB6410
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2054F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0E0],ymm4
       mov       [rsp+190],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L54
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L57
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L60
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L89
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L43
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L92
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L95
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L44
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L45
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L98
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L155
       mov       [rsp+0D0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+16C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+16C]
M08_L07:
       mov       rax,[rsp+0D0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2C6F2801D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B569A0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L99
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L53
M08_L10:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0F0],rcx
       mov       [rsp+0F8],r12d
       lea       rcx,[rsp+0F0]
       xor       edx,edx
       call      qword ptr [7FFB20D26958]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+168],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       r10d,r8d
       mov       [rsp+0D8],r10
       xor       edx,edx
       div       r10
       inc       rax
       mov       [rsp+160],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B569A0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0B0],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+168]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L11:
       mov       [rsp+60],r8
       mov       [rsp+110],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       edx,r12d
       mov       rcx,[rsp+0D8]
       add       rdx,rcx
       mov       r9d,[rax+8]
       cmp       rdx,r9
       ja        near ptr M08_L108
       lea       r9,[rax+rcx*4+10]
M08_L12:
       mov       [rsp+58],r9
       mov       [rsp+10C],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L110
       lea       r11,[rcx*4]
       mov       [rsp+150],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L14
       nop       dword ptr [rax]
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L13
M08_L14:
       mov       r11,[rsp+150]
       test      r11b,20
       jne       near ptr M08_L109
M08_L15:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L16:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L113
       cmp       edi,r12d
       jg        near ptr M08_L39
       jmp       short M08_L17
M08_L17:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+160]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L155
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L17
M08_L18:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+0A8],rax
       mov       edx,[rsp+110]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L115
       mov       r8d,[rsp+110]
       cmp       [rax+8],r8d
       jg        near ptr M08_L24
       jmp       short M08_L20
M08_L19:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L27
M08_L20:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L19
       xor       r9d,r9d
       mov       [rsp+15C],r9d
       mov       r11d,ecx
M08_L21:
       cmp       r8d,edi
       jae       near ptr M08_L155
       mov       r12d,r8d
       lea       r12,[r15+r12*4]
       mov       ebx,[r12]
       mov       r13,[rsp+0A8]
       cmp       ecx,[r13+8]
       jae       near ptr M08_L155
       mov       r13d,ecx
       mov       r9,[rsp+0A8]
       mov       [r9+r13*4+10],ebx
       mov       [r12],ecx
       inc       ecx
       mov       r12d,[rsp+15C]
       inc       r12d
       cmp       r8d,[rsp+10C]
       jae       near ptr M08_L155
       mov       r8d,r8d
       mov       rbx,[rsp+58]
       mov       r8d,[rbx+r8*4]
       test      r8d,r8d
       mov       [rsp+15C],r12d
       jge       short M08_L21
       mov       r12d,[rsp+10C]
       mov       r13,[rsp+160]
       mov       r9d,[rsp+15C]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L19
M08_L22:
       mov       rbx,[rsp+0A8]
M08_L23:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+110]
       jle       near ptr M08_L28
M08_L24:
       cmp       edx,r8d
       jae       near ptr M08_L155
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L22
       xor       r9d,r9d
       mov       [rsp+15C],r9d
       mov       r12d,ecx
       jmp       short M08_L25
M08_L25:
       cmp       r11d,edi
       jae       near ptr M08_L155
       mov       ebx,r11d
       lea       rbx,[r15+rbx*4]
       mov       r13d,[rbx]
       mov       r8,[rsp+0A8]
       cmp       ecx,[r8+8]
       jae       near ptr M08_L155
       mov       r8d,ecx
       mov       r9,[rsp+0A8]
       mov       [r9+r8*4+10],r13d
       mov       [rbx],ecx
       inc       ecx
       mov       r8d,[rsp+15C]
       inc       r8d
       mov       ebx,[rsp+10C]
       cmp       r11d,ebx
       jae       near ptr M08_L155
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       mov       [rsp+15C],r8d
       jge       short M08_L25
       mov       rbx,r9
       mov       r13,[rsp+160]
       mov       r9d,[rsp+15C]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+10C]
       jmp       near ptr M08_L23
M08_L26:
       cmp       ebx,edi
       jae       near ptr M08_L155
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L155
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L26
       jmp       near ptr M08_L34
M08_L27:
       mov       rbx,[rsp+0A8]
M08_L28:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0B0]
       test      r8,r8
       je        near ptr M08_L137
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+14C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L117
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L116
M08_L29:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L118
M08_L30:
       xor       ecx,ecx
       mov       dword ptr [rsp+144],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+14C]
       cmp       edx,r10d
       jbe       near ptr M08_L31
       mov       dword ptr [rsp+148],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0B0]
       cmp       [r8+8],edx
       jne       near ptr M08_L119
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L120
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+148]
       mov       r10d,[rsp+14C]
M08_L31:
       mov       rdx,2C6F2800C90
       mov       rdx,[rdx]
       mov       [rsp+40],rdx
       mov       r11,rdx
       mov       [rsp+90],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L133
M08_L32:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L34
       cmp       ebp,edi
       jl        near ptr M08_L26
       xor       ebx,ebx
M08_L33:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L33
M08_L34:
       mov       rbx,[rsp+0C8]
       test      rbx,rbx
       je        near ptr M08_L137
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L138
M08_L35:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L36
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L139
       cmp       edi,ecx
       jae       near ptr M08_L155
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L140
M08_L36:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L152
M08_L37:
       mov       rax,rsi
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L38:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+110]
M08_L39:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+160]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L155
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L155
       mov       ebx,ecx
       mov       [rsp+188],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+188]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+10C]
       jl        short M08_L38
       jmp       near ptr M08_L114
M08_L40:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L41:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L49
M08_L42:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L52
M08_L43:
       mov       rcx,rsi
       mov       rdx,7FFB20DBE318
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L44:
       mov       rdx,7FFB20DBFD40
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L45:
       mov       rdx,7FFB20DBFC68
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L46:
       mov       rdx,7FFB20DBFC70
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L47:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0C0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,2C6F2800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7E097850
       mov       r8d,0B40C4C73
       cmp       edx,8
       jb        near ptr M08_L40
       mov       r9d,edx
       shr       r9d,3
M08_L48:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L48
       test      dl,4
       jne       near ptr M08_L41
M08_L49:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L50:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L51:
       mov       r10,[rsp+0B8]
M08_L52:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L10
M08_L53:
       cmp       r12d,edi
       jae       near ptr M08_L155
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0C0],r8
       mov       [rsp+0B8],rax
       test      r8,r8
       je        near ptr M08_L42
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L46
       jmp       near ptr M08_L47
M08_L54:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L55
       jmp       short M08_L56
M08_L55:
       mov       rdx,7FFB20DBC6E8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L56:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L57:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L58
       jmp       short M08_L59
M08_L58:
       mov       rdx,7FFB20DBC6F8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L60:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L61
       jmp       short M08_L62
M08_L61:
       mov       rcx,rsi
       mov       rdx,7FFB20DBF1D0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L62:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L63
       mov       rdx,2C6F2800068
       cmp       rdi,[rdx]
       je        short M08_L63
       mov       rdx,2C6F2800070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L63:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208BDA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L67
M08_L64:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L65
       mov       ebx,[rdx+8]
M08_L65:
       cmp       [rdx+8],r14d
       jle       short M08_L66
       mov       r14d,[rdx+8]
M08_L66:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L67:
       cmp       [rbp+8],ecx
       jg        short M08_L64
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DE4BE8]
       mov       r13,rax
       test      r13,r13
       je        short M08_L70
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L68
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L68
       jmp       short M08_L69
M08_L68:
       mov       rcx,rsi
       mov       rdx,7FFB20DBF5C8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L70:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0E0],rdx
       mov       [rsp+0E8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0E0]
       mov       r8,2C6F2800070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+170]
       mov       r9d,ebx
       call      qword ptr [7FFB20DE4C00]
       mov       ebx,[rsp+178]
       movzx     r14d,byte ptr [rsp+170]
       movzx     r12d,byte ptr [rsp+171]
       mov       r13d,[rsp+174]
       mov       eax,[rsp+17C]
       mov       [rsp+108],eax
       mov       edx,[rsp+180]
       mov       [rsp+104],edx
       test      ebx,ebx
       je        near ptr M08_L82
       test      r13d,r13d
       jge       near ptr M08_L76
       test      r14d,r14d
       je        near ptr M08_L73
       test      r12d,r12d
       jne       short M08_L71
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
       jmp       short M08_L72
M08_L71:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
M08_L72:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L73:
       cmp       ebx,1
       je        short M08_L74
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
       jmp       short M08_L75
M08_L74:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
M08_L75:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L76:
       test      r14d,r14d
       je        near ptr M08_L79
       test      r12d,r12d
       jne       short M08_L77
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
       jmp       short M08_L78
M08_L77:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
M08_L78:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L79:
       cmp       ebx,1
       je        short M08_L80
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
       jmp       short M08_L81
M08_L80:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+104]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C18]
M08_L81:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L82:
       test      r14d,r14d
       je        short M08_L85
       test      r12d,r12d
       jne       short M08_L83
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C30]
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C48]
M08_L84:
       jmp       short M08_L86
M08_L85:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+104]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+108]
       call      qword ptr [7FFB20DE4C60]
M08_L86:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L87
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L87
       jmp       short M08_L88
M08_L87:
       mov       rcx,rsi
       mov       rdx,7FFB20DBF5C8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L88:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L89:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L90
       jmp       short M08_L91
M08_L90:
       mov       rcx,rsi
       mov       rdx,7FFB20DBF0B0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L91:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DE53B0]
       mov       rax,rsi
       vzeroupper
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L92:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L93
       jmp       short M08_L94
M08_L93:
       mov       rdx,7FFB20DBC6E8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L94:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L95:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L96
       jmp       short M08_L97
M08_L96:
       mov       rdx,7FFB20DBC6F8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L98:
       mov       ecx,28F
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D2DB30]
       int       3
M08_L99:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L51
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L50
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L50
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L51
M08_L105:
       mov       r8,[rsp+0C0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L51
M08_L106:
       mov       edx,[rsp+168]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L11
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L12
M08_L108:
       call      qword ptr [7FFB2071F228]
       int       3
M08_L109:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L15
M08_L110:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L111:
       test      cl,2
       je        short M08_L112
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L112:
       test      cl,1
       je        near ptr M08_L16
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L16
M08_L113:
       mov       r13,[rsp+160]
       jmp       near ptr M08_L18
M08_L114:
       mov       r13,[rsp+160]
       jmp       near ptr M08_L18
M08_L115:
       mov       rbx,[rsp+0A8]
       jmp       near ptr M08_L28
M08_L116:
       mov       ecx,7
       call      qword ptr [7FFB20D2DD88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L29
M08_L117:
       jmp       short M08_L116
M08_L118:
       mov       rcx,rdx
       call      qword ptr [7FFB20AEF438]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L30
M08_L119:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B7EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L120:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+14C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L155
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L122
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D2FC18]
       mov       r9,rax
M08_L121:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FFB20B7F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L129
M08_L122:
       jmp       short M08_L121
M08_L123:
       cmp       eax,[r8+8]
       jae       near ptr M08_L155
       mov       [rsp+130],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+128],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A6E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+124],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L125
       test      r8d,r8d
       jne       short M08_L126
       xor       edx,edx
       mov       [rax+14],edx
M08_L124:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+124]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+128],1
M08_L125:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+128],0
       je        short M08_L127
       jmp       short M08_L130
M08_L126:
       jmp       short M08_L124
M08_L127:
       mov       eax,[rsp+130]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L128
       xor       ecx,ecx
M08_L128:
       mov       edx,[rsp+12C]
       inc       edx
       mov       eax,ecx
M08_L129:
       mov       r8,[rsp+78]
       mov       [rsp+12C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L123
       jmp       short M08_L131
M08_L130:
       mov       edx,1
       jmp       short M08_L132
M08_L131:
       xor       edx,edx
M08_L132:
       mov       eax,edx
       mov       [rsp+144],eax
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+148]
       mov       r10d,[rsp+14C]
       jmp       near ptr M08_L31
M08_L133:
       mov       r8,[rsp+0B0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+148],ecx
       je        near ptr M08_L32
       mov       rcx,r8
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+140],eax
       mov       rdx,[rsp+0B0]
       mov       r8d,[rdx+8]
       mov       [rsp+13C],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+140]
       mov       r9d,[rsp+13C]
       mov       edx,3
       call      qword ptr [7FFB20D2F870]
       mov       eax,[rsp+148]
       test      [rsp+144],eax
       jne       short M08_L134
       mov       rcx,[rsp+0B0]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rcx,[rsp+0B0]
       mov       edx,[rcx+8]
       mov       [rsp+134],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+148],0
       jne       short M08_L135
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L136
M08_L134:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L32
M08_L135:
       mov       ecx,[rsp+14C]
       xor       edx,edx
M08_L136:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+138]
       mov       r8d,[rsp+134]
       call      qword ptr [7FFB20B7EEE0]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L32
M08_L137:
       mov       ecx,2
       call      qword ptr [7FFB2054FD50]
       int       3
M08_L138:
       mov       rcx,r12
       call      qword ptr [7FFB20AEF438]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L35
M08_L139:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B7EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L140:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L155
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L141
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D2FC18]
M08_L141:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B7F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L148
M08_L142:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L155
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+118],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A6E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L144
       test      r8d,r8d
       jne       short M08_L145
       xor       edx,edx
       mov       [rax+14],edx
M08_L143:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L144:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L146
       jmp       short M08_L149
M08_L145:
       jmp       short M08_L143
M08_L146:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L147
       xor       r15d,r15d
M08_L147:
       mov       eax,[rsp+11C]
       inc       eax
M08_L148:
       mov       [rsp+11C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L142
       jmp       short M08_L150
M08_L149:
       mov       r14d,1
       jmp       short M08_L151
M08_L150:
       xor       r14d,r14d
M08_L151:
       jmp       near ptr M08_L36
M08_L152:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L37
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+120],eax
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+120]
       mov       edx,3
       call      qword ptr [7FFB20D2F870]
       test      r14d,ebp
       jne       near ptr M08_L37
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L153
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L154
M08_L153:
       mov       ecx,edi
       xor       edx,edx
M08_L154:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B7EEE0]
       jmp       near ptr M08_L37
M08_L155:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6186
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,307876D0008
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
       call      qword ptr [7FFB20D2F588]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DBC6E8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC60]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DBC6F8
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,27A96000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20555A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207EC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,27A80000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],6D7820D2
       mov       dword ptr [rbp-58],0F99543CA
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF5338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF5338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DF5338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB204A0D30
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20727750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB204A0D48
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB204A0D50
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D3FAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208CD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20727810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB204A0D28
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2055F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D606D0
       call      qword ptr [7FFB20D35920]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D6B440
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D36C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20AFF000]
       mov       ecx,65
       mov       rdx,7FFB20958D68
       call      qword ptr [7FFB2055F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20825AC0
       call      qword ptr [7FFB2055F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2055D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20958D68
       call      qword ptr [7FFB2055F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2055D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D3D5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D3D5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB204A0D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB204A0D00
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D362B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DF5278]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D3FC00]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB204A0D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB204A0D10
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27A96000AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB204A0D40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB204A0D20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB204A0D38
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D3FC18]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27A96000AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,27A96000AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E27020
       xor       edx,edx
       call      qword ptr [7FFB20DF52D8]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB204A0D38
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D3EA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208C5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D3EA30]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2055FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20555A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DCC5B8
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20DC61C0
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207277F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DC61D8
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2055F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L52
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L55
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L58
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L87
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L90
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L93
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L09
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L10
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L96
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L51
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27A80001D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B66E88]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L97
       cmp       [rbx+8],edi
       jb        near ptr M08_L107
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L18
       jmp       near ptr M08_L98
M08_L08:
       mov       rcx,rsi
       mov       rdx,7FFB20DCE008
       call      qword ptr [7FFB2055F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       mov       rdx,7FFB20DCFA30
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L10:
       mov       rdx,7FFB20DCF958
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,7FFB20DCF960
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L12:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L104
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L99
       mov       rcx,27A80000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L103
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6D7820D2
       mov       r8d,0F99543CA
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L13:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L13
       test      dl,4
       jne       near ptr M08_L20
M08_L14:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L15:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L16:
       mov       r10,[rsp+0B0]
M08_L17:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L18:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L11
       jmp       near ptr M08_L12
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L100
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L14
       nop
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L17
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FFB20D369B8]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B66E88]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L105
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L107
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L106
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L107
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       jne       near ptr M08_L108
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L39:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L118
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       r11,27A80000C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L46
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L46:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L113
M08_L50:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L51:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L50
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
       jmp       short M08_L50
M08_L52:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L53
       jmp       short M08_L54
M08_L53:
       mov       rdx,7FFB20DCC420
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L54:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D3FC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L55:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L56
       jmp       short M08_L57
M08_L56:
       mov       rdx,7FFB20DCC430
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L58:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20727810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L59
       jmp       short M08_L60
M08_L59:
       mov       rcx,rsi
       mov       rdx,7FFB20DCEEC0
       call      qword ptr [7FFB2055F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L60:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L61
       mov       rdx,27A80000068
       cmp       rdi,[rdx]
       je        short M08_L61
       mov       rdx,27A80000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L61:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208CDA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L65
M08_L62:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L63
       mov       ebx,[rdx+8]
M08_L63:
       cmp       [rdx+8],r14d
       jle       short M08_L64
       mov       r14d,[rdx+8]
M08_L64:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L65:
       cmp       [rbp+8],ecx
       jg        short M08_L62
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DF4BD0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L68
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L66
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L66
       jmp       short M08_L67
M08_L66:
       mov       rcx,rsi
       mov       rdx,7FFB20DCF2B8
       call      qword ptr [7FFB2055F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L67:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L68:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,27A80000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DF4BE8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L80
       test      r13d,r13d
       jge       near ptr M08_L74
       test      r14d,r14d
       je        near ptr M08_L71
       test      r12d,r12d
       jne       short M08_L69
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
       jmp       short M08_L70
M08_L69:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
M08_L70:
       mov       r13,r14
       jmp       near ptr M08_L84
M08_L71:
       cmp       ebx,1
       je        short M08_L72
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
       jmp       short M08_L73
M08_L72:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
M08_L73:
       mov       r13,r12
       jmp       near ptr M08_L84
M08_L74:
       test      r14d,r14d
       je        near ptr M08_L77
       test      r12d,r12d
       jne       short M08_L75
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
       jmp       short M08_L76
M08_L75:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
M08_L76:
       mov       r13,r14
       jmp       near ptr M08_L84
M08_L77:
       cmp       ebx,1
       je        short M08_L78
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
       jmp       short M08_L79
M08_L78:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C00]
M08_L79:
       mov       r13,r12
       jmp       near ptr M08_L84
M08_L80:
       test      r14d,r14d
       je        short M08_L83
       test      r12d,r12d
       jne       short M08_L81
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C18]
       jmp       short M08_L82
M08_L81:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C30]
M08_L82:
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF4C48]
M08_L84:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L85
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L85
       jmp       short M08_L86
M08_L85:
       mov       rcx,rsi
       mov       rdx,7FFB20DCF2B8
       call      qword ptr [7FFB2055F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L86:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L87:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L88
       jmp       short M08_L89
M08_L88:
       mov       rcx,rsi
       mov       rdx,7FFB20DCEDA0
       call      qword ptr [7FFB2055F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L89:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DF5398]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L91
       jmp       short M08_L92
M08_L91:
       mov       rdx,7FFB20DCC420
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L92:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D3FC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L93:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L94
       jmp       short M08_L95
M08_L94:
       mov       rdx,7FFB20DCC430
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L95:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L96:
       mov       ecx,28F
       mov       rdx,7FFB20494000
       call      qword ptr [7FFB2055F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D3DB18]
       int       3
M08_L97:
       test      edi,edi
       jne       near ptr M08_L107
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L98:
       jmp       near ptr M08_L22
M08_L99:
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L100:
       mov       r9d,80
       test      dl,1
       je        short M08_L101
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L101:
       test      dl,2
       je        short M08_L102
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L102:
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L103:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L16
M08_L104:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L16
M08_L105:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L107
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L106:
       or        edx,r12d
       jne       short M08_L107
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L107:
       call      qword ptr [7FFB2072F228]
       int       3
M08_L108:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L27
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       ecx,7
       call      qword ptr [7FFB20D3DD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L39
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FFB20AFF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L40
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B8EEB0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20494000
       call      qword ptr [7FFB2055F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208C7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D3FBE8]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FFB20B8F480]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A7E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FFB20556820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FFB20D3F858]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L133:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FFB20B8EF28]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L135:
       mov       ecx,2
       call      qword ptr [7FFB2055FD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FFB20AFF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B8EEB0]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20494000
       call      qword ptr [7FFB2055F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208C7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D3FBE8]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B8F480]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A7E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FFB20556820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+114]
       inc       eax
M08_L146:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L46
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FFB20D3F858]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2097D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B8EF28]
       jmp       near ptr M08_L47
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6085
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20555818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20555818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A007B0008
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
       call      qword ptr [7FFB20D3F570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DCC420
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D3FC30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205558D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DCC430
       call      qword ptr [7FFB2055F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20555C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,1B89C802A18
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207DC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,1B89C800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],6105AEFC
       mov       dword ptr [rbp-58],85EAE488
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DE52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20490D50
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20717750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20490D68
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20490D70
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20D2FAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20490D48
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2054F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D501D8
       call      qword ptr [7FFB20D257E8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D5AF48
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D26B08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20AEEFA0]
       mov       ecx,65
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20815AC0
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20948D68
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2054D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20D2D5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20D2D5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20490D28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20490D20
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D26178]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DE5200]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20D2FB28]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20490D38
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20490D30
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B89C802AC0
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20490D60
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20490D40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20490D58
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20D2FB40]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B89C802AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1B89C802AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E167D0
       xor       edx,edx
       call      qword ptr [7FFB20DE5290]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20490D58
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D2EA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208B5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D2EA30]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2054FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20545A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DBBCF0
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20DB6538
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207177F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DB6550
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2054F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L18
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L08
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L09
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1B89C801D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B569D8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L17
       jmp       near ptr M08_L99
M08_L08:
       mov       rdx,7FFB20DBEF18
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
       nop       dword ptr [rax]
M08_L09:
       mov       rdx,7FFB20DBEE40
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L10:
       mov       rdx,7FFB20DBEE48
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L11:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,1B89C800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6105AEFC
       mov       r8d,85EAE488
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L12:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L12
       test      dl,4
       jne       near ptr M08_L20
M08_L13:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L14:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L15:
       mov       r10,[rsp+0B0]
M08_L16:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L17:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L10
       jmp       near ptr M08_L11
M08_L18:
       mov       rcx,rsi
       mov       rdx,7FFB20DBD4F0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L13
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FFB20D26880]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B569D8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L27
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L39:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L118
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       r11,1B89C800C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L46
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L46:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L113
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FFB20DBBB58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FFB20DBBB68
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20717810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FFB20DBE3A8
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,1B89C800068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,1B89C800070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208BDA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DE45A0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FFB20DBE7A0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,1B89C800070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DE45B8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45D0]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE45E8]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE4600]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DE4618]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FFB20DBE7A0
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FFB20DBE288
       call      qword ptr [7FFB2054F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DE5218]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FFB20DBBB58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FFB20DBBB68
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D2DB18]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       jmp       near ptr M08_L22
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L15
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L15
M08_L105:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L15
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L108:
       call      qword ptr [7FFB2071F228]
       int       3
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       ecx,7
       call      qword ptr [7FFB20D2DD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L39
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FFB20AEF420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L40
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B7EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20D2FBB8]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FFB20B7F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A6DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FFB20D2F858]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L133:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FFB20B7EEE0]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L135:
       mov       ecx,2
       call      qword ptr [7FFB2054FD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FFB20AEF420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B7EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20484000
       call      qword ptr [7FFB2054F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208B7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20D2FBB8]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B7F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A6DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FFB20546820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+114]
       inc       eax
M08_L146:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L46
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FFB20D2F858]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2096D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B7EEE0]
       jmp       near ptr M08_L47
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6079
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20545818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F931880008
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
       call      qword ptr [7FFB20D2F570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DBBB58
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20D2FC30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205458D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DBBB68
       call      qword ptr [7FFB2054F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20545C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,1DE13000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207CC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,1DDFD000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],0D2F6393E
       mov       dword ptr [rbp-58],89CF7927
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD6058]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD6058]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFB20DD6058]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB20480F58
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20707750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20480F70
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20480F78
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FFB20DD4840]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208AD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FFB20480F50
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FFB2053F498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FFB20D49F80
       call      qword ptr [7FFB20D176F0]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFB20D65250
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D1CA20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FFB20ADF000]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20C1D260]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20C1D278]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FFB20480F30
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FFB20480F28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FFB20D1C090]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DD5F98]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20DD4918]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FFB20480F40
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB20480F38
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DE13000B28
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB20480F68
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFB20480F48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFB20480F60
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20DD4930]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DE13000B30
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1DE13000B30
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FFB20E1AB80
       xor       edx,edx
       call      qword ptr [7FFB20DD5FF8]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FFB20480F60
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20D1EAA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208A5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20D1EAC0]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FFB2053FC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20DF8CE8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20DB8140
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207077F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20DB8158
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2053F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L18
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L08
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L09
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1DDFD001D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FFB20B46F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L17
       jmp       near ptr M08_L99
M08_L08:
       mov       rdx,7FFB20DFC918
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
       nop       dword ptr [rax]
M08_L09:
       mov       rdx,7FFB20DFC840
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L10:
       mov       rdx,7FFB20DFC848
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L11:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,1DDFD000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0D2F6393E
       mov       r8d,89CF7927
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L12:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L12
       test      dl,4
       jne       near ptr M08_L20
M08_L13:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L14:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L15:
       mov       r10,[rsp+0B0]
M08_L16:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L17:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L10
       jmp       near ptr M08_L11
M08_L18:
       mov       rcx,rsi
       mov       rdx,7FFB20DFAEF0
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L13
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FFB20D1C798]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B46F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L27
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L39:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L118
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       r11,1DDFD000C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L46
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L46:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L113
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FFB20DF8B50
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DD4A38]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FFB20DF8B60
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FFB20DFBDA8
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,1DDFD000068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,1DDFD000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208ADA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DD59B0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FFB20DFC1A0
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,1DDFD000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DD59C8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59E0]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD59F8]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD5A10]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DD5A28]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FFB20DFC1A0
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FFB20DFBC88
       call      qword ptr [7FFB2053F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DD60B8]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FFB20DF8B50
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DD4A38]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FFB20DF8B60
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFB20D1DBA8]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       jmp       near ptr M08_L22
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L15
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L15
M08_L105:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L15
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L108:
       call      qword ptr [7FFB2070F228]
       int       3
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       ecx,7
       call      qword ptr [7FFB20D1DE00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L39
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FFB20ADF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L40
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B6EF10]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20DD48D0]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FFB20B6F4E0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A5E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FFB20D1F390]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L133:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FFB20B6EF88]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L135:
       mov       ecx,2
       call      qword ptr [7FFB2053FD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FFB20ADF480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B6EF10]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20DD48D0]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B6F4E0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A5E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+114]
       inc       eax
M08_L146:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L46
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FFB20D1F390]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B6EF88]
       jmp       near ptr M08_L47
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6079
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
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21E92140008
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
       call      qword ptr [7FFB20D1FD08]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20DF8B50
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DD4A38]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB205358D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20DF8B60
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-68],xmm4
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L43
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L45
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L44
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L56
       mov       rdx,21C11000AC8
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L46
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L47
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L48
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L50
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L49
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,7FFB204812F8
       call      qword ptr [r11]
       mov       rcx,rax
M00_L06:
       mov       [rbp-70],rcx
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-70]
       cmp       [rcx],rdx
       jne       near ptr M00_L35
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFB207CC150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L31
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,21BFB000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L30
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       dword ptr [rbp-48],3D8E1FE7
       mov       dword ptr [rbp-50],0E5D0857
       cmp       edx,8
       jb        near ptr M00_L18
       mov       r8d,edx
       shr       r8d,3
M00_L11:
       mov       r10d,[rbp-48]
       add       r10d,[rcx]
       mov       [rbp-48],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-48]
       mov       r11d,[rbp-50]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-48],r9d
       mov       [rbp-50],r11d
       add       r10d,[rbp-48]
       mov       [rbp-48],r10d
       mov       r10d,[rbp-48]
       mov       r9d,[rbp-50]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-48],r10d
       mov       [rbp-50],r9d
       add       rcx,8
       dec       r8d
       jne       short M00_L11
       test      dl,4
       jne       near ptr M00_L19
M00_L12:
       mov       r8d,edx
       and       r8,7
       mov       ecx,[rcx+r8-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L13:
       add       ecx,[rbp-48]
       mov       [rbp-48],ecx
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-50]
       call      qword ptr [7FFB20DF6430]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-50]
       call      qword ptr [7FFB20DF6430]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-50]
       xor       eax,[rbp-48]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-80],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L33
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L37
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-78],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-80]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-80]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L34
M00_L18:
       cmp       edx,4
       jb        near ptr M00_L27
M00_L19:
       mov       r8d,[rbp-48]
       add       r8d,[rcx]
       mov       [rbp-48],r8d
       mov       r8d,[rbp-48]
       mov       r10d,[rbp-50]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       mov       [rbp-48],r8d
       mov       [rbp-50],r10d
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L37
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-88],r9
       cmp       [r9+8],eax
       je        near ptr M00_L32
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L36
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L37
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FFB204812E8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-70]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFB20707750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       mov       r8d,80
       test      dl,1
       je        short M00_L28
       mov       r8d,edx
       and       r8,2
       movzx     r8d,byte ptr [rcx+r8]
       or        r8d,8000
M00_L28:
       test      dl,2
       je        short M00_L29
       shl       r8d,10
       movzx     ecx,word ptr [rcx]
       or        r8d,ecx
       mov       ecx,r8d
       jmp       near ptr M00_L13
M00_L29:
       mov       ecx,r8d
       jmp       near ptr M00_L13
M00_L30:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FFB20481300
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L32:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FFB20481308
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-88]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L33:
       mov       rcx,r15
       call      qword ptr [7FFB20DF4C18]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L37
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-80],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L34:
       mov       r14,[rbp-78]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFB208AD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L35:
       mov       r11,7FFB204812E0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L36:
       call      qword ptr [7FFB2053F498]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       near ptr M00_L52
M00_L39:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L40
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L53
M00_L40:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L54
       xor       esi,esi
M00_L41:
       test      rsi,rsi
       jne       short M00_L42
       mov       rdx,r15
       mov       rcx,7FFB20DC72C8
       call      qword ptr [7FFB20D5DDA0]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L42:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFB20DD2040
       cmp       [rcx],ecx
       call      qword ptr [7FFB20D5F0A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L43:
       call      qword ptr [7FFB20ADEFA0]
       mov       ecx,65
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB20805AC0
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB20938D68
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2053D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20C14E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB20C14E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       r11,7FFB204812C0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L45:
       mov       rcx,rsi
       mov       r11,7FFB204812B8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L41
M00_L47:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L40
       mov       rcx,r15
       call      qword ptr [7FFB20D5E730]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L40
       jmp       near ptr M00_L02
M00_L48:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB20DF6370]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFB20DF4D50]
       jmp       near ptr M00_L40
M00_L49:
       mov       r11,7FFB204812D0
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L50:
       mov       rcx,rsi
       mov       r11,7FFB204812C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB204812D8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L06
M00_L52:
       mov       rcx,rax
       mov       r11,7FFB204812F0
       call      qword ptr [r11]
       jmp       near ptr M00_L39
M00_L53:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFB20DF4D68]
       jmp       near ptr M00_L40
M00_L54:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21C11000B30
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L55
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L55:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,21C11000B30
       mov       rsi,[rdx]
       jmp       near ptr M00_L41
M00_L56:
       xor       r8d,r8d
       mov       [rbp-68],r8
       mov       [rbp-60],r8d
       lea       r8,[rbp-68]
       mov       rcx,7FFB20EBE5D8
       xor       edx,edx
       call      qword ptr [7FFB20DF63D0]
       mov       rsi,rax
       jmp       near ptr M00_L42
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L57
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M00_L57
       mov       rcx,rax
       mov       r11,7FFB204812F0
       call      qword ptr [r11]
M00_L57:
       nop
       add       rsp,28
       ret
; Total bytes of code 2372
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB76510B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20C1F318]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB208A5E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB20C1F330]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFB2053FC60]
       int       3
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFB20535A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,7FFB20E91348
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFB77177EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB77174088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB771852F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB77181B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB771774F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB77183730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB77174090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB77173FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB77179150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FFB77173FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_BenchmarkDotNet.Characteristics.Characteristic<System.Int32>
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFB80159590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFB20D71DA0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFB207077F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFB20D71DB8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFB2053F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L62
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L65
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L94
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L09
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L97
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L100
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L10
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M08_L11
       mov       rcx,rax
M08_L05:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       [rsp+0D4],edi
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       xor       r14d,r14d
       mov       r15d,edi
       test      r15d,r15d
       jl        near ptr M08_L103
       mov       r13,[rbx+10]
       xor       r12d,r12d
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L58
M08_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M08_L12
       mov       rcx,rax
M08_L07:
       mov       edx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21BFB001D88
       mov       r15,[rcx]
       mov       [rsp+48],r15
       mov       rcx,r15
       mov       edx,edi
       call      qword ptr [7FFB20B46990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       r14d,edi
       test      rbx,rbx
       je        near ptr M08_L104
       cmp       [rbx+8],r14d
       jb        near ptr M08_L114
       lea       r13,[rbx+10]
M08_L08:
       xor       r12d,r12d
       cmp       edi,r12d
       jg        near ptr M08_L20
       jmp       near ptr M08_L105
M08_L09:
       mov       rcx,rsi
       mov       rdx,7FFB20E92BA8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L10:
       mov       rdx,7FFB20E945C8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L11:
       mov       rdx,7FFB20E944F0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L05
M08_L12:
       mov       rdx,7FFB20E944F0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L07
M08_L13:
       mov       rdx,7FFB20E944F8
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L14:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L111
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L106
       mov       rcx,21BFB000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L110
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,3D8E1FE7
       mov       r8d,0E5D0857
       cmp       edx,8
       jb        near ptr M08_L21
       mov       r9d,edx
       shr       r9d,3
M08_L15:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L15
       test      dl,4
       jne       near ptr M08_L22
M08_L16:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L17:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L18:
       mov       r10,[rsp+0B0]
M08_L19:
       mov       [r10],eax
       inc       r12d
       cmp       edi,r12d
       jle       near ptr M08_L24
       mov       edi,[rsp+0D4]
M08_L20:
       cmp       r12d,r14d
       jae       near ptr M08_L156
       lea       rax,[r13+r12*4]
       mov       r8,[rbp+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L23
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L13
       jmp       near ptr M08_L14
M08_L21:
       cmp       edx,4
       jb        near ptr M08_L107
M08_L22:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L16
       xchg      ax,ax
M08_L23:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L19
M08_L24:
       mov       rcx,r13
       mov       r12d,r14d
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FFB20D5EE38]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       r10d,r8d
       mov       [rsp+0C8],r10
       xor       edx,edx
       div       r10
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r15
       lea       edx,[r8+r12]
       call      qword ptr [7FFB20B46990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L112
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L114
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L25:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L113
       mov       edx,r12d
       mov       rcx,[rsp+0C8]
       add       rdx,rcx
       mov       r9d,[rax+8]
       cmp       rdx,r9
       ja        near ptr M08_L114
       lea       r9,[rax+rcx*4+10]
M08_L26:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L32
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r15d,r15d
       cmp       rcx,10
       jb        short M08_L28
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r15],ymm0
       vmovups   [r8+r15+20],ymm0
       add       r15,40
       cmp       r15,r11
       jb        short M08_L27
M08_L28:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L29
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r15],ymm0
M08_L29:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L30:
       xor       ecx,ecx
       test      r14d,r14d
       jle       near ptr M08_L115
       cmp       r14d,r12d
       jg        near ptr M08_L37
M08_L31:
       mov       r11d,ecx
       mov       r11d,[r13+r11*4]
       mov       r15,[rsp+150]
       imul      r11,r15
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L156
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,r14d
       jge       short M08_L35
       jmp       short M08_L31
M08_L32:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L33
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L33:
       test      cl,2
       je        short M08_L34
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L34:
       test      cl,1
       je        near ptr M08_L30
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L30
M08_L35:
       mov       edx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L42
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L53
       jmp       near ptr M08_L41
M08_L36:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L37:
       mov       r11d,ecx
       mov       r11d,[r13+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L156
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L156
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,r14d
       mov       r12d,[rsp+104]
       jl        short M08_L36
       jmp       near ptr M08_L116
M08_L38:
       xor       r9d,r9d
       mov       r11d,ecx
M08_L39:
       cmp       r8d,r14d
       jae       near ptr M08_L156
       mov       r15d,r8d
       lea       r15,[r13+r15*4]
       mov       r12d,[r15]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L156
       mov       edi,ecx
       mov       [rbx+rdi*4+10],r12d
       mov       [r15],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L156
       mov       r8d,r8d
       mov       rdi,[rsp+58]
       mov       r8d,[rdi+r8*4]
       test      r8d,r8d
       jge       short M08_L39
       mov       r12d,[rsp+104]
       mov       r15,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
M08_L40:
       inc       edx
       cmp       [rax+8],edx
       jle       short M08_L42
M08_L41:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L40
       jmp       near ptr M08_L38
M08_L42:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L138
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L118
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L117
M08_L43:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L119
M08_L44:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+144]
       cmp       edx,r10d
       jbe       near ptr M08_L45
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L120
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L121
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L45:
       mov       rdx,21BFB000C90
       mov       rdx,[rdx]
       mov       [rsp+40],rdx
       mov       r11,rdx
       mov       [rsp+90],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L134
M08_L46:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r15
       xor       ebx,ebx
       test      r14d,r14d
       jle       short M08_L48
       mov       edi,[rsp+0D4]
       cmp       edi,r14d
       jl        near ptr M08_L55
       xor       ebx,ebx
M08_L47:
       mov       r15d,[rbx+r13]
       mov       rcx,[rsi+18]
       mov       r8,[rbp+rbx*2+10]
       movsxd    rdx,r15d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       r14d
       jne       short M08_L47
M08_L48:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L138
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L139
M08_L49:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L50
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L140
       cmp       edi,ecx
       jae       near ptr M08_L156
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L141
M08_L50:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L153
M08_L51:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L52:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L42
M08_L53:
       cmp       edx,r8d
       jae       near ptr M08_L156
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L52
       xor       r9d,r9d
       mov       r12d,ecx
M08_L54:
       cmp       r11d,r14d
       jae       near ptr M08_L156
       mov       r15d,r11d
       lea       r15,[r13+r15*4]
       mov       r8d,[r15]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L156
       mov       edi,ecx
       mov       [rbx+rdi*4+10],r8d
       mov       [r15],ecx
       inc       ecx
       inc       r9d
       mov       edi,[rsp+104]
       cmp       r11d,edi
       jae       near ptr M08_L156
       mov       r11d,r11d
       mov       r15,[rsp+58]
       mov       r11d,[r15+r11*4]
       test      r11d,r11d
       jge       short M08_L54
       mov       r15,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L52
M08_L55:
       cmp       ebx,r14d
       jae       near ptr M08_L156
       mov       ecx,ebx
       mov       r15d,[r13+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,edi
       jae       near ptr M08_L156
       mov       r8d,ebx
       mov       r8,[rbp+r8*8+10]
       movsxd    rdx,r15d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,r14d
       jl        short M08_L55
       jmp       near ptr M08_L48
M08_L56:
       lea       edx,[r14+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r14d
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r15d
       mov       r14d,[rsp+15C]
M08_L57:
       inc       r12d
       cmp       r12d,[rbx+28]
       jge       near ptr M08_L06
M08_L58:
       test      r15d,r15d
       je        near ptr M08_L06
       cmp       r12d,[r13+8]
       jae       near ptr M08_L156
       mov       r8,r12
       shl       r8,4
       lea       r8,[r13+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L57
       jmp       short M08_L56
M08_L59:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rdx,7FFB20E911B0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L61:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DF4D80]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L62:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L63
       jmp       short M08_L64
M08_L63:
       mov       rdx,7FFB20E911C0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L64:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L65:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB20707810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L66
       jmp       short M08_L67
M08_L66:
       mov       rcx,rsi
       mov       rdx,7FFB20E93A60
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L68
       mov       rdx,21BFB000068
       cmp       rdi,[rdx]
       je        short M08_L68
       mov       rdx,21BFB000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L68:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFB208ADA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L72
M08_L69:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L70
       mov       ebx,[rdx+8]
M08_L70:
       cmp       [rdx+8],r14d
       jle       short M08_L71
       mov       r14d,[rdx+8]
M08_L71:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L72:
       cmp       [rbp+8],ecx
       jg        short M08_L69
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FFB20DF5D10]
       mov       r13,rax
       test      r13,r13
       je        short M08_L75
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L73
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L73
       jmp       short M08_L74
M08_L73:
       mov       rcx,rsi
       mov       rdx,7FFB20E93E58
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L74:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L75:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,21BFB000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FFB20DF5D28]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L87
       test      r13d,r13d
       jge       near ptr M08_L81
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L91
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L91
M08_L81:
       test      r14d,r14d
       je        near ptr M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
M08_L83:
       mov       r13,r14
       jmp       near ptr M08_L91
M08_L84:
       cmp       ebx,1
       je        short M08_L85
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
       jmp       short M08_L86
M08_L85:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D40]
M08_L86:
       mov       r13,r12
       jmp       near ptr M08_L91
M08_L87:
       test      r14d,r14d
       je        short M08_L90
       test      r12d,r12d
       jne       short M08_L88
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D58]
       jmp       short M08_L89
M08_L88:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D70]
M08_L89:
       jmp       short M08_L91
M08_L90:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FFB20DF5D88]
M08_L91:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L92
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rcx,rsi
       mov       rdx,7FFB20E93E58
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L93:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L94:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rcx,rsi
       mov       rdx,7FFB20E93940
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L96:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB20DF6490]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L97:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L98
       jmp       short M08_L99
M08_L98:
       mov       rdx,7FFB20E911B0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L99:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DF4D80]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L100:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L101
       jmp       short M08_L102
M08_L101:
       mov       rdx,7FFB20E911C0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L102:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L103:
       mov       ecx,28F
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB20C153B0]
       int       3
M08_L104:
       test      r14d,r14d
       jne       near ptr M08_L114
       xor       r13d,r13d
       xor       r14d,r14d
       jmp       near ptr M08_L08
M08_L105:
       jmp       near ptr M08_L24
M08_L106:
       xor       eax,eax
       jmp       near ptr M08_L18
M08_L107:
       mov       r9d,80
       test      dl,1
       je        short M08_L108
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L108:
       test      dl,2
       je        short M08_L109
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L17
M08_L109:
       mov       ecx,r9d
       jmp       near ptr M08_L17
M08_L110:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L18
M08_L111:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L18
M08_L112:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L114
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L25
M08_L113:
       or        edx,r12d
       jne       short M08_L114
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L26
M08_L114:
       call      qword ptr [7FFB2070F228]
       int       3
M08_L115:
       mov       r15,[rsp+150]
       jmp       near ptr M08_L35
M08_L116:
       mov       r15,[rsp+150]
       jmp       near ptr M08_L35
M08_L117:
       mov       ecx,7
       call      qword ptr [7FFB20C15680]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L43
M08_L118:
       jmp       short M08_L117
M08_L119:
       mov       rcx,rdx
       call      qword ptr [7FFB20ADF420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L44
M08_L120:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB20B6EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L121:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L156
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L123
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FFB20DF4CA8]
       mov       r9,rax
M08_L122:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FFB20B6F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L130
M08_L123:
       jmp       short M08_L122
M08_L124:
       cmp       eax,[r8+8]
       jae       near ptr M08_L156
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FFB20A5E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L126
       test      r8d,r8d
       jne       short M08_L127
       xor       edx,edx
       mov       [rax+14],edx
M08_L125:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L126:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L128
       jmp       short M08_L131
M08_L127:
       jmp       short M08_L125
M08_L128:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L129
       xor       ecx,ecx
M08_L129:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L130:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L124
       jmp       short M08_L132
M08_L131:
       mov       edx,1
       jmp       short M08_L133
M08_L132:
       xor       edx,edx
M08_L133:
       mov       eax,edx
       mov       [rsp+13C],eax
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L45
M08_L134:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L46
       mov       rcx,r8
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FFB20C16928]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L135
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L136
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L137
M08_L135:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L46
M08_L136:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L137:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FFB20B6EEE0]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L46
M08_L138:
       mov       ecx,2
       call      qword ptr [7FFB2053FD50]
       int       3
M08_L139:
       mov       rcx,r12
       call      qword ptr [7FFB20ADF420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L49
M08_L140:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB20B6EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FFB20474000
       call      qword ptr [7FFB2053F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFB208A7D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L141:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L156
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L142
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFB20DF4CA8]
M08_L142:
       mov       r14,[rax+8]
       call      qword ptr [7FFB20B6F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L149
M08_L143:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L156
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB20A5E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L145
       test      r8d,r8d
       jne       short M08_L146
       xor       edx,edx
       mov       [rax+14],edx
M08_L144:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L145:
       mov       rcx,rax
       call      qword ptr [7FFB20536820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L147
       jmp       short M08_L150
M08_L146:
       jmp       short M08_L144
M08_L147:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L148
       xor       r15d,r15d
M08_L148:
       mov       eax,[rsp+114]
       inc       eax
M08_L149:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L143
       jmp       short M08_L151
M08_L150:
       mov       r14d,1
       jmp       short M08_L152
M08_L151:
       xor       r14d,r14d
M08_L152:
       jmp       near ptr M08_L50
M08_L153:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L51
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FFB20C16928]
       test      r14d,ebp
       jne       near ptr M08_L51
       mov       rcx,rbx
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FFB2095D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L154
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L155
M08_L154:
       mov       ecx,edi
       xor       edx,edx
M08_L155:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFB20B6EEE0]
       jmp       near ptr M08_L51
M08_L156:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6126
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
       je        near ptr M10_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L00
       test      rbx,rbx
       je        near ptr M10_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M10_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB801C9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB20535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       test      rbx,rbx
       je        short M10_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L02
M10_L01:
       mov       rax,25C8FE80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       call      qword ptr [7FFB20D5FA50]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FFB20E911B0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFB20DF4D80]
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FFB20E911C0
       call      qword ptr [7FFB2053F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 204
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB20535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

