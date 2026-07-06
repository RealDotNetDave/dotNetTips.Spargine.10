## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L22
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L03
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
M00_L00:
       xor       esi,esi
       cmp       esi,edi
       jl        near ptr M00_L26
M00_L01:
       xor       r14d,r14d
M00_L02:
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
M00_L03:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L28
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L31
M00_L04:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L30
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M00_L23
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
       mov       [rbp-30],rsi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L11
       mov       rsi,[rbp-30]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L11
       jmp       short M00_L08
M00_L06:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
M00_L07:
       test      eax,eax
       jne       near ptr M00_L19
M00_L08:
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L12
       mov       [rsi+8],eax
       mov       r10d,[rsi+8]
       cmp       r10d,[rsi+0C]
       jae       near ptr M00_L18
       mov       r14,[rsi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L20
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L13
       test      rcx,rcx
       je        near ptr M00_L14
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L14
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L06
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L09:
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
M00_L10:
       test      eax,eax
       jne       near ptr M00_L19
M00_L11:
       mov       rsi,[rbp-30]
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rdi
       jne       near ptr M00_L15
       mov       eax,[rsi+8]
       inc       eax
       cmp       eax,[rsi+0C]
       jae       near ptr M00_L12
       mov       [rsi+8],eax
       mov       ecx,[rsi+8]
       cmp       ecx,[rsi+0C]
       jae       near ptr M00_L18
       mov       r14,[rsi+10]
       mov       r10d,[rsi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L20
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L17
       test      rcx,rcx
       je        near ptr M00_L16
       test      rdx,rdx
       je        near ptr M00_L16
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L16
       lea       r8,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       rax,rcx
       cmp       rax,0A
       je        near ptr M00_L09
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L12:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L21
M00_L13:
       mov       eax,1
       jmp       near ptr M00_L07
M00_L14:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFD574D0EC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,rsi
       mov       r11,7FFD574D0EC8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L10
M00_L16:
       xor       eax,eax
       jmp       near ptr M00_L10
M00_L17:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L18:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57E146F0]
       int       3
M00_L19:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L34
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       cmp       rbx,rdi
       je        near ptr M00_L01
       jmp       near ptr M00_L33
M00_L22:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
       jmp       near ptr M00_L00
M00_L23:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFD57D97E70],1
       je        short M00_L29
M00_L24:
       mov       r11,18A42400B10
       mov       rsi,[r11]
       jmp       near ptr M00_L05
M00_L25:
       call      qword ptr [7FFD577AC2D0]
       int       3
M00_L26:
       mov       rdx,[r14+rsi*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L27
       inc       esi
       cmp       esi,edi
       jl        short M00_L26
       jmp       near ptr M00_L01
M00_L27:
       mov       r14d,1
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,r11
       mov       r11,7FFD574D0ED8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L31
       jmp       near ptr M00_L04
M00_L29:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L24
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D0EE0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L31:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18A42400B10
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFD574D0EB8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L33:
       mov       rcx,rsi
       mov       r11,7FFD574D0ED0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L34:
       call      M00_L36
       nop
       mov       r14d,[rbp-24]
       jmp       near ptr M00_L02
M00_L35:
       xor       r14d,r14d
       jmp       near ptr M00_L02
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
       mov       r11,7FFD574D0ED0
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1149
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L01
       cmp       rcx,rdx
       je        near ptr M01_L11
       cmp       r8,20
       jb        near ptr M01_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L07
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M01_L06
M01_L00:
       xor       eax,eax
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
       jmp       short M01_L05
M01_L04:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M01_L05:
       vzeroupper
       ret
M01_L06:
       add       rax,20
       cmp       r8,rax
       jbe       short M01_L07
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M01_L00
       jmp       short M01_L06
M01_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L00
       jmp       short M01_L11
M01_L08:
       cmp       r8,10
       jb        short M01_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L10
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L00
M01_L09:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L10
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L00
       jmp       short M01_L09
M01_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L00
M01_L11:
       mov       eax,1
       vzeroupper
       ret
M01_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L05
; Total bytes of code 352
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L03
       test      rcx,rcx
       je        short M02_L03
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L03
       add       rdx,0C
       add       rcx,0C
       mov       rbx,rcx
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L01
M02_L00:
       mov       rax,[rdx]
       mov       rcx,[rdx+2]
       mov       rdx,[rbx]
       xor       rax,rdx
       xor       rcx,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L01:
       add       rsp,20
       pop       rbx
       ret
M02_L02:
       mov       eax,1
       jmp       short M02_L01
M02_L03:
       xor       eax,eax
       jmp       short M02_L01
; Total bytes of code 119
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFD574C0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFD574C0B50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57D46910]
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
       test      byte ptr [7FFD57D15FB0],1
       je        short M00_L31
