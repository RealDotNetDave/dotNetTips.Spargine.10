## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED65CF8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65CF8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4ED65CF8]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65CF8]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA4E6D0]
       mov       ecx,54A8
       mov       rdx,7FFB4E775D88
       call      qword ptr [7FFB4E657738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E775D88
       call      qword ptr [7FFB4E657738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E775D88
       call      qword ptr [7FFB4E657738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4ECA43D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4ECA43F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED65140]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED65140]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64648]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,227675E0008
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
       call      qword ptr [7FFB4ED67018]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55CE0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55CE0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55CE0]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55CE0]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA3E598]
       mov       ecx,54A8
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC94270]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EC94288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED550B0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED550B0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21367970008
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
       call      qword ptr [7FFB4ED56F88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EC9EAC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9EAC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4EC9EAC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9EAC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA169B8]
       mov       ecx,54A8
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EB4C708]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EB4C720]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC9EAF0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC9EAF0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EB08]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20EA52C0008
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
       call      qword ptr [7FFB4EC9F150]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55C68]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55C68]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55C68]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55C68]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA3E598]
       mov       ecx,54A8
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC94240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EC94258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED550B0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED550B0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED545B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A082CD0008
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
       call      qword ptr [7FFB4ED56F88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EC8D0F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EC8D0F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4EC8D0F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4EC8D0F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA2E508]
       mov       ecx,54A8
       mov       rdx,7FFB4E755D88
       call      qword ptr [7FFB4E637738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E755D88
       call      qword ptr [7FFB4E637738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E755D88
       call      qword ptr [7FFB4E637738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC841F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EC84210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC8D110]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC8D110]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8D0E0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D85FD00008
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
       call      qword ptr [7FFB4ED47000]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L15
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EC9D128]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L14
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9D128]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L14:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L21
M00_L15:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L18
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L17
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFB4EC9D128]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L16
M00_L20:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L15
       jmp       near ptr M00_L05
M00_L21:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L23
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9D128]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFB4EA3E508]
       mov       ecx,54A8
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC941C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EC941E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC953F8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC953F8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC953E0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1212
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23EACDF0008
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
       call      qword ptr [7FFB4ED57000]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EC5EE20]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EC5EE20]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4EC5EE20]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4EC5EE20]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA1E598]
       mov       ecx,54A8
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC55488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EC554A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC566A0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EC566A0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56688]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E9AF110008
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
       call      qword ptr [7FFB4ED37630]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L13
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L13
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EB9EFA0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EB9EFA0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L25
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L27
M00_L13:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L16
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L15
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFB4EB9EFA0]
       jmp       short M00_L14
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L26
       test      edi,edi
       jle       short M00_L13
       jmp       near ptr M00_L05
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4EB9EFA0]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       call      qword ptr [7FFB4EA569B8]
       mov       ecx,54A8
       mov       rdx,7FFB4E785D88
       call      qword ptr [7FFB4E667738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB4E785D88
       call      qword ptr [7FFB4E667738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB4E785D88
       call      qword ptr [7FFB4E667738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E3E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EB9F1F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4EB9F210]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L33
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L32
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       esi,1
       jo        short M00_L34
       cmp       esi,[rbp-2C]
       jl        short M00_L28
M00_L30:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EB9EFB8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L35
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-2C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L37
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-2C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L46
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L45
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4EB9EFB8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB9F030]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1209
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
       call      00007FFBADFF8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB4E3E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB4E3E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26C24AD0008
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
       call      qword ptr [7FFB4EDBC528]
       int       3
; Total bytes of code 231
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,10E0C800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9DFC3CBB
       mov       r8d,29C1D825
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       esi,esi
M00_L07:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC7CF48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FFB4E2F10B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E2F10C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       esi,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1BCD2400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,426AD72
       mov       r8d,3C4F2DBA
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC9CF30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E807828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E3110B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E3110C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1A952C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B01DC593
       mov       r8d,0F2236735
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4ECA5428]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7F7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E300CF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E300CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1F1B4000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CFAD741B
       mov       r8d,28AAE6EF
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L07
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,4
       jb        short M00_L10
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4ECAD080]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E817828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E3210B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E3210C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,21CE8C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6986D9A3
       mov       r8d,0D2C7410D
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC95410]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E2F0CF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E2F0CF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,21A10000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,31BF44D5
       mov       r8d,9F65B262
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC7CE88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       jmp       near ptr M00_L01
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E2F10B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E2F10C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,23CE2000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,911F716F
       mov       r8d,43144681
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L07
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,4
       jb        short M00_L10
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EC6EB08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FFB4E2F1350
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E2F1358
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1D9AA400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F794E86A
       mov       r8d,0EEB89566
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       esi,esi
M00_L07:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB4EDE6A18]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB4E7F7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FFB4E3016F0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFB4E3016F8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       esi,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,2A88B400AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
       nop       dword ptr [rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2A88B400AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A88B400AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E657DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6579A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED6F2D0]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFB4E320F98
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E320FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E320FA8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E320FB0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       r14d,1
       jo        near ptr M00_L90
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L63
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L63
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L62
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L79
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L77
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L72
M00_L61:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L62:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       near ptr M00_L73
M00_L63:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L66
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L65
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L67
M00_L64:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L68
M00_L65:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,r13
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L64
M00_L68:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L63
       jmp       near ptr M00_L51
