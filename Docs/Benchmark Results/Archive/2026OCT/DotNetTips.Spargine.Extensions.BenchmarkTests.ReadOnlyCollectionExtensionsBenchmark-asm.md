## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L34
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L31
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L27
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L30
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L29
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01BD320],1
       je        near ptr M00_L28
M00_L01:
       mov       rax,14E10C00B38
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L07
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L07
M00_L03:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L08
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L16
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L09
       test      r15,r15
       je        near ptr M00_L10
       test      rdx,rdx
       je        near ptr M00_L10
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L10
       add       r15,0C
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFCDF9AFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       je        near ptr M00_L03
       jmp       near ptr M00_L15
M00_L05:
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L16
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L13
       test      r15,r15
       je        near ptr M00_L12
       test      rdx,rdx
       je        near ptr M00_L12
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L12
       lea       r8,[r15+0C]
       mov       rax,r8
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFCDF9AFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L06:
       test      eax,eax
       jne       near ptr M00_L15
M00_L07:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       short M00_L11
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        near ptr M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L17
M00_L09:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFCDF8F0EA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L17
       mov       rcx,rdi
       mov       r11,7FFCDF8F0EA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       short M00_L06
M00_L12:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L13:
       mov       eax,1
       jmp       near ptr M00_L06
M00_L14:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE0235800]
       int       3
M00_L15:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L33
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       cmp       rbx,rsi
       jne       near ptr M00_L32
M00_L18:
       xor       r14d,r14d
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L26
       add       rdi,10
       jmp       short M00_L22
M00_L21:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L22:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L18
M00_L23:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L24
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L23
       jmp       short M00_L18
M00_L24:
       mov       r14d,1
       jmp       short M00_L19
M00_L25:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L26:
       call      qword ptr [7FFCDFBCC2A0]
       int       3
M00_L27:
       mov       rcx,r11
       mov       r11,7FFCDF8F0EB8
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L30
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFCDF8F0EC0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,14E10C00B38
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFCDF8F0E98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       mov       r11,7FFCDF8F0EB0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L33:
       call      M00_L35
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L19
M00_L34:
       xor       r14d,r14d
       jmp       near ptr M00_L19
M00_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L36
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L36
       mov       rcx,rdi
       mov       r11,7FFCDF8F0EB0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 1063
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
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF9AFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L26
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L29
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L28
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0191A40],1
       je        near ptr M00_L27
M00_L01:
       mov       rax,1E35E002AB8
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L10
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L06
M00_L03:
       xor       eax,eax
       jmp       short M00_L05
M00_L04:
       mov       eax,1
M00_L05:
       test      eax,eax
       jne       near ptr M00_L14
M00_L06:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L04
       test      r15,r15
       je        short M00_L03
       test      rdx,rdx
       je        short M00_L03
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L03
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L07:
       xor       eax,eax
       jmp       short M00_L09
M00_L08:
       mov       eax,1
M00_L09:
       test      eax,eax
       jne       near ptr M00_L14
M00_L10:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L12
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L11
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L08
       test      r15,r15
       je        short M00_L07
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L09
M00_L11:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L16
M00_L12:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L09
M00_L13:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE016EBB0]
       int       3
M00_L14:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       rbx,rsi
       jne       near ptr M00_L31
M00_L17:
       xor       r14d,r14d
M00_L18:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L25
       add       rdi,10
       jmp       short M00_L21
M00_L20:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L17
M00_L22:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L22
       jmp       short M00_L17
M00_L23:
       mov       r14d,1
       jmp       short M00_L18
M00_L24:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L25:
       call      qword ptr [7FFCDFBB7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8E0DF8
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L29
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFCDF995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFCDF995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E35E002AB8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L32:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L18
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L18
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1029
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L26
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L29
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L28
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0191A40],1
       je        near ptr M00_L27
M00_L01:
       mov       rax,24B03C02AB8
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L10
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L06
M00_L03:
       xor       eax,eax
       jmp       short M00_L05
