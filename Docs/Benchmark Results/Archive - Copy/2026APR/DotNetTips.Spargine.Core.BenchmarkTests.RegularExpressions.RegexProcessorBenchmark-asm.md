## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsFirstLastName()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,193654000D0
       mov       rsi,[rcx]
       mov       edi,0E
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1D3E42D06C0
       cmp       edi,0E
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27558]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,0E00000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],0E
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],0E
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E6D710],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,19365400168
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],0E
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E275E8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],0E
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E275E8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      qword ptr [7FF997805728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997E2FF48]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 851
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997E2FF78]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997805C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsWord()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       test      rsi,rsi
       je        near ptr M00_L18
       mov       rcx,1D4E18000D0
       mov       rdi,[rcx]
       mov       ecx,[rsi+8]
       mov       r14d,ecx
       xor       eax,eax
       test      byte ptr [rdi+40],40
       mov       r15d,eax
       cmovne    r15d,ecx
       mov       [rbp-48],rdi
       cmp       ecx,r15d
       jb        near ptr M00_L16
       lea       rcx,[rdi+30]
       xor       eax,eax
       mov       r13,rax
       xchg      r13,[rcx]
       test      r13,r13
       je        near ptr M00_L17
M00_L00:
       mov       [rbp-50],r13
       mov       rdx,[rdi+48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF997E37528]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       add       rsi,0C
       xor       ecx,ecx
       mov       [r13+60],ecx
       lea       rcx,[r13+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+48],r15d
       xor       ecx,ecx
       mov       [r13+40],ecx
       mov       [r13+44],r14d
       mov       [r13+4C],r15d
       mov       rdi,[r13+28]
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rdx,[r13+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+34],ecx
       mov       [rdi+5C],r14d
       mov       rcx,[rdi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rdi+60],0
       mov       rcx,[rdi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rdi,[rbp-50]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rdi+10]
       mov       eax,[rax+8]
       mov       [rdi+50],eax
       mov       rax,[rdi+18]
       mov       eax,[rax+8]
       mov       [rdi+54],eax
       mov       ecx,[rcx+8]
       mov       [rdi+58],ecx
M00_L04:
       mov       [rbp-40],rsi
       mov       [rbp-38],r14d
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,[rdi+28]
       mov       rcx,[rsi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rsi+8],rcx
       test      byte ptr [7FF997E7D6F0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1D4E1800168
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r13+30]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[r13+30]
       mov       [rsp+20],r14d
       mov       r8,[r13+30]
       mov       r8d,[r8+44]
       mov       r9,[r13+8]
       mov       rcx,r15
       call      qword ptr [7FF997E375B8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[r15+68]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [rsp+20],r14d
       mov       r8,[r13+30]
       mov       r8d,[r8+44]
       mov       rdx,[r13+30]
       mov       r9,[r13+8]
       mov       rcx,r15
       call      qword ptr [7FF997E375B8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r15d,[rdi+5C]
       shl       r15d,3
       mov       r13d,r15d
       mov       edx,20
       cmp       r15d,20
       cmovl     r13d,edx
       mov       edx,10
       cmp       r15d,10
       cmovl     r15d,edx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r13d
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+54],r15d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      qword ptr [7FF997815728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      dil
       movzx     edi,dil
M00_L15:
       mov       rax,[rbx+60]
       mov       [rax+4C],dil
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997E3FE40]
       int       3
M00_L17:
       mov       rcx,[rdi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L18:
       xor       edi,edi
       jmp       short M00_L15
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp-50]
       mov       [rdi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 867
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997E3FE70]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997815C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCreditCardNumber()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,195FD4020F0
       mov       rsi,[rcx]
       mov       edi,10
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1D6926906C0
       cmp       edi,10
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E5F300]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,1000000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],10
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],10
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997EBD960],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,195FD4021A8
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],10
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E5F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],10
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E5F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EE6EC8]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EE6EF8]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997805C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCurrencyCode()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,220A5C020F0
       mov       rsi,[rcx]
       mov       edi,3
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2613AB006C0
       cmp       edi,3
       ja        near ptr M00_L13
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L14
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E4F300]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,300000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],3
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],3
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rsi+28]
       mov       rdx,[rcx+50]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L11
       cmp       dword ptr [rdx+10],0
       jg        short M00_L05
       xor       edx,edx
       mov       [rcx+8],rdx
       mov       rcx,220A5C02178
       mov       rdi,[rcx]
       jmp       short M00_L06
M00_L05:
       xor       edx,edx
       mov       [rcx+8],rdx
       xor       edi,edi
M00_L06:
       jmp       near ptr M00_L12
M00_L07:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L08
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],3
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L09
M00_L08:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],3
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L09:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED6CE8]
       int       3
M00_L14:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 816
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997ED6D18]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsEmailAddress()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,1D359C020F0
       mov       rsi,[rcx]
       mov       edi,13
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,213EE9D06C0
       cmp       edi,13
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E6F300]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,1300000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],13
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],13
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jle       short M00_L07
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
       jmp       short M00_L09
M00_L05:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L10
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],13
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E6F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L07:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997ECD850],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,1D359C021A8
       mov       r14,[rcx]
M00_L09:
       jmp       near ptr M00_L14
M00_L10:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],13
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E6F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M00_L06
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L08
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EF70F0]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EF7120]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997815C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsGuid()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,278134020F0
       mov       rsi,[rcx]
       mov       edi,24
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2B8A83C06C0
       cmp       edi,24
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E7F300]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,2400000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],24
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],24
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997EDDBF0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,278134021A8
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],24
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E7F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],24
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E7F390]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EF6D18]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EF6D48]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997815C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv4Address()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,23B984000F8
       mov       rsi,[rcx]
       mov       edi,0B
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,27C175506C0
       cmp       edi,0B
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E4F318]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,0B00000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],0B
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],0B
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jle       short M00_L07
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
       jmp       short M00_L09
M00_L05:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L10
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],0B
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F3A8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L07:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997EAD960],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,23B984001B0
       mov       r14,[rcx]
M00_L09:
       jmp       near ptr M00_L14
M00_L10:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],0B
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F3A8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M00_L06
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L08
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED6D90]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997ED6DC0]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF9977F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv6Address()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,1E5424020C8
       mov       rsi,[rcx]
       mov       edi,27
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,225D72F06C0
       cmp       edi,27
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E37558]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,2700000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],27
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],27
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E7D710],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1E542402160
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],27
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E375E8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],27
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E375E8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      qword ptr [7FF997815728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997E3FC78]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 851
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997E3FCA8]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997815C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsISBN()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,1BB27C000D0
       mov       rsi,[rcx]
       mov       edi,0D
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1FBA6CB06C0
       cmp       edi,0D
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27648]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,0D00000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],0D
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],0D
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E6D940],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1BB27C00168
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],0D
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E276D8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],0D
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E276D8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997E2FD08]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997E2FD38]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997805C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsMACAddress()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,1A5014000D0
       mov       rsi,[rcx]
       mov       edi,11
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1E5804706C0
       cmp       edi,11
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E47678]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,1100000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],11
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],11
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E8DBF0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1A501400168
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],11
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E47708]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],11
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E47708]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      qword ptr [7FF997825728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997E4FCD8]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 851
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997E4FD08]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF997825C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsScientific()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,1D90C0000F8
       mov       rsi,[rcx]
       mov       edi,8
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2199C6B06C0
       cmp       edi,8
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E3F2B8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,800000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],8
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],8
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E9CFB0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1D90C0001B0
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],8
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E3F348]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],8
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E3F348]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EC6E38]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EC6E68]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF9977E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsSHA1Hash()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,15A1D4000F8
       mov       rsi,[rcx]
       mov       edi,28
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,19A9C3F06C0
       cmp       edi,28
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E4F210]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,2800000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],28
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],28
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jle       short M00_L07
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
       jmp       short M00_L09
M00_L05:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L10
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],28
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F2A0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L07:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997EAD230],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,15A1D4001B0
       mov       r14,[rcx]
M00_L09:
       jmp       near ptr M00_L14
M00_L10:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],28
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E4F2A0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M00_L06
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L08
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED6F10]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997ED6F40]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF9977F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrl()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,190E54000E0
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1D1641E06C0
       cmp       edi,15
       ja        near ptr M00_L15
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L16
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E3EA78]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,1500000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],15
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],15
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L12
       cmp       dword ptr [rcx+10],0
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF997E9AA98],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,190E54001A8
       mov       r14,[rcx]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       xor       r14d,r14d
M00_L07:
       jmp       near ptr M00_L14
M00_L08:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],15
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E3EB08]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],15
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E3EB08]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L10:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L05
M00_L14:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EB6898]
       int       3
M00_L16:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 850
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EB68C8]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
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
       jmp       qword ptr [7FF9977F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrlDomainAddress()
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
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rcx,2B9494020F0
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2F9DE4006C0
       cmp       edi,15
       ja        near ptr M00_L13
       lea       rcx,[rsi+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L14
M00_L00:
       mov       [rbp-50],r15
       mov       rdx,[rsi+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E6F2E8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r15+8],r14
       lea       r13,[r14+0C]
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       mov       rcx,1500000000
       mov       [r15+40],rcx
       mov       [r15+4C],edi
       mov       rsi,[r15+28]
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,r14
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       dword ptr [rsi+5C],15
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L02
       add       rcx,10
M00_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L01
M00_L02:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M00_L03
       xor       eax,eax
       mov       [rcx+18],rax
M00_L03:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M00_L04:
       mov       [rbp-40],r13
       mov       dword ptr [rbp-38],15
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rsi+28]
       mov       rdx,[rcx+50]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L11
       cmp       dword ptr [rdx+10],0
       jg        short M00_L05
       xor       edx,edx
       mov       [rcx+8],rdx
       mov       rcx,2B949402178
       mov       rdi,[rcx]
       jmp       short M00_L06
M00_L05:
       xor       edx,edx
       mov       [rcx+8],rdx
       xor       edi,edi
M00_L06:
       jmp       near ptr M00_L12
M00_L07:
       mov       rcx,[r15+30]
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L08
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r15+30]
       mov       dword ptr [rsp+20],15
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E6F378]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L09
M00_L08:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],15
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF997E6F378]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L09:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rsi+5C]
       shl       edi,3
       mov       r14d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r14d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+50],r14d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       mov       rdx,[rbx+60]
       mov       [rdx+4C],cl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EE7048]
       int       3
M00_L14:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-50]
       mov       [rsi+8],rcx
       mov       rax,[rbp-48]
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 816
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF997EE7078]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsValidString()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       call      qword ptr [7FF997C15CE0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rbx,rax
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L29
       mov       rcx,1DDB7001370
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L00:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,1DDB7000108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,1DDB70000F8
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       call      qword ptr [7FF997A24150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rsi,rax
M00_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF997C16298]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L23
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L22
       mov       rcx,rdi
       mov       rdx,21E4C1706C0
       mov       r9d,1
       call      qword ptr [7FF997C16C88]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L02
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L21
M00_L02:
       test      r14,r14
       je        near ptr M00_L23
M00_L03:
       test      r14,r14
       je        near ptr M00_L32
       mov       rcx,1DDB70020F0
       mov       rbx,[rcx]
       mov       ecx,[r14+8]
       mov       esi,ecx
       xor       eax,eax
       test      byte ptr [rbx+40],40
       mov       edi,eax
       cmovne    edi,ecx
       mov       [rbp-60],rbx
       cmp       ecx,edi
       jb        near ptr M00_L30
       lea       rcx,[rbx+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L31
M00_L04:
       mov       [rbp-68],r15
       mov       rdx,[rbx+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF997E5F330]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,0C
       xor       ecx,ecx
       mov       [r15+60],ecx
       lea       rcx,[r15+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],edi
       xor       ecx,ecx
       mov       [r15+40],ecx
       mov       [r15+44],esi
       mov       [r15+4C],edi
       mov       rbx,[r15+28]
       test      rbx,rbx
       je        near ptr M00_L12
       mov       rdx,[r15+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+5C],esi
       mov       rcx,[rbx+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L06
       add       rcx,10
M00_L05:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L05
M00_L06:
       mov       byte ptr [rbx+60],0
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        short M00_L07
       xor       eax,eax
       mov       [rcx+18],rax
M00_L07:
       mov       rbx,[rbp-68]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M00_L16
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M00_L08:
       mov       [rbp-40],r14
       mov       [rbp-38],esi
       lea       rdx,[rbp-40]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,[rbx+28]
       mov       rcx,[rsi+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L15
       cmp       dword ptr [rcx+10],0
       jg        short M00_L10
       xor       ecx,ecx
       mov       [rsi+8],rcx
       test      byte ptr [7FF997EBD970],1
       je        near ptr M00_L17
M00_L09:
       mov       rcx,1DDB70021A8
       mov       rdi,[rcx]
       jmp       short M00_L11
M00_L10:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       xor       edi,edi
M00_L11:
       jmp       near ptr M00_L18
M00_L12:
       mov       rcx,[r15+30]
       cmp       qword ptr [rcx+18],0
       je        short M00_L13
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,[r15+8]
       mov       [rsp+20],r8
       mov       [rsp+28],esi
       mov       r8,[r15+30]
       mov       r8,[r8+18]
       mov       r9,[r15+30]
       mov       r9d,[r9+44]
       mov       rdx,[r15+30]
       mov       rcx,rbx
       call      qword ptr [7FF997EE7108]
       jmp       short M00_L14
M00_L13:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+20],esi
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,[r15+8]
       mov       rcx,rbx
       call      qword ptr [7FF997E5F3C0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L14:
       lea       rcx,[r15+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L07
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L16:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[rbx+5C]
       shl       edi,3
       mov       r15d,edi
       mov       edx,20
       cmp       edi,20
       cmovl     r15d,edx
       mov       edx,10
       cmp       edi,10
       cmovl     edi,edx
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+50],r15d
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+58],20
       jmp       near ptr M00_L08
M00_L17:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L09
M00_L18:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       rax,[rbp-60]
       lea       rcx,[rax+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       sete      bl
       movzx     ebx,bl
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF997EE6718]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L21:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L22:
       mov       rcx,rdi
       mov       rdx,21E4C1706C0
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FF997EE7018]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-48],rsi
M00_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF997C7E228]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF997948720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L27
       cmp       r14,rdi
       je        short M00_L24
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,21E4C1706C0
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L25
       mov       rdi,r14
       jmp       short M00_L24
M00_L25:
       cmp       qword ptr [rbx+38],0
       je        short M00_L26
       mov       rdx,[rbx+38]
       mov       [rbp-58],rdx
       mov       byte ptr [rbp-30],0
       lea       rdx,[rbp-30]
       mov       rcx,[rbp-58]
       call      qword ptr [7FF997805998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-30],0
       je        short M00_L26
       mov       rcx,[rbp-58]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M00_L26:
       mov       [rbp-50],r15
       jmp       short M00_L28
M00_L27:
       xor       r8d,r8d
       mov       rcx,[rbp-48]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L28:
       call      M00_L34
       nop
       mov       r14,[rbp-50]
       jmp       near ptr M00_L03
M00_L29:
       mov       r8,1DDB7001370
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,21E4C1706C0
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L30:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EE70C0]
       int       3
M00_L31:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L04
M00_L32:
       xor       ebx,ebx
       jmp       near ptr M00_L19
       sub       rsp,38
       cmp       byte ptr [rbp-30],0
       je        short M00_L33
       mov       rcx,[rbp-58]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M00_L33:
       nop
       add       rsp,38
       ret
M00_L34:
       sub       rsp,38
       xor       r8d,r8d
       mov       rcx,[rbp-48]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       xor       ecx,ecx
       mov       rbx,[rbp-68]
       mov       [rbx+8],rcx
       mov       rax,[rbp-60]
       lea       rcx,[rax+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       ret
; Total bytes of code 1603
```
```assembly
; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
;                 if (object.ReferenceEquals(resourceMan, null)) {
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetTips.Spargine.Tester.Properties.Resources", typeof(Resources).Assembly);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     resourceMan = temp;
;                     ^^^^^^^^^^^^^^^^^^^
;                 return resourceMan;
;                 ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,1DDB7001368
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,21E4C16B988
       call      qword ptr [7FF997EE71B0]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,21E4C16B910
       call      qword ptr [7FF997C15D10]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 101
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FF9EF9787D0]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FF9EF98FA08]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF9EF990BA0]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF9EF98E3E8]
       int       3
; Total bytes of code 63
```
```assembly
; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        short M03_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M03_L17
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M03_L16
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L19
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M03_L18
M03_L01:
       cmp       rdi,rdx
       jne       near ptr M03_L15
M03_L02:
       mov       rax,1DDB7000100
       mov       rax,[rax]
       mov       [rbp+18],rax
M03_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L22
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M03_L04
       call      qword ptr [7FF997EE6C40]
       int       3
M03_L04:
       mov       rcx,[rbp-30]
       call      00007FF9F749DAE0
       test      eax,eax
       jne       short M03_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997EE6A30]
M03_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M03_L11
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L10
M03_L06:
       mov       rax,[rbp+10]
       mov       r8,[rax+38]
       mov       rdx,[r8+8]
       cmp       rcx,rdx
       jne       short M03_L08
M03_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M03_L13
M03_L08:
       test      rcx,rcx
       je        near ptr M03_L12
       test      rdx,rdx
       je        short M03_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M03_L12
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF99780FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M03_L09:
       test      eax,eax
       je        near ptr M03_L20
       jmp       short M03_L07
M03_L10:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,21E4C160008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M03_L06
M03_L11:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M03_L06
M03_L12:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M03_L09
M03_L13:
       cmp       byte ptr [rbp-28],0
       je        short M03_L14
       mov       rcx,[rbp-30]
       call      00007FF9F749DA00
       test      eax,eax
       jne       near ptr M03_L21
M03_L14:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L15:
       test      rdi,rdi
       je        near ptr M03_L03
       test      rdx,rdx
       je        near ptr M03_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L03
       lea       rax,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF99780FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L16:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,21E4C160008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L17:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M03_L19
M03_L18:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,21E4C160008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M03_L01
M03_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M03_L01
M03_L20:
       call      M03_L26
       jmp       short M03_L22
M03_L21:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF997EE6958]
       jmp       near ptr M03_L14
M03_L22:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M03_L23
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FF997805998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FF99784AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,rbx
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M03_L23:
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L25
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M03_L24
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997805998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+18]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L24
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M03_L24:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L25:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L26:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L27
       mov       rcx,[rbp-30]
       call      00007FF9F749DA00
       test      eax,eax
       je        short M03_L27
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF997EE6958]
M03_L27:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L28
       mov       rcx,[rbp-38]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M03_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L29
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M03_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1028
```
```assembly
; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M04_L24
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M04_L25
       test      rbx,rbx
       je        near ptr M04_L25
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M04_L00
       call      qword ptr [7FF997EE6C40]
       int       3
M04_L00:
       mov       rcx,rbx
       call      00007FF9F749DAE0
       test      eax,eax
       jne       short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF997EE6A30]
M04_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L16
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M04_L11
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M04_L03
       lea       r11,[rdx+0C]
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M04_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M04_L02
M04_L03:
       mov       r14d,ecx
M04_L04:
       mov       r8,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       eax,[r8+8]
       mov       r10d,eax
       imul      rcx,r10
       shr       rcx,20
       cmp       ecx,eax
       jae       near ptr M04_L20
       mov       ecx,ecx
       lea       r8,[r8+rcx*4+10]
       mov       r15d,[r8]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M04_L16
M04_L05:
       mov       r8d,r15d
       shl       r8,5
       lea       r15,[r13+r8+10]
       cmp       [r15+8],r14d
       jne       near ptr M04_L15
       mov       r10,[r15]
       mov       r8,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,r8
       jne       near ptr M04_L14
       cmp       r10,rdx
       jne       short M04_L09
       mov       r9d,1
M04_L06:
       test      r9d,r9d
       je        near ptr M04_L15
       add       r15,10
M04_L07:
       test      r15,r15
       je        short M04_L10
       vmovdqu   xmm0,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M04_L17
M04_L08:
       mov       [rbp-80],rsi
       jmp       near ptr M04_L22
M04_L09:
       test      r10,r10
       je        near ptr M04_L13
       mov       r8d,[r10+8]
       mov       ecx,[rdx+8]
       cmp       r8d,ecx
       jne       near ptr M04_L13
       lea       rcx,[r10+0C]
       mov       r8d,[r10+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF99780FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L06
M04_L10:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FF997C16D00]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M04_L21
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997C16D78]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF997C16E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L08
M04_L11:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FF997750A48
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L04
M04_L12:
       cmp       eax,r15d
       jbe       short M04_L16
       jmp       near ptr M04_L05
M04_L13:
       xor       r9d,r9d
       jmp       near ptr M04_L06
M04_L14:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FF997750A50
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L06
M04_L15:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M04_L12
       call      qword ptr [7FF997A27A08]
       int       3
M04_L16:
       mov       rdx,[rbp+18]
       xor       r15d,r15d
       jmp       near ptr M04_L07
M04_L17:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M04_L18
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997EE6CA0]
       jmp       short M04_L19
M04_L18:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997D8E538]; System.Resources.ResourceReader.LoadString(Int32)
M04_L19:
       mov       [rbp-80],rax
       jmp       short M04_L22
M04_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L21:
       call      M04_L38
       jmp       near ptr M04_L27
M04_L22:
       cmp       byte ptr [rbp-50],0
       je        short M04_L23
       mov       rcx,[rbp-78]
       call      00007FF9F749DA00
       test      eax,eax
       jne       short M04_L26
M04_L23:
       mov       rax,[rbp-80]
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
M04_L24:
       mov       ecx,13BFC
       mov       rdx,7FF997744000
       call      qword ptr [7FF997A27798]
       mov       rcx,rax
       call      qword ptr [7FF997EE5EC0]
       int       3
M04_L25:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997EE6C70]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF997EE6C88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L26:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FF997EE6958]
       jmp       short M04_L23
M04_L27:
       cmp       byte ptr [rbp+20],0
       jne       short M04_L28
       xor       eax,eax
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
M04_L28:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M04_L29
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,1DDB7000070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF997C16B38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M04_L29:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FF997805998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M04_L32
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF997EE6CB8]
       jmp       short M04_L31
M04_L30:
       mov       rcx,rsi
       call      qword ptr [7FF997C84248]
       mov       rdx,rax
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       r8d,[rsi+14]
       cmp       [rbx],bl
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],r8d
       lea       r8,[rbp-60]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FF997C16E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M04_L31:
       mov       rcx,rsi
       call      qword ptr [7FF997C84240]
       test      eax,eax
       jne       short M04_L30
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M04_L32:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF997C825D0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M04_L33
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M04_L36
M04_L33:
       cmp       qword ptr [rbp-48],0
       je        short M04_L34
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M04_L36
M04_L34:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FF997C16D78]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M04_L35
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF997C16E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M04_L35:
       cmp       byte ptr [rbp-50],0
       je        short M04_L37
       mov       rcx,[rbp-78]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M04_L37
M04_L36:
       call      M04_L40
       jmp       near ptr M04_L23