M00_L69:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L70:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L70
M00_L71:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L72:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       near ptr M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L71
       jmp       near ptr M00_L69
M00_L73:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L75
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L76
M00_L74:
       mov       dword ptr [rbp-64],1
       jmp       near ptr M00_L61
M00_L75:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L76:
       mov       rcx,r12
       call      qword ptr [7FFB4ED65F08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L74
M00_L77:
       call      qword ptr [7FFB4ECACF60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFB4ED6F2E8]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E775D88
       call      qword ptr [7FFB4E657738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB4E8178D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED65350]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFB4ECACFD8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2E90A536FB8
       mov       r8,2E90A536FB8
       call      qword ptr [7FFB4ECA42A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED65350]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L95
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E320FB0
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED65350]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED65350]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64858]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2770
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED65470]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A0],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L25
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L24
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,1B0F9400AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rdi,4
       dec       r13d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L21
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L22:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
       nop       dword ptr [rax]
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L24:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L19
M00_L25:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L28
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B0F9400AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B0F9400AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E627DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6279A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED3F2E8]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       edi,edi
       mov       r13d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFB4E2F0F98
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E2F0FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E2F0FA8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E2F0FB0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       r14d,1
       jo        near ptr M00_L90
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L65
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L65
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L76
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L79
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L77
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       short M00_L64
M00_L61:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L62:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B0],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B0]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L62
M00_L63:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L64:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       near ptr M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L63
       jmp       near ptr M00_L61
M00_L65:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L68
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L67
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L69
M00_L66:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L70
M00_L67:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L66
M00_L70:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L65
       jmp       near ptr M00_L51