M00_L04:
       mov       eax,1
M00_L05:
       test      eax,eax
       jne       near ptr M00_L14
M00_L06:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L04
       test      r15,r15
       je        short M00_L03
       test      rdx,rdx
       je        short M00_L03
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L03
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L07:
       xor       eax,eax
       jmp       short M00_L09
M00_L08:
       mov       eax,1
M00_L09:
       test      eax,eax
       jne       near ptr M00_L14
M00_L10:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L12
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L11
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L08
       test      r15,r15
       je        short M00_L07
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L09
M00_L11:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L16
M00_L12:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L09
M00_L13:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE016EBC8]
       int       3
M00_L14:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       rbx,rsi
       jne       near ptr M00_L31
M00_L17:
       xor       r14d,r14d
M00_L18:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L25
       add       rdi,10
       jmp       short M00_L21
M00_L20:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L17
M00_L22:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L22
       jmp       short M00_L17
M00_L23:
       mov       r14d,1
       jmp       short M00_L18
M00_L24:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L25:
       call      qword ptr [7FFCDFBB7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8E0DF8
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L29
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFCDF995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0E00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFCDF995728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24B03C02AB8
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L32:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L18
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L18
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1029
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L26
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L29
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L28
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01B2550],1
       je        near ptr M00_L27
M00_L01:
       mov       rax,1A132400AC0
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L10
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L10
       jmp       short M00_L05
M00_L03:
       mov       eax,1
M00_L04:
       test      eax,eax
       jne       near ptr M00_L14
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9BFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L06:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L07:
       xor       eax,eax
       jmp       short M00_L09
M00_L08:
       mov       eax,1
M00_L09:
       test      eax,eax
       jne       near ptr M00_L14
M00_L10:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L12
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L11
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L13
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L08
       test      r15,r15
       je        short M00_L07
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L07
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9BFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L09
M00_L11:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L16
M00_L12:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L16
       mov       rcx,rdi
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L09
M00_L13:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE018EBC8]
       int       3
M00_L14:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L32
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       cmp       rbx,rsi
       jne       near ptr M00_L31
M00_L17:
       xor       r14d,r14d
M00_L18:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L25
       add       rdi,10
       jmp       short M00_L21
M00_L20:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       xor       ebx,ebx
       cmp       ebx,r14d
       jge       short M00_L17
M00_L22:
       mov       rdx,[rdi+rbx*8]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L23
       inc       ebx
       cmp       ebx,r14d
       jl        short M00_L22
       jmp       short M00_L17
M00_L23:
       mov       r14d,1
       jmp       short M00_L18
M00_L24:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L25:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF900E10
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L29
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FFCDF9B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF900E18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L29:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFCDF9B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A132400AC0
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF900E08
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L32:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
       jmp       near ptr M00_L18
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L18
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF900E08
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1032
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF9BFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L31
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L27
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L30
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L29
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01C2B88],1
       je        near ptr M00_L28
M00_L01:
       mov       rax,19C45000AC0
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L11
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L11
       jmp       short M00_L05
M00_L03:
       mov       eax,1
M00_L04:
       test      eax,eax
       jne       near ptr M00_L07
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L12
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L06:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L16
M00_L08:
       xor       eax,eax
       jmp       short M00_L10
M00_L09:
       mov       eax,1
M00_L10:
       test      eax,eax
       jne       short M00_L07
M00_L11:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L13
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L12
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L09
       test      r15,r15
       je        short M00_L08
       test      rdx,rdx
       je        short M00_L08
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L08
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L12:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L18
M00_L13:
       mov       rcx,rdi
       mov       r11,7FFCDF910C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFCDF910C58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L10
M00_L14:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE019EBC8]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       rbx,rsi
       je        short M00_L23
       jmp       near ptr M00_L32
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L26
       add       rdi,10
       jmp       short M00_L21
