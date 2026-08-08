## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountry()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       call      qword ptr [7FFB37145EA8]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       rbx,rax
       mov       rcx,[rbx+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],r11
       jne       near ptr M00_L36
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L39
M00_L00:
       mov       rbx,[rbx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rbx],rcx
       jne       near ptr M00_L38
       mov       esi,[rbx+8]
       test      esi,esi
       jne       near ptr M00_L35
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       test      byte ptr [7FFB373AF768],1
       je        near ptr M00_L37
M00_L01:
       mov       rcx,2143DC00268
       mov       rdi,[rcx]
M00_L02:
       mov       [rbp-48],rdi
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L11
       mov       rdi,[rbp-48]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rbx,rcx
       jne       near ptr M00_L11
       jmp       short M00_L05
M00_L03:
       xor       eax,eax
M00_L04:
       test      eax,eax
       jne       near ptr M00_L33
M00_L05:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L21
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L31
       mov       rsi,[rdi+10]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L32
       mov       ecx,r10d
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,[r14+48]
       mov       r8,254BCC50AA0
       cmp       rcx,r8
       je        near ptr M00_L33
       test      rcx,rcx
       je        short M00_L05
       cmp       dword ptr [rcx+8],2
       jne       short M00_L05
       add       rcx,0C
       mov       r8,254BCC50AAC
       mov       edx,2
       xor       r15d,r15d
       cmp       edx,4
       jae       near ptr M00_L16
M00_L06:
       cmp       edx,2
       jb        short M00_L07
       mov       r12d,[rcx+r15]
       mov       r9d,[r8+r15]
       mov       eax,r12d
       or        eax,r9d
       test      eax,0FF80FF80
       jne       near ptr M00_L18
       xor       r9d,r12d
       shl       r9d,2
       add       r12d,50005
       or        r12d,0A000A0
       add       r12d,1A001A
       or        r12d,0FF7FFF7F
       test      r12d,r9d
       jne       near ptr M00_L03
       add       r15,4
       add       edx,0FFFFFFFE
M00_L07:
       test      edx,edx
       jne       near ptr M00_L17
M00_L08:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L33
M00_L11:
       mov       rdi,[rbp-48]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rbx,rcx
       jne       near ptr M00_L22
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L23
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L31
       mov       rsi,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L32
       mov       ecx,r10d
       mov       r14,[rsi+rcx*8+10]
M00_L12:
       mov       rcx,[r14+48]
       mov       r8,254BCC50AA0
       cmp       rcx,r8
       je        near ptr M00_L33
       test      rcx,rcx
       je        short M00_L11
       cmp       dword ptr [rcx+8],2
       jne       short M00_L11
       add       rcx,0C
       mov       r8,254BCC50AAC
       mov       edx,2
       xor       r15d,r15d
M00_L13:
       cmp       edx,4
       jae       near ptr M00_L25
       cmp       edx,2
       jb        short M00_L14
       mov       r12d,[rcx+r15]
       mov       r9d,[r8+r15]
       mov       eax,r12d
       or        eax,r9d
       test      eax,0FF80FF80
       jne       near ptr M00_L28
       xor       r9d,r12d
       shl       r9d,2
       lea       eax,[r12+50005]
       or        eax,0A000A0
       add       eax,1A001A
       or        eax,0FF7FFF7F
       test      eax,r9d
       jne       near ptr M00_L09
       add       r15,4
       add       edx,0FFFFFFFE
M00_L14:
       test      edx,edx
       jne       near ptr M00_L27
M00_L15:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L16:
       mov       r13,[rcx+r15]
       mov       r12,[r8+r15]
       mov       r9,r13
       or        r9,r12
       mov       rax,r9
       shr       rax,20
       or        eax,r9d
       test      eax,0FF80FF80
       jne       near ptr M00_L19
       xor       r12,r13
       shl       r12,2
       mov       r9,5000500050005
       add       r9,r13
       mov       rax,0A000A000A000A0
       or        r9,rax
       mov       rax,1A001A001A001A
       add       r9,rax
       mov       rax,0FF7FFF7FFF7FFF7F
       or        r9,rax
       test      r9,r12
       jne       near ptr M00_L03
       add       r15,8
       add       edx,0FFFFFFFC
       cmp       edx,4
       jae       short M00_L16
       jmp       near ptr M00_L06
