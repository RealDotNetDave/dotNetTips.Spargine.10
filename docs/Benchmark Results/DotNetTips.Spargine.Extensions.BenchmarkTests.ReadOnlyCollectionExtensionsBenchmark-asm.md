## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L03
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L27
       add       r14,10
M00_L00:
       xor       esi,esi
       cmp       esi,edi
       jl        near ptr M00_L28
M00_L01:
       xor       r14d,r14d
M00_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L34
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L30
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L33
M00_L04:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L32
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L25
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L17
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L17
       jmp       short M00_L11
M00_L06:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L07:
       jmp       short M00_L10
M00_L08:
       xor       eax,eax
       jmp       short M00_L10
M00_L09:
       mov       eax,1
M00_L10:
       test      eax,eax
       jne       near ptr M00_L21
M00_L11:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L18
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L20
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L22
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L09
       test      r15,r15
       je        short M00_L08
       test      rdx,rdx
       je        short M00_L08
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L08
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L06
       mov       rcx,r9
       call      qword ptr [7FFB83A7C408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L12:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L13:
       jmp       short M00_L16
M00_L14:
       xor       eax,eax
       jmp       short M00_L16
M00_L15:
       mov       eax,1
M00_L16:
       test      eax,eax
       jne       near ptr M00_L21
M00_L17:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L19
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L18
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L20
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L22
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L15
       test      r15,r15
       je        short M00_L14
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L14
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L12
       mov       rcx,r9
       call      qword ptr [7FFB83A7C408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L13
M00_L18:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L23
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB839C0E30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L23
       mov       rcx,rsi
       mov       r11,7FFB839C0E38
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L16
M00_L20:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8423E988]
       int       3
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L36
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       cmp       rbx,rdi
       je        near ptr M00_L01
       jmp       near ptr M00_L35
M00_L24:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L25:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842596F0],1
       je        short M00_L31
M00_L26:
       mov       r11,1D95F000A88
       mov       rsi,[r11]
       jmp       near ptr M00_L05
M00_L27:
       call      qword ptr [7FFB83A7F570]
       int       3
M00_L28:
       mov       rdx,[r14+rsi*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L29
       inc       esi
       cmp       esi,edi
       jl        short M00_L28
       jmp       near ptr M00_L01
M00_L29:
       mov       r14d,1
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,r11
       mov       r11,7FFB839C0E48
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L26
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFB839C0E50
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D95F000A88
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839C0E28
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFB839C0E40
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L36:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L02
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L02
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839C0E40
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1120
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
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M02_L03
       test      rdx,rdx
       je        short M02_L02
       test      rcx,rcx
       je        short M02_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M02_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A7C408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L01:
       jmp       short M02_L04
M02_L02:
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L29
       add       r14,10
M00_L00:
       xor       esi,esi
       cmp       esi,edi
       jge       short M00_L02
M00_L01:
       mov       rdx,[r14+rsi*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L34
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L30
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L33
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L32
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L27
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L18
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L18
       jmp       short M00_L12
M00_L07:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L08:
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
       jmp       short M00_L11
M00_L10:
       mov       eax,1
M00_L11:
       test      eax,eax
       jne       near ptr M00_L22
M00_L12:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r9
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L14:
       jmp       short M00_L17
M00_L15:
       xor       eax,eax
       jmp       short M00_L17
M00_L16:
       mov       eax,1
M00_L17:
       test      eax,eax
       jne       near ptr M00_L22
M00_L18:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L20
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L16
       test      r15,r15
       je        short M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L13
       mov       rcx,r9
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8424DFB0]
       int       3
M00_L22:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L36
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L35
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L27:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842596F0],1
       je        short M00_L31
M00_L28:
       mov       r11,1CEA3800A80
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFB839C0E00
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFB83A75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFB839C0E08
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFB83A75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CEA3800A80
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFB839C0DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L36:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L03
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839C0DF8
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1117
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L29
       add       r14,10
M00_L00:
       xor       esi,esi
       cmp       esi,edi
       jge       short M00_L02