M00_L20:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       test      r14d,r14d
       jle       short M00_L23
       xor       ebx,ebx
M00_L22:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L24
       add       rbx,8
       dec       r14d
       jne       short M00_L22
M00_L23:
       xor       r14d,r14d
       jmp       short M00_L17
M00_L24:
       mov       r14d,1
       jmp       short M00_L17
M00_L25:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L26:
       call      qword ptr [7FFCDFBE7A08]
       int       3
M00_L27:
       mov       rcx,r11
       mov       r11,7FFCDF910C68
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L30
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,rdi
       call      qword ptr [7FFCDF9C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFCDF910C70
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFCDF9C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19C45000AC0
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFCDF910C48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       mov       r11,7FFCDF910C60
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF910C60
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1026
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L31
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L27
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L30
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L29
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0182080],1
       je        near ptr M00_L28
M00_L01:
       mov       rax,2C3E5C00AC0
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L11
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L11
       jmp       short M00_L06
M00_L03:
       xor       eax,eax
       jmp       short M00_L05
M00_L04:
       mov       eax,1
M00_L05:
       test      eax,eax
       jne       short M00_L07
M00_L06:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L12
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L04
       test      r15,r15
       je        short M00_L03
       test      rdx,rdx
       je        short M00_L03
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L03
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF98FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L16
M00_L08:
       xor       eax,eax
       jmp       short M00_L10
M00_L09:
       mov       eax,1
M00_L10:
       test      eax,eax
       jne       short M00_L07
M00_L11:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L13
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L12
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L09
       test      r15,r15
       je        short M00_L08
       test      rdx,rdx
       je        short M00_L08
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L08
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF98FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L12:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L18
M00_L13:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0DF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFCDF8D0DF8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       near ptr M00_L10
M00_L14:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE015EBC8]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       rbx,rsi
       je        short M00_L23
       jmp       near ptr M00_L32
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L26
       add       rdi,10
       jmp       short M00_L21
M00_L20:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L21:
       test      r14d,r14d
       jle       short M00_L23
       xor       ebx,ebx
M00_L22:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L24
       add       rbx,8
       dec       r14d
       jne       short M00_L22
M00_L23:
       xor       r14d,r14d
       jmp       short M00_L17
M00_L24:
       mov       r14d,1
       jmp       short M00_L17
M00_L25:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L26:
       call      qword ptr [7FFCDFBA7A08]
       int       3
M00_L27:
       mov       rcx,r11
       mov       r11,7FFCDF8D0E08
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L30
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,rdi
       call      qword ptr [7FFCDF985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFCDF8D0E10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      qword ptr [7FFCDF985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C3E5C00AC0
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFCDF8D0DE8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0E00
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8D0E00
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1019
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF98FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L31
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L27
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L30
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L29
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L26
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01C2A60],1
       je        near ptr M00_L28
M00_L01:
       mov       rax,20ECAC00B00
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-38],rdi
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L06
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L06
M00_L03:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L08
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L09
       test      r15,r15
       je        near ptr M00_L10
       test      rdx,rdx
       je        near ptr M00_L10
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L10
       add       r15,0C
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       je        near ptr M00_L03
M00_L05:
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L16
M00_L06:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L11
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L08
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        near ptr M00_L13
       test      r15,r15
       je        near ptr M00_L12
       test      rdx,rdx
       je        near ptr M00_L12
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L12
       add       r15,0C
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       test      eax,eax
       je        near ptr M00_L06
       jmp       near ptr M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       near ptr M00_L18
M00_L09:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L10:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0F20
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFCDF8E0F28
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       jmp       short M00_L07
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       eax,1
       jmp       short M00_L07
M00_L14:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE017F5A0]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       call      M00_L34
       nop
       mov       r14d,[rbp-2C]
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],r14b
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       rbx,rsi
       je        short M00_L24
       jmp       near ptr M00_L32
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L20
       add       rdi,10
       jmp       short M00_L22