M00_L17:
       movzx     r12d,word ptr [rcx+r15]
       movzx     r9d,word ptr [r8+r15]
       mov       eax,r12d
       or        eax,r9d
       cmp       eax,7F
       ja        short M00_L18
       cmp       r12d,r9d
       je        near ptr M00_L08
       or        r12d,20
       lea       ecx,[r12-61]
       cmp       ecx,19
       ja        near ptr M00_L03
       or        r9d,20
       cmp       r12d,r9d
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L18:
       test      r12d,0FF80FF80
       je        near ptr M00_L03
       test      r9d,0FF80FF80
       jne       short M00_L20
       jmp       near ptr M00_L03
M00_L19:
       mov       r9,0FF80FF80FF80FF80
       test      r9,r13
       je        near ptr M00_L03
       mov       r9,0FF80FF80FF80FF80
       test      r9,r12
       je        near ptr M00_L03
M00_L20:
       add       rcx,r15
       add       r8,r15
       mov       r9d,edx
       call      qword ptr [7FFB373CC240]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L21:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L40
M00_L22:
       mov       rcx,rdi
       mov       r11,7FFB36C60A68
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L24
       jmp       near ptr M00_L40
M00_L23:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L40
M00_L24:
       mov       rcx,rdi
       mov       r11,7FFB36C60A70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L12
M00_L25:
       mov       r13,[rcx+r15]
       mov       r12,[r8+r15]
       mov       r9,r13
       or        r9,r12
       mov       rax,r9
       shr       rax,20
       or        eax,r9d
       test      eax,0FF80FF80
       je        short M00_L26
       mov       r9,0FF80FF80FF80FF80
       test      r9,r13
       je        near ptr M00_L09
       mov       r9,0FF80FF80FF80FF80
       test      r9,r12
       je        near ptr M00_L09
       jmp       near ptr M00_L29
M00_L26:
       mov       r9,r13
       xor       r9,r12
       shl       r9,2
       mov       rax,5000500050005
       add       rax,r13
       mov       r10,0A000A000A000A0
       or        rax,r10
       mov       r10,1A001A001A001A
       add       rax,r10
       mov       r10,0FF7FFF7FFF7FFF7F
       or        rax,r10
       test      rax,r9
       jne       near ptr M00_L09
       add       r15,8
       add       edx,0FFFFFFFC
       jmp       near ptr M00_L13
M00_L27:
       movzx     r12d,word ptr [rcx+r15]
       movzx     r9d,word ptr [r8+r15]
       mov       eax,r12d
       or        eax,r9d
       cmp       eax,7F
       jbe       short M00_L30
M00_L28:
       test      r12d,0FF80FF80
       je        near ptr M00_L09
       test      r9d,0FF80FF80
       je        near ptr M00_L09
M00_L29:
       add       rcx,r15
       add       r8,r15
       mov       r9d,edx
       call      qword ptr [7FFB373CC240]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L10
M00_L30:
       cmp       r12d,r9d
       je        near ptr M00_L15
       or        r12d,20
       lea       ecx,[r12-61]
       cmp       ecx,19
       ja        near ptr M00_L09
       or        r9d,20
       cmp       r12d,r9d
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L10
M00_L31:
       mov       ecx,[rdi+8]
       call      qword ptr [7FFB373CC378]
       int       3
M00_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L33:
       mov       rdi,[rbp-48]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rbx,rcx
       jne       near ptr M00_L41
M00_L34:
       mov       [rbp-40],r14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+88]
       mov       rdx,[rbp-40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L35:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],esi
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L36:
       mov       r11,7FFB36C60A80
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M00_L39
       jmp       near ptr M00_L00