M00_L28:
       mov       r11,20EC7C00A20
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFD57797A20]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFD574C0B60
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFD574C0B68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20EC7C00A20
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFD574C0B40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFD574C0B58
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
       mov       r11,7FFD574C0B58
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
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFD574E0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFD574E0B50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57D66A78]
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
       test      byte ptr [7FFD57D35FB0],1
       je        short M00_L31
M00_L28:
       mov       r11,216FCC00A20
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFD577B7A20]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFD574E0B60
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFD574E0B68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,216FCC00A20
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFD574E0B40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFD574E0B58
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
       mov       r11,7FFD574E0B58
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L19:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L24
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFD574D0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L24
       mov       rcx,rsi
       mov       r11,7FFD574D0B50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L17
M00_L21:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57D56A78]
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
       test      byte ptr [7FFD57D25FB0],1
       je        short M00_L31
M00_L28:
       mov       r11,22389400A20
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFD577A7A20]
       int       3
M00_L30:
       mov       rcx,r11
       mov       r11,7FFD574D0B60
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L33
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFD574D0B68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L33:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22389400A20
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,rbx
       mov       r11,7FFD574D0B40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFD574D0B58
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
       mov       r11,7FFD574D0B58
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
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FFD574E0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FFD574E0B50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L18
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57D66A78]
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
       test      byte ptr [7FFD57D35FB0],1
       je        short M00_L32
M00_L29:
       mov       r11,29FF7400A20
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FFD577B7A20]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FFD574E0B60
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFD574E0B68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29FF7400A20
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFD574E0B40
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FFD574E0B58
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
       mov       r11,7FFD574E0B58
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L16
       mov       rsi,[rbp-38]
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rcx
       cmp       rbx,rdi
       jne       near ptr M00_L16
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       eax,1
M00_L15:
       test      eax,eax
       jne       short M00_L13
M00_L16:
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
       je        short M00_L14
       test      r15,r15
       je        short M00_L19
       test      rdx,rdx
       je        short M00_L19
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L19
       lea       r9,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L17
       mov       rcx,r9
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       xor       eax,eax
       jmp       near ptr M00_L15
M00_L20:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       short M00_L25
M00_L21:
       mov       rcx,rsi
       mov       r11,7FFD574E0B68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,rsi
       mov       r11,7FFD574E0B70
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L15
M00_L22:
       mov       ecx,[rsi+8]
       call      qword ptr [7FFD57D66B20]
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
       test      byte ptr [7FFD57D35988],1
       je        short M00_L32
M00_L29:
       mov       r11,1E960C00A28
       mov       rsi,[r11]
       jmp       near ptr M00_L06
M00_L30:
       call      qword ptr [7FFD577B7A20]
       int       3
M00_L31:
       mov       rcx,r11
       mov       r11,7FFD574E0B80
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L34
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L29
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFD574E0B88
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L34:
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E960C00A28
       mov       rsi,[rcx]
       jmp       near ptr M00_L06
M00_L35:
       mov       rcx,rbx
       mov       r11,7FFD574E0B60
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,rsi
       mov       r11,7FFD574E0B78
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
       mov       r11,7FFD574E0B78
       call      qword ptr [r11]
M00_L39:
       nop
       add       rsp,28
       ret
; Total bytes of code 1102
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
       call      qword ptr [7FFD5759FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFD577A7A20]
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
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L10
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,rcx
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L06
M00_L04:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       jne       near ptr M00_L07
M00_L06:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L17
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L18
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L12
       test      rcx,rcx
       je        near ptr M00_L13
       test      rdx,rdx
       je        near ptr M00_L13
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L13
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L04
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L07:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L19
M00_L08:
       mov       rax,rcx
       mov       rcx,rdx
       mov       r11,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rcx]
       xor       r11,rdx
       xor       rax,[rcx+2]
       or        r11,rax
       sete      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       jne       short M00_L07