M00_L20:
       call      qword ptr [7FFCDFBB7A08]
       int       3
M00_L21:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L22:
       test      r14d,r14d
       jle       short M00_L24
       xor       ebx,ebx
M00_L23:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L25
       add       rbx,8
       dec       r14d
       jne       short M00_L23
M00_L24:
       xor       r14d,r14d
       jmp       short M00_L17
M00_L25:
       mov       r14d,1
       jmp       short M00_L17
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,r11
       mov       r11,7FFCDF8E0F38
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L30
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0F40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20ECAC00B00
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0F18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0F30
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L35
       mov       rdi,[rbp-38]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8E0F30
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1051
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
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF99FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rsi
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L31
       mov       r11,[rbx+8]
       cmp       [r11],rsi
       jne       near ptr M00_L27
       mov       edi,[r11+8]
       test      edi,edi
       je        near ptr M00_L30
M00_L00:
       mov       rbx,[rbx+8]
       cmp       [rbx],rsi
       jne       near ptr M00_L29
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L26
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0265C58],1
       je        near ptr M00_L28
M00_L01:
       mov       rax,197DD000B28
       mov       rdi,[rax]
M00_L02:
       mov       [rbp-40],rdi
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L09
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       r8,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,r8
       cmp       rbx,rsi
       jne       near ptr M00_L09
       jmp       short M00_L05
M00_L03:
       mov       r13d,1
M00_L04:
       test      r13d,r13d
       jne       near ptr M00_L12
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L03
       test      r15,r15
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L06:
       xor       r13d,r13d
       jmp       near ptr M00_L04
M00_L07:
       mov       r13d,1
M00_L08:
       test      r13d,r13d
       jne       near ptr M00_L12
M00_L09:
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       jne       near ptr M00_L13
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L11
       mov       [rdi+8],eax
       mov       r8d,[rdi+8]
       cmp       r8d,[rdi+0C]
       jae       near ptr M00_L14
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L15
       mov       r8d,r10d
       mov       rdx,[r14+r8*8+10]
       mov       r15,[rdx+28]
       mov       rcx,[rbp+10]
       mov       r8,[rcx+50]
       mov       rdx,[r8+28]
       cmp       r15,rdx
       je        short M00_L07
       test      r15,r15
       je        short M00_L10
       test      rdx,rdx
       je        short M00_L10
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L10
       lea       r9,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r9
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       near ptr M00_L08
M00_L10:
       xor       r13d,r13d
       jmp       near ptr M00_L08
M00_L11:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       near ptr M00_L18
M00_L12:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L16
M00_L13:
       mov       rcx,rdi
       mov       r11,7FFCDF911228
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L18
       mov       rcx,rdi
       mov       r11,7FFCDF911230
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       mov       r13d,eax
       jmp       near ptr M00_L08
M00_L14:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE0324030]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       call      M00_L34
       nop
       mov       r14d,[rbp-34]
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
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
M00_L18:
       cmp       rbx,rsi
       je        short M00_L24
       jmp       near ptr M00_L32
M00_L19:
       mov       r14d,[rbx+10]
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r14d
       jb        short M00_L20
       add       rdi,10
       jmp       short M00_L22
M00_L20:
       call      qword ptr [7FFCDFBE7A08]
       int       3
M00_L21:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
M00_L22:
       test      r14d,r14d
       jle       short M00_L24
       xor       ebx,ebx
M00_L23:
       mov       rdx,[rdi+rbx]
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.<IsNotEmptyFound>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      rax
       test      eax,eax
       jne       short M00_L25
       add       rbx,8
       dec       r14d
       jne       short M00_L23
M00_L24:
       xor       r14d,r14d
       jmp       short M00_L17
