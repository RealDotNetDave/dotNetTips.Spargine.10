## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.IsNotEmptyFound()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L35
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rsi
       je        near ptr M00_L23
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L27
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
       jne       near ptr M00_L24
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       r14d,r14d
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L28
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L31
M00_L05:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L30
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
M00_L06:
       mov       [rbp-30],rsi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L12
       mov       rsi,[rbp-30]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L12
       jmp       short M00_L09
M00_L07:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
M00_L08:
       test      eax,eax
       jne       near ptr M00_L20
M00_L09:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L13
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L19
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L21
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L14
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       call      qword ptr [7FF7D50DC408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L10:
       mov       rax,r8
       mov       rcx,rdx
       mov       r11,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rcx]
       xor       r11,rdx
       xor       rax,[rcx+2]
       or        r11,rax
       sete      al
       movzx     eax,al
M00_L11:
       test      eax,eax
       jne       near ptr M00_L20
M00_L12:
       mov       rsi,[rbp-30]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L16
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L13
       mov       [rsi+8],eax
       mov       ecx,[rsi+8]
       cmp       ecx,[rsi+0C]
       jae       near ptr M00_L19
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L21
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L18
       test      rcx,rcx
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       lea       r8,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       rax,rcx
       cmp       rax,0A
       je        near ptr M00_L10
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FF7D50DC408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L13:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L22
M00_L14:
       mov       eax,1
       jmp       near ptr M00_L08
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L08
M00_L16:
       mov       rcx,rsi
       mov       r11,7FF7D5020DF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,rsi
       mov       r11,7FF7D5020E00
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L11
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L11
M00_L18:
       mov       eax,1
       jmp       near ptr M00_L11
M00_L19:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D58BE4D8]
       int       3
M00_L20:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L34
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L33
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L24:
       mov       r14d,1
       jmp       near ptr M00_L03
M00_L25:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FF7D58D37C8],1
       je        short M00_L29
M00_L26:
       mov       r11,188B7802A98
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L27:
       call      qword ptr [7FF7D50DF570]
       int       3
M00_L28:
       mov       rcx,r11
       mov       r11,7FF7D5020E10
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L31
       jmp       near ptr M00_L05
M00_L29:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L26
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5020E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L31:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,188B7802A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,rbx
       mov       r11,7FF7D5020DF0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rsi
       mov       r11,7FF7D5020E08
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L34:
       call      M00_L36
       nop
       mov       r14d,[rbp-24]
       jmp       near ptr M00_L03
M00_L35:
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L37
       mov       rsi,[rbp-30]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       je        short M00_L37
       mov       rcx,rsi
       mov       r11,7FF7D5020E08
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L03
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L03
       add       rdx,0C
       add       rcx,0C
       mov       rbx,rcx
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF7D50DC408]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rdx]
       mov       rcx,[rdx+2]
       mov       rdx,[rbx]
       xor       rax,rdx
       xor       rcx,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 119
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
       jmp       qword ptr [7FF7D50D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L15
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L15
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
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       mov       eax,1
M00_L14:
       test      eax,eax
       jne       near ptr M00_L22
M00_L15:
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
       je        short M00_L13
       test      r15,r15
       je        short M00_L18
       test      rdx,rdx
       je        short M00_L18
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L18
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L16
       mov       rcx,r9
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
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
M00_L17:
       jmp       near ptr M00_L14
M00_L18:
       xor       eax,eax
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FF7D5050DD8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FF7D5050DE0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L14
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D58CE478]
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
       test      byte ptr [7FF7D58D96F0],1
       je        short M00_L31
M00_L28:
       mov       r11,1B32AC00AA0
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FF7D510F498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FF7D5050DF0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FF7D5105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FF7D5050DF8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FF7D5105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B32AC00AA0
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7D5050DD0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF7D5050DE8
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
       mov       r11,7FF7D5050DE8
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1108
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
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D5105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       jmp       short M00_L09
M00_L07:
       mov       eax,1
M00_L08:
       test      eax,eax
       jne       near ptr M00_L22
M00_L09:
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
       call      qword ptr [7FF7D50FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7D50FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FF7D5040DD8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FF7D5040DE0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D58DE4D8]
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
       test      byte ptr [7FF7D58EB260],1
       je        short M00_L31
