## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L32
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L20
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L19
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L29
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L25
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L06
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L06
M00_L02:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L14
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L15
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L08
       test      r15,r15
       je        near ptr M00_L09
       test      rdx,rdx
       je        near ptr M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L09
       add       r15,0C
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       test      eax,eax
       je        near ptr M00_L02
       jmp       near ptr M00_L13
M00_L04:
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L15
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L12
       test      r15,r15
       je        near ptr M00_L11
       test      rdx,rdx
       je        near ptr M00_L11
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L11
       lea       r8,[r15+0C]
       mov       r10,r8
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       test      eax,eax
       jne       near ptr M00_L13
M00_L06:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       short M00_L10
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L14
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        near ptr M00_L04
M00_L07:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L16
M00_L08:
       mov       edx,1
       mov       eax,edx
       jmp       near ptr M00_L03
M00_L09:
       xor       edx,edx
       mov       eax,edx
       jmp       near ptr M00_L03
M00_L10:
       mov       r11,7FFB6D240FF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D241000
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L05
M00_L11:
       xor       r11d,r11d
       mov       eax,r11d
       jmp       near ptr M00_L05
M00_L12:
       mov       r11d,1
       mov       eax,r11d
       jmp       near ptr M00_L05
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L31
M00_L14:
       call      qword ptr [7FFB6D51C9C0]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       rbx,rsi
       jne       near ptr M00_L30
M00_L17:
       xor       edi,edi
M00_L18:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L24
       add       rsi,10
       jmp       short M00_L21