M00_L01:
       mov       rdx,[r14+rsi*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L34
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L30
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L33
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L32
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L27
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L16
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L16
       jmp       short M00_L12
M00_L07:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L08:
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
       jmp       short M00_L11
M00_L10:
       mov       eax,1
M00_L11:
       test      eax,eax
       jne       near ptr M00_L22
M00_L12:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r9
       call      qword ptr [7FFB83A9C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       xor       eax,eax
       jmp       short M00_L15
M00_L14:
       mov       eax,1
M00_L15:
       test      eax,eax
       jne       near ptr M00_L22
M00_L16:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L20
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L14
       test      r15,r15
       je        short M00_L13
       test      rdx,rdx
       je        near ptr M00_L13
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L13
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L17
       mov       rcx,r9
       call      qword ptr [7FFB83A9C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L18
M00_L17:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L18:
       jmp       near ptr M00_L15
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFB839E0C58
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFB839E0C60
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L15
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8426DF08]
       int       3
M00_L22:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L36
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L35
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L27:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842796F0],1
       je        short M00_L31
M00_L28:
       mov       r11,1F55F000A80
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFB83A9F498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFB839E0C70
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFB83A95728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFB839E0C78
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFB83A95728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F55F000A80
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839E0C50
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFB839E0C68
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L36:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L03
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839E0C68
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1113
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A9C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       jmp       qword ptr [7FFB83A95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L25
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L29
       add       r14,10
M00_L00:
       xor       esi,esi
       cmp       esi,edi
       jge       short M00_L02
M00_L01:
       mov       rdx,[r14+rsi*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L34
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L30
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L33
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L32
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L27
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L16
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L16
       jmp       short M00_L12
M00_L07:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L08:
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
       jmp       short M00_L11
M00_L10:
       mov       eax,1
M00_L11:
       test      eax,eax
       jne       near ptr M00_L22
M00_L12:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r9
       call      qword ptr [7FFB83A6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       xor       eax,eax
       jmp       short M00_L15
M00_L14:
       mov       eax,1
M00_L15:
       test      eax,eax
       jne       near ptr M00_L22
M00_L16:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L20
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L19
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L21
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L14
       test      r15,r15
       je        short M00_L13
       test      rdx,rdx
       je        near ptr M00_L13
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L13
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L17
       mov       rcx,r9
       call      qword ptr [7FFB83A6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L18
M00_L17:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L18:
       jmp       near ptr M00_L15
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFB839B0DF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFB839B0E00
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L15
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8423DF20]
       int       3
M00_L22:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L36
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L35
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L27:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842496E0],1
       je        short M00_L31
M00_L28:
       mov       r11,1E564000A80
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFB83A6F498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFB839B0E10
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFB83A65728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFB839B0E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFB83A65728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E564000A80
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFB839B0DF0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFB839B0E08
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L36:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L03
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839B0E08
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1113
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       jmp       qword ptr [7FFB83A65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L26
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
M00_L00:
       test      edi,edi
       jle       short M00_L02
       xor       esi,esi
M00_L01:
       mov       rdx,[r14+rsi]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       near ptr M00_L27
       add       rsi,8
       dec       edi
       jne       short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L35
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L31
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L34
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L33
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L28
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L17
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L17
       jmp       short M00_L12
M00_L07:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L08:
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
       jmp       short M00_L11
M00_L10:
       mov       eax,1
M00_L11:
       test      eax,eax
       jne       near ptr M00_L13
M00_L12:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L20
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L22
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r9
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L24
M00_L14:
       xor       eax,eax
       jmp       short M00_L16
M00_L15:
       mov       eax,1
M00_L16:
       test      eax,eax
       jne       short M00_L13
M00_L17:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L21
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L20
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L22
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L15
       test      r15,r15
       je        short M00_L14
       test      rdx,rdx
       je        short M00_L14
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L14
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L18
       mov       rcx,r9
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L19
M00_L18:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L19:
       jmp       near ptr M00_L16
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FFB839C0C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FFB839C0C58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L16
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8424DF50]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L03
M00_L25:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L36
M00_L26:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L27:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L28:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84259760],1
       je        short M00_L32
M00_L29:
       mov       r11,1DA1BC00A80
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FFB839C0C68
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FFB83A75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFB839C0C70
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFB83A75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DA1BC00A80
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFB839C0C48
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FFB839C0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839C0C60
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1107
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A7C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L26
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L30
       add       r14,10
M00_L00:
       test      edi,edi
       jle       short M00_L02
       xor       esi,esi
M00_L01:
       mov       rdx,[r14+rsi]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       near ptr M00_L27
       add       rsi,8
       dec       edi
       jne       short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L35
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L31
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L34
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L33
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L28
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],edi
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L19
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L19
       jmp       short M00_L09
M00_L07:
       mov       eax,1
M00_L08:
       test      eax,eax
       jne       near ptr M00_L13
M00_L09:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L20
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L22
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L07
       test      r15,r15
       je        short M00_L12
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L12
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L10
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L11
M00_L10:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L11:
       jmp       near ptr M00_L08
M00_L12:
       xor       eax,eax
       jmp       near ptr M00_L08
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L24
M00_L14:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L15:
       jmp       short M00_L18
M00_L16:
       xor       eax,eax
       jmp       short M00_L18
M00_L17:
       mov       eax,1
M00_L18:
       test      eax,eax
       jne       short M00_L13
M00_L19:
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L21
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L20
       mov       [rsi+8],eax
       mov       edx,[rsi+8]
       cmp       edx,[rsi+0C]
       jae       near ptr M00_L22
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L17
       test      r15,r15
       je        short M00_L16
       test      rdx,rdx
       je        short M00_L16
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L16
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L14
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FFB839D0C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FFB839D0C58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L18
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFB8425DFC8]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L03
M00_L25:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L36
M00_L26:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L27:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L28:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84269130],1
       je        short M00_L32