M04_L37:
       mov       rax,rsi
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
M04_L38:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L39
       mov       rcx,[rbp-78]
       call      00007FF9F749DA00
       test      eax,eax
       je        short M04_L39
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FF997EE6958]
M04_L39:
       nop
       add       rsp,28
       ret
M04_L40:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L41
       mov       rcx,[rbp-78]
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
M04_L41:
       nop
       add       rsp,28
       ret
; Total bytes of code 1369
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF997EE70F0]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbp,r9
       mov       ecx,2
       call      qword ptr [7FFA0CCB6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA0CCB8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA0CCB6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA0CCB59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA0CCB59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       esi,[rsp+70]
       mov       [rbx+5C],esi
       mov       byte ptr [rbx+60],0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF997805C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF9EF990CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M08_L01
       cmp       [rax],ecx
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M08_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],edx
       jle       short M08_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M08_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M09_L00
       cmp       [rdx],rcx
       jne       short M09_L01
M09_L00:
       mov       rax,rdx
       ret
M09_L01:
       jmp       qword ptr [7FF99780FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       byte ptr [rbx],0
       je        short M10_L00
       call      qword ptr [7FF9EF990BF0]
       int       3
M10_L00:
       test      rsi,rsi
       je        short M10_L02
       mov       rcx,rsi
       call      qword ptr [7FF9EF990BB0]
       test      eax,eax
       jne       short M10_L01
       mov       rcx,rsi
       call      qword ptr [7FF9EF990BC0]
M10_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L02:
       xor       ecx,ecx
       call      qword ptr [7FF9EF98B1E8]
       int       3
; Total bytes of code 70
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      00007FF9F749DA00
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FF997EE5EC0]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF997EE6958]
; Total bytes of code 56
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveHtml()
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
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,22692400110
       mov       rsi,[rcx]
       mov       edi,11
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       rbp,[rsi+38]
       test      rbp,rbp
       je        near ptr M00_L12
M00_L00:
       mov       r14,[rsi+18]
       mov       r15d,[rsi+44]
       mov       r13,[rsi+20]
       mov       r12d,[rsi+40]
       mov       rcx,[rbp+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        short M00_L03
       test      cl,2
       jne       short M00_L01
       mov       rax,[rcx]
       jmp       short M00_L04
M00_L01:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       rax,[rdx]
       test      rax,rax
       jne       short M00_L02
       mov       rdx,7FF997FD2868
       call      qword ptr [7FF9977E6E08]
M00_L02:
       jmp       short M00_L04
M00_L03:
       xor       eax,eax
M00_L04:
       test      rax,rax
       je        near ptr M00_L08
       mov       [rsp+28],rax
       mov       r8,[rax+18]
       cmp       [r8],r8b
       mov       rdx,26711400008
       cmp       r8,rdx
       jne       near ptr M00_L14
M00_L05:
       mov       rax,[rsp+28]
       cmp       [rax],al
       mov       rbp,267114106C0
       mov       ecx,11
       cmp       ecx,edi
       jb        near ptr M00_L18
       test      byte ptr [rsi+40],40
       jne       near ptr M00_L20
       cmp       byte ptr [rax+20],0
       jne       near ptr M00_L20
       mov       rcx,[rax+10]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L19
       mov       r8,26711400008
M00_L06:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997E0FD68]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L07:
       mov       [rsp+30],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L08:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,26711400008
       call      qword ptr [7FF997E0FBA0]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L15
       test      r14,r14
       je        short M00_L09
       cmp       qword ptr [7FF99772B020],0
       jne       near ptr M00_L16
M00_L09:
       xor       eax,eax
M00_L10:
       test      r15b,2
       jne       near ptr M00_L17
       test      rax,rax
       jne       near ptr M00_L17
       mov       rcx,r15
       mov       rdx,r14
       call      00007FF9F7424440
M00_L11:
       mov       [rsp+28],r14
       jmp       near ptr M00_L05
M00_L12:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9977E6D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L13
       call      qword ptr [7FF997ECD9C8]
       int       3
M00_L13:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF9F7419D60
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L14:
       cmp       dword ptr [r8+8],0
       jne       near ptr M00_L08
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       mov       rdx,26711400014
       call      qword ptr [7FF9977EFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M00_L05
       jmp       near ptr M00_L08
M00_L15:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ECF930]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997B667F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rax,[7FF99772B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,r14
       call      qword ptr [7FF997ECF948]
       jmp       near ptr M00_L10
M00_L17:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF997ECF960]
       jmp       near ptr M00_L11
M00_L18:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ECE760]
       int       3
M00_L19:
       mov       r8,[rax+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L21
       mov       r8,[r8+10]
       jmp       near ptr M00_L06
M00_L20:
       mov       [rsp+20],edi
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997ECE778]
       jmp       near ptr M00_L07
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 735
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,148
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M01_L53
       mov       ecx,[rbx+8]
       mov       rax,rbx
M01_L00:
       mov       [rbp-70],rbx
       mov       [rbp-68],rdi
       mov       rdx,26711410D98
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,226924001B0
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L54
M01_L01:
       mov       [rbp-0F8],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M01_L52
       xor       r13d,r13d
       xor       r12d,r12d
M01_L02:
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M01_L55
M01_L03:
       mov       [rbp-108],rdx
       mov       [rbp-100],rdx
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-100]
       call      qword ptr [7FF997EC4048]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
M01_L04:
       mov       rdx,[rbp-108]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-108]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M01_L16
       mov       rax,[rdx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],r12d
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M01_L06
       add       rcx,10
M01_L05:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M01_L05
M01_L06:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M01_L07
       xor       eax,eax
       mov       [rcx+18],rax
M01_L07:
       mov       rsi,[rbp-108]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M01_L23
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M01_L08:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveHtmlRegex_14+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M01_L28
       mov       rax,rsi
       mov       [rbp-130],rax
       mov       r10d,[rax+4C]
       lea       ecx,[r12-3]
       cmp       r10d,ecx
       jg        near ptr M01_L18
M01_L09:
       cmp       r10d,r12d
       ja        near ptr M01_L32
       mov       ecx,r10d
       lea       rcx,[r13+rcx*2]
       mov       [rbp-94],r10d
       mov       r8d,r12d
       sub       r8d,r10d
       mov       edx,3C
       call      qword ptr [7FF997957798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jl        near ptr M01_L18
       mov       edx,[rbp-94]
       add       edx,eax
       mov       rax,[rbp-130]
       mov       [rax+4C],edx
       mov       [rbp-0C8],r13
       mov       [rbp-0C0],r12d
       lea       rdx,[rbp-0C8]
       mov       rcx,rax
       call      qword ptr [7FF997EC4228]; System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveHtmlRegex_14+RunnerFactory+Runner.TryMatchAtCurrentPosition(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        near ptr M01_L27
M01_L10:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L33
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M01_L19
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L33
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M01_L33
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M01_L11:
       mov       [rbp-128],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M01_L34
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M01_L29
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L20
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M01_L12:
       mov       r8,[rbp-128]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L21
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M01_L13:
       mov       r8,[rbp-128]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M01_L34
M01_L14:
       mov       eax,[rsi+4C]
       mov       ecx,eax
       cmp       dword ptr [r8+14],0
       je        near ptr M01_L30
M01_L15:
       mov       rdx,[rsi+10]
       mov       edx,[rdx+8]
       mov       [rsi+50],edx
       mov       rdx,[rsi+18]
       mov       edx,[rdx+8]
       mov       [rsi+54],edx
       mov       rdx,[rsi+20]
       mov       edx,[rdx+8]
       mov       [rsi+58],edx
       mov       [rbp-88],ecx
       mov       esi,eax
       jmp       near ptr M01_L04
M01_L16:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-148],rax
       test      rax,rax
       je        near ptr M01_L22
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-118],rdx
       mov       rax,rsi
       mov       r10,[rbp-148]
       mov       [rbp-120],r10
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-108]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF997EC41B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-118]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-118]
M01_L17:
       mov       rsi,[rbp-108]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L07
M01_L18:
       mov       rax,[rbp-130]
       mov       [rax+4C],r12d
       jmp       near ptr M01_L10
M01_L19:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,226924001D0
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M01_L11
M01_L20:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997EC4300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M01_L12
M01_L21:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997EC4300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M01_L13
M01_L22:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-110],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-108]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-110]
       call      qword ptr [7FF997EC41B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-110]
       jmp       near ptr M01_L17
M01_L23:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M01_L24
       mov       r8d,20
M01_L24:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M01_L25
       mov       dword ptr [rbp-8C],10
M01_L25:
       mov       [rbp-90],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-90]
       mov       [rsi+50],edx
       movsxd    rdx,dword ptr [rbp-8C]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-8C]
       mov       [rsi+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M01_L08
M01_L26:
       inc       dword ptr [rdx+4C]
       mov       ecx,[rdx+4C]
       lea       eax,[r12-3]
       cmp       ecx,eax
       mov       r10d,ecx
       jg        near ptr M01_L18
       jmp       near ptr M01_L09
M01_L27:
       mov       rdx,[rbp-130]
       cmp       [rdx+4C],r12d
       jne       short M01_L26
       jmp       near ptr M01_L10
M01_L28:
       mov       [rbp-0C8],r13
       mov       [rbp-0C0],r12d
       lea       rdx,[rbp-0C8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L10
M01_L29:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-128]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-128]
       je        short M01_L34
       jmp       near ptr M01_L14
M01_L30:
       mov       ecx,r12d
       mov       edx,1
       mov       r8,[rbp-0F8]
       test      byte ptr [r8+40],40
       je        short M01_L31
       xor       ecx,ecx
       mov       edx,0FFFFFFFF
M01_L31:
       cmp       eax,ecx
       je        short M01_L34
       lea       ecx,[rax+rdx]
       jmp       near ptr M01_L15
M01_L32:
       call      qword ptr [7FF997957198]
       int       3
M01_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L34:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-0F8]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       je        near ptr M01_L42
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L50
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M01_L35:
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L51
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M01_L36:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M01_L56
       cmp       [rax+8],ecx
       jb        near ptr M01_L57
       add       rax,10
M01_L37:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M01_L39
M01_L38:
       cmp       edx,ecx
       jae       near ptr M01_L80
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M01_L38
M01_L39:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,226924001B8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L58
M01_L40:
       test      r14d,r14d
       jle       near ptr M01_L48
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF9F7494CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rdx,[r15+0C]
       mov       [rbp-0D8],rdx
       mov       [rbp-0D0],r14d
       mov       [rbp-0F0],rbx
       mov       [rbp-0E8],rdi
       lea       rdx,[rbp-80]
       mov       [rbp-0E0],rdx
       lea       rdx,[rbp-0D8]
       lea       r8,[rbp-0F0]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M01_L41:
       mov       r14,r15
M01_L42:
       cmp       qword ptr [rbp-58],0
       je        near ptr M01_L47
       mov       rcx,2267C401D28
       mov       rbx,[rcx]
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M01_L59
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M01_L59
M01_L43:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M01_L60
M01_L44:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],edi
       jbe       short M01_L45
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M01_L61
       cmp       edi,[rax+8]
       jae       near ptr M01_L80
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-138],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-138]
       test      r12,r12
       jne       near ptr M01_L62
M01_L45:
       mov       rcx,2267C400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M01_L77
M01_L46:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M01_L47:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L48:
       test      r14d,r14d
       je        short M01_L49
       mov       ecx,28
       call      qword ptr [7FF997A0C168]
       int       3
M01_L49:
       mov       r15,26711400008
       jmp       near ptr M01_L41
M01_L50:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997EC4300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M01_L35
M01_L51:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997EC4300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M01_L36
M01_L52:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M01_L02
M01_L53:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L54:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,226924001A8
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF9977E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,226924001B0
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L55:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M01_L03
M01_L56:
       test      ecx,ecx
       jne       short M01_L57
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L37
M01_L57:
       call      qword ptr [7FF997957198]
       int       3
M01_L58:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,226924001A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF9977E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,226924001B8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L59:
       mov       ecx,7
       call      qword ptr [7FF997ECDF98]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L43
M01_L60:
       mov       rcx,rbx
       call      qword ptr [7FF997D7F228]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L44
M01_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF997ECE5F8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF997724000
       call      qword ptr [7FF997A0C030]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF997B66898]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L62:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L80
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L63
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF997ECE610]
M01_L63:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9977E5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99772B1A4],0
       je        short M01_L64
       call      qword ptr [7FF997ECE628]
       mov       edx,eax
       mov       [rbp-0A8],edx
       jmp       short M01_L66
M01_L64:
       mov       ecx,9
       call      qword ptr [7FF997ECE640]
       mov       eax,[rax+10]
       mov       [rbp-0AC],eax
       mov       ecx,9
       call      qword ptr [7FF997ECE640]
       mov       edx,[rbp-0AC]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L65
       call      qword ptr [7FF997ECE658]
       mov       edx,eax
       mov       [rbp-0A8],edx
       jmp       short M01_L66
M01_L65:
       sar       edx,10
       mov       [rbp-0A8],edx
M01_L66:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9977E5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0A8]
       xor       edx,edx
       div       dword ptr [7FF99772B198]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L73
M01_L67:
       cmp       eax,[r13+8]
       jae       near ptr M01_L80
       mov       [rbp-0A0],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-140],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0B0],r10d
       mov       rcx,r8
       call      qword ptr [7FF997CFDFF8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-140]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0B4],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L69
       test      r8d,r8d
       jne       short M01_L70
       xor       edx,edx
       mov       [rax+14],edx
M01_L68:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B4]
       inc       ecx
       mov       rax,[rbp-140]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0B0],1
M01_L69:
       mov       rcx,rax
       call      qword ptr [7FF9977E6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0B0],0
       je        short M01_L71
       jmp       short M01_L74
M01_L70:
       jmp       short M01_L68
M01_L71:
       mov       eax,[rbp-0A0]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M01_L72
       xor       ecx,ecx
M01_L72:
       mov       edx,[rbp-0A4]
       inc       edx
       mov       eax,ecx
M01_L73:
       mov       [rbp-0A4],edx
       cmp       [r13+8],edx
       jg        near ptr M01_L67
       jmp       short M01_L75
M01_L74:
       mov       r13d,1
       jmp       short M01_L76
M01_L75:
       xor       r13d,r13d
M01_L76:
       jmp       near ptr M01_L45
M01_L77:
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L46
       mov       rcx,rsi
       call      qword ptr [7FF997C0D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-98],eax
       mov       edx,[rsi+8]
       mov       [rbp-9C],edx
       mov       rcx,rbx
       call      qword ptr [7FF997C0D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-98]
       mov       r9d,[rbp-9C]
       mov       edx,3
       call      qword ptr [7FF997ECE4C0]
       test      r13d,r15d
       jne       near ptr M01_L46
       mov       rcx,rsi
       call      qword ptr [7FF997C0D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF997C0D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L78
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L79
M01_L78:
       mov       ecx,edi
       xor       edx,edx
M01_L79:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF997ECE670]
       jmp       near ptr M01_L46
M01_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-108]
       mov       [rsi+8],rcx
       mov       r8,[rbp-0F8]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       ret
; Total bytes of code 3142
```
```assembly
; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,1E25C4751946
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M02_L07
       mov       rax,2267C400100
       mov       r15,[rax]
M02_L00:
       test      [rsp],esp
       sub       rsp,80
       lea       rcx,[rsp+20]
       mov       [rbp+38],rbx
       mov       [rbp+80],edi
       mov       [rbp+40],r15
       xor       eax,eax
       mov       [rbp+6C],eax
       mov       byte ptr [rbp+84],0
       mov       [rbp+48],rsi
       mov       [rbp+7C],r14d
       mov       rdi,[rbp+100]
       mov       [rbp+50],rdi
       mov       [rbp+88],rax
       mov       [rbp+90],eax
       mov       [rbp+98],rcx
       mov       dword ptr [rbp+0A0],20
       mov       [rbp+10],rax
       mov       [rbp+18],rax
       mov       [rbp+20],rax
       mov       [rbp+28],rax
       mov       [rbp+30],rax
       mov       [rbp+68],eax
       mov       [rbp+70],eax
       mov       [rbp+74],eax
       mov       [rbp+78],eax
       mov       [rbp+58],rax
       mov       [rbp+60],rax
       mov       byte ptr [rbp+85],0
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r9d,[rbp+80]
       mov       byte ptr [rax+2E],19
       mov       [rax+28],r9d
       mov       [rbp+28],rax
M02_L01:
       mov       r9d,[rbp+68]
       mov       rcx,[rbp+38]
       cmp       r9d,[rcx+8]
       jl        short M02_L02
       mov       rdi,[rbp+28]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF997E0FC00]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M02_L04
M02_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FF997C07348]; System.String.IndexOf(Char, Int32, Int32)
       mov       [rbp+68],eax
       cmp       dword ptr [rbp+68],0
       jge       short M02_L03
       mov       r8,[rbp+38]
       mov       r8d,[r8+8]
       mov       [rbp+68],r8d
M02_L03:
       mov       r8d,[rbp+68]
       sub       r8d,edi
       lea       rcx,[rbp+10]
       mov       edx,edi
       mov       r9d,1
       call      qword ptr [7FF998015590]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M02_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FF9980155A8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9980155C0]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M02_L01
M02_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M02_L08
M02_L05:
       mov       rax,r14
       mov       r8,1E25C4751946
       cmp       [rbp+8],r8
       je        short M02_L06
       call      CORINFO_HELP_FAIL_FAST
M02_L06:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       call      qword ptr [7FF997A06670]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M02_L00
M02_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,2267C401D28
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DF3ED8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M02_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M02_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,2267C401D28
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DF3ED8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M02_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 632
```
```assembly
; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       movzx     edi,r8b
       test      edi,edi
       setne     bpl
       movzx     ebp,bpl
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993528]
       test      rax,rax
       je        short M03_L04
M03_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M03_L02
       mov       rcx,rbx
       call      qword ptr [7FF9EF9860A0]
       test      rax,rax
       jne       short M03_L06
       call      qword ptr [7FF9EF9783F0]
       cmp       qword ptr [rax+8],0
       jne       short M03_L05
       xor       edi,edi
M03_L01:
       test      edi,edi
       jne       short M03_L06
M03_L02:
       xor       eax,eax
M03_L03:
       test      rax,rax
       jne       short M03_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993530]
       jmp       short M03_L00
M03_L05:
       call      qword ptr [7FF9EF9783F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FF9EF989690]
       jmp       short M03_L03
M03_L07:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 183
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M04_L01
       cmp       rcx,rdx
       je        near ptr M04_L11
       cmp       r8,20
       jae       near ptr M04_L05
       cmp       r8,10
       jae       near ptr M04_L08
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M04_L00:
       vzeroupper
       ret
M04_L01:
       cmp       r8,4
       jae       short M04_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M04_L02
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M04_L02:
       test      r8b,1
       je        short M04_L03
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M04_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M04_L00
M04_L04:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M04_L00
M04_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M04_L07
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M04_L12
M04_L06:
       add       rax,20
       cmp       r8,rax
       jbe       short M04_L07
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M04_L12
       jmp       short M04_L06
M04_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M04_L12
       jmp       short M04_L11
M04_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M04_L10
M04_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M04_L12
       add       rax,10
       cmp       r8,rax
       ja        short M04_L09
M04_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M04_L12
M04_L11:
       mov       eax,1
       vzeroupper
       ret
M04_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 315
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveSpecialChar()
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
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,2349AC000D0
       mov       rsi,[rcx]
       mov       edi,0D
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       rbp,[rsi+38]
       test      rbp,rbp
       je        near ptr M00_L13
M00_L00:
       mov       r14,[rsi+18]
       mov       r15d,[rsi+44]
       mov       r13,[rsi+20]
       mov       r12d,[rsi+40]
       mov       rcx,[rbp+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        short M00_L03
       test      cl,2
       jne       short M00_L01
       mov       rax,[rcx]
       jmp       short M00_L04
M00_L01:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       rax,[rdx]
       test      rax,rax
       jne       short M00_L02
       mov       rdx,7FF997EE6710
       call      qword ptr [7FF997816E08]
M00_L02:
       jmp       short M00_L04
M00_L03:
       xor       eax,eax
M00_L04:
       test      rax,rax
       je        short M00_L06
       mov       [rsp+28],rax
       mov       r8,[rax+18]
       cmp       [r8],r8b
       mov       rdx,27519AB0008
       cmp       r8,rdx
       jne       short M00_L05
       mov       r14,[rsp+28]
       jmp       near ptr M00_L10
M00_L05:
       cmp       dword ptr [r8+8],0
       jne       short M00_L06
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       mov       rdx,27519AB0014
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L06
       mov       r14,[rsp+28]
       jmp       short M00_L10
M00_L06:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,27519AB0008
       call      qword ptr [7FF997E37648]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L15
       test      r14,r14
       je        short M00_L07
       cmp       qword ptr [7FF99775B020],0
       jne       near ptr M00_L16
M00_L07:
       xor       eax,eax
M00_L08:
       test      r15b,2
       jne       near ptr M00_L17
       test      rax,rax
       jne       near ptr M00_L17
       mov       rcx,r15
       mov       rdx,r14
       call      00007FF9F7424440
M00_L09:
       nop
M00_L10:
       cmp       [r14],r14b
       mov       rbp,27519AC06C0
       mov       ecx,0D
       cmp       ecx,edi
       jb        near ptr M00_L18
       test      byte ptr [rsi+40],40
       jne       near ptr M00_L20
       cmp       byte ptr [r14+20],0
       jne       near ptr M00_L20
       mov       rcx,[r14+10]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L19
       mov       r8,27519AB0008
M00_L11:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997E37810]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L12:
       mov       [rsp+30],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L13:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF997816D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L14
       call      qword ptr [7FF997ED4A80]
       int       3
M00_L14:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF9F7419D60
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L15:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED5230]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997B95F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rax,[7FF99775B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L07
       mov       rcx,r14
       call      qword ptr [7FF997ED5248]
       jmp       near ptr M00_L08
M00_L17:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF997ED5260]
       jmp       near ptr M00_L09
M00_L18:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED4AC8]
       int       3
M00_L19:
       mov       r8,[r14+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L21
       mov       r8,[r8+10]
       jmp       near ptr M00_L11
M00_L20:
       mov       [rsp+20],edi
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997ED4AE0]
       jmp       near ptr M00_L12
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 719
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L06
       cmp       rcx,rdx
       je        short M01_L04
       cmp       r8,10
       jae       short M01_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L05
M01_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M01_L05
M01_L04:
       mov       eax,1
       ret
M01_L05:
       xor       eax,eax
       ret
M01_L06:
       cmp       r8,4
       jb        short M01_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M01_L00
M01_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L08:
       test      r8b,1
       je        short M01_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L00
M01_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L05
       jmp       near ptr M01_L02
; Total bytes of code 237
```
```assembly
; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,63691FD9EDB2
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M02_L07
       mov       rax,23484C00100
       mov       r15,[rax]