M00_L71:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L73
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L74
M00_L72:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L75
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L74:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L72
M00_L75:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        short M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L76:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L71
M00_L77:
       call      qword ptr [7FFB4EC7D068]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFB4ED3F300]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB4E7E78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFB4EC7D0E0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F178436FB8
       mov       r8,1F178436FB8
       call      qword ptr [7FFB4EC74288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L95
       mov       rcx,[rbp-0A8]
       mov       r11,7FFB4E2F0FB0
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rsi,[rbp-0A0]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2753
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED35488]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A8],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L25
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L24
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,2D436C02AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdi,[r14+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r13,4
       mov       eax,[rbp-94]
       dec       eax
       mov       [rbp-94],eax
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L21
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L22:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L20
       nop       dword ptr [rax+rax]
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L24:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L19
M00_L25:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L28
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2D436C02AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2D436C02AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E627DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6279A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED3E7C0]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       r13d,r13d
       mov       [rbp-94],eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFB4E2F0F90
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F0F98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F0FA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F0FA8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       r14d,1
       jo        near ptr M00_L89
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L78
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L75:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L79
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFB4EC7D068]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFB4ED3E7D8]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB4E7E78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L88
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L87
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFB4EC7D0E0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,314CB9F6FB8
       mov       r8,314CB9F6FB8
       call      qword ptr [7FFB4EC74270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L94
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F0FA8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L102
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L101
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L116
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L115
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2776
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED35488]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A8],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,18399C00AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdi,[r14+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r13,4
       mov       eax,[rbp-94]
       dec       eax
       mov       [rbp-94],eax
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
       nop       dword ptr [rax+rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,18399C00AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18399C00AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E637DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6379A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4EC9F000]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       r13d,r13d
       mov       [rbp-94],eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFB4E300D50
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E300D58
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E300D60
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E300D68
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       r14d,1
       jo        near ptr M00_L90
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L79
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L77
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       rax,rcx
       jg        near ptr M00_L76
       jmp       near ptr M00_L81
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFB4EC9EDF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L74:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L74
M00_L75:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       movsxd    rdx,ecx
       mov       rax,[rbp-88]
       cmp       rax,rdx
       mov       r8,rcx
       jle       near ptr M00_L81
M00_L76:
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFB4EC95458]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFB4EC9F018]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E755D88
       call      qword ptr [7FFB4E637738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB4E7F78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4EC9EE08]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFB4EC954D0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C418CD6FB8
       mov       r8,1C418CD6FB8
       call      qword ptr [7FFB4EB5C720]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4EC9EE08]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L95
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E300D68
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4EC9EE08]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4EC9EE08]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EDD8]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2791
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED35BD8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-0A8],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L19
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L30
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       mov       rcx,1F95D000AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L31
M00_L13:
       test      rdi,rdi
       je        near ptr M00_L32
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdi,[r14+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[r12+rdx]
       add       r15d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       edi,r15d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r12+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rdi,rdx
       jne       near ptr M00_L37
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r13,4
       mov       eax,[rbp-94]
       dec       eax
       mov       [rbp-94],eax
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L22
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L20
       nop       dword ptr [rax+rax]
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L27
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L30:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1F95D000AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F95D000AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E627DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6279A8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED3E7C0]
       mov       r12,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r12d,r12d
       xor       eax,eax
       xor       r13d,r13d
       jmp       near ptr M00_L14
M00_L36:
       xor       r13d,r13d
       mov       [rbp-94],eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rdi
       mov       r11,7FFB4E2F1110
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F1118
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F1120
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F1128
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       r14d,1
       jo        near ptr M00_L90
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       xor       r15d,r15d
       test      rdi,rdi
       je        near ptr M00_L61
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       mov       r13d,1
       cmp       edi,1
       jle       short M00_L58
       test      r15,r15
       je        short M00_L52
       cmp       [r15+8],edi
       jge       near ptr M00_L72
M00_L52:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L79
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L59
M00_L60:
       mov       edi,[r14+8]
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L77
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       rax,rcx
       jg        near ptr M00_L76
       jmp       near ptr M00_L81
M00_L61:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L64
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L63
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L69
       mov       rcx,r12
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFB4ED35FB0]
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L72:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       short M00_L67
M00_L73:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L74:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L74
M00_L75:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       movsxd    rdx,ecx
       mov       rax,[rbp-88]
       cmp       rax,rdx
       mov       r8,rcx
       jle       near ptr M00_L81
M00_L76:
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFB4EC7CF90]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFB4ED3E7D8]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB4E7E78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       edi,edi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L89
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L88
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],r14
       mov       rdi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFB4EC7D008]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,239DC256FB8
       mov       r8,239DC256FB8
       call      qword ptr [7FFB4EC74270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L95
       mov       rcx,[rbp-0B0]
       mov       r11,7FFB4E2F1128
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFB4ED35380]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34888]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2791
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED35488]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-98],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1FFDA800AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E310D90
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L20:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E310D98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E310DA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E310DA8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E647DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1FFDA800AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FFDA800AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6479A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ECAF030]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L88
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L61
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       mov       r15d,1
       cmp       esi,1
       jle       short M00_L58
       test      r14,r14
       je        short M00_L52
       cmp       [r14+8],esi
       jge       near ptr M00_L72