M00_L10:
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L14
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L17
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L18
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L16
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L08
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L09
M00_L11:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       short M00_L20
M00_L12:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L13:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFD574D0EC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L20
       mov       rcx,rdi
       mov       r11,7FFD574D0EC8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L09
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L09
M00_L16:
       mov       eax,1
       jmp       near ptr M00_L09
M00_L17:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFD57D4E940]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       call      M00_L36
       nop
       mov       r14d,[rbp-24]
       jmp       short M00_L25
M00_L20:
       cmp       rbx,rsi
       je        short M00_L24
       jmp       near ptr M00_L34
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
       pop       r14
       pop       rbp
       ret
M00_L26:
       mov       r14d,1
       jmp       short M00_L25
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFD57D66E90],1
       je        short M00_L30
M00_L28:
       mov       r11,26EF7C00AE0
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L29:
       mov       rcx,r11
       mov       r11,7FFD574D0ED8
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L32
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,rdi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L28
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFD574D0EE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L32:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26EF7C00AE0
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       r11,7FFD574D0EB8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L34:
       mov       rcx,rdi
       mov       r11,7FFD574D0ED0
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L35:
       xor       r14d,r14d
       jmp       near ptr M00_L25
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L37
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L37
       mov       rcx,rdi
       mov       r11,7FFD574D0ED0
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1128
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
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+28]
       mov       rcx,[rcx+48]
       mov       rcx,[rcx+28]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L03
       test      rcx,rcx
       je        short M02_L03
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L03
       add       rdx,0C
       add       rcx,0C
       mov       rbx,rcx
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFD5758FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L01
M02_L00:
       mov       rax,[rdx]
       mov       rcx,[rdx+2]
       mov       rdx,[rbx]
       xor       rax,rdx
       xor       rcx,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L01:
       add       rsp,20
       pop       rbx
       ret
M02_L02:
       mov       eax,1
       jmp       short M02_L01
M02_L03:
       xor       eax,eax
       jmp       short M02_L01
; Total bytes of code 119
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L34
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       short M00_L01
       mov       esi,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],esi
       jb        short M00_L00
       add       rdi,10
       jmp       near ptr M00_L21
M00_L00:
       call      qword ptr [7FFD57797A20]
       int       3
M00_L01:
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r11
       jne       near ptr M00_L32
       mov       r11,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r11],rax
       jne       near ptr M00_L28
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L31
M00_L02:
       mov       rbx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rbx],rax
       jne       near ptr M00_L30
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L26
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
       mov       [rbp-30],rdi
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L10
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,rcx
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L06
M00_L04:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
M00_L05:
       test      eax,eax
       jne       near ptr M00_L07
M00_L06:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L18
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L16
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L17
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L11
       test      rcx,rcx
       je        near ptr M00_L12
       test      rdx,rdx
       je        near ptr M00_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L12
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L04
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L07:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L19
M00_L08:
       mov       rax,rcx
       mov       rcx,rdx
       mov       r11,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rcx]
       xor       r11,rdx
       xor       rax,[rcx+2]
       or        r11,rax
       sete      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       jne       short M00_L07
M00_L10:
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L13
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L18
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L16
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L17
       mov       ecx,r10d
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rdx+28]
       mov       r9,[rbp+10]
       mov       rdx,[r9+48]
       mov       rdx,[rdx+28]
       cmp       rcx,rdx
       je        near ptr M00_L15
       test      rcx,rcx
       je        near ptr M00_L14
       test      rdx,rdx
       je        short M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L14
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        near ptr M00_L08
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L09
M00_L11:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L12:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L13:
       mov       rcx,rdi
       mov       r11,7FFD574C10E8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L33
       mov       rcx,rdi
       mov       r11,7FFD574C10F0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L09
M00_L14:
       xor       eax,eax
       jmp       near ptr M00_L09
M00_L15:
       mov       eax,1
       jmp       near ptr M00_L09