M00_L20:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L17
M00_L22:
       mov       rdx,[rsi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L22
       jmp       short M00_L17
M00_L23:
       mov       edi,1
       jmp       short M00_L18
M00_L24:
       call      qword ptr [7FFB6D51C2A0]
       int       3
M00_L25:
       mov       rcx,r11
       mov       r11,7FFB6D241010
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24D8B800A88
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D241018
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24D8B800A88
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFB6D240FF0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D241008
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L31:
       call      M00_L33
       nop
       mov       edi,[rbp-2C]
       jmp       near ptr M00_L18
M00_L32:
       xor       edi,edi
       jmp       near ptr M00_L18
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L34
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L34
       mov       r11,7FFB6D241008
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1090
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L03
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        short M01_L01
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L08
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        near ptr M01_L07
M01_L00:
       xor       eax,eax
       vzeroupper
       ret
M01_L01:
       cmp       r8,10
       jae       near ptr M01_L09
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L02:
       vzeroupper
       ret
M01_L03:
       cmp       r8,4
       jae       short M01_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L04:
       test      r8b,1
       je        short M01_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L07:
       add       rax,20
       cmp       r8,rax
       jbe       short M01_L08
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M01_L00
       jmp       short M01_L07
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L00
       jmp       short M01_L12
M01_L09:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L00
M01_L10:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L11
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L00
       jmp       short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L00
M01_L12:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 357
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L02
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L02
       add       r8,0C
       mov       rax,r8
       add       ecx,ecx
       mov       r8d,ecx
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       nop
       add       rsp,28
       ret
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 82
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
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L28
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L24
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L09
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L09
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       jmp       short M00_L04
M00_L03:
       mov       edx,1
M00_L04:
       test      edx,edx
       jne       near ptr M00_L12
M00_L05:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L10
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L02
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L04
M00_L06:
       xor       edx,edx
       jmp       short M00_L08
M00_L07:
       mov       edx,1
M00_L08:
       test      edx,edx
       jne       near ptr M00_L12
M00_L09:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L11
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L10
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L07
       test      r15,r15
       je        near ptr M00_L06
       test      rdx,rdx
       je        near ptr M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L06
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L15
M00_L11:
       mov       r11,7FFB6D260F30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D260F38
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L12:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L30
M00_L13:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       rbx,rsi
       jne       near ptr M00_L29
M00_L16:
       xor       edi,edi
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L23
       add       rsi,10
       jmp       short M00_L20
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[rsi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L17
M00_L23:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L24:
       mov       rcx,r11
       mov       r11,7FFB6D260F48
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15C42801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFB6D260F50
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15C42801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D260F40
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       call      M00_L32
       nop
       mov       edi,[rbp-2C]
       jmp       near ptr M00_L17
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L17
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L33
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D260F40
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1074
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L02
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        near ptr M01_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L08
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L07
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,4
       jae       short M01_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L03:
       test      r8b,1
       je        short M01_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L06
M01_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L06:
       vzeroupper
       ret
M01_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M01_L00
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M01_L01
       jmp       short M01_L12
M01_L09:
       cmp       r8,10
       jb        short M01_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
M01_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L12:
       mov       eax,1
       vzeroupper
       ret
M01_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L00:
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       add       rsp,28
       ret
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L28
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L24
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L09
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L09
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       jmp       short M00_L04
M00_L03:
       mov       edx,1
M00_L04:
       test      edx,edx
       jne       near ptr M00_L12
M00_L05:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L10
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L02
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L04
M00_L06:
       xor       edx,edx
       jmp       short M00_L08
M00_L07:
       mov       edx,1
M00_L08:
       test      edx,edx
       jne       near ptr M00_L12
M00_L09:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L11
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L10
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L07
       test      r15,r15
       je        near ptr M00_L06
       test      rdx,rdx
       je        near ptr M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L06
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L15
M00_L11:
       mov       r11,7FFB6D240F48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D240F50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L12:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L30
M00_L13:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       rbx,rsi
       jne       near ptr M00_L29
M00_L16:
       xor       edi,edi
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L23
       add       rsi,10
       jmp       short M00_L20
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[rsi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L17
M00_L23:
       call      qword ptr [7FFB6D517A08]
       int       3
M00_L24:
       mov       rcx,r11
       mov       r11,7FFB6D240F60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D485801FE0
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFB6D240F68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D485801FE0
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB6D240F40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D240F58
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       call      M00_L32
       nop
       mov       edi,[rbp-2C]
       jmp       near ptr M00_L17
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L17
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L33
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D240F58
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1074
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L02
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        near ptr M01_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L08
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L07
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,4
       jae       short M01_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L03:
       test      r8b,1
       je        short M01_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L06
M01_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L06:
       vzeroupper
       ret
M01_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M01_L00
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M01_L01
       jmp       short M01_L12
M01_L09:
       cmp       r8,10
       jb        short M01_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
M01_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L12:
       mov       eax,1
       vzeroupper
       ret
M01_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D2FFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L00:
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       add       rsp,28
       ret
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L28
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L24
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L27
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L26
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L08
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       jmp       short M00_L04
M00_L03:
       mov       edx,1
M00_L04:
       test      edx,edx
       jne       near ptr M00_L12
M00_L05:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L10
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L02
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L04
M00_L06:
       mov       edx,1
M00_L07:
       test      edx,edx
       jne       near ptr M00_L12
M00_L08:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L11
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L10
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L06
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L07
M00_L09:
       xor       edx,edx
       jmp       near ptr M00_L07
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L15
M00_L11:
       mov       r11,7FFB6D260DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D260DA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L07
M00_L12:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L30
M00_L13:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       rbx,rsi
       jne       near ptr M00_L29
M00_L16:
       xor       edi,edi
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L23
       add       rsi,10
       jmp       short M00_L20
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[rsi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       edi,1
       jmp       short M00_L17
M00_L23:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L24:
       mov       rcx,r11
       mov       r11,7FFB6D260DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F86401FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFB6D260DC0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F86401FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB6D260D98
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D260DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       call      M00_L32
       nop
       mov       edi,[rbp-2C]
       jmp       near ptr M00_L17
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L17
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L33
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D260DB0
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1065
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L02
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        near ptr M01_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L08
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L07
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,4
       jae       short M01_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L03:
       test      r8b,1
       je        short M01_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L06
M01_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L06:
       vzeroupper
       ret
M01_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M01_L00
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M01_L01
       jmp       short M01_L12
M01_L09:
       cmp       r8,10
       jb        short M01_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
M01_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L12:
       mov       eax,1
       vzeroupper
       ret
M01_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L00:
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       add       rsp,28
       ret
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L29
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L25
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L10
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       jmp       short M00_L04
M00_L03:
       mov       edx,1
M00_L04:
       test      edx,edx
       jne       near ptr M00_L06
M00_L05:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L11
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L02
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D32FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L04
M00_L06:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L15
M00_L07:
       xor       edx,edx
       jmp       short M00_L09
M00_L08:
       mov       edx,1
M00_L09:
       test      edx,edx
       jne       short M00_L06
M00_L10:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L12
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L11
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L08
       test      r15,r15
       je        near ptr M00_L07
       test      rdx,rdx
       je        near ptr M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D32FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L09
M00_L11:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L17
M00_L12:
       mov       r11,7FFB6D270DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L17
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D270DA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L09
M00_L13:
       call      qword ptr [7FFB6D54C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       call      M00_L32
       nop
       mov       edi,[rbp-2C]
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L17:
       cmp       rbx,rsi
       je        short M00_L22
       jmp       near ptr M00_L30
M00_L18:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L24
       add       rsi,10
       jmp       short M00_L20
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       test      edi,edi
       jle       short M00_L22
       xor       ebx,ebx
M00_L21:
       mov       rdx,[rsi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       add       rbx,8
       dec       edi
       jne       short M00_L21
M00_L22:
       xor       edi,edi
       jmp       short M00_L16
M00_L23:
       mov       edi,1
       jmp       short M00_L16
M00_L24:
       call      qword ptr [7FFB6D547A08]
       int       3
M00_L25:
       mov       rcx,r11
       mov       r11,7FFB6D270DB8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B537401FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D270DC0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D325728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B537401FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFB6D270D98
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D270DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L33
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D270DB0
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1068
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L02
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        near ptr M01_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L08
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L07
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,4
       jae       short M01_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L03:
       test      r8b,1
       je        short M01_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L06
M01_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L06:
       vzeroupper
       ret
M01_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M01_L00
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M01_L01
       jmp       short M01_L12
M01_L09:
       cmp       r8,10
       jb        short M01_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
M01_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L12:
       mov       eax,1
       vzeroupper
       ret
M01_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D32FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L00:
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       add       rsp,28
       ret
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],r11
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       je        near ptr M00_L18
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L29
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L25
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L10
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       jmp       short M00_L04
M00_L03:
       mov       edx,1
M00_L04:
       test      edx,edx
       jne       near ptr M00_L06
M00_L05:
       mov       rcx,[rbp-38]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L11
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L02
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D2EFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L04
M00_L06:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L15
M00_L07:
       xor       edx,edx
       jmp       short M00_L09
M00_L08:
       mov       edx,1
M00_L09:
       test      edx,edx
       jne       short M00_L06
M00_L10:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L12
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L11
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L08
       test      r15,r15
       je        near ptr M00_L07
       test      rdx,rdx
       je        near ptr M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D2EFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,eax
       jmp       near ptr M00_L09
M00_L11:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L17
M00_L12:
       mov       r11,7FFB6D230F40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L17
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D230F48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L09
M00_L13:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       call      M00_L32
       nop
       mov       edi,[rbp-2C]
M00_L16:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L17:
       cmp       rbx,rsi
       je        short M00_L22
       jmp       near ptr M00_L30
M00_L18:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L24
       add       rsi,10
       jmp       short M00_L20
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       test      edi,edi
       jle       short M00_L22
       xor       ebx,ebx
M00_L21:
       mov       rdx,[rsi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       add       rbx,8
       dec       edi
       jne       short M00_L21
M00_L22:
       xor       edi,edi
       jmp       short M00_L16
M00_L23:
       mov       edi,1
       jmp       short M00_L16
M00_L24:
       call      qword ptr [7FFB6D507A08]
       int       3
M00_L25:
       mov       rcx,r11
       mov       r11,7FFB6D230F58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29D67802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D230F60
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB6D2E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29D67802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFB6D230F38
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D230F50
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L33
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D230F50
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1068
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L02
       cmp       rcx,rdx
       je        near ptr M01_L12
       cmp       r8,20
       jb        near ptr M01_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L08
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L07
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,4
       jae       short M01_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L03:
       test      r8b,1
       je        short M01_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L06
M01_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L06:
       vzeroupper
       ret
M01_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M01_L00
M01_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M01_L01
       jmp       short M01_L12
M01_L09:
       cmp       r8,10
       jb        short M01_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L11
M01_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L12:
       mov       eax,1
       vzeroupper
       ret
M01_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D2EFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L00:
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       add       rsp,28
       ret
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L31
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rsi
       je        near ptr M00_L17
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L29
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L25
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-40],rsi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L08
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L08
       jmp       short M00_L04
M00_L02:
       mov       r13d,1
M00_L03:
       test      r13d,r13d
       jne       near ptr M00_L11
M00_L04:
       mov       rcx,[rbp-40]
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L13
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L10
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L02
       test      r15,r15
       je        short M00_L05
       test      rdx,rdx
       je        short M00_L05
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L05
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D30FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       near ptr M00_L03
M00_L05:
       xor       r13d,r13d
       jmp       near ptr M00_L03
M00_L06:
       mov       r13d,1
M00_L07:
       test      r13d,r13d
       jne       near ptr M00_L11
M00_L08:
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       jne       near ptr M00_L12
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       r8,rdx
       mov       r10d,[rdi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L13
       mov       edx,[rdi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L10
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L14
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L06
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r10,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D30FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L09:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L10:
       xor       edx,edx
       mov       [rdi+8],rdx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L16
M00_L11:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L15
M00_L12:
       mov       r11,7FFB6D2511C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D2511D0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L13:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       call      M00_L32
       nop
       mov       edi,[rbp-34]
       jmp       short M00_L23
M00_L16:
       cmp       rbx,rsi
       je        short M00_L22
       jmp       near ptr M00_L30
M00_L17:
       mov       edi,[rbx+10]
       mov       rsi,[rbx+8]
       cmp       [rsi+8],edi
       jb        short M00_L18
       add       rsi,10
       jmp       short M00_L20
M00_L18:
       call      qword ptr [7FFB6D527A08]
       int       3
M00_L19:
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       test      edi,edi
       jle       short M00_L22
       xor       ebx,ebx
M00_L21:
       mov       rdx,[rsi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L24
       add       rbx,8
       dec       edi
       jne       short M00_L21
M00_L22:
       xor       edi,edi
M00_L23:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L24:
       mov       edi,1
       jmp       short M00_L23
M00_L25:
       mov       rcx,r11
       mov       r11,7FFB6D2511E0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B66B800A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D2511E8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B66B800A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFB6D2511C0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,[rbp-40]
       mov       r11,7FFB6D2511D8
       call      qword ptr [r11]
       jmp       near ptr M00_L22
M00_L31:
       xor       edi,edi
       jmp       near ptr M00_L23
M00_L32:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L33
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rsi
       je        short M00_L33
       mov       r11,7FFB6D2511D8
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1069
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L04
       cmp       rcx,rdx
       je        near ptr M01_L13
       cmp       r8,20
       jb        short M01_L02
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L09
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        near ptr M01_L08
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,10
       jae       near ptr M01_L10
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       vzeroupper
       ret
M01_L04:
       cmp       r8,4
       jae       short M01_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L05:
       test      r8b,1
       je        short M01_L06
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L07:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L08:
       add       rax,20
       cmp       r8,rax
       ja        near ptr M01_L00
M01_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L01
       jmp       short M01_L13
M01_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L12
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
M01_L11:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L12
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       jmp       short M01_L11
M01_L12:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L13:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       jne       short M02_L01
       mov       eax,1
M02_L00:
       add       rsp,28
       ret
M02_L01:
       test      r8,r8
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L02
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L02
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D30FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L02:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L32
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L21
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rsi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L29
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L25
       mov       edi,[r11+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L28
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L27
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L26
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L08
       jmp       short M00_L04
M00_L02:
       mov       r15d,1
M00_L03:
       test      r15d,r15d
       jne       near ptr M00_L13
M00_L04:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L14
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L15
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r14,rdx
       je        short M00_L02
       test      r14,r14
       je        short M00_L05
       test      rdx,rdx
       je        short M00_L05
       mov       r8d,[r14+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L05
       lea       r10,[r14+0C]
       mov       r8d,[r14+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L05:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L06:
       mov       rdi,[rdx+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L15
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+48]
       mov       rdx,[r8+28]
       cmp       r14,rdx
       jne       near ptr M00_L11
       mov       r15d,1
M00_L07:
       test      r15d,r15d
       jne       near ptr M00_L13
M00_L08:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       short M00_L10
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8d,[rsi+10]
       mov       r10,[rsi]
       cmp       r8d,[r10+14]
       jne       near ptr M00_L14
       mov       r8d,[rsi+14]
       cmp       r8d,[rdx+10]
       jb        near ptr M00_L06
M00_L09:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L16
M00_L10:
       mov       r11,7FFB6D2619E8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L16
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D2619F0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r15d,eax
       jmp       near ptr M00_L07
M00_L11:
       test      r14,r14
       je        short M00_L12
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[r14+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L12
       add       r14,0C
       mov       r10,r14
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r15d,eax
       jmp       near ptr M00_L07
M00_L12:
       xor       r15d,r15d
       jmp       near ptr M00_L07
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L31
M00_L14:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       jne       near ptr M00_L30
M00_L17:
       xor       esi,esi
M00_L18:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       esi,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],esi
       jb        short M00_L20
       add       rdi,10
       jmp       short M00_L22
M00_L20:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L21:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
M00_L22:
       test      esi,esi
       jle       short M00_L17
       xor       ebx,ebx
M00_L23:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L24
       add       rbx,8
       dec       esi
       jne       short M00_L23
       jmp       short M00_L17
M00_L24:
       mov       esi,1
       jmp       short M00_L18
M00_L25:
       mov       rcx,r11
       mov       r11,7FFB6D261A00
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,274F1002BD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D261A08
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,274F1002BD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFB6D2619E0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFB6D2619F8
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L31:
       call      M00_L33
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L18
M00_L32:
       xor       esi,esi
       jmp       near ptr M00_L18
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L34
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L34
       mov       r11,7FFB6D2619F8
       call      qword ptr [r11]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1079
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L01
       cmp       rcx,rdx
       je        near ptr M01_L11
       cmp       r8,20
       jae       near ptr M01_L05
       cmp       r8,10
       jae       near ptr M01_L08
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L00:
       vzeroupper
       ret
M01_L01:
       cmp       r8,4
       jae       short M01_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L02
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L02:
       test      r8b,1
       je        short M01_L03
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L00
M01_L04:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M01_L00
M01_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M01_L07
M01_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M01_L12
       add       rax,20
       cmp       r8,rax
       ja        short M01_L06
M01_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M01_L12
       jmp       short M01_L11
M01_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L10
M01_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L12
       add       rax,10
       cmp       r8,rax
       ja        short M01_L09
M01_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M01_L12
M01_L11:
       mov       eax,1
       vzeroupper
       ret
M01_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 291
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r8,rdx
       jne       short M02_L01
       mov       eax,1
M02_L00:
       add       rsp,28
       ret
M02_L01:
       test      r8,r8
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L02
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M02_L02
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB6D31FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L02:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 77
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1E34E8009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L09
M00_L06:
       lea       rbx,[r14+8]
       mov       rax,[rbx]
       mov       ecx,[rbx+10]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+14]
       jne       short M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L09:
       mov       rcx,r14
       mov       r11,7FFB6D250F30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D250F38
       call      qword ptr [r11]
M00_L10:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L11:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L18
M00_L17:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L14
M00_L19:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L19
       jmp       short M00_L14
M00_L20:
       mov       ebx,1
       jmp       short M00_L15
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E34E8009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E34E8009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D527A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D250F48
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E338801FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D250F50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E338801FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 978
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E940]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1EE32C009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L09
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L09:
       mov       rcx,r14
       mov       r11,7FFB6D250F30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D250F38
       call      qword ptr [r11]
M00_L10:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L11:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L18
M00_L17:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L14
M00_L19:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L19
       jmp       short M00_L14
M00_L20:
       mov       ebx,1
       jmp       short M00_L15
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EE32C009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D306BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EE32C009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D527A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D250F48
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EE1CC01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D250F50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EE1CC01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 978
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E970]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1A9F08009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L09
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L09:
       mov       rcx,r14
       mov       r11,7FFB6D260F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D260F40
       call      qword ptr [r11]
M00_L10:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L11:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L18
M00_L17:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L14
M00_L19:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L19
       jmp       short M00_L14
M00_L20:
       mov       ebx,1
       jmp       short M00_L15
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A9F08009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A9F08009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D260F50
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A9DA801FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D260F58
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A9DA801FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D260F30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D260F48
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D260F48
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 978
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E970]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,16DEFC029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L09
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L11
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L09:
       mov       rcx,r14
       mov       r11,7FFB6D240F48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D240F50
       call      qword ptr [r11]
M00_L10:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L11:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L18
M00_L17:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L14
M00_L19:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L19
       jmp       short M00_L14
M00_L20:
       mov       ebx,1
       jmp       short M00_L15
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,16DEFC029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16DEFC029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D517A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D240F68
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16DEFC01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D240F70
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16DEFC01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D240F40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D240F58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D240F58
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 978
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E970]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1CEB6C009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L08
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L12
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L11
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L11
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L09
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L12
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L09:
       mov       rcx,r14
       mov       r11,7FFB6D230F40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D230F48
       call      qword ptr [r11]
M00_L10:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L18
M00_L17:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       test      r14d,r14d
       jle       short M00_L14
       xor       ebx,ebx
M00_L19:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       add       rbx,8
       dec       r14d
       jne       short M00_L19
       jmp       short M00_L14
M00_L20:
       mov       ebx,1
       jmp       short M00_L15
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1CEB6C009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CEB6C009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D507A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D230F58
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CEA0C01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D230F60
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CEA0C01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D230F38
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D230F50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D230F50
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 980
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E988]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,272F5C029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L15
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L14
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L09
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L09
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L09
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L08
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L10
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L08
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L09:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L10:
       mov       rcx,r14
       mov       r11,7FFB6D260DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D260DA8
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       je        short M00_L18
       jmp       near ptr M00_L28
M00_L14:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        near ptr M00_L22
       add       rdi,10
       jmp       short M00_L16
M00_L15:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L16:
       test      r14d,r14d
       jle       short M00_L18
       xor       ebx,ebx
M00_L17:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       add       rbx,8
       dec       r14d
       jne       short M00_L17
M00_L18:
       xor       ebx,ebx
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       ebx,1
       jmp       short M00_L19
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,272F5C029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D316BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,272F5C029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFB6D537A08]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D260DB8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,272F5C01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D260DC0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,272F5C01FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D260D98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D260DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L19
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L19
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D260DB0
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 979
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE435E970]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1D973400A60
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L16
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L09
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L09
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L09
M00_L03:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L08
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L07
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L03
M00_L04:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L12
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[r14+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L05:
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       jne       short M00_L10
M00_L06:
       lea       rbx,[r14+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L08
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L07:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L13
M00_L08:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L09:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r14],rdi
       je        short M00_L06
M00_L10:
       mov       rcx,r14
       mov       r11,7FFB6D2311C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L13
       mov       rcx,r14
       mov       r11,7FFB6D2311D0
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L05
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       cmp       [r14],rdi
       jne       near ptr M00_L28
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L17
       add       rdi,10
       jmp       short M00_L19
M00_L17:
       call      qword ptr [7FFB6D507A08]
       int       3
M00_L18:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L19:
       test      r14d,r14d
       jle       short M00_L14
       xor       ebx,ebx
M00_L20:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L21
       add       rbx,8
       dec       r14d
       jne       short M00_L20
       jmp       short M00_L14
M00_L21:
       mov       ebx,1
       jmp       short M00_L15
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D973400A58
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D2E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D973400A60
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,r11
       mov       r11,7FFB6D2311E0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D95D401FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D2311E8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D95D401FF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFB6D2311C0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r14
       mov       r11,7FFB6D2311D8
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L32
       mov       rcx,r14
       mov       r11,7FFB6D2311D8
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 976
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFBE4344990]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyNotFound()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rax,1455CC00B68
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L20
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L28
       mov       r11,[rbx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rax
       je        near ptr M00_L16
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rdi
       je        near ptr M00_L14
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L25
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L21
       mov       r14d,[r11+10]
M00_L01:
       test      r14d,r14d
       je        near ptr M00_L24
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L23
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L22
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14d,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],r14d
       mov       [rdi+1C],ecx
M00_L02:
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L05
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L05
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L05
M00_L03:
       lea       r14,[rcx+8]
       mov       rdx,[r14]
       mov       rax,rdx
       mov       r8d,[r14+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L09
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L06
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L10
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-30]
       jmp       short M00_L03
M00_L04:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L10
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L08
M00_L05:
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       short M00_L07
       lea       r14,[rcx+8]
       mov       rax,[r14]
       mov       edx,[r14+10]
       mov       r8,[r14]
       cmp       edx,[r8+14]
       jne       short M00_L09
       mov       r8d,[r14+14]
       cmp       r8d,[rax+10]
       jb        short M00_L04
M00_L06:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       short M00_L11
M00_L07:
       mov       r11,7FFB6D2719B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L11
       mov       rcx,[rbp-30]
       mov       r11,7FFB6D2719B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L08:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L05
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L27
M00_L09:
       call      qword ptr [7FFB6D54C138]
       int       3
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L11:
       cmp       rbx,rdi
       jne       near ptr M00_L26
M00_L12:
       xor       r14d,r14d
M00_L13:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L14:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L15
       add       rdi,10
       jmp       short M00_L17
M00_L15:
       call      qword ptr [7FFB6D547A08]
       int       3
M00_L16:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L17:
       test      r14d,r14d
       jle       short M00_L12
       xor       ebx,ebx
M00_L18:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L19
       add       rbx,8
       dec       r14d
       jne       short M00_L18
       jmp       short M00_L12
M00_L19:
       mov       r14d,1
       jmp       short M00_L13
M00_L20:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1455CC00B60
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB6D326BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1455CC00B68
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,r11
       mov       r11,7FFB6D2719C8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1455CC00BE8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,rbx
       mov       r11,7FFB6D2719D0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1455CC00BE8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFB6D2719A8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,[rbp-30]
       mov       r11,7FFB6D2719C0
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L27:
       call      M00_L29
       nop
       mov       r14d,[rbp-24]
       jmp       near ptr M00_L13
M00_L28:
       xor       r14d,r14d
       jmp       near ptr M00_L13
M00_L29:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L30
       mov       rcx,[rbp-30]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L30
       mov       r11,7FFB6D2719C0
       call      qword ptr [r11]
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 975
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFB6DA27168]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFB6D325C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,1D7C0001FB8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1D7C0000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,3ABDAB85
       mov       r8d,8D75FDC9
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D250DC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D250DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D250DC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D89DF98]
       mov       ecx,65
       mov       rdx,7FFB6D705BF8
       call      qword ptr [7FFB6D527798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5E4878
       call      qword ptr [7FFB6D527798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D307840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D705BF8
       call      qword ptr [7FFB6D527798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D307840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE4414B28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE435F138]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D250DE0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D7C0001FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D250DE8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D7C0001FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D250DB8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D250DD8
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D250DD8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D305818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D305818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,21854FC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE435F708]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,1F24BC01FD0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1F24BC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,522605DA
       mov       r8d,9B70AC8D
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D230DB8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D230DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D230DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D87E8E0]
       mov       ecx,65
       mov       rdx,7FFB6D6E5BF8
       call      qword ptr [7FFB6D507798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5C4878
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D2E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D6E5BF8
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D2E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE435D638]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE435D650]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D230DD0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F24BC02000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D230DD8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F24BC02000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D230DA8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D230DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D230DC8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,232E0DF0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE435FBE8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,25390801FD0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,25390800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CF3146F2
       mov       r8d,0A5352D3B
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D230DB0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D230DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D230DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D50C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D87E940]
       mov       ecx,65
       mov       rdx,7FFB6D6E5BF8
       call      qword ptr [7FFB6D507798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5C4878
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D2E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D6E5BF8
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D2E7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE435D788]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE435D7A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D230DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25390802000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D230DD0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25390802000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D230DA0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D230DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D230DC0
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,294258A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE435FC60]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D2E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,190BA801FD0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,190BA800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7F3D0420
       mov       r8d,3CA48819
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D250F30
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D250F38
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D52C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D89E928]
       mov       ecx,65
       mov       rdx,7FFB6D705BF8
       call      qword ptr [7FFB6D527798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5E4878
       call      qword ptr [7FFB6D527798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D307840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D705BF8
       call      qword ptr [7FFB6D527798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D307840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE435D788]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE435D7A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D250F48
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,190BA802000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D250F50
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,190BA802000
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D250F40
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D305818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D305818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1D14F810008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE435FC60]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D305C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,29463001FB8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L19
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L11
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,29463000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,43E374F
       mov       r8d,6F16A17
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L14
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L12:
       mov       rcx,r15
       mov       r11,7FFB6D260CF8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       eax,eax
       jmp       short M00_L07
M00_L14:
       mov       r10d,80
       test      dl,1
       je        short M00_L15
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFB6D260D00
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L19:
       mov       rcx,r15
       mov       r11,7FFB6D260CF0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L28
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D8A6BF8]
       mov       ecx,65
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5F4878
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE439C870]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE439C888]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D260D10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29463001FC8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D260D18
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29463001FC8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D260CE8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D260D08
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D260D08
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2D4F8170008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE439CB10]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       rcx,2F14D801FD0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L20
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,2F14D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0E716856D
       mov       r8d,2BAF37
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D260DF0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D260DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D260DE8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L27
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L21:
       call      qword ptr [7FFB6D8AE8E0]
       mov       ecx,65
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5F4878
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE435D710]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE435D728]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFB6D260E08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2F14D801FE0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFB6D260E10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2F14D801FE0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFB6D260DE0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FFB6D260E00
       call      qword ptr [r11]