M00_L37:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L38:
       mov       rcx,rbx
       mov       r11,7FFB36C60A88
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L39:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2143DC00268
       mov       rdi,[rcx]
       jmp       near ptr M00_L02
M00_L40:
       call      M00_L43
       jmp       short M00_L42
M00_L41:
       mov       rcx,rdi
       mov       r11,7FFB36C60A78
       call      qword ptr [r11]
       jmp       near ptr M00_L34
M00_L42:
       xor       r14d,r14d
       jmp       near ptr M00_L34
M00_L43:
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M00_L44
       mov       rdi,[rbp-48]
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rbx,rcx
       je        short M00_L44
       mov       rcx,rdi
       mov       r11,7FFB36C60A78
       call      qword ptr [r11]
M00_L44:
       nop
       add       rsp,28
       ret
; Total bytes of code 1611
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,254BCC4B610
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,21427C01390
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB37146058]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,254BCC4B610
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
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
       jmp       qword ptr [7FFB36D15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountryByCountryName()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,25D67E30AD0
       call      qword ptr [7FFB36C6A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       rcx,21CE90001B8
       mov       rdi,[rcx]
       mov       rcx,21CE90001A0
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L36
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L37
       mov       rcx,rsi
       mov       rax,[7FFB373BA838]
       call      qword ptr [rax+18]
       mov       r13d,eax
M00_L01:
       mov       r12,[r15+8]
       mov       rcx,[r15+10]
       mov       edx,r13d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L56
       mov       edx,edx
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L46
       test      r12,r12
       je        near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L31
M00_L02:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L38
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       test      r10,r10
       je        near ptr M00_L40
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L39
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFB36C660A0]; System.Enum.Equals(System.Object)
M00_L03:
       test      eax,eax
       je        near ptr M00_L40
M00_L04:
       mov       rax,[rbp-50]
       mov       rdx,[rax+10]
       mov       [rbp-40],rdx
M00_L05:
       mov       rdx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFB371452D8]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L47
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rsi],rdi
       je        near ptr M00_L26
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       mov       rcx,[rsi+8]
       cmp       [rcx],rdi
       jne       near ptr M00_L49
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M00_L52
M00_L06:
       mov       rsi,[rsi+8]
       cmp       [rsi],rdi
       jne       near ptr M00_L51
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       test      byte ptr [7FFB373C0F50],1
       je        near ptr M00_L50
M00_L07:
       mov       rcx,21CE9000228
       mov       r14,[rcx]