M00_L25:
       mov       r14d,1
       jmp       short M00_L17
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L27:
       mov       rcx,r11
       mov       r11,7FFCDF911240
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L30
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L29:
       mov       rcx,rbx
       mov       r11,7FFCDF911248
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,197DD000B28
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L31:
       mov       rcx,rbx
       mov       r11,7FFCDF911220
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,rdi
       mov       r11,7FFCDF911238
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L33:
       xor       r14d,r14d
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L35
       mov       rdi,[rbp-40]
       mov       rbx,[rdi]
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rbx,rsi
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF911238
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1053
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
       sub       rsp,28
       mov       r8,[rdx+28]
       mov       rdx,[rcx+50]
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
       call      qword ptr [7FFCDF9CFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1CF57800A48
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01B2680],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,1CF57800AD0
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       mov       edx,[rdi+8]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF900DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF900DE8
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE018EB98]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1CF57800A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CF57800A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CF57800AD0
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF900DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 929
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
       call      qword ptr [7FFCE018D248]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,2280D402A40
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01B1EC8],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,2280D402AC8
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       mov       edx,[rdi+8]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF900DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF900DE8
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE018EBC8]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2280D402A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2280D402A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2280D402AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF900DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 929
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
       call      qword ptr [7FFCE018D278]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,235C3002A40
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0191ED8],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,235C3002AC8
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DE8
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE016EBE0]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,235C3002A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,235C3002A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBB7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8E0DF8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0E00
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,235C3002AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 926
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
       call      qword ptr [7FFCE016D278]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1138EC00A48
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01B2CC8],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,1138EC00AD0
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF900DE0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF900DE8
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE018EBE0]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       xor       ebx,ebx
       cmp       ebx,edi
       jge       short M00_L16
M00_L21:
       mov       rdx,[r14+rbx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       inc       ebx
       cmp       ebx,edi
       jl        short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1138EC00A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1138EC00A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1138EC00AD0
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF900DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 926
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
       call      qword ptr [7FFCE018D278]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,1E61B400A30
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE012FC78],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,1E61B400A50
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF8D0B58
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE01676D8]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       test      edi,edi
       jle       short M00_L16
       xor       ebx,ebx
M00_L21:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       add       rbx,8
       dec       edi
       jne       short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E61B400A28
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E61B400A30
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBA7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8D0B68
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FFCDF985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8D0B70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      qword ptr [7FFCDF985728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E61B400A50
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8D0B48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0B60
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8D0B60
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
       call      qword ptr [7FFCE016E4F0]
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,19083800A48
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L19
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L23
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01B1B70],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,19083800AD0
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE018EBE0]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        near ptr M00_L25
       add       r14,10
       jmp       short M00_L20
M00_L19:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L20:
       test      edi,edi
       jle       short M00_L16
       xor       ebx,ebx
M00_L21:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L22
       add       rbx,8
       dec       edi
       jne       short M00_L21
       jmp       short M00_L16
M00_L22:
       mov       ebx,1
       jmp       short M00_L17
M00_L23:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,19083800A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19083800A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       call      qword ptr [7FFCDFBD7A08]
       int       3
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF900E10
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF900E18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19083800AD0
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF900E08
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF900E08
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 928
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
       call      qword ptr [7FFCE018D278]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,15ED3002A40
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L24
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE01A5B70],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,15ED3002B08
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0EE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF8E0EF0
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE017F618]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L19
       add       r14,10
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFCDFBB7A08]
       int       3
M00_L20:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L21:
       test      edi,edi
       jle       short M00_L16
       xor       ebx,ebx
M00_L22:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L23
       add       rbx,8
       dec       edi
       jne       short M00_L22
       jmp       short M00_L16
M00_L23:
       mov       ebx,1
       jmp       short M00_L17
M00_L24:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,15ED3002A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15ED3002A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8E0F00
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0F08
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15ED3002B08
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8E0EE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0EF8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8E0EF8
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 924
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
       call      qword ptr [7FFCE017D830]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2E8]
       mov       rax,27D28002AE8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L00:
       test      rbx,rbx
       je        near ptr M00_L33
       mov       r11,[rbx]
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       r11,rdi
       je        near ptr M00_L20
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       je        near ptr M00_L18
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r11,rax
       jne       near ptr M00_L30
       mov       r11,[rbx+8]
       cmp       [r11],rdi
       jne       near ptr M00_L26
       mov       r14d,[r11+8]
       test      r14d,r14d
       je        near ptr M00_L29