M00_L29:
       mov       r11,266C0802A78
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FFB83A8F498]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FFB839D0C68
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FFB83A85728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFB839D0C70
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFB83A85728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,266C0802A78
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFB839D0C48
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FFB839D0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L39
       mov       rcx,rsi
       mov       r11,7FFB839D0C60
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1110
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L37
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L01
       mov       esi,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],esi
       jb        short M00_L00
       add       rdi,10
       jmp       near ptr M00_L24
M00_L00:
       call      qword ptr [7FFB83A8F498]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L35
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L31
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L34
M00_L02:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L33
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L29
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L14
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,rcx
       cmp       rbx,rsi
       jne       near ptr M00_L14
       jmp       short M00_L09
M00_L04:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L05:
       jmp       short M00_L08
M00_L06:
       xor       eax,eax
       jmp       short M00_L08
M00_L07:
       mov       eax,1
M00_L08:
       test      eax,eax
       jne       near ptr M00_L10
M00_L09:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L17
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L19
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L20
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L07
       test      r15,r15
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L04
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L10:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L21
M00_L11:
       xor       eax,eax
       jmp       short M00_L13
M00_L12:
       mov       eax,1
M00_L13:
       test      eax,eax
       jne       short M00_L10
M00_L14:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L18
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L17
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L19
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L20
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L12
       test      r15,r15
       je        short M00_L11
       test      rdx,rdx
       je        short M00_L11
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L11
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L15
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L15:
       mov       rax,r9
       mov       r11,rdx
       mov       rdx,[rax]
       mov       rax,[rax+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rax,[r11+2]
       or        rax,rdx
       sete      al
       movzx     eax,al
M00_L16:
       jmp       near ptr M00_L13
M00_L17:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       short M00_L22
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFB839D0FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,rdi
       mov       r11,7FFB839D0FA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L13
M00_L19:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFB8424ED48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       call      M00_L38
       nop
       mov       r14d,[rbp-2C]
       jmp       short M00_L27
M00_L22:
       cmp       rbx,rsi
       je        short M00_L26
       jmp       near ptr M00_L36
M00_L23:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
M00_L24:
       test      esi,esi
       jle       short M00_L26
       xor       r14d,r14d
M00_L25:
       mov       rdx,[rdi+r14]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L28
       add       r14,8
       dec       esi
       jne       short M00_L25
M00_L26:
       xor       r14d,r14d
M00_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       mov       r14d,1
       jmp       short M00_L27
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB8427A388],1
       je        short M00_L32