M00_L52:
       xor       eax,eax
       mov       [rbp-64],eax
       cmp       r15d,[r14+8]
       jae       short M00_L55
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L54
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-98]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L78
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L59
M00_L60:
       mov       esi,[rdi+8]
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L64
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L63
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L69
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L70:
       mov       rcx,r13
       call      qword ptr [7FFB4ECA5878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L72:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
M00_L74:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L80
       cmp       r8d,r13d
       jae       near ptr M00_L78
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L75:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L79
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFB4ECA53E0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFB4ECA5938]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E765D88
       call      qword ptr [7FFB4E647738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4E8078D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L88
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       esi,1
       jo        near ptr M00_L89
       cmp       esi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],rdi
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB6D980]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFB4ECA5458]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24059966FB8
       mov       r8,24059966FB8
       call      qword ptr [7FFB4EB6C720]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB6D980]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L94
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E310DA8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L102
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L101
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB6D980]
M00_L100:
       add       edi,1
       jo        short M00_L103
       cmp       edi,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L116
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L115
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB6D980]
M00_L114:
       add       esi,1
       jo        short M00_L117
       cmp       esi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB6D968]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2765
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED35BC0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-98],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L23
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L23
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       xchg      ax,ax
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L34
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,152D9002AC0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        short M00_L17
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L20
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       ecx,11
       call      qword ptr [7FFB4E637DF8]
       int       3
M00_L18:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L19:
       add       rsi,4
       dec       r15d
       jne       short M00_L18
       jmp       short M00_L16
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFB4E301408
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E301410
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E301418
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L21
M00_L22:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E301420
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L26
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L25
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L27
M00_L24:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L28
M00_L25:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
       xchg      ax,ax
M00_L28:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L23
       jmp       near ptr M00_L05
M00_L29:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L31
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L32
M00_L30:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L33
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L32:
       mov       rcx,r15
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L30
M00_L33:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L34:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L29
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,152D9002AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,152D9002AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6379A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED4FE10]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L18
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L19
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L89
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       edi,1
       jo        near ptr M00_L90
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L67
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L67
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L80
       test      r14d,r14d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       mov       r15d,1
       cmp       esi,1
       jle       short M00_L58
       test      r14,r14
       je        short M00_L52
       cmp       [r14+8],esi
       jge       near ptr M00_L78
M00_L52:
       xor       eax,eax
       mov       [rbp-64],eax
       cmp       r15d,[r14+8]
       jae       short M00_L55
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L54
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       cmp       r15d,esi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-98]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L79
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L59
M00_L60:
       mov       esi,[rdi+8]
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L65
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L64
M00_L61:
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L62:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L62
M00_L63:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
M00_L64:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L81
       cmp       r8d,r13d
       jae       near ptr M00_L79
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L63
       jmp       near ptr M00_L61
M00_L65:
       call      qword ptr [7FFB4EC7EDA8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFB4EC7FD08]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E755D88
       call      qword ptr [7FFB4E637738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4E7F78D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L70
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L69
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L71
M00_L68:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L72
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L71:
       mov       rcx,r15
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L72:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        short M00_L80
       test      r14d,r14d
       jle       short M00_L67
       jmp       near ptr M00_L51
M00_L73:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L75
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L76
M00_L74:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L77
M00_L75:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L76:
       mov       rcx,r13
       call      qword ptr [7FFB4EC7FC30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L74
M00_L77:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        short M00_L80
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L78:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L73
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L89
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       esi,1
       jo        near ptr M00_L90
       cmp       esi,[rbp-5C]
       jl        short M00_L82
M00_L84:
       mov       [rbp-70],rdi
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L85:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EC77168]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFB4EC7EE20]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1936DF66FB8
       mov       r8,1936DF66FB8
       call      qword ptr [7FFB4EC75F80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EC77168]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L91
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-3C],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L93
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-3C],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L95
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E301420
       call      qword ptr [r11]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L96
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-3C],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L98
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L99
       mov       [rbp-3C],ecx
M00_L98:
       add       rsp,28
       ret
M00_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L103
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L102
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EC77168]
M00_L101:
       add       edi,1
       jo        short M00_L104
       cmp       edi,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L105:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L106
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-5C],ecx
M00_L106:
       add       rsp,28
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L108
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-5C],ecx
M00_L108:
       add       rsp,28
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L110
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L111
       mov       [rbp-5C],ecx
M00_L110:
       add       rsp,28
       ret
M00_L111:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L112
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L113
       mov       [rbp-5C],ecx