M00_L01:
       mov       rbx,[rbx+8]
       cmp       [rbx],rdi
       jne       near ptr M00_L28
       mov       edi,[rbx+8]
       test      edi,edi
       jne       near ptr M00_L24
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       test      byte ptr [7FFCE0246628],1
       je        near ptr M00_L27
M00_L02:
       mov       rax,27D28002B18
       mov       r14,[rax]
M00_L03:
       mov       [rbp-30],r14
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L09
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       jne       near ptr M00_L09
       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],r11
       jne       short M00_L09
M00_L04:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       short M00_L08
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       jmp       short M00_L04
M00_L05:
       mov       [rdi+8],eax
       mov       edx,[rdi+8]
       cmp       edx,[rdi+0C]
       jae       near ptr M00_L12
       mov       rbx,[rdi+10]
       cmp       edx,[rbx+8]
       jae       near ptr M00_L14
       mov       ecx,edx
       mov       rax,[rbx+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rsi+18],rcx
       jne       short M00_L11
M00_L06:
       cmp       [rdi],r14
       jne       short M00_L10
M00_L07:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jb        short M00_L05
M00_L08:
       mov       r11d,[rdi+0C]
       mov       [rdi+8],r11d
       jmp       short M00_L15
M00_L09:
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       je        short M00_L07
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFCDF8F1250
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L15
       mov       rcx,rdi
       mov       r11,7FFCDF8F1258
       call      qword ptr [r11]
M00_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L06
       jmp       short M00_L13
M00_L12:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFCE03040A8]
       int       3
M00_L13:
       mov       dword ptr [rbp-24],1
       jmp       near ptr M00_L32
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L15:
       cmp       [rdi],r14
       jne       near ptr M00_L31
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L18:
       mov       edi,[rbx+10]
       mov       r14,[rbx+8]
       cmp       [r14+8],edi
       jb        short M00_L19
       add       r14,10
       jmp       short M00_L21
M00_L19:
       call      qword ptr [7FFCDFBC7A08]
       int       3
M00_L20:
       lea       r14,[rbx+10]
       mov       edi,[rbx+8]
M00_L21:
       test      edi,edi
       jle       short M00_L16
       xor       ebx,ebx
M00_L22:
       mov       rdx,[r14+rbx]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L23
       add       rbx,8
       dec       edi
       jne       short M00_L22
       jmp       short M00_L16
M00_L23:
       mov       ebx,1
       jmp       short M00_L17