M00_L08:
       mov       [rbp-58],r14
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L14
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L14
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L23
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L16
       mov       [r14+8],eax
       mov       r10d,[r14+8]
       cmp       r10d,[r14+0C]
       jae       near ptr M00_L21
       mov       rdi,[r14+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L22
       mov       r8d,r10d
       mov       r15,[rdi+r8*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L15
       test      r13,r13
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r13+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB36D2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L10
M00_L12:
       xor       eax,eax
M00_L13:
       test      eax,eax
       jne       near ptr M00_L23
M00_L14:
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L17
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L18
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       near ptr M00_L21
       mov       rdi,[r14+10]
       mov       r10d,[r14+8]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L22
       mov       r8d,r10d
       mov       r15,[rdi+r8*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L20
       test      r13,r13
       je        short M00_L12
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[r13+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L12
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB36D2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L13
M00_L15:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L16:
       mov       r8d,[r14+0C]
       mov       [r14+8],r8d
       jmp       near ptr M00_L54
M00_L17:
       mov       rcx,r14
       mov       r11,7FFB36C709F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L19
       jmp       near ptr M00_L54
M00_L18:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L54
M00_L19:
       mov       rcx,r14
       mov       r11,7FFB36C70A00
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       jmp       near ptr M00_L13
M00_L20:
       mov       eax,1
       jmp       near ptr M00_L13
M00_L21:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB373D5770]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L55
M00_L24:
       mov       [rbp-48],r15
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L25:
       mov       r15d,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],r15d
       jb        near ptr M00_L48
       add       r14,10
       jmp       short M00_L27
M00_L26:
       lea       r14,[rsi+10]
       mov       r15d,[rsi+8]
M00_L27:
       xor       esi,esi
       cmp       esi,r15d
       jge       short M00_L29
M00_L28:
       mov       rdi,[r14+rsi*8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       test      eax,eax
       jne       short M00_L30
       inc       esi
       cmp       esi,r15d
       jl        short M00_L28
M00_L29:
       xor       r15d,r15d
       jmp       short M00_L24
M00_L30:
       mov       r15,rdi
       jmp       near ptr M00_L24
M00_L31:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L43
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L41
       test      r10,r10
       je        near ptr M00_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L44
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFB36C660A0]; System.Enum.Equals(System.Object)
M00_L32:
       test      eax,eax
       je        near ptr M00_L45
       jmp       near ptr M00_L04
M00_L33:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L34:
       call      qword ptr [7FFB3735E538]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L35
       call      qword ptr [7FFB373D7348]
       mov       rbx,rax
M00_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25D67E30AA0
       call      qword ptr [7FFB36FBDA10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21CE90001B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       call      qword ptr [7FFB36D26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21CE90001B8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L37:
       mov       rdx,rsi
       mov       r11,7FFB36C709E0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L01
M00_L38:
       mov       [rbp-50],rax
       jmp       short M00_L40
M00_L39:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L03
M00_L40:
       mov       rax,[rbp-50]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L02
       jmp       short M00_L46
M00_L41:
       mov       rcx,r12
       mov       r8,rsi
       mov       rdx,r10
       mov       r11,7FFB36C709E8
       call      qword ptr [r11]
       jmp       near ptr M00_L32
M00_L42:
       mov       rax,[rbp-50]
M00_L43:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L31
       jmp       short M00_L46
M00_L44:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L32
M00_L45:
       mov       rax,[rbp-50]
       jmp       short M00_L43
M00_L46:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,r14
       call      qword ptr [7FFB370AC720]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L05
M00_L47:
       mov       ecx,11
       call      qword ptr [7FFB36D2F930]
       int       3
M00_L48:
       call      qword ptr [7FFB36D2F480]
       int       3
M00_L49:
       mov       r11,7FFB36C70A10
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L52
       jmp       near ptr M00_L06
M00_L50:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L07
M00_L51:
       mov       rcx,rsi
       mov       r11,7FFB36C70A18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L08
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21CE9000228
       mov       r14,[rcx]
       jmp       near ptr M00_L08
M00_L53:
       mov       rcx,rsi
       mov       r11,7FFB36C709F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L08
M00_L54:
       call      M00_L57
       jmp       near ptr M00_L29
M00_L55:
       mov       rcx,r14
       mov       r11,7FFB36C70A08
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       sub       rsp,48
       cmp       qword ptr [rbp-58],0
       je        short M00_L58
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       je        short M00_L58
       mov       rcx,r14
       mov       r11,7FFB36C70A08
       call      qword ptr [r11]
M00_L58:
       nop
       add       rsp,48
       ret
; Total bytes of code 1899
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L23
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L07
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L25
       mov       rcx,rsi
       call      qword ptr [7FFB36EF61C0]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M01_L08
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
M01_L02:
       test      ecx,ecx
       je        short M01_L05
       cmp       rbx,rdi
       jne       near ptr M01_L24
M01_L03:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      al,2
       jne       near ptr M01_L09
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       je        near ptr M01_L25
       call      00007FFB9695E010
       mov       rcx,21CD3000B10
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L61
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,25D67E20020
       cmp       rdi,rcx
       je        near ptr M01_L26
       mov       rcx,25D67E23E20
       cmp       rdi,rcx
       jne       near ptr M01_L27
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FFB9695E010
       mov       rcx,21CD3000B10
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L61
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L28
       cmp       qword ptr [rdi+10],0
       je        short M01_L10
       mov       rcx,[rdi+10]
       mov       rbp,[rcx]
       test      rbp,rbp
       je        short M01_L10
       mov       rax,rbp
       jmp       short M01_L11
M01_L07:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L08:
       xor       ecx,ecx
       jmp       near ptr M01_L02
M01_L09:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       rcx,rdi
       call      qword ptr [7FFB36EF56C8]; System.RuntimeType.InitializeCache()
M01_L11:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        near ptr M01_L29
M01_L12:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M01_L49
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L13:
       mov       esi,[rsi+8]
       cmp       qword ptr [rbx+10],0
       je        short M01_L14
       mov       rcx,[rbx+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L19
M01_L14:
       mov       rcx,rbx
       call      qword ptr [7FFB36EF56C8]; System.RuntimeType.InitializeCache()
M01_L15:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L21
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       short M01_L20
       mov       rax,rcx
M01_L16:
       test      rax,rax
       je        short M01_L22
M01_L17:
       mov       rcx,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L51
       mov       edx,esi
       mov       ecx,[rcx+8]
       cmp       rcx,rdx
       seta      al
       movzx     eax,al
M01_L18:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L19:
       mov       rax,rdi
       jmp       short M01_L15
M01_L20:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M01_L21
       mov       rax,[rcx+28]
       jmp       short M01_L16
M01_L21:
       xor       eax,eax
       jmp       short M01_L16
M01_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB36FBDEF0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L17
M01_L23:
       mov       ecx,3AD
       mov       rdx,7FFB36C64000
       call      qword ptr [7FFB36D2F210]
       mov       rcx,rax
       call      qword ptr [7FFB373D5128]
       int       3
M01_L24:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFB373D5A70]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB373D6328]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFB373D58F0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB370A4360]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       call      qword ptr [7FFB373D6310]
       int       3
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFB3735C648]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FFB373BB0F8
       call      qword ptr [7FFB3735E550]
       not       eax
       shr       eax,1F
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L27:
       mov       rcx,25D67E260C0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E23D70
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E23BD0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E26098
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E23B58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E260E8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E23950
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,25D67E26070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB373D6340]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB370A61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB373D6358]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFB373D58F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB370A4360]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L29:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FFB36FB72D0]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L30
       mov       rcx,rdi
       call      qword ptr [7FFB36C6A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
M01_L30:
       mov       rcx,25D67E26098
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,5
       jmp       near ptr M01_L46
M01_L31:
       mov       rcx,25D67E23BD0
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,6
       jmp       near ptr M01_L46
M01_L32:
       mov       rcx,25D67E260C0
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,7
       jmp       near ptr M01_L46
M01_L33:
       mov       rcx,25D67E23D70
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,8
       jmp       near ptr M01_L46
M01_L34:
       mov       rcx,25D67E23E20
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,9
       jmp       near ptr M01_L46
M01_L35:
       mov       rcx,25D67E23B58
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0A
       jmp       near ptr M01_L46
M01_L36:
       mov       rcx,25D67E260E8
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0B
       jmp       near ptr M01_L46
M01_L37:
       mov       rcx,25D67E23950
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,0C
       jmp       near ptr M01_L46
M01_L38:
       mov       rcx,25D67E26048
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,3
       jmp       near ptr M01_L46
M01_L39:
       mov       rcx,25D67E26070
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,4
       jmp       near ptr M01_L46
M01_L40:
       mov       rcx,25D67E26110
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0D
       jmp       short M01_L46
M01_L41:
       mov       rcx,25D67E26138
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0E
       jmp       short M01_L46
M01_L42:
       mov       rcx,25D67E26DB8
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,0F
       jmp       short M01_L46
M01_L43:
       mov       rcx,25D67E237C8
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,10
       jmp       short M01_L46
M01_L44:
       mov       rcx,25D67E20020
       cmp       rbp,rcx
       jne       short M01_L45
       mov       ebp,12
       jmp       short M01_L46
M01_L45:
       mov       rcx,25D67E30B88
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M01_L46:
       cmp       qword ptr [rdi+10],0
       je        short M01_L47
       mov       rcx,[rdi+10]
       mov       r14,[rcx]
       test      r14,r14
       je        short M01_L47
       mov       rax,r14
       jmp       short M01_L48
M01_L47:
       mov       rcx,rdi
       call      qword ptr [7FFB36EF56C8]; System.RuntimeType.InitializeCache()
M01_L48:
       mov       [rax+98],ebp
       jmp       near ptr M01_L12
M01_L49:
       cmp       ebp,0A
       ja        short M01_L50
       mov       edx,ebp
       lea       rcx,[7FFB374330E8]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L50:
       mov       rdx,25D67E23D48
       cmp       rdi,rdx
       je        near ptr M01_L59
       jmp       near ptr M01_L57
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F50]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F50]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F38]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F38]
       jmp       near ptr M01_L18