M02_L00:
       test      [rsp],esp
       sub       rsp,80
       lea       rcx,[rsp+20]
       mov       [rbp+38],rbx
       mov       [rbp+80],edi
       mov       [rbp+40],r15
       xor       eax,eax
       mov       [rbp+6C],eax
       mov       byte ptr [rbp+84],0
       mov       [rbp+48],rsi
       mov       [rbp+7C],r14d
       mov       rdi,[rbp+100]
       mov       [rbp+50],rdi
       mov       [rbp+88],rax
       mov       [rbp+90],eax
       mov       [rbp+98],rcx
       mov       dword ptr [rbp+0A0],20
       mov       [rbp+10],rax
       mov       [rbp+18],rax
       mov       [rbp+20],rax
       mov       [rbp+28],rax
       mov       [rbp+30],rax
       mov       [rbp+68],eax
       mov       [rbp+70],eax
       mov       [rbp+74],eax
       mov       [rbp+78],eax
       mov       [rbp+58],rax
       mov       [rbp+60],rax
       mov       byte ptr [rbp+85],0
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r9d,[rbp+80]
       mov       byte ptr [rax+2E],19
       mov       [rax+28],r9d
       mov       [rbp+28],rax
M02_L01:
       mov       r9d,[rbp+68]
       mov       rcx,[rbp+38]
       cmp       r9d,[rcx+8]
       jl        short M02_L02
       mov       rdi,[rbp+28]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF997E376A8]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M02_L04
M02_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FF997C26AC0]; System.String.IndexOf(Char, Int32, Int32)
       mov       [rbp+68],eax
       cmp       dword ptr [rbp+68],0
       jge       short M02_L03
       mov       r8,[rbp+38]
       mov       r8d,[r8+8]
       mov       [rbp+68],r8d
M02_L03:
       mov       r8d,[rbp+68]
       sub       r8d,edi
       lea       rcx,[rbp+10]
       mov       edx,edi
       mov       r9d,1
       call      qword ptr [7FF997EDC960]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M02_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FF997EDC978]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF997EDC990]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M02_L01
M02_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M02_L08
M02_L05:
       mov       rax,r14
       mov       r8,63691FD9EDB2
       cmp       [rbp+8],r8
       je        short M02_L06
       call      CORINFO_HELP_FAIL_FAST
M02_L06:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       call      qword ptr [7FF997A35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M02_L00
M02_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,23484C01CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DBC1F0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M02_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M02_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,23484C01CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DBC1F0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M02_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 632
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L88
       mov       ecx,[rbx+8]
       mov       rax,rbx
M03_L01:
       mov       [rbp-70],rbx
       mov       [rbp+20],rdi
       mov       [rbp-68],rdi
       mov       rdx,27519AC0D98
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,2349AC00170
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M03_L89
M03_L02:
       mov       [rbp-110],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M03_L87
       xor       r13d,r13d
       xor       r12d,r12d
M03_L03:
       mov       [rbp-1A8],r13
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M03_L90
M03_L04:
       mov       [rbp-120],rdx
       mov       [rbp-118],rdx
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-118]
       call      qword ptr [7FF997E37AE0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
       jmp       near ptr M03_L16
M03_L05:
       mov       rcx,r9
       mov       r8,r10
       call      00007FF9F73FDC70
       cmp       dword ptr [7FF9F7753B10],0
       jne       near ptr M03_L57
M03_L06:
       mov       rax,[rbp-148]
       mov       rcx,[rax+20]
       mov       ecx,[rcx+8]
       add       [rax+58],ecx
       lea       rcx,[rax+20]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       mov       r9d,[rbp-0A0]
       mov       r11d,[rbp-9C]
M03_L07:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M03_L64
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       rax,[rax+28]
       mov       [rbp-178],rax
       mov       r8,[rax+48]
       mov       [rbp-180],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M03_L64
       cmp       qword ptr [r8+10],0
       je        near ptr M03_L58
M03_L08:
       mov       rax,[rbp-178]
       mov       r8,[rax+48]
       mov       [rbp-188],r8
       mov       rax,[rax+50]
       mov       [rbp-190],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L64
       mov       r10d,[rax+10]
       mov       [rbp-0A4],r10d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M03_L64
       mov       rdx,[r8+10]
       lea       ecx,[r10+r10]
       mov       [rbp-104],ecx
       lea       r13d,[rcx+2]
       cmp       [rdx+8],r13d
       jl        near ptr M03_L59
M03_L09:
       cmp       dword ptr [r8+8],0
       jbe       near ptr M03_L64
       mov       rdx,[r8+10]
       mov       r8,rdx
       mov       ecx,[rbp-104]
       cmp       ecx,[r8+8]
       jae       near ptr M03_L64
       mov       r13d,ecx
       mov       [r8+r13*4+10],r9d
       inc       ecx
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L64
       sub       r11d,r9d
       mov       [rdx+rcx*4+10],r11d
       mov       rax,[rbp-190]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L64
       inc       r10d
       mov       [rax+10],r10d
M03_L10:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L64
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M03_L29
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L64
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M03_L64
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L64
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M03_L11:
       mov       [rbp-140],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M03_L68
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M03_L65
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M03_L30
       cmp       eax,[rcx+8]
       jae       near ptr M03_L64
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M03_L12:
       mov       r8,[rbp-140]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M03_L31
       cmp       eax,[rcx+8]
       jae       near ptr M03_L64
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M03_L13:
       mov       r8,[rbp-140]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M03_L68
M03_L14:
       mov       ecx,[rsi+4C]
       mov       edx,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M03_L66
M03_L15:
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       rax,[rsi+20]
       mov       eax,[rax+8]
       mov       [rsi+58],eax
       mov       [rbp-88],edx
       mov       esi,ecx
       mov       r13,[rbp-1A8]
M03_L16:
       mov       rdx,[rbp-120]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-120]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M03_L32
       mov       rax,[rdx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],r12d
       mov       rcx,[rsi+50]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       jle       short M03_L18
M03_L17:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M03_L17
M03_L18:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M03_L19
       xor       eax,eax
       mov       [rcx+18],rax
M03_L19:
       mov       rsi,[rbp-120]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M03_L40
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M03_L20:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rdx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveSpecialCharRegex_15+RunnerFactory+Runner
       cmp       [rsi],rdx
       jne       near ptr M03_L62
       mov       rax,rsi
       mov       [rbp-148],rax
       mov       edx,r12d
       mov       ecx,[rax+4C]
       cmp       ecx,edx
       jae       near ptr M03_L28
       mov       r8d,ecx
       lea       r8,[r13+r8*2]
       sub       edx,ecx
       mov       r10,2349AC00100
       mov       r10,[r10]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M03_L34
       cmp       word ptr [r8],7F
       ja        near ptr M03_L34
       mov       [rbp-150],r8
       mov       [rbp-94],edx
       lea       r9,[r10+8]
       mov       [rbp-158],r8
       cmp       edx,10
       jg        near ptr M03_L43
       vmovups   xmm0,[r9]
       lea       r9d,[rdx-8]
       movsxd    r11,r9d
       lea       r9,[r8+r11*2]
       cmp       r8,r9
       ja        near ptr M03_L51
       mov       r11,r8
M03_L21:
       vmovups   xmm1,[r11]
       vpackuswb xmm1,xmm1,[r9]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9978B4B00]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9978B4B10]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M03_L50
       vpmovmskb r13d,xmm0
       tzcnt     r13d,r13d
       cmp       r13d,8
       jge       near ptr M03_L52
M03_L22:
       sub       r11,r8
       shr       r11,1
       add       r11d,r13d
M03_L23:
       mov       r9d,r11d
       cmp       r9d,edx
       jae       short M03_L24
       mov       r13d,r9d
       cmp       word ptr [r8+r13*2],7F
       ja        near ptr M03_L53
M03_L24:
       test      r11d,r11d
       jl        near ptr M03_L55
       add       ecx,r11d
       mov       [rax+4C],ecx
       mov       r8d,[rax+4C]
       lea       r10d,[r8+1]
       mov       [rax+4C],r10d
       mov       r9d,r8d
       mov       r11d,r10d
       cmp       r11d,r9d
       jl        near ptr M03_L56
M03_L25:
       cmp       dword ptr [rax+58],0
       jne       near ptr M03_L07
       mov       [rbp-0A0],r9d
       mov       [rbp-9C],r11d
       mov       r8,[rax+20]
       mov       [rbp-1B8],r8
       mov       edx,[r8+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-170],rax
       mov       rcx,[rbp-1B8]
       mov       rdx,rcx
       mov       r9d,[rcx+8]
       mov       r10d,[rcx+8]
       test      rdx,rdx
       je        short M03_L27
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       short M03_L27
       cmp       dword ptr [rcx+4],18
       jne       short M03_L27
       cmp       r10d,[rdx+8]
       ja        short M03_L27
       lea       r8d,[r9+r10]
       cmp       r8d,[rax+8]
       ja        short M03_L27
       movzx     r8d,word ptr [rcx]
       mov       r10d,r10d
       imul      r10,r8
       add       rdx,10
       mov       r9d,r9d
       imul      r8,r9
       lea       r9,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        short M03_L26
       mov       rax,[rbp-170]
       cmp       r10,4000
       jbe       near ptr M03_L05
       mov       rcx,r9
       mov       r8,r10
       call      qword ptr [7FF997ED4978]
       jmp       near ptr M03_L06
M03_L26:
       mov       rcx,r9
       mov       r8,r10
       call      qword ptr [7FF997815818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L06
M03_L27:
       mov       [rsp+20],r10d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdx
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF997ED4990]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L06
M03_L28:
       mov       [rax+4C],r12d
       jmp       near ptr M03_L10
M03_L29:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,2349AC00190
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M03_L11
M03_L30:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37E40]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M03_L12
M03_L31:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37E40]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M03_L13
M03_L32:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-1B0],rax
       test      rax,rax
       je        near ptr M03_L39
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-130],rdx
       mov       rax,rsi
       mov       r10,[rbp-1B0]
       mov       [rbp-138],r10
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-120]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF997E37C48]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-130]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-130]
M03_L33:
       mov       rsi,[rbp-120]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L19
M03_L34:
       add       r10,88
       mov       r11d,edx
       lea       rdx,[r8+r11*2]
       mov       [rbp-168],rdx
       mov       r11,r8
       mov       r13,[r10]
       mov       r10d,[r10+10]
       mov       [rbp-98],r10d
       cmp       r8,rdx
       je        near ptr M03_L54
M03_L35:
       movzx     edx,word ptr [r11]
       imul      r10d,edx
       mov       edi,[r13+8]
       imul      r10,rdi
       shr       r10,20
       movzx     r10d,word ptr [r13+r10*2+10]
       cmp       r10d,edx
       jne       short M03_L36
       add       r11,2
       mov       rdx,[rbp-168]
       cmp       r11,rdx
       mov       r10d,[rbp-98]
       jne       short M03_L35
       jmp       near ptr M03_L54
M03_L36:
       mov       rdx,r11
       sub       rdx,r8
       shr       rdx,1
M03_L37:
       mov       r11d,edx
       test      r11d,r11d
       jl        short M03_L38
       lea       r11d,[rdx+r9]
M03_L38:
       jmp       near ptr M03_L24
M03_L39:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-128],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-120]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-128]
       call      qword ptr [7FF997E37C48]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-128]
       jmp       near ptr M03_L33
       nop
M03_L40:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M03_L41
       mov       r8d,20
M03_L41:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M03_L42
       mov       dword ptr [rbp-8C],10
M03_L42:
       mov       [rbp-90],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-90]
       mov       [rsi+50],edx
       movsxd    rdx,dword ptr [rbp-8C]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-8C]
       mov       [rsi+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M03_L20
M03_L43:
       vmovups   ymm0,[r9]
       mov       r9d,[rbp-94]
       cmp       r9d,20
       jle       near ptr M03_L46
       add       r9d,0FFFFFFE0
       movsxd    r9,r9d
       mov       r11,[rbp-150]
       lea       r9,[r11+r9*2]
M03_L44:
       mov       r11,[rbp-158]
       vmovups   ymm1,[r11]
       vpackuswb ymm1,ymm1,[r11+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9978B4B20]
       vbroadcastsd ymm3,qword ptr [7FF9978B4B10]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M03_L45
       add       r11,40
       cmp       r11,r9
       mov       [rbp-158],r11
       jb        short M03_L44
       jmp       short M03_L46
M03_L45:
       sub       r11,r8
       shr       r11,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       add       r11d,r9d
       jmp       near ptr M03_L23
M03_L46:
       lea       r9d,[rdx-10]
       movsxd    r9,r9d
       lea       r9,[r8+r9*2]
       mov       r11,[rbp-158]
       cmp       r11,r9
       ja        short M03_L47
       jmp       short M03_L48
M03_L47:
       mov       r11,r9
M03_L48:
       vmovups   ymm1,[r11]
       vpackuswb ymm1,ymm1,[r9]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9978B4B20]
       vbroadcastsd ymm2,qword ptr [7FF9978B4B10]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        short M03_L50
       mov       [rbp-160],r11
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r11d,ymm0
       tzcnt     r11d,r11d
       cmp       r11d,10
       jl        short M03_L49
       add       r11d,0FFFFFFF0
       mov       [rbp-160],r9
M03_L49:
       mov       r9,[rbp-160]
       sub       r9,r8
       shr       r9,1
       add       r11d,r9d
       jmp       near ptr M03_L23
M03_L50:
       mov       r11d,0FFFFFFFF
       jmp       near ptr M03_L23
M03_L51:
       mov       r11,r9
       jmp       near ptr M03_L21
M03_L52:
       mov       r11,r9
       add       r13d,0FFFFFFF8
       jmp       near ptr M03_L22
M03_L53:
       mov       r11d,r9d
       lea       r8,[r8+r11*2]
       sub       edx,r9d
       jmp       near ptr M03_L34
M03_L54:
       mov       edx,0FFFFFFFF
       jmp       near ptr M03_L37
M03_L55:
       mov       r13,[rbp-1A8]
       jmp       near ptr M03_L28
M03_L56:
       mov       [rbp-9C],r8d
       mov       [rbp-0A0],r10d
       mov       r9d,[rbp-0A0]
       mov       r11d,[rbp-9C]
       jmp       near ptr M03_L25
M03_L57:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L06
M03_L58:
       mov       [rbp-0A0],r9d
       mov       [rbp-9C],r11d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-180]
       xor       edx,edx
       call      qword ptr [7FF9978157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r9d,[rbp-0A0]
       mov       r11d,[rbp-9C]
       jmp       near ptr M03_L08
M03_L59:
       mov       [rbp-0A0],r9d
       mov       [rbp-9C],r11d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M03_L64
       mov       r13,[r8+10]
       lea       edx,[r10*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       mov       r10d,[rbp-104]
       cmp       ecx,r10d
       jl        short M03_L60
       jmp       short M03_L61
M03_L60:
       cmp       ecx,[r13+8]
       jae       near ptr M03_L64
       mov       r8d,[r13+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       short M03_L64
       mov       [rax+rcx*4+10],r8d
       inc       ecx
       cmp       ecx,r10d
       jl        short M03_L63
M03_L61:
       mov       rcx,[rbp-188]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9978157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r8,[rbp-188]
       mov       r9d,[rbp-0A0]
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-9C]
       jmp       near ptr M03_L09
M03_L62:
       mov       [rbp-0D8],r13
       mov       [rbp-0D0],r12d
       lea       rdx,[rbp-0D8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L10
M03_L63:
       mov       r10d,[rbp-104]
       jmp       near ptr M03_L60
M03_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L65:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-140]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-140]
       je        short M03_L68
       jmp       near ptr M03_L14
M03_L66:
       mov       edx,r12d
       mov       eax,1
       mov       r8,[rbp-110]
       test      byte ptr [r8+40],40
       je        short M03_L67
       xor       edx,edx
       mov       eax,0FFFFFFFF
M03_L67:
       cmp       ecx,edx
       je        short M03_L68
       lea       edx,[rcx+rax]
       jmp       near ptr M03_L15
M03_L68:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-110]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       je        near ptr M03_L76
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M03_L85
       cmp       eax,[rcx+8]
       jae       near ptr M03_L115
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M03_L69:
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M03_L86
       cmp       eax,[rcx+8]
       jae       near ptr M03_L115
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M03_L70:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M03_L91
       cmp       [rax+8],ecx
       jb        near ptr M03_L92
       add       rax,10
M03_L71:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       mov       rdi,[rbp+20]
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M03_L73
M03_L72:
       cmp       edx,ecx
       jae       near ptr M03_L115
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M03_L72
M03_L73:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,2349AC00178
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M03_L93
M03_L74:
       test      rsi,rsi
       je        near ptr M03_L84
       test      r14d,r14d
       jle       near ptr M03_L82
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF9F7494CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rdx,[r15+0C]
       mov       [rbp-0E8],rdx
       mov       [rbp-0E0],r14d
       mov       [rbp-100],rbx
       mov       [rbp-0F8],rdi
       lea       rdx,[rbp-80]
       mov       [rbp-0F0],rdx
       lea       rdx,[rbp-0E8]
       lea       r8,[rbp-100]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M03_L75:
       mov       r14,r15
M03_L76:
       cmp       qword ptr [rbp-58],0
       je        near ptr M03_L81
       mov       rcx,23484C01CE8
       mov       rbx,[rcx]
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M03_L94
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L94
M03_L77:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M03_L95
M03_L78:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],edi
       jbe       short M03_L79
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M03_L96
       cmp       edi,[rax+8]
       jae       near ptr M03_L115
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-198],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-198]
       test      r12,r12
       jne       near ptr M03_L97
M03_L79:
       mov       rcx,23484C00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M03_L112
M03_L80:
       xor       eax,eax
       mov       [rbp-58],rax
M03_L81:
       mov       rax,r14
       vzeroupper
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L82:
       test      r14d,r14d
       je        short M03_L83
       mov       ecx,28
       call      qword ptr [7FF997A378D0]
       int       3
M03_L83:
       mov       r15,27519AB0008
       jmp       near ptr M03_L75
M03_L84:
       mov       ecx,1C
       call      qword ptr [7FF997A3C228]
       int       3
M03_L85:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37E40]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M03_L69
M03_L86:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37E40]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M03_L70
M03_L87:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M03_L03
M03_L88:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M03_L01
M03_L89:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,2349AC00168
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2349AC00170
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L02
M03_L90:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M03_L04
M03_L91:
       test      ecx,ecx
       jne       short M03_L92
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M03_L71
M03_L92:
       call      qword ptr [7FF997987198]
       int       3
M03_L93:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2349AC00168
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2349AC00178
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L74
M03_L94:
       mov       ecx,7
       call      qword ptr [7FF997ED4810]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L77
M03_L95:
       mov       rcx,rbx
       call      qword ptr [7FF997D96C58]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M03_L78
M03_L96:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF997ED4840]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF997B96010]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L97:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L115
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L98
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF997ED4858]
M03_L98:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF997815740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99775B17C],0
       je        short M03_L99
       call      qword ptr [7FF997ED4870]
       mov       edx,eax
       mov       [rbp-0B8],edx
       jmp       short M03_L101
M03_L99:
       mov       ecx,9
       call      qword ptr [7FF997ED4888]
       mov       eax,[rax+10]
       mov       [rbp-0BC],eax
       mov       ecx,9
       call      qword ptr [7FF997ED4888]
       mov       edx,[rbp-0BC]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M03_L100
       call      qword ptr [7FF997ED48A0]
       mov       edx,eax
       mov       [rbp-0B8],edx
       jmp       short M03_L101
M03_L100:
       sar       edx,10
       mov       [rbp-0B8],edx
M03_L101:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF997815740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0B8]
       xor       edx,edx
       div       dword ptr [7FF99775B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M03_L108
M03_L102:
       cmp       eax,[r13+8]
       jae       near ptr M03_L115
       mov       [rbp-0B0],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-1A0],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0C0],r10d
       mov       rcx,r8
       call      qword ptr [7FF997D1D458]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1A0]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0C4],r8d
       cmp       [rcx+8],r8d
       jbe       short M03_L104
       test      r8d,r8d
       jne       short M03_L105
       xor       edx,edx
       mov       [rax+14],edx
M03_L103:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0C4]
       inc       ecx
       mov       rax,[rbp-1A0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0C0],1
M03_L104:
       mov       rcx,rax
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0C0],0
       je        short M03_L106
       jmp       short M03_L109
M03_L105:
       jmp       short M03_L103
M03_L106:
       mov       eax,[rbp-0B0]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M03_L107
       xor       ecx,ecx
M03_L107:
       mov       edx,[rbp-0B4]
       inc       edx
       mov       eax,ecx
M03_L108:
       mov       [rbp-0B4],edx
       cmp       [r13+8],edx
       jg        near ptr M03_L102
       jmp       short M03_L110
M03_L109:
       mov       r13d,1
       jmp       short M03_L111
M03_L110:
       xor       r13d,r13d
M03_L111:
       jmp       near ptr M03_L79
M03_L112:
       cmp       dword ptr [rsi+8],0
       je        near ptr M03_L80
       mov       rcx,rsi
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A8],eax
       mov       edx,[rsi+8]
       mov       [rbp-0AC],edx
       mov       rcx,rbx
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-0A8]
       mov       r9d,[rbp-0AC]
       mov       edx,3
       call      qword ptr [7FF997ED48B8]
       test      r13d,r15d
       jne       near ptr M03_L80
       mov       rcx,rsi
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M03_L113
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M03_L114
M03_L113:
       mov       ecx,edi
       xor       edx,edx
M03_L114:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF997ED48D0]
       jmp       near ptr M03_L80
M03_L115:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-120]
       mov       [rsi+8],rcx
       mov       r8,[rbp-110]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 4670
```
```assembly
; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       movzx     edi,r8b
       test      edi,edi
       setne     bpl
       movzx     ebp,bpl
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993528]
       test      rax,rax
       je        short M04_L04
M04_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M04_L02
       mov       rcx,rbx
       call      qword ptr [7FF9EF9860A0]
       test      rax,rax
       jne       short M04_L06
       call      qword ptr [7FF9EF9783F0]
       cmp       qword ptr [rax+8],0
       jne       short M04_L05
       xor       edi,edi
M04_L01:
       test      edi,edi
       jne       short M04_L06
M04_L02:
       xor       eax,eax
M04_L03:
       test      rax,rax
       jne       short M04_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993530]
       jmp       short M04_L00