M00_L24:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27D28002AE0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark+<>c.<IsNotEmptyNotFound>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27D28002AE8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,r11
       mov       r11,7FFCDF8F1268
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L29
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,rbx
       mov       r11,7FFCDF8F1270
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L29:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27D28002B18
       mov       r14,[rcx]
       jmp       near ptr M00_L03
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFCDF8F1248
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,rdi
       mov       r11,7FFCDF8F1260
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L32:
       call      M00_L34
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L17
M00_L33:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L35
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-30]
       cmp       [rdi],r14
       je        short M00_L35
       mov       rcx,rdi
       mov       r11,7FFCDF8F1260
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 924
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
       call      qword ptr [7FFCE0096250]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,1C41E402A38
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE01C3520],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,1C41E402AD0
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,1C41E400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D8C3FD5
       mov       r10d,0FA1A5BAA
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF900DF0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF900DF8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF900DE8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE01AEB98]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF6F3C0]
       mov       ecx,65
       mov       rdx,7FFCDFDBC8A8
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDBC8A8
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE01AF888]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE01AE0D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF900E08
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF900E10
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C41E402AD0
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF900DE0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF900E00
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,204B3300008
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
       call      qword ptr [7FFCE01AE6B8]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,1A118402A20
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE0190BA0],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,1A118402AD0
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,1A118400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,2247753D
       mov       r10d,80C74215
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8E0C68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0C70
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF8E0C60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE016EB68]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF4EB98]
       mov       ecx,65
       mov       rdx,7FFCDFD9C8A8
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFD9C8A8
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016ED60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016E0A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF8E0C80
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0C88
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A118402AD0
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0C58
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8E0C78
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF8E0C78
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E1AD530008
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
       call      qword ptr [7FFCE016E688]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,24B65000A28
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE0160A70],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,24B65000A58
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,24B4F000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,67E51BCD
       mov       r10d,784F1F6F
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8F0B60
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF8F0B68
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF8F0B58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE01877C8]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF57750]
       mov       ecx,65
       mov       rdx,7FFCDFDAC8A8
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDAC8A8
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0187960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0187978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF8F0B78
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF8F0B80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24B65000A58
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF8F0B50
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8F0B70
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF8F0B70
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28BE3E90008
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
       call      qword ptr [7FFCE0187EB8]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,215CA002A20
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE0191910],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,215CA002AD0
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,215CA000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,58FDE17B
       mov       r10d,9F0DEEF3
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8E0C60
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF8E0C68
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF8E0C58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE016EB98]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF4ED18]
       mov       ecx,65
       mov       rdx,7FFCDFD9C8A8
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFD9C8A8
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016ED90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016E0D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF8E0C78
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0C80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,215CA002AD0
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0C50
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8E0C70
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF8E0C70
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2565F290008
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
       call      qword ptr [7FFCE016E6B8]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,1DEE5402A38
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE01D4140],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,1DEE5402A48
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,1DEE5400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0E5654BCF
       mov       r10d,6E8E7F88
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF910E18
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF910E20
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF910E10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE01B6520]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF7F3D8]
       mov       ecx,65
       mov       rdx,7FFCDFDCC8A8
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFCA4F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDCC8A8
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE01BEDD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE01BE1C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF910E30
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF910E38
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DEE5402A48
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF910E08
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF910E28
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF910E28
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21F7A270008
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
       call      qword ptr [7FFCE01BE7A8]
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,162C2400A40
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE0183520],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,162C2400A50
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,162AC400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D9B961FB
       mov       r10d,49B426A7
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8D0E20
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0E28
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF8D0E18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE01560D0]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF3EFB8]
       mov       ecx,65
       mov       rdx,7FFCDFD8C8A8
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFD8C8A8
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE015EDC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015E1A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF8D0E38
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0E40
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,162C2400A50
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0E10
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8D0E30
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF8D0E30
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A3411D0008
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
       call      qword ptr [7FFCE015E790]
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,15AA8002AA0
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE01DFCC8],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,15AA8002AB0
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,15AA8000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0F0C7877B
       mov       r10d,926497CA
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8D0F70
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF8D0F78
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF8D0F68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE019DB78]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF3ED18]
       mov       ecx,65
       mov       rdx,7FFCDFD8C8A8
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFD8C8A8
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE019E418]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019E430]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF8D0F88
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0F90
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15AA8002AB0
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0F60
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF8D0F80
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF8D0F80
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19B3CFF0008
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
       call      qword ptr [7FFCE019F4E0]
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L24
       mov       rcx,28685400AB8
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
       jne       near ptr M00_L23
       test      byte ptr [7FFCE023F4C8],1
       je        near ptr M00_L26
M00_L01:
       mov       rcx,28685400AC8
       mov       rcx,[rcx]