M00_L112:
       add       rsp,28
       ret
M00_L113:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L117
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L116
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EC77168]
M00_L115:
       add       esi,1
       jo        short M00_L118
       cmp       esi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC77150]
       int       3
M00_L117:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L118:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L119:
       add       rsp,28
       ret
; Total bytes of code 2750
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED45650]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-98],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,22A26400B68
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E2F17B0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L20:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E2F17B8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E2F17C0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E2F17C8
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E627DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22A26400B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22A26400B68
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6279A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4EF14A08]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L88
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L84
M00_L44:
       add       edi,1
       jo        near ptr M00_L89
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M00_L89
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L85
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L61
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L61
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L46
M00_L51:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       mov       r15d,1
       cmp       esi,1
       jle       short M00_L58
       test      r14,r14
       je        short M00_L52
       cmp       [r14+8],esi
       jge       near ptr M00_L72
M00_L52:
       xor       eax,eax
       mov       [rbp-64],eax
       cmp       r15d,[r14+8]
       jae       short M00_L55
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L54
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jl        short M00_L52
M00_L58:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-98]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L60
M00_L59:
       test      ecx,ecx
       jl        short M00_L60
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L78
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L79
       add       edx,1
       jo        near ptr M00_L79
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L59
M00_L60:
       mov       esi,[rdi+8]
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L79
       or        edx,ecx
       jl        near ptr M00_L76
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L64
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L63
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r15
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L66:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L79
       test      r14d,r14d
       jle       short M00_L61
       jmp       near ptr M00_L51
M00_L67:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L69
       mov       rcx,r13
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L70:
       mov       rcx,r13
       call      qword ptr [7FFB4EB7C300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L72:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L67
M00_L73:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
M00_L74:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L80
       cmp       r8d,r13d
       jae       near ptr M00_L78
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L73
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L75:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L78
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L79
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L75
       jmp       near ptr M00_L73
M00_L76:
       call      qword ptr [7FFB4ED569E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L77
       call      qword ptr [7FFB4ED570F0]
       mov       rbx,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E47
       mov       rdx,7FFB4E745D88
       call      qword ptr [7FFB4E627738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4E7E78D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L80:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L83
M00_L81:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L88
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L87
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L86
M00_L82:
       add       esi,1
       jo        near ptr M00_L89
       cmp       esi,[rbp-5C]
       jl        short M00_L81
M00_L83:
       mov       [rbp-70],rdi
       mov       rsi,[rbx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L84:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB77630]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFB4ED56A60]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,26AA5426FB8
       mov       r8,26AA5426FB8
       call      qword ptr [7FFB4EC844B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB77630]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L90
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-3C],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L92
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-3C],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L94
       mov       rcx,[rbp-0A0]
       mov       r11,7FFB4E2F17C8
       call      qword ptr [r11]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L95
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-3C],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L97
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L98
       mov       [rbp-3C],ecx
M00_L97:
       add       rsp,28
       ret
M00_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L104
M00_L99:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L102
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L101
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB77630]
M00_L100:
       add       edi,1
       jo        short M00_L103
       cmp       edi,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L104:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L105
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-5C],ecx
M00_L105:
       add       rsp,28
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L107
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-5C],ecx
M00_L107:
       add       rsp,28
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L109
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-5C],ecx
M00_L109:
       add       rsp,28
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M00_L111
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L112
       mov       [rbp-5C],ecx
M00_L111:
       add       rsp,28
       ret
M00_L112:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L118
M00_L113:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L116
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L115
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB77630]
M00_L114:
       add       esi,1
       jo        short M00_L117
       cmp       esi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB76AD8]
       int       3
M00_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L118:
       add       rsp,28
       ret
; Total bytes of code 2765
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4EB77738]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-68],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED65C80]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65C80]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,2DD19802AC0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4ED65C80]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFB4ED65C80]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2DD19802AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2DD19802AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E657DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6579A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-60],rax
       mov       [rbp-58],edx
       lea       rdx,[rbp-60]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB4ED6EFD0]
       mov       r13,[rbp-50]
       mov       eax,[rbp-48]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB4E3210F8
       call      qword ptr [r11]
       mov       [rbp-70],rax