M00_L28:
       mov       r11,25DDC002A98
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FF7D50FF498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FF7D5040DF0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FF7D50F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FF7D5040DF8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FF7D50F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25DDC002A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7D5040DD0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF7D5040DE8
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
       mov       r11,7FF7D5040DE8
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1116
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
       call      qword ptr [7FF7D50FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       jmp       short M00_L09
M00_L07:
       mov       eax,1
M00_L08:
       test      eax,eax
       jne       near ptr M00_L22
M00_L09:
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
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FF7D5030C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FF7D5030C58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D58CE490]
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
       test      byte ptr [7FF7D58DB7A0],1
       je        short M00_L31
M00_L28:
       mov       r11,19373400AA0
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FF7D50EF498]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FF7D5030C68
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FF7D50E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FF7D5030C70
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FF7D50E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19373400AA0
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7D5030C48
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FF7D5030C60
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
       mov       r11,7FF7D5030C60
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1116
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
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       jmp       short M00_L10
M00_L07:
       xor       eax,eax
       jmp       short M00_L09
M00_L08:
       mov       eax,1
M00_L09:
       test      eax,eax
       jne       near ptr M00_L13
M00_L10:
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
       je        short M00_L08
       test      r15,r15
       je        short M00_L07
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L07
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L11
       mov       rcx,r9
       call      qword ptr [7FF7D50DC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L12
M00_L11:
       mov       rax,[r9]
       mov       r8,[r9+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        r8,rax
       sete      al
       movzx     eax,al
M00_L12:
       jmp       near ptr M00_L09
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
       call      qword ptr [7FF7D50DC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FF7D5020C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FF7D5020C48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L18
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D589E478]
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
       test      byte ptr [7FF7D58A96F0],1
       je        short M00_L32
M00_L29:
       mov       r11,2E597802A98
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FF7D50DF498]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FF7D5020C58
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FF7D50D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF7D5020C60
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FF7D50D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2E597802A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FF7D5020C38
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF7D5020C50
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
       mov       r11,7FF7D5020C50
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
       call      qword ptr [7FF7D50DC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D50D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF7D511C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7D511C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FF7D5060DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FF7D5060DE8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L18
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FF7D58FE4A8]
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
       test      byte ptr [7FF7D590B270],1
       je        short M00_L32
M00_L29:
       mov       r11,2340D000AA0
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FF7D511F498]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FF7D5060DF8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FF7D5115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF7D5060E00
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FF7D5115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2340D000AA0
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FF7D5060DD8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF7D5060DF0
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
       mov       r11,7FF7D5060DF0
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
       call      qword ptr [7FF7D511C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D5115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L36
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L01
       mov       esi,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],esi
       jb        short M00_L00
       add       rdi,10
       jmp       near ptr M00_L23
M00_L00:
       call      qword ptr [7FF7D50EF498]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L34
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L30
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L33
M00_L02:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L32
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L28
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
       jmp       short M00_L07
M00_L04:
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
       je        short M00_L05
       mov       rcx,r9
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L06
M00_L05:
       mov       r8,[r9]
       mov       rax,[r9+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        r8,rax
       sete      r13b
       movzx     r13d,r13b
M00_L06:
       test      r13d,r13d
       jne       short M00_L08
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L16
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L18
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L19
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       jne       near ptr M00_L04
       mov       r13d,1
       jmp       short M00_L06
M00_L08:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L20
M00_L09:
       xor       r13d,r13d
       jmp       short M00_L06
M00_L10:
       mov       r13d,1
M00_L11:
       test      r13d,r13d
       jne       short M00_L08
M00_L12:
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L17
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L16
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L18
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L19
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
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       short M00_L21
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7D5030F88
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,rdi
       mov       r11,7FF7D5030F90
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L11
M00_L18:
       mov       ecx,[rdi+8]
       call      qword ptr [7FF7D58CF288]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       call      M00_L37
       nop
       mov       r14d,[rbp-34]
       jmp       short M00_L26
M00_L21:
       cmp       rbx,rsi
       je        short M00_L25
       jmp       near ptr M00_L35
M00_L22:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
M00_L23:
       test      esi,esi
       jle       short M00_L25
       xor       r14d,r14d
M00_L24:
       mov       rdx,[rdi+r14]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L27
       add       r14,8
       dec       esi
       jne       short M00_L24
M00_L25:
       xor       r14d,r14d
M00_L26:
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
M00_L27:
       mov       r14d,1
       jmp       short M00_L26
M00_L28:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FF7D58FB790],1
       je        short M00_L31
M00_L29:
       mov       r11,21E22000B00
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,r11
       mov       r11,7FF7D5030FA0
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L33
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L32:
       mov       rcx,rbx
       mov       r11,7FF7D5030FA8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L33:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21E22000B00
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L34:
       mov       rcx,rbx
       mov       r11,7FF7D5030F80
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rdi
       mov       r11,7FF7D5030F98
       call      qword ptr [r11]
       jmp       near ptr M00_L25