M04_L05:
       call      qword ptr [7FF9EF9783F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       call      qword ptr [7FF9EF989690]
       jmp       short M04_L03
M04_L07:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 183
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ReplaceCrLf()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rcx,232C68000D0
       mov       rsi,[rcx]
       mov       edi,0C
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       r14,273570D06C0
       mov       r15,[rsi+38]
       test      r15,r15
       je        near ptr M00_L56
M00_L00:
       mov       r13,[rsi+18]
       mov       r12d,[rsi+44]
       mov       rax,[rsi+20]
       mov       [rbp-0D0],rax
       mov       r8d,[rsi+40]
       mov       [rbp-3C],r8d
       mov       rcx,[r15+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        short M00_L03
       mov       r8d,[rbp-3C]
       test      cl,2
       jne       short M00_L01
       mov       r10,[rcx]
       jmp       short M00_L04
M00_L01:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       r10,[rdx]
       test      r10,r10
       jne       short M00_L02
       mov       rdx,7FF997ED8EB0
       call      qword ptr [7FF997806E08]
       mov       r10,rax
       mov       r8d,[rbp-3C]
M00_L02:
       jmp       short M00_L04
M00_L03:
       mov       r8d,[rbp-3C]
       xor       r10d,r10d
M00_L04:
       test      r10,r10
       je        short M00_L06
       mov       [rbp-0C8],r10
       mov       rdx,[r10+18]
       cmp       [rdx],dl
       mov       rcx,273570C0008
       cmp       rdx,rcx
       jne       short M00_L05
       mov       r13,[rbp-0C8]
       jmp       near ptr M00_L10
M00_L05:
       cmp       dword ptr [rdx+8],0
       jne       short M00_L06
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       mov       rdx,273570C0014
       call      qword ptr [7FF99780FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       mov       r8d,[rbp-3C]
       je        short M00_L06
       mov       r13,[rbp-0C8]
       jmp       short M00_L10
M00_L06:
       mov       rax,[rbp-0D0]
       mov       [rsp+20],rax
       mov       edx,r8d
       mov       r8,r13
       mov       r9d,r12d
       mov       rcx,273570C0008
       call      qword ptr [7FF997E27648]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r13,rax
       mov       r12,[r15+8]
       and       r12,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L58
       test      r13,r13
       je        short M00_L07
       cmp       qword ptr [7FF99774B020],0
       jne       near ptr M00_L59
M00_L07:
       xor       eax,eax
M00_L08:
       test      r12b,2
       jne       near ptr M00_L60
       test      rax,rax
       jne       near ptr M00_L60
       mov       rcx,r12
       mov       rdx,r13
       call      00007FF9F7424440
M00_L09:
       nop
M00_L10:
       cmp       [r13],r13b
       cmp       edi,0C
       ja        near ptr M00_L61
       mov       eax,[rsi+40]
       and       eax,40
       je        near ptr M00_L62
M00_L11:
       mov       [rbp-70],r13
       mov       rcx,273570D0DA8
       mov       [rbp-60],rcx
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       [rbp-50],r14
       mov       [rbp-48],ecx
       mov       dword ptr [rbp-44],0C
       mov       [rbp-68],ecx
       mov       dword ptr [rbp-64],0FFFFFFFF
       test      eax,eax
       je        near ptr M00_L54
       mov       dword ptr [rbp-68],0C
       mov       rcx,232C6800190
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L68
M00_L12:
       mov       r12d,2
       mov       ecx,1
       cmp       byte ptr [r13+20],0
       cmove     r12d,ecx
       mov       [rbp-0D8],rsi
       lea       r13,[r14+0C]
       lea       rcx,[rsi+30]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L69
M00_L13:
       mov       [rbp-0E0],rcx
       mov       [rcx+8],r14
       mov       rdx,[rsi+48]
       call      qword ptr [7FF997E27B58]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       r14d,edi
       mov       r8,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveCrLfRegex_13+RunnerFactory+Runner
       mov       rsi,[rbp-0E0]
       cmp       [rsi],r8
       jne       near ptr M00_L26
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],r8
       jne       near ptr M00_L26
M00_L14:
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],0C
       mov       [rsp+20],r12d
       lea       r8,[rbp-0B0]
       mov       rdx,[rbp-0D8]
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF997E27B70]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       [rsi+4C],r14d
       mov       rdi,rsi
M00_L15:
       mov       ecx,[rdi+4C]
       test      ecx,ecx
       jle       short M00_L17
       dec       ecx
       mov       eax,ecx
       cmp       eax,0C
       jae       short M00_L17
M00_L16:
       mov       edx,ecx
       movzx     r8d,word ptr [r13+rdx*2]
       cmp       r8d,0A
       sete      dl
       movzx     edx,dl
       cmp       r8d,0D
       sete      r8b
       movzx     r8d,r8b
       or        edx,r8d
       jne       near ptr M00_L21
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jb        short M00_L16
M00_L17:
       xor       edx,edx
       mov       [rdi+4C],edx
M00_L18:
       mov       r14,[rsi+28]
       mov       rax,[r14+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L50
       cmp       dword ptr [rax+10],0
       jle       near ptr M00_L25
       mov       edx,[rsi+4C]
       mov       rcx,r14
       mov       r9d,r12d
       xor       r8d,r8d
       call      qword ptr [7FF997E27DB0]; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
M00_L19:
       cmp       dword ptr [r14+30],0
       je        near ptr M00_L51
       mov       rcx,[r15+8]
       lea       rdx,[rbp-70]
       mov       r8,r14
       call      qword ptr [7FF997E27A80]; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       test      eax,eax
       je        near ptr M00_L51
       mov       edi,[rsi+4C]
       mov       r10d,edi
       cmp       dword ptr [r14+14],0
       je        near ptr M00_L35
M00_L20:
       mov       r8,[rsi+10]
       mov       r8d,[r8+8]
       mov       [rsi+50],r8d
       mov       r8,[rsi+18]
       mov       r8d,[r8+8]
       mov       [rsi+54],r8d
       mov       r8,[rsi+20]
       mov       r8d,[r8+8]
       mov       [rsi+58],r8d
       mov       r14d,r10d
       jmp       near ptr M00_L14
M00_L21:
       inc       ecx
       mov       [rdi+4C],ecx
       mov       r14d,ecx
       cmp       r14d,0C
       ja        near ptr M00_L49
       xor       edx,edx
       test      r14d,r14d
       jle       short M00_L23
M00_L22:
       mov       r8d,r14d
       sub       r8d,edx
       dec       r8d
       cmp       r8d,0C
       jae       near ptr M00_L50
       mov       eax,r8d
       movzx     eax,word ptr [r13+rax*2]
       cmp       eax,0A
       sete      r8b
       movzx     r8d,r8b
       cmp       eax,0D
       sete      al
       movzx     eax,al
       or        eax,r8d
       je        short M00_L23
       inc       edx
       cmp       r14d,edx
       jg        short M00_L22
M00_L23:
       test      edx,edx
       je        near ptr M00_L34
       mov       ecx,r14d
       sub       ecx,edx
       mov       [rdi+4C],ecx
       mov       eax,r14d
       mov       r9d,ecx
       cmp       r9d,eax
       mov       [rbp-88],eax
       mov       [rbp-84],r9d
       jge       short M00_L24
       mov       [rbp-84],r14d
       mov       [rbp-88],ecx
M00_L24:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF997E27D80]; System.Text.RegularExpressions.RegexRunner.Crawl(Int32)
       mov       r14d,[rbp-84]
       mov       eax,[rbp-88]
       mov       r9d,r14d
       sub       r9d,eax
       mov       rcx,[rdi+28]
       mov       r8d,eax
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27D98]; System.Text.RegularExpressions.Match.AddMatch(Int32, Int32, Int32)
       jmp       near ptr M00_L18
M00_L25:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       rcx,232C68001B0
       mov       r14,[rcx]
       jmp       near ptr M00_L19
M00_L26:
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],0C
       mov       [rsp+20],r12d
       lea       r8,[rbp-0B0]
       mov       rdx,[rbp-0D8]
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF997E27B70]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       [rsi+4C],r14d
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveCrLfRegex_13+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M00_L37
       mov       rdi,rsi
M00_L27:
       mov       eax,[rdi+4C]
       test      eax,eax
       jle       short M00_L29
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jae       short M00_L29
M00_L28:
       cmp       ecx,0C
       jae       near ptr M00_L50
       mov       edx,ecx
       movzx     r8d,word ptr [r13+rdx*2]
       cmp       r8d,0A
       sete      dl
       movzx     edx,dl
       cmp       r8d,0D
       sete      r8b
       movzx     r8d,r8b
       or        edx,r8d
       jne       near ptr M00_L38
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jb        short M00_L28
M00_L29:
       xor       edx,edx
       mov       [rdi+4C],edx
M00_L30:
       mov       r14,[rsi+28]
       mov       rax,[r14+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L50
       cmp       dword ptr [rax+10],0
       jle       near ptr M00_L42
       jmp       near ptr M00_L43
M00_L31:
       mov       r8d,r14d
       sub       r8d,edx
       dec       r8d
       cmp       r8d,0C
       jae       near ptr M00_L50
       mov       eax,r8d
       movzx     eax,word ptr [r13+rax*2]
       cmp       eax,0A
       sete      r8b
       movzx     r8d,r8b
       cmp       eax,0D
       sete      al
       movzx     eax,al
       or        eax,r8d
       je        near ptr M00_L39
       inc       edx
       cmp       r14d,edx
       jle       near ptr M00_L39
       jmp       short M00_L31
M00_L32:
       cmp       dword ptr [r14+30],0
       je        near ptr M00_L51
       jmp       near ptr M00_L44
M00_L33:
       dec       ecx
       mov       [rdi+4C],ecx
       jmp       near ptr M00_L15
M00_L34:
       cmp       dword ptr [rdi+4C],0
       jne       short M00_L33
       jmp       near ptr M00_L18
M00_L35:
       mov       r11d,0C
       mov       r10d,1
       mov       rdx,[rbp-0D8]
       test      byte ptr [rdx+40],40
       je        short M00_L36
       xor       r11d,r11d
       mov       r10d,0FFFFFFFF
M00_L36:
       cmp       edi,r11d
       je        near ptr M00_L51
       add       r10d,edi
       mov       r14d,r10d
       mov       r10d,r14d
       jmp       near ptr M00_L20
M00_L37:
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],0C
       lea       rdx,[rbp-0B0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L30
M00_L38:
       inc       ecx
       mov       [rdi+4C],ecx
       mov       r14d,ecx
       cmp       r14d,0C
       ja        near ptr M00_L49
       xor       edx,edx
       test      r14d,r14d
       jg        near ptr M00_L31
M00_L39:
       test      edx,edx
       je        short M00_L41
       mov       ecx,r14d
       sub       ecx,edx
       mov       [rdi+4C],ecx
       mov       eax,r14d
       mov       r8d,ecx
       cmp       r8d,eax
       mov       [rbp-88],eax
       mov       [rbp-84],r8d
       jge       short M00_L40
       mov       [rbp-84],r14d
       mov       [rbp-88],ecx
M00_L40:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF997E27D80]; System.Text.RegularExpressions.RegexRunner.Crawl(Int32)
       mov       r14d,[rbp-84]
       mov       r8d,[rbp-88]
       mov       r9d,r14d
       sub       r9d,r8d
       mov       rcx,[rdi+28]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27D98]; System.Text.RegularExpressions.Match.AddMatch(Int32, Int32, Int32)
       jmp       near ptr M00_L30
M00_L41:
       cmp       dword ptr [rdi+4C],0
       je        near ptr M00_L30
       dec       ecx
       mov       [rdi+4C],ecx
       jmp       near ptr M00_L27
M00_L42:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       rcx,232C68001B0
       mov       r14,[rcx]
       jmp       near ptr M00_L32
M00_L43:
       mov       edx,[rsi+4C]
       mov       rcx,r14
       mov       r9d,r12d
       xor       r8d,r8d
       call      qword ptr [7FF997E27DB0]; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       jmp       near ptr M00_L32
M00_L44:
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       je        short M00_L45
       lea       rdx,[rbp-70]
       mov       r8,r14
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       short M00_L46
M00_L45:
       mov       rcx,[r15+8]
       lea       rdx,[rbp-70]
       mov       r8,r14
       call      qword ptr [7FF997E27A80]; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
M00_L46:
       test      eax,eax
       je        short M00_L51
       mov       edi,[rsi+4C]
       mov       eax,edi
       cmp       dword ptr [r14+14],0
       jne       short M00_L48
       mov       r11d,0C
       mov       r10d,1
       mov       rdx,[rbp-0D8]
       test      byte ptr [rdx+40],40
       je        short M00_L47
       xor       r11d,r11d
       mov       r10d,0FFFFFFFF
M00_L47:
       cmp       edi,r11d
       je        short M00_L51
       lea       eax,[rdi+r10]
M00_L48:
       mov       rcx,[rsi+10]
       mov       ecx,[rcx+8]
       mov       [rsi+50],ecx
       mov       rcx,[rsi+18]
       mov       ecx,[rcx+8]
       mov       [rsi+54],ecx
       mov       rcx,[rsi+20]
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
       mov       r14d,eax
       jmp       near ptr M00_L26
M00_L49:
       call      qword ptr [7FF997977198]
       int       3
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rdx,[rbp-0D8]
       lea       rcx,[rdx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-58],0
       je        near ptr M00_L70
       mov       r9d,[rbp-68]
       cmp       r9d,[rbp-44]
       ja        near ptr M00_L71
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       lea       rcx,[rbp-98]
       mov       rdx,[rbp-50]
       mov       r8d,[rbp-48]
       call      qword ptr [7FF997EC5698]; System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]]..ctor(System.Object, Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-98]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FF997E27DE0]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ReadOnlyMemory`1<Char>)
       lea       rcx,[rbp-60]
       lea       rdx,[rbp-80]
       call      qword ptr [7FF997E27F90]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].AsSpan()
       lea       rcx,[rbp-80]
       call      qword ptr [7FF997E27FD8]; System.MemoryExtensions.Reverse[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]](System.Span`1<System.ReadOnlyMemory`1<Char>>)
M00_L52:
       lea       rcx,[rbp-60]
       call      qword ptr [7FF997E2C1F8]; System.Text.RegularExpressions.Regex.SegmentsToStringAndDispose(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef)
M00_L53:
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-0A0]
       mov       rdx,7FF997E755F8
       cmp       [rcx],ecx
       call      qword ptr [7FF997E2C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L54:
       mov       rcx,232C6800188
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L65
M00_L55:
       mov       r9d,2
       mov       ecx,1
       cmp       byte ptr [r13+20],0
       cmove     r9d,ecx
       lea       rcx,[r14+0C]
       mov       [rbp-0B0],rcx
       mov       dword ptr [rbp-0A8],0C
       mov       [rsp+20],edi
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       [rsp+30],rax
       mov       [rsp+38],r9d
       mov       dword ptr [rsp+40],1
       lea       r9,[rbp-0B0]
       mov       rcx,rsi
       mov       rdx,7FF997E71CB8
       mov       r8,r14
       call      qword ptr [7FF997E27A98]; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, System.ReadOnlySpan`1<Char>, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       mov       esi,[rbp-58]
       test      esi,esi
       je        near ptr M00_L70
       mov       edx,[rbp-68]
       mov       edi,[rbp-44]
       cmp       edx,edi
       ja        near ptr M00_L71
       mov       rax,[rbp-50]
       mov       r14d,edx
       add       r14d,[rbp-48]
       sub       edi,edx
       mov       r15,[rbp-60]
       mov       edx,[r15+8]
       cmp       edx,esi
       jbe       near ptr M00_L67
       jmp       near ptr M00_L66
M00_L56:
       lea       r15,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF997806D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      r15,r15
       jne       short M00_L57
       call      qword ptr [7FF997EC4F18]
       int       3
M00_L57:
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF9F7419D60
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L00
       mov       r15,[rsi+38]
       jmp       near ptr M00_L00
M00_L58:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997EC5650]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997B85F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L59:
       mov       rax,[7FF99774B020]
       mov       rcx,r13
       call      rax
       test      eax,eax
       je        near ptr M00_L07
       mov       rcx,r13
       call      qword ptr [7FF997EC5668]
       jmp       near ptr M00_L08
M00_L60:
       lea       rcx,[r15+8]
       mov       rdx,r13
       mov       r8,rax
       call      qword ptr [7FF997EC5680]
       jmp       near ptr M00_L09
M00_L61:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997EC4F60]
       int       3
M00_L62:
       cmp       byte ptr [r13+20],0
       jne       near ptr M00_L11
       mov       rcx,[r13+10]
       cmp       dword ptr [rcx+8],0
       jne       short M00_L63
       mov       r8,273570C0008
       jmp       short M00_L64
M00_L63:
       mov       r8,[r13+8]
       cmp       dword ptr [r8+8],0
       jbe       near ptr M00_L72
       mov       r8,[r8+10]
M00_L64:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997EC4F78]
       jmp       near ptr M00_L53
M00_L65:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,232C6800170
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,7FF997EC0FF0
       call      qword ptr [7FF997806BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,232C6800188
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
       jmp       near ptr M00_L55
M00_L66:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[r15+rcx+10]
       mov       rcx,r15
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+8],r14d
       mov       [r15+0C],edi
       inc       esi
       mov       [rbp-58],esi
       jmp       near ptr M00_L52
M00_L67:
       mov       [rbp-0C0],rax
       mov       [rbp-0B8],r14d
       mov       [rbp-0B4],edi
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FF997E27DF8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
       jmp       near ptr M00_L52
M00_L68:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,232C6800170
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF997806BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,232C6800190
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L12
M00_L69:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M00_L13
M00_L70:
       mov       rax,273570D06C0
       jmp       near ptr M00_L53
M00_L71:
       mov       ecx,21
       call      qword ptr [7FF997A278D0]
       int       3
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       xor       ecx,ecx
       mov       rsi,[rbp-0E0]
       mov       [rsi+8],rcx
       mov       rdx,[rbp-0D8]
       lea       rcx,[rdx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       ret
; Total bytes of code 2867
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L06
       cmp       rcx,rdx
       je        short M01_L04
       cmp       r8,10
       jae       short M01_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L00:
       ret
M01_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L05
M01_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M01_L10
M01_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M01_L05
M01_L04:
       mov       eax,1
       ret
M01_L05:
       xor       eax,eax
       ret
M01_L06:
       cmp       r8,4
       jb        short M01_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M01_L00
M01_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L08:
       test      r8b,1
       je        short M01_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L00
M01_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M01_L05
       jmp       near ptr M01_L02
; Total bytes of code 237
```
```assembly
; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqu   ymmword ptr [rbp+90],ymm4
       mov       rax,613496B0654
       mov       [rbp],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       jne       near ptr M02_L03
       call      qword ptr [7FF997A25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
M02_L00:
       test      [rsp],esp
       sub       rsp,80
       lea       rcx,[rsp+40]
       mov       [rsp+20],rsi
       mov       [rsp+28],r14d
       mov       r14,[rbp+100]
       mov       [rsp+30],r14
       mov       [rbp+8],rcx
       mov       dword ptr [rbp+10],20
       lea       rcx,[rbp+8]
       mov       [rsp+38],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9,rax
       call      qword ptr [7FF997E27678]; System.Text.RegularExpressions.RegexParser..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Span`1<Int32>)
       nop
       lea       rcx,[rbp+18]
       call      qword ptr [7FF997E27690]; System.Text.RegularExpressions.RegexParser.ScanReplacement()
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF997E276A8]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       nop
       mov       rcx,7FF997FCE40C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       jne       short M02_L04
M02_L01:
       mov       rcx,7FF997FCE410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
       mov       r8,613496B0654
       cmp       [rbp],r8
       je        short M02_L02
       call      CORINFO_HELP_FAIL_FAST
M02_L02:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L03:
       mov       rcx,7FF997FCE408
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,232C2000100
       mov       rax,[rcx]
       jmp       near ptr M02_L00
M02_L04:
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,232C2001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DAC1F0]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M02_L01
       sub       rsp,48
       mov       rcx,7FF997FCE40C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       je        short M02_L05
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,232C2001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DAC1F0]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M02_L05:
       nop
       add       rsp,48
       ret
; Total bytes of code 441
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF997EC5008]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       cmp       [rbx],bl
       lea       rdi,[rbx+10]
       lea       rdx,[rbx+20]
       mov       ecx,[rsi+10]
       mov       eax,[rsi+14]
       lea       ebp,[rcx+rax]
       mov       r14d,[rbx+8]
       sub       r14d,ecx
       sub       r14d,eax
       mov       ecx,ebp
       mov       eax,r14d
       add       rcx,rax
       mov       eax,[rdx+0C]
       cmp       rcx,rax
       ja        near ptr M04_L02
       mov       rax,[rdx]
       add       ebp,[rdx+8]
       mov       r15,[rdi]
       mov       r13d,[rdi+8]
       cmp       [r15+8],r13d
       ja        short M04_L01
       mov       [rsp+20],rax
       mov       [rsp+28],ebp
       mov       [rsp+2C],r14d
       lea       rdx,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FF997E27DF8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M04_L00:
       mov       ecx,[rsi+10]
       mov       [rbx+8],ecx
       mov       rcx,[rbx]
       lea       rdx,[rbx+10]
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27F30]; System.Text.RegularExpressions.RegexReplacement.ReplacementImplRTL(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef, System.Text.RegularExpressions.Match)
       add       rbx,0C
       mov       eax,[rbx]
       dec       eax
       mov       [rbx],eax
       test      eax,eax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       mov       ecx,r13d
       shl       rcx,4
       lea       r15,[r15+rcx+10]
       mov       rcx,r15
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+8],ebp
       mov       [r15+0C],r14d
       inc       r13d
       mov       [rdi+8],r13d
       jmp       short M04_L00
M04_L02:
       mov       ecx,21
       call      qword ptr [7FF997A278D0]
       int       3
; Total bytes of code 232
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,r9d
       mov       edi,[r8+8]
       mov       ecx,[rsp+80]
       mov       [rbx+60],ecx
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+48],esi
       xor       ecx,ecx
       mov       [rbx+40],ecx
       mov       [rbx+44],edi
       mov       [rbx+4C],esi
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M05_L04
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],edi
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M05_L01
       add       rcx,10
M05_L00:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M05_L00
M05_L01:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M05_L02
       xor       eax,eax
       mov       [rcx+18],rax
M05_L02:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M05_L07
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M05_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       mov       rsi,[rbx+30]
       mov       rbp,[rsi+18]
       test      rbp,rbp
       je        short M05_L05
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FF997E27CC0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[r14+68]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L06
M05_L05:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FF997E27CC0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M05_L06:
       lea       rcx,[rbx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L02
M05_L07:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,[rbx+5C]
       shl       esi,3
       mov       edi,esi
       mov       edx,20
       cmp       esi,20
       cmovl     edi,edx
       mov       edx,10
       cmp       esi,10
       cmovl     esi,edx
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+50],edi
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+54],esi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+58],20
       jmp       near ptr M05_L03
; Total bytes of code 460
```
```assembly
; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ebx,r8d
       mov       rsi,[rcx+50]
       cmp       dword ptr [rsi+8],0
       jbe       near ptr M06_L08
       mov       eax,[rsi+10]
       mov       [rcx+30],eax
       mov       [rcx+34],ebx
       add       edx,ebx
       mov       [rcx+58],edx
       add       [rcx+5C],ebx
       mov       rdi,[rcx+48]
       cmp       dword ptr [rdi+8],0
       jbe       short M06_L08
       mov       rax,[rdi+10]
       mov       edx,[rax+8]
       cmp       edx,1
       jbe       short M06_L08
       mov       edx,[rax+14]
       mov       [rcx+14],edx
       mov       edx,ebx
       add       edx,[rax+10]
       mov       [rcx+10],edx
       cmp       r9d,2
       je        short M06_L01
M06_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L01:
       cmp       byte ptr [rcx+60],0
       je        short M06_L02
       call      qword ptr [7FF997EC5050]
M06_L02:
       test      ebx,ebx
       je        short M06_L00
       xor       eax,eax
       jmp       short M06_L07
M06_L03:
       mov       rcx,[rdi+rax*8+10]
       test      rcx,rcx
       je        short M06_L06
       cmp       eax,[rsi+8]
       jae       short M06_L08
       mov       edx,[rsi+rax*4+10]
       add       edx,edx
       xor       r8d,r8d
       jmp       short M06_L05
M06_L04:
       cmp       r8d,[rcx+8]
       jae       short M06_L08
       lea       r10,[rcx+r8*4+10]
       add       [r10],ebx
       add       r8d,2
M06_L05:
       cmp       r8d,edx
       jl        short M06_L04
M06_L06:
       inc       eax
M06_L07:
       cmp       [rdi+8],eax
       jg        short M06_L03
       jmp       short M06_L00
M06_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 175
```
```assembly
; System.Text.RegularExpressions.RegexRunner.Crawl(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       dword ptr [rbx+58],0
       je        short M07_L01
M07_L00:
       mov       rax,[rbx+20]
       mov       ecx,[rbx+58]
       dec       ecx
       mov       [rbx+58],ecx
       cmp       ecx,[rax+8]
       jae       short M07_L02
       mov       [rax+rcx*4+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       mov       rcx,rbx
       call      qword ptr [7FF997EC5038]
       jmp       short M07_L00
M07_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Match.AddMatch(Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       ebp,r9d
       mov       r14,[rsi+48]
       cmp       ebx,[r14+8]
       jae       near ptr M08_L06
       mov       r15d,ebx
       cmp       qword ptr [r14+r15*8+10],0
       je        near ptr M08_L02
M08_L00:
       mov       r14,[rsi+48]
       mov       rsi,[rsi+50]
       mov       edx,[rsi+8]
       cmp       ebx,edx
       jae       near ptr M08_L06
       mov       r13d,[rsi+r15*4+10]
       mov       edx,[r14+8]
       cmp       ebx,edx
       jae       near ptr M08_L06
       mov       rdx,[r14+r15*8+10]
       lea       r12d,[r13+r13]
       lea       ecx,[r12+2]
       cmp       [rdx+8],ecx
       jl        short M08_L03
M08_L01:
       mov       rax,[r14+r15*8+10]
       mov       rcx,rax
       mov       edx,[rcx+8]
       cmp       r12d,edx
       jae       near ptr M08_L06
       mov       r8d,r12d
       mov       [rcx+r8*4+10],edi
       inc       r12d
       cmp       r12d,edx
       jae       near ptr M08_L06
       mov       ecx,r12d
       mov       [rax+rcx*4+10],ebp
       inc       r13d
       mov       [rsi+r15*4+10],r13d
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
M08_L02:
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       edx,ebx
       mov       rcx,r14
       call      qword ptr [7FF9978057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M08_L00
M08_L03:
       mov       rax,[r14+r15*8+10]
       mov       [rsp+20],rax
       lea       edx,[r13*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       edx,edx
       cmp       edx,r12d
       jge       short M08_L05
M08_L04:
       mov       rcx,[rsp+20]
       cmp       edx,[rcx+8]
       jae       short M08_L06
       mov       r8d,[rcx+rdx*4+10]
       cmp       edx,[rax+8]
       jae       short M08_L06
       mov       [rax+rdx*4+10],r8d
       inc       edx
       cmp       edx,r12d
       jl        short M08_L04
M08_L05:
       mov       edx,ebx
       mov       rcx,r14
       mov       r8,rax
       call      qword ptr [7FF9978057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M08_L01
M08_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]]..ctor(System.Object, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       esi,r8d
       mov       edi,r9d
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       [rbx+0C],edi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 30
```
```assembly
; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ReadOnlyMemory`1<Char>)
       push      rdi
       push      rsi
       push      rbx
       mov       r8,rcx
       mov       rsi,[r8]
       mov       ebx,[r8+8]
       mov       ecx,[rsi+8]
       cmp       ecx,ebx
       ja        short M10_L00
       mov       rcx,r8
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF997E27DF8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M10_L00:
       mov       eax,ebx
       shl       rax,4
       lea       rdi,[rsi+rax+10]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       inc       ebx
       mov       [r8+8],ebx
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 63
```
```assembly
; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].AsSpan()
       sub       rsp,28
       mov       rax,rdx
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       test      rdx,rdx
       je        short M11_L01
       cmp       [rdx+8],ecx
       jb        short M11_L02
       add       rdx,10