M00_L39:
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E321100
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E321108
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E321110
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-34]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED650C8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-34],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L54
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E321110
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L55
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-34],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L57
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-34],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED650C8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-34]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED645D0]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1381
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED651E8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-68],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,20666000AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       rsi,4
       dec       r15d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20666000AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20666000AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E637DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6379A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-60],rax
       mov       [rbp-58],edx
       lea       rdx,[rbp-60]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB4ED4F000]
       mov       r13,[rbp-50]
       mov       eax,[rbp-48]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       esi,esi
       mov       r15d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB4E3010F8
       call      qword ptr [r11]
       mov       [rbp-70],rax
M00_L39:
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E301100
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E301108
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E301110
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-34]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED450F8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-34],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L54
       mov       rcx,[rbp-70]
       mov       r11,7FFB4E301110
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L55
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-34],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L57
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-34],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-68]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED450F8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-34]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1381
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED45218]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,2AAFB400AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45D28]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2AAFB400AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AAFB400AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E637DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6379A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED4E4C0]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB4E3010F0
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E3010F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E301100
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E301108
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED450F8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E301108
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED450F8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44600]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED45218]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,2EB43000AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L31
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L32
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L33
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        near ptr M00_L38
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L36
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L37
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFB4ED55CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFB4ED55CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2EB43000AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2EB43000AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFB4E647DF8]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFB4E6479A8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ED5E4C0]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L35:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L36:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L37:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB4E310F70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310F78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310F80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310F88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED550F8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310F88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ED550F8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54600]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFB4ED55200]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L28
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L28
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ECA5680]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L27
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5680]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1B7B8400AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E310D70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L26
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FFB4ECA5680]
       jmp       short M00_L23
M00_L26:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L27:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L22
M00_L28:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L31
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L30
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L32
M00_L29:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L33
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       mov       rcx,r14
       call      qword ptr [7FFB4ECA5680]
       jmp       short M00_L29
M00_L33:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L28
       jmp       near ptr M00_L05
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E647DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B7B8400AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B7B8400AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6479A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ECAEC40]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ECA56F8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ECA56F8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECA5668]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED457A0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ECB5680]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ECB5680]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1721D800AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E310D70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFB4ECB5680]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFB4ECB5680]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E647DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1721D800AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1721D800AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6479A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ECBEC40]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ECB56F8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E310D88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4ECB56F8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECB5668]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ED55848]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ECAE448]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ECAE448]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,1AC21000AE0
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E300D70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E300D78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E300D80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E300D88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFB4ECAE448]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFB4ECAE448]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E637DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1AC21000AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AC21000AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6379A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4ECAF0F0]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB5D9B0]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E300D88
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EB5D9B0]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB5D998]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4ECAF2D0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L22
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L22
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4EBAC390]
       jmp       short M00_L01
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L33
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4EBAC390]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       mov       rax,16CF1400B70
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L34
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L19
       test      eax,eax
       jle       short M00_L16
       mov       rsi,[rdi+18]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L39
       xor       edx,edx
M00_L15:
       mov       r8d,[rdx+r13]
       add       r14d,r8d
       jo        near ptr M00_L41
       add       rdx,4
       dec       eax
       jne       short M00_L15
M00_L16:
       mov       esi,r14d
       jmp       near ptr M00_L42
M00_L17:
       mov       r8d,[r15+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       rsi,rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L18:
       add       r15,4
       dec       r12d
       jne       short M00_L17
       jmp       short M00_L16
M00_L19:
       mov       rcx,rsi
       mov       r11,7FFB4E321770
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E321778
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E321780
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E321788
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L22:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L25
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L24
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFB4EBAC390]
       jmp       short M00_L23
M00_L27:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L22
       jmp       near ptr M00_L05
M00_L28:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L30
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFB4EBAC390]
       jmp       short M00_L29
M00_L32:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L33:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L28
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFB4E657DF8]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16CF1400B68
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFB4E3D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16CF1400B70
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L36:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L38
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L37
       call      qword ptr [7FFB4E6579A8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB4EF446D8]
       mov       r13,[rbp-58]
       mov       eax,[rbp-50]
       jmp       near ptr M00_L14