M00_L16:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFD57DAECA0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L33
M00_L19:
       call      M00_L35
       nop
       mov       r14d,[rbp-24]
       jmp       short M00_L24
M00_L20:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
M00_L21:
       test      esi,esi
       jle       short M00_L23
       xor       r14d,r14d
M00_L22:
       mov       rdx,[rdi+r14]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L25
       add       r14,8
       dec       esi
       jne       short M00_L22
M00_L23:
       xor       r14d,r14d
M00_L24:
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
M00_L25:
       mov       r14d,1
       jmp       short M00_L24
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFD57DE51A8],1
       je        short M00_L29
M00_L27:
       mov       r11,2E6CF002AD0
       mov       rdi,[r11]
       jmp       near ptr M00_L03
M00_L28:
       mov       rcx,r11
       mov       r11,7FFD574C1100
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L31
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L27
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574C1108
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2E6CF002AD0
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L32:
       mov       rcx,rbx
       mov       r11,7FFD574C10E0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L33:
       cmp       rbx,rsi
       je        near ptr M00_L23
       mov       rcx,rdi
       mov       r11,7FFD574C10F8
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L34:
       xor       r14d,r14d
       jmp       near ptr M00_L24
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L36
       mov       rdi,[rbp-30]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L36
       mov       rcx,rdi
       mov       r11,7FFD574C10F8
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 1128
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
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L03
       test      rcx,rcx
       je        short M02_L03
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M02_L03
       add       rdx,0C
       add       rcx,0C
       mov       rbx,rcx
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFD5757FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L01
M02_L00:
       mov       rax,[rdx]
       mov       rcx,[rdx+2]
       mov       rdx,[rbx]
       xor       rax,rdx
       xor       rcx,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L01:
       add       rsp,20
       pop       rbx
       ret
M02_L02:
       mov       eax,1
       jmp       short M02_L01
M02_L03:
       xor       eax,eax
       jmp       short M02_L01
; Total bytes of code 119
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,23D68800A10
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
       mov       r11,7FFD574D0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574D0B50
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
       call      qword ptr [7FFD57D56910]
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
       test      byte ptr [7FFD57D25AB8],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,23D68800A30
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23D68800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23D68800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD577A7A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574D0B60
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
       mov       r11,7FFD574D0B68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23D68800A30
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D0B40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574D0B58
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
       mov       r11,7FFD574D0B58
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
       call      qword ptr [7FFD57D5D5F0]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,24F77C00A10
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
       mov       r11,7FFD574D0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574D0B50
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
       call      qword ptr [7FFD57D56988]
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
       test      byte ptr [7FFD57D260E0],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,24F77C00A30
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24F77C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24F77C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD577A7A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574D0B60
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
       mov       r11,7FFD574D0B68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24F77C00A30
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D0B40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574D0B58
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
       mov       r11,7FFD574D0B58
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
       call      qword ptr [7FFD57D5D5F0]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,28694C02A20
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
       mov       r11,7FFD574D0DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574D0DD8
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
       call      qword ptr [7FFD57D5DF68]
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
       test      byte ptr [7FFD57D69820],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,28694C02AA8
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28694C02A18
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28694C02A20
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD577A7A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574D0DE8
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
       mov       r11,7FFD574D0DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28694C02AA8
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D0DC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574D0DE0
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
       mov       r11,7FFD574D0DE0
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
       call      qword ptr [7FFD57D5C558]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1B5CB800A10
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
       mov       r11,7FFD574C0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574C0B50
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
       call      qword ptr [7FFD57D46AA8]
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
       test      byte ptr [7FFD57D15AB8],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1B5CB800A30
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1B5CB800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B5CB800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD57797A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574C0B60
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFD574C0B68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B5CB800A30
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574C0B40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574C0B58
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
       mov       r11,7FFD574C0B58
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 961
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
       call      qword ptr [7FFD57D4D7A0]
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,1639AC00A10
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
       mov       r11,7FFD574C0B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574C0B50
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
       call      qword ptr [7FFD57D46A90]
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
       test      byte ptr [7FFD57D160D0],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,1639AC00A30
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1639AC00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1639AC00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD57797A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574C0B60
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFD574C0B68
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1639AC00A30
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574C0B40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574C0B58
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
       mov       r11,7FFD574C0B58
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 961
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
       call      qword ptr [7FFD57D4D788]
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,10DC8800A10
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
       mov       r11,7FFD574D0B68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,r14
       mov       r11,7FFD574D0B70
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
       call      qword ptr [7FFD57D56B20]
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
       test      byte ptr [7FFD57D25AB8],1
       je        near ptr M00_L27