M01_L51:
       test      rcx,rcx
       jne       short M01_L52
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M01_L53
M01_L52:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M01_L53:
       cmp       dword ptr [rcx+8],20
       jle       short M01_L54
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,esi
       call      qword ptr [7FFB373D65B0]
       jmp       short M01_L55
M01_L54:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFB373D67C0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L55:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFB3735E5B0]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F20]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F20]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F08]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5EF0]
       jmp       near ptr M01_L18
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L56
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L56:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5F68]
       jmp       near ptr M01_L18
M01_L57:
       mov       rdx,25D67E26160
       cmp       rdi,rdx
       je        short M01_L58
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB373D6340]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB370A61A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5ED8]
       jmp       short M01_L60
M01_L59:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFB373D5ED8]
M01_L60:
       jmp       near ptr M01_L18
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2087
```
```assembly
; System.Enum.Equals(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M02_L00:
       test      rdx,rdx
       je        short M02_L03
       cmp       rbx,rdx
       je        short M02_L02
       mov       rcx,[rbx]
       cmp       rcx,[rdx]
       jne       short M02_L03
       lea       rsi,[rbx+8]
       lea       rdi,[rdx+8]
       call      00007FFB9695E010
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M02_L03
       lea       rcx,[7FFB374339D0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       mov       eax,[rsi]
       cmp       eax,[rdi]
       sete      al
       movzx     eax,al
M02_L01:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,byte ptr [rsi]
       cmp       al,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
       movzx     eax,word ptr [rsi]
       cmp       ax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
       mov       rax,[rsi]
       cmp       rax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,25D67E2B610
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,21CD3001390
       cmp       qword ptr [rsi],0
       je        short M03_L01
M03_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FFB37145488]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
M03_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,25D67E2B610
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M04_L04
       cmp       rcx,rdx
       je        short M04_L03
       cmp       r8,20
       jae       near ptr M04_L09
       cmp       r8,10
       jb        near ptr M04_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M04_L02
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       je        short M04_L01
M04_L00:
       xor       eax,eax
       vzeroupper
       ret
M04_L01:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M04_L12
M04_L02:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M04_L00
M04_L03:
       mov       eax,1
       vzeroupper
       ret
M04_L04:
       cmp       r8,4
       jae       short M04_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M04_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M04_L05:
       test      r8b,1
       je        short M04_L06
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M04_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M04_L08
M04_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M04_L08:
       vzeroupper
       ret
M04_L09:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M04_L11
M04_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M04_L00
       add       rax,20
       cmp       r8,rax
       ja        short M04_L10
M04_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M04_L00
       jmp       near ptr M04_L03
M04_L12:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M04_L08
; Total bytes of code 335
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
; 		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
; 		                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       r8,[rdx+68]
       mov       rdx,[rcx+8]
       cmp       r8,rdx
       je        short M05_L03
       test      r8,r8
       je        short M05_L00
       test      rdx,rdx
       je        short M05_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       je        short M05_L02
M05_L00:
       xor       eax,eax
M05_L01:
       add       rsp,28
       ret
M05_L02:
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFB36D2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L01
M05_L03:
       mov       eax,1
       jmp       short M05_L01
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 			var type = key.GetType();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EF61C0]; System.Object.GetType()
       mov       [rbp-8],rax