M00_L02:
       mov       [rbp-38],rcx
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L11
       mov       [rax+8],ecx
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M00_L20
       mov       rcx,[rax+10]
       mov       r11d,[rax+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L21
       mov       rdx,[rcx+r11*8+10]
M00_L04:
       test      rdx,rdx
       je        short M00_L03
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L13
       mov       rcx,2866F400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0E2C4683
       mov       r10d,1F9BA821
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r9d,edx
       shr       r9d,3
M00_L05:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L05
       test      dl,4
       jne       short M00_L10
M00_L06:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L07:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M00_L08:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,r8d
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L14
M00_L10:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L06
M00_L11:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M00_L22
M00_L12:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF901108
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-38]
       jmp       near ptr M00_L04
M00_L13:
       xor       r8d,r8d
       jmp       short M00_L08
M00_L14:
       mov       r9d,80
       test      dl,1
       je        short M00_L15
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L15:
       test      dl,2
       je        short M00_L16
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L16:
       mov       ecx,r9d
       jmp       near ptr M00_L07
M00_L17:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L18:
       mov       rcx,rdi
       mov       r11,7FFCDF901110
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,rax
       mov       r11,7FFCDF901100
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,[rax+8]
       call      qword ptr [7FFCE01EE640]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rax,[rbx+90]
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
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+8],0FFFFFFFF
       mov       [r13+0C],r15d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M00_L02
M00_L24:
       call      qword ptr [7FFCDFF67738]
       mov       ecx,65
       mov       rdx,7FFCDFDBC8A8
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDBC8A8
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE009EC28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE009EC40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       r11,7FFCDF901120
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L28
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFCDF901128
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28685400AC8
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFCDF9010F8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L30:
       mov       rcx,[rbp-38]
       mov       r11,7FFCDF901118
       call      qword ptr [r11]
       jmp       near ptr M00_L22
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L31
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L31
       mov       rcx,rax
       mov       r11,7FFCDF901118
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1228
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C704400008
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
       call      qword ptr [7FFCE01EE6A0]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF900DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF900DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE00ACEB8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF900DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF900DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8F0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF8F0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE00AD3C8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF8F0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8F0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8E0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE009D350]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF8E0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8E0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF910DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF910DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE00BCEE8]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF910DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF910DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF900DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF900DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE00ACD08]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF900DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF900DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8E0DC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF8E0DB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE009D350]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF8E0DD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8E0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8D0FD0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0FC8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE006FA20]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF8D0FE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8D0FD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
       mov       rbp,[rbx+50]
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
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8E1220
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       short M00_L00
M00_L03:
       mov       rcx,rsi
       mov       r11,7FFCDF8E1218
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFCE0075CB0]
       int       3
M00_L05:
       mov       edx,edi
       mov       r11,7FFCDF8E1230
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8E1228
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       r14,rbp
       jmp       near ptr M00_L01
; Total bytes of code 304
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF900DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF900DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00ACEA0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF900DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF900DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8D0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE007CF30]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF8D0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8D0DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF900DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF900DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00BD050]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF900DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF900DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8F0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF8F0DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00AD350]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF8F0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8F0DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8D0DC0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF8D0DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE008D350]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF8D0DD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8D0DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF910DB8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF910DB0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00BCBD0]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF910DC8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF910DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8F0F68
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF8F0F60
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00AE160]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF8F0F78
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8F0F70
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       edi,[rbx+238]
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
       jne       near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,edi
       jbe       short M00_L06
       mov       eax,edi
       mov       rbp,[rcx+rax*8+10]
M00_L01:
       mov       ecx,1
M00_L02:
       mov       rdx,[rbx+90]
       mov       [rdx+4C],cl
       mov       [rsp+20],rbp
       mov       rbx,[rbx+90]
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
       mov       r11,7FFCDF8F1230
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,rsi
       mov       r11,7FFCDF8F1228
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       ebp,ebp
       xor       ecx,ecx
       jmp       short M00_L02
M00_L06:
       call      qword ptr [7FFCE00A5D70]
       int       3
M00_L07:
       mov       edx,edi
       mov       r11,7FFCDF8F1240
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,edi
       mov       r11,7FFCDF8F1238
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L01
; Total bytes of code 319
```