M00_L23:
       mov       r11,10DC8800A38
       mov       rdi,[r11]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,10DC8800A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,10DC8800A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFD577A7A20]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574D0B80
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFD574D0B88
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,10DC8800A38
       mov       rdi,[rcx]
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D0B60
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,r14
       mov       r11,7FFD574D0B78
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
       mov       r11,7FFD574D0B78
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 961
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
       call      qword ptr [7FFD57D57270]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,25781C00A10
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
       call      qword ptr [7FFD577B7A20]
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
       mov       r11,7FFD574E0ED8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFD574E0EE0
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
       call      qword ptr [7FFD57D5E0E8]
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
       test      byte ptr [7FFD57D76B90],1
       je        short M00_L27
M00_L24:
       mov       r11,25781C00AE0
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25781C00A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25781C00A10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574E0EF0
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
       mov       r11,7FFD574E0EF8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25781C00AE0
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574E0ED0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFD574E0EE8
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
       mov       r11,7FFD574E0EE8
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
       call      qword ptr [7FFD57D5CB28]
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,26636402AC8
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
       call      qword ptr [7FFD577A7A20]
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
       mov       r11,7FFD574D1260
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFD574D1268
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
       call      qword ptr [7FFD57DCF510]
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
       test      byte ptr [7FFD57E1D750],1
       je        short M00_L27