M00_L30:
       mov       r11,257D3400AE0
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r11
       mov       r11,7FFB839D0FB8
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L34
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       call      qword ptr [7FFB83A85728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L30
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFB839D0FC0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L34:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFB83A85728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,257D3400AE0
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFB839D0F98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,rdi
       mov       r11,7FFB839D0FB0
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L37:
       xor       r14d,r14d
       jmp       near ptr M00_L27
M00_L38:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L39
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L39
       mov       rcx,rdi
       mov       r11,7FFB839D0FB0
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1106
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
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
M01_L10:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L11
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       jmp       short M01_L10
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
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L06
; Total bytes of code 324
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M02_L03
       test      rdx,rdx
       je        short M02_L02
       test      rcx,rcx
       je        short M02_L02
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M02_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L01:
       jmp       short M02_L04
M02_L02:
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 124
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L01
       mov       esi,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],esi
       jb        short M00_L00
       add       rdi,10
       jmp       near ptr M00_L22
M00_L00:
       call      qword ptr [7FFB83A8F498]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L33
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L29
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L32
M00_L02:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L31
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L27
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L12
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,rcx
       cmp       rbx,rsi
       jne       near ptr M00_L12
       jmp       short M00_L08
M00_L04:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L20
M00_L05:
       test      r15,r15
       je        near ptr M00_L09
       test      rdx,rdx
       je        near ptr M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L09
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L06
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L07
M00_L06:
       mov       r8,[r9]
       mov       rax,[r9+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        r8,rax
       sete      r13b
       movzx     r13d,r13b
M00_L07:
       test      r13d,r13d
       jne       short M00_L04
M00_L08:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L19
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L17
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L18
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       jne       near ptr M00_L05
       mov       r13d,1
       jmp       short M00_L07
M00_L09:
       xor       r13d,r13d
       jmp       short M00_L07
M00_L10:
       mov       r13d,1
M00_L11:
       test      r13d,r13d
       jne       near ptr M00_L04
M00_L12:
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L16
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L19
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L17
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L18
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L15
       test      rdx,rdx
       je        short M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L15
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L13
       mov       rcx,r9
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L14
M00_L13:
       mov       r11,r9
       mov       rax,rdx
       mov       rdx,[r11]
       mov       r11,[r11+2]
       mov       r8,[rax]
       xor       rdx,r8
       xor       r11,[rax+2]
       or        r11,rdx
       sete      r13b
       movzx     r13d,r13b
M00_L14:
       jmp       near ptr M00_L11
M00_L15:
       xor       r13d,r13d
       jmp       near ptr M00_L11
M00_L16:
       mov       rcx,rdi
       mov       r11,7FFB839D1258
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,rdi
       mov       r11,7FFB839D1260
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFB842AF108]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L34
M00_L20:
       call      M00_L36
       nop
       mov       r14d,[rbp-34]
       jmp       short M00_L25
M00_L21:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
M00_L22:
       test      esi,esi
       jle       short M00_L24
       xor       r14d,r14d
M00_L23:
       mov       rdx,[rdi+r14]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L26
       add       r14,8
       dec       esi
       jne       short M00_L23
M00_L24:
       xor       r14d,r14d
M00_L25:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],r14b
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L26:
       mov       r14d,1
       jmp       short M00_L25
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB843001C0],1
       je        short M00_L30
M00_L28:
       mov       r11,2BA44800AE8
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L29:
       mov       rcx,r11
       mov       r11,7FFB839D1270
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L32
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFB839D1278
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L32:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BA44800AE8
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFB839D1250
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L34:
       cmp       rbx,rsi
       je        near ptr M00_L24
       mov       rcx,rdi
       mov       r11,7FFB839D1268
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L35:
       xor       r14d,r14d
       jmp       near ptr M00_L25
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L37
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L37
       mov       rcx,rdi
       mov       r11,7FFB839D1268
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1141
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
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       jne       short M02_L01
       mov       eax,1
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       test      rdx,rdx
       je        short M02_L04
       test      rcx,rcx
       je        short M02_L04
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L04
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB83A8C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L03:
       jmp       short M02_L00