M11_L00:
       mov       [rax],rdx
       mov       [rax+8],ecx
       add       rsp,28
       ret
M11_L01:
       test      ecx,ecx
       jne       short M11_L02
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M11_L00
M11_L02:
       call      qword ptr [7FF997977198]
       int       3
; Total bytes of code 55
```
```assembly
; System.MemoryExtensions.Reverse[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]](System.Span`1<System.ReadOnlyMemory`1<Char>>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rbx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M12_L01
       mov       eax,eax
       shl       rax,4
       lea       rbp,[rbx+rax-10]
M12_L00:
       mov       rdx,[rbx]
       mov       r14d,[rbx+8]
       mov       r15d,[rbx+0C]
       mov       rdi,rbx
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbp+8],r14d
       mov       [rbp+0C],r15d
       add       rbx,10
       add       rbp,0FFFFFFFFFFFFFFF0
       cmp       rbx,rbp
       jb        short M12_L00
M12_L01:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 92
```
```assembly
; System.Text.RegularExpressions.Regex.SegmentsToStringAndDispose(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       edi,[rbx+8]
       test      rsi,rsi
       je        near ptr M13_L15
       cmp       [rsi+8],edi
       jb        near ptr M13_L22
       add       rsi,10
M13_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M13_L02
       xor       ecx,ecx
       mov       eax,edi
M13_L01:
       add       ebp,[rsi+rcx+0C]
       add       rcx,10
       dec       eax
       jne       short M13_L01
M13_L02:
       mov       rcx,232C68001E0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M13_L16
M13_L03:
       test      ebp,ebp
       jle       near ptr M13_L17
       mov       edx,ebp
       mov       r15,offset MT_System.String
       mov       rcx,r15
       call      00007FF9F7494CA0
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rdx,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       cmp       [r14+18],rdx
       jne       near ptr M13_L23
       xor       r14d,r14d
       cmp       r14d,edi
       jge       near ptr M13_L08
M13_L04:
       mov       rax,r14
       shl       rax,4
       add       rax,rsi
       mov       [rsp+40],rax
       xor       edx,edx
       xor       r8d,r8d
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M13_L07
       cmp       [rcx],r15
       jne       near ptr M13_L19
       lea       rdx,[rcx+0C]
M13_L05:
       mov       r8d,[rcx+8]
M13_L06:
       mov       rax,[rsp+40]
       mov       ecx,[rax+8]
       and       ecx,7FFFFFFF
       mov       eax,[rax+0C]
       mov       r10d,eax
       add       r10,rcx
       mov       r8d,r8d
       cmp       r10,r8
       ja        near ptr M13_L22
       lea       rdx,[rdx+rcx*2]
       mov       r8d,eax
M13_L07:
       cmp       r8d,ebp
       ja        near ptr M13_L21
       mov       [rsp+0A4],r8d
       mov       eax,r8d
       add       rax,rax
       mov       [rsp+48],rax
       mov       r8,rax
       mov       rcx,r12
       call      qword ptr [7FF997805818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+0A4]
       mov       rax,[rsp+48]
       add       r12,rax
       sub       ebp,r8d
       inc       r14d
       cmp       r14d,edi
       jl        near ptr M13_L04
M13_L08:
       cmp       qword ptr [rbx],0
       je        near ptr M13_L14
       mov       rcx,232C6800198
       mov       rsi,[rcx]
       mov       rdi,[rbx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M13_L24
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M13_L24
M13_L09:
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M13_L25
M13_L10:
       xor       r15d,r15d
       mov       r12d,1
       cmp       [r14+8],ebp
       jbe       short M13_L12
       mov       r15d,1
       mov       rdx,[rdi]
       movzx     ecx,word ptr [rdx]
       mov       eax,[rdi+8]
       imul      rax,rcx
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M13_L26
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FF997E2C2D0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M13_L11:
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       [rdi+8],ecx
       jne       near ptr M13_L27
       mov       ecx,ebp
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       mov       rax,[r14]
       mov       [rsp+38],rax
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],ecx
       mov       r14,[rsp+38]
       test      r14,r14
       jne       near ptr M13_L28
M13_L12:
       mov       rcx,232C2000C90
       mov       r14,[rcx]
       cmp       byte ptr [r14+9D],0
       jne       near ptr M13_L43
M13_L13:
       xor       eax,eax
       mov       [rbx],rax
M13_L14:
       mov       rax,r13
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L15:
       test      edi,edi
       jne       near ptr M13_L22
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M13_L00
M13_L16:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.Span<System.ReadOnlyMemory<System.Char>>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,232C68001B8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       call      qword ptr [7FF997806BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,232C68001E0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M13_L03
M13_L17:
       test      ebp,ebp
       jne       short M13_L18
       mov       r13,273570C0008
       jmp       near ptr M13_L08
M13_L18:
       mov       ecx,28
       call      qword ptr [7FF997A278D0]
       int       3
M13_L19:
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M13_L20
       lea       rdx,[rcx+10]
       jmp       near ptr M13_L05
M13_L20:
       lea       rdx,[rsp+90]
       mov       r8,[rcx]
       mov       r8,[r8+40]
       call      qword ptr [r8+28]
       mov       rdx,[rsp+90]
       mov       r8d,[rsp+98]
       mov       eax,r8d
       mov       r8d,eax
       jmp       near ptr M13_L06
M13_L21:
       call      qword ptr [7FF997C1C4B0]
       int       3
M13_L22:
       call      qword ptr [7FF997977198]
       int       3
M13_L23:
       mov       [rsp+60],r12
       mov       [rsp+68],ebp
       mov       [rsp+50],rsi
       mov       [rsp+58],edi
       lea       rdx,[rsp+60]
       lea       r8,[rsp+50]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M13_L08
M13_L24:
       mov       ecx,9
       call      qword ptr [7FF997EC4D38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M13_L09
M13_L25:
       mov       rcx,rsi
       call      qword ptr [7FF997E27EE8]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M13_L10
M13_L26:
       mov       rdx,rax
       call      qword ptr [7FF9978057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M13_L11
M13_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997EC4D50]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF997744000
       call      qword ptr [7FF997A27798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF997B86010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M13_L28:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M13_L46
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M13_L29
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FF997EC4D68]
M13_L29:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99774B17C],0
       je        short M13_L30
       call      qword ptr [7FF997EC4D80]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M13_L32
M13_L30:
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       mov       eax,[rax+10]
       mov       [rsp+78],eax
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       mov       edx,[rsp+78]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M13_L31
       call      qword ptr [7FF997EC4DB0]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M13_L32
M13_L31:
       sar       edx,10
       mov       [rsp+7C],edx
M13_L32:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+7C]
       xor       edx,edx
       div       dword ptr [7FF99774B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M13_L39
M13_L33:
       cmp       eax,[r12+8]
       jae       near ptr M13_L46
       mov       [rsp+84],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+74],r10d
       mov       rcx,r8
       call      qword ptr [7FF997D0D770]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+70],r8d
       cmp       [rcx+8],r8d
       jbe       short M13_L35
       test      r8d,r8d
       jne       short M13_L36
       xor       edx,edx
       mov       [rax+14],edx
M13_L34:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+70]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+74],1
M13_L35:
       mov       rcx,rax
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+74],0
       je        short M13_L37
       jmp       short M13_L40
M13_L36:
       jmp       short M13_L34
M13_L37:
       mov       eax,[rsp+84]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M13_L38
       xor       ecx,ecx
M13_L38:
       mov       edx,[rsp+80]
       inc       edx
       mov       eax,ecx
M13_L39:
       mov       [rsp+80],edx
       cmp       [r12+8],edx
       jg        near ptr M13_L33
       jmp       short M13_L41
M13_L40:
       mov       r12d,1
       jmp       short M13_L42
M13_L41:
       xor       r12d,r12d
M13_L42:
       jmp       near ptr M13_L12
M13_L43:
       cmp       dword ptr [rdi+8],0
       je        near ptr M13_L13
       mov       rcx,rdi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+8C],eax
       mov       edx,[rdi+8]
       mov       [rsp+88],edx
       mov       rcx,rsi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rsp+8C]
       mov       r9d,[rsp+88]
       mov       edx,3
       call      qword ptr [7FF997EC4DE0]
       test      r12d,r15d
       jne       near ptr M13_L13
       mov       rcx,rdi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M13_L44
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M13_L45
M13_L44:
       mov       ecx,ebp
       xor       edx,edx
M13_L45:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FF997EC4DF8]
       jmp       near ptr M13_L13