; 			if (!type.IsEnum)
; 			^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M06_L00
; 				throw new ArgumentException("Type provided must be an Enum.", nameof(input));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       ecx,6B19
       mov       rdx,7FFB36FF4CA0
       call      qword ptr [7FFB36D2F210]
       mov       [rbp-40],rax
       mov       ecx,2047
       mov       rdx,7FFB36FF4CA0
       call      qword ptr [7FFB36D2F210]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFB370A6250]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB3735E8F8]; System.Enum.GetName(System.Type, System.Object)
       mov       [rbp-10],rax
; 			if (name == null)
; 			^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-10],0
       jne       short M06_L01
; 				return key.ToString();
; 				^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-38],rax
       jmp       near ptr M06_L05
; 			var field = type.GetField(name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L01:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3735E910]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFB3735E928]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
       test      eax,eax
       je        short M06_L02
; 				return name;
; 				^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
       jmp       near ptr M06_L05
; 			var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L02:
       mov       rdx,[rbp-18]
       mov       rcx,7FFB373C08A0
       xor       r8d,r8d
       call      qword ptr [7FFB37246688]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-20],rax
; 			if (descriptionAttr != null && !string.IsNullOrEmpty(descriptionAttr.Description))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-20],0
       je        short M06_L03
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FFB36FBE490]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M06_L03
; 				return descriptionAttr.Description;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       [rbp-38],rax
       jmp       short M06_L05