M00_L38:
       xor       r13d,r13d
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M00_L14
M00_L39:
       xor       r15d,r15d
       mov       r12d,eax
       jmp       near ptr M00_L17
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L42:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L45
M00_L43:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L48
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L47
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L46
M00_L44:
       add       edi,1
       jo        short M00_L49
       cmp       edi,[rbp-3C]
       jl        short M00_L43
M00_L45:
       mov       rcx,[rbx+18]
       mov       [rcx+38],esi
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
M00_L46:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EBA76A8]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L50
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-3C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L52
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L53
       mov       [rbp-3C],ecx
M00_L52:
       add       rsp,28
       ret
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L54
       mov       rcx,[rbp-78]
       mov       r11,7FFB4E321788
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L55
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L56
       mov       [rbp-3C],ecx
M00_L55:
       add       rsp,28
       ret
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L57
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L58
       mov       [rbp-3C],ecx
M00_L57:
       add       rsp,28
       ret
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L64
M00_L59:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L62
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L61
       mov       rcx,r14
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFB4EBA76A8]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6B68]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       add       rsp,28
       ret
; Total bytes of code 1399
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,edx
       add       eax,r8d
       jo        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
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
       call      qword ptr [7FFB4EBA77C8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45C68]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45C68]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFB4ED45C68]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FFB4ED45C68]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED45038]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED45038]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44540]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35BA8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35BA8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35BA8]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35BA8]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED34FF0]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED34FF0]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ECBEA30]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ECBEA30]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFB4ECBEA30]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4ECBEA30]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ECBEA00]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ECBEA00]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECBE9E8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35C50]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35C50]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35C50]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35C50]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED35020]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED35020]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34528]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35C20]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35C20]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFB4ED35C20]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFB4ED35C20]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED34FF0]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB4ED34FF0]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED344F8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB4ECAEBB0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFB4ECAEBB0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFB4ECAEBB0]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFB4ECAEBB0]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4ECAEBC8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4ECAEBC8]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4ECAEB98]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB4EC5EC70]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFB4EC5EC70]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFB4EC5EC70]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFB4EC5EC70]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4EC56550]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4EC56550]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC56538]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB4EB8C300]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFB4EB8C300]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFB4EB8C300]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFB4EB8C300]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4EB87630]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB4EB87630]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86AF0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,232CF800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0F1FB5EFE
       mov       r11d,3C4E27C8
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8EA60]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC8EA18]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E2F0CF8
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC852C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E2F0CF0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC8EA48]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC8EA48]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC8EA60]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FFBA9FC3D78]
       int       3
M01_L01:
       call      qword ptr [7FFBA9FC3D80]
       int       3
; Total bytes of code 45
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,13CD2800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C305B8CC
       mov       r11d,0D459F233
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ED35C80]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E2F10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC7CF30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E2F10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED35050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED35050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED34558]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFB4ED7B2C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFB4ED7B2C0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC7F420]
       int       3
M01_L01:
       mov       rcx,7FFB4ED7B2C4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED36538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2BAE0800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,62A9FA4A
       mov       r11d,18D68221
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54570]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC9D7A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3110C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3C57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC9CEE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E807828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3110B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55068]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55068]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54570]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4ED9B280
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4ED9B278
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC9F438]
       int       3
M02_L01:
       mov       rcx,7FFB4ED9B27C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED56538]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,1DA24C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,691CEB3B
       mov       r11d,0B775C8D4
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64558]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ECAD7A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3210C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3D57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4ECACF18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3210B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64558]
       int       3
; Total bytes of code 1060
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4EDAA400
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4EDAA3F8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ECAF420]
       int       3
M02_L01:
       mov       rcx,7FFB4EDAA3FC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED66520]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,1B2F4800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0BD7B173
       mov       r11d,214722FC
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC8F2A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3010C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3B57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC8CE40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7F7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3010B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED45050]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED45050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED44558]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4ED8BD10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4ED8BD08
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC8F420]
       int       3
M02_L01:
       mov       rcx,7FFB4ED8BD0C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED465B0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,21C03000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,42CD4A52
       mov       r11d,65F8CFBC
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC955A8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC9D938]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3110C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3C57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC9D0B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E807828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3110B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC955C0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC955C0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC955A8]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4ED9BDF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4ED9BDE8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC9F480]
       int       3