M02_L04:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 124
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1EF4D400A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax+rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       mov       edx,[r14+8]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8424DF38]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84259820],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1EF4D400A90
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EF4D400A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EF4D400A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839C0DF8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839C0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EF4D400A90
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 963
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
       call      qword ptr [7FFB8424C660]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2EDCE002A00
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax+rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       mov       edx,[r14+8]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839E0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839E0DE8
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8426DFC8]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84279820],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,2EDCE002A88
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2EDCE0029F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A96BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2EDCE002A00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A9F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839E0DF8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839E0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2EDCE002A88
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839E0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839E0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839E0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 963
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
       call      qword ptr [7FFB8426C6D8]
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
       jmp       qword ptr [7FFB83A95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,29100000A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax+rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8424DF80]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84259810],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,29100000A90
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,29100000A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29100000A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839C0DF8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839C0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29100000A90
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 959
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
       call      qword ptr [7FFB8424C690]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2048D400A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax+rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8424DF80]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84259810],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,2048D400A90
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2048D400A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2048D400A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839C0DF8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839C0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2048D400A90
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 959
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
       call      qword ptr [7FFB8424C690]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1D226000A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       xor       ebx,ebx
M00_L02:
       mov       rdx,[r15+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       add       rbx,8
       dec       r14d
       jne       short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839D0C58
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839D0C60
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8425DF68]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84269260],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1D226000A90
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D226000A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A86BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D226000A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A8F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839D0C70
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839D0C78
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D226000A90
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839D0C50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839D0C68
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839D0C68
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 959
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
       call      qword ptr [7FFB8425C660]
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,161C8400A08
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L25
       add       r15,10
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       xor       ebx,ebx
M00_L02:
       mov       rdx,[r15+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L21
       add       rbx,8
       dec       r14d
       jne       short M00_L02
M00_L03:
       xor       ebx,ebx
M00_L04:
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
M00_L05:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r15d,[r11+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L06:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M00_L22
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       nop       dword ptr [rax]
M00_L08:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L12
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       jmp       short M00_L08
M00_L09:
       mov       [r14+8],eax
       mov       edx,[r14+8]
       cmp       edx,[r14+0C]
       jae       near ptr M00_L16
       mov       rbx,[r14+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L18
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       cmp       [r14],rdi
       jne       short M00_L14
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jb        short M00_L09
M00_L12:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       short M00_L19
M00_L13:
       mov       r14,[rbp-38]
       cmp       [r14],r14d
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       je        short M00_L11
M00_L14:
       mov       rcx,r14
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L17
M00_L16:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB8424DF80]
       int       3
M00_L17:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       cmp       [r14],rdi
       je        near ptr M00_L03
       jmp       near ptr M00_L31
M00_L20:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L21:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L22:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB84259260],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,161C8400A90
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,161C8400A00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,161C8400A08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839C0DE8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839C0DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,161C8400A90
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-38]
       cmp       [r14],rdi
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB839C0DE0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 959
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
       call      qword ptr [7FFB8424C678]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,29D80002A10
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L17
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L02
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L01
       add       r14,10
       jmp       near ptr M00_L18
M00_L01:
       call      qword ptr [7FFB83AAF498]
       int       3
M00_L02:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L03:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L04:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L10
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L10
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L09
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L13
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L15
       jmp       short M00_L05
M00_L06:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L13
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L15
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L12
M00_L07:
       cmp       [rdi],r14
       jne       short M00_L11
M00_L08:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L06
M00_L09:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       short M00_L16
M00_L10:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L08
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFB839F0FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFB839F0FD0
       call      qword ptr [r11]
M00_L12:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L07
       jmp       short M00_L14
M00_L13:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFB8427ED30]
       int       3
M00_L14:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       [rdi],r14
       je        short M00_L20
       jmp       near ptr M00_L31
M00_L17:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L18:
       test      edi,edi
       jle       short M00_L20
       xor       ebx,ebx
M00_L19:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       add       rbx,8
       dec       edi
       jne       short M00_L19
M00_L20:
       xor       ebx,ebx
M00_L21:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L22:
       mov       ebx,1
       jmp       short M00_L21
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842B5C50],1
       je        short M00_L27