; 			var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L03:
       mov       rdx,[rbp-18]
       mov       rcx,7FFB373C0928
       xor       r8d,r8d
       call      qword ptr [7FFB37246688]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M06_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3735E958]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       rcx,rax
       call      qword ptr [7FFB36FBE490]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M06_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3735E958]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       [rbp-38],rax
       jmp       short M06_L05
; 			return name;
; 			^^^^^^^^^^^^
M06_L04:
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
M06_L05:
       mov       rax,[rbp-38]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 458
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFB373D5548]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-58],r11
       mov       eax,[rbp+2C]
       test      r9d,r9d
       je        near ptr M08_L20
M08_L00:
       mov       [rbp-3C],eax
M08_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M08_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M08_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M08_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFBADB71D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M08_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M08_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M08_L08
M08_L03:
       mov       rcx,[r8]
       call      qword ptr [7FFBADB71558]
       mov       rcx,rax
       call      qword ptr [7FFBADB71288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFBADB71260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBADB71260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FFBADB71260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFBADB71260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M08_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M08_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M08_L15
M08_L04:
       cmp       r14d,64
       jbe       near ptr M08_L17
       jmp       near ptr M08_L16
M08_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M08_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M08_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FFBADB718E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M08_L07
M08_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M08_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M08_L23
M08_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M08_L09
       mov       rcx,[r8]
       call      qword ptr [7FFBADB71500]
       mov       rcx,rax
       call      qword ptr [7FFBADB71AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M08_L10
M08_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M08_L08
       jmp       near ptr M08_L03
M08_L10:
       cmp       byte ptr [rbp+38],0
       je        short M08_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBADB71260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBADB71268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M08_L12
M08_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFBADB71268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M08_L24
M08_L13:
       call      qword ptr [7FFBADB71258]
       int       3
M08_L14:
       call      qword ptr [7FFBADB71250]
       int       3
M08_L15:
       mov       esi,1
       jmp       near ptr M08_L04
M08_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFBADB71C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M08_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M08_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M08_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFBADB71D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M08_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M08_L25
M08_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBADB71268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M08_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFBADB718E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M08_L22
M08_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M08_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M08_L00
M08_L23:
       call      M08_L28
       jmp       near ptr M08_L01
M08_L24:
       call      M08_L28
       jmp       short M08_L26
M08_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFBADB72430]
       jmp       near ptr M08_L19
M08_L26:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L27:
       call      qword ptr [7FFBADB71258]
       int       3
M08_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M08_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M08_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFBADB71D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M08_L29:
       nop
       add       rsp,28
       ret
M08_L30:
       call      qword ptr [7FFBADB71258]
       int       3
; Total bytes of code 950
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFB36D25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFB371452D8]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,1F93B34B610
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1B8A6401390
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB37145488]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,1F93B34B610
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```