M02_L01:
       mov       rcx,7FFB4ED9BDEC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED56640]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1CDF1000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,1C3B8397
       mov       r11d,823F684F
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC96808]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC9F840]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E321328
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3D57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC9E310]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E321320
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC96820]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC96820]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC96808]
       int       3
; Total bytes of code 1060
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4EDC91C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4EDC91B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EBAE7F0]
       int       3
M02_L01:
       mov       rcx,7FFB4EDC91BC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED66C70]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,23F37000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,4D49FD1
       mov       r11d,90B2BEC7
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86B08]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC94378]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E301700
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4ED668B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7F7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3016F8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EB87648]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EB87648]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFB4EB86B08]
       int       3
; Total bytes of code 1057
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FFB4EB855C0]
       int       3
M02_L01:
       call      qword ptr [7FFB4EC9E778]
       int       3
; Total bytes of code 45
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,297D2400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,77A8792A
       mov       r11d,0D1EC8595
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54528]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ED55BD8]
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3110C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3C57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC9CE40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E807828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3110B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55020]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55020]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54528]
       int       3
; Total bytes of code 1053
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFB4ED9B290
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFB4ED9B288
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC9F3F0]
       int       3
M01_L01:
       mov       rcx,7FFB4ED9B28C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED56508]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,20647800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,4B18C853
       mov       r11d,786D6B17
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64540]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ECAD7A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3210C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3D57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4ECACE28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3210B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65038]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65038]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64540]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4EDAB360
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4EDAB358
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ECAF408]
       int       3
M02_L01:
       mov       rcx,7FFB4EDAB35C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED66508]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F8D6000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A262EEA8
       mov       r11d,2901D3AD
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EAF0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC9E370]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E2F0F38
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC953C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E2F0F30
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC9E3A0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC9E3A0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC9EAF0]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FFBA9FC3D78]
       int       3
M02_L01:
       call      qword ptr [7FFBA9FC3D80]
       int       3
; Total bytes of code 45
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,2A2CC000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0ED1735D7
       mov       r11d,40743884
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54588]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC9D7D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3110C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3C57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC9CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E807828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3110B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55080]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED55080]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED54588]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4ED9B2B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4ED9B2B0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC9F450]
       int       3
M02_L01:
       mov       rcx,7FFB4ED9B2B4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED56550]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,28997800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,7DBFEB2E
       mov       r11d,32193C13
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64528]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ECAD788]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3210C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3D57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4ECACDF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3210B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65020]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4ED65020]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4ED64528]
       int       3
; Total bytes of code 1053
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4EDAAE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4EDAAE88
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ECAF3F0]
       int       3
M02_L01:
       mov       rcx,7FFB4EDAAE8C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED66580]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,2CD9AC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,20676D0
       mov       r11d,4D855408
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC75458]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EC7F2D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E2F10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EC7CE70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E7E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E2F10B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC75470]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EC75470]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4EC75458]
       int       3
; Total bytes of code 1053
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FFB4ED7BD18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFB4ED7BD10
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EC7F498]
       int       3
M02_L01:
       mov       rcx,7FFB4ED7BD14
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED36598]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F0AEC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E01C3B8D
       mov       r11d,0A1193A43
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBF7078]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4ED742A0]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E3212A0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFB4E3D57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4EBFEB80]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E321298
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EBF7090]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EBF7090]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBF7078]
       int       3
; Total bytes of code 1051
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FFB4EDA1B68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFB4EDA1B60
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4EBF6838]
       int       3
M01_L01:
       mov       rcx,7FFB4EDA1B64
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB4ED756E0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,25B26C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,9BE66F17
       mov       r11d,3CF897BC
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFBADEE9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6AF0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB4EBAC300]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFB4E321700
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB4ED867F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4E817828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FFB4E3216F8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EBA7630]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FFBADFA6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFB4EBA7630]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFB4EBA6AF0]
       int       3
; Total bytes of code 1050
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFBA9FA8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FFB4EBA55A8]
       int       3
M02_L01:
       call      qword ptr [7FFB4ECBE778]
       int       3
; Total bytes of code 45
```