M00_L36:
       xor       r14d,r14d
       jmp       near ptr M00_L26
M00_L37:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L38
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L38
       mov       rcx,rdi
       mov       r11,7FF7D5030F98
       call      qword ptr [r11]
M00_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1131
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
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
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
; Total bytes of code 337
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
       call      qword ptr [7FF7D50EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF7D510F498]
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
       jmp       short M00_L06
M00_L04:
       mov       r8,[r9]
       mov       rax,[r9+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        r8,rax
       sete      r13b
       movzx     r13d,r13b
M00_L05:
       test      r13d,r13d
       jne       short M00_L07
M00_L06:
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
       jne       short M00_L08
       mov       r13d,1
       jmp       short M00_L05
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L20
M00_L08:
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
       je        near ptr M00_L04
       mov       rcx,r9
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       near ptr M00_L05
M00_L09:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L10:
       mov       r13d,1
M00_L11:
       test      r13d,r13d
       jne       short M00_L07
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
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,7FF7D50510F0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,rdi
       mov       r11,7FF7D50510F8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,[rdi+8]
       call      qword ptr [7FF7D593F630]
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
       test      byte ptr [7FF7D5993850],1
       je        short M00_L30
M00_L28:
       mov       r11,25173400B08
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L29:
       mov       rcx,r11
       mov       r11,7FF7D5051108
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
       mov       r11,7FF7D5051110
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L32:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25173400B08
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       r11,7FF7D50510E8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L34:
       cmp       rbx,rsi
       je        near ptr M00_L24
       mov       rcx,rdi
       mov       r11,7FF7D5051100
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
       mov       r11,7FF7D5051100
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1131
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
       call      qword ptr [7FF7D510C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF7D5105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,201D5C00A28
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
       mov       r11,7FF7D5040DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5040DD8
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
       call      qword ptr [7FF7D58DE508]
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
       test      byte ptr [7FF7D58EB390],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,201D5C00AB0
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,201D5C00A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,201D5C00A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D50FF498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5040DE8
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
       mov       r11,7FF7D5040DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,201D5C00AB0
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5040DE0
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
       mov       r11,7FF7D5040DE0
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
       call      qword ptr [7FF7D58DCBE8]
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1E693000A28
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
       mov       r11,7FF7D5040DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5040DD8
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
       call      qword ptr [7FF7D58DE508]
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
       test      byte ptr [7FF7D58EB8E0],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1E693000AB0
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E693000A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E693000A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D50FF498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5040DE8
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
       mov       r11,7FF7D5040DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E693000AB0
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5040DE0
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
       mov       r11,7FF7D5040DE0
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
       call      qword ptr [7FF7D58DCC18]
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1484CC02A20
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
       mov       r11,7FF7D5040DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5040DD8
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
       call      qword ptr [7FF7D58BE478]
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
       test      byte ptr [7FF7D58C9820],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1484CC02AA8
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1484CC02A18
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1484CC02A20
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D50FF498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5040DE8
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
       mov       r11,7FF7D5040DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1484CC02AA8
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5040DE0
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
       mov       r11,7FF7D5040DE0
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
       call      qword ptr [7FF7D58BCB58]
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1654B400A28
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
       mov       r11,7FF7D5030DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5030DD8
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
       call      qword ptr [7FF7D58CE520]
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
       test      byte ptr [7FF7D58DB390],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1654B400AB0
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1654B400A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1654B400A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D50EF498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5030DE8
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
       mov       r11,7FF7D5030DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1654B400AB0
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5030DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5030DE0
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
       mov       r11,7FF7D5030DE0
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
       call      qword ptr [7FF7D58CCBE8]
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,20183800A28
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
       mov       r11,7FF7D5040C48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5040C50
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
       call      qword ptr [7FF7D58BE490]
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
       test      byte ptr [7FF7D58C9820],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,20183800AB0
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20183800A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20183800A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D50FF498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5040C60
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
       mov       r11,7FF7D5040C68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20183800AB0
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5040C40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5040C58
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
       mov       r11,7FF7D5040C58
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
       call      qword ptr [7FF7D58BCB70]
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,16F49800A28
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
       mov       r11,7FF7D5050DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FF7D5050DE8
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
       call      qword ptr [7FF7D58EE4A8]
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
       test      byte ptr [7FF7D58FB8C0],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,16F49800AB0
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,16F49800A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D5106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16F49800A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FF7D510F498]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5050DF8
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
       mov       r11,7FF7D5050E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16F49800AB0
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5050DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FF7D5050DF0
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
       mov       r11,7FF7D5050DF0
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
       call      qword ptr [7FF7D58ECB70]
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
       jmp       qword ptr [7FF7D5105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,25581400A28
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
       call      qword ptr [7FF7D50EF498]
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
       mov       r11,7FF7D5030FA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FF7D5030FB0
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
       call      qword ptr [7FF7D58CF288]
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
       test      byte ptr [7FF7D5905CD0],1
       je        short M00_L27
M00_L24:
       mov       r11,25581400B10
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25581400A20
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25581400A28
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5030FC0
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
       mov       r11,7FF7D5030FC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25581400B10
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5030FA0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FF7D5030FB8
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
       mov       r11,7FF7D5030FB8
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
       call      qword ptr [7FF7D58CCBE8]
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1FE03400AD0
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
       call      qword ptr [7FF7D50EF498]
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
       mov       r11,7FF7D5031230
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FF7D5031238
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
       call      qword ptr [7FF7D591F648]
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
       test      byte ptr [7FF7D5973990],1
       je        short M00_L27
M00_L24:
       mov       r11,1FE03400B18
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1FE03400AC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7D50E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FE03400AD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FF7D5031248
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
       mov       r11,7FF7D5031250
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FE03400B18
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FF7D5031228
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FF7D5031240
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
       mov       r11,7FF7D5031240
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
       call      qword ptr [7FF7D57C5AD0]
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,22305000A20
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
       mov       rcx,222EF000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,676D6DF5
       mov       r8d,3D24725F
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
       mov       r11,7FF7D5040DE0
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
       mov       r11,7FF7D5040DE8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5040DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58DE478]
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
       test      byte ptr [7FF7D58EBBE8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,22305000AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D569EF88]
       mov       ecx,65
       mov       rdx,7FF7D54F8D68
       call      qword ptr [7FF7D50FF228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54F8D68
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58D7FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58D7FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5040DF8
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
       mov       r11,7FF7D5040E00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22305000AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5040DD0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5040DF0
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
       mov       r11,7FF7D5040DF0
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26384060008
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
       call      qword ptr [7FF7D58DDF50]
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
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,136DCC00A20
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
       mov       rcx,136C6C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A2768CC
       mov       r8d,0F93D97A9
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
       mov       r11,7FF7D5030C58
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
       mov       r11,7FF7D5030C60
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5030C50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58CE490]
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
       test      byte ptr [7FF7D58DC108],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,136DCC00AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D568EFA0]
       mov       ecx,65
       mov       rdx,7FF7D54E8D68
       call      qword ptr [7FF7D50EF228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54E8D68
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58C7F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58C7F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5030C70
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
       mov       r11,7FF7D5030C78
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,136DCC00AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5030C48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5030C68
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
       mov       r11,7FF7D5030C68
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1775BA90008
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
       call      qword ptr [7FF7D58CDF68]
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,20E1A400A20
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
       mov       rcx,20E04400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A2C7461C
       mov       r8d,7CD637F8
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
       mov       r11,7FF7D5050C50
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
       mov       r11,7FF7D5050C58
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5050C48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58CE460]
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
       test      byte ptr [7FF7D58E9AB8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,20E1A400AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D56AEAA8]
       mov       ecx,65
       mov       rdx,7FF7D5508D68
       call      qword ptr [7FF7D510F228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D5508D68
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CC3D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CC3F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5050C68
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
       mov       r11,7FF7D5050C70
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20E1A400AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5050C40
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5050C60
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
       mov       r11,7FF7D5050C60
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24E99330008
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
       call      qword ptr [7FF7D58CDF38]
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
       jmp       qword ptr [7FF7D5105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1D8A7800A20
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
       mov       rcx,1D891800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C7DB7AE5
       mov       r8d,79EAC417
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
       mov       r11,7FF7D5060C50
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
       mov       r11,7FF7D5060C58
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5060C48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58FE508]
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
       test      byte ptr [7FF7D590C128],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1D8A7800AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D56BEFE8]
       mov       ecx,65
       mov       rdx,7FF7D5518D68
       call      qword ptr [7FF7D511F228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D5518D68
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58F7FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58F7FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5060C68
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
       mov       r11,7FF7D5060C70
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D8A7800AB8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5060C40
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5060C60
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
       mov       r11,7FF7D5060C60
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21926860008
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
       call      qword ptr [7FF7D58FDFC8]
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
       jmp       qword ptr [7FF7D5115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,174BDC02A18
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
       mov       rcx,174BDC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F16B667
       mov       r8d,220405C8
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
       mov       r11,7FF7D5020C90
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
       mov       r11,7FF7D5020C98
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5020C88
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58B58D8]
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
       test      byte ptr [7FF7D58CBBE8],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,174BDC02A28
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D567EF88]
       mov       ecx,65
       mov       rdx,7FF7D54D8D68
       call      qword ptr [7FF7D50DF228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53A5AC0
       call      qword ptr [7FF7D50DF228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D50DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54D8D68
       call      qword ptr [7FF7D50DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58B7FC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58B7FD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5020CA8
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
       mov       r11,7FF7D5020CB0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,174BDC02A28
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5020C80
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5020CA0
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
       mov       r11,7FF7D5020CA0
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B552C10008
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
       call      qword ptr [7FF7D58BE010]
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
       jmp       qword ptr [7FF7D50D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2207E400A20
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
       mov       rcx,22068400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,3D1B9216
       mov       r8d,9B686912
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
       mov       r11,7FF7D5030E10
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
       mov       r11,7FF7D5030E18
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5030E08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D58C6D18]
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
       test      byte ptr [7FF7D58DC108],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2207E400A30
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D568EFE8]
       mov       ecx,65
       mov       rdx,7FF7D54E8D68
       call      qword ptr [7FF7D50EF228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54E8D68
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58C7FC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58C7FD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5030E28
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
       mov       r11,7FF7D5030E30
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2207E400A30
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5030E00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5030E20
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
       mov       r11,7FF7D5030E20
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,260FD1C0008
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
       call      qword ptr [7FF7D58CE088]
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
       jmp       qword ptr [7FF7D50E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1FC07000A88
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
       mov       rcx,1FBF1000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,245516DB
       mov       r8d,315B1D5B
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
       mov       r11,7FF7D5060F70
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
       mov       r11,7FF7D5060F78
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5060F68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D591CC78]
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
       test      byte ptr [7FF7D595AAD0],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1FC07000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D56BEFE8]
       mov       ecx,65
       mov       rdx,7FF7D5518D68
       call      qword ptr [7FF7D511F228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D5518D68
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57FD2C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57FD2D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5060F88
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
       mov       r11,7FF7D5060F90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FC07000A98
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5060F60
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5060F80
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
       mov       r11,7FF7D5060F80
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23C85F00008
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
       call      qword ptr [7FF7D591EA60]
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
       jmp       qword ptr [7FF7D5115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1F2F0000AC8
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
       mov       rcx,1F2DA000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4E27C965
       mov       r8d,440EC844
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
       mov       r11,7FF7D5051148
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
       mov       r11,7FF7D5051150
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FF7D5051140
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FF7D593E418]
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
       test      byte ptr [7FF7D5992290],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,1F2F0000AD8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FF7D56AEAC0]
       mov       ecx,65
       mov       rdx,7FF7D5508D68
       call      qword ptr [7FF7D510F228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D5508D68
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57E4DB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57E4DC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FF7D5051160
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
       mov       r11,7FF7D5051168
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F2F0000AD8
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FF7D5051138
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FF7D5051158
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
       mov       r11,7FF7D5051158
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2336F1A0008
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
       call      qword ptr [7FF7D593E358]
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
       jmp       qword ptr [7FF7D5105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5060DB0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5060DA8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57FC678]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5060DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5060DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5050B28
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5050B20
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57C49F0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5050B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5050B30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5060DB0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5060DA8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57FC660]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5060DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5060DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5040DB0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5040DA8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57DC6D8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5040DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5040DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5020DB0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5020DA8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57AC1F8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5020DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5020DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5040DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5040DB0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57EC648]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5040DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5030F78
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D5030F70
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57CD9B0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5030F88
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5030F80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D50511F8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FF7D50511F0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FF7D57E5500]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FF7D5051208
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5051200
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5040DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5040DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57CC180]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5040DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5040DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5040DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57DC660]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5040DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5040DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5050DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5050DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57FC630]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5050DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5050DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5060DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5060DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57FC660]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5060DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5060DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5020DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5020DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57AC180]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5020DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5020DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5050DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5050DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57DC180]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5050DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5050DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5040F38
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D5040F30
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57DDEC0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5040F48
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5040F40
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FF7D5061200
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FF7D50611F8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FF7D57F54E8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FF7D5061210
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FF7D5061208
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

