## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L33
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L23
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
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
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L26
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L29
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L28
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L27
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L12
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L12
       jmp       short M00_L09
M00_L07:
       mov       r8,[r15]
       mov       r10,[r15+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L08:
       test      eax,eax
       jne       near ptr M00_L19
M00_L09:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L20
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L13
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L21
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L14
       test      r15,r15
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       r15,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r15
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L10:
       mov       r11,r8
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       eax,r11d
M00_L11:
       test      eax,eax
       jne       near ptr M00_L19
M00_L12:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L16
       lea       rsi,[rcx+8]
       mov       rax,[rsi]
       mov       edx,[rsi+10]
       mov       r8,[rsi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L20
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L13
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L21
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L18
       test      r15,r15
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       lea       r8,[r15+0C]
       add       rdx,0C
       mov       r10d,[r15+8]
       add       r10d,r10d
       cmp       r10,0A
       je        near ptr M00_L10
       mov       rcx,r8
       mov       r8,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L13:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L22
M00_L14:
       mov       edx,1
       mov       eax,edx
       jmp       near ptr M00_L08
M00_L15:
       xor       edx,edx
       mov       eax,edx
       jmp       near ptr M00_L08
M00_L16:
       mov       r11,7FFA068E0FF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E1000
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L11
M00_L17:
       xor       r11d,r11d
       mov       eax,r11d
       jmp       near ptr M00_L11
M00_L18:
       mov       r11d,1
       mov       eax,r11d
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L20:
       call      qword ptr [7FFA06BBC9F0]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L31
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L24:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L25:
       call      qword ptr [7FFA06BBC2D0]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFA068E1010
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15C7A800A90
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFA068E1018
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15C7A800A90
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFA068E0FF0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E1008
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L32:
       call      M00_L34
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L33:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L35
       mov       r11,7FFA068E1008
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1199
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
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        short M02_L03
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        short M02_L01
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M02_L08
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        near ptr M02_L07
M02_L00:
       xor       eax,eax
       vzeroupper
       ret
M02_L01:
       cmp       r8,10
       jae       near ptr M02_L09
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L02:
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L02
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M02_L02
M02_L07:
       add       rax,20
       cmp       r8,rax
       jbe       short M02_L08
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L00
       jmp       short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M02_L00
       jmp       short M02_L12
M02_L09:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L00
M02_L10:
       add       rax,10
       cmp       r8,rax
       jbe       short M02_L11
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L00
       jmp       short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L00
M02_L12:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 357
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
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
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L28
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L31
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L30
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L29
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L18
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L18
       jmp       short M00_L09
M00_L07:
       mov       edx,1
M00_L08:
       test      edx,edx
       jne       near ptr M00_L21
M00_L09:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L19
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
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
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L10
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L11
M00_L10:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L11:
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L12:
       xor       edx,edx
       jmp       near ptr M00_L08
M00_L13:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       edx,r11d
       mov       eax,edx
M00_L14:
       mov       edx,eax
       jmp       short M00_L17
M00_L15:
       xor       edx,edx
       jmp       short M00_L17
M00_L16:
       mov       edx,1
M00_L17:
       test      edx,edx
       jne       near ptr M00_L21
M00_L18:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L20
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L22
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L19
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L16
       test      r15,r15
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L13
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L24
M00_L20:
       mov       r11,7FFA068E0DB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E0DB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L17
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L34
M00_L22:
       call      qword ptr [7FFA06BBC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L33
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L27:
       call      qword ptr [7FFA06BB7A20]
       int       3
M00_L28:
       mov       rcx,r11
       mov       r11,7FFA068E0DC8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15A47802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFA068E0DD0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15A47802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFA068E0DA8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E0DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L34:
       call      M00_L36
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L37
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA068E0DC0
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1169
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
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
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
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L28
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L31
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L30
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L29
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L18
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L18
       jmp       short M00_L10
M00_L07:
       xor       edx,edx
       jmp       short M00_L09
M00_L08:
       mov       edx,1
M00_L09:
       test      edx,edx
       jne       near ptr M00_L21
M00_L10:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L19
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L08
       test      r15,r15
       je        short M00_L07
       test      rdx,rdx
       je        near ptr M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L11
       mov       rcx,r10
       call      qword ptr [7FFA069BFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L12
M00_L11:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L12:
       mov       edx,eax
       jmp       near ptr M00_L09
M00_L13:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       edx,r11d
       mov       eax,edx
M00_L14:
       mov       edx,eax
       jmp       short M00_L17
M00_L15:
       xor       edx,edx
       jmp       short M00_L17
M00_L16:
       mov       edx,1
M00_L17:
       test      edx,edx
       jne       near ptr M00_L21
M00_L18:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L20
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L22
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L19
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L16
       test      r15,r15
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L13
       mov       rcx,r10
       call      qword ptr [7FFA069BFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L24
M00_L20:
       mov       r11,7FFA06900F48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,[rbp-38]
       mov       r11,7FFA06900F50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L17
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L34
M00_L22:
       call      qword ptr [7FFA06BDC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L33
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L27:
       call      qword ptr [7FFA06BD7A20]
       int       3
M00_L28:
       mov       rcx,r11
       mov       r11,7FFA06900F60
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA069B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2591B802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFA06900F68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA069B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2591B802000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFA06900F40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FFA06900F58
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L34:
       call      M00_L36
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L37
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA06900F58
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1174
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
       call      qword ptr [7FFA069BFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA069B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
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
       jne       near ptr M00_L26
       inc       esi
       cmp       esi,edi
       jl        short M00_L01
M00_L02:
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L28
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L31
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L30
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L29
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L18
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L18
       jmp       short M00_L09
M00_L07:
       mov       edx,1
M00_L08:
       test      edx,edx
       jne       near ptr M00_L21
M00_L09:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L19
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
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
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L10
       mov       rcx,r10
       call      qword ptr [7FFA069AFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L11
M00_L10:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L11:
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L12:
       xor       edx,edx
       jmp       near ptr M00_L08
M00_L13:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       edx,r11d
       mov       eax,edx
M00_L14:
       mov       edx,eax
       jmp       short M00_L17
M00_L15:
       xor       edx,edx
       jmp       short M00_L17
M00_L16:
       mov       edx,1
M00_L17:
       test      edx,edx
       jne       near ptr M00_L21
M00_L18:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L20
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L22
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L19
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L16
       test      r15,r15
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L13
       mov       rcx,r10
       call      qword ptr [7FFA069AFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L24
M00_L20:
       mov       r11,7FFA068F0DA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,[rbp-38]
       mov       r11,7FFA068F0DA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L17
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L34
M00_L22:
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L33
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L26:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L27:
       call      qword ptr [7FFA06BC7A20]
       int       3
M00_L28:
       mov       rcx,r11
       mov       r11,7FFA068F0DB8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA069A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E79F002000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFA068F0DC0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA069A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E79F002000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFA068F0D98
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068F0DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L34:
       call      M00_L36
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L37
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA068F0DB0
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1169
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
       call      qword ptr [7FFA069AFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
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
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L33
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L29
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L32
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L31
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L30
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L16
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L16
       jmp       short M00_L09
M00_L07:
       mov       edx,1
M00_L08:
       test      edx,edx
       jne       near ptr M00_L13
M00_L09:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L20
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
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
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L10
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L11
M00_L10:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L11:
       mov       edx,eax
       jmp       near ptr M00_L08
M00_L12:
       xor       edx,edx
       jmp       near ptr M00_L08
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L24
M00_L14:
       mov       edx,1
M00_L15:
       test      edx,edx
       jne       short M00_L13
M00_L16:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L21
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L22
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L20
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L14
       test      r15,r15
       je        short M00_L19
       test      rdx,rdx
       je        short M00_L19
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L19
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L17
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L18
M00_L17:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       edx,r11d
       mov       eax,edx
M00_L18:
       mov       edx,eax
       jmp       near ptr M00_L15
M00_L19:
       xor       edx,edx
       jmp       near ptr M00_L15
M00_L20:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L25
M00_L21:
       mov       r11,7FFA068E0F40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E0F48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L15
M00_L22:
       call      qword ptr [7FFA06BBC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       call      M00_L36
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L25:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L34
M00_L26:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L27:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L28:
       call      qword ptr [7FFA06BB7A20]
       int       3
M00_L29:
       mov       rcx,r11
       mov       r11,7FFA068E0F58
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L30:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22134C02000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFA068E0F60
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22134C02000
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA068E0F38
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E0F50
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L37
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA068E0F50
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1154
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
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L35
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L26
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       jne       short M00_L04
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L28
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
       xor       esi,esi
M00_L03:
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
M00_L04:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L33
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L29
       mov       r14d,[r11+10]
M00_L05:
       test      r14d,r14d
       je        near ptr M00_L32
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L31
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L30
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L06:
       mov       [rbp-38],rsi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L19
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L19
       jmp       short M00_L12
M00_L07:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L08:
       mov       edx,eax
       jmp       short M00_L11
M00_L09:
       xor       edx,edx
       jmp       short M00_L11
M00_L10:
       mov       edx,1
M00_L11:
       test      edx,edx
       jne       near ptr M00_L13
M00_L12:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L20
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L10
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        near ptr M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L09
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L07
       mov       rcx,r10
       call      qword ptr [7FFA0698FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L13:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L24
M00_L14:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r11b
       movzx     r11d,r11b
       mov       edx,r11d
       mov       eax,edx
M00_L15:
       mov       edx,eax
       jmp       short M00_L18
M00_L16:
       xor       edx,edx
       jmp       short M00_L18
M00_L17:
       mov       edx,1
M00_L18:
       test      edx,edx
       jne       short M00_L13
M00_L19:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L21
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L22
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L20
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L17
       test      r15,r15
       je        near ptr M00_L16
       test      rdx,rdx
       je        near ptr M00_L16
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L16
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L14
       mov       rcx,r10
       call      qword ptr [7FFA0698FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L20:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L25
M00_L21:
       mov       r11,7FFA068D0CA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-38]
       mov       r11,7FFA068D0CB0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       edx,eax
       jmp       near ptr M00_L18
M00_L22:
       call      qword ptr [7FFA06BAC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       call      M00_L36
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L03
M00_L25:
       cmp       rbx,rdi
       je        near ptr M00_L02
       jmp       near ptr M00_L34
M00_L26:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L27:
       mov       esi,1
       jmp       near ptr M00_L03
M00_L28:
       call      qword ptr [7FFA06BA7A20]
       int       3
M00_L29:
       mov       rcx,r11
       mov       r11,7FFA068D0CC0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L05
M00_L30:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,258F8C01FC8
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFA068D0CC8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA06985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,258F8C01FC8
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA068D0CA0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068D0CB8
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L03
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L37
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA068D0CB8
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1176
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
       call      qword ptr [7FFA0698FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA06985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L23
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       jne       short M00_L01
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L00
       add       r14,10
       jmp       near ptr M00_L24
M00_L00:
       call      qword ptr [7FFA06B97A20]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L33
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L29
       mov       r14d,[r11+10]
M00_L02:
       test      r14d,r14d
       je        near ptr M00_L32
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L31
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L30
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rdi
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
M00_L03:
       mov       [rbp-40],rsi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L12
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L12
       jmp       short M00_L06
M00_L04:
       mov       r13d,1
M00_L05:
       test      r13d,r13d
       jne       near ptr M00_L17
M00_L06:
       mov       rcx,[rbp-40]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L19
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L16
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        short M00_L04
       test      r15,r15
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L07
       mov       rcx,r10
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L08
M00_L07:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      r13b
       movzx     r13d,r13b
M00_L08:
       jmp       near ptr M00_L05
M00_L09:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L10:
       mov       r13d,1
M00_L11:
       test      r13d,r13d
       jne       near ptr M00_L17
M00_L12:
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       jne       near ptr M00_L18
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8,rdx
       mov       r10d,[rsi+10]
       cmp       r10d,[rdx+14]
       jne       near ptr M00_L19
       mov       edx,[rsi+14]
       cmp       edx,[r8+10]
       jae       near ptr M00_L16
       mov       r14,[r8+8]
       mov       r8d,edx
       cmp       r8d,[r14+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r15,rdx
       je        near ptr M00_L10
       test      r15,r15
       je        short M00_L15
       test      rdx,rdx
       je        short M00_L15
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L15
       lea       r10,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L13
       mov       rcx,r10
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L14
M00_L13:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r13b
       movzx     r13d,r13b
M00_L14:
       jmp       near ptr M00_L11
M00_L15:
       xor       r13d,r13d
       jmp       near ptr M00_L11
M00_L16:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M00_L22
M00_L17:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L21
M00_L18:
       mov       r11,7FFA068C1258
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-40]
       mov       r11,7FFA068C1260
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L11
M00_L19:
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       call      M00_L36
       nop
       mov       esi,[rbp-34]
       jmp       short M00_L27
M00_L22:
       cmp       rbx,rdi
       je        short M00_L26
       jmp       near ptr M00_L34
M00_L23:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L24:
       test      edi,edi
       jle       short M00_L26
       xor       esi,esi
M00_L25:
       mov       rdx,[r14+rsi]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L28
       add       rsi,8
       dec       edi
       jne       short M00_L25
M00_L26:
       xor       esi,esi
M00_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       mov       esi,1
       jmp       short M00_L27
M00_L29:
       mov       rcx,r11
       mov       r11,7FFA068C1270
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,254A5402A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFA068C1278
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L32:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,254A5402A98
       mov       rsi,[rcx]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA068C1250
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L34:
       mov       rcx,[rbp-40]
       mov       r11,7FFA068C1268
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L27
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L37
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdi
       je        short M00_L37
       mov       r11,7FFA068C1268
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1143
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
       jne       near ptr M01_L12
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
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L12
M01_L09:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L10
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L12
       jmp       short M01_L09
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
; Total bytes of code 318
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
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L38
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L25
       mov       rsi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rsi
       jne       short M00_L01
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L00
       add       r14,10
       jmp       near ptr M00_L26
M00_L00:
       call      qword ptr [7FFA06BB7A20]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L35
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L31
       mov       r14d,[r11+10]
M00_L02:
       test      r14d,r14d
       je        near ptr M00_L34
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L33
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       esi,[rbx+14]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],esi
       mov       [rdi+1C],ecx
M00_L03:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        short M00_L04
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       je        short M00_L08
M00_L04:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,rdx
       jne       near ptr M00_L12
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       r8d,[rsi+10]
       mov       r10,[rsi]
       cmp       r8d,[r10+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rdx+10]
       jb        near ptr M00_L13
M00_L05:
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L24
M00_L06:
       mov       r15d,1
M00_L07:
       test      r15d,r15d
       jne       near ptr M00_L21
M00_L08:
       mov       rcx,[rbp-38]
       lea       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,rdx
       mov       r8d,[rsi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L22
       mov       r8d,[rsi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L05
       mov       rdi,[rax+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r14,rdx
       je        short M00_L06
       test      r14,r14
       je        short M00_L11
       test      rdx,rdx
       je        short M00_L11
       mov       r8d,[r14+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L11
       lea       r10,[r14+0C]
       add       rdx,0C
       mov       r8d,[r14+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L09
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r15d,eax
       jmp       short M00_L10
M00_L09:
       mov       r8,[r10]
       mov       r10,[r10+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       r10,[rdx+2]
       or        r8,r10
       sete      r15b
       movzx     r15d,r15b
M00_L10:
       jmp       near ptr M00_L07
M00_L11:
       xor       r15d,r15d
       jmp       near ptr M00_L07
M00_L12:
       mov       r11,7FFA068E1928
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L24
M00_L13:
       mov       rdi,[rdx+8]
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L23
       mov       edx,r8d
       mov       rdx,[rdi+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+28]
       mov       rax,[rbp+10]
       mov       rdx,[rax+48]
       mov       rdx,[rdx+28]
       cmp       r14,rdx
       jne       short M00_L15
       jmp       near ptr M00_L19
M00_L14:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E1930
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r15d,eax
       jmp       short M00_L20
M00_L15:
       test      r14,r14
       je        short M00_L18
       test      rdx,rdx
       je        short M00_L18
       mov       r8d,[r14+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L18
       add       r14,0C
       mov       r10,r14
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L16
       mov       rcx,r10
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r15d,eax
       jmp       short M00_L17
M00_L16:
       mov       r11,r10
       mov       r8,[r11]
       mov       r11,[r11+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       r11,[rdx+2]
       or        r11,r8
       sete      r15b
       movzx     r15d,r15b
M00_L17:
       jmp       short M00_L20
M00_L18:
       xor       r15d,r15d
       jmp       short M00_L20
M00_L19:
       mov       r15d,1
M00_L20:
       test      r15d,r15d
       je        near ptr M00_L04
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L37
M00_L22:
       call      qword ptr [7FFA06BBC150]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L28
       jmp       near ptr M00_L36
M00_L25:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L26:
       test      edi,edi
       jle       short M00_L28
       xor       esi,esi
M00_L27:
       mov       rdx,[r14+rsi]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L30
       add       rsi,8
       dec       edi
       jne       short M00_L27
M00_L28:
       xor       esi,esi
M00_L29:
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
M00_L30:
       mov       esi,1
       jmp       short M00_L29
M00_L31:
       mov       rcx,r11
       mov       r11,7FFA068E1940
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F657002BD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFA068E1948
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L34:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F657002BD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFA068E1920
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068E1938
       call      qword ptr [r11]
       jmp       near ptr M00_L28
M00_L37:
       call      M00_L39
       nop
       mov       esi,[rbp-2C]
       jmp       near ptr M00_L29
M00_L38:
       xor       esi,esi
       jmp       near ptr M00_L29
M00_L39:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L40
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r11
       je        short M00_L40
       mov       r11,7FFA068E1938
       call      qword ptr [r11]
M00_L40:
       nop
       add       rsp,28
       ret
; Total bytes of code 1135
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
       call      qword ptr [7FFA0699FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,28A8D4009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       inc       edi
       cmp       edi,r14d
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       xchg      ax,ax
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L14
M00_L11:
       lea       rbx,[rdi+8]
       mov       rax,[rbx]
       mov       ecx,[rbx+10]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+14]
       jne       short M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFA068F0F30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068F0F38
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L16:
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28A8D4009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA069A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28A8D4009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06BC7A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068F0F48
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A77402000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068F0F50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A77402000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068F0F28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068F0F40
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068F0F40
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA071AE820]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1324B0009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       inc       edi
       cmp       edi,r14d
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       xchg      ax,ax
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L14
M00_L11:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFA068C0F30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068C0F38
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L16:
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1324B0009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA06976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1324B0009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06B97A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068C0F48
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13235002000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068C0F50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13235002000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068C0F28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068C0F40
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068C0F40
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA0717E7F0]
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,2C642C029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       inc       edi
       cmp       edi,r14d
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       xchg      ax,ax
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L14
M00_L11:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFA068C0F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068C0F40
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L16:
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C642C029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA06976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C642C029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06B97A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068C0F50
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C642C02000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068C0F58
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C642C02000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068C0F30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068C0F48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068C0F48
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA0717E868]
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1F4910029F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L03
M00_L02:
       mov       rdx,[r15+rdi*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       inc       edi
       cmp       edi,r14d
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
       xchg      ax,ax
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L14
M00_L11:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L16
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFA068C0DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068C0DC0
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L16:
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F4910029E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA06976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F4910029F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06B97A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068C0DD0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F491002000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068C0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F491002000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068C0DB0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068C0DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068C0DC8
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA0717E820]
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1E811C009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       xor       edi,edi
M00_L02:
       mov       rdx,[r15+rdi]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       add       rdi,8
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L13
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L13
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L17
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L16
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L16
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L15
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L14
M00_L11:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L17
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFA068C0F40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068C0F48
       call      qword ptr [r11]
M00_L15:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E811C009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA06976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E811C009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06B97A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068C0F60
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E7FBC02000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068C0F68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E7FBC02000
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068C0F38
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068C0F50
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068C0F50
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA0717E7A8]
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,230D9C009F8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L19
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L05
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L22
       add       r15,10
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       xor       edi,edi
M00_L02:
       mov       rdx,[r15+rdi]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       near ptr M00_L20
       add       rdi,8
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
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L06:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L07:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L14
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L14
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L14
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L13
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L12
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L08
M00_L09:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L17
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L16
M00_L10:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L15
M00_L11:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L13
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L12:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L18
M00_L13:
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L14:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L11
M00_L15:
       mov       rcx,rdi
       mov       r11,7FFA068F0F48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFA068F0F50
       call      qword ptr [r11]
M00_L16:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L10
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       cmp       [rdi],r14
       je        near ptr M00_L03
       jmp       near ptr M00_L28
M00_L19:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,1
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,230D9C009F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA069A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,230D9C009F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFA06BC7A20]
       int       3
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068F0F60
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,230C3C02008
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068F0F68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,230C3C02008
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068F0F40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068F0F58
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L04
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068F0F58
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFA071AE820]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1BFB3402A48
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L30
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L16
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L02
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        short M00_L01
       add       r15,10
       jmp       near ptr M00_L17
M00_L01:
       call      qword ptr [7FFA06BC7A20]
       int       3
M00_L02:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L27
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L23
       mov       r15d,[r11+10]
M00_L03:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L25
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L24
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L04:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L11
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       jne       near ptr M00_L11
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L11
M00_L05:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       near ptr M00_L10
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jae       near ptr M00_L09
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L14
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       jmp       short M00_L05
M00_L06:
       mov       r15,[rax+8]
       cmp       r8d,[r15+8]
       jae       near ptr M00_L14
       mov       ecx,r8d
       mov       rdx,[r15+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rax,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L13
M00_L07:
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       jne       short M00_L12
M00_L08:
       lea       rbx,[rdi+8]
       mov       rcx,[rbx]
       mov       rax,rcx
       mov       edx,[rbx+10]
       cmp       edx,[rcx+14]
       jne       short M00_L10
       mov       r8d,[rbx+14]
       cmp       r8d,[rax+10]
       jb        short M00_L06
M00_L09:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       short M00_L15
M00_L10:
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L11:
       mov       rdi,[rbp-38]
       cmp       [rdi],edi
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdi],r14
       je        short M00_L08
M00_L12:
       mov       rcx,rdi
       mov       r11,7FFA068F1278
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFA068F1280
       call      qword ptr [r11]
M00_L13:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L07
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L29
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       je        short M00_L19
       jmp       near ptr M00_L28
M00_L16:
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
M00_L17:
       test      r14d,r14d
       jle       short M00_L19
       xor       edi,edi
M00_L18:
       mov       rdx,[r15+rdi]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L21
       add       rdi,8
       dec       r14d
       jne       short M00_L18
M00_L19:
       xor       ebx,ebx
M00_L20:
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
M00_L21:
       mov       ebx,1
       jmp       short M00_L20
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BFB3402A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA069A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BFB3402A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,r11
       mov       r11,7FFA068F1290
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BFB3402AA8
       mov       rdi,[rcx]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,rbx
       mov       r11,7FFA068F1298
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BFB3402AA8
       mov       rdi,[rcx]
       jmp       near ptr M00_L04
M00_L27:
       mov       rcx,rbx
       mov       r11,7FFA068F1270
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L28:
       mov       rcx,rdi
       mov       r11,7FFA068F1288
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L20
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L20
M00_L31:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L32
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rdi,[rbp-38]
       cmp       [rdi],r14
       je        short M00_L32
       mov       rcx,rdi
       mov       r11,7FFA068F1288
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 970
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
       call      qword ptr [7FFA071A4D98]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,27319C00BB0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L29
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L17
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       short M00_L02
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        short M00_L01
       add       r15,10
       jmp       near ptr M00_L18
M00_L01:
       call      qword ptr [7FFA06BC7A20]
       int       3
M00_L02:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L26
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L22
       mov       r15d,[r11+10]
M00_L03:
       test      r15d,r15d
       je        near ptr M00_L25
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L24
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L23
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,r14
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
M00_L04:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        short M00_L06
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r14
       jne       short M00_L06
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rdx
       jne       short M00_L06
M00_L05:
       lea       rdi,[rcx+8]
       mov       rdx,[rdi]
       mov       rax,rdx
       mov       r8d,[rdi+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jae       short M00_L07
       mov       rsi,[rax+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L13
       mov       edx,r8d
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       jmp       short M00_L05
M00_L06:
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r14
       jne       short M00_L08
       lea       rdi,[rcx+8]
       mov       rax,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L12
       mov       r8d,[rdi+14]
       cmp       r8d,[rax+10]
       jb        short M00_L09
M00_L07:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L14
M00_L08:
       mov       r11,7FFA068F1940
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       jmp       short M00_L14
M00_L09:
       mov       rdx,[rax+8]
       cmp       r8d,[rdx+8]
       jae       short M00_L13
       mov       eax,r8d
       mov       rdx,[rdx+rax*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+10]
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L11
       jmp       near ptr M00_L06
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068F1948
       call      qword ptr [r11]
       mov       rdx,rax
M00_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L06
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L28
M00_L12:
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       cmp       rbx,r14
       jne       near ptr M00_L27
M00_L15:
       xor       edi,edi
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
       lea       r15,[rbx+10]
       mov       r14d,[rbx+8]
M00_L18:
       test      r14d,r14d
       jle       short M00_L15
       xor       edi,edi
M00_L19:
       mov       rdx,[r15+rdi]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L20
       add       rdi,8
       dec       r14d
       jne       short M00_L19
       jmp       short M00_L15
M00_L20:
       mov       edi,1
       jmp       short M00_L16
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27319C00BA8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFA069A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27319C00BB0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       mov       rcx,r11
       mov       r11,7FFA068F1958
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27319C00BF0
       mov       rdi,[rcx]
       jmp       near ptr M00_L04
M00_L24:
       mov       rcx,rbx
       mov       r11,7FFA068F1960
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27319C00BF0
       mov       rdi,[rcx]
       jmp       near ptr M00_L04
M00_L26:
       mov       rcx,rbx
       mov       r11,7FFA068F1938
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L27:
       mov       rcx,[rbp-38]
       mov       r11,7FFA068F1950
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L28:
       call      M00_L30
       nop
       mov       edi,[rbp-2C]
       jmp       near ptr M00_L16
M00_L29:
       xor       edi,edi
       jmp       near ptr M00_L16
M00_L30:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,[rbp-38]
       mov       rbx,[rcx]
       mov       r14,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rbx,r14
       je        short M00_L31
       mov       r11,7FFA068F1950
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 965
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
       call      qword ptr [7FFA070B77C8]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1E917001FD8
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
       mov       rcx,1E917000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4A4E6F34
       mov       r8d,659A53DB
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
       mov       r11,7FFA068E0DC0
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
       mov       r11,7FFA068E0DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068E0DB8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFA06BBC150]
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
       call      qword ptr [7FFA06F2EBC8]
       mov       ecx,65
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C75488
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0719D608]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0719D620]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFA068E0DD8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E917002008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFA068E0DE0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E917002008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFA068E0DB0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFA068E0DD0
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
       mov       r11,7FFA068E0DD0
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,229ABFA0008
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
       call      qword ptr [7FFA0719FB58]
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1D3B0801FD8
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
       mov       rcx,1D3B0800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C9F178F7
       mov       r8d,0EE2B2CB8
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
       mov       r11,7FFA068F0DB8
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
       mov       r11,7FFA068F0DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068F0DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFA06BCC150]
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
       call      qword ptr [7FFA06F3EBC8]
       mov       ecx,65
       mov       rdx,7FFA06DA5BF8
       call      qword ptr [7FFA06BC77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C85488
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA069A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06DA5BF8
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA069A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA071AD6B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA071AD6C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFA068F0DD0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D3B0802008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFA068F0DD8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D3B0802008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFA068F0DA8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFA068F0DC8
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
       mov       r11,7FFA068F0DC8
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
       mov       rax,214456B0008
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
       call      qword ptr [7FFA071AFB58]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2EB2F001FD8
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
       mov       rcx,2EB2F000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6DAC1D63
       mov       r8d,0D34F131F
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
       mov       r11,7FFA068D0DB0
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
       mov       r11,7FFA068D0DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068D0DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFA06BAC150]
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
       call      qword ptr [7FFA06F1EBC8]
       mov       ecx,65
       mov       rdx,7FFA06D85BF8
       call      qword ptr [7FFA06BA77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C65488
       call      qword ptr [7FFA06BA77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D85BF8
       call      qword ptr [7FFA06BA77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0718D680]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0718D698]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFA068D0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2EB2F002008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFA068D0DD0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2EB2F002008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFA068D0DA0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFA068D0DC0
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
       mov       r11,7FFA068D0DC0
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,32BC4270008
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
       call      qword ptr [7FFA0718FBD0]
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
       jmp       qword ptr [7FFA06985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1CF1DC01FD8
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
       mov       rcx,1CF1DC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A38CEE9F
       mov       r8d,6E7AF786
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
       mov       r11,7FFA068E0DB0
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
       mov       r11,7FFA068E0DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068E0DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFA06BBC150]
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
       call      qword ptr [7FFA06F2EBC8]
       mov       ecx,65
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C75488
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0719D4D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0719D4E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFA068E0DC8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CF1DC02008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFA068E0DD0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CF1DC02008
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFA068E0DA0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFA068E0DC0
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
       mov       r11,7FFA068E0DC0
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20FB2CB0008
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
       call      qword ptr [7FFA0719FB10]
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,19FE5801FD8
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
       mov       rcx,19FE5800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0AD678FB8
       mov       r8d,0FFDC2601
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
       call      qword ptr [7FFA06B9C150]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FFA068C0F70
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
       mov       r11,7FFA068C0F78
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068C0F68
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
       call      qword ptr [7FFA06F0EB80]
       mov       ecx,65
       mov       rdx,7FFA06D75BF8
       call      qword ptr [7FFA06B977B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C55488
       call      qword ptr [7FFA06B977B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D75BF8
       call      qword ptr [7FFA06B977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0717D800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0717D818]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFA068C0F88
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19FE5801FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFA068C0F90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19FE5801FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFA068C0F60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FFA068C0F80
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
       mov       r11,7FFA068C0F80
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
       mov       rax,1E07A6D0008
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
       call      qword ptr [7FFA0717FC30]
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
       jmp       qword ptr [7FFA06975C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,26E60001FD8
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
       mov       rcx,26E60000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4DC681A
       mov       r8d,0A703E1E9
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
       call      qword ptr [7FFA06BAC150]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FFA068D0DF0
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
       mov       r11,7FFA068D0DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068D0DE8
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
       call      qword ptr [7FFA06F1EB80]
       mov       ecx,65
       mov       rdx,7FFA06D85BF8
       call      qword ptr [7FFA06BA77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C65488
       call      qword ptr [7FFA06BA77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D85BF8
       call      qword ptr [7FFA06BA77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0718D710]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0718D728]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFA068D0E08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26E60001FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFA068D0E10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26E60001FE8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFA068D0DE0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FFA068D0E00
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
       mov       r11,7FFA068D0E00
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AEF5010008
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
       call      qword ptr [7FFA0718FBE8]
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
       jmp       qword ptr [7FFA06985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,17B8B401FC0
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
       mov       rcx,17B8B400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,768A2EA7
       mov       r8d,4D2A37
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
       call      qword ptr [7FFA06BCC150]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FFA068F1108
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
       mov       r11,7FFA068F1110
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068F1100
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
       call      qword ptr [7FFA06F36E98]
       mov       ecx,65
       mov       rdx,7FFA06DA5BF8
       call      qword ptr [7FFA06BC77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C85488
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA069A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06DA5BF8
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA069A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA071AF0F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA071AF108]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFA068F1120
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17B8B401FD0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFA068F1128
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17B8B401FD0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFA068F10F8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FFA068F1118
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
       mov       r11,7FFA068F1118
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
       mov       rax,1BC202B0008
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
       call      qword ptr [7FFA071AFA50]
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
       jmp       qword ptr [7FFA069A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1B40AC02BA0
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
       mov       rcx,1B40AC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,3BC1707A
       mov       r8d,68083223
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
       mov       r11,7FFA068E1998
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
       mov       r11,7FFA068E19A0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FFA068E1990
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FFA06BBC150]
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
       call      qword ptr [7FFA06F2E190]
       mov       ecx,65
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       r15,rax
       mov       ecx,1B55
       mov       rdx,7FFA06C75488
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA06D95BF8
       call      qword ptr [7FFA06BB77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA06997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0709C540]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0709C558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FFA068E19B0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B40AC02BB0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFA068E19B8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B40AC02BB0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFA068E1988
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FFA068E19A8
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
       mov       r11,7FFA068E19A8
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
       call      00007FFA66629F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA06995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F49FC10008
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
       call      qword ptr [7FFA071B6A90]
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
       jmp       qword ptr [7FFA06995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA068D0F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA068D0F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA0709DBC0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA068D0F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068D0F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA06900F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA06900F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA070CDC68]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA06900F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA06900F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA068D0F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA068D0F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA0709DCE0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA068D0F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068D0F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA068E0F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA068E0F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA070ADC38]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA068E0F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068E0F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA068C0F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA068C0F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA0708DC38]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA068C0F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068C0F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA06900F10
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA06900F08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA070CDC68]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA06900F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA06900F18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       r13d,[rcx+10]
M00_L00:
       cmp       edi,r13d
       jge       near ptr M00_L07
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
       mov       r11,7FFA068E1198
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFA068E1190
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFA071A4B10]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFA068E11A8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068E11A0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L06
       test      edi,edi
       jl        near ptr M00_L06
       mov       r14,[rsi]
       mov       r15,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r14,r15
       jne       short M00_L02
       mov       rcx,[rsi+8]
       mov       r11,7FFA068D1950
       call      qword ptr [r11]
M00_L00:
       cmp       edi,eax
       jge       near ptr M00_L06
       cmp       r14,r15
       jne       near ptr M00_L05
       mov       rcx,[rsi+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L04
       cmp       edi,[rcx+10]
       jae       short M00_L03
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
       mov       r11,7FFA068D1948
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFA071A51B8]
       int       3
M00_L04:
       mov       edx,edi
       mov       r11,7FFA068D1960
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L05:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068D1958
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       r14,rbp
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 269
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068E0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068E0F08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA070ADC38]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068E0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068E0F18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068E0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068E0F08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA070ADBC0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068E0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068E0F18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068D0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068D0F08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA0709DC38]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068D0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068D0F18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068F0F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068F0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA070BDBD8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068F0F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068F0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068C0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068C0F08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA0708DC38]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068C0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068C0F18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068C0F18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068C0F10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA0708DC20]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068C0F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068C0F20
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA068D10C0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFA068D10B8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFA0708EBF8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFA068D10D0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA068D10C8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFA06901950
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
       mov       r11,7FFA06901948
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFA071D51B8]
       int       3
M00_L06:
       mov       edx,edi
       mov       r11,7FFA06901960
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFA06901958
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 288
```