M13_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1563
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
; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, System.ReadOnlySpan`1<Char>, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       mov       [rbp+10],rcx
       mov       rdi,r8
       mov       esi,[rbp+30]
       mov       rbx,[rbp+38]
       mov       r14d,[rbp+48]
       mov       r15d,[rbp+50]
       mov       r12,[r9]
       mov       eax,[r9+8]
       mov       [rbp-5C],eax
       lea       rdx,[rcx+30]
       xor       r8d,r8d
       xchg      r8,[rdx]
       mov       rdx,r8
       test      rdx,rdx
       je        near ptr M15_L52
M15_L00:
       mov       [rbp-90],rdx
       mov       [rbp-98],rdx
       lea       rcx,[rdx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-98]
       call      qword ptr [7FF997E27B58]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [rbp-3C],esi
M15_L01:
       mov       rdx,[rbp-90]
       mov       [rdx+60],r14d
       lea       rcx,[rdx+30]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       eax,[rbp-5C]
       mov       [rdx+44],eax
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M15_L26
       mov       r8,[rdx+8]
       lea       rcx,[rsi+8]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       eax,[rbp-5C]
       mov       [rsi+5C],eax
       mov       rcx,[rsi+50]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       jle       short M15_L03
M15_L02:
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       inc       edx
       cmp       [rcx+8],edx
       jg        short M15_L02
M15_L03:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M15_L04
       xor       edx,edx
       mov       [rcx+18],rdx
M15_L04:
       mov       rsi,[rbp-90]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M15_L29
       mov       rdx,[rsi+10]
       mov       edx,[rdx+8]
       mov       [rsi+50],edx
       mov       rdx,[rsi+18]
       mov       edx,[rdx+8]
       mov       [rsi+54],edx
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M15_L05:
       mov       edx,[rbp-3C]
       mov       [rsi+4C],edx
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__RemoveCrLfRegex_13+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M15_L41
       mov       rdx,rsi
       mov       [rbp-0C8],rdx
M15_L06:
       mov       ecx,[rdx+4C]
       test      ecx,ecx
       jle       near ptr M15_L33
       dec       ecx
       mov       r8d,ecx
       mov       eax,[rbp-5C]
       cmp       r8d,eax
       jae       short M15_L08
       nop       dword ptr [rax+rax]
M15_L07:
       mov       r10d,ecx
       movzx     r10d,word ptr [r12+r10*2]
       cmp       r10d,0A
       sete      r9b
       movzx     r9d,r9b
       cmp       r10d,0D
       sete      r10b
       movzx     r10d,r10b
       or        r10d,r9d
       jne       near ptr M15_L17
       lea       ecx,[r8-1]
       mov       r8d,ecx
       cmp       r8d,eax
       jb        short M15_L07
M15_L08:
       xor       ecx,ecx
       mov       [rdx+4C],ecx
M15_L09:
       mov       r8,[rsi+28]
       mov       [rbp-0C0],r8
       mov       rcx,[r8+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M15_L50
       mov       r10d,[rcx+10]
       mov       [rbp-84],r10d
       test      r10d,r10d
       jle       near ptr M15_L24
       test      r15b,r15b
       je        near ptr M15_L42
M15_L10:
       mov       ecx,[rsi+4C]
       mov       r10d,[rbp-84]
       mov       [r8+30],r10d
       xor       edx,edx
       mov       [r8+34],edx
       mov       [r8+58],ecx
       mov       ecx,[r8+5C]
       mov       [r8+5C],ecx
       mov       rcx,[r8+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M15_L50
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M15_L50
       mov       edx,[rcx+14]
       mov       [r8+14],edx
       mov       ecx,[rcx+10]
       mov       [r8+10],ecx
       cmp       r14d,2
       je        near ptr M15_L43
M15_L11:
       mov       r10,r8
M15_L12:
       cmp       dword ptr [r10+30],0
       je        near ptr M15_L51
       mov       [rbp+50],r15d
       test      r15b,r15b
       je        near ptr M15_L44
M15_L13:
       mov       rdx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       mov       r13,[rbp+40]
       cmp       [r13+18],rdx
       jne       near ptr M15_L45
       lea       r8,[rbx+10]
       mov       [rbp-0F0],r8
       lea       rdx,[rbx+20]
       mov       ecx,[r10+10]
       mov       [rbp-0B8],r10
       mov       r9d,[r10+14]
       lea       r11d,[rcx+r9]
       mov       r13d,[rbx+8]
       sub       r13d,ecx
       sub       r13d,r9d
       mov       ecx,r11d
       mov       r9d,r13d
       add       rcx,r9
       mov       r9d,[rdx+0C]
       cmp       rcx,r9
       ja        near ptr M15_L49
       mov       r9,[rdx]
       add       r11d,[rdx+8]
       mov       [rbp-54],r11d
       mov       rcx,[r8]
       mov       edx,[r8+8]
       mov       [rbp-58],edx
       cmp       [rcx+8],edx
       ja        near ptr M15_L25
       mov       [rbp-80],r9
       mov       [rbp-78],r11d
       mov       [rbp-74],r13d
       lea       rdx,[rbp-80]
       mov       rcx,r8
       call      qword ptr [7FF997E27DF8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M15_L14:
       mov       r13,[rbp-0B8]
       mov       ecx,[r13+10]
       mov       [rbx+8],ecx
       mov       rcx,[rbx]
       lea       rdx,[rbx+10]
       mov       r8,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF997E27F30]; System.Text.RegularExpressions.RegexReplacement.ReplacementImplRTL(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef, System.Text.RegularExpressions.Match)
       lea       rdx,[rbx+0C]
       mov       r8d,[rdx]
       dec       r8d
       mov       [rdx],r8d
       test      r8d,r8d
       je        near ptr M15_L51
M15_L15:
       mov       eax,[rsi+4C]
       mov       edx,eax
       cmp       dword ptr [r13+14],0
       je        near ptr M15_L46
M15_L16:
       mov       rcx,[rsi+10]
       mov       ecx,[rcx+8]
       mov       [rsi+50],ecx
       mov       rcx,[rsi+18]
       mov       ecx,[rcx+8]
       mov       [rsi+54],ecx
       mov       rcx,[rsi+20]
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
       mov       [rbp-3C],edx
       mov       esi,eax
       movzx     r15d,byte ptr [rbp+50]
       jmp       near ptr M15_L01
M15_L17:
       inc       ecx
       mov       [rdx+4C],ecx
       mov       r8d,ecx
       mov       r10d,r8d
       cmp       r10d,eax
       ja        near ptr M15_L48
       xor       r8d,r8d
       test      r10d,r10d
       jle       near ptr M15_L34
M15_L18:
       mov       r9d,r10d
       sub       r9d,r8d
       dec       r9d
       cmp       r9d,eax
       jae       near ptr M15_L50
       movzx     r9d,word ptr [r12+r9*2]
       cmp       r9d,0A
       sete      r11b
       movzx     r11d,r11b
       cmp       r9d,0D
       sete      r9b
       movzx     r9d,r9b
       or        r9d,r11d
       je        short M15_L19
       inc       r8d
       cmp       r10d,r8d
       jle       short M15_L19
       mov       eax,[rbp-5C]
       jmp       short M15_L18
M15_L19:
       test      r8d,r8d
       je        near ptr M15_L35
       mov       ecx,r10d
       sub       ecx,r8d
       mov       r8d,ecx
       mov       [rdx+4C],r8d
       mov       r9d,r10d
       mov       r11d,r8d
       cmp       r11d,r9d
       jge       short M15_L20
       mov       [rbp-48],r10d
       mov       [rbp-4C],r8d
       mov       r9d,[rbp-4C]
       mov       r11d,[rbp-48]
M15_L20:
       cmp       dword ptr [rdx+58],0
       je        near ptr M15_L36
M15_L21:
       mov       rcx,[rdx+20]
       mov       r8d,[rdx+58]
       dec       r8d
       mov       [rdx+58],r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M15_L50
       xor       r10d,r10d
       mov       [rcx+r8*4+10],r10d
       mov       r8,[rdx+28]
       mov       [rbp-0D0],r8
       mov       r10,[r8+48]
       mov       [rbp-0D8],r10
       cmp       dword ptr [r10+8],0
       jbe       near ptr M15_L50
       cmp       qword ptr [r10+10],0
       je        near ptr M15_L37
M15_L22:
       mov       r8,[rbp-0D0]
       mov       r10,[r8+48]
       mov       [rbp-0E0],r10
       mov       r8,[r8+50]
       mov       [rbp-0E8],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M15_L50
       mov       ecx,[r8+10]
       mov       [rbp-50],ecx
       cmp       dword ptr [r10+8],0
       jbe       near ptr M15_L50
       mov       rdx,[r10+10]
       lea       r13d,[rcx*2+2]
       cmp       [rdx+8],r13d
       jl        near ptr M15_L38
M15_L23:
       mov       rdx,[r10+10]
       mov       r10,rdx
       lea       r13d,[rcx+rcx]
       cmp       r13d,[r10+8]
       jae       near ptr M15_L50
       lea       r13d,[rcx+rcx]
       mov       [r10+r13*4+10],r9d
       lea       r10d,[rcx*2+1]
       cmp       r10d,[rdx+8]
       jae       near ptr M15_L50
       sub       r11d,r9d
       mov       [rdx+r10*4+10],r11d
       inc       ecx
       mov       r8,[rbp-0E8]
       mov       [r8+10],ecx
       mov       eax,[rbp-5C]
       jmp       near ptr M15_L09
M15_L24:
       xor       r10d,r10d
       mov       [r8+8],r10
       mov       rdx,232C68001B0
       mov       r10,[rdx]
       mov       r8,r10
       mov       r10,r8
       jmp       near ptr M15_L12
M15_L25:
       cmp       edx,[rcx+8]
       jae       near ptr M15_L50
       mov       r15d,edx
       shl       r15,4
       lea       r15,[rcx+r15+10]
       mov       rcx,r15
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-54]
       mov       [r15+8],ecx
       mov       [r15+0C],r13d
       mov       r15d,[rbp-58]
       inc       r15d
       mov       r13,[rbp-0F0]
       mov       [r13+8],r15d
       jmp       near ptr M15_L14
M15_L26:
       mov       rsi,[rdx+30]
       mov       r8,[rsi+18]
       mov       [rbp-0F8],r8
       test      r8,r8
       je        short M15_L27
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-0A8],rdx
       mov       rax,rsi
       mov       r10,[rbp-0F8]
       mov       [rbp-0B0],r10
       mov       r11d,[rbp-5C]
       mov       [rsp+20],r11d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-90]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF997E27CC0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-0A8]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0A8]
       jmp       short M15_L28
M15_L27:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A0],rax
       mov       eax,[rbp-5C]
       mov       [rsp+20],eax
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-90]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FF997E27CC0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-0A0]
M15_L28:
       mov       rsi,[rbp-90]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M15_L04
M15_L29:
       mov       rcx,rsi
       mov       rdx,[rsi]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M15_L30
       mov       r8d,20
M15_L30:
       cmp       eax,10
       mov       [rbp-40],eax
       jge       short M15_L31
       mov       dword ptr [rbp-40],10
M15_L31:
       mov       [rbp-44],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-44]
       mov       [rsi+50],edx
       movsxd    rdx,dword ptr [rbp-40]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [rsi+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M15_L05
M15_L32:
       dec       ecx
       mov       [rdx+4C],ecx
       jmp       near ptr M15_L06
M15_L33:
       mov       eax,[rbp-5C]
       jmp       near ptr M15_L08
M15_L34:
       jmp       near ptr M15_L19
M15_L35:
       cmp       dword ptr [rdx+4C],0
       jne       short M15_L32
       mov       eax,[rbp-5C]
       jmp       near ptr M15_L09
M15_L36:
       mov       [rbp-4C],r9d
       mov       [rbp-48],r11d
       mov       rcx,rdx
       call      qword ptr [7FF997EC5038]
       mov       rdx,[rbp-0C8]
       mov       r9d,[rbp-4C]
       mov       r11d,[rbp-48]
       jmp       near ptr M15_L21
M15_L37:
       mov       [rbp-4C],r9d
       mov       [rbp-48],r11d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-0D8]
       xor       edx,edx
       call      qword ptr [7FF9978057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r9d,[rbp-4C]
       mov       r11d,[rbp-48]
       jmp       near ptr M15_L22
M15_L38:
       mov       [rbp-4C],r9d
       mov       [rbp-48],r11d
       mov       r13,[r10+10]
       lea       edx,[rcx*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M15_L40
M15_L39:
       cmp       ecx,[r13+8]
       jae       near ptr M15_L50
       mov       r8d,[r13+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M15_L50
       mov       [rax+rcx*4+10],r8d
       inc       ecx
M15_L40:
       mov       r10d,[rbp-50]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M15_L39
       mov       rcx,[rbp-0E0]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9978057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rbp-50]
       mov       r9d,[rbp-4C]
       mov       r10,[rbp-0E0]
       mov       r11d,[rbp-48]
       jmp       near ptr M15_L23
M15_L41:
       mov       [rbp-70],r12
       mov       eax,[rbp-5C]
       mov       [rbp-68],eax
       lea       rdx,[rbp-70]
       mov       rcx,rsi
       mov       r8,[rsi]
       mov       r8,[r8+40]
       call      qword ptr [r8+20]
       mov       eax,[rbp-5C]
       jmp       near ptr M15_L09
M15_L42:
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],rcx
       mov       eax,[rbp-5C]
       mov       r8,[rbp-0C0]
       jmp       near ptr M15_L10
M15_L43:
       cmp       byte ptr [r8+60],0
       je        near ptr M15_L11
       mov       rcx,r8
       call      qword ptr [7FF997EC5050]
       mov       eax,[rbp-5C]
       mov       r8,[rbp-0C0]
       jmp       near ptr M15_L11
M15_L44:
       xor       edx,edx
       mov       [rsi+28],rdx
       jmp       near ptr M15_L13
M15_L45:
       mov       rdx,rbx
       mov       [rbp-0B8],r10
       mov       r8,r10
       mov       r13,[rbp+40]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       [rbp+40],r13
       je        short M15_L51
       mov       r13,[rbp-0B8]
       jmp       near ptr M15_L15
M15_L46:
       mov       r13d,[rbp-5C]
       mov       edx,r13d
       mov       ecx,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M15_L47
       xor       edx,edx
       mov       ecx,0FFFFFFFF
M15_L47:
       cmp       eax,edx
       je        short M15_L51
       lea       edx,[rax+rcx]
       jmp       near ptr M15_L16
M15_L48:
       call      qword ptr [7FF997977198]
       int       3
M15_L49:
       mov       ecx,21
       call      qword ptr [7FF997A278D0]
       int       3
M15_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L51:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M15_L52:
       mov       rdx,[rcx+10]
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M15_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rsi,[rbp-90]
       mov       [rsi+8],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 2338
```
```assembly
; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       movzx     edi,r8b
       test      edi,edi
       setne     bpl
       movzx     ebp,bpl
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993528]
       test      rax,rax
       je        short M16_L04
M16_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M16_L02
       mov       rcx,rbx
       call      qword ptr [7FF9EF9860A0]
       test      rax,rax
       jne       short M16_L06
       call      qword ptr [7FF9EF9783F0]
       cmp       qword ptr [rax+8],0
       jne       short M16_L05
       xor       edi,edi
M16_L01:
       test      edi,edi
       jne       short M16_L06
M16_L02:
       xor       eax,eax
M16_L03:
       test      rax,rax
       jne       short M16_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993530]
       jmp       short M16_L00
M16_L05:
       call      qword ptr [7FF9EF9783F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M16_L01
M16_L06:
       mov       rcx,rbx
       call      qword ptr [7FF9EF989690]
       jmp       short M16_L03
M16_L07:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 183
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M17_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FF997EC7DF8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       cmp       dword ptr [rdi+8],0
       jne       near ptr M18_L10
       mov       ebp,100
M18_L00:
       mov       rcx,232C6800198
       mov       r14,[rcx]
       mov       r15,r14
       mov       r13,r15
       mov       rcx,232C2000C90
       mov       r12,[rcx]
       mov       [rsp+68],r12
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       edx,edx
       lzcnt     edx,ecx
       xor       edx,1F
       add       edx,0FFFFFFFD
       mov       [rsp+0B4],edx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M18_L11
       mov       rcx,[rcx+240]
       mov       r8,[rcx+48]
       test      r8,r8
       je        near ptr M18_L11
M18_L01:
       mov       [rsp+30],r8
       mov       rcx,[r8+10]
       test      rcx,rcx
       je        near ptr M18_L14
       mov       r10d,[rcx+8]
       mov       edx,[rsp+0B4]
       cmp       r10d,edx
       jbe       near ptr M18_L15
       mov       r10d,edx
       shl       r10,4
       mov       r9,[rcx+r10+10]
       test      r9,r9
       je        near ptr M18_L13
       xor       r11d,r11d
       mov       [rcx+r10+10],r11
       mov       rax,[rsp+68]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M18_L12
M18_L02:
       mov       rbp,r9
M18_L03:
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15d,[rsi+8]
       test      rbp,rbp
       je        near ptr M18_L34
       mov       rcx,[rdi]
       cmp       rcx,[rbp]
       jne       near ptr M18_L34
       cmp       dword ptr [rcx+4],18
       jne       near ptr M18_L34
       cmp       r15d,[rdi+8]
       ja        near ptr M18_L34
       cmp       r15d,[rbp+8]
       ja        near ptr M18_L34
       mov       r8d,r15d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M18_L33
       cmp       r8,4000
       jbe       short M18_L04
       mov       rcx,rax
       call      qword ptr [7FF997EC5200]
       jmp       short M18_L05
M18_L04:
       mov       rcx,rax
       call      00007FF9F73FDC70
       cmp       dword ptr [7FF9F7753B10],0
       jne       near ptr M18_L31
M18_L05:
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       r13,[rsp+30]
       mov       r13,[r13+10]
       test      r13,r13
       je        near ptr M18_L37
M18_L06:
       xor       eax,eax
       mov       dword ptr [rsp+90],1
       cmp       [r13+8],r15d
       jbe       near ptr M18_L08
       mov       dword ptr [rsp+94],1
       mov       rdx,[rdi]
       movzx     ecx,word ptr [rdx]
       mov       r10d,[rdi+8]
       imul      r10,rcx
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M18_L38
       mov       rdx,r10
       shr       rdx,3
       call      qword ptr [7FF997E2C2D0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M18_L07:
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M18_L39
       mov       ecx,r15d
       shl       rcx,4
       lea       r13,[r13+rcx+10]
       mov       rax,[r13]
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       mov       r13,[rsp+48]
       test      r13,r13
       jne       near ptr M18_L40
       mov       eax,[rsp+94]
M18_L08:
       cmp       byte ptr [r12+9D],0
       jne       near ptr M18_L55
M18_L09:
       mov       eax,[rsi+8]
       lea       ecx,[rax+1]
       mov       [rsi+8],ecx
       cmp       eax,[rbp+8]
       jae       near ptr M18_L58
       shl       rax,4
       lea       rdi,[rbp+rax+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M18_L10:
       mov       ebp,[rdi+8]
       add       ebp,ebp
       jmp       near ptr M18_L00
M18_L11:
       mov       ecx,9
       call      qword ptr [7FF997EC4D38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r8,rax
       jmp       near ptr M18_L01
M18_L12:
       mov       [rsp+60],r9
       mov       rcx,r9
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rbp,[rsp+60]
       mov       eax,[rbp+8]
       mov       [rsp+9C],eax
       mov       rcx,r15
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+0B4]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+9C]
       mov       rcx,[rsp+68]
       call      qword ptr [7FF997EC51A0]
       mov       r9,rbp
       jmp       near ptr M18_L02
M18_L13:
       mov       edx,[rsp+0B4]
       jmp       short M18_L15
M18_L14:
       mov       edx,[rsp+0B4]
M18_L15:
       mov       rcx,[r13+10]
       cmp       [rcx+8],edx
       jbe       near ptr M18_L28
       mov       r10d,edx
       mov       rcx,[rcx+r10*8+10]
       test      rcx,rcx
       je        near ptr M18_L27
       mov       rbp,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99774B17C],0
       je        short M18_L16
       call      qword ptr [7FF997EC4D80]
       mov       r15d,eax
       jmp       short M18_L18
M18_L16:
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       mov       r15d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M18_L17
       call      qword ptr [7FF997EC4DB0]
       mov       r15d,eax
       jmp       short M18_L18
M18_L17:
       sar       r15d,10
M18_L18:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF99774B170]
       mov       r15d,edx
       xor       eax,eax
       jmp       near ptr M18_L22
M18_L19:
       cmp       r15d,[rbp+8]
       jae       near ptr M18_L58
       mov       ecx,r15d
       mov       rdx,[rbp+rcx*8+10]
       mov       [rsp+50],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       rcx,rdx
       call      qword ptr [7FF997D0D770]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rsp+50]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M18_L20
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rsp+58],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M18_L20:
       mov       rcx,rdx
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rsp+58]
       test      rcx,rcx
       jne       short M18_L23
       inc       r15d
       cmp       [rbp+8],r15d
       jne       short M18_L21
       xor       r15d,r15d
M18_L21:
       mov       eax,[rsp+98]
       inc       eax
M18_L22:
       mov       [rsp+98],eax
       cmp       [rbp+8],eax
       jg        near ptr M18_L19
       jmp       short M18_L24
M18_L23:
       mov       rbp,rcx
       jmp       short M18_L25
M18_L24:
       xor       ebp,ebp
M18_L25:
       test      rbp,rbp
       je        short M18_L27
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        short M18_L26
       mov       rcx,rbp
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       edx,[rbp+8]
       mov       [rsp+0A0],edx
       mov       rcx,r13
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r13d,[rsp+0B4]
       mov       [rsp+20],r13d
       mov       edx,[rsp+0A4]
       mov       r8d,[rsp+0A0]
       mov       rcx,r15
       call      qword ptr [7FF997EC51A0]
       mov       r9,rbp
       jmp       near ptr M18_L02
M18_L26:
       mov       r9,rbp
       jmp       near ptr M18_L02
M18_L27:
       mov       ecx,10
       mov       edx,[rsp+0B4]
       shlx      ebp,ecx,edx
       jmp       short M18_L30
M18_L28:
       test      ebp,ebp
       jne       short M18_L29
       mov       rbp,273570D0DA8
       jmp       near ptr M18_L03
M18_L29:
       mov       ecx,ebp
       mov       rdx,273570C6F28
       call      qword ptr [7FF997A2D848]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M18_L30:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.ReadOnlyMemory<System.Char>[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        near ptr M18_L32
       mov       rcx,rbp
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0B0],eax
       mov       edx,[rbp+8]
       mov       [rsp+0AC],edx
       mov       rcx,r13
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0AC]
       mov       rcx,r15
       call      qword ptr [7FF997EC51A0]
       mov       eax,[rbp+8]
       mov       [rsp+0A8],eax
       mov       rcx,r13
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r13+10]
       mov       edx,1
       mov       r8d,2
       mov       r13d,[rsp+0B4]
       cmp       [rcx+8],r13d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0A8]
       call      qword ptr [7FF997EC51B8]
       mov       r9,rbp
       jmp       near ptr M18_L02
M18_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L05
M18_L32:
       mov       r9,rbp
       jmp       near ptr M18_L02
M18_L33:
       mov       rcx,rax
       call      qword ptr [7FF997805818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M18_L05
M18_L34:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF997EC57E8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
       test      rbp,rbp
       jne       short M18_L35
       xor       r9d,r9d
       jmp       short M18_L36
M18_L35:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF997EC57E8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M18_L36:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FF997EC5218]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M18_L05
M18_L37:
       mov       rcx,r14
       call      qword ptr [7FF997E27EE8]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r13,rax
       jmp       near ptr M18_L06
M18_L38:
       mov       rdx,r10
       call      qword ptr [7FF9978057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M18_L07
M18_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997EC4D50]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF997744000
       call      qword ptr [7FF997A27798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF997B86010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M18_L40:
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M18_L58
       mov       edx,r15d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M18_L41
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF997EC4D68]
M18_L41:
       mov       rax,[rax+8]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99774B17C],0
       je        short M18_L42
       call      qword ptr [7FF997EC4D80]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M18_L44
M18_L42:
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       mov       eax,[rax+10]
       mov       [rsp+78],eax
       mov       ecx,0A
       call      qword ptr [7FF997EC4D98]
       mov       edx,[rsp+78]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M18_L43
       call      qword ptr [7FF997EC4DB0]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M18_L44
M18_L43:
       sar       edx,10
       mov       [rsp+7C],edx
M18_L44:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF997805740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+7C]
       xor       edx,edx
       div       dword ptr [7FF99774B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M18_L51
M18_L45:
       cmp       eax,[r8+8]
       jae       near ptr M18_L58
       mov       [rsp+84],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+38],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+74],r9d
       mov       rcx,r10
       call      qword ptr [7FF997D0D770]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+70],r8d
       cmp       [rcx+8],r8d
       jbe       short M18_L47
       test      r8d,r8d
       jne       short M18_L48
       xor       edx,edx
       mov       [rax+14],edx
M18_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+70]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+74],1
M18_L47:
       mov       rcx,rax
       call      qword ptr [7FF997806820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+74],0
       je        short M18_L49
       jmp       short M18_L52
M18_L48:
       jmp       short M18_L46
M18_L49:
       mov       eax,[rsp+84]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+40]
       cmp       [r8+8],ecx
       jne       short M18_L50
       xor       ecx,ecx
M18_L50:
       mov       edx,[rsp+80]
       inc       edx
       mov       eax,ecx
M18_L51:
       mov       r8,[rsp+40]
       mov       [rsp+80],edx
       cmp       [r8+8],edx
       jg        near ptr M18_L45
       jmp       short M18_L53
M18_L52:
       mov       r8d,1
       jmp       short M18_L54
M18_L53:
       xor       r8d,r8d
M18_L54:
       mov       [rsp+90],r8d
       mov       eax,[rsp+94]
       jmp       near ptr M18_L08
M18_L55:
       cmp       dword ptr [rdi+8],0
       mov       [rsp+94],eax
       je        near ptr M18_L09
       mov       rcx,rdi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rdi+8]
       mov       [rsp+8C],eax
       mov       rcx,r14
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,r13d
       mov       r9d,[rsp+8C]
       mov       edx,3
       call      qword ptr [7FF997EC4DE0]
       mov       r13d,[rsp+94]
       test      [rsp+90],r13d
       jne       near ptr M18_L09
       mov       rcx,rdi
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+88],eax
       mov       edi,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FF997C1CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M18_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M18_L57
M18_L56:
       mov       ecx,r15d
       xor       edx,edx
M18_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,[rsp+88]
       mov       r8d,edi
       call      qword ptr [7FF997EC4DF8]
       jmp       near ptr M18_L09
M18_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2284
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ReplaceSpaces()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       call      qword ptr [7FF997C25CE0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rbx,rax
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L27
       mov       rcx,25678001370
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L18
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L18
M00_L00:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,25678000108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       call      qword ptr [7FF997A34138]; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rsi,rax
M00_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF997C26298]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L21
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       mov       rcx,rdi
       mov       rdx,2970CFA06C0
       mov       r9d,1
       call      qword ptr [7FF997C26C88]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L02
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L19
M00_L02:
       test      r14,r14
       je        near ptr M00_L21
M00_L03:
       test      r14,r14
       je        near ptr M00_L37
       mov       rcx,256780020C8
       mov       rbx,[rcx]
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L28
       xor       esi,esi
M00_L04:
       mov       rdi,[rbx+38]
       test      rdi,rdi
       je        near ptr M00_L29
M00_L05:
       mov       r15,[rbx+18]
       mov       r13d,[rbx+44]
       mov       r12,[rbx+20]
       mov       eax,[rbx+40]
       mov       [rbp-44],eax
       mov       rcx,[rdi+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        short M00_L08
       mov       eax,[rbp-44]
       test      cl,2
       jne       short M00_L06
       mov       r8,[rcx]
       mov       r10,r8
       jmp       short M00_L09
M00_L06:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       r8,[rdx]
       test      r8,r8
       jne       short M00_L07
       mov       rdx,7FF997EF2E70
       call      qword ptr [7FF997816E08]
       mov       r8,rax
       mov       eax,[rbp-44]
M00_L07:
       mov       r10,r8
       jmp       short M00_L09
M00_L08:
       mov       eax,[rbp-44]
       xor       r10d,r10d
M00_L09:
       test      r10,r10
       je        short M00_L11
       mov       [rbp-70],r10
       mov       r8,[r10+18]
       cmp       [r8],r8b
       mov       rdx,2970CF925A8
       cmp       r8,rdx
       jne       short M00_L10
       mov       r15,[rbp-70]
       jmp       near ptr M00_L15
M00_L10:
       cmp       dword ptr [r8+8],1
       jne       short M00_L11
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       mov       rdx,2970CF925B4
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       mov       eax,[rbp-44]
       je        short M00_L11
       mov       r15,[rbp-70]
       jmp       short M00_L15
M00_L11:
       mov       [rsp+20],r12
       mov       edx,eax
       mov       r8,r15
       mov       r9d,r13d
       mov       rcx,2970CF925A8
       call      qword ptr [7FF997E376C0]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r15,rax
       mov       r13,[rdi+8]
       and       r13,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L31
       test      r15,r15
       je        short M00_L12
       cmp       qword ptr [7FF99775B020],0
       jne       near ptr M00_L32
M00_L12:
       xor       eax,eax
M00_L13:
       test      r13b,2
       jne       near ptr M00_L33
       test      rax,rax
       jne       near ptr M00_L33
       mov       rcx,r13
       mov       rdx,r15
       call      00007FF9F7424440
M00_L14:
       nop
M00_L15:
       cmp       [r15],r15b
       cmp       [r14+8],esi
       jb        near ptr M00_L34
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L36
       cmp       byte ptr [r15+20],0
       jne       near ptr M00_L36
       mov       rcx,[r15+10]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L35
       mov       rcx,[r15+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L38
       mov       r8,[rcx+10]
M00_L16:
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997E37918]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L17:
       mov       [rbp-50],rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L18:
       mov       ecx,2
       call      qword ptr [7FF997ED4D50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L19:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       mov       rcx,rdi
       mov       rdx,2970CFA06C0
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FF997ED50F8]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rsi
M00_L22:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF997C8E228]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L25
       mov       rcx,[rbp-58]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF997958720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L25
       cmp       r14,rdi
       je        short M00_L22
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,2970CFA06C0
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L23
       mov       rdi,r14
       jmp       short M00_L22
M00_L23:
       cmp       qword ptr [rbx+38],0
       je        short M00_L24
       mov       rdx,[rbx+38]
       mov       [rbp-68],rdx
       mov       byte ptr [rbp-40],0
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-68]
       call      qword ptr [7FF997815998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+8]
       mov       [rbp-78],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-40],0
       je        short M00_L24
       mov       rcx,[rbp-68]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M00_L24:
       mov       [rbp-60],r15
       jmp       short M00_L26
M00_L25:
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L26:
       call      M00_L40
       nop
       mov       r14,[rbp-60]
       jmp       near ptr M00_L03
M00_L27:
       mov       r8,25678001370
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,2970CFA06C0
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L28:
       mov       esi,[r14+8]
       jmp       near ptr M00_L04
M00_L29:
       lea       rdi,[rbx+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF997816D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rdi,rdi
       jne       short M00_L30
       call      qword ptr [7FF997ED53E0]
       int       3
M00_L30:
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF9F7419D60
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L05
       mov       rdi,[rbx+38]
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED5830]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997B95F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       mov       rax,[7FF99775B020]
       mov       rcx,r15
       call      rax
       test      eax,eax
       je        near ptr M00_L12
       mov       rcx,r15
       call      qword ptr [7FF997ED5848]
       jmp       near ptr M00_L13
M00_L33:
       lea       rcx,[rdi+8]
       mov       rdx,r15
       mov       r8,rax
       call      qword ptr [7FF997ED5860]
       jmp       near ptr M00_L14
M00_L34:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED5428]
       int       3
M00_L35:
       mov       r8,2970CF90008
       jmp       near ptr M00_L16
M00_L36:
       mov       [rsp+20],esi
       mov       rcx,r15
       mov       rdx,rbx
       mov       r8,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF997ED5440]
       jmp       near ptr M00_L17
M00_L37:
       xor       eax,eax
       jmp       near ptr M00_L17
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M00_L39
       mov       rcx,[rbp-68]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M00_L39:
       nop
       add       rsp,28
       ret
M00_L40:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
; Total bytes of code 1507
```
```assembly
; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
;                 if (object.ReferenceEquals(resourceMan, null)) {
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetTips.Spargine.Tester.Properties.Resources", typeof(Resources).Assembly);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     resourceMan = temp;
;                     ^^^^^^^^^^^^^^^^^^^
;                 return resourceMan;
;                 ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,25678001368
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2970CF9B988
       call      qword ptr [7FF997ED5878]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,2970CF9B910
       call      qword ptr [7FF997C25D10]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 101
```
```assembly
; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rax,256780000F8
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF997A34150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
; Total bytes of code 25
```
```assembly
; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        short M03_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M03_L17
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M03_L16
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L19
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M03_L18
M03_L01:
       cmp       rdi,rdx
       jne       near ptr M03_L15
M03_L02:
       mov       rax,25678000100
       mov       rax,[rax]
       mov       [rbp+18],rax
M03_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L22
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M03_L04
       call      qword ptr [7FF997ED5140]
       int       3
M03_L04:
       mov       rcx,[rbp-30]
       call      00007FF9F749DAE0
       test      eax,eax
       jne       short M03_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997ED4FD8]
M03_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M03_L11
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L10
M03_L06:
       mov       rax,[rbp+10]
       mov       r8,[rax+38]
       mov       rdx,[r8+8]
       cmp       rcx,rdx
       jne       short M03_L08
M03_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M03_L13
M03_L08:
       test      rcx,rcx
       je        near ptr M03_L12
       test      rdx,rdx
       je        short M03_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M03_L12
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M03_L09:
       test      eax,eax
       je        near ptr M03_L20
       jmp       short M03_L07
M03_L10:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,2970CF90008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M03_L06
M03_L11:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M03_L06
M03_L12:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M03_L09
M03_L13:
       cmp       byte ptr [rbp-28],0
       je        short M03_L14
       mov       rcx,[rbp-30]
       call      00007FF9F749DA00
       test      eax,eax
       jne       near ptr M03_L21
M03_L14:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L15:
       test      rdi,rdi
       je        near ptr M03_L03
       test      rdx,rdx
       je        near ptr M03_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L03
       lea       rax,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L16:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,2970CF90008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L17:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M03_L19
M03_L18:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,2970CF90008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M03_L01
M03_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M03_L01
M03_L20:
       call      M03_L26
       jmp       short M03_L22
M03_L21:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF997ED4E40]
       jmp       near ptr M03_L14
M03_L22:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M03_L23
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FF997815998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FF99785AC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,rbx
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M03_L23:
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L25
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M03_L24
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997815998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+18]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L24
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M03_L24:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L25:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L26:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L27
       mov       rcx,[rbp-30]
       call      00007FF9F749DA00
       test      eax,eax
       je        short M03_L27
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF997ED4E40]
M03_L27:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L28
       mov       rcx,[rbp-38]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M03_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L29
       mov       rcx,[rbp-30]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M03_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1028
```
```assembly
; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M04_L24
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M04_L25
       test      rbx,rbx
       je        near ptr M04_L25
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M04_L00
       call      qword ptr [7FF997ED5140]
       int       3
M04_L00:
       mov       rcx,rbx
       call      00007FF9F749DAE0
       test      eax,eax
       jne       short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF997ED4FD8]
M04_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L16
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M04_L11
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M04_L03
       lea       r11,[rdx+0C]
M04_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M04_L02
M04_L03:
       mov       r14d,ecx
M04_L04:
       mov       r8,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       eax,[r8+8]
       mov       r10d,eax
       imul      rcx,r10
       shr       rcx,20
       cmp       ecx,eax
       jae       near ptr M04_L20
       mov       ecx,ecx
       lea       r8,[r8+rcx*4+10]
       mov       r15d,[r8]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M04_L16
M04_L05:
       mov       r8d,r15d
       shl       r8,5
       lea       r15,[r13+r8+10]
       cmp       [r15+8],r14d
       jne       near ptr M04_L15
       mov       r10,[r15]
       mov       r8,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,r8
       jne       near ptr M04_L14
       cmp       r10,rdx
       jne       short M04_L09
       mov       r9d,1
M04_L06:
       test      r9d,r9d
       je        near ptr M04_L15
       add       r15,10
M04_L07:
       test      r15,r15
       je        short M04_L10
       vmovdqu   xmm0,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M04_L17
M04_L08:
       mov       [rbp-80],rsi
       jmp       near ptr M04_L22
M04_L09:
       test      r10,r10
       je        near ptr M04_L13
       mov       r8d,[r10+8]
       mov       ecx,[rdx+8]
       cmp       r8d,ecx
       jne       near ptr M04_L13
       lea       rcx,[r10+0C]
       mov       r8d,[r10+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L06
M04_L10:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FF997C26D00]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M04_L21
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997C26D78]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF997C26E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L08
M04_L11:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FF9977609B8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L04
M04_L12:
       cmp       eax,r15d
       jbe       short M04_L16
       jmp       near ptr M04_L05
M04_L13:
       xor       r9d,r9d
       jmp       near ptr M04_L06
M04_L14:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FF9977609C0
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L06
M04_L15:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M04_L12
       call      qword ptr [7FF997A37A08]
       int       3
M04_L16:
       xor       r15d,r15d
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L07
M04_L17:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M04_L18
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997ED5200]
       jmp       short M04_L19
M04_L18:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FF997D96850]; System.Resources.ResourceReader.LoadString(Int32)
M04_L19:
       mov       [rbp-80],rax
       jmp       short M04_L22
M04_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L21:
       call      M04_L38
       jmp       near ptr M04_L27
M04_L22:
       cmp       byte ptr [rbp-50],0
       je        short M04_L23
       mov       rcx,[rbp-78]
       call      00007FF9F749DA00
       test      eax,eax
       jne       short M04_L26
M04_L23:
       mov       rax,[rbp-80]
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
M04_L24:
       mov       ecx,13BFC
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       rcx,rax
       call      qword ptr [7FF997ED4E28]
       int       3
M04_L25:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED51D0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF997ED51E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L26:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FF997ED4E40]
       jmp       short M04_L23
M04_L27:
       cmp       byte ptr [rbp+20],0
       jne       short M04_L28
       xor       eax,eax
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
M04_L28:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M04_L29
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,25678000070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF997C26B38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M04_L29:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FF997815998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M04_L32
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF997ED5218]
       jmp       short M04_L31
M04_L30:
       mov       rcx,rsi
       call      qword ptr [7FF997C94248]
       mov       rdx,rax
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       r8d,[rsi+14]
       cmp       [rbx],bl
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],r8d
       lea       r8,[rbp-60]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FF997C26E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M04_L31:
       mov       rcx,rsi
       call      qword ptr [7FF997C94240]
       test      eax,eax
       jne       short M04_L30
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M04_L32:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF997C925D0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M04_L33
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M04_L36
M04_L33:
       cmp       qword ptr [rbp-48],0
       je        short M04_L34
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M04_L36
M04_L34:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FF997C26D78]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M04_L35
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF997C26E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M04_L35:
       cmp       byte ptr [rbp-50],0
       je        short M04_L37
       mov       rcx,[rbp-78]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M04_L37
M04_L36:
       call      M04_L40
       jmp       near ptr M04_L23
M04_L37:
       mov       rax,rsi
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
M04_L38:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L39
       mov       rcx,[rbp-78]
       call      00007FF9F749DA00
       test      eax,eax
       je        short M04_L39
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FF997ED4E40]
M04_L39:
       nop
       add       rsp,28
       ret
M04_L40:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L41
       mov       rcx,[rbp-78]
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
M04_L41:
       nop
       add       rsp,28
       ret
; Total bytes of code 1355
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M05_L01
       cmp       rcx,rdx
       je        near ptr M05_L11
       cmp       r8,20
       jae       near ptr M05_L05
       cmp       r8,10
       jae       near ptr M05_L08
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M05_L00:
       vzeroupper
       ret
M05_L01:
       cmp       r8,4
       jae       short M05_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L02
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L02:
       test      r8b,1
       je        short M05_L03
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M05_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L00
M05_L04:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M05_L00
M05_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L07
M05_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M05_L12
       add       rax,20
       cmp       r8,rax
       ja        short M05_L06
M05_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M05_L12
       jmp       short M05_L11
M05_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L10
M05_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L12
       add       rax,10
       cmp       r8,rax
       ja        short M05_L09
M05_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L12
M05_L11:
       mov       eax,1
       vzeroupper
       ret
M05_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 291
```
```assembly
; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqu   ymmword ptr [rbp+90],ymm4
       vmovdqa   xmmword ptr [rbp+0B0],xmm4
       xor       eax,eax
       mov       [rbp+0C0],rax
       mov       rax,610F88586345
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       rdi,r8
       mov       r14d,r9d
       test      ebx,200
       je        near ptr M06_L32
       mov       rax,25678000100
       mov       r15,[rax]
M06_L00:
       test      [rsp],esp
       sub       rsp,80
       lea       rcx,[rsp+20]
       mov       [rbp+58],rsi
       mov       [rbp+0A0],ebx
       mov       [rbp+60],r15
       xor       eax,eax
       mov       [rbp+8C],eax
       mov       byte ptr [rbp+0A4],0
       mov       [rbp+68],rdi
       mov       [rbp+9C],r14d
       mov       rbx,[rbp+130]
       mov       [rbp+70],rbx
       mov       [rbp+0A8],rax
       mov       [rbp+0B0],eax
       mov       [rbp+0B8],rcx
       mov       dword ptr [rbp+0C0],20
       mov       [rbp+30],rax
       mov       [rbp+38],rax
       mov       [rbp+40],rax
       mov       [rbp+48],rax
       mov       [rbp+50],rax
       mov       [rbp+88],eax
       mov       [rbp+90],eax
       mov       [rbp+94],eax
       mov       [rbp+98],eax
       mov       [rbp+78],rax
       mov       [rbp+80],rax
       mov       byte ptr [rbp+0A5],0
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbp+0A0]
       mov       byte ptr [rax+2E],19
       mov       [rax+28],ecx
       mov       [rbp+48],rax
M06_L01:
       mov       ebx,[rbp+88]
       mov       rcx,[rbp+58]
       cmp       ebx,[rcx+8]
       jge       near ptr M06_L08
       mov       r14d,ebx
       mov       rcx,[rbp+58]
       mov       r8d,[rcx+8]
       mov       edx,r8d
       sub       edx,ebx
       cmp       r8d,ebx
       jb        near ptr M06_L07
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       mov       r8d,edx
       mov       edx,24
       call      qword ptr [7FF997987798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jge       short M06_L02
       jmp       short M06_L03
M06_L02:
       add       eax,ebx
M06_L03:
       mov       [rbp+88],eax
       cmp       dword ptr [rbp+88],0
       jge       short M06_L04
       mov       rcx,[rbp+58]
       mov       ecx,[rcx+8]
       mov       [rbp+88],ecx
M06_L04:
       mov       ebx,[rbp+88]
       sub       ebx,r14d
       cmp       ebx,1
       jg        near ptr M06_L18
       test      ebx,ebx
       je        near ptr M06_L06
       cmp       ebx,1
       jne       near ptr M06_L22
       mov       rbx,[rbp+48]
       mov       rcx,[rbp+58]
       cmp       r14d,[rcx+8]
       jae       near ptr M06_L27
       mov       eax,r14d
       movzx     r14d,word ptr [rcx+rax*2+0C]
       mov       r15d,[rbp+0A0]
       and       r15d,0FFFFFFFE
       mov       rdx,[rbp+60]
       test      r15b,1
       jne       near ptr M06_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
M06_L05:
       cmp       [rbx],bl
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       call      qword ptr [7FF997E37780]; System.Text.RegularExpressions.RegexNode.Reduce()
       mov       r14,rax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       jne       near ptr M06_L11
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L06:
       mov       ecx,[rbp+88]
       mov       rax,[rbp+58]
       cmp       ecx,[rax+8]
       jge       near ptr M06_L01
       jmp       near ptr M06_L28
M06_L07:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF997D95AA0]
       int       3
M06_L08:
       mov       rbx,[rbp+48]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9,rdi
       call      qword ptr [7FF997E37798]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M06_L29
M06_L09:
       lea       r8,[rbp+8C]
       lea       r9,[rbp+20]
       mov       ecx,r14d
       call      qword ptr [7FF997EDD278]
       test      eax,eax
       jne       short M06_L10
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       and       r15d,0FFFFFFFE
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
       jmp       near ptr M06_L05
M06_L10:
       vmovdqu   xmm0,xmmword ptr [rbp+20]
       vmovdqu   xmmword ptr [rbp+10],xmm0
       lea       rcx,[rbp+10]
       call      qword ptr [7FF997EDD290]
       mov       r13,rax
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       byte ptr [r14+2E],0B
       mov       ecx,r15d
       and       ecx,0FFFFFFFE
       mov       [r14+28],ecx
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,r14
       jmp       near ptr M06_L05
M06_L11:
       mov       rdx,[rbx+8]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M06_L16
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FF997B96610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M06_L12
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L13
M06_L12:
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FF99798E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L13:
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M06_L14
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L15
M06_L14:
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FF99798E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L15:
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L06
M06_L16:
       mov       rdx,[rbx+8]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M06_L17
       lea       r8d,[rdx+1]
       mov       [rax+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L06
M06_L17:
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FF99798E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L06
M06_L18:
       mov       ecx,[rbp+0A0]
       not       ecx
       and       ecx,1
       or        ecx,1
       jne       short M06_L21
       mov       rcx,[rbp+58]
       test      rcx,rcx
       jne       short M06_L20
M06_L19:
       mov       ecx,21
       call      qword ptr [7FF997A378D0]
       int       3
M06_L20:
       mov       eax,r14d
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        short M06_L19
       mov       eax,r14d
       lea       rcx,[rcx+rax*2+0C]
       mov       eax,ebx
       mov       [rbp+10],rcx
       mov       [rbp+18],eax
       lea       rcx,[rbp+10]
       call      qword ptr [7FF997EDD260]
       test      eax,eax
       jne       short M06_L22
M06_L21:
       mov       r15,[rbp+48]
       mov       r13d,[rbp+0A0]
       and       r13d,0FFFFFFFE
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[rbp+58]
       mov       edx,r14d
       mov       r8d,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF99798F450]; System.String.Substring(Int32, Int32)
       mov       byte ptr [r12+2E],0C
       mov       [r12+28],r13d
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF997E37768]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       jmp       near ptr M06_L06
M06_L22:
       mov       r9,[rbp+58]
       test      r9,r9
       jne       short M06_L23
       or        r14d,ebx
       jne       near ptr M06_L19
       xor       r15d,r15d
       xor       ebx,ebx
       jmp       short M06_L24
M06_L23:
       mov       ecx,r14d
       mov       edx,ebx
       add       rcx,rdx
       mov       edx,[r9+8]
       cmp       rcx,rdx
       ja        near ptr M06_L19
       mov       ecx,r14d
       lea       r15,[r9+rcx*2+0C]
M06_L24:
       xor       r14d,r14d
       jmp       short M06_L26
M06_L25:
       movzx     ecx,word ptr [r15+r14*2]
       mov       r13,[rbp+48]
       lea       r9,[rbp+8C]
       mov       edx,[rbp+0A0]
       mov       r8,[rbp+60]
       call      qword ptr [7FF997E37750]; System.Text.RegularExpressions.RegexNode.CreateOneWithCaseConversion(Char, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Text.RegularExpressions.RegexCaseBehavior ByRef)
       mov       rdx,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF997E37768]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       inc       r14d
M06_L26:
       cmp       r14d,ebx
       jl        short M06_L25
       jmp       near ptr M06_L06
M06_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L28:
       mov       ecx,[rbp+88]
       inc       ecx
       mov       [rbp+88],ecx
       mov       rbx,[rbp+48]
       lea       rcx,[rbp+30]
       call      qword ptr [7FF997EDD1D0]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF997E37768]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       xor       ecx,ecx
       mov       [rbp+50],rcx
       jmp       near ptr M06_L01
M06_L29:
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       jne       short M06_L33
M06_L30:
       mov       rax,r14
       mov       r8,610F88586345
       cmp       [rbp+8],r8
       je        short M06_L31
       call      CORINFO_HELP_FAIL_FAST
M06_L31:
       nop
       lea       rsp,[rbp+0C8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L32:
       call      qword ptr [7FF997A35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M06_L00
M06_L33:
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,25678001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DBC1F0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M06_L30
       sub       rsp,28
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       je        short M06_L34
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,25678001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF997DBC1F0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M06_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1585
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1C8
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M07_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M07_L00
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M07_L131
       mov       ecx,[rbx+8]
       mov       rax,rbx
M07_L01:
       mov       [rbp-70],rbx
       mov       [rbp+20],rdi
       mov       [rbp-68],rdi
       mov       rdx,2970CFA0D90
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       [rbp+18],rbx
       mov       r14,rbx
       mov       rcx,25678002160
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M07_L132
M07_L02:
       mov       [rbp-128],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M07_L130
       xor       r13d,r13d
       xor       r12d,r12d
M07_L03:
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M07_L133
M07_L04:
       mov       [rbp-138],rdx
       mov       [rbp-130],rdx
       lea       rcx,[rdx+8]
       mov       [rbp-120],r14
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-130]
       call      qword ptr [7FF997E37C00]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
       jmp       near ptr M07_L34
M07_L05:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-1C8],rax
       test      rax,rax
       je        near ptr M07_L69
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       [rbp-150],rsi
       mov       r8,[rbp-1C8]
       mov       [rbp-160],r8
       mov       esi,[rsi+44]
       mov       r10,[rbp-138]
       mov       r9,[r10+8]
       mov       [rbp-158],r9
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-168],rax
       mov       rdx,[rbp-148]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-148]
       mov       [rdx+10],rcx
       lea       rcx,[rdx+18]
       mov       rdx,[rbp-168]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-148]
       mov       [rdx+30],ecx
       mov       rcx,2970CF90C00
       mov       [rdx+28],rcx
       lea       rcx,[rdx+40]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,[rbp-148]
       lea       rcx,[rdx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[][]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,[rbp-148]
       lea       rcx,[rsi+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+48]
       mov       r8,[rsi+18]
       xor       edx,edx
       call      qword ptr [7FF9978157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       [rsi+5C],r12d
       mov       byte ptr [rsi+60],0
       lea       rcx,[rsi+68]
       mov       rdx,[rbp-160]
       call      CORINFO_HELP_ASSIGN_REF
M07_L06:
       mov       rax,[rbp-138]
       lea       rcx,[rax+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L37
M07_L07:
       lea       r11d,[rdx-10]
       movsxd    r11,r11d
       lea       r11,[rcx+r11*2]
       cmp       r9,r11
       ja        near ptr M07_L75
M07_L08:
       vmovups   ymm1,[r9]
       vpminuw   ymm1,ymm1,[7FF9978BC060]
       vmovups   ymm2,[r11]
       vpminuw   ymm2,ymm2,[7FF9978BC060]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9978BC080]
       vbroadcastsd ymm2,qword ptr [7FF9978BC0A0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L77
       vpermq    ymm0,ymm0,0D8
       vpmovmskb edi,ymm0
       tzcnt     edi,edi
       cmp       edi,10
       jge       near ptr M07_L76
M07_L09:
       sub       r9,rcx
       shr       r9,1
       add       r9d,edi
       jmp       near ptr M07_L41
M07_L10:
       vmovups   xmm0,[rdi]
       lea       r9d,[rdx-8]
       movsxd    r9,r9d
       lea       r9,[rcx+r9*2]
       cmp       rcx,r9
       ja        near ptr M07_L78
       mov       r11,rcx
M07_L11:
       vmovups   xmm1,[r11]
       vpminuw   xmm1,xmm1,[7FF9978BC060]
       vmovups   xmm2,[r9]
       vpminuw   xmm2,xmm2,[7FF9978BC060]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9978BC080]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9978BC0A0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L77
       vpmovmskb edi,xmm0
       tzcnt     edi,edi
       cmp       edi,8
       jge       near ptr M07_L79
M07_L12:
       sub       r11,rcx
       shr       r11,1
       lea       r9d,[r11+rdi]
       jmp       near ptr M07_L41
M07_L13:
       mov       r9d,edi
       lea       rcx,[rcx+r9*2]
       mov       [rbp-98],edi
       sub       edx,edi
       mov       r9d,[rbp-98]
M07_L14:
       mov       r11,rcx
       add       r8,88
       cmp       edx,10
       jge       near ptr M07_L80
       mov       ecx,edx
       lea       rcx,[r11+rcx*2]
       mov       rdx,r11
       mov       rdi,[r8]
       mov       r8d,[r8+10]
       mov       [rbp-9C],r8d
       cmp       r11,rcx
       je        short M07_L16
M07_L15:
       movzx     r14d,word ptr [rdx]
       mov       ebx,r8d
       imul      ebx,r14d
       mov       r8d,[rdi+8]
       imul      r8,rbx
       shr       r8,20
       movzx     r8d,word ptr [rdi+r8*2+10]
       cmp       r8d,r14d
       je        near ptr M07_L81
       add       rdx,2
       cmp       rdx,rcx
       mov       r8d,[rbp-9C]
       jne       short M07_L15
M07_L16:
       mov       r8d,0FFFFFFFF
M07_L17:
       mov       edx,r8d
       test      edx,edx
       jl        short M07_L18
       lea       edx,[r8+r9]
M07_L18:
       mov       r9d,edx
       jmp       near ptr M07_L42
M07_L19:
       mov       edi,r11d
       shr       edi,9
       mov       r14,7FF9EED07080
       movzx     edi,byte ptr [r14+rdi]
       shl       edi,6
       mov       r14d,r11d
       shr       r14d,3
       and       r14d,3E
       add       edi,r14d
       mov       r14,7FF9EED04B88
       movzx     edi,word ptr [r14+rdi]
       shl       edi,4
       and       r11d,0F
       add       r11d,edi
       mov       rdi,7FF9EED0CE60
       movzx     r11d,byte ptr [rdi+r11]
       mov       rdi,7FF9EED15930
       cmp       byte ptr [rdi+r11],0
       jl        near ptr M07_L44
M07_L20:
       test      r8d,r8d
       je        near ptr M07_L82
       cmp       r8d,ecx
       ja        near ptr M07_L103
       add       r8d,r9d
       mov       [rax+4C],r8d
       mov       r10d,r9d
       mov       r11d,r8d
       cmp       r11d,r10d
       jl        near ptr M07_L83
M07_L21:
       cmp       dword ptr [rax+58],0
       jne       near ptr M07_L25
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       mov       r8,[rax+20]
       mov       [rbp-1D0],r8
       mov       edx,[r8+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-180],rax
       mov       rcx,[rbp-1D0]
       mov       rdx,rcx
       mov       [rbp-188],rdx
       mov       r10d,[rcx+8]
       mov       [rbp-0A8],r10d
       mov       r9d,[rcx+8]
       mov       [rbp-0AC],r9d
       test      rdx,rdx
       je        near ptr M07_L104
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M07_L53
       cmp       dword ptr [rcx+4],18
       jne       near ptr M07_L53
       cmp       r9d,[rdx+8]
       ja        near ptr M07_L53
       lea       r8d,[r10+r9]
       cmp       r8d,[rax+8]
       ja        near ptr M07_L53
       movzx     r8d,word ptr [rcx]
       mov       r9d,r9d
       imul      r9,r8
       add       rdx,10
       mov       r10d,r10d
       imul      r8,r10
       lea       r10,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        near ptr M07_L45
       cmp       r9,4000
       jbe       short M07_L22
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF997ED5038]
       jmp       short M07_L24
M07_L22:
       mov       rcx,r10
       mov       r8,r9
       call      00007FF9F73FDC70
       cmp       dword ptr [7FF9F7753B10],0
       jne       near ptr M07_L84
M07_L23:
       cmp       dword ptr [7FF9F7753B10],0
       jne       near ptr M07_L85
M07_L24:
       mov       rax,[rbp-178]
       mov       rcx,[rax+20]
       mov       ecx,[rcx+8]
       add       [rax+58],ecx
       lea       rcx,[rax+20]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-178]
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
M07_L25:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M07_L110
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       rax,[rax+28]
       mov       [rbp-190],rax
       mov       r8,[rax+48]
       mov       [rbp-198],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M07_L110
       cmp       qword ptr [r8+10],0
       je        near ptr M07_L95
M07_L26:
       mov       rax,[rbp-190]
       mov       r8,[rax+48]
       mov       [rbp-1A0],r8
       mov       rax,[rax+50]
       mov       [rbp-1A8],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M07_L110
       mov       r9d,[rax+10]
       mov       [rbp-0C0],r9d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M07_L110
       mov       rdx,[r8+10]
       lea       ecx,[r9*2+2]
       cmp       [rdx+8],ecx
       jl        near ptr M07_L96
M07_L27:
       cmp       dword ptr [r8+8],0
       jbe       near ptr M07_L110
       mov       rdx,[r8+10]
       mov       rcx,rdx
       lea       r8d,[r9+r9]
       cmp       r8d,[rcx+8]
       jae       near ptr M07_L110
       lea       r8d,[r9+r9]
       mov       [rcx+r8*4+10],r10d
       lea       ecx,[r9*2+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M07_L110
       sub       r11d,r10d
       mov       [rdx+rcx*4+10],r11d
       mov       rax,[rbp-1A8]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M07_L110
       inc       r9d
       mov       [rax+10],r9d
M07_L28:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M07_L110
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M07_L66
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M07_L110
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M07_L110
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M07_L110
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M07_L29:
       mov       [rbp-170],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M07_L111
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M07_L100
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M07_L67
       cmp       eax,[rcx+8]
       jae       near ptr M07_L110
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M07_L30:
       mov       r8,[rbp-170]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M07_L68
       cmp       eax,[rcx+8]
       jae       near ptr M07_L110
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M07_L31:
       mov       r8,[rbp-170]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M07_L111
M07_L32:
       mov       ecx,[rsi+4C]
       mov       eax,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M07_L101
M07_L33:
       mov       rdx,[rsi+10]
       mov       edx,[rdx+8]
       mov       [rsi+50],edx
       mov       rdx,[rsi+18]
       mov       edx,[rdx+8]
       mov       [rsi+54],edx
       mov       rdx,[rsi+20]
       mov       edx,[rdx+8]
       mov       [rsi+58],edx
       mov       [rbp-88],eax
       mov       esi,ecx
M07_L34:
       mov       rdx,[rbp-138]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M07_L05
       mov       rax,[rdx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],r12d
       mov       rcx,[rsi+50]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       jle       short M07_L36
M07_L35:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M07_L35
M07_L36:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M07_L37
       xor       eax,eax
       mov       [rcx+18],rax
M07_L37:
       mov       rsi,[rbp-138]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M07_L70
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M07_L38:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FA092AC2DAA06EA382BA862B3355812DFC606B015100A61D8986FEC880F20C55B__SpacesRegex_18+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M07_L99
       mov       rax,rsi
       mov       [rbp-178],rax
M07_L39:
       mov       r10d,[rax+4C]
       mov       [rbp-94],r10d
       cmp       r10d,r12d
       jae       near ptr M07_L65
       mov       ecx,r10d
       lea       rcx,[r13+rcx*2]
       mov       edx,r12d
       sub       edx,r10d
       mov       r8,25678002130
       mov       r8,[r8]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M07_L14
       cmp       word ptr [rcx],7F
       ja        near ptr M07_L14
       mov       r9,rcx
       mov       r11d,edx
       lea       rdi,[r8+48]
       cmp       r11d,10
       jle       near ptr M07_L10
       vmovups   ymm0,[rdi]
       cmp       edx,20
       jle       near ptr M07_L07
       lea       r11d,[rdx-20]
       movsxd    r11,r11d
       lea       r11,[rcx+r11*2]
M07_L40:
       vmovups   ymm1,[r9]
       vpminuw   ymm1,ymm1,[7FF9978BC060]
       vmovups   ymm2,[r9+20]
       vpminuw   ymm2,ymm2,[7FF9978BC060]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9978BC080]
       vbroadcastsd ymm3,qword ptr [7FF9978BC0A0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       je        near ptr M07_L74
       mov       r11,r9
       sub       r11,rcx
       shr       r11,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       add       r9d,r11d
M07_L41:
       mov       edi,r9d
       cmp       edi,edx
       jae       short M07_L42
       mov       r11d,edi
       cmp       word ptr [rcx+r11*2],7F
       ja        near ptr M07_L13
M07_L42:
       test      r9d,r9d
       jl        near ptr M07_L65
       mov       r10d,[rbp-94]
       add       r10d,r9d
       mov       rax,[rbp-178]
       mov       [rax+4C],r10d
       mov       r8d,r10d
       mov       r9d,r8d
       cmp       r9d,r12d
       ja        near ptr M07_L103
       mov       r8d,r9d
       lea       rdx,[r13+r8*2]
       mov       ecx,r12d
       sub       ecx,r9d
       xor       r8d,r8d
M07_L43:
       cmp       r8d,ecx
       jae       near ptr M07_L20
       movzx     r11d,word ptr [rdx+r8*2]
       cmp       r11d,100
       jge       near ptr M07_L19
       cmp       r11d,100
       jae       near ptr M07_L110
       mov       r11d,r11d
       mov       rdi,7FF9EED06998
       test      byte ptr [rdi+r11],80
       je        near ptr M07_L20
M07_L44:
       inc       r8d
       jmp       short M07_L43
M07_L45:
       mov       rcx,r10
       mov       r8,rdx
       mov       r11,r9
       mov       rdi,rcx
       sub       rdi,r8
       cmp       rdi,r11
       jb        near ptr M07_L90
       mov       rdi,r8
       sub       rdi,rcx
       cmp       rdi,r11
       jb        near ptr M07_L90
       lea       rdi,[r8+r11]
       lea       r14,[rcx+r11]
       cmp       r11,10
       ja        short M07_L48
       test      r9b,18
       jne       short M07_L47
       test      r9b,4
       jne       short M07_L46
       test      r9,r9
       je        near ptr M07_L24
       movzx     edx,byte ptr [rdx]
       mov       [r10],dl
       test      r9b,2
       je        near ptr M07_L24
       movsx     r10,word ptr [rdi-2]
       mov       [r14-2],r10w
       jmp       near ptr M07_L24
M07_L46:
       mov       edx,[rdx]
       mov       [r10],edx
       mov       r10d,[rdi-4]
       mov       [r14-4],r10d
       jmp       near ptr M07_L24
M07_L47:
       mov       r11,[rdx]
       mov       [r10],r11
       mov       r10,[rdi-8]
       mov       [r14-8],r10
       jmp       near ptr M07_L24
M07_L48:
       cmp       r11,40
       ja        near ptr M07_L87
M07_L49:
       vmovups   xmm0,[r8]
       vmovups   [rcx],xmm0
       cmp       r11,20
       ja        short M07_L52
M07_L50:
       vmovups   xmm0,[rdi-10]
       vmovups   [r14-10],xmm0
       jmp       near ptr M07_L24
M07_L51:
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       r8,40
       dec       r10
       jne       short M07_L51
       jmp       near ptr M07_L89
M07_L52:
       vmovups   xmm0,[r8+10]
       vmovups   [rcx+10],xmm0
       cmp       r11,30
       jbe       short M07_L50
       jmp       near ptr M07_L86
M07_L53:
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M07_L56
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M07_L92
       mov       r8d,1
M07_L54:
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M07_L93
       mov       r11d,1
M07_L55:
       cmp       r8d,r11d
       jne       near ptr M07_L105
M07_L56:
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M07_L60
       xor       r8d,r8d
M07_L57:
       test      r8d,r8d
       jg        near ptr M07_L106
       neg       r8d
       mov       [rbp-0B0],r8d
       test      r8d,r8d
       jl        near ptr M07_L107
       lea       ecx,[r8+r9]
       cmp       ecx,[rdx+8]
       ja        near ptr M07_L107
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M07_L61
       xor       r11d,r11d
M07_L58:
       cmp       r10d,r11d
       jl        near ptr M07_L108
       sub       r10d,r11d
       mov       [rbp-0B4],r10d
       test      r10d,r10d
       jl        near ptr M07_L109
       lea       ecx,[r10+r9]
       cmp       ecx,[rax+8]
       ja        near ptr M07_L109
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M07_L59
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF997ED5B18]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M07_L62
       mov       rax,[rbp-180]
       mov       rdx,[rbp-188]
M07_L59:
       mov       rcx,[rdx]
       movzx     r11d,word ptr [rcx]
       mov       r9d,[rbp-0AC]
       imul      r9,r11
       mov       r8d,[rbp-0B0]
       imul      r8,r11
       lea       rdx,[rdx+r8+10]
       mov       r8d,[rbp-0B4]
       imul      r8,r11
       lea       r10,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        short M07_L63
       cmp       r9,4000
       ja        near ptr M07_L64
       mov       rcx,r10
       mov       r8,r9
       call      00007FF9F73FDC70
       cmp       dword ptr [7FF9F7753B10],0
       je        near ptr M07_L23
       jmp       near ptr M07_L94
M07_L60:
       movsxd    r8,ecx
       mov       r8d,[rdx+r8*4+10]
       jmp       near ptr M07_L57
M07_L61:
       movsxd    r11,ecx
       mov       r11d,[rax+r11*4+10]
       jmp       near ptr M07_L58
M07_L62:
       mov       r10d,[rbp-0AC]
       mov       [rsp+20],r10d
       mov       [rsp+28],eax
       mov       rcx,[rbp-188]
       mov       edx,[rbp-0B0]
       mov       r8,[rbp-180]
       mov       r9d,[rbp-0B4]
       call      qword ptr [7FF997ED5B30]
       jmp       near ptr M07_L24
M07_L63:
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF997815818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L24
M07_L64:
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF997ED5038]
       jmp       near ptr M07_L24
M07_L65:
       mov       rax,[rbp-178]
       mov       [rax+4C],r12d
       jmp       near ptr M07_L28
M07_L66:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,25678002180
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M07_L29
M07_L67:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37FC0]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M07_L30
M07_L68:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37FC0]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M07_L31
M07_L69:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-138]
       mov       r9,[rsi+8]
       mov       rcx,rax
       call      qword ptr [7FF997E37D68]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rcx,[rbp-140]
       mov       rsi,rcx
       jmp       near ptr M07_L06
M07_L70:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M07_L71
       mov       r8d,20
M07_L71:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M07_L72
       mov       dword ptr [rbp-8C],10
M07_L72:
       mov       [rbp-90],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-90]
       mov       [rsi+50],edx
       movsxd    rdx,dword ptr [rbp-8C]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-8C]
       mov       [rsi+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       jmp       near ptr M07_L38
M07_L73:
       inc       r10d
       mov       [rax+4C],r10d
       jmp       near ptr M07_L39
M07_L74:
       add       r9,40
       cmp       r9,r11
       jb        near ptr M07_L40
       jmp       near ptr M07_L07
M07_L75:
       mov       r9,r11
       jmp       near ptr M07_L08
M07_L76:
       mov       r9,r11
       add       edi,0FFFFFFF0
       jmp       near ptr M07_L09
M07_L77:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M07_L41
M07_L78:
       mov       r11,r9
       jmp       near ptr M07_L11
M07_L79:
       mov       r11,r9
       add       edi,0FFFFFFF8
       jmp       near ptr M07_L12
M07_L80:
       mov       [rbp-98],r9d
       call      qword ptr [7FF997E3C048]; System.Buffers.ProbabilisticMap.IndexOfAnyVectorized[[System.Buffers.SearchValues+TrueConst, System.Private.CoreLib]](Char ByRef, Int32, System.Buffers.ProbabilisticMapState ByRef)
       mov       r8d,eax
       mov       r9d,[rbp-98]
       jmp       near ptr M07_L17
M07_L81:
       mov       r8,rdx
       sub       r8,r11
       shr       r8,1
       jmp       near ptr M07_L17
M07_L82:
       cmp       [rax+4C],r12d
       jne       short M07_L73
       jmp       near ptr M07_L28
M07_L83:
       mov       [rbp-0A0],r9d
       mov       [rbp-0A4],r8d
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M07_L21
M07_L84:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L23
M07_L85:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L24
M07_L86:
       vmovups   xmm0,[r8+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M07_L50
M07_L87:
       cmp       r11,800
       ja        short M07_L91
       cmp       r11,100
       jb        short M07_L88
       mov       r8,r10
       and       r8,3F
       mov       r11,r8
       neg       r11
       add       r11,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [r10],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [r10+20],ymm0
       add       rdx,r11
       mov       r8,rdx
       lea       rcx,[r10+r11]
       sub       r9,r11
       mov       r11,r9
M07_L88:
       mov       r10,r11
       shr       r10,6
       jmp       near ptr M07_L51
M07_L89:
       and       r11,3F
       cmp       r11,10
       ja        near ptr M07_L49
       jmp       near ptr M07_L50
M07_L90:
       cmp       r10,rdx
       jne       short M07_L91
       cmp       [rdx],dl
       jmp       near ptr M07_L24
M07_L91:
       cmp       [r10],r10b
       cmp       [rdx],dl
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF9978166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L24
M07_L92:
       mov       r8d,ecx
       jmp       near ptr M07_L54
M07_L93:
       mov       r11d,ecx
       jmp       near ptr M07_L55
M07_L94:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L23
M07_L95:
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-198]
       xor       edx,edx
       call      qword ptr [7FF9978157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M07_L26
M07_L96:
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M07_L110
       mov       rcx,[r8+10]
       mov       [rbp-1B0],rcx
       lea       edx,[r9*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M07_L98
M07_L97:
       mov       r8,[rbp-1B0]
       cmp       ecx,[r8+8]
       jae       near ptr M07_L110
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M07_L110
       mov       [rax+rcx*4+10],edx
       inc       ecx
M07_L98:
       mov       r10d,[rbp-0C0]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M07_L97
       mov       rcx,[rbp-1A0]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9978157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r8,[rbp-1A0]
       mov       r9d,[rbp-0C0]
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M07_L27
M07_L99:
       mov       [rbp-0F0],r13
       mov       [rbp-0E8],r12d
       lea       rdx,[rbp-0F0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L28
M07_L100:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-170]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-170]
       je        near ptr M07_L111
       jmp       near ptr M07_L32
M07_L101:
       mov       eax,r12d
       mov       edx,1
       mov       r8,[rbp-128]
       test      byte ptr [r8+40],40
       je        short M07_L102
       xor       eax,eax
       mov       edx,0FFFFFFFF
M07_L102:
       cmp       ecx,eax
       je        near ptr M07_L111
       lea       eax,[rcx+rdx]
       jmp       near ptr M07_L33
M07_L103:
       call      qword ptr [7FF997987198]
       int       3
M07_L104:
       mov       ecx,12D
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       rcx,rax
       call      qword ptr [7FF997ED4E28]
       int       3
M07_L105:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED5B48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997ED5B60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L106:
       mov       [rbp-0B8],r8d
       mov       ecx,167
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       edx,[rbp-0B8]
       xor       ecx,ecx
       call      qword ptr [7FF997ED5AD0]
       int       3
M07_L107:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF997ED5B78]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF997B96010]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M07_L108:
       mov       [rbp-0BC],r11d
       mov       ecx,17F
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       edx,[rbp-0BC]
       mov       ecx,[rbp-0A8]
       call      qword ptr [7FF997ED5AD0]
       int       3
M07_L109:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED5B90]
       mov       rdi,rax
       mov       ecx,145
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF997B96010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L110:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L111:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-128]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       mov       r14,[rbp-120]
       je        near ptr M07_L119
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M07_L128
       cmp       eax,[rcx+8]
       jae       near ptr M07_L158
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M07_L112:
       mov       rbx,[rbp+18]
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M07_L129
       cmp       eax,[rcx+8]
       jae       near ptr M07_L158
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M07_L113:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M07_L134
       cmp       [rax+8],ecx
       jb        near ptr M07_L135
       add       rax,10
M07_L114:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       mov       rdi,[rbp+20]
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M07_L116
M07_L115:
       cmp       edx,ecx
       jae       near ptr M07_L158
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M07_L115
M07_L116:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,25678002168
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M07_L136
M07_L117:
       test      rsi,rsi
       je        near ptr M07_L127
       test      r14d,r14d
       jle       near ptr M07_L125
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF9F7494CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rdx,[r15+0C]
       mov       [rbp-100],rdx
       mov       [rbp-0F8],r14d
       mov       [rbp-118],rbx
       mov       [rbp-110],rdi
       lea       rdx,[rbp-80]
       mov       [rbp-108],rdx
       lea       rdx,[rbp-100]
       lea       r8,[rbp-118]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M07_L118:
       mov       r14,r15
M07_L119:
       cmp       qword ptr [rbp-58],0
       je        near ptr M07_L124
       mov       rcx,25678001CE8
       mov       rbx,[rcx]
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M07_L137
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M07_L137
M07_L120:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M07_L138
M07_L121:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M07_L122
       mov       r15d,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rsi+8],edx
       jne       near ptr M07_L139
       cmp       edi,ecx
       jae       near ptr M07_L158
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-1B8],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-1B8]
       test      r12,r12
       jne       near ptr M07_L140
M07_L122:
       mov       rcx,25678000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M07_L155
M07_L123:
       xor       eax,eax
       mov       [rbp-58],rax
M07_L124:
       mov       rax,r14
       vzeroupper
       add       rsp,1C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L125:
       test      r14d,r14d
       je        short M07_L126
       mov       ecx,28
       call      qword ptr [7FF997A378D0]
       int       3
M07_L126:
       mov       r15,2970CF90008
       jmp       near ptr M07_L118
M07_L127:
       mov       ecx,1C
       call      qword ptr [7FF997A3C228]
       int       3
M07_L128:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37FC0]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M07_L112
M07_L129:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF997E37FC0]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M07_L113
M07_L130:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M07_L03
M07_L131:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M07_L01
M07_L132:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,25678002158
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25678002160
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L02
M07_L133:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M07_L04
M07_L134:
       test      ecx,ecx
       jne       short M07_L135
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M07_L114
M07_L135:
       call      qword ptr [7FF997987198]
       int       3
M07_L136:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25678002158
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25678002168
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L117
M07_L137:
       mov       ecx,7
       call      qword ptr [7FF997ED4D50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M07_L120
M07_L138:
       mov       rcx,rbx
       call      qword ptr [7FF997D96C58]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M07_L121
M07_L139:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF997ED4D80]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF997754000
       call      qword ptr [7FF997A37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF997B96010]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L140:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M07_L158
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M07_L141
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF997ED4D98]
M07_L141:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF997815740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF99775B17C],0
       je        short M07_L142
       call      qword ptr [7FF997ED4DB0]
       mov       edx,eax
       mov       [rbp-0D4],edx
       jmp       short M07_L144
M07_L142:
       mov       ecx,9
       call      qword ptr [7FF997ED4DC8]
       mov       eax,[rax+10]
       mov       [rbp-0D8],eax
       mov       ecx,9
       call      qword ptr [7FF997ED4DC8]
       mov       edx,[rbp-0D8]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M07_L143
       call      qword ptr [7FF997ED4DE0]
       mov       edx,eax
       mov       [rbp-0D4],edx
       jmp       short M07_L144
M07_L143:
       sar       edx,10
       mov       [rbp-0D4],edx
M07_L144:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF997815740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0D4]
       xor       edx,edx
       div       dword ptr [7FF99775B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M07_L151
M07_L145:
       cmp       eax,[r13+8]
       jae       near ptr M07_L158
       mov       [rbp-0CC],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-1C0],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0DC],r10d
       mov       rcx,r8
       call      qword ptr [7FF997D1D470]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1C0]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0E0],r8d
       cmp       [rcx+8],r8d
       jbe       short M07_L147
       test      r8d,r8d
       jne       short M07_L148
       xor       edx,edx
       mov       [rax+14],edx
M07_L146:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0E0]
       inc       ecx
       mov       rax,[rbp-1C0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0DC],1
M07_L147:
       mov       rcx,rax
       call      qword ptr [7FF997816820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0DC],0
       je        short M07_L149
       jmp       short M07_L152
M07_L148:
       jmp       short M07_L146
M07_L149:
       mov       eax,[rbp-0CC]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M07_L150
       xor       ecx,ecx
M07_L150:
       mov       edx,[rbp-0D0]
       inc       edx
       mov       eax,ecx
M07_L151:
       mov       [rbp-0D0],edx
       cmp       [r13+8],edx
       jg        near ptr M07_L145
       jmp       short M07_L153
M07_L152:
       mov       r13d,1
       jmp       short M07_L154
M07_L153:
       xor       r13d,r13d
M07_L154:
       jmp       near ptr M07_L122
M07_L155:
       cmp       dword ptr [rsi+8],0
       je        near ptr M07_L123
       mov       rcx,rsi
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0C4],eax
       mov       edx,[rsi+8]
       mov       [rbp-0C8],edx
       mov       rcx,rbx
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-0C4]
       mov       r9d,[rbp-0C8]
       mov       edx,3
       call      qword ptr [7FF997ED4DF8]
       test      r13d,r15d
       jne       near ptr M07_L123
       mov       rcx,rsi
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF997C2CB58]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M07_L156
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M07_L157
M07_L156:
       mov       ecx,edi
       xor       edx,edx
M07_L157:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF997ED4E10]
       jmp       near ptr M07_L123
M07_L158:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-138]
       mov       [rsi+8],rcx
       mov       r8,[rbp-128]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 6411
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF9EF990CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M08_L01
       cmp       [rax],ecx
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M08_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],edx
       jle       short M08_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M08_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M09_L00
       cmp       [rdx],rcx
       jne       short M09_L01
M09_L00:
       mov       rax,rdx
       ret
M09_L01:
       jmp       qword ptr [7FF99781FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       byte ptr [rbx],0
       je        short M10_L00
       call      qword ptr [7FF9EF990BF0]
       int       3
M10_L00:
       test      rsi,rsi
       je        short M10_L02
       mov       rcx,rsi
       call      qword ptr [7FF9EF990BB0]
       test      eax,eax
       jne       short M10_L01
       mov       rcx,rsi
       call      qword ptr [7FF9EF990BC0]
M10_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L02:
       xor       ecx,ecx
       call      qword ptr [7FF9EF98B1E8]
       int       3
; Total bytes of code 70
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      00007FF9F749DA00
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FF997ED4E28]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF997ED4E40]
; Total bytes of code 56
```
```assembly
; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       movzx     edi,r8b
       test      edi,edi
       setne     bpl
       movzx     ebp,bpl
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993528]
       test      rax,rax
       je        short M12_L04
M12_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M12_L02
       mov       rcx,rbx
       call      qword ptr [7FF9EF9860A0]
       test      rax,rax
       jne       short M12_L06
       call      qword ptr [7FF9EF9783F0]
       cmp       qword ptr [rax+8],0
       jne       short M12_L05
       xor       edi,edi
M12_L01:
       test      edi,edi
       jne       short M12_L06
M12_L02:
       xor       eax,eax
M12_L03:
       test      rax,rax
       jne       short M12_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF9EF993530]
       jmp       short M12_L00
M12_L05:
       call      qword ptr [7FF9EF9783F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M12_L01
M12_L06:
       mov       rcx,rbx
       call      qword ptr [7FF9EF989690]
       jmp       short M12_L03
M12_L07:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 183
```