M00_L28:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D260E00
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1189
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,331E2760008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE435FCC0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,16E49001FC8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,16E49000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,90F68D76
       mov       r8d,74888879
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FFB6D241200
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D241208
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D2411F8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D51C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D88E028]
       mov       ecx,65
       mov       rdx,7FFB6D6F5BF8
       call      qword ptr [7FFB6D517798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5D4878
       call      qword ptr [7FFB6D517798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D2F7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D6F5BF8
       call      qword ptr [7FFB6D517798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D2F7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBE434F468]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBE434F480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D241218
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16E49001FD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D241220
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16E49001FD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D2411F0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D241210
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D241210
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D2F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D2F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1AEDE060008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFBE4404408]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D2F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,24FB8800B30
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L08
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,24FA2800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F431906A
       mov       r8d,0DA6C1DF4
       cmp       edx,8
       jb        near ptr M00_L11
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L12
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L09:
       mov       rcx,r15
       mov       r11,7FFB6D2619B8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       xor       eax,eax
       jmp       short M00_L07
M00_L11:
       cmp       edx,4
       jb        short M00_L13
M00_L12:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FFB6D2619C0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFB6D2619B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFB6D53C138]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FFB6D8A6C10]
       mov       ecx,65
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFB6D5F4878
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB6D715BF8
       call      qword ptr [7FFB6D537798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6D317840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB6DA0F888]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB6DA0F8A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFB6D2619D0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24FB8800B40
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFB6D2619D8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24FB8800B40
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB6D2619A8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFB6D2619C8
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FFB6D2619C8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1198
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBCCF94CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB6D315818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,290376E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFBE43768C8]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFB6D315C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D240F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D240F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA0DE18]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D240F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D240F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D250F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA1DDA0]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D250F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA1DD28]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D270C88
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D270C80
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA06130]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D270C98
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D270C90
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D270F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D270F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA3DE00]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D270F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D270F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA1D488]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L04
       cmp       r14,r15
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+28],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       r11,7FFB6D2711A0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D271198
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       r14,rbp
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFB6DA2F4F8]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D2711B0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D2711A8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GetValueOrDefault()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       mov       rbp,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L03
       test      edi,edi
       jl        near ptr M00_L03
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       short M00_L02
       mov       rcx,[rsi+8]
       mov       r11,7FFB6D2419B0
       call      qword ptr [r11]