M00_L24:
       mov       r11,29D80002AE8
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,29D80002A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83AA6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29D80002A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839F0FE0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L03
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L24
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839F0FE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29D80002AE8
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839F0FC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFB839F0FD8
       call      qword ptr [r11]
       jmp       near ptr M00_L20
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L21
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L21
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFB839F0FD8
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 930
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
       call      qword ptr [7FFB8427C6F0]
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
       jmp       qword ptr [7FFB83AA5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,25D41800AB0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L17
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L02
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L01
       add       r14,10
       jmp       near ptr M00_L18
M00_L01:
       call      qword ptr [7FFB83A7F498]
       int       3
M00_L02:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L03:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M00_L04:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L10
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L10
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L10
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L09
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L13
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L15
       jmp       short M00_L05
M00_L06:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L13
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L15
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L12
M00_L07:
       cmp       [rdi],r14
       jne       short M00_L11
M00_L08:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L06
M00_L09:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       short M00_L16
M00_L10:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L08
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFB839C1110
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFB839C1118
       call      qword ptr [r11]
M00_L12:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L07
       jmp       short M00_L14
M00_L13:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFB8428F108]
       int       3
M00_L14:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       [rdi],r14
       je        short M00_L20
       jmp       near ptr M00_L31
M00_L17:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L18:
       test      edi,edi
       jle       short M00_L20
       xor       ebx,ebx
M00_L19:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       add       rbx,8
       dec       edi
       jne       short M00_L19
M00_L20:
       xor       ebx,ebx
M00_L21:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L22:
       mov       ebx,1
       jmp       short M00_L21
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFB842E00E0],1
       je        short M00_L27