M00_L24:
       mov       r11,26636402B10
       mov       r14,[r11]
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26636402AC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26636402AC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFD574D1278
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
       mov       r11,7FFD574D1280
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26636402B10
       mov       r14,[rcx]
       jmp       near ptr M00_L04
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFD574D1258
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFD574D1270
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
       mov       r11,7FFD574D1270
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
       call      qword ptr [7FFD57C75500]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,20900000A08
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
       mov       rcx,208EA000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0E750ABE0
       mov       r8d,0FE58D766
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
       mov       r11,7FFD574C0B58
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
       mov       r11,7FFD574C0B60
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574C0B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D46A60]
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
       test      byte ptr [7FFD57D16938],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,20900000A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B17240]
       mov       ecx,65
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57855550
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D46EE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D46EF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574C0B70
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
       mov       r11,7FFD574C0B78
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20900000A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574C0B48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574C0B68
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
       mov       r11,7FFD574C0B68
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2497F040008
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
       call      qword ptr [7FFD57D47150]
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,224F5002A00
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
       mov       rcx,224F5000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7C062283
       mov       r8d,8BF25286
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
       mov       r11,7FFD574E0B58
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
       mov       r11,7FFD574E0B60
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574E0B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D66A30]
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
       test      byte ptr [7FFD57D36938],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,224F5002A30
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B37240]
       mov       ecx,65
       mov       rdx,7FFD579984A8
       call      qword ptr [7FFD577B77B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57875550
       call      qword ptr [7FFD577B77B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57597840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579984A8
       call      qword ptr [7FFD577B77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57597840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D66EB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D66EC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574E0B70
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
       mov       r11,7FFD574E0B78
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,224F5002A30
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574E0B48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574E0B68
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
       mov       r11,7FFD574E0B68
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26589F70008
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
       call      qword ptr [7FFD57D67120]
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2A1FA400A08
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
       mov       rcx,2A1E4400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A574AED6
       mov       r8d,7A8B1C7A
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
       mov       r11,7FFD574C0B58
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
       mov       r11,7FFD574C0B60
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574C0B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D469B8]
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
       test      byte ptr [7FFD57D16310],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2A1FA400A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B17240]
       mov       ecx,65
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57855550
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D46C10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D46C28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574C0B70
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
       mov       r11,7FFD574C0B78
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A1FA400A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574C0B48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574C0B68
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
       mov       r11,7FFD574C0B68
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E279500008
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
       call      qword ptr [7FFD57D47168]
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2122D400A08
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
       mov       rcx,21217400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,27AA68B9
       mov       r8d,0A59EE184
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
       mov       r11,7FFD574E0B58
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
       mov       r11,7FFD574E0B60
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574E0B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D66958]
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
       test      byte ptr [7FFD57D36928],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,2122D400A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B37258]
       mov       ecx,65
       mov       rdx,7FFD579984A8
       call      qword ptr [7FFD577B77B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57875550
       call      qword ptr [7FFD577B77B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57597840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579984A8
       call      qword ptr [7FFD577B77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57597840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D66AA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D66AC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574E0B70
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
       mov       r11,7FFD574E0B78
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2122D400A38
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574E0B48
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574E0B68
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
       mov       r11,7FFD574E0B68
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,252AC2F0008
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
       call      qword ptr [7FFD57D67228]
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
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L25
       mov       rcx,1D8DEC00A08
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L30
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L26
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L28
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L23
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
       jne       near ptr M00_L20
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       [r13+8],ecx
M00_L03:
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L11
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L22
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,1D8C8C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8380212A
       mov       r8d,0B60C3077
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L05:
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
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
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
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57C5DC38]
       int       3
M00_L12:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       je        near ptr M00_L03
       mov       rcx,r13
       mov       r11,7FFD574D0B98
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L13:
       xor       eax,eax
       jmp       short M00_L08
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
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r10d
       jmp       near ptr M00_L07
M00_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFD574D0BA0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L19:
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       xor       esi,esi
       jmp       short M00_L21
M00_L20:
       mov       rcx,r13
       mov       r11,7FFD574D0B90
       call      qword ptr [r11]
       mov       esi,eax
M00_L21:
       test      esi,esi
       jne       near ptr M00_L12
       jmp       near ptr M00_L31
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       test      byte ptr [7FFD57D26928],1
       je        near ptr M00_L27
M00_L24:
       mov       rcx,1D8DEC00A18
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       call      qword ptr [7FFD57B27240]
       mov       ecx,65
       mov       rdx,7FFD579884A8
       call      qword ptr [7FFD577A77B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57865550
       call      qword ptr [7FFD577A77B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57587840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579884A8
       call      qword ptr [7FFD577A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57587840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D56B98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D56BB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       mov       r11,7FFD574D0BB0
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L24
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD574D0BB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D8DEC00A18
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,rsi
       mov       r11,7FFD574D0B88
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L31:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       je        short M00_L32
       mov       rcx,r13
       mov       r11,7FFD574D0BA8
       call      qword ptr [r11]
M00_L32:
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
       je        short M00_L33
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L33
       mov       rcx,rax
       mov       r11,7FFD574D0BA8
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1239
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2195DAB0008
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
       call      qword ptr [7FFD57D57E88]
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
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L25
       mov       rcx,28A2CC00A08
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L30
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L26
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L29
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M00_L28
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L23
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
       jne       near ptr M00_L20
       mov       ecx,[r13+8]
       inc       ecx
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L19
       mov       [r13+8],ecx
M00_L03:
       mov       ecx,[r13+8]
       cmp       ecx,[r13+0C]
       jae       near ptr M00_L11
       mov       rcx,[r13+10]
       mov       r11d,[r13+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L22
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,28A16C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9F21D922
       mov       r8d,4B29EA1C
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L05:
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
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
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
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57C4DC38]
       int       3
M00_L12:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       je        near ptr M00_L03
       mov       rcx,r13
       mov       r11,7FFD574C0B98
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L13:
       xor       eax,eax
       jmp       short M00_L08
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
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r10d
       jmp       near ptr M00_L07
M00_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFD574C0BA0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L19:
       mov       ecx,[r13+0C]
       mov       [r13+8],ecx
       xor       esi,esi
       jmp       short M00_L21
M00_L20:
       mov       rcx,r13
       mov       r11,7FFD574C0B90
       call      qword ptr [r11]
       mov       esi,eax
M00_L21:
       test      esi,esi
       jne       near ptr M00_L12
       jmp       near ptr M00_L31
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       test      byte ptr [7FFD57D16938],1
       je        near ptr M00_L27
M00_L24:
       mov       rcx,28A2CC00A18
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       call      qword ptr [7FFD57B17240]
       mov       ecx,65
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57855550
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579784A8
       call      qword ptr [7FFD577977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57577840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D46DA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D46DC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       mov       r11,7FFD574C0BB0
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L29
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L24
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD574C0BB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A2CC00A18
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,rsi
       mov       r11,7FFD574C0B88
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L31:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       je        short M00_L32
       mov       rcx,r13
       mov       r11,7FFD574C0BA8
       call      qword ptr [r11]
M00_L32:
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
       je        short M00_L33
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L33
       mov       rcx,rax
       mov       r11,7FFD574C0BA8
       call      qword ptr [r11]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1237
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CAABA00008
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
       call      qword ptr [7FFD57D47E88]
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
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,252D7802A18
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
       mov       rcx,252D7800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,54C4E00C
       mov       r8d,0E325710B
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
       mov       r11,7FFD574F0DE8
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
       mov       r11,7FFD574F0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574F0DE0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D76AD8]
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
       test      byte ptr [7FFD57D8E488],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,252D7802A28
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B47240]
       mov       ecx,65
       mov       rdx,7FFD579A84A8
       call      qword ptr [7FFD577C77B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57885550
       call      qword ptr [7FFD577C77B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD575A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579A84A8
       call      qword ptr [7FFD577C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD575A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7D4B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7D4D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574F0E00
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
       mov       r11,7FFD574F0E08
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,252D7802A28
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574F0DD8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574F0DF8
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
       mov       r11,7FFD574F0DF8
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD575A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD575A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2936C980008
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
       call      qword ptr [7FFD57D7D5F0]
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
       jmp       qword ptr [7FFD575A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,14CBA402A90
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
       mov       rcx,14CBA400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,3349354D
       mov       r8d,0C6CC3E5A
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
       mov       r11,7FFD574B1120
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
       mov       r11,7FFD574B1128
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r13
       mov       r11,7FFD574B1118
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L19:
       mov       ecx,[r13+8]
       call      qword ptr [7FFD57D9D410]
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
       test      byte ptr [7FFD57DD6308],1
       je        near ptr M00_L26
M00_L23:
       mov       rcx,14CBA402AA0
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       call      qword ptr [7FFD57B07240]
       mov       ecx,65
       mov       rdx,7FFD579684A8
       call      qword ptr [7FFD577877B0]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFD57845550
       call      qword ptr [7FFD577877B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD57567840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579684A8
       call      qword ptr [7FFD577877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57567840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C4DF98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C4DFB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFD574B1138
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
       mov       r11,7FFD574B1140
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,14CBA402AA0
       mov       r13,[rcx]
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFD574B1110
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L01
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD574B1130
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
       mov       r11,7FFD574B1130
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18D4F3B0008
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
       call      qword ptr [7FFD57D9DAD0]
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
       jmp       qword ptr [7FFD57565C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574B0C48
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574B0C40
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C349C0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574B0C58
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574B0C50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574D0B28
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574D0B20
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C549C0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574D0B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574D0B30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574E0B28
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574E0B20
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C649C0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574E0B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574E0B30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574B0BE8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574B0BE0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C34A08]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574B0BF8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574B0BF0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574D0B28
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574D0B20
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C549C0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574D0B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574D0B30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574C0D68
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574C0D60
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C449D8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574C0D78
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574C0D70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574C0EA8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574C0EA0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C4D278]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574C0EB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574C0EB0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574C11E0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFD574C11D8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFD57C5FFD8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFD574C11F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574C11E8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 301
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574C0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574C0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C449D8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574C0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574C0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574E0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574E0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C649A8]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574E0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574E0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574E0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574E0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C649C0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574E0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574E0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574B0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574B0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C349F0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574B0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574B0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574D0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574D0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C549C0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574D0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574D0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574E0B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574E0B20
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C649C0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574E0B38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574E0B30
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574E0EA8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574E0EA0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C6CB28]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574E0EB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574E0EB0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r11,7FFD574B11E0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFD574B11D8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFD57C4FFC0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFD574B11F0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFD574B11E8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 306
```