M00_L00:
       cmp       edi,eax
       jge       short M00_L03
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L05
       cmp       edi,[rcx+10]
       jae       short M00_L04
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       short M00_L07
       mov       ecx,edi
       mov       r14,[rax+rcx*8+10]
M00_L01:
       mov       [rsp+20],r14
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
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       rcx,rsi
       mov       r11,7FFB6D2419A8
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       r14,rbp
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFBE4355170]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB6D2419C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D2419B8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6DA2DD88]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6DA2DD88]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D250F08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6DA1DDB8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D250F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D250F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6DA0D458]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D250F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D250F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D260F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D260F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6DA2DDA0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D260F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D260F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D230F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D230F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB6D9FDD88]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D230F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D230F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L05
       test      edi,edi
       jl        near ptr M00_L05
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L04
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       r15d,[rcx+10]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L07
       cmp       edi,[rcx+10]
       jae       near ptr M00_L06
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L09
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
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
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r11,7FFB6D241198
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB6D241190
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFBE4344030]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB6D2411A8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D2411A0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.TryGetValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       edi,[rbx+1C8]
       test      rsi,rsi
       je        near ptr M00_L04
       test      edi,edi
       jl        near ptr M00_L04
       mov       rbp,[rsi]
       mov       r14,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbp,r14
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,7FFB6D231960
       call      qword ptr [r11]
M00_L00:
       cmp       edi,eax
       jge       near ptr M00_L04
       cmp       rbp,r14
       jne       near ptr M00_L07
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L06
       cmp       edi,[rcx+10]
       jae       short M00_L05
       mov       rax,[rcx+8]
       cmp       edi,[rax+8]
       jae       near ptr M00_L08
       mov       ecx,edi
       mov       rbp,[rax+rcx*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB6D231958
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFBE43558D8]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFB6D231970
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB6D231968
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 288
```