M00_L24:
       mov       r11,25D41800AF8
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25D41800AA8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFB83A76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25D41800AB0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFB839C1128
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L03
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L24
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFB839C1130
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25D41800AF8
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB839C1108
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFB839C1120
       call      qword ptr [r11]
       jmp       near ptr M00_L20
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L21
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L21
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFB839C1120
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 930
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
       call      qword ptr [7FFB84145788]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,1ED7D000A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1ED67000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B9467A78
       mov       r8d,33A80AF
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839C0C70
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
       mov       r11,7FFB839C0C78
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839C0C68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB8424DF08]
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
       test      byte ptr [7FFB84259AB8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1ED7D000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8400F4C8]
       mov       ecx,65
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D44FE0
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84247A68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84247A80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839C0C88
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839C0C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ED7D000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839C0C60
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839C0C80
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839C0C80
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22DFC060008
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
       call      qword ptr [7FFB8424DA10]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,2237C800A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,22366800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B713F546
       mov       r8d,4F1DD53A
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839E0C68
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
       mov       r11,7FFB839E0C70
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839E0C60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB8426DFC8]
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
       test      byte ptr [7FFB84279C30],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2237C800A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8402F570]
       mov       ecx,65
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D654F0
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84267AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84267AF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839E0C80
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839E0C88
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2237C800A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839E0C58
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839E0C78
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839E0C78
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,263FB9C0008
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
       call      qword ptr [7FFB8426DAD0]
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
       jmp       qword ptr [7FFB83A95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,1630F000A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,162F9000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F3005FF4
       mov       r8d,574ED8E0
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839E0C60
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
       mov       r11,7FFB839E0C68
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839E0C58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB8426DF50]
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
       test      byte ptr [7FFB8427A078],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1630F000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8402F4E0]
       mov       ecx,65
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D64FE0
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84267AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84267AC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839E0C78
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839E0C80
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1630F000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839E0C50
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839E0C70
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839E0C70
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A38DE40008
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
       call      qword ptr [7FFB8426DA58]
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
       jmp       qword ptr [7FFB83A95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,2110A000A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,210F4000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C78AE641
       mov       r8d,0A337F2C8
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839B0DE0
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
       mov       r11,7FFB839B0DE8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839B0DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB8423DF68]
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
       test      byte ptr [7FFB8424A078],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2110A000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB83FFF4E0]
       mov       ecx,65
       mov       rdx,7FFB83E584A8
       call      qword ptr [7FFB83A6F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D34FE0
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E584A8
       call      qword ptr [7FFB83A6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84237AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84237AC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839B0DF8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839B0E00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2110A000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839B0DD0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839B0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839B0DF0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25188EF0008
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
       call      qword ptr [7FFB8423DA58]
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
       jmp       qword ptr [7FFB83A65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,1D041800A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1D02B800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,74F1115F
       mov       r8d,8BC16736
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839E0CA0
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
       mov       r11,7FFB839E0CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839E0C98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB84265440]
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
       test      byte ptr [7FFB8427A078],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1D041800A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8402F528]
       mov       ecx,65
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D64FE0
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E884A8
       call      qword ptr [7FFB83A9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84267B58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84267B70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839E0CB8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839E0CC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D041800A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839E0C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839E0CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839E0CB0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,210C07C0008
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
       call      qword ptr [7FFB8426DB00]
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
       jmp       qword ptr [7FFB83A95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,27753800A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,2773D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,704E0DD5
       mov       r8d,36B3EA2
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839D0CA0
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
       mov       r11,7FFB839D0CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839D0C98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB842262E0]
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
       test      byte ptr [7FFB842487F8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,27753800A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8401F048]
       mov       ecx,65
       mov       rdx,7FFB83E784A8
       call      qword ptr [7FFB83A8F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D554F0
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E784A8
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84227FC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84227FD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839D0CB8
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839D0CC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27753800A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839D0C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839D0CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839D0CB0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B7D2720008
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
       call      qword ptr [7FFB8422DB00]
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
       jmp       qword ptr [7FFB83A85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,21733C00A00
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,2171DC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B06C505C
       mov       r8d,0F6898C11
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839C0F28
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
       mov       r11,7FFB839C0F30
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839C0F20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB84236838]
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
       test      byte ptr [7FFB84259AB8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,21733C00A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8400F510]
       mov       ecx,65
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D454F0
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84237BA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84237BB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839C0F40
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839C0F48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21733C00A10
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839C0F18
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839C0F38
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839C0F38
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,257B2C40008
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
       call      qword ptr [7FFB8423E298]
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L24
       mov       rcx,2C453000AA8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L25
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L28
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L22
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-38],r13
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r13,[rbp-38]
       cmp       [r13],rcx
       jne       near ptr M00_L18
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L10
       mov       [r13+8],ecx
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L20
       mov       rdx,[rcx+r11*8+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,2C43D000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,15D2891B
       mov       r8d,3E792191
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r13
       mov       r11,7FFB839C1280
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
       mov       r11,7FFB839C1288
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFB839C1278
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFB8428DF20]
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
       test      byte ptr [7FFB842E0A70],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2C453000AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFB8400F510]
       mov       ecx,65
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       r13,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D454F0
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB83E684A8
       call      qword ptr [7FFB83A7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB84144B88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB84144BA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFB839C1298
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB839C12A0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C453000AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB839C1270
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFB839C1290
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFB839C1290
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1205
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,304D2110008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
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
       call      qword ptr [7FFB8428DE60]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFB83A75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839C0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839C0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8414C180]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839E0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839E0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8416C180]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839E0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839E0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839E0DC8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839E0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB84147C60]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839E0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839E0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839F0DC8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839F0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8417C180]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839F0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839F0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839E0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839E0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8416C150]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839E0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839E0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839C0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8414C150]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839B0FA0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839B0F98
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB8413D470]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839B0FB0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839B0FA8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L07
       test      edi,edi
       jl        near ptr M00_L07
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       near ptr M00_L03
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+8]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
       cmp       r14,r15
       jne       near ptr M00_L06
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L05
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L04
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
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
       mov       r11,7FFB839C1218
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFB839C1210
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFB841451A0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFB839C1228
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C1220
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839C0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8414C168]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839C0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8414C168]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839C0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839C0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8414C120]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839C0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839C0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839D0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839D0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8415C180]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839D0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839D0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839B0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839B0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8413C1B0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839B0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839B0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839D0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839D0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8415C168]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839D0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839D0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839E0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839E0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB8416C2B8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839E0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839E0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       r15d,[rcx+8]
M00_L00:
       cmp       edi,r15d
       jge       near ptr M00_L05
       cmp       rbp,r14
       jne       near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],rax
       jne       short M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
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
       mov       r11,7FFB839E1238
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFB839E1230
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFB841551E8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFB839E1248
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFB839E1240
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

