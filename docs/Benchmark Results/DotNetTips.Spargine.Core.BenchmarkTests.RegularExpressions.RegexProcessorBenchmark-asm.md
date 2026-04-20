## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2190CC020F8
       mov       rsi,[rcx]
       mov       edi,0E
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,259A19F06C0
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
       call      qword ptr [7FFE9888F138]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE988EBD78],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,2190CC021B0
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
       call      qword ptr [7FFE9888F1C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE9888F1C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98906DD8]
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
       jmp       qword ptr [7FFE98906E08]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98235C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2529E400100
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
       call      qword ptr [7FFE9888F060]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE988EB4D8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,2529E4001B8
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
       call      qword ptr [7FFE9888F0F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE9888F0F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFE98916D30]
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
; Total bytes of code 866
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFE98916D60]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98235C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,210ADC020D0
       mov       rsi,[rcx]
       mov       edi,10
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,25142A406C0
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
       call      qword ptr [7FFE988774B0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE988BC680],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,210ADC02168
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
       call      qword ptr [7FFE98877540]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98877540]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98255728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFE9887FBE8]
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
       jmp       qword ptr [7FFE9887FC18]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98255C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2582E800100
       mov       rsi,[rcx]
       mov       edi,3
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,298ADA006C0
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
       call      qword ptr [7FFE988BF180]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       mov       rcx,2582E800188
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
       call      qword ptr [7FFE988BF210]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE988BF210]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98936CA0]
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
       jmp       qword ptr [7FFE98936CD0]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,259800020F8
       mov       rsi,[rcx]
       mov       edi,13
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,259022206C0
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
       call      qword ptr [7FFE9888F120]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L08
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
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FFE988EBD48],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,259800021B0
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
       mov       dword ptr [rsp+20],13
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9888F1B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],13
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9888F1B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98916F58]
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
       jmp       qword ptr [7FFE98916F88]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98235C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,217904020F8
       mov       rsi,[rcx]
       mov       edi,24
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,258255606C0
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
       call      qword ptr [7FFE988BF150]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L05
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
       mov       dword ptr [rsp+20],24
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE988BF1E0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       test      byte ptr [7FFE9891BD78],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,217904021B0
       mov       r14,[rcx]
M00_L09:
       jmp       near ptr M00_L14
M00_L10:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],24
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE988BF1E0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98936B80]
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
       jmp       qword ptr [7FFE98936BB0]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98265C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,22B3D4020F8
       mov       rsi,[rcx]
       mov       edi,0B
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,26BD23B06C0
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
       call      qword ptr [7FFE9889F168]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE9889F1F8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       test      byte ptr [7FFE988FBD78],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,22B3D4021B0
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
       call      qword ptr [7FFE9889F1F8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98916BF8]
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
       jmp       qword ptr [7FFE98916C28]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98245C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,207A6800100
       mov       rsi,[rcx]
       mov       edi,27
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,248256106C0
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
       call      qword ptr [7FFE988AF180]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE9890C470],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,207A68001B8
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
       call      qword ptr [7FFE988AF210]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE988AF210]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98926CD0]
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
       jmp       qword ptr [7FFE98926D00]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98255C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2213F0020F8
       mov       rsi,[rcx]
       mov       edi,0D
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,261D3FF06C0
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
       call      qword ptr [7FFE9889F060]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE988FBD48],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,2213F0021B0
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
       call      qword ptr [7FFE9889F0F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE9889F0F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98916CD0]
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
       jmp       qword ptr [7FFE98916D00]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98245C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,207BCC020D0
       mov       rsi,[rcx]
       mov       edi,11
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,24851BD06C0
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
       call      qword ptr [7FFE988473D8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE9888BEE0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,207BCC02168
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
       call      qword ptr [7FFE98847468]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98847468]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98225728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFE9884FAC8]
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
       jmp       qword ptr [7FFE9884FAF8]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98225C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1DBA1400100
       mov       rsi,[rcx]
       mov       edi,8
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,21C320606C0
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
       call      qword ptr [7FFE9887F198]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE988DBD58],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1DBA14001B8
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
       call      qword ptr [7FFE9887F228]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE9887F228]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98906D18]
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
       jmp       qword ptr [7FFE98906D48]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98225C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1A1BA4020F8
       mov       rsi,[rcx]
       mov       edi,28
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1E24F4F06C0
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
       call      qword ptr [7FFE9887F138]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L08
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
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FFE988DBEE0],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1A1BA4021B0
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
       mov       dword ptr [rsp+20],28
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9887F1C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],28
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9887F1C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98906F58]
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
       jmp       qword ptr [7FFE98906F88]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98225C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,254D34020F8
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,295683C06C0
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
       call      qword ptr [7FFE988AF1B0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FFE9890BD78],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,254D34021B0
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
       call      qword ptr [7FFE988AF240]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE988AF240]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FFE98926E98]
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
       jmp       qword ptr [7FFE98926EC8]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FFE98255C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,18229000100
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1C2A80F06C0
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
       call      qword ptr [7FFE9889F0A8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L05
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
       jle       short M00_L07
       xor       edx,edx
       mov       [rcx+8],rdx
       xor       edi,edi
       jmp       short M00_L08
M00_L05:
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
       call      qword ptr [7FFE9889F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L07:
       xor       edx,edx
       mov       [rcx+8],rdx
       mov       rcx,18229000188
       mov       rdi,[rcx]
M00_L08:
       jmp       near ptr M00_L12
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
       call      qword ptr [7FFE9889F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M00_L06
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
       call      qword ptr [7FFE98926E98]
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
       jmp       qword ptr [7FFE98926EC8]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1D05C401370
       cmp       qword ptr [rcx],0
       je        near ptr M00_L21
M00_L00:
       mov       rcx,1D05C401370
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L31
       mov       rcx,1D05C401378
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L02
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L22
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L22
M00_L01:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,1D05C400108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       call      qword ptr [7FFE98474138]; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rsi,rax
M00_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE98666598]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L25
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L24
       mov       rcx,rdi
       mov       rdx,210F13C06C0
       mov       r9d,1
       call      qword ptr [7FFE98666F88]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L23
M00_L03:
       test      r14,r14
       je        near ptr M00_L25
M00_L04:
       test      r14,r14
       je        near ptr M00_L34
       mov       rcx,1D05C4020D0
       mov       rbx,[rcx]
       mov       ecx,[r14+8]
       mov       esi,ecx
       xor       eax,eax
       test      byte ptr [rbx+40],40
       mov       edi,eax
       cmovne    edi,ecx
       mov       [rbp-60],rbx
       cmp       ecx,edi
       jb        near ptr M00_L32
       lea       rcx,[rbx+30]
       xor       eax,eax
       mov       r15,rax
       xchg      r15,[rcx]
       test      r15,r15
       je        near ptr M00_L33
M00_L05:
       mov       [rbp-68],r15
       mov       rdx,[rbx+48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE98877450]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L13
       mov       rdx,[r15+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+5C],esi
       mov       rcx,[rbx+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M00_L07
       add       rcx,10
M00_L06:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M00_L06
M00_L07:
       mov       byte ptr [rbx+60],0
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        short M00_L08
       xor       eax,eax
       mov       [rcx+18],rax
M00_L08:
       mov       rbx,[rbp-68]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M00_L17
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M00_L09:
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
       jbe       near ptr M00_L16
       cmp       dword ptr [rcx+10],0
       jg        short M00_L11
       xor       ecx,ecx
       mov       [rsi+8],rcx
       test      byte ptr [7FFE988BC250],1
       je        near ptr M00_L18
M00_L10:
       mov       rcx,1D05C402168
       mov       rdi,[rcx]
       jmp       short M00_L12
M00_L11:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       xor       edi,edi
M00_L12:
       jmp       near ptr M00_L19
M00_L13:
       mov       rcx,[r15+30]
       cmp       qword ptr [rcx+18],0
       je        short M00_L14
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
       call      qword ptr [7FFE989140F0]
       jmp       short M00_L15
M00_L14:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+20],esi
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,[r15+8]
       mov       rcx,rbx
       call      qword ptr [7FFE988774E0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L15:
       lea       rcx,[r15+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
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
       jmp       near ptr M00_L09
M00_L18:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L10
M00_L19:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       rax,[rbp-60]
       lea       rcx,[rax+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       sete      bl
       movzx     ebx,bl
M00_L20:
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
M00_L21:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,210F13BBBA8
       call      qword ptr [7FFE98914150]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,210F13BBB30
       call      qword ptr [7FFE98666010]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,1D05C401370
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       mov       ecx,2
       call      qword ptr [7FFE9887FE28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L23:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L24:
       mov       rcx,rdi
       mov       rdx,210F13C06C0
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FFE9887FE40]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-48],rsi
M00_L26:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE986D2410]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L29
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFE98398720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L29
       cmp       r14,rdi
       je        short M00_L26
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,210F13C06C0
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L27
       mov       rdi,r14
       jmp       short M00_L26
M00_L27:
       cmp       qword ptr [rbx+38],0
       je        short M00_L28
       mov       rdx,[rbx+38]
       mov       [rbp-58],rdx
       mov       byte ptr [rbp-30],0
       lea       rdx,[rbp-30]
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE98255998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        short M00_L28
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M00_L28:
       mov       [rbp-50],r15
       jmp       short M00_L30
M00_L29:
       xor       r8d,r8d
       mov       rcx,[rbp-48]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L30:
       call      M00_L36
       nop
       mov       r14,[rbp-50]
       jmp       near ptr M00_L04
M00_L31:
       mov       r8,1D05C401378
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,210F13C06C0
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L32:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE989140A8]
       int       3
M00_L33:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L34:
       xor       ebx,ebx
       jmp       near ptr M00_L20
       sub       rsp,38
       cmp       byte ptr [rbp-30],0
       je        short M00_L35
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M00_L35:
       nop
       add       rsp,38
       ret
M00_L36:
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
; Total bytes of code 1688
```
```assembly
; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rax,1D05C4000F8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFE98474150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
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
       je        short M02_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M02_L20
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L00:
       cmp       [rbx],rsi
       jne       near ptr M02_L22
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M02_L21
M02_L01:
       cmp       rdi,rdx
       jne       near ptr M02_L16
M02_L02:
       mov       rax,1D05C400100
       mov       rax,[rax]
       mov       [rbp+18],rax
M02_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L25
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M02_L04
       call      qword ptr [7FFE9887FE88]
       int       3
M02_L04:
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2D60
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE9887FEA0]
M02_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M02_L12
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M02_L11
M02_L06:
       mov       rax,[rbp+10]
       mov       rdx,[rax+38]
       mov       rdx,[rdx+8]
       cmp       rcx,rdx
       jne       short M02_L08
M02_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M02_L14
M02_L08:
       test      rcx,rcx
       je        near ptr M02_L13
       test      rdx,rdx
       je        near ptr M02_L13
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M02_L13
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L09
       call      qword ptr [7FFE9825FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L10
M02_L09:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M02_L10:
       test      eax,eax
       je        near ptr M02_L23
       jmp       short M02_L07
M02_L11:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,210F13B0008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M02_L06
M02_L12:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L13:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M02_L10
M02_L14:
       cmp       byte ptr [rbp-28],0
       je        short M02_L15
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       near ptr M02_L24
M02_L15:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       test      rdi,rdi
       je        near ptr M02_L03
       test      rdx,rdx
       je        near ptr M02_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M02_L03
       lea       rax,[rdi+0C]
       add       rdx,0C
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L17
       mov       rcx,rax
       call      qword ptr [7FFE9825FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L18
M02_L17:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M02_L18:
       test      eax,eax
       je        near ptr M02_L03
       jmp       near ptr M02_L02
M02_L19:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,210F13B0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L20:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M02_L22
M02_L21:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,210F13B0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L01
M02_L22:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L23:
       call      M02_L29
       jmp       short M02_L25
M02_L24:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFE9887FC30]
       jmp       near ptr M02_L15
M02_L25:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M02_L26
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FFE98255998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FFE9829AC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M02_L26
       mov       rcx,rbx
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M02_L26:
       cmp       qword ptr [rbp-20],0
       je        near ptr M02_L28
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M02_L27
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98255998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        short M02_L27
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M02_L27:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L28:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L29:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L30
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2C80
       test      eax,eax
       je        short M02_L30
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFE9887FC30]
M02_L30:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L31
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M02_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L32
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M02_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 1110
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
       je        near ptr M03_L26
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M03_L27
       test      rbx,rbx
       je        near ptr M03_L27
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M03_L00
       call      qword ptr [7FFE9887FE88]
       int       3
M03_L00:
       mov       rcx,rbx
       call      00007FFEF7EE2D60
       test      eax,eax
       jne       short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FFE9887FEA0]
M03_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L18
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M03_L13
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M03_L03
       lea       r11,[rdx+0C]
M03_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M03_L02
M03_L03:
       mov       r14d,ecx
M03_L04:
       mov       rcx,[rbx+8]
       mov       r8d,r14d
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M03_L22
       mov       r8d,r8d
       lea       rcx,[rcx+r8*4+10]
       mov       r15d,[rcx]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M03_L18
M03_L05:
       mov       ecx,r15d
       shl       rcx,5
       lea       r15,[r13+rcx+10]
       cmp       [r15+8],r14d
       jne       near ptr M03_L17
       mov       r10,[r15]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M03_L16
       cmp       r10,rdx
       jne       short M03_L09
       mov       r9d,1
M03_L06:
       test      r9d,r9d
       je        near ptr M03_L17
       add       r15,10
M03_L07:
       test      r15,r15
       je        near ptr M03_L12
       vmovdqu   xmm0,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M03_L19
M03_L08:
       mov       [rbp-80],rsi
       jmp       near ptr M03_L24
M03_L09:
       test      r10,r10
       je        near ptr M03_L15
       mov       ecx,[r10+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       near ptr M03_L15
       lea       rcx,[r10+0C]
       lea       r9,[rdx+0C]
       mov       r8d,[r10+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L10
       mov       rdx,r9
       call      qword ptr [7FFE9825FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M03_L11
M03_L10:
       mov       rdx,[rbp+18]
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r9]
       xor       r8,r11
       xor       rcx,[r9+2]
       or        rcx,r8
       sete      r9b
       movzx     r9d,r9b
M03_L11:
       jmp       near ptr M03_L06
M03_L12:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FFE98667000]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M03_L23
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE98667078]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFE98667138]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L08
M03_L13:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FFE981A09B8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L04
M03_L14:
       cmp       eax,r15d
       jbe       short M03_L18
       jmp       near ptr M03_L05
M03_L15:
       xor       r9d,r9d
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FFE981A09C0
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L06
M03_L17:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M03_L14
       call      qword ptr [7FFE98477A20]
       int       3
M03_L18:
       xor       r15d,r15d
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L07
M03_L19:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M03_L20
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE9887FF00]
       jmp       short M03_L21
M03_L20:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE987D6B38]; System.Resources.ResourceReader.LoadString(Int32)
M03_L21:
       mov       [rbp-80],rax
       jmp       short M03_L24
M03_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L23:
       call      M03_L40
       jmp       near ptr M03_L29
M03_L24:
       cmp       byte ptr [rbp-50],0
       je        short M03_L25
       mov       rcx,[rbp-78]
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       short M03_L28
M03_L25:
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
M03_L26:
       mov       ecx,13BFC
       mov       rdx,7FFE98194000
       call      qword ptr [7FFE984777B0]
       mov       rcx,rax
       call      qword ptr [7FFE9887FC18]
       int       3
M03_L27:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9887FED0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE9887FEE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L28:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE9887FC30]
       jmp       short M03_L25
M03_L29:
       cmp       byte ptr [rbp+20],0
       jne       short M03_L30
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
M03_L30:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M03_L31
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,1D05C400070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE98666E38]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M03_L31:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFE98255998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M03_L34
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFE9887FF18]
       jmp       short M03_L33
M03_L32:
       mov       rcx,rsi
       call      qword ptr [7FFE986D8358]
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
       call      qword ptr [7FFE98667138]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M03_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE986D8350]
       test      eax,eax
       jne       short M03_L32
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE986D66E0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M03_L35
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M03_L38
M03_L35:
       cmp       qword ptr [rbp-48],0
       je        short M03_L36
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M03_L38
M03_L36:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FFE98667078]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M03_L37
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFE98667138]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M03_L37:
       cmp       byte ptr [rbp-50],0
       je        short M03_L39
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M03_L39
M03_L38:
       call      M03_L42
       jmp       near ptr M03_L25
M03_L39:
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
M03_L40:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L41
       mov       rcx,[rbp-78]
       call      00007FFEF7EE2C80
       test      eax,eax
       je        short M03_L41
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE9887FC30]
M03_L41:
       nop
       add       rsp,28
       ret
M03_L42:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L43
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE98256820]; System.Threading.Monitor.Exit(System.Object)
M03_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1407
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFE989140D8]
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
       call      qword ptr [7FFF24FC6E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFF24FC8240]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFF24FC6E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFF24FC59C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFF24FC59E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFE98255C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M07_L00
       test      rsi,rsi
       je        short M07_L01
       mov       rcx,rsi
       call      qword ptr [7FFEF7CB25D0]
       test      rax,rax
       je        short M07_L02
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      qword ptr [7FFEF7CA3FE8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      qword ptr [7FFEF7CA3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFEF7CB71F0]
       int       3
M07_L01:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFEF7CB71F0]
       int       3
M07_L02:
       call      qword ptr [7FFEF7CAE538]
       mov       rbx,rax
       call      qword ptr [7FFEF7CB9268]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB7188]
       mov       rcx,rbx
       call      qword ptr [7FFEF7CA3FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFEF7CBCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE9825FD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       call      qword ptr [7FFEF7CBCBF8]
       int       3
M10_L00:
       test      rsi,rsi
       je        short M10_L02
       mov       rcx,rsi
       call      qword ptr [7FFEF7CBCBB8]
       test      eax,eax
       jne       short M10_L01
       mov       rcx,rsi
       call      qword ptr [7FFEF7CBCBC8]
M10_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEF7CB71F0]
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
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FFE9887FC18]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE9887FC30]
; Total bytes of code 56
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,158B0000128
       mov       rsi,[rcx]
       mov       edi,11
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       rbp,[rsi+38]
       test      rbp,rbp
       je        near ptr M00_L09
M00_L00:
       mov       r14,[rsi+18]
       mov       r15d,[rsi+44]
       mov       r13,[rsi+20]
       mov       r12d,[rsi+40]
       mov       rcx,[rbp+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L11
       test      cl,2
       jne       near ptr M00_L12
       mov       rax,[rcx]
M00_L01:
       test      rax,rax
       je        short M00_L02
       mov       [rsp+28],rax
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       mov       rdx,1992F120008
       cmp       rcx,rdx
       je        short M00_L06
       jmp       near ptr M00_L14
M00_L02:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,1992F120008
       call      qword ptr [7FFE98914D08]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L17
       test      r14,r14
       je        short M00_L03
       cmp       qword ptr [7FFE9817B020],0
       jne       near ptr M00_L18
M00_L03:
       xor       eax,eax
M00_L04:
       test      r15b,2
       jne       near ptr M00_L19
       test      rax,rax
       jne       near ptr M00_L19
       mov       rcx,r15
       mov       rdx,r14
       call      00007FFEF7E675D0
M00_L05:
       mov       [rsp+28],r14
M00_L06:
       mov       rax,[rsp+28]
       cmp       [rax],al
       mov       rbp,1992F1306C0
       mov       ecx,11
       cmp       ecx,edi
       jb        near ptr M00_L20
       test      byte ptr [rsi+40],40
       jne       near ptr M00_L22
       cmp       byte ptr [rax+20],0
       jne       near ptr M00_L22
       mov       rcx,[rax+10]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L21
       mov       r8,1992F120008
M00_L07:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE98914EB8]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L08:
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
M00_L09:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE98236D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L10
       call      qword ptr [7FFE9891DBA8]
       int       3
M00_L10:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFEF7E7CC60
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L01
M00_L12:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       rax,[rdx]
       test      rax,rax
       jne       short M00_L13
       mov       rdx,7FFE98A20B70
       call      qword ptr [7FFE98236E08]
M00_L13:
       jmp       near ptr M00_L01
M00_L14:
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L02
       lea       r10,[rcx+0C]
       mov       rdx,1992F120014
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M00_L15
       mov       r8,[r10]
       mov       r9,[r10+2]
       mov       rcx,[rdx]
       xor       r8,rcx
       xor       r9,[rdx+2]
       or        r8,r9
       sete      dl
       movzx     edx,dl
       mov       eax,edx
       jmp       short M00_L16
M00_L15:
       mov       rcx,r10
       call      qword ptr [7FFE9823FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L16:
       test      eax,eax
       jne       near ptr M00_L06
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9891FA38]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE985B6820]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       rax,[7FFE9817B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r14
       call      qword ptr [7FFE9891FA50]
       jmp       near ptr M00_L04
M00_L19:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FFE9891FA68]
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE9891E898]
       int       3
M00_L21:
       mov       r8,[rax+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L23
       mov       r8,[r8+10]
       jmp       near ptr M00_L07
M00_L22:
       mov       [rsp+20],edi
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE9891E8B0]
       jmp       near ptr M00_L08
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 779
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
       mov       rax,7DEF14B3C860
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M01_L07
       mov       rax,1589A000100
       mov       r15,[rax]
M01_L00:
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
M01_L01:
       mov       r9d,[rbp+68]
       mov       rcx,[rbp+38]
       cmp       r9d,[rcx+8]
       jl        short M01_L02
       mov       rdi,[rbp+28]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FFE98914D50]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M01_L04
M01_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FFE98657630]; System.String.IndexOf(Char, Int32, Int32)
       mov       [rbp+68],eax
       cmp       dword ptr [rbp+68],0
       jge       short M01_L03
       mov       r8,[rbp+38]
       mov       r8d,[r8+8]
       mov       [rbp+68],r8d
M01_L03:
       mov       r8d,[rbp+68]
       sub       r8d,edi
       lea       rcx,[rbp+10]
       mov       edx,edi
       mov       r9d,1
       call      qword ptr [7FFE98A656C8]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FFE98A656E0]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE98A656F8]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M01_L01
M01_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M01_L08
M01_L05:
       mov       rax,r14
       mov       r8,7DEF14B3C860
       cmp       [rbp+8],r8
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      qword ptr [7FFE98456688]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M01_L00
M01_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,1589A001D48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE98858BF0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M01_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,1589A001D48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE98858BF0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
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
       je        near ptr M02_L53
       mov       ecx,[rbx+8]
       mov       rax,rbx
M02_L00:
       mov       [rbp-70],rbx
       mov       [rbp-68],rdi
       mov       rdx,1992F130D98
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,158B00001C8
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M02_L54
M02_L01:
       mov       [rbp-0F8],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M02_L52
       xor       r13d,r13d
       xor       r12d,r12d
M02_L02:
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L55
M02_L03:
       mov       [rbp-108],rdx
       mov       [rbp-100],rdx
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-100]
       call      qword ptr [7FFE98915188]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
M02_L04:
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
       je        near ptr M02_L16
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
       jle       short M02_L06
       add       rcx,10
M02_L05:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M02_L05
M02_L06:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M02_L07
       xor       eax,eax
       mov       [rcx+18],rax
M02_L07:
       mov       rsi,[rbp-108]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L23
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M02_L08:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveHtmlRegex_14+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M02_L28
       mov       rax,rsi
       mov       [rbp-130],rax
       mov       r10d,[rax+4C]
       lea       ecx,[r12-3]
       cmp       r10d,ecx
       jg        near ptr M02_L18
M02_L09:
       cmp       r10d,r12d
       ja        near ptr M02_L32
       mov       ecx,r10d
       lea       rcx,[r13+rcx*2]
       mov       [rbp-94],r10d
       mov       r8d,r12d
       sub       r8d,r10d
       mov       edx,3C
       call      qword ptr [7FFE983A7798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jl        near ptr M02_L18
       mov       edx,[rbp-94]
       add       edx,eax
       mov       rax,[rbp-130]
       mov       [rax+4C],edx
       mov       [rbp-0C8],r13
       mov       [rbp-0C0],r12d
       lea       rdx,[rbp-0C8]
       mov       rcx,rax
       call      qword ptr [7FFE98915368]; System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveHtmlRegex_14+RunnerFactory+Runner.TryMatchAtCurrentPosition(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        near ptr M02_L27
M02_L10:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L33
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M02_L19
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L33
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M02_L33
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M02_L11:
       mov       [rbp-128],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M02_L34
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M02_L29
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L20
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L12:
       mov       r8,[rbp-128]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L21
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L13:
       mov       r8,[rbp-128]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M02_L34
M02_L14:
       mov       eax,[rsi+4C]
       mov       ecx,eax
       cmp       dword ptr [r8+14],0
       je        near ptr M02_L30
M02_L15:
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
       jmp       near ptr M02_L04
M02_L16:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-148],rax
       test      rax,rax
       je        near ptr M02_L22
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
       call      qword ptr [7FFE989152F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-118]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-118]
M02_L17:
       mov       rsi,[rbp-108]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L18:
       mov       rax,[rbp-130]
       mov       [rax+4C],r12d
       jmp       near ptr M02_L10
M02_L19:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,158B00001E8
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M02_L11
M02_L20:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE98915440]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L12
M02_L21:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE98915440]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L13
M02_L22:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-110],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-108]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-110]
       call      qword ptr [7FFE989152F0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-110]
       jmp       near ptr M02_L17
M02_L23:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M02_L24
       mov       r8d,20
M02_L24:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M02_L25
       mov       dword ptr [rbp-8C],10
M02_L25:
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
       jmp       near ptr M02_L08
M02_L26:
       inc       dword ptr [rdx+4C]
       mov       ecx,[rdx+4C]
       lea       eax,[r12-3]
       cmp       ecx,eax
       mov       r10d,ecx
       jg        near ptr M02_L18
       jmp       near ptr M02_L09
M02_L27:
       mov       rdx,[rbp-130]
       cmp       [rdx+4C],r12d
       jne       short M02_L26
       jmp       near ptr M02_L10
M02_L28:
       mov       [rbp-0C8],r13
       mov       [rbp-0C0],r12d
       lea       rdx,[rbp-0C8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L10
M02_L29:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-128]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-128]
       je        short M02_L34
       jmp       near ptr M02_L14
M02_L30:
       mov       ecx,r12d
       mov       edx,1
       mov       r8,[rbp-0F8]
       test      byte ptr [r8+40],40
       je        short M02_L31
       xor       ecx,ecx
       mov       edx,0FFFFFFFF
M02_L31:
       cmp       eax,ecx
       je        short M02_L34
       lea       ecx,[rax+rdx]
       jmp       near ptr M02_L15
M02_L32:
       call      qword ptr [7FFE983A7198]
       int       3
M02_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L34:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-0F8]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       je        near ptr M02_L42
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L50
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L35:
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L51
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L36:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M02_L56
       cmp       [rax+8],ecx
       jb        near ptr M02_L57
       add       rax,10
M02_L37:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M02_L39
M02_L38:
       cmp       edx,ecx
       jae       near ptr M02_L80
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M02_L38
M02_L39:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,158B00001D0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L58
M02_L40:
       test      r14d,r14d
       jle       near ptr M02_L48
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFEF7ED9F20
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
M02_L41:
       mov       r14,r15
M02_L42:
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L47
       mov       rcx,1589A001D48
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
       jle       near ptr M02_L59
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L59
M02_L43:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M02_L60
M02_L44:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],edi
       jbe       short M02_L45
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M02_L61
       cmp       edi,[rax+8]
       jae       near ptr M02_L80
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
       jne       near ptr M02_L62
M02_L45:
       mov       rcx,1589A000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L77
M02_L46:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M02_L47:
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
M02_L48:
       test      r14d,r14d
       je        short M02_L49
       mov       ecx,28
       call      qword ptr [7FFE9845C198]
       int       3
M02_L49:
       mov       r15,1992F120008
       jmp       near ptr M02_L41
M02_L50:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE98915440]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L35
M02_L51:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE98915440]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L36
M02_L52:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M02_L02
M02_L53:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L54:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,158B00001C0
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FFE98236BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,158B00001C8
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L55:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M02_L03
M02_L56:
       test      ecx,ecx
       jne       short M02_L57
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L37
M02_L57:
       call      qword ptr [7FFE983A7198]
       int       3
M02_L58:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,158B00001C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FFE98236BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,158B00001D0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L40
M02_L59:
       mov       ecx,7
       call      qword ptr [7FFE9891E0D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L43
M02_L60:
       mov       rcx,rbx
       call      qword ptr [7FFE988647B0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M02_L44
M02_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE9891E730]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE9845C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFE985B68C8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L62:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L80
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L63
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE9891E748]
M02_L63:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98235740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9817B1A4],0
       je        short M02_L64
       call      qword ptr [7FFE9891E760]
       mov       edx,eax
       mov       [rbp-0A8],edx
       jmp       short M02_L66
M02_L64:
       mov       ecx,9
       call      qword ptr [7FFE9891E778]
       mov       eax,[rax+10]
       mov       [rbp-0AC],eax
       mov       ecx,9
       call      qword ptr [7FFE9891E778]
       mov       edx,[rbp-0AC]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M02_L65
       call      qword ptr [7FFE9891E790]
       mov       edx,eax
       mov       [rbp-0A8],edx
       jmp       short M02_L66
M02_L65:
       sar       edx,10
       mov       [rbp-0A8],edx
M02_L66:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98235740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0A8]
       xor       edx,edx
       div       dword ptr [7FFE9817B198]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L73
M02_L67:
       cmp       eax,[r13+8]
       jae       near ptr M02_L80
       mov       [rbp-0A0],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-140],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0B0],r10d
       mov       rcx,r8
       call      qword ptr [7FFE987F4FC0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-140]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0B4],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L69
       test      r8d,r8d
       jne       short M02_L70
       xor       edx,edx
       mov       [rax+14],edx
M02_L68:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B4]
       inc       ecx
       mov       rax,[rbp-140]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0B0],1
M02_L69:
       mov       rcx,rax
       call      qword ptr [7FFE98236820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0B0],0
       je        short M02_L71
       jmp       short M02_L74
M02_L70:
       jmp       short M02_L68
M02_L71:
       mov       eax,[rbp-0A0]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M02_L72
       xor       ecx,ecx
M02_L72:
       mov       edx,[rbp-0A4]
       inc       edx
       mov       eax,ecx
M02_L73:
       mov       [rbp-0A4],edx
       cmp       [r13+8],edx
       jg        near ptr M02_L67
       jmp       short M02_L75
M02_L74:
       mov       r13d,1
       jmp       short M02_L76
M02_L75:
       xor       r13d,r13d
M02_L76:
       jmp       near ptr M02_L45
M02_L77:
       cmp       dword ptr [rsi+8],0
       je        near ptr M02_L46
       mov       rcx,rsi
       call      qword ptr [7FFE98744450]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-98],eax
       mov       edx,[rsi+8]
       mov       [rbp-9C],edx
       mov       rcx,rbx
       call      qword ptr [7FFE98744450]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-98]
       mov       r9d,[rbp-9C]
       mov       edx,3
       call      qword ptr [7FFE9891E568]
       test      r13d,r15d
       jne       near ptr M02_L46
       mov       rcx,rsi
       call      qword ptr [7FFE98744450]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE98744450]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L78
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L79
M02_L78:
       mov       ecx,edi
       xor       edx,edx
M02_L79:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FFE9891E7A8]
       jmp       near ptr M02_L46
M02_L80:
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
       call      qword ptr [7FFEF7CBF528]
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
       call      qword ptr [7FFEF7CB20A8]
       test      rax,rax
       jne       short M03_L06
       call      qword ptr [7FFEF7CA4408]
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
       call      qword ptr [7FFEF7CBF530]
       jmp       short M03_L00
M03_L05:
       call      qword ptr [7FFEF7CA4408]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB56A0]
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
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M04_L12
M04_L09:
       add       rax,10
       cmp       r8,rax
       jbe       short M04_L10
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M04_L12
       jmp       short M04_L09
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
; Total bytes of code 338
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,18EF90020F8
       mov       rsi,[rcx]
       mov       edi,0D
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       rbp,[rsi+38]
       test      rbp,rbp
       je        near ptr M00_L09
M00_L00:
       mov       r14,[rsi+18]
       mov       r15d,[rsi+44]
       mov       r13,[rsi+20]
       mov       r12d,[rsi+40]
       mov       rcx,[rbp+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L11
       test      cl,2
       jne       near ptr M00_L12
       mov       rax,[rcx]
M00_L01:
       test      rax,rax
       je        short M00_L02
       mov       [rsp+28],rax
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       mov       rdx,1CF8E120008
       cmp       rcx,rdx
       je        short M00_L06
       jmp       near ptr M00_L14
M00_L02:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,1CF8E120008
       call      qword ptr [7FFE9888F150]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L17
       test      r14,r14
       je        short M00_L03
       cmp       qword ptr [7FFE9817B020],0
       jne       near ptr M00_L18
M00_L03:
       xor       eax,eax
M00_L04:
       test      r15b,2
       jne       near ptr M00_L19
       test      rax,rax
       jne       near ptr M00_L19
       mov       rcx,r15
       mov       rdx,r14
       call      00007FFEF7E675D0
M00_L05:
       mov       [rsp+28],r14
M00_L06:
       mov       rax,[rsp+28]
       cmp       [rax],al
       mov       rbp,1CF8E1306C0
       mov       ecx,0D
       cmp       ecx,edi
       jb        near ptr M00_L20
       test      byte ptr [rsi+40],40
       jne       near ptr M00_L22
       cmp       byte ptr [rax+20],0
       jne       near ptr M00_L22
       mov       rcx,[rax+10]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L21
       mov       r8,1CF8E120008
M00_L07:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE9888F300]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L08:
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
M00_L09:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE98236D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L10
       call      qword ptr [7FFE98916820]
       int       3
M00_L10:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFEF7E7CC60
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L01
M00_L12:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       rax,[rdx]
       test      rax,rax
       jne       short M00_L13
       mov       rdx,7FFE98958A10
       call      qword ptr [7FFE98236E08]
M00_L13:
       jmp       near ptr M00_L01
M00_L14:
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L02
       lea       r10,[rcx+0C]
       mov       rdx,1CF8E120014
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M00_L15
       mov       r8,[r10]
       mov       r9,[r10+2]
       mov       rcx,[rdx]
       xor       r8,rcx
       xor       r9,[rdx+2]
       or        r8,r9
       sete      dl
       movzx     edx,dl
       mov       eax,edx
       jmp       short M00_L16
M00_L15:
       mov       rcx,r10
       call      qword ptr [7FFE9823FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L16:
       test      eax,eax
       jne       near ptr M00_L06
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9891C8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE985B5F80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       rax,[7FFE9817B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r14
       call      qword ptr [7FFE9891C900]
       jmp       near ptr M00_L04
M00_L19:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FFE9891C918]
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE989176D8]
       int       3
M00_L21:
       mov       r8,[rax+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L23
       mov       r8,[r8+10]
       jmp       near ptr M00_L07
M00_L22:
       mov       [rsp+20],edi
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE989176F0]
       jmp       near ptr M00_L08
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 779
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
       mov       rax,0F8F5CDDDDB5B
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M01_L07
       mov       rax,18EF9000100
       mov       r15,[rax]
M01_L00:
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
M01_L01:
       mov       r9d,[rbp+68]
       mov       rcx,[rbp+38]
       cmp       r9d,[rcx+8]
       jl        short M01_L02
       mov       rdi,[rbp+28]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FFE9888F198]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M01_L04
M01_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FFE98646D90]; System.String.IndexOf(Char, Int32, Int32)
       mov       [rbp+68],eax
       cmp       dword ptr [rbp+68],0
       jge       short M01_L03
       mov       r8,[rbp+38]
       mov       r8d,[r8+8]
       mov       [rbp+68],r8d
M01_L03:
       mov       r8d,[rbp+68]
       sub       r8d,edi
       lea       rcx,[rbp+10]
       mov       edx,edi
       mov       r9d,1
       call      qword ptr [7FFE9891E928]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FFE9891E940]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE9891E958]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M01_L01
M01_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M01_L08
M01_L05:
       mov       rax,r14
       mov       r8,0F8F5CDDDDB5B
       cmp       [rbp+8],r8
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      qword ptr [7FFE98455DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M01_L00
M01_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,18EF9001D18
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE9882E500]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M01_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,18EF9001D18
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE9882E500]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
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
       sub       rsp,1A8
       lea       rbp,[rsp+1E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L105
       mov       ecx,[rbx+8]
       mov       rax,rbx
M02_L01:
       mov       [rbp-70],rbx
       mov       [rbp-68],rdi
       mov       rdx,1CF8E130D98
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,18EF9002198
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M02_L106
M02_L02:
       mov       [rbp-118],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M02_L102
       xor       r13d,r13d
       xor       r12d,r12d
M02_L03:
       mov       [rbp-1A0],r13
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L107
M02_L04:
       mov       [rbp-128],rdx
       mov       [rbp-120],rdx
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-120]
       call      qword ptr [7FFE9888F5D0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
       jmp       near ptr M02_L29
M02_L05:
       mov       rdx,r11
       sub       rdx,r8
       shr       rdx,1
M02_L06:
       mov       r11d,edx
       test      r11d,r11d
       jl        short M02_L07
       lea       r11d,[rdx+r9]
M02_L07:
       jmp       near ptr M02_L37
M02_L08:
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M02_L11
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M02_L67
       mov       r10d,1
M02_L09:
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M02_L68
       mov       r9d,1
M02_L10:
       cmp       r10d,r9d
       jne       near ptr M02_L81
M02_L11:
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M02_L13
       xor       r10d,r10d
M02_L12:
       test      r10d,r10d
       jle       short M02_L14
       mov       [rbp-0AC],r10d
       mov       ecx,167
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       r8,rax
       mov       edx,[rbp-0AC]
       xor       ecx,ecx
       call      qword ptr [7FFE9891C720]
       int       3
M02_L13:
       movsxd    r10,ecx
       mov       r10d,[rdx+r10*4+10]
       jmp       short M02_L12
M02_L14:
       neg       r10d
       mov       [rbp-0A4],r10d
       test      r10d,r10d
       jl        near ptr M02_L82
       lea       ecx,[r10+r13]
       cmp       ecx,[rdx+8]
       ja        near ptr M02_L82
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M02_L16
       xor       r9d,r9d
M02_L15:
       cmp       r8d,r9d
       jge       short M02_L17
       mov       [rbp-0B0],r9d
       mov       ecx,17F
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       r8,rax
       mov       edx,[rbp-0B0]
       mov       ecx,[rbp-0A0]
       call      qword ptr [7FFE9891C720]
       int       3
M02_L16:
       movsxd    r9,ecx
       mov       r9d,[rax+r9*4+10]
       jmp       short M02_L15
M02_L17:
       sub       r8d,r9d
       mov       [rbp-0A8],r8d
       test      r8d,r8d
       jl        near ptr M02_L83
       lea       ecx,[r8+r13]
       cmp       ecx,[rax+8]
       ja        near ptr M02_L83
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M02_L18
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FFE9891C7C8]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M02_L72
       mov       rax,[rbp-168]
       mov       rdx,[rbp-170]
M02_L18:
       mov       rcx,[rdx]
       movzx     r9d,word ptr [rcx]
       mov       r11d,r13d
       imul      r11,r9
       mov       r10d,[rbp-0A4]
       imul      r10,r9
       lea       rdx,[rdx+r10+10]
       mov       r8d,[rbp-0A8]
       imul      r8,r9
       lea       r10,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L71
       cmp       r11,4000
       ja        near ptr M02_L70
       mov       rcx,r10
       mov       r8,r11
       call      00007FFEF7E71380
       cmp       dword ptr [7FFEF8193A10],0
       jne       near ptr M02_L69
M02_L19:
       mov       r13,[rbp-150]
       mov       rcx,[r13+20]
       mov       ecx,[rcx+8]
       add       [r13+58],ecx
       lea       rcx,[r13+20]
       mov       rdx,[rbp-168]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
M02_L20:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M02_L84
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       r13,[rax+28]
       mov       rax,[r13+48]
       mov       [rbp-178],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L84
       cmp       qword ptr [rax+10],0
       je        near ptr M02_L73
M02_L21:
       mov       rax,[r13+48]
       mov       [rbp-180],rax
       mov       r13,[r13+50]
       cmp       dword ptr [r13+8],0
       jbe       near ptr M02_L84
       mov       r8d,[r13+10]
       mov       [rbp-0B4],r8d
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L84
       mov       rdx,[rax+10]
       lea       ecx,[r8*2+2]
       cmp       [rdx+8],ecx
       jl        near ptr M02_L74
M02_L22:
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L84
       mov       rdx,[rax+10]
       mov       rcx,rdx
       lea       eax,[r8+r8]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L84
       lea       eax,[r8+r8]
       mov       [rcx+rax*4+10],r10d
       lea       ecx,[r8*2+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L84
       sub       r9d,r10d
       mov       [rdx+rcx*4+10],r9d
       cmp       dword ptr [r13+8],0
       jbe       near ptr M02_L84
       inc       r8d
       mov       [r13+10],r8d
M02_L23:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L84
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M02_L43
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L84
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M02_L84
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L84
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M02_L24:
       mov       [rbp-148],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M02_L85
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M02_L78
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L44
       cmp       eax,[rcx+8]
       jae       near ptr M02_L84
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L25:
       mov       r8,[rbp-148]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L45
       cmp       eax,[rcx+8]
       jae       near ptr M02_L84
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L26:
       mov       r8,[rbp-148]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M02_L85
M02_L27:
       mov       ecx,[rsi+4C]
       mov       edx,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M02_L79
M02_L28:
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
       mov       r13,[rbp-1A0]
M02_L29:
       mov       rdx,[rbp-128]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-118]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-128]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M02_L47
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
       jle       short M02_L31
       add       rcx,10
M02_L30:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M02_L30
M02_L31:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M02_L32
       xor       eax,eax
       mov       [rcx+18],rax
M02_L32:
       mov       rsi,[rbp-128]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L50
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M02_L33:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rdx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveSpecialCharRegex_15+RunnerFactory+Runner
       cmp       [rsi],rdx
       jne       near ptr M02_L77
       mov       rax,rsi
       mov       [rbp-150],rax
       mov       edx,r12d
       mov       ecx,[rax+4C]
       cmp       ecx,edx
       jae       near ptr M02_L42
       mov       r8d,ecx
       lea       r8,[r13+r8*2]
       sub       edx,ecx
       mov       r10,18EF9002128
       mov       r10,[r10]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M02_L39
       cmp       word ptr [r8],7F
       ja        near ptr M02_L39
       mov       r9,r8
       mov       r11d,edx
       lea       r13,[r10+8]
       cmp       r11d,10
       jg        near ptr M02_L53
       vmovups   xmm0,[r13]
       lea       r9d,[rdx-8]
       movsxd    r9,r9d
       lea       r9,[r8+r9*2]
       cmp       r8,r9
       ja        near ptr M02_L61
       mov       r11,r8
M02_L34:
       vmovups   xmm1,[r11]
       vpackuswb xmm1,xmm1,[r9]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFE98986640]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFE98986650]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M02_L60
       vpmovmskb r13d,xmm0
       tzcnt     r13d,r13d
       cmp       r13d,8
       jge       near ptr M02_L62
M02_L35:
       sub       r11,r8
       shr       r11,1
       add       r11d,r13d
M02_L36:
       mov       r9d,r11d
       cmp       r9d,edx
       jae       short M02_L37
       mov       r13d,r9d
       cmp       word ptr [r8+r13*2],7F
       ja        near ptr M02_L63
M02_L37:
       test      r11d,r11d
       jl        near ptr M02_L65
       add       ecx,r11d
       mov       [rax+4C],ecx
       mov       r13d,[rax+4C]
       lea       r8d,[r13+1]
       mov       [rax+4C],r8d
       mov       r10d,r13d
       mov       r9d,r8d
       cmp       r9d,r10d
       jl        near ptr M02_L66
M02_L38:
       cmp       dword ptr [rax+58],0
       jne       near ptr M02_L20
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       mov       r13,[rax+20]
       mov       edx,[r13+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-168],rax
       mov       rdx,r13
       mov       [rbp-170],rdx
       mov       r8d,[r13+8]
       mov       [rbp-0A0],r8d
       mov       r13d,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L46
       mov       r10,[rdx]
       cmp       r10,[rax]
       jne       near ptr M02_L08
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L08
       cmp       r13d,[rdx+8]
       ja        near ptr M02_L08
       lea       ecx,[r8+r13]
       cmp       ecx,[rax+8]
       ja        near ptr M02_L08
       movzx     ecx,word ptr [r10]
       mov       r9d,r13d
       imul      r9,rcx
       add       rdx,10
       mov       r8d,r8d
       imul      rcx,r8
       lea       rcx,[rax+rcx+10]
       test      dword ptr [r10],1000000
       je        near ptr M02_L41
       mov       r8,r9
       call      qword ptr [7FFE982357A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L19
M02_L39:
       add       r10,88
       mov       r11d,edx
       lea       rdx,[r8+r11*2]
       mov       [rbp-158],rdx
       mov       r11,r8
       mov       r13,[r10]
       mov       [rbp-160],r13
       mov       r10d,[r10+10]
       mov       [rbp-94],r10d
       cmp       r8,rdx
       je        near ptr M02_L64
M02_L40:
       movzx     edx,word ptr [r11]
       imul      r10d,edx
       mov       r13d,[r13+8]
       imul      r10,r13
       shr       r10,20
       mov       r13,[rbp-160]
       movzx     r10d,word ptr [r13+r10*2+10]
       cmp       r10d,edx
       jne       near ptr M02_L05
       add       r11,2
       mov       rdx,[rbp-158]
       cmp       r11,rdx
       mov       r10d,[rbp-94]
       jne       short M02_L40
       jmp       near ptr M02_L64
M02_L41:
       mov       r8,r9
       call      qword ptr [7FFE98235818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L19
M02_L42:
       mov       [rax+4C],r12d
       jmp       near ptr M02_L23
M02_L43:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,18EF90021B8
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M02_L24
M02_L44:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE9888F930]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L25
M02_L45:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE9888F930]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L26
M02_L46:
       mov       ecx,12D
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       rcx,rax
       call      qword ptr [7FFE989162E0]
       int       3
M02_L47:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-1A8],rax
       test      rax,rax
       je        short M02_L48
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rax,rsi
       mov       r10,[rbp-1A8]
       mov       [rbp-140],r10
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-128]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FFE9888F738]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-138]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       short M02_L49
M02_L48:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-130],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-128]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-130]
       call      qword ptr [7FFE9888F738]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-130]
M02_L49:
       mov       rsi,[rbp-128]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L32
M02_L50:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M02_L51
       mov       r8d,20
M02_L51:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M02_L52
       mov       dword ptr [rbp-8C],10
M02_L52:
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
       jmp       near ptr M02_L33
M02_L53:
       vmovups   ymm0,[r13]
       cmp       edx,20
       jle       short M02_L56
       lea       r11d,[rdx-20]
       movsxd    r11,r11d
       lea       r11,[r8+r11*2]
M02_L54:
       vmovups   ymm1,[r9]
       vpackuswb ymm1,ymm1,[r9+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFE98986660]
       vbroadcastsd ymm3,qword ptr [7FFE98986650]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M02_L55
       add       r9,40
       cmp       r9,r11
       jb        short M02_L54
       jmp       short M02_L56
M02_L55:
       mov       r11,r9
       sub       r11,r8
       shr       r11,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       add       r11d,r9d
       jmp       near ptr M02_L36
M02_L56:
       lea       r11d,[rdx-10]
       movsxd    r11,r11d
       lea       r11,[r8+r11*2]
       cmp       r9,r11
       ja        short M02_L57
       jmp       short M02_L58
M02_L57:
       mov       r9,r11
M02_L58:
       vmovups   ymm1,[r9]
       vpackuswb ymm1,ymm1,[r11]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFE98986660]
       vbroadcastsd ymm2,qword ptr [7FFE98986650]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        short M02_L60
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r13d,ymm0
       tzcnt     r13d,r13d
       cmp       r13d,10
       jl        short M02_L59
       mov       r9,r11
       add       r13d,0FFFFFFF0
M02_L59:
       sub       r9,r8
       shr       r9,1
       lea       r11d,[r9+r13]
       jmp       near ptr M02_L36
M02_L60:
       mov       r11d,0FFFFFFFF
       jmp       near ptr M02_L36
M02_L61:
       mov       r11,r9
       jmp       near ptr M02_L34
M02_L62:
       mov       r11,r9
       add       r13d,0FFFFFFF8
       jmp       near ptr M02_L35
M02_L63:
       mov       r11d,r9d
       lea       r8,[r8+r11*2]
       sub       edx,r9d
       jmp       near ptr M02_L39
M02_L64:
       mov       edx,0FFFFFFFF
       jmp       near ptr M02_L06
M02_L65:
       mov       r13,[rbp-1A0]
       jmp       near ptr M02_L42
M02_L66:
       mov       [rbp-98],r13d
       mov       [rbp-9C],r8d
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L38
M02_L67:
       mov       r10d,ecx
       jmp       near ptr M02_L09
M02_L68:
       mov       r9d,ecx
       jmp       near ptr M02_L10
M02_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L19
M02_L70:
       mov       rcx,r10
       mov       r8,r11
       call      qword ptr [7FFE987BE0D0]
       jmp       near ptr M02_L19
M02_L71:
       mov       rcx,r10
       mov       r8,r11
       call      qword ptr [7FFE98235818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L19
M02_L72:
       mov       [rsp+20],r13d
       mov       [rsp+28],eax
       mov       rcx,[rbp-170]
       mov       edx,[rbp-0A4]
       mov       r8,[rbp-168]
       mov       r9d,[rbp-0A8]
       call      qword ptr [7FFE9891C7E0]
       jmp       near ptr M02_L19
M02_L73:
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-178]
       xor       edx,edx
       call      qword ptr [7FFE982357B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L21
M02_L74:
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L84
       mov       r11,[rax+10]
       mov       [rbp-188],r11
       lea       edx,[r8*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M02_L76
M02_L75:
       mov       r8,[rbp-188]
       cmp       ecx,[r8+8]
       jae       near ptr M02_L84
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L84
       mov       [rax+rcx*4+10],edx
       inc       ecx
M02_L76:
       mov       r10d,[rbp-0B4]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M02_L75
       mov       rcx,[rbp-180]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FFE982357B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-180]
       mov       r8d,[rbp-0B4]
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L22
M02_L77:
       mov       [rbp-0E8],r13
       mov       [rbp-0E0],r12d
       lea       rdx,[rbp-0E8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L23
M02_L78:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-148]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-148]
       je        near ptr M02_L85
       jmp       near ptr M02_L27
M02_L79:
       mov       edx,r12d
       mov       eax,1
       mov       r8,[rbp-118]
       test      byte ptr [r8+40],40
       je        short M02_L80
       xor       edx,edx
       mov       eax,0FFFFFFFF
M02_L80:
       cmp       ecx,edx
       je        near ptr M02_L85
       lea       edx,[rcx+rax]
       jmp       near ptr M02_L28
M02_L81:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9891C768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE9891C780]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L82:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9891C798]
       mov       rdi,rax
       mov       ecx,12D
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE985B6028]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L83:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE9891C7B0]
       mov       r14,rax
       mov       ecx,145
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE985B6028]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L84:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L85:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-118]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       je        near ptr M02_L93
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M02_L103
       cmp       eax,r8d
       jae       near ptr M02_L132
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L86:
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M02_L104
       cmp       eax,r8d
       jae       near ptr M02_L132
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L87:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M02_L108
       cmp       [rax+8],ecx
       jb        near ptr M02_L109
       add       rax,10
M02_L88:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M02_L90
M02_L89:
       cmp       edx,ecx
       jae       near ptr M02_L132
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M02_L89
M02_L90:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,18EF90021A0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L110
M02_L91:
       test      rsi,rsi
       je        near ptr M02_L101
       test      r14d,r14d
       jle       near ptr M02_L99
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFEF7ED9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rdx,[r15+0C]
       mov       [rbp-0F8],rdx
       mov       [rbp-0F0],r14d
       mov       [rbp-110],rbx
       mov       [rbp-108],rdi
       lea       rdx,[rbp-80]
       mov       [rbp-100],rdx
       lea       rdx,[rbp-0F8]
       lea       r8,[rbp-110]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M02_L92:
       mov       r14,r15
M02_L93:
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L98
       mov       rcx,18EF9001D18
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
       jle       near ptr M02_L111
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L111
M02_L94:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M02_L112
M02_L95:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],edi
       jbe       short M02_L96
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M02_L113
       cmp       edi,[rax+8]
       jae       near ptr M02_L132
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-190],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-190]
       test      r12,r12
       jne       near ptr M02_L114
M02_L96:
       mov       rcx,18EF9000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L129
M02_L97:
       xor       eax,eax
       mov       [rbp-58],rax
M02_L98:
       mov       rax,r14
       vzeroupper
       add       rsp,1A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L99:
       test      r14d,r14d
       je        short M02_L100
       mov       ecx,28
       call      qword ptr [7FFE984578E8]
       int       3
M02_L100:
       mov       r15,1CF8E120008
       jmp       near ptr M02_L92
M02_L101:
       mov       ecx,1C
       call      qword ptr [7FFE9845C240]
       int       3
M02_L102:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M02_L03
M02_L103:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE9888F930]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L86
M02_L104:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE9888F930]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L87
M02_L105:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L01
M02_L106:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,18EF9002190
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FFE98236BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18EF9002198
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L107:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L108:
       test      ecx,ecx
       jne       short M02_L109
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L88
M02_L109:
       call      qword ptr [7FFE983A7198]
       int       3
M02_L110:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18EF9002190
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FFE98236BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18EF90021A0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L91
M02_L111:
       mov       ecx,7
       call      qword ptr [7FFE98916B38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L94
M02_L112:
       mov       rcx,rbx
       call      qword ptr [7FFE987BEB80]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M02_L95
M02_L113:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE98917570]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE98174000
       call      qword ptr [7FFE984577B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE985B6028]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L114:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L132
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L115
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE98917588]
M02_L115:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98235740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9817B184],0
       je        short M02_L116
       call      qword ptr [7FFE989175A0]
       mov       edx,eax
       mov       [rbp-0C8],edx
       jmp       short M02_L118
M02_L116:
       mov       ecx,9
       call      qword ptr [7FFE989175B8]
       mov       eax,[rax+10]
       mov       [rbp-0CC],eax
       mov       ecx,9
       call      qword ptr [7FFE989175B8]
       mov       edx,[rbp-0CC]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M02_L117
       call      qword ptr [7FFE989175D0]
       mov       edx,eax
       mov       [rbp-0C8],edx
       jmp       short M02_L118
M02_L117:
       sar       edx,10
       mov       [rbp-0C8],edx
M02_L118:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98235740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0C8]
       xor       edx,edx
       div       dword ptr [7FFE9817B178]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L125
M02_L119:
       cmp       eax,[r13+8]
       jae       near ptr M02_L132
       mov       [rbp-0C0],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-198],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0D0],r10d
       mov       rcx,r8
       call      qword ptr [7FFE9873D740]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-198]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0D4],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L121
       test      r8d,r8d
       jne       short M02_L122
       xor       edx,edx
       mov       [rax+14],edx
M02_L120:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0D4]
       inc       ecx
       mov       rax,[rbp-198]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0D0],1
M02_L121:
       mov       rcx,rax
       call      qword ptr [7FFE98236820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0D0],0
       je        short M02_L123
       jmp       short M02_L126
M02_L122:
       jmp       short M02_L120
M02_L123:
       mov       eax,[rbp-0C0]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M02_L124
       xor       ecx,ecx
M02_L124:
       mov       edx,[rbp-0C4]
       inc       edx
       mov       eax,ecx
M02_L125:
       mov       [rbp-0C4],edx
       cmp       [r13+8],edx
       jg        near ptr M02_L119
       jmp       short M02_L127
M02_L126:
       mov       r13d,1
       jmp       short M02_L128
M02_L127:
       xor       r13d,r13d
M02_L128:
       jmp       near ptr M02_L96
M02_L129:
       cmp       dword ptr [rsi+8],0
       je        near ptr M02_L97
       mov       rcx,rsi
       call      qword ptr [7FFE9864CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0B8],eax
       mov       edx,[rsi+8]
       mov       [rbp-0BC],edx
       mov       rcx,rbx
       call      qword ptr [7FFE9864CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-0B8]
       mov       r9d,[rbp-0BC]
       mov       edx,3
       call      qword ptr [7FFE98917270]
       test      r13d,r15d
       jne       near ptr M02_L97
       mov       rcx,rsi
       call      qword ptr [7FFE9864CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE9864CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L130
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L131
M02_L130:
       mov       ecx,edi
       xor       edx,edx
M02_L131:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FFE989175E8]
       jmp       near ptr M02_L97
M02_L132:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-128]
       mov       [rsi+8],rcx
       mov       r8,[rbp-118]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 5289
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
       call      qword ptr [7FFEF7CBF528]
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
       call      qword ptr [7FFEF7CB20A8]
       test      rax,rax
       jne       short M03_L06
       call      qword ptr [7FFEF7CA4408]
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
       call      qword ptr [7FFEF7CBF530]
       jmp       short M03_L00
M03_L05:
       call      qword ptr [7FFEF7CA4408]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB56A0]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M04_L13
       cmp       rsi,rdi
       je        near ptr M04_L04
       cmp       rbx,20
       jae       near ptr M04_L06
       mov       rcx,7FFE98906550
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M04_L01
       mov       rcx,7FFE98906568
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE9890656C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M04_L00:
       mov       rcx,7FFE98906534
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M04_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M04_L05
M04_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M04_L17
       mov       rcx,7FFE98906554
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L18
       mov       rcx,7FFE98906558
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFE98906538
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       mov       rcx,7FFE98906564
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        short M04_L11
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L08
M04_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M04_L10
       mov       rcx,7FFE98906548
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M04_L07
M04_L08:
       mov       rcx,7FFE9890654C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L09:
       mov       rcx,7FFE98906570
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L10:
       mov       rcx,7FFE9890653C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L11:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L12
       mov       rcx,7FFE98906540
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,7FFE98906544
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L13:
       cmp       rbx,4
       jb        short M04_L14
       mov       rcx,7FFE98906530
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L14:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M04_L15
       mov       rcx,7FFE98906528
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M04_L15:
       test      bl,1
       je        short M04_L16
       mov       rcx,7FFE9890652C
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M04_L16:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L17:
       mov       rcx,7FFE98906560
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L05
       jmp       near ptr M04_L02
M04_L18:
       mov       rcx,7FFE9890655C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L09
; Total bytes of code 685
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       rbx,rcx
       mov       rcx,273A24000D8
       mov       rsi,[rcx]
       mov       edi,0C
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       r14,2B4214F06C0
       mov       r15,[rsi+38]
       test      r15,r15
       je        near ptr M00_L55
M00_L00:
       mov       r13,[rsi+18]
       mov       r12d,[rsi+44]
       mov       rax,[rsi+20]
       mov       [rbp-0C0],rax
       mov       r8d,[rsi+40]
       mov       [rbp-3C],r8d
       mov       rcx,[r15+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L57
       mov       r8d,[rbp-3C]
       test      cl,2
       jne       near ptr M00_L58
       mov       r10,[rcx]
M00_L01:
       test      r10,r10
       je        near ptr M00_L05
       mov       [rbp-0B8],r10
       mov       rcx,[r10+18]
       cmp       [rcx],cl
       mov       rdx,2B4214E0008
       cmp       rcx,rdx
       jne       short M00_L02
       mov       r13,[rbp-0B8]
       jmp       near ptr M00_L09
M00_L02:
       cmp       dword ptr [rcx+8],0
       jne       short M00_L05
       lea       r9,[rcx+0C]
       mov       rdx,2B4214E0014
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r11d,ecx
       cmp       r11,0A
       je        short M00_L03
       mov       rcx,r9
       mov       r8,r11
       call      qword ptr [7FFE9824FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       short M00_L04
       nop       dword ptr [rax]
M00_L03:
       mov       rcx,[r9]
       mov       r9,[r9+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r9,[rdx+2]
       or        r9,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L04:
       test      eax,eax
       je        short M00_L05
       mov       r13,[rbp-0B8]
       jmp       short M00_L09
M00_L05:
       mov       rax,[rbp-0C0]
       mov       [rsp+20],rax
       mov       edx,r8d
       mov       r8,r13
       mov       r9d,r12d
       mov       rcx,2B4214E0008
       call      qword ptr [7FFE988674E0]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r13,rax
       mov       r12,[r15+8]
       and       r12,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L60
       test      r13,r13
       je        short M00_L06
       cmp       qword ptr [7FFE9818B020],0
       jne       near ptr M00_L61
M00_L06:
       xor       eax,eax
M00_L07:
       test      r12b,2
       jne       near ptr M00_L62
       test      rax,rax
       jne       near ptr M00_L62
       mov       rcx,r12
       mov       rdx,r13
       call      00007FFEF7E675D0
M00_L08:
       nop
M00_L09:
       cmp       [r13],r13b
       cmp       edi,0C
       ja        near ptr M00_L63
       mov       eax,[rsi+40]
       and       eax,40
       je        near ptr M00_L64
M00_L10:
       mov       [rbp-70],r13
       mov       rcx,2B4214F0DA8
       mov       [rbp-60],rcx
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       [rbp-50],r14
       mov       [rbp-48],ecx
       mov       dword ptr [rbp-44],0C
       mov       [rbp-68],ecx
       mov       dword ptr [rbp-64],0FFFFFFFF
       test      eax,eax
       je        near ptr M00_L67
       mov       dword ptr [rbp-68],0C
       mov       rcx,273A2400198
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L70
M00_L11:
       mov       r12d,2
       mov       ecx,1
       cmp       byte ptr [r13+20],0
       cmove     r12d,ecx
       mov       [rbp-0C8],rsi
       lea       r13,[r14+0C]
       lea       rcx,[rsi+30]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L71
M00_L12:
       mov       [rbp-0D0],rcx
       mov       [rcx+8],r14
       mov       rdx,[rsi+48]
       call      qword ptr [7FFE988679D8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       r14d,edi
       mov       r8,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveCrLfRegex_13+RunnerFactory+Runner
       mov       rsi,[rbp-0D0]
       cmp       [rsi],r8
       jne       near ptr M00_L21
M00_L13:
       mov       [rbp-0A0],r13
       mov       dword ptr [rbp-98],0C
       mov       [rsp+20],r12d
       lea       r8,[rbp-0A0]
       mov       rdx,[rbp-0C8]
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFE988679F0]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       [rsi+4C],r14d
       mov       rdi,rsi
M00_L14:
       mov       ecx,[rdi+4C]
       test      ecx,ecx
       jle       short M00_L16
       dec       ecx
       mov       eax,ecx
       cmp       eax,0C
       jae       short M00_L16
M00_L15:
       mov       edx,ecx
       movzx     r8d,word ptr [r13+rdx*2]
       cmp       r8d,0A
       sete      dl
       movzx     edx,dl
       cmp       r8d,0D
       sete      r8b
       movzx     r8d,r8b
       or        edx,r8d
       jne       near ptr M00_L27
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jb        short M00_L15
M00_L16:
       xor       edx,edx
       mov       [rdi+4C],edx
M00_L17:
       mov       r14,[rsi+28]
       mov       rax,[r14+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L51
       cmp       dword ptr [rax+10],0
       jle       near ptr M00_L31
       mov       edx,[rsi+4C]
       mov       rcx,r14
       mov       r9d,r12d
       xor       r8d,r8d
       call      qword ptr [7FFE98867C30]; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
M00_L18:
       cmp       dword ptr [r14+30],0
       je        near ptr M00_L52
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M00_L34
       mov       rcx,[r15+8]
       lea       rdx,[rbp-70]
       mov       r8,r14
       call      qword ptr [7FFE98867900]; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
M00_L19:
       test      eax,eax
       je        near ptr M00_L52
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
       jmp       near ptr M00_L13
M00_L21:
       mov       [rbp-0A0],r13
       mov       dword ptr [rbp-98],0C
       mov       [rsp+20],r12d
       lea       r8,[rbp-0A0]
       mov       rdx,[rbp-0C8]
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFE988679F0]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       [rsi+4C],r14d
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveCrLfRegex_13+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M00_L37
       mov       rdi,rsi
M00_L22:
       mov       eax,[rdi+4C]
       test      eax,eax
       jle       near ptr M00_L38
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jae       near ptr M00_L38
M00_L23:
       cmp       ecx,0C
       jae       near ptr M00_L51
       mov       edx,ecx
       movzx     r8d,word ptr [r13+rdx*2]
       cmp       r8d,0A
       sete      dl
       movzx     edx,dl
       cmp       r8d,0D
       sete      r8b
       movzx     r8d,r8b
       or        edx,r8d
       jne       near ptr M00_L39
       lea       ecx,[rax-1]
       mov       eax,ecx
       cmp       eax,0C
       jb        short M00_L23
       jmp       near ptr M00_L38
M00_L24:
       mov       r8d,r14d
       sub       r8d,edx
       dec       r8d
       cmp       r8d,0C
       jae       near ptr M00_L51
       mov       eax,r8d
       movzx     eax,word ptr [r13+rax*2]
       cmp       eax,0A
       sete      r8b
       movzx     r8d,r8b
       cmp       eax,0D
       sete      al
       movzx     eax,al
       or        eax,r8d
       je        near ptr M00_L40
       inc       edx
       cmp       r14d,edx
       jle       near ptr M00_L40
       jmp       short M00_L24
M00_L25:
       mov       r14,[rsi+28]
       mov       rax,[r14+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M00_L51
       cmp       dword ptr [rax+10],0
       jle       near ptr M00_L43
       jmp       near ptr M00_L44
M00_L26:
       cmp       dword ptr [r14+30],0
       je        near ptr M00_L52
       jmp       near ptr M00_L45
M00_L27:
       inc       ecx
       mov       [rdi+4C],ecx
       mov       r14d,ecx
       cmp       r14d,0C
       ja        near ptr M00_L50
       xor       edx,edx
       test      r14d,r14d
       jle       short M00_L29
M00_L28:
       mov       r8d,r14d
       sub       r8d,edx
       dec       r8d
       cmp       r8d,0C
       jae       near ptr M00_L51
       mov       eax,r8d
       movzx     eax,word ptr [r13+rax*2]
       cmp       eax,0A
       sete      r8b
       movzx     r8d,r8b
       cmp       eax,0D
       sete      al
       movzx     eax,al
       or        eax,r8d
       je        short M00_L29
       inc       edx
       cmp       r14d,edx
       jg        short M00_L28
M00_L29:
       test      edx,edx
       je        near ptr M00_L33
       mov       ecx,r14d
       sub       ecx,edx
       mov       [rdi+4C],ecx
       mov       eax,r14d
       mov       r9d,ecx
       cmp       r9d,eax
       mov       [rbp-88],eax
       mov       [rbp-84],r9d
       jge       short M00_L30
       mov       [rbp-84],r14d
       mov       [rbp-88],ecx
M00_L30:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE98867C00]; System.Text.RegularExpressions.RegexRunner.Crawl(Int32)
       mov       r14d,[rbp-84]
       mov       eax,[rbp-88]
       mov       r9d,r14d
       sub       r9d,eax
       mov       rcx,[rdi+28]
       mov       r8d,eax
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFE98867C18]; System.Text.RegularExpressions.Match.AddMatch(Int32, Int32, Int32)
       jmp       near ptr M00_L17
M00_L31:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       rcx,273A24001B8
       mov       r14,[rcx]
       jmp       near ptr M00_L18
M00_L32:
       dec       ecx
       mov       [rdi+4C],ecx
       jmp       near ptr M00_L14
M00_L33:
       cmp       dword ptr [rdi+4C],0
       jne       short M00_L32
       jmp       near ptr M00_L17
M00_L34:
       lea       rdx,[rbp-70]
       mov       r8,r14
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M00_L19
M00_L35:
       mov       r11d,0C
       mov       r10d,1
       mov       rdx,[rbp-0C8]
       test      byte ptr [rdx+40],40
       je        short M00_L36
       xor       r11d,r11d
       mov       r10d,0FFFFFFFF
M00_L36:
       cmp       edi,r11d
       je        near ptr M00_L52
       add       r10d,edi
       mov       r14d,r10d
       mov       r10d,r14d
       jmp       near ptr M00_L20
M00_L37:
       mov       [rbp-0A0],r13
       mov       dword ptr [rbp-98],0C
       lea       rdx,[rbp-0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L25
M00_L38:
       xor       edx,edx
       mov       [rdi+4C],edx
       jmp       near ptr M00_L25
M00_L39:
       inc       ecx
       mov       [rdi+4C],ecx
       mov       r14d,ecx
       cmp       r14d,0C
       ja        near ptr M00_L50
       xor       edx,edx
       test      r14d,r14d
       jg        near ptr M00_L24
M00_L40:
       test      edx,edx
       je        short M00_L42
       mov       ecx,r14d
       sub       ecx,edx
       mov       [rdi+4C],ecx
       mov       eax,r14d
       mov       r8d,ecx
       cmp       r8d,eax
       mov       [rbp-88],eax
       mov       [rbp-84],r8d
       jge       short M00_L41
       mov       [rbp-84],r14d
       mov       [rbp-88],ecx
M00_L41:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE98867C00]; System.Text.RegularExpressions.RegexRunner.Crawl(Int32)
       mov       r14d,[rbp-84]
       mov       r8d,[rbp-88]
       mov       r9d,r14d
       sub       r9d,r8d
       mov       rcx,[rdi+28]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFE98867C18]; System.Text.RegularExpressions.Match.AddMatch(Int32, Int32, Int32)
       jmp       near ptr M00_L25
M00_L42:
       cmp       dword ptr [rdi+4C],0
       je        near ptr M00_L25
       dec       ecx
       mov       [rdi+4C],ecx
       jmp       near ptr M00_L22
M00_L43:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       rcx,273A24001B8
       mov       r14,[rcx]
       jmp       near ptr M00_L26
M00_L44:
       mov       edx,[rsi+4C]
       mov       rcx,r14
       mov       r9d,r12d
       xor       r8d,r8d
       call      qword ptr [7FFE98867C30]; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       jmp       near ptr M00_L26
M00_L45:
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       je        short M00_L46
       lea       rdx,[rbp-70]
       mov       r8,r14
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       short M00_L47
M00_L46:
       mov       rcx,[r15+8]
       lea       rdx,[rbp-70]
       mov       r8,r14
       call      qword ptr [7FFE98867900]; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
M00_L47:
       test      eax,eax
       je        short M00_L52
       mov       edi,[rsi+4C]
       mov       eax,edi
       cmp       dword ptr [r14+14],0
       jne       short M00_L49
       mov       r11d,0C
       mov       r10d,1
       mov       rdx,[rbp-0C8]
       test      byte ptr [rdx+40],40
       je        short M00_L48
       xor       r11d,r11d
       mov       r10d,0FFFFFFFF
M00_L48:
       cmp       edi,r11d
       je        short M00_L52
       lea       eax,[rdi+r10]
M00_L49:
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
       jmp       near ptr M00_L21
M00_L50:
       call      qword ptr [7FFE983B7198]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       rdx,[rbp-0C8]
       lea       rcx,[rdx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-58],0
       je        near ptr M00_L72
       mov       edx,[rbp-68]
       cmp       edx,[rbp-44]
       ja        near ptr M00_L73
       mov       rcx,[rbp-50]
       mov       eax,[rbp-48]
       mov       [rbp-0B0],rcx
       mov       [rbp-0A8],eax
       mov       [rbp-0A4],edx
       lea       rdx,[rbp-0B0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE98867C60]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ReadOnlyMemory`1<Char>)
       lea       rcx,[rbp-60]
       lea       rdx,[rbp-80]
       call      qword ptr [7FFE98867E10]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].AsSpan()
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE98867E58]; System.MemoryExtensions.Reverse[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]](System.Span`1<System.ReadOnlyMemory`1<Char>>)
M00_L53:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE9886C078]; System.Text.RegularExpressions.Regex.SegmentsToStringAndDispose(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef)
M00_L54:
       mov       [rbp-90],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-90]
       mov       rdx,7FFE988B4070
       cmp       [rcx],ecx
       call      qword ptr [7FFE9886C168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L55:
       lea       r15,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE98246D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      r15,r15
       jne       short M00_L56
       call      qword ptr [7FFE98904EE8]
       int       3
M00_L56:
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFEF7E7CC60
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L00
       mov       r15,[rsi+38]
       jmp       near ptr M00_L00
M00_L57:
       mov       r8d,[rbp-3C]
       xor       r10d,r10d
       jmp       near ptr M00_L01
M00_L58:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       r10,[rdx]
       test      r10,r10
       jne       short M00_L59
       mov       rdx,7FFE98918948
       call      qword ptr [7FFE98246E08]
       mov       r10,rax
       mov       r8d,[rbp-3C]
M00_L59:
       jmp       near ptr M00_L01
M00_L60:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE98905608]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE985C5F80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L61:
       mov       rax,[7FFE9818B020]
       mov       rcx,r13
       call      rax
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,r13
       call      qword ptr [7FFE98905620]
       jmp       near ptr M00_L07
M00_L62:
       lea       rcx,[r15+8]
       mov       rdx,r13
       mov       r8,rax
       call      qword ptr [7FFE98905638]
       jmp       near ptr M00_L08
M00_L63:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE98904F18]
       int       3
M00_L64:
       cmp       byte ptr [r13+20],0
       jne       near ptr M00_L10
       mov       rcx,[r13+10]
       cmp       dword ptr [rcx+8],0
       jne       short M00_L65
       mov       r8,2B4214E0008
       jmp       short M00_L66
M00_L65:
       mov       r8,[r13+8]
       cmp       dword ptr [r8+8],0
       jbe       near ptr M00_L74
       mov       r8,[r8+10]
M00_L66:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE98904F30]
       jmp       near ptr M00_L54
M00_L67:
       mov       rcx,273A2400190
       mov       rax,[rcx]
       test      rax,rax
       jne       short M00_L68
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,273A2400178
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,7FFE98900FA8
       call      qword ptr [7FFE98246BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,273A2400190
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L68:
       mov       r9d,2
       mov       ecx,1
       cmp       byte ptr [r13+20],0
       cmove     r9d,ecx
       lea       rcx,[r14+0C]
       mov       [rbp-0A0],rcx
       mov       dword ptr [rbp-98],0C
       mov       [rsp+20],edi
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       [rsp+30],rax
       mov       [rsp+38],r9d
       mov       dword ptr [rsp+40],1
       lea       r9,[rbp-0A0]
       mov       rcx,rsi
       mov       rdx,7FFE988B0730
       mov       r8,r14
       call      qword ptr [7FFE98867918]; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, System.ReadOnlySpan`1<Char>, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       mov       esi,[rbp-58]
       test      esi,esi
       je        near ptr M00_L72
       mov       edx,[rbp-68]
       mov       edi,[rbp-44]
       cmp       edx,edi
       ja        near ptr M00_L73
       mov       rax,[rbp-50]
       mov       r14d,edx
       add       r14d,[rbp-48]
       sub       edi,edx
       mov       r15,[rbp-60]
       mov       edx,[r15+8]
       cmp       edx,esi
       jbe       short M00_L69
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
       jmp       near ptr M00_L53
M00_L69:
       mov       [rbp-0B0],rax
       mov       [rbp-0A8],r14d
       mov       [rbp-0A4],edi
       lea       rdx,[rbp-0B0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE98867C78]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
       jmp       near ptr M00_L53
M00_L70:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,273A2400178
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FFE98246BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,273A2400198
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L71:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M00_L12
M00_L72:
       mov       rax,2B4214F06C0
       jmp       near ptr M00_L54
M00_L73:
       mov       ecx,21
       call      qword ptr [7FFE984678E8]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       xor       ecx,ecx
       mov       rsi,[rbp-0D0]
       mov       [rsi+8],rcx
       mov       rdx,[rbp-0C8]
       lea       rcx,[rdx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       ret
; Total bytes of code 2929
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
       mov       rax,0C648BA21B847
       mov       [rbp],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       jne       near ptr M02_L03
       call      qword ptr [7FFE98465DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE988674F8]; System.Text.RegularExpressions.RegexParser..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Span`1<Int32>)
       nop
       lea       rcx,[rbp+18]
       call      qword ptr [7FFE98867510]; System.Text.RegularExpressions.RegexParser.ScanReplacement()
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FFE98867528]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       nop
       mov       rcx,7FFE98A0DA04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       jne       short M02_L04
M02_L01:
       mov       rcx,7FFE98A0DA08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
       mov       r8,0C648BA21B847
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
       mov       rcx,7FFE98A0DA00
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,2738C400100
       mov       rax,[rcx]
       jmp       near ptr M02_L00
M02_L04:
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,2738C401CF0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE987EEC70]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M02_L01
       sub       rsp,48
       mov       rcx,7FFE98A0DA04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       je        short M02_L05
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,2738C401CF0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE987EEC70]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
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
       jmp       qword ptr [7FFE98904FC0]
; Total bytes of code 20
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
       je        short M04_L04
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],edi
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M04_L01
       add       rcx,10
M04_L00:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M04_L00
M04_L01:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M04_L02
       xor       eax,eax
       mov       [rcx+18],rax
M04_L02:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M04_L07
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M04_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       mov       rsi,[rbx+30]
       mov       rbp,[rsi+18]
       test      rbp,rbp
       je        short M04_L05
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FFE98867B40]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[r14+68]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L06
M04_L05:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FFE98867B40]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M04_L06:
       lea       rcx,[rbx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L02
M04_L07:
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
       jmp       near ptr M04_L03
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
       jbe       near ptr M05_L08
       mov       eax,[rsi+10]
       mov       [rcx+30],eax
       mov       [rcx+34],ebx
       add       edx,ebx
       mov       [rcx+58],edx
       add       [rcx+5C],ebx
       mov       rdi,[rcx+48]
       cmp       dword ptr [rdi+8],0
       jbe       short M05_L08
       mov       rax,[rdi+10]
       mov       edx,[rax+8]
       cmp       edx,1
       jbe       short M05_L08
       mov       edx,[rax+14]
       mov       [rcx+14],edx
       mov       edx,ebx
       add       edx,[rax+10]
       mov       [rcx+10],edx
       cmp       r9d,2
       je        short M05_L01
M05_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       cmp       byte ptr [rcx+60],0
       je        short M05_L02
       call      qword ptr [7FFE98905008]
M05_L02:
       test      ebx,ebx
       je        short M05_L00
       xor       eax,eax
       jmp       short M05_L07
M05_L03:
       mov       rcx,[rdi+rax*8+10]
       test      rcx,rcx
       je        short M05_L06
       cmp       eax,[rsi+8]
       jae       short M05_L08
       mov       edx,[rsi+rax*4+10]
       add       edx,edx
       xor       r8d,r8d
       jmp       short M05_L05
M05_L04:
       cmp       r8d,[rcx+8]
       jae       short M05_L08
       lea       r10,[rcx+r8*4+10]
       add       [r10],ebx
       add       r8d,2
M05_L05:
       cmp       r8d,edx
       jl        short M05_L04
M05_L06:
       inc       eax
M05_L07:
       cmp       [rdi+8],eax
       jg        short M05_L03
       jmp       short M05_L00
M05_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 175
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
       ja        near ptr M06_L02
       mov       rax,[rdx]
       add       ebp,[rdx+8]
       mov       r15,[rdi]
       mov       r13d,[rdi+8]
       cmp       [r15+8],r13d
       ja        short M06_L01
       mov       [rsp+20],rax
       mov       [rsp+28],ebp
       mov       [rsp+2C],r14d
       lea       rdx,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FFE98867C78]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M06_L00:
       mov       ecx,[rsi+10]
       mov       [rbx+8],ecx
       mov       rcx,[rbx]
       lea       rdx,[rbx+10]
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE98867DB0]; System.Text.RegularExpressions.RegexReplacement.ReplacementImplRTL(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef, System.Text.RegularExpressions.Match)
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
M06_L01:
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
       jmp       short M06_L00
M06_L02:
       mov       ecx,21
       call      qword ptr [7FFE984678E8]
       int       3
; Total bytes of code 232
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
       call      qword ptr [7FFE98904FF0]
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
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M08_L01
M08_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
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
       ja        short M09_L00
       mov       rcx,r8
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE98867C78]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M09_L00:
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
       je        short M10_L01
       cmp       [rdx+8],ecx
       jb        short M10_L02
       add       rdx,10
M10_L00:
       mov       [rax],rdx
       mov       [rax+8],ecx
       add       rsp,28
       ret
M10_L01:
       test      ecx,ecx
       jne       short M10_L02
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFE983B7198]
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
       jle       short M11_L01
       mov       eax,eax
       shl       rax,4
       lea       rbp,[rbx+rax-10]
M11_L00:
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
       jb        short M11_L00
M11_L01:
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
       je        near ptr M12_L15
       cmp       [rsi+8],edi
       jb        near ptr M12_L22
       add       rsi,10
M12_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M12_L02
       xor       ecx,ecx
       mov       eax,edi
M12_L01:
       add       ebp,[rsi+rcx+0C]
       add       rcx,10
       dec       eax
       jne       short M12_L01
M12_L02:
       mov       rcx,273A24001E8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M12_L16
M12_L03:
       test      ebp,ebp
       jle       near ptr M12_L17
       mov       edx,ebp
       mov       r15,offset MT_System.String
       mov       rcx,r15
       call      00007FFEF7ED9F20
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rdx,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       cmp       [r14+18],rdx
       jne       near ptr M12_L23
       xor       r14d,r14d
       cmp       r14d,edi
       jge       near ptr M12_L08
M12_L04:
       mov       rax,r14
       shl       rax,4
       add       rax,rsi
       mov       [rsp+40],rax
       xor       edx,edx
       xor       r8d,r8d
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M12_L07
       cmp       [rcx],r15
       jne       near ptr M12_L19
       lea       rdx,[rcx+0C]
M12_L05:
       mov       r8d,[rcx+8]
M12_L06:
       mov       rax,[rsp+40]
       mov       ecx,[rax+8]
       and       ecx,7FFFFFFF
       mov       eax,[rax+0C]
       mov       r10d,eax
       add       r10,rcx
       mov       r8d,r8d
       cmp       r10,r8
       ja        near ptr M12_L22
       lea       rdx,[rdx+rcx*2]
       mov       r8d,eax
M12_L07:
       cmp       r8d,ebp
       ja        near ptr M12_L21
       mov       [rsp+0A4],r8d
       mov       eax,r8d
       add       rax,rax
       mov       [rsp+48],rax
       mov       r8,rax
       mov       rcx,r12
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+0A4]
       mov       rax,[rsp+48]
       add       r12,rax
       sub       ebp,r8d
       inc       r14d
       cmp       r14d,edi
       jl        near ptr M12_L04
M12_L08:
       cmp       qword ptr [rbx],0
       je        near ptr M12_L14
       mov       rcx,273A24001A0
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
       jle       near ptr M12_L24
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M12_L24
M12_L09:
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M12_L25
M12_L10:
       xor       r15d,r15d
       mov       r12d,1
       cmp       [r14+8],ebp
       jbe       short M12_L12
       mov       r15d,1
       mov       rdx,[rdi]
       movzx     ecx,word ptr [rdx]
       mov       eax,[rdi+8]
       imul      rax,rcx
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M12_L26
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE9886C150]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M12_L11:
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       [rdi+8],ecx
       jne       near ptr M12_L27
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
       jne       near ptr M12_L28
M12_L12:
       mov       rcx,2738C400C90
       mov       r14,[rcx]
       cmp       byte ptr [r14+9D],0
       jne       near ptr M12_L43
M12_L13:
       xor       eax,eax
       mov       [rbx],rax
M12_L14:
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
M12_L15:
       test      edi,edi
       jne       near ptr M12_L22
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M12_L00
M12_L16:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.Span<System.ReadOnlyMemory<System.Char>>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,273A24001C0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       call      qword ptr [7FFE98246BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,273A24001E8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L03
M12_L17:
       test      ebp,ebp
       jne       short M12_L18
       mov       r13,2B4214E0008
       jmp       near ptr M12_L08
M12_L18:
       mov       ecx,28
       call      qword ptr [7FFE984678E8]
       int       3
M12_L19:
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M12_L20
       lea       rdx,[rcx+10]
       jmp       near ptr M12_L05
M12_L20:
       lea       rdx,[rsp+90]
       mov       r8,[rcx]
       mov       r8,[r8+40]
       call      qword ptr [r8+28]
       mov       rdx,[rsp+90]
       mov       r8d,[rsp+98]
       mov       eax,r8d
       mov       r8d,eax
       jmp       near ptr M12_L06
M12_L21:
       call      qword ptr [7FFE9865C780]
       int       3
M12_L22:
       call      qword ptr [7FFE983B7198]
       int       3
M12_L23:
       mov       [rsp+60],r12
       mov       [rsp+68],ebp
       mov       [rsp+50],rsi
       mov       [rsp+58],edi
       lea       rdx,[rsp+60]
       lea       r8,[rsp+50]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M12_L08
M12_L24:
       mov       ecx,9
       call      qword ptr [7FFE98904C90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M12_L09
M12_L25:
       mov       rcx,rsi
       call      qword ptr [7FFE98867D68]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M12_L10
M12_L26:
       mov       rdx,rax
       call      qword ptr [7FFE982457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M12_L11
M12_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE98904CA8]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE985C6028]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M12_L28:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M12_L46
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M12_L29
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FFE98904CC0]
M12_L29:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9818B17C],0
       je        short M12_L30
       call      qword ptr [7FFE98904CD8]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M12_L32
M12_L30:
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       mov       eax,[rax+10]
       mov       [rsp+78],eax
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       mov       edx,[rsp+78]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M12_L31
       call      qword ptr [7FFE98904D08]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M12_L32
M12_L31:
       sar       edx,10
       mov       [rsp+7C],edx
M12_L32:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+7C]
       xor       edx,edx
       div       dword ptr [7FFE9818B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M12_L39
M12_L33:
       cmp       eax,[r12+8]
       jae       near ptr M12_L46
       mov       [rsp+84],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+74],r10d
       mov       rcx,r8
       call      qword ptr [7FFE9874DA28]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+70],r8d
       cmp       [rcx+8],r8d
       jbe       short M12_L35
       test      r8d,r8d
       jne       short M12_L36
       xor       edx,edx
       mov       [rax+14],edx
M12_L34:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+70]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+74],1
M12_L35:
       mov       rcx,rax
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+74],0
       je        short M12_L37
       jmp       short M12_L40
M12_L36:
       jmp       short M12_L34
M12_L37:
       mov       eax,[rsp+84]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M12_L38
       xor       ecx,ecx
M12_L38:
       mov       edx,[rsp+80]
       inc       edx
       mov       eax,ecx
M12_L39:
       mov       [rsp+80],edx
       cmp       [r12+8],edx
       jg        near ptr M12_L33
       jmp       short M12_L41
M12_L40:
       mov       r12d,1
       jmp       short M12_L42
M12_L41:
       xor       r12d,r12d
M12_L42:
       jmp       near ptr M12_L12
M12_L43:
       cmp       dword ptr [rdi+8],0
       je        near ptr M12_L13
       mov       rcx,rdi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+8C],eax
       mov       edx,[rdi+8]
       mov       [rsp+88],edx
       mov       rcx,rsi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rsp+8C]
       mov       r9d,[rsp+88]
       mov       edx,3
       call      qword ptr [7FFE98904D20]
       test      r12d,r15d
       jne       near ptr M12_L13
       mov       rcx,rdi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M12_L44
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M12_L45
M12_L44:
       mov       ecx,ebp
       xor       edx,edx
M12_L45:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFE98904D38]
       jmp       near ptr M12_L13
M12_L46:
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
       call      qword ptr [7FFEF7CBF528]
       test      rax,rax
       je        short M14_L04
M14_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M14_L02
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB20A8]
       test      rax,rax
       jne       short M14_L06
       call      qword ptr [7FFEF7CA4408]
       cmp       qword ptr [rax+8],0
       jne       short M14_L05
       xor       edi,edi
M14_L01:
       test      edi,edi
       jne       short M14_L06
M14_L02:
       xor       eax,eax
M14_L03:
       test      rax,rax
       jne       short M14_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M14_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FFEF7CBF530]
       jmp       short M14_L00
M14_L05:
       call      qword ptr [7FFEF7CA4408]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M14_L01
M14_L06:
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB56A0]
       jmp       short M14_L03
M14_L07:
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
       je        short M15_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L00:
       call      qword ptr [7FFE98907C60]
       int       3
; Total bytes of code 44
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
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       mov       [rbp+10],rcx
       mov       rdi,r8
       mov       ebx,[rbp+30]
       mov       rsi,[rbp+38]
       mov       r14d,[rbp+48]
       mov       r15d,[rbp+50]
       mov       r13,[r9]
       mov       r12d,[r9+8]
       lea       rax,[rcx+30]
       xor       edx,edx
       xchg      rdx,[rax]
       mov       rax,rdx
       test      rax,rax
       je        near ptr M16_L50
M16_L00:
       mov       [rbp-90],rax
       mov       [rbp-98],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE988679D8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [rbp-3C],ebx
M16_L01:
       mov       rdx,[rbp-90]
       mov       [rdx+60],r14d
       lea       rcx,[rdx+30]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       mov       [rdx+48],ebx
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],ebx
       mov       rbx,[rdx+28]
       test      rbx,rbx
       je        near ptr M16_L26
       mov       rax,[rdx+8]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+5C],r12d
       mov       rcx,[rbx+50]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       jle       short M16_L03
M16_L02:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M16_L02
M16_L03:
       mov       byte ptr [rbx+60],0
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        short M16_L04
       xor       eax,eax
       mov       [rcx+18],rax
M16_L04:
       mov       rbx,[rbp-90]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M16_L29
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M16_L05:
       mov       eax,[rbp-3C]
       mov       [rbx+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__RemoveCrLfRegex_13+RunnerFactory+Runner
       cmp       [rbx],rcx
       jne       near ptr M16_L39
       mov       rax,rbx
       mov       [rbp-0C8],rax
M16_L06:
       mov       ecx,[rax+4C]
       test      ecx,ecx
       jle       short M16_L08
       dec       ecx
       mov       edx,ecx
       cmp       edx,r12d
       jae       short M16_L08
M16_L07:
       mov       r8d,ecx
       movzx     r8d,word ptr [r13+r8*2]
       cmp       r8d,0A
       sete      r10b
       movzx     r10d,r10b
       cmp       r8d,0D
       sete      r8b
       movzx     r8d,r8b
       or        r8d,r10d
       jne       near ptr M16_L18
       lea       ecx,[rdx-1]
       mov       edx,ecx
       cmp       edx,r12d
       jb        short M16_L07
M16_L08:
       xor       edx,edx
       mov       [rax+4C],edx
M16_L09:
       mov       rax,[rbx+28]
       mov       [rbp-0C0],rax
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M16_L48
       mov       r8d,[rcx+10]
       mov       [rbp-84],r8d
       test      r8d,r8d
       jle       near ptr M16_L25
       test      r15b,r15b
       je        near ptr M16_L40
M16_L10:
       mov       ecx,[rbx+4C]
       mov       r8d,[rbp-84]
       mov       [rax+30],r8d
       xor       edx,edx
       mov       [rax+34],edx
       mov       [rax+58],ecx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M16_L48
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M16_L48
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       cmp       r14d,2
       je        near ptr M16_L41
M16_L11:
       mov       r8,rax
M16_L12:
       cmp       dword ptr [r8+30],0
       je        near ptr M16_L49
       mov       [rbp+50],r15d
       test      r15b,r15b
       je        near ptr M16_L42
M16_L13:
       mov       rdx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       mov       rax,[rbp+40]
       cmp       [rax+18],rdx
       jne       near ptr M16_L43
       lea       r10,[rsi+10]
       mov       [rbp-0F8],r10
       lea       rdx,[rsi+20]
       mov       ecx,[r8+10]
       mov       [rbp-0B8],r8
       mov       r9d,[r8+14]
       lea       r11d,[rcx+r9]
       mov       eax,[rsi+8]
       sub       eax,ecx
       sub       eax,r9d
       mov       [rbp-54],eax
       mov       ecx,r11d
       mov       r9d,eax
       add       rcx,r9
       mov       r9d,[rdx+0C]
       cmp       rcx,r9
       ja        near ptr M16_L47
       mov       r9,[rdx]
       add       r11d,[rdx+8]
       mov       [rbp-58],r11d
       mov       rcx,[r10]
       mov       edx,[r10+8]
       mov       [rbp-5C],edx
       cmp       [rcx+8],edx
       ja        near ptr M16_L17
       mov       [rbp-80],r9
       mov       [rbp-78],r11d
       mov       [rbp-74],eax
       lea       rdx,[rbp-80]
       mov       rcx,r10
       call      qword ptr [7FFE98867C78]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
M16_L14:
       mov       rax,[rbp-0B8]
       mov       ecx,[rax+10]
       mov       [rsi+8],ecx
       mov       rcx,[rsi]
       lea       rdx,[rsi+10]
       mov       [rbp-0B8],rax
       mov       r8,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE98867DB0]; System.Text.RegularExpressions.RegexReplacement.ReplacementImplRTL(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef, System.Text.RegularExpressions.Match)
       lea       rdx,[rsi+0C]
       mov       r8d,[rdx]
       dec       r8d
       mov       [rdx],r8d
       test      r8d,r8d
       je        near ptr M16_L49
M16_L15:
       mov       eax,[rbx+4C]
       mov       ecx,eax
       mov       r8,[rbp-0B8]
       cmp       dword ptr [r8+14],0
       je        near ptr M16_L44
M16_L16:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       mov       [rbx+50],edx
       mov       rdx,[rbx+18]
       mov       edx,[rdx+8]
       mov       [rbx+54],edx
       mov       rdx,[rbx+20]
       mov       edx,[rdx+8]
       mov       [rbx+58],edx
       mov       [rbp-3C],ecx
       mov       ebx,eax
       movzx     r15d,byte ptr [rbp+50]
       jmp       near ptr M16_L01
M16_L17:
       cmp       edx,[rcx+8]
       jae       near ptr M16_L48
       mov       r15d,edx
       shl       r15,4
       lea       r15,[rcx+r15+10]
       mov       rcx,r15
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-58]
       mov       [r15+8],ecx
       mov       ecx,[rbp-54]
       mov       [r15+0C],ecx
       mov       r15d,[rbp-5C]
       inc       r15d
       mov       rcx,[rbp-0F8]
       mov       [rcx+8],r15d
       jmp       near ptr M16_L14
M16_L18:
       inc       ecx
       mov       [rax+4C],ecx
       mov       edx,ecx
       mov       r8d,edx
       cmp       r8d,r12d
       ja        near ptr M16_L46
       xor       edx,edx
       test      r8d,r8d
       jle       short M16_L20
M16_L19:
       mov       r10d,r8d
       sub       r10d,edx
       dec       r10d
       cmp       r10d,r12d
       jae       near ptr M16_L48
       movzx     r10d,word ptr [r13+r10*2]
       cmp       r10d,0A
       sete      r9b
       movzx     r9d,r9b
       cmp       r10d,0D
       sete      r10b
       movzx     r10d,r10b
       or        r10d,r9d
       je        short M16_L20
       inc       edx
       cmp       r8d,edx
       jg        short M16_L19
M16_L20:
       test      edx,edx
       je        near ptr M16_L33
       mov       ecx,r8d
       sub       ecx,edx
       mov       edx,ecx
       mov       [rax+4C],edx
       mov       r10d,r8d
       mov       r9d,edx
       cmp       r9d,r10d
       jge       short M16_L21
       mov       [rbp-48],r8d
       mov       [rbp-4C],edx
       mov       r9d,[rbp-48]
       mov       r10d,[rbp-4C]
M16_L21:
       cmp       dword ptr [rax+58],0
       je        near ptr M16_L34
M16_L22:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M16_L48
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       rax,[rax+28]
       mov       [rbp-0D0],rax
       mov       r8,[rax+48]
       mov       [rbp-0D8],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M16_L48
       cmp       qword ptr [r8+10],0
       je        near ptr M16_L35
M16_L23:
       mov       rax,[rbp-0D0]
       mov       r8,[rax+48]
       mov       [rbp-0E0],r8
       mov       rax,[rax+50]
       mov       [rbp-0E8],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M16_L48
       mov       r11d,[rax+10]
       mov       [rbp-50],r11d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M16_L48
       mov       rdx,[r8+10]
       lea       ecx,[r11*2+2]
       cmp       [rdx+8],ecx
       jl        near ptr M16_L36
M16_L24:
       mov       rdx,[r8+10]
       mov       rcx,rdx
       lea       r8d,[r11+r11]
       cmp       r8d,[rcx+8]
       jae       near ptr M16_L48
       lea       r8d,[r11+r11]
       mov       [rcx+r8*4+10],r10d
       lea       ecx,[r11*2+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M16_L48
       sub       r9d,r10d
       mov       [rdx+rcx*4+10],r9d
       inc       r11d
       mov       rax,[rbp-0E8]
       mov       [rax+10],r11d
       jmp       near ptr M16_L09
M16_L25:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rdx,273A24001B8
       mov       r8,[rdx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M16_L12
M16_L26:
       mov       rbx,[rdx+30]
       mov       rax,[rbx+18]
       mov       [rbp-100],rax
       test      rax,rax
       je        short M16_L27
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-0A8],rdx
       mov       rax,rbx
       mov       r10,[rbp-100]
       mov       [rbp-0B0],r10
       mov       [rsp+20],r12d
       mov       r8d,[rbx+44]
       mov       rbx,[rbp-90]
       mov       r9,[rbx+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FFE98867B40]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-0A8]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0A8]
       jmp       short M16_L28
M16_L27:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A0],rax
       mov       [rsp+20],r12d
       mov       r8d,[rbx+44]
       mov       rdx,rbx
       mov       rbx,[rbp-90]
       mov       r9,[rbx+8]
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE98867B40]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-0A0]
M16_L28:
       mov       rbx,[rbp-90]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L04
M16_L29:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rbx+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M16_L30
       mov       r8d,20
M16_L30:
       cmp       eax,10
       mov       [rbp-40],eax
       jge       short M16_L31
       mov       dword ptr [rbp-40],10
M16_L31:
       mov       [rbp-44],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-44]
       mov       [rbx+50],edx
       movsxd    rdx,dword ptr [rbp-40]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [rbx+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+58],20
       jmp       near ptr M16_L05
M16_L32:
       dec       ecx
       mov       [rax+4C],ecx
       jmp       near ptr M16_L06
M16_L33:
       cmp       dword ptr [rax+4C],0
       jne       short M16_L32
       jmp       near ptr M16_L09
M16_L34:
       mov       [rbp-4C],r10d
       mov       [rbp-48],r9d
       mov       rcx,rax
       call      qword ptr [7FFE98904FF0]
       mov       rax,[rbp-0C8]
       mov       r9d,[rbp-48]
       mov       r10d,[rbp-4C]
       jmp       near ptr M16_L22
M16_L35:
       mov       [rbp-4C],r10d
       mov       [rbp-48],r9d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-0D8]
       xor       edx,edx
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r9d,[rbp-48]
       mov       r10d,[rbp-4C]
       jmp       near ptr M16_L23
M16_L36:
       mov       [rbp-4C],r10d
       mov       [rbp-48],r9d
       mov       rcx,[r8+10]
       mov       [rbp-0F0],rcx
       lea       edx,[r11*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M16_L38
M16_L37:
       mov       r8,[rbp-0F0]
       cmp       ecx,[r8+8]
       jae       near ptr M16_L48
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M16_L48
       mov       [rax+rcx*4+10],edx
       inc       ecx
M16_L38:
       mov       r10d,[rbp-50]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M16_L37
       mov       rcx,[rbp-0E0]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r8,[rbp-0E0]
       mov       r9d,[rbp-48]
       mov       r10d,[rbp-4C]
       mov       r11d,[rbp-50]
       jmp       near ptr M16_L24
M16_L39:
       mov       [rbp-70],r13
       mov       [rbp-68],r12d
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M16_L09
M16_L40:
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+28],rcx
       mov       rax,[rbp-0C0]
       jmp       near ptr M16_L10
M16_L41:
       cmp       byte ptr [rax+60],0
       je        near ptr M16_L11
       mov       rcx,rax
       call      qword ptr [7FFE98905008]
       mov       rax,[rbp-0C0]
       jmp       near ptr M16_L11
M16_L42:
       xor       edx,edx
       mov       [rbx+28],rdx
       jmp       near ptr M16_L13
M16_L43:
       mov       rdx,rsi
       mov       [rbp-0B8],r8
       mov       rax,[rbp+40]
       mov       rcx,[rax+8]
       mov       [rbp+40],rax
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M16_L49
       jmp       near ptr M16_L15
M16_L44:
       mov       ecx,r12d
       mov       edx,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M16_L45
       xor       ecx,ecx
       mov       edx,0FFFFFFFF
M16_L45:
       cmp       eax,ecx
       je        short M16_L49
       lea       ecx,[rax+rdx]
       jmp       near ptr M16_L16
M16_L46:
       call      qword ptr [7FFE983B7198]
       int       3
M16_L47:
       mov       ecx,21
       call      qword ptr [7FFE984678E8]
       int       3
M16_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M16_L49:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
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
M16_L50:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp+10]
       jmp       near ptr M16_L00
       sub       rsp,28
       xor       ecx,ecx
       mov       rbx,[rbp-90]
       mov       [rbx+8],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 2262
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
       jne       near ptr M17_L09
       mov       ebp,100
M17_L00:
       mov       rcx,273A24001A0
       mov       r14,[rcx]
       mov       r15,r14
       mov       r13,r15
       mov       rcx,2738C400C90
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
       jle       near ptr M17_L10
       mov       rcx,[rcx+240]
       mov       r8,[rcx+48]
       test      r8,r8
       je        near ptr M17_L10
M17_L01:
       mov       [rsp+30],r8
       mov       rcx,[r8+10]
       test      rcx,rcx
       je        near ptr M17_L13
       mov       r10d,[rcx+8]
       mov       edx,[rsp+0B4]
       cmp       r10d,edx
       jbe       near ptr M17_L14
       mov       r10d,edx
       shl       r10,4
       mov       r9,[rcx+r10+10]
       test      r9,r9
       je        near ptr M17_L12
       xor       r11d,r11d
       mov       [rcx+r10+10],r11
       mov       rax,[rsp+68]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M17_L11
M17_L02:
       mov       rbp,r9
M17_L03:
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15d,[rsi+8]
       test      rbp,rbp
       je        near ptr M17_L34
       mov       rcx,[rdi]
       cmp       rcx,[rbp]
       jne       near ptr M17_L34
       cmp       dword ptr [rcx+4],18
       jne       near ptr M17_L34
       cmp       r15d,[rdi+8]
       ja        near ptr M17_L34
       cmp       r15d,[rbp+8]
       ja        near ptr M17_L34
       mov       r8d,r15d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M17_L33
       cmp       r8,4000
       ja        near ptr M17_L32
       mov       rcx,rax
       call      00007FFEF7E71380
       cmp       dword ptr [7FFEF8193A10],0
       jne       near ptr M17_L30
M17_L04:
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
       je        near ptr M17_L37
M17_L05:
       xor       eax,eax
       mov       dword ptr [rsp+90],1
       cmp       [r13+8],r15d
       jbe       near ptr M17_L07
       mov       dword ptr [rsp+94],1
       mov       rdx,[rdi]
       movzx     ecx,word ptr [rdx]
       mov       r10d,[rdi+8]
       imul      r10,rcx
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M17_L38
       mov       rdx,r10
       shr       rdx,3
       call      qword ptr [7FFE9886C150]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M17_L06:
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M17_L39
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
       jne       near ptr M17_L40
       mov       eax,[rsp+94]
M17_L07:
       cmp       byte ptr [r12+9D],0
       jne       near ptr M17_L55
M17_L08:
       mov       eax,[rsi+8]
       lea       ecx,[rax+1]
       mov       [rsi+8],ecx
       cmp       eax,[rbp+8]
       jae       near ptr M17_L58
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
M17_L09:
       mov       ebp,[rdi+8]
       add       ebp,ebp
       jmp       near ptr M17_L00
M17_L10:
       mov       ecx,9
       call      qword ptr [7FFE98904C90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r8,rax
       jmp       near ptr M17_L01
M17_L11:
       mov       [rsp+60],r9
       mov       rcx,r9
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rbp,[rsp+60]
       mov       eax,[rbp+8]
       mov       [rsp+9C],eax
       mov       rcx,r15
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+0B4]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+9C]
       mov       rcx,[rsp+68]
       call      qword ptr [7FFE98905158]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L12:
       mov       edx,[rsp+0B4]
       jmp       short M17_L14
M17_L13:
       mov       edx,[rsp+0B4]
M17_L14:
       mov       rcx,[r13+10]
       cmp       [rcx+8],edx
       jbe       near ptr M17_L27
       mov       r10d,edx
       mov       rcx,[rcx+r10*8+10]
       test      rcx,rcx
       je        near ptr M17_L26
       mov       rbp,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9818B17C],0
       je        short M17_L15
       call      qword ptr [7FFE98904CD8]
       mov       r15d,eax
       jmp       short M17_L17
M17_L15:
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       mov       r15d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M17_L16
       call      qword ptr [7FFE98904D08]
       mov       r15d,eax
       jmp       short M17_L17
M17_L16:
       sar       r15d,10
M17_L17:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE9818B170]
       mov       r15d,edx
       xor       eax,eax
       jmp       near ptr M17_L21
M17_L18:
       cmp       r15d,[rbp+8]
       jae       near ptr M17_L58
       mov       ecx,r15d
       mov       rdx,[rbp+rcx*8+10]
       mov       [rsp+50],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       rcx,rdx
       call      qword ptr [7FFE9874DA28]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rsp+50]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M17_L19
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rsp+58],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M17_L19:
       mov       rcx,rdx
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rsp+58]
       test      rcx,rcx
       jne       short M17_L22
       inc       r15d
       cmp       [rbp+8],r15d
       jne       short M17_L20
       xor       r15d,r15d
M17_L20:
       mov       eax,[rsp+98]
       inc       eax
M17_L21:
       mov       [rsp+98],eax
       cmp       [rbp+8],eax
       jg        near ptr M17_L18
       jmp       short M17_L23
M17_L22:
       mov       rbp,rcx
       jmp       short M17_L24
M17_L23:
       xor       ebp,ebp
M17_L24:
       test      rbp,rbp
       je        short M17_L26
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        short M17_L25
       mov       rcx,rbp
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       edx,[rbp+8]
       mov       [rsp+0A0],edx
       mov       rcx,r13
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r13d,[rsp+0B4]
       mov       [rsp+20],r13d
       mov       edx,[rsp+0A4]
       mov       r8d,[rsp+0A0]
       mov       rcx,r15
       call      qword ptr [7FFE98905158]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L25:
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L26:
       mov       ecx,10
       mov       edx,[rsp+0B4]
       shlx      ebp,ecx,edx
       jmp       short M17_L29
M17_L27:
       test      ebp,ebp
       jne       short M17_L28
       mov       rbp,2B4214F0DA8
       jmp       near ptr M17_L03
M17_L28:
       mov       ecx,ebp
       mov       rdx,2B4214E6F28
       call      qword ptr [7FFE9846D860]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M17_L29:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.ReadOnlyMemory<System.Char>[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        near ptr M17_L31
       mov       rcx,rbp
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0B0],eax
       mov       edx,[rbp+8]
       mov       [rsp+0AC],edx
       mov       rcx,r13
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0AC]
       mov       rcx,r15
       call      qword ptr [7FFE98905158]
       mov       eax,[rbp+8]
       mov       [rsp+0A8],eax
       mov       rcx,r13
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE98905170]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L04
M17_L31:
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L32:
       mov       rcx,rax
       call      qword ptr [7FFE98904DC8]
       jmp       near ptr M17_L04
M17_L33:
       mov       rcx,rax
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M17_L04
M17_L34:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE98904DE0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
       test      rbp,rbp
       jne       short M17_L35
       xor       r9d,r9d
       jmp       short M17_L36
M17_L35:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFE98904DE0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M17_L36:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFE98904DF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M17_L04
M17_L37:
       mov       rcx,r14
       call      qword ptr [7FFE98867D68]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r13,rax
       jmp       near ptr M17_L05
M17_L38:
       mov       rdx,r10
       call      qword ptr [7FFE982457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M17_L06
M17_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE98904CA8]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r12
       call      qword ptr [7FFE985C6028]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M17_L40:
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M17_L58
       mov       edx,r15d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L41
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE98904CC0]
M17_L41:
       mov       rax,[rax+8]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9818B17C],0
       je        short M17_L42
       call      qword ptr [7FFE98904CD8]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M17_L44
M17_L42:
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       mov       eax,[rax+10]
       mov       [rsp+78],eax
       mov       ecx,0A
       call      qword ptr [7FFE98904CF0]
       mov       edx,[rsp+78]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M17_L43
       call      qword ptr [7FFE98904D08]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M17_L44
M17_L43:
       sar       edx,10
       mov       [rsp+7C],edx
M17_L44:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+7C]
       xor       edx,edx
       div       dword ptr [7FFE9818B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M17_L51
M17_L45:
       cmp       eax,[r8+8]
       jae       near ptr M17_L58
       mov       [rsp+84],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+38],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+74],r9d
       mov       rcx,r10
       call      qword ptr [7FFE9874DA28]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+70],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L47
       test      r8d,r8d
       jne       short M17_L48
       xor       edx,edx
       mov       [rax+14],edx
M17_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+70]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+74],1
M17_L47:
       mov       rcx,rax
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+74],0
       je        short M17_L49
       jmp       short M17_L52
M17_L48:
       jmp       short M17_L46
M17_L49:
       mov       eax,[rsp+84]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+40]
       cmp       [r8+8],ecx
       jne       short M17_L50
       xor       ecx,ecx
M17_L50:
       mov       edx,[rsp+80]
       inc       edx
       mov       eax,ecx
M17_L51:
       mov       r8,[rsp+40]
       mov       [rsp+80],edx
       cmp       [r8+8],edx
       jg        near ptr M17_L45
       jmp       short M17_L53
M17_L52:
       mov       r8d,1
       jmp       short M17_L54
M17_L53:
       xor       r8d,r8d
M17_L54:
       mov       [rsp+90],r8d
       mov       eax,[rsp+94]
       jmp       near ptr M17_L07
M17_L55:
       cmp       dword ptr [rdi+8],0
       mov       [rsp+94],eax
       je        near ptr M17_L08
       mov       rcx,rdi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rdi+8]
       mov       [rsp+8C],eax
       mov       rcx,r14
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,r13d
       mov       r9d,[rsp+8C]
       mov       edx,3
       call      qword ptr [7FFE98904D20]
       mov       r13d,[rsp+94]
       test      [rsp+90],r13d
       jne       near ptr M17_L08
       mov       rcx,rdi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+88],eax
       mov       edi,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M17_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M17_L57
M17_L56:
       mov       ecx,r15d
       xor       edx,edx
M17_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,[rsp+88]
       mov       r8d,edi
       call      qword ptr [7FFE98904D38]
       jmp       near ptr M17_L08
M17_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2291
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,235B5801370
       cmp       qword ptr [rcx],0
       je        near ptr M00_L15
M00_L00:
       mov       rcx,235B5801370
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L25
       mov       rcx,235B5801378
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L02
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L16
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L16
M00_L01:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,235B5800108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,235B58000F8
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       call      qword ptr [7FFE98464150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rsi,rax
M00_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE98656568]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L19
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rcx,rdi
       mov       rdx,2764A970670
       mov       r9d,1
       call      qword ptr [7FFE98656F58]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L17
M00_L03:
       test      r14,r14
       je        near ptr M00_L19
M00_L04:
       test      r14,r14
       je        near ptr M00_L41
       mov       rcx,235B58020F8
       mov       rbx,[rcx]
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L26
       xor       esi,esi
M00_L05:
       mov       rdi,[rbx+38]
       test      rdi,rdi
       je        near ptr M00_L27
M00_L06:
       mov       r15,[rbx+18]
       mov       r13d,[rbx+44]
       mov       r12,[rbx+20]
       mov       eax,[rbx+40]
       mov       [rbp-44],eax
       mov       rcx,[rdi+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L29
       mov       eax,[rbp-44]
       test      cl,2
       jne       near ptr M00_L30
       mov       r8,[rcx]
M00_L07:
       mov       r10,r8
       test      r10,r10
       je        short M00_L08
       mov       [rbp-70],r10
       mov       rcx,[r10+18]
       cmp       [rcx],cl
       mov       rdx,2764A9625A8
       cmp       rcx,rdx
       je        short M00_L12
       jmp       near ptr M00_L32
M00_L08:
       mov       [rsp+20],r12
       mov       edx,eax
       mov       r8,r15
       mov       r9d,r13d
       mov       rcx,2764A9625A8
       call      qword ptr [7FFE9889F168]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r15,rax
       mov       r13,[rdi+8]
       and       r13,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L35
       test      r15,r15
       je        short M00_L09
       cmp       qword ptr [7FFE9818B020],0
       jne       near ptr M00_L36
M00_L09:
       xor       eax,eax
M00_L10:
       test      r13b,2
       jne       near ptr M00_L37
       test      rax,rax
       jne       near ptr M00_L37
       mov       rcx,r13
       mov       rdx,r15
       call      00007FFEF7E675D0
M00_L11:
       mov       [rbp-70],r15
M00_L12:
       mov       r10,[rbp-70]
       cmp       [r10],r10b
       cmp       [r14+8],esi
       jb        near ptr M00_L38
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L40
       cmp       byte ptr [r10+20],0
       jne       near ptr M00_L40
       mov       rcx,[r10+10]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L39
       mov       rcx,[r10+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L42
       mov       r8,[rcx+10]
M00_L13:
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE9889F3A8]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L14:
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
M00_L15:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2764A96BBA8
       call      qword ptr [7FFE98927D80]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2764A96BB30
       call      qword ptr [7FFE98655FE0]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,235B5801370
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L16:
       mov       ecx,2
       call      qword ptr [7FFE98926EC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L17:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L18:
       mov       rcx,rdi
       mov       rdx,2764A970670
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L19:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FFE98927AF8]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rsi
M00_L20:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE986C2410]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L23
       mov       rcx,[rbp-58]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFE98388720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L23
       cmp       r14,rdi
       je        short M00_L20
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,2764A970670
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L21
       mov       rdi,r14
       jmp       short M00_L20
M00_L21:
       cmp       qword ptr [rbx+38],0
       je        short M00_L22
       mov       rdx,[rbx+38]
       mov       [rbp-68],rdx
       mov       byte ptr [rbp-40],0
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-68]
       call      qword ptr [7FFE98245998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        short M00_L22
       mov       rcx,[rbp-68]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M00_L22:
       mov       [rbp-60],r15
       jmp       short M00_L24
M00_L23:
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L24:
       call      M00_L44
       nop
       mov       r14,[rbp-60]
       jmp       near ptr M00_L04
M00_L25:
       mov       r8,235B5801378
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,2764A970670
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L26:
       mov       esi,[r14+8]
       jmp       near ptr M00_L05
M00_L27:
       lea       rdi,[rbx+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE98246D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rdi,rdi
       jne       short M00_L28
       call      qword ptr [7FFE98926BC8]
       int       3
M00_L28:
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFEF7E7CC60
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L06
       mov       rdi,[rbx+38]
       jmp       near ptr M00_L06
M00_L29:
       mov       eax,[rbp-44]
       xor       r10d,r10d
       mov       r8,r10
       jmp       near ptr M00_L07
M00_L30:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       mov       rdx,[rcx+10]
       mov       r8,[rdx]
       test      r8,r8
       jne       short M00_L31
       mov       rdx,7FFE9896DBE0
       call      qword ptr [7FFE98246E08]
       mov       r8,rax
       mov       eax,[rbp-44]
M00_L31:
       mov       r10,r8
       mov       r8,r10
       jmp       near ptr M00_L07
M00_L32:
       cmp       dword ptr [rcx+8],1
       jne       near ptr M00_L08
       lea       r9,[rcx+0C]
       mov       rdx,2764A9625B4
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M00_L33
       mov       r8,[r9]
       mov       r9,[r9+2]
       mov       rcx,[rdx]
       xor       r8,rcx
       xor       r9,[rdx+2]
       or        r8,r9
       sete      dl
       movzx     edx,dl
       mov       eax,edx
       jmp       short M00_L34
M00_L33:
       mov       rcx,r9
       call      qword ptr [7FFE9824FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L34:
       test      eax,eax
       mov       eax,[rbp-44]
       jne       near ptr M00_L12
       jmp       near ptr M00_L08
M00_L35:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE9892C138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE985C5F80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rax,[7FFE9818B020]
       mov       rcx,r15
       call      rax
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,r15
       call      qword ptr [7FFE9892C150]
       jmp       near ptr M00_L10
M00_L37:
       lea       rcx,[rdi+8]
       mov       rdx,r15
       mov       r8,rax
       call      qword ptr [7FFE9892C168]
       jmp       near ptr M00_L11
M00_L38:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE98927CD8]
       int       3
M00_L39:
       mov       r8,2764A960008
       jmp       near ptr M00_L13
M00_L40:
       mov       [rsp+20],esi
       mov       rcx,r10
       mov       rdx,rbx
       mov       r8,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFE98927CF0]
       jmp       near ptr M00_L14
M00_L41:
       xor       eax,eax
       jmp       near ptr M00_L14
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M00_L43
       mov       rcx,[rbp-68]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M00_L43:
       nop
       add       rsp,28
       ret
M00_L44:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
; Total bytes of code 1696
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFEF7CA47E8]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FFEF7CBBA00]
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFEF7CBCBA8]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFEF7CBA3D0]
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
       je        short M02_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M02_L20
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L00:
       cmp       [rbx],rsi
       jne       near ptr M02_L22
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M02_L21
M02_L01:
       cmp       rdi,rdx
       jne       near ptr M02_L16
M02_L02:
       mov       rax,235B5800100
       mov       rax,[rax]
       mov       [rbp+18],rax
M02_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L25
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M02_L04
       call      qword ptr [7FFE989273C0]
       int       3
M02_L04:
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2D60
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE989271C8]
M02_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M02_L12
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M02_L11
M02_L06:
       mov       rax,[rbp+10]
       mov       rdx,[rax+38]
       mov       rdx,[rdx+8]
       cmp       rcx,rdx
       jne       short M02_L08
M02_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M02_L14
M02_L08:
       test      rcx,rcx
       je        near ptr M02_L13
       test      rdx,rdx
       je        near ptr M02_L13
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M02_L13
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L09
       call      qword ptr [7FFE9824FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L10
M02_L09:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M02_L10:
       test      eax,eax
       je        near ptr M02_L23
       jmp       short M02_L07
M02_L11:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,2764A960008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M02_L06
M02_L12:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L13:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M02_L10
M02_L14:
       cmp       byte ptr [rbp-28],0
       je        short M02_L15
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       near ptr M02_L24
M02_L15:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       test      rdi,rdi
       je        near ptr M02_L03
       test      rdx,rdx
       je        near ptr M02_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M02_L03
       lea       rax,[rdi+0C]
       add       rdx,0C
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M02_L17
       mov       rcx,rax
       call      qword ptr [7FFE9824FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L18
M02_L17:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M02_L18:
       test      eax,eax
       je        near ptr M02_L03
       jmp       near ptr M02_L02
M02_L19:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,2764A960008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L20:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M02_L22
M02_L21:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,2764A960008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L01
M02_L22:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L23:
       call      M02_L29
       jmp       short M02_L25
M02_L24:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFE989270F0]
       jmp       near ptr M02_L15
M02_L25:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M02_L26
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FFE98245998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FFE9828AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M02_L26
       mov       rcx,rbx
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M02_L26:
       cmp       qword ptr [rbp-20],0
       je        near ptr M02_L28
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M02_L27
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98245998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        short M02_L27
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M02_L27:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L28:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L29:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L30
       mov       rcx,[rbp-30]
       call      00007FFEF7EE2C80
       test      eax,eax
       je        short M02_L30
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFE989270F0]
M02_L30:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L31
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M02_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L32
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M02_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 1110
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
       je        near ptr M03_L26
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M03_L27
       test      rbx,rbx
       je        near ptr M03_L27
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M03_L00
       call      qword ptr [7FFE989273C0]
       int       3
M03_L00:
       mov       rcx,rbx
       call      00007FFEF7EE2D60
       test      eax,eax
       jne       short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FFE989271C8]
M03_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L18
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M03_L13
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M03_L03
       lea       r11,[rdx+0C]
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M03_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M03_L02
M03_L03:
       mov       r14d,ecx
M03_L04:
       mov       rcx,[rbx+8]
       mov       r8d,r14d
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M03_L22
       mov       r8d,r8d
       lea       rcx,[rcx+r8*4+10]
       mov       r15d,[rcx]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M03_L18
M03_L05:
       mov       ecx,r15d
       shl       rcx,5
       lea       r15,[r13+rcx+10]
       cmp       [r15+8],r14d
       jne       near ptr M03_L17
       mov       r10,[r15]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M03_L16
       cmp       r10,rdx
       jne       short M03_L09
       mov       r9d,1
M03_L06:
       test      r9d,r9d
       je        near ptr M03_L17
       add       r15,10
M03_L07:
       test      r15,r15
       je        near ptr M03_L12
       vmovdqu   xmm0,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M03_L19
M03_L08:
       mov       [rbp-80],rsi
       jmp       near ptr M03_L24
M03_L09:
       test      r10,r10
       je        near ptr M03_L15
       mov       ecx,[r10+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       near ptr M03_L15
       add       r10,0C
       lea       r9,[rdx+0C]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M03_L10
       mov       rcx,r10
       mov       rdx,r9
       call      qword ptr [7FFE9824FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M03_L11
M03_L10:
       mov       rdx,[rbp+18]
       mov       rcx,[r10]
       mov       r8,[r10+2]
       mov       r11,[r9]
       xor       rcx,r11
       xor       r8,[r9+2]
       or        rcx,r8
       sete      r9b
       movzx     r9d,r9b
M03_L11:
       jmp       near ptr M03_L06
M03_L12:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FFE98656FD0]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M03_L23
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE98657048]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFE98657108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L08
M03_L13:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FFE98190A48
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L04
M03_L14:
       cmp       eax,r15d
       jbe       short M03_L18
       jmp       near ptr M03_L05
M03_L15:
       xor       r9d,r9d
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FFE98190A50
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L06
M03_L17:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M03_L14
       call      qword ptr [7FFE98467A20]
       int       3
M03_L18:
       mov       rdx,[rbp+18]
       xor       r15d,r15d
       jmp       near ptr M03_L07
M03_L19:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M03_L20
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE98927420]
       jmp       short M03_L21
M03_L20:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFE987CE790]; System.Resources.ResourceReader.LoadString(Int32)
M03_L21:
       mov       [rbp-80],rax
       jmp       short M03_L24
M03_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L23:
       call      M03_L40
       jmp       near ptr M03_L29
M03_L24:
       cmp       byte ptr [rbp-50],0
       je        short M03_L25
       mov       rcx,[rbp-78]
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       short M03_L28
M03_L25:
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
M03_L26:
       mov       ecx,13BFC
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       rcx,rax
       call      qword ptr [7FFE98926688]
       int       3
M03_L27:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE989273F0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE98927408]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L28:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE989270F0]
       jmp       short M03_L25
M03_L29:
       cmp       byte ptr [rbp+20],0
       jne       short M03_L30
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
M03_L30:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M03_L31
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,235B5800070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE98656E08]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M03_L31:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFE98245998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M03_L34
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFE98927438]
       jmp       short M03_L33
M03_L32:
       mov       rcx,rsi
       call      qword ptr [7FFE986C8358]
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
       call      qword ptr [7FFE98657108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M03_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE986C8350]
       test      eax,eax
       jne       short M03_L32
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE986C66E0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M03_L35
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M03_L38
M03_L35:
       cmp       qword ptr [rbp-48],0
       je        short M03_L36
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M03_L38
M03_L36:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FFE98657048]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M03_L37
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFE98657108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M03_L37:
       cmp       byte ptr [rbp-50],0
       je        short M03_L39
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M03_L39
M03_L38:
       call      M03_L42
       jmp       near ptr M03_L25
M03_L39:
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
M03_L40:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L41
       mov       rcx,[rbp-78]
       call      00007FFEF7EE2C80
       test      eax,eax
       je        short M03_L41
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE989270F0]
M03_L41:
       nop
       add       rsp,28
       ret
M03_L42:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L43
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
M03_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1422
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
       mov       rax,0F27291C6A7CC
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M04_L32
       mov       rax,235B5800100
       mov       r15,[rax]
M04_L00:
       test      [rsp],esp
       sub       rsp,80
       lea       rcx,[rsp+20]
       mov       [rbp+58],rbx
       mov       [rbp+0A0],edi
       mov       [rbp+60],r15
       xor       eax,eax
       mov       [rbp+8C],eax
       mov       byte ptr [rbp+0A4],0
       mov       [rbp+68],rsi
       mov       [rbp+9C],r14d
       mov       rdi,[rbp+130]
       mov       [rbp+70],rdi
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
M04_L01:
       mov       edi,[rbp+88]
       mov       rcx,[rbp+58]
       cmp       edi,[rcx+8]
       jge       near ptr M04_L06
       mov       r14d,edi
       mov       rcx,[rbp+58]
       mov       r8d,[rcx+8]
       mov       edx,r8d
       sub       edx,edi
       cmp       r8d,edi
       jb        near ptr M04_L27
       movsxd    r8,edi
       lea       rcx,[rcx+r8*2+0C]
       mov       r8d,edx
       mov       edx,24
       call      qword ptr [7FFE983B7798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jge       near ptr M04_L07
M04_L02:
       mov       [rbp+88],eax
       cmp       dword ptr [rbp+88],0
       jge       short M04_L03
       mov       rcx,[rbp+58]
       mov       ecx,[rcx+8]
       mov       [rbp+88],ecx
M04_L03:
       mov       edi,[rbp+88]
       sub       edi,r14d
       cmp       edi,1
       jg        near ptr M04_L17
       test      edi,edi
       je        near ptr M04_L05
       cmp       edi,1
       jne       near ptr M04_L21
       mov       rdi,[rbp+48]
       mov       rcx,[rbp+58]
       cmp       r14d,[rcx+8]
       jae       near ptr M04_L28
       mov       eax,r14d
       movzx     r14d,word ptr [rcx+rax*2+0C]
       mov       r15d,[rbp+0A0]
       and       r15d,0FFFFFFFE
       mov       rdx,[rbp+60]
       test      r15b,1
       jne       near ptr M04_L08
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
M04_L04:
       cmp       [rdi],dil
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       call      qword ptr [7FFE9889F210]; System.Text.RegularExpressions.RegexNode.Reduce()
       mov       r14,rax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+8],0
       jne       near ptr M04_L10
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M04_L05:
       mov       ecx,[rbp+88]
       mov       rax,[rbp+58]
       cmp       ecx,[rax+8]
       jge       near ptr M04_L01
       jmp       near ptr M04_L26
M04_L06:
       mov       rdi,[rbp+48]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FFE9889F228]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M04_L29
M04_L07:
       add       eax,edi
       jmp       near ptr M04_L02
M04_L08:
       lea       r8,[rbp+8C]
       lea       r9,[rbp+20]
       mov       ecx,r14d
       call      qword ptr [7FFE9892EFA0]
       test      eax,eax
       jne       short M04_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       and       r15d,0FFFFFFFE
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
       jmp       near ptr M04_L04
M04_L09:
       vmovdqu   xmm0,xmmword ptr [rbp+20]
       vmovdqu   xmmword ptr [rbp+10],xmm0
       lea       rcx,[rbp+10]
       call      qword ptr [7FFE9892EFB8]
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
       jmp       near ptr M04_L04
M04_L10:
       mov       rdx,[rdi+8]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FFE985C6628]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       inc       dword ptr [r13+14]
       mov       r12,[r13+8]
       mov       eax,[r13+10]
       cmp       [r12+8],eax
       jbe       short M04_L11
       lea       ecx,[rax+1]
       mov       [r13+10],ecx
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L12
M04_L11:
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFE983BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M04_L12:
       inc       dword ptr [r13+14]
       mov       r15,[r13+8]
       mov       r12d,[r13+10]
       cmp       [r15+8],r12d
       jbe       short M04_L13
       lea       ecx,[r12+1]
       mov       [r13+10],ecx
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L14
M04_L13:
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFE983BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M04_L14:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L05
M04_L15:
       mov       rdx,[rdi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       inc       dword ptr [rax+14]
       mov       rdi,[rax+8]
       mov       r15d,[rax+10]
       cmp       [rdi+8],r15d
       jbe       short M04_L16
       lea       ecx,[r15+1]
       mov       [rax+10],ecx
       mov       ecx,r15d
       lea       rcx,[rdi+rcx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L05
M04_L16:
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFE983BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M04_L05
M04_L17:
       mov       ecx,[rbp+0A0]
       not       ecx
       and       ecx,1
       or        ecx,1
       jne       short M04_L20
       mov       rcx,[rbp+58]
       test      rcx,rcx
       jne       short M04_L19
M04_L18:
       mov       ecx,21
       call      qword ptr [7FFE984678E8]
       int       3
M04_L19:
       mov       eax,r14d
       mov       edx,edi
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        short M04_L18
       mov       eax,r14d
       lea       rcx,[rcx+rax*2+0C]
       mov       eax,edi
       mov       [rbp+10],rcx
       mov       [rbp+18],eax
       lea       rcx,[rbp+10]
       call      qword ptr [7FFE9892EF88]
       test      eax,eax
       jne       short M04_L21
M04_L20:
       mov       r15,[rbp+48]
       mov       r13d,[rbp+0A0]
       and       r13d,0FFFFFFFE
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[rbp+58]
       mov       edx,r14d
       mov       r8d,edi
       cmp       [rcx],ecx
       call      qword ptr [7FFE983BF450]; System.String.Substring(Int32, Int32)
       mov       byte ptr [r12+2E],0C
       mov       [r12+28],r13d
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE9889F1F8]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       jmp       near ptr M04_L05
M04_L21:
       mov       r9,[rbp+58]
       test      r9,r9
       jne       short M04_L22
       or        r14d,edi
       jne       near ptr M04_L18
       xor       r15d,r15d
       xor       edi,edi
       jmp       short M04_L23
M04_L22:
       mov       ecx,r14d
       mov       edx,edi
       add       rcx,rdx
       mov       edx,[r9+8]
       cmp       rcx,rdx
       ja        near ptr M04_L18
       mov       ecx,r14d
       lea       r15,[r9+rcx*2+0C]
M04_L23:
       xor       r14d,r14d
       jmp       short M04_L25
M04_L24:
       movzx     ecx,word ptr [r15+r14*2]
       mov       r13,[rbp+48]
       lea       r9,[rbp+8C]
       mov       edx,[rbp+0A0]
       mov       r8,[rbp+60]
       call      qword ptr [7FFE9889F1E0]; System.Text.RegularExpressions.RegexNode.CreateOneWithCaseConversion(Char, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Text.RegularExpressions.RegexCaseBehavior ByRef)
       mov       rdx,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE9889F1F8]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       inc       r14d
M04_L25:
       cmp       r14d,edi
       jl        short M04_L24
       jmp       near ptr M04_L05
M04_L26:
       mov       ecx,[rbp+88]
       inc       ecx
       mov       [rbp+88],ecx
       mov       rdi,[rbp+48]
       lea       rcx,[rbp+30]
       call      qword ptr [7FFE9892EF70]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE9889F1F8]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       xor       ecx,ecx
       mov       [rbp+50],rcx
       jmp       near ptr M04_L01
M04_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE987C5D40]
       int       3
M04_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L29:
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       jne       short M04_L33
M04_L30:
       mov       rax,r14
       mov       r8,0F27291C6A7CC
       cmp       [rbp+8],r8
       je        short M04_L31
       call      CORINFO_HELP_FAIL_FAST
M04_L31:
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
M04_L32:
       call      qword ptr [7FFE98465DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M04_L00
M04_L33:
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,235B5801D18
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE9883E510]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M04_L30
       sub       rsp,28
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       je        short M04_L34
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,235B5801D18
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE9883E510]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M04_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 1607
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
       sub       rsp,248
       vmovaps   [rsp+230],xmm6
       vmovaps   [rsp+220],xmm7
       lea       rbp,[rsp+280]
       xor       eax,eax
       mov       [rbp-148],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       vmovdqa   xmmword ptr [rbp-130],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       add       rax,30
       jne       short M05_L00
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M05_L104
       mov       ecx,[rbx+8]
       mov       rax,rbx
M05_L01:
       mov       [rbp-98],rbx
       mov       [rbp+20],rdi
       mov       [rbp-90],rdi
       mov       rdx,2764A970D40
       mov       [rbp-80],rdx
       xor       edx,edx
       mov       [rbp-78],edx
       mov       [rbp-70],rax
       mov       [rbp-68],edx
       mov       [rbp-64],ecx
       mov       [rbp-88],edx
       mov       [rbp-84],r9d
       mov       r14,rbx
       mov       rcx,235B5802190
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L105
M05_L02:
       mov       [rbp-168],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M05_L103
       xor       r13d,r13d
       xor       r12d,r12d
M05_L03:
       mov       eax,[rbp+30]
       mov       [rbp-0AC],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M05_L106
M05_L04:
       mov       [rbp-178],rdx
       mov       [rbp-170],rdx
       lea       rcx,[rdx+8]
       mov       [rbp-160],r14
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-170]
       call      qword ptr [7FFE9889F690]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-0AC]
       mov       [rbp-0B0],esi
       vbroadcastss ymm6,dword ptr [7FFE9898B880]
       jmp       near ptr M05_L30
M05_L05:
       mov       edi,r11d
       shr       edi,9
       mov       [rbp-248],rdi
       mov       rdi,7FFEF7036778
       mov       r14,[rbp-248]
       movzx     edi,byte ptr [rdi+r14]
       shl       edi,6
       mov       r14d,r11d
       shr       r14d,3
       and       r14d,3E
       add       edi,r14d
       mov       r14,7FFEF7034280
       movzx     edi,word ptr [r14+rdi]
       shl       edi,4
       and       r11d,0F
       add       r11d,edi
       mov       rdi,7FFEF703C558
       movzx     r11d,byte ptr [rdi+r11]
       mov       rdi,7FFEF7045028
       cmp       byte ptr [rdi+r11],0
       jl        near ptr M05_L40
M05_L06:
       test      r8d,r8d
       je        near ptr M05_L74
       cmp       r8d,ecx
       ja        near ptr M05_L94
       add       r8d,r9d
       mov       [rax+4C],r8d
       mov       r10d,r9d
       mov       r11d,r8d
       cmp       r11d,r10d
       jl        near ptr M05_L75
M05_L07:
       cmp       dword ptr [rax+58],0
       jne       near ptr M05_L21
       mov       [rbp-0CC],r10d
       mov       [rbp-0C8],r11d
       mov       r8,[rax+20]
       mov       [rbp-240],r8
       mov       edx,[r8+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-1E0],rax
       mov       rcx,[rbp-240]
       mov       rdx,rcx
       mov       [rbp-1E8],rdx
       mov       r8d,[rcx+8]
       mov       [rbp-0D0],r8d
       mov       r10d,[rcx+8]
       mov       [rbp-0D4],r10d
       test      rdx,rdx
       vinsertf128 ymm6,ymm6,xmm7,1
       je        near ptr M05_L60
       mov       r9,[rdx]
       cmp       r9,[rax]
       jne       short M05_L08
       cmp       dword ptr [r9+4],18
       jne       short M05_L08
       cmp       r10d,[rdx+8]
       ja        short M05_L08
       lea       ecx,[r8+r10]
       cmp       ecx,[rax+8]
       jbe       near ptr M05_L55
M05_L08:
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M05_L11
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M05_L79
       mov       r9d,1
M05_L09:
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M05_L80
       mov       r11d,1
M05_L10:
       cmp       r9d,r11d
       jne       near ptr M05_L95
M05_L11:
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M05_L13
       xor       r9d,r9d
M05_L12:
       test      r9d,r9d
       jle       short M05_L14
       mov       [rbp-0E0],r9d
       mov       ecx,167
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       edx,[rbp-0E0]
       xor       ecx,ecx
       call      qword ptr [7FFE98927DC8]
       int       3
M05_L13:
       movsxd    r9,ecx
       mov       r9d,[rdx+r9*4+10]
       jmp       short M05_L12
M05_L14:
       neg       r9d
       mov       [rbp-0D8],r9d
       test      r9d,r9d
       jl        near ptr M05_L96
       lea       ecx,[r9+r10]
       cmp       ecx,[rdx+8]
       ja        near ptr M05_L96
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M05_L16
       xor       r11d,r11d
M05_L15:
       cmp       r8d,r11d
       jge       short M05_L17
       mov       [rbp-0E4],r11d
       mov       ecx,17F
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       edx,[rbp-0E4]
       mov       ecx,[rbp-0D0]
       call      qword ptr [7FFE98927DC8]
       int       3
M05_L16:
       movsxd    r11,ecx
       mov       r11d,[rax+r11*4+10]
       jmp       short M05_L15
M05_L17:
       sub       r8d,r11d
       mov       [rbp-0DC],r8d
       test      r8d,r8d
       jl        near ptr M05_L97
       lea       ecx,[r8+r10]
       cmp       ecx,[rax+8]
       ja        near ptr M05_L97
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M05_L18
       mov       rcx,rdx
       mov       rdx,rax
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE98927E70]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       vinsertf128 ymm6,ymm6,xmm7,1
       jne       near ptr M05_L84
       mov       rax,[rbp-1E0]
       mov       rdx,[rbp-1E8]
M05_L18:
       mov       rcx,[rdx]
       movzx     r11d,word ptr [rcx]
       mov       r10d,[rbp-0D4]
       imul      r10,r11
       mov       r9d,[rbp-0D8]
       imul      r9,r11
       lea       rdx,[rdx+r9+10]
       mov       r8d,[rbp-0DC]
       imul      r8,r11
       lea       r9,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L83
       cmp       r10,4000
       ja        near ptr M05_L82
       mov       rcx,r9
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      00007FFEF7E71380
       cmp       dword ptr [7FFEF8193A10],0
       vinsertf128 ymm6,ymm6,xmm7,1
       jne       near ptr M05_L81
M05_L19:
       cmp       dword ptr [7FFEF8193A10],0
       jne       near ptr M05_L77
M05_L20:
       mov       rax,[rbp-1B8]
       mov       rcx,[rax+20]
       mov       ecx,[rcx+8]
       add       [rax+58],ecx
       lea       rcx,[rax+20]
       mov       rdx,[rbp-1E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-1B8]
       mov       r10d,[rbp-0CC]
       mov       r11d,[rbp-0C8]
M05_L21:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M05_L98
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       rax,[rax+28]
       mov       [rbp-1F0],rax
       mov       r8,[rax+48]
       mov       [rbp-1F8],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M05_L98
       cmp       qword ptr [r8+10],0
       je        near ptr M05_L85
M05_L22:
       mov       rax,[rbp-1F0]
       mov       r8,[rax+48]
       mov       [rbp-200],r8
       mov       rax,[rax+50]
       mov       [rbp-208],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L98
       mov       r9d,[rax+10]
       mov       [rbp-0E8],r9d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M05_L98
       mov       rdx,[r8+10]
       lea       ecx,[r9*2+2]
       cmp       [rdx+8],ecx
       jl        near ptr M05_L86
M05_L23:
       cmp       dword ptr [r8+8],0
       jbe       near ptr M05_L98
       mov       rdx,[r8+10]
       mov       rcx,rdx
       lea       r8d,[r9+r9]
       cmp       r8d,[rcx+8]
       jae       near ptr M05_L98
       lea       r8d,[r9+r9]
       mov       [rcx+r8*4+10],r10d
       lea       ecx,[r9*2+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M05_L98
       sub       r11d,r10d
       mov       [rdx+rcx*4+10],r11d
       mov       rax,[rbp-208]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L98
       inc       r9d
       mov       [rax+10],r9d
M05_L24:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M05_L98
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M05_L90
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M05_L98
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M05_L98
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M05_L98
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M05_L25:
       mov       [rbp-1B0],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M05_L107
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M05_L91
       mov       edx,[rbp-88]
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       cmp       [rcx+8],eax
       jbe       near ptr M05_L58
       cmp       eax,[rcx+8]
       jae       near ptr M05_L98
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-78],eax
M05_L26:
       mov       r8,[rbp-1B0]
       mov       edx,[r8+10]
       sub       edx,[rbp-88]
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       cmp       [rcx+8],eax
       jbe       near ptr M05_L59
       cmp       eax,[rcx+8]
       jae       near ptr M05_L98
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-78],eax
M05_L27:
       mov       r8,[rbp-1B0]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-88],edx
       mov       edx,[rbp-84]
       dec       edx
       mov       [rbp-84],edx
       test      edx,edx
       je        near ptr M05_L107
M05_L28:
       mov       ecx,[rsi+4C]
       mov       edx,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M05_L92
M05_L29:
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       rax,[rsi+20]
       mov       eax,[rax+8]
       mov       [rsi+58],eax
       mov       [rbp-0B0],edx
       mov       esi,ecx
M05_L30:
       mov       rdx,[rbp-178]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-168]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-178]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M05_L41
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
       jle       short M05_L32
M05_L31:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M05_L31
M05_L32:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M05_L33
       xor       eax,eax
       mov       [rcx+18],rax
M05_L33:
       mov       rsi,[rbp-178]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M05_L62
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M05_L34:
       mov       eax,[rbp-0B0]
       mov       [rsi+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE581368DC9C23F5F28EB17DCEF90B1959DB8CDE813C9B37026FAB58F57999C10__SpacesRegex_18+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M05_L89
       mov       rax,rsi
       mov       [rbp-1B8],rax
M05_L35:
       mov       edx,r12d
       mov       r10d,[rax+4C]
       mov       [rbp-0BC],r10d
       cmp       r10d,edx
       jae       near ptr M05_L57
       mov       ecx,r10d
       lea       rcx,[r13+rcx*2]
       sub       edx,r10d
       mov       r8,235B5802160
       mov       r8,[r8]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M05_L50
       cmp       word ptr [rcx],7F
       ja        near ptr M05_L50
       mov       r9,rcx
       mov       r11d,edx
       lea       rdi,[r8+48]
       cmp       r11d,10
       jle       near ptr M05_L46
       vmovups   ymm0,[rdi]
       cmp       edx,20
       jle       near ptr M05_L43
       lea       r11d,[rdx-20]
       movsxd    r11,r11d
       lea       r11,[rcx+r11*2]
M05_L36:
       vpminuw   ymm1,ymm6,[r9]
       vpminuw   ymm2,ymm6,[r9+20]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFE9898B8A0]
       vbroadcastsd ymm3,qword ptr [7FFE9898B8C0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       je        near ptr M05_L66
       mov       r11,r9
       sub       r11,rcx
       shr       r11,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       add       r9d,r11d
M05_L37:
       mov       edi,r9d
       cmp       edi,edx
       jae       short M05_L38
       mov       r11d,edi
       cmp       word ptr [rcx+r11*2],7F
       ja        near ptr M05_L49
M05_L38:
       test      r9d,r9d
       jl        near ptr M05_L57
       mov       r10d,[rbp-0BC]
       add       r10d,r9d
       mov       rax,[rbp-1B8]
       mov       [rax+4C],r10d
       mov       r8d,r10d
       mov       r9d,r8d
       cmp       r9d,r12d
       ja        near ptr M05_L94
       mov       r8d,r9d
       lea       rdx,[r13+r8*2]
       mov       ecx,r12d
       sub       ecx,r9d
       xor       r8d,r8d
M05_L39:
       cmp       r8d,ecx
       jae       near ptr M05_L06
       movzx     r11d,word ptr [rdx+r8*2]
       cmp       r11d,100
       jge       near ptr M05_L05
       cmp       r11d,100
       jae       near ptr M05_L98
       mov       r11d,r11d
       mov       rdi,7FFEF7036090
       test      byte ptr [rdi+r11],80
       je        near ptr M05_L06
M05_L40:
       inc       r8d
       jmp       short M05_L39
M05_L41:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-238],rax
       test      rax,rax
       je        near ptr M05_L61
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-188],rax
       mov       [rbp-190],rsi
       mov       r8,[rbp-238]
       mov       [rbp-1A0],r8
       mov       esi,[rsi+44]
       mov       r10,[rbp-178]
       mov       r9,[r10+8]
       mov       [rbp-198],r9
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-1A8],rax
       mov       rdx,[rbp-188]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-188]
       mov       [rdx+10],rcx
       lea       rcx,[rdx+18]
       mov       rdx,[rbp-1A8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-188]
       mov       [rdx+30],ecx
       mov       rcx,2764A960C00
       mov       [rdx+28],rcx
       lea       rcx,[rdx+40]
       mov       rdx,[rbp-190]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,[rbp-188]
       lea       rcx,[rdx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[][]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,[rbp-188]
       lea       rcx,[rsi+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+48]
       mov       r8,[rsi+18]
       xor       edx,edx
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       [rsi+5C],r12d
       mov       byte ptr [rsi+60],0
       lea       rcx,[rsi+68]
       mov       rdx,[rbp-1A0]
       call      CORINFO_HELP_ASSIGN_REF
       vinsertf128 ymm6,ymm6,xmm7,1
M05_L42:
       mov       rax,[rbp-178]
       lea       rcx,[rax+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L33
M05_L43:
       lea       r11d,[rdx-10]
       movsxd    r11,r11d
       lea       r11,[rcx+r11*2]
       cmp       r9,r11
       ja        near ptr M05_L67
M05_L44:
       vpminuw   ymm1,ymm6,[r9]
       vpminuw   ymm2,ymm6,[r11]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFE9898B8A0]
       vbroadcastsd ymm2,qword ptr [7FFE9898B8C0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M05_L69
       vpermq    ymm0,ymm0,0D8
       vpmovmskb edi,ymm0
       tzcnt     edi,edi
       cmp       edi,10
       jge       near ptr M05_L68
M05_L45:
       sub       r9,rcx
       shr       r9,1
       add       r9d,edi
       jmp       near ptr M05_L37
M05_L46:
       vmovups   xmm0,[rdi]
       lea       r9d,[rdx-8]
       movsxd    r9,r9d
       lea       r9,[rcx+r9*2]
       cmp       rcx,r9
       ja        near ptr M05_L70
       mov       r11,rcx
M05_L47:
       vmovups   xmm1,[r11]
       vpminuw   xmm1,xmm1,[7FFE9898B8D0]
       vmovups   xmm2,[r9]
       vpminuw   xmm2,xmm2,[7FFE9898B8D0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFE9898B8A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFE9898B8C0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M05_L69
       vpmovmskb edi,xmm0
       tzcnt     edi,edi
       cmp       edi,8
       jge       near ptr M05_L71
M05_L48:
       sub       r11,rcx
       shr       r11,1
       lea       r9d,[r11+rdi]
       jmp       near ptr M05_L37
M05_L49:
       mov       r9d,edi
       lea       rcx,[rcx+r9*2]
       mov       [rbp-0C0],edi
       sub       edx,edi
       mov       r9d,[rbp-0C0]
M05_L50:
       mov       r11,rcx
       mov       [rbp-1C0],r11
       add       r8,88
       mov       [rbp-1C8],r8
       cmp       edx,10
       jge       near ptr M05_L72
       mov       ecx,edx
       lea       rcx,[r11+rcx*2]
       mov       [rbp-1D0],rcx
       mov       rdx,r11
       mov       r8,[r8]
       mov       [rbp-1D8],r8
       mov       rcx,[rbp-1C8]
       mov       ecx,[rcx+10]
       mov       [rbp-0C4],ecx
       mov       rcx,[rbp-1D0]
       cmp       r11,rcx
       je        short M05_L52
M05_L51:
       movzx     ecx,word ptr [rdx]
       mov       r11d,ecx
       imul      r11d,[rbp-0C4]
       mov       r8d,[r8+8]
       imul      r8,r11
       shr       r8,20
       mov       r11,[rbp-1D8]
       movzx     r8d,word ptr [r11+r8*2+10]
       cmp       r8d,ecx
       je        near ptr M05_L73
       add       rdx,2
       mov       rcx,[rbp-1D0]
       cmp       rdx,rcx
       mov       r8,r11
       jne       short M05_L51
M05_L52:
       mov       r11d,0FFFFFFFF
M05_L53:
       mov       edx,r11d
       test      edx,edx
       jl        short M05_L54
       lea       edx,[r11+r9]
M05_L54:
       mov       r9d,edx
       jmp       near ptr M05_L38
M05_L55:
       movzx     ecx,word ptr [r9]
       mov       r10d,r10d
       imul      r10,rcx
       add       rdx,10
       mov       r8d,r8d
       imul      rcx,r8
       lea       rcx,[rax+rcx+10]
       test      dword ptr [r9],1000000
       jne       short M05_L56
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L56:
       cmp       r10,4000
       ja        near ptr M05_L78
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      00007FFEF7E71380
       cmp       dword ptr [7FFEF8193A10],0
       vinsertf128 ymm6,ymm6,xmm7,1
       je        near ptr M05_L19
       jmp       near ptr M05_L76
M05_L57:
       mov       rax,[rbp-1B8]
       mov       [rax+4C],r12d
       jmp       near ptr M05_L24
M05_L58:
       lea       rcx,[rbp-80]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE9889FA50]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L26
M05_L59:
       lea       rcx,[rbp-80]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE9889FA50]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L27
M05_L60:
       mov       ecx,12D
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       rcx,rax
       call      qword ptr [7FFE98926688]
       int       3
M05_L61:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-180],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-178]
       mov       r9,[rsi+8]
       mov       rcx,rax
       call      qword ptr [7FFE9889F7F8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rcx,[rbp-180]
       vinsertf128 ymm6,ymm6,xmm7,1
       mov       rsi,rcx
       jmp       near ptr M05_L42
M05_L62:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       vinsertf128 ymm6,ymm6,xmm7,1
       jge       short M05_L63
       mov       r8d,20
M05_L63:
       cmp       eax,10
       mov       [rbp-0B4],eax
       jge       short M05_L64
       mov       dword ptr [rbp-0B4],10
M05_L64:
       mov       [rbp-0B8],r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Int32[]
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-0B8]
       mov       [rsi+50],edx
       movsxd    rdx,dword ptr [rbp-0B4]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B4]
       mov       [rsi+54],ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+58],20
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L34
M05_L65:
       inc       r10d
       mov       [rax+4C],r10d
       jmp       near ptr M05_L35
M05_L66:
       add       r9,40
       cmp       r9,r11
       jb        near ptr M05_L36
       jmp       near ptr M05_L43
M05_L67:
       mov       r9,r11
       jmp       near ptr M05_L44
M05_L68:
       mov       r9,r11
       add       edi,0FFFFFFF0
       jmp       near ptr M05_L45
M05_L69:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M05_L37
M05_L70:
       mov       r11,r9
       jmp       near ptr M05_L47
M05_L71:
       mov       r11,r9
       add       edi,0FFFFFFF8
       jmp       near ptr M05_L48
M05_L72:
       mov       [rbp-0C0],r9d
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE9889FAC8]; System.Buffers.ProbabilisticMap.IndexOfAnyVectorized[[System.Buffers.SearchValues+TrueConst, System.Private.CoreLib]](Char ByRef, Int32, System.Buffers.ProbabilisticMapState ByRef)
       mov       r11d,eax
       vinsertf128 ymm6,ymm6,xmm7,1
       mov       r9d,[rbp-0C0]
       jmp       near ptr M05_L53
M05_L73:
       mov       r11,rdx
       sub       r11,[rbp-1C0]
       shr       r11,1
       jmp       near ptr M05_L53
M05_L74:
       cmp       [rax+4C],r12d
       jne       near ptr M05_L65
       jmp       near ptr M05_L24
M05_L75:
       mov       [rbp-0C8],r9d
       mov       [rbp-0CC],r8d
       mov       r10d,[rbp-0CC]
       mov       r11d,[rbp-0C8]
       jmp       near ptr M05_L07
M05_L76:
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_POLL_GC
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L19
M05_L77:
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_POLL_GC
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L78:
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE987CE0D0]
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L79:
       mov       r9d,ecx
       jmp       near ptr M05_L09
M05_L80:
       mov       r11d,ecx
       jmp       near ptr M05_L10
M05_L81:
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_POLL_GC
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L19
M05_L82:
       mov       rcx,r9
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE987CE0D0]
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L83:
       mov       rcx,r9
       mov       r8,r10
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L84:
       mov       r10d,[rbp-0D4]
       mov       [rsp+20],r10d
       mov       [rsp+28],eax
       mov       rcx,[rbp-1E8]
       mov       edx,[rbp-0D8]
       mov       r8,[rbp-1E0]
       mov       r9d,[rbp-0DC]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE98927E88]
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L20
M05_L85:
       mov       [rbp-0CC],r10d
       mov       [rbp-0C8],r11d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-1F8]
       xor       edx,edx
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       vinsertf128 ymm6,ymm6,xmm7,1
       mov       r10d,[rbp-0CC]
       mov       r11d,[rbp-0C8]
       jmp       near ptr M05_L22
M05_L86:
       mov       [rbp-0CC],r10d
       mov       [rbp-0C8],r11d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M05_L98
       mov       rcx,[r8+10]
       mov       [rbp-210],rcx
       lea       edx,[r9*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       short M05_L88
M05_L87:
       mov       r8,[rbp-210]
       cmp       ecx,[r8+8]
       jae       near ptr M05_L98
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M05_L98
       mov       [rax+rcx*4+10],edx
       inc       ecx
M05_L88:
       mov       r10d,[rbp-0E8]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M05_L87
       mov       rcx,[rbp-200]
       mov       r8,rax
       xor       edx,edx
       vextractf128 xmm7,ymm6,1
       call      qword ptr [7FFE982457B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       vinsertf128 ymm6,ymm6,xmm7,1
       mov       r8,[rbp-200]
       mov       r9d,[rbp-0E8]
       mov       r10d,[rbp-0CC]
       mov       r11d,[rbp-0C8]
       jmp       near ptr M05_L23
M05_L89:
       mov       [rbp-120],r13
       mov       [rbp-118],r12d
       lea       rdx,[rbp-120]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [rax+20]
       vinsertf128 ymm6,ymm6,xmm7,1
       jmp       near ptr M05_L24
M05_L90:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,235B58021B0
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M05_L25
M05_L91:
       lea       rdx,[rbp-98]
       mov       r8,[rbp-1B0]
       mov       rcx,[r15+8]
       vextractf128 xmm7,ymm6,1
       call      qword ptr [r15+18]
       test      eax,eax
       vinsertf128 ymm6,ymm6,xmm7,1
       mov       r8,[rbp-1B0]
       je        near ptr M05_L107
       jmp       near ptr M05_L28
M05_L92:
       mov       edx,r12d
       mov       eax,1
       mov       r8,[rbp-168]
       test      byte ptr [r8+40],40
       je        short M05_L93
       xor       edx,edx
       mov       eax,0FFFFFFFF
M05_L93:
       cmp       ecx,edx
       je        near ptr M05_L107
       lea       edx,[rcx+rax]
       jmp       near ptr M05_L29
M05_L94:
       call      qword ptr [7FFE983B7198]
       int       3
M05_L95:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE98927E10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE98927E28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L96:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE98927E40]
       mov       rdi,rax
       mov       ecx,12D
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE985C6028]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L97:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE98927E58]
       mov       r14,rax
       mov       ecx,145
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE985C6028]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M05_L98:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L99:
       cmp       edx,eax
       jae       near ptr M05_L148
       add       r14d,[rcx+rdx*4]
       add       edx,2
       cmp       edx,eax
       jl        short M05_L99
       jmp       near ptr M05_L114
M05_L100:
       cmp       [r13+8],r14d
       jg        near ptr M05_L120
       mov       r10d,[r13+8]
       add       r10,r10
       mov       [rbp-150],r10
       mov       r8,r10
       lea       rdx,[r13+0C]
       mov       rcx,rbx
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r13+8]
       cmp       r8d,r14d
       ja        near ptr M05_L121
       mov       rcx,[rbp-150]
       add       rbx,rcx
       sub       r14d,r8d
M05_L101:
       mov       rax,[rbp-158]
       cmp       eax,esi
       jae       near ptr M05_L148
       mov       r8d,[rdi+rax*4]
       lea       ecx,[rax+1]
       cmp       ecx,esi
       jae       near ptr M05_L148
       mov       [rbp-158],rax
       lea       ecx,[rax+1]
       mov       r10d,[rdi+rcx*4]
       mov       [rbp-0EC],r10d
       mov       ecx,r8d
       mov       edx,r10d
       add       rcx,rdx
       mov       edx,[r15+8]
       cmp       rcx,rdx
       ja        near ptr M05_L119
       lea       rdx,[r15+r8*2+0C]
       mov       r8d,r10d
       cmp       r8d,r14d
       jg        near ptr M05_L120
       add       r8,r8
       mov       rcx,rbx
       call      qword ptr [7FFE98245818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-0EC]
       cmp       r10d,r14d
       ja        near ptr M05_L121
       mov       eax,r10d
       lea       rbx,[rbx+rax*2]
       sub       r14d,r10d
       mov       rax,[rbp-158]
       add       eax,2
       cmp       eax,esi
       jge       near ptr M05_L122
M05_L102:
       mov       [rbp-158],rax
       test      eax,eax
       je        near ptr M05_L101
       jmp       near ptr M05_L100
M05_L103:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M05_L03
M05_L104:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M05_L01
M05_L105:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,235B5802188
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FFE98246BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,235B5802190
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L02
M05_L106:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M05_L04
M05_L107:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-168]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-78]
       test      ecx,ecx
       mov       r14,[rbp-160]
       je        near ptr M05_L125
       mov       edx,[rbp-88]
       mov       rax,[rbp-80]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M05_L108
       cmp       ecx,r8d
       jae       near ptr M05_L148
       mov       r8d,ecx
       mov       [rax+r8*4+10],edx
       inc       ecx
       mov       [rbp-78],ecx
       jmp       short M05_L109
M05_L108:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE9889FA50]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
M05_L109:
       mov       edx,[rbx+8]
       sub       edx,[rbp-88]
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M05_L110
       cmp       eax,r8d
       jae       near ptr M05_L148
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-78],eax
       jmp       short M05_L111
M05_L110:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE9889FA50]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
M05_L111:
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       test      rcx,rcx
       jne       short M05_L112
       test      eax,eax
       jne       near ptr M05_L121
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M05_L113
M05_L112:
       cmp       [rcx+8],eax
       jb        near ptr M05_L121
       add       rcx,10
M05_L113:
       mov       r14d,eax
       shr       r14d,1
       dec       r14d
       mov       rdi,[rbp+20]
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       eax,1
       jg        near ptr M05_L99
M05_L114:
       mov       [rbp-0A8],rcx
       mov       [rbp-0A0],eax
       mov       rcx,235B5802198
       mov       rsi,[rcx]
       mov       r15,rbx
       mov       r13,rdi
       test      rsi,rsi
       jne       short M05_L115
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,235B5802188
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FFE98246BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,235B5802198
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L115:
       test      rsi,rsi
       jne       short M05_L116
       mov       ecx,1C
       call      qword ptr [7FFE9846C240]
       int       3
M05_L116:
       test      r14d,r14d
       jg        short M05_L118
       test      r14d,r14d
       jne       short M05_L117
       mov       r12,2764A960008
       jmp       near ptr M05_L124
M05_L117:
       mov       ecx,28
       call      qword ptr [7FFE984678E8]
       int       3
M05_L118:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFEF7ED9F20
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       cmp       [rsi+18],r8
       jne       short M05_L123
       mov       rbx,rax
       mov       rdi,[rbp-0A8]
       mov       esi,[rbp-0A0]
       xor       eax,eax
       cmp       eax,esi
       jl        near ptr M05_L102
       jmp       short M05_L122
M05_L119:
       mov       ecx,21
       call      qword ptr [7FFE984678E8]
       int       3
M05_L120:
       call      qword ptr [7FFE9865C780]
       int       3
M05_L121:
       call      qword ptr [7FFE983B7198]
       int       3
M05_L122:
       jmp       short M05_L124
M05_L123:
       mov       [rbp-130],rax
       mov       [rbp-128],r14d
       mov       [rbp-148],rbx
       mov       [rbp-140],rdi
       lea       rdx,[rbp-0A8]
       mov       [rbp-138],rdx
       lea       rdx,[rbp-130]
       lea       r8,[rbp-148]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L122
M05_L124:
       mov       r14,r12
M05_L125:
       mov       rbx,[rbp-80]
       test      rbx,rbx
       je        near ptr M05_L147
       mov       rcx,235B5801D18
       mov       rsi,[rcx]
       mov       edi,[rbx+8]
       lea       ecx,[rdi-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       short M05_L126
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       jne       short M05_L127
M05_L126:
       mov       ecx,7
       call      qword ptr [7FFE98926EC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M05_L127:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M05_L128
       mov       rcx,rsi
       call      qword ptr [7FFE987CEB98]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M05_L128:
       xor       r13d,r13d
       mov       r12d,1
       mov       ecx,[rax+8]
       cmp       ecx,r15d
       jbe       near ptr M05_L143
       mov       r13d,1
       mov       edx,10
       shlx      edx,edx,r15d
       cmp       edi,edx
       je        short M05_L129
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE98927930]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE98184000
       call      qword ptr [7FFE984677B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE985C6028]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M05_L129:
       cmp       r15d,ecx
       jae       near ptr M05_L148
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp-220],rax
       mov       r8,[rax]
       mov       [rbp-228],r8
       mov       rcx,rax
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-220]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-228],0
       je        near ptr M05_L143
       mov       rcx,[rsi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M05_L148
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M05_L130
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE98927948]
       mov       r8,rax
M05_L130:
       mov       r12,[r8+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE9818B18C],0
       je        short M05_L131
       call      qword ptr [7FFE98927960]
       mov       edx,eax
       mov       [rbp-100],edx
       jmp       short M05_L133
M05_L131:
       mov       ecx,9
       call      qword ptr [7FFE98927978]
       mov       eax,[rax+10]
       mov       [rbp-104],eax
       mov       ecx,9
       call      qword ptr [7FFE98927978]
       mov       edx,[rbp-104]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M05_L132
       call      qword ptr [7FFE98927990]
       mov       edx,eax
       mov       [rbp-100],edx
       jmp       short M05_L133
M05_L132:
       sar       edx,10
       mov       [rbp-100],edx
M05_L133:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE98245740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-100]
       xor       edx,edx
       div       dword ptr [7FFE9818B180]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M05_L140
M05_L134:
       cmp       eax,[r12+8]
       jae       near ptr M05_L148
       mov       [rbp-0F8],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-230],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-108],r10d
       mov       rcx,r8
       call      qword ptr [7FFE9874D740]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M05_L136
       test      r8d,r8d
       jne       short M05_L137
       xor       edx,edx
       mov       [rax+14],edx
M05_L135:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp-228]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-10C]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-108],1
M05_L136:
       mov       rcx,rax
       call      qword ptr [7FFE98246820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-108],0
       je        short M05_L138
       jmp       short M05_L141
M05_L137:
       jmp       short M05_L135
M05_L138:
       mov       eax,[rbp-0F8]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M05_L139
       xor       ecx,ecx
M05_L139:
       mov       edx,[rbp-0FC]
       inc       edx
       mov       eax,ecx
M05_L140:
       mov       [rbp-0FC],edx
       cmp       [r12+8],edx
       jg        near ptr M05_L134
       jmp       short M05_L142
M05_L141:
       mov       r12d,1
       jmp       short M05_L143
M05_L142:
       xor       r12d,r12d
M05_L143:
       mov       rcx,235B5800C90
       mov       rax,[rcx]
       mov       [rbp-218],rax
       cmp       byte ptr [rax+9D],0
       je        near ptr M05_L146
       test      edi,edi
       je        near ptr M05_L146
       mov       rcx,rbx
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0F0],eax
       mov       [rbp-0F4],edi
       mov       rcx,rsi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-218]
       mov       r8d,[rbp-0F0]
       mov       r9d,[rbp-0F4]
       mov       edx,3
       call      qword ptr [7FFE98927768]
       test      r12d,r13d
       jne       short M05_L146
       mov       rcx,rbx
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rsi
       call      qword ptr [7FFE9865CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M05_L144
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M05_L145
M05_L144:
       mov       ecx,r15d
       xor       edx,edx
M05_L145:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rbp-218]
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFE989279A8]
M05_L146:
       xor       eax,eax
       mov       [rbp-80],rax
M05_L147:
       mov       rax,r14
       vzeroupper
       vmovaps   xmm6,[rsp+230]
       vmovaps   xmm7,[rsp+220]
       add       rsp,248
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L148:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-178]
       mov       [rsi+8],rcx
       mov       r8,[rbp-168]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 6694
```
```assembly
; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M06_L00
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFEF7CB25D0]
       test      rax,rax
       je        short M06_L02
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      qword ptr [7FFEF7CA3FE8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      qword ptr [7FFEF7CA3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M06_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFEF7CB71F0]
       int       3
M06_L01:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFEF7CB71F0]
       int       3
M06_L02:
       call      qword ptr [7FFEF7CAE538]
       mov       rbx,rax
       call      qword ptr [7FFEF7CB9268]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB7188]
       mov       rcx,rbx
       call      qword ptr [7FFEF7CA3FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFEF7CBCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M07_L01
       cmp       [rax],ecx
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M07_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],edx
       jle       short M07_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M07_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
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
       je        short M08_L00
       cmp       [rdx],rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       ret
M08_L01:
       jmp       qword ptr [7FFE9824FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       je        short M09_L00
       call      qword ptr [7FFEF7CBCBF8]
       int       3
M09_L00:
       test      rsi,rsi
       je        short M09_L02
       mov       rcx,rsi
       call      qword ptr [7FFEF7CBCBB8]
       test      eax,eax
       jne       short M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFEF7CBCBC8]
M09_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEF7CB71F0]
       int       3
; Total bytes of code 70
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M10_L00
       mov       rcx,rbx
       call      00007FFEF7EE2C80
       test      eax,eax
       jne       short M10_L01
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       xor       ecx,ecx
       call      qword ptr [7FFE98926688]
       int       3
M10_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE989270F0]
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
       call      qword ptr [7FFEF7CBF528]
       test      rax,rax
       je        short M11_L04
M11_L00:
       mov       rcx,rax
       or        rcx,1
       test      edi,edi
       cmove     rcx,rax
       mov       [rsi+8],rcx
       test      rbx,rbx
       je        short M11_L02
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB20A8]
       test      rax,rax
       jne       short M11_L06
       call      qword ptr [7FFEF7CA4408]
       cmp       qword ptr [rax+8],0
       jne       short M11_L05
       xor       edi,edi
M11_L01:
       test      edi,edi
       jne       short M11_L06
M11_L02:
       xor       eax,eax
M11_L03:
       test      rax,rax
       jne       short M11_L07
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FFEF7CBF530]
       jmp       short M11_L00
M11_L05:
       call      qword ptr [7FFEF7CA4408]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M11_L01
M11_L06:
       mov       rcx,rbx
       call      qword ptr [7FFEF7CB56A0]
       jmp       short M11_L03
M11_L07:
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M12_L13
       cmp       rsi,rdi
       je        near ptr M12_L04
       cmp       rbx,20
       jae       near ptr M12_L06
       mov       rcx,7FFE98917930
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M12_L01
       mov       rcx,7FFE98917948
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE9891794C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M12_L00:
       mov       rcx,7FFE98917914
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M12_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M12_L05
M12_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M12_L17
       mov       rcx,7FFE98917934
       call      CORINFO_HELP_COUNTPROFILE32
M12_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M12_L18
       mov       rcx,7FFE98917938
       call      CORINFO_HELP_COUNTPROFILE32
M12_L04:
       mov       rcx,7FFE98917918
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L05:
       mov       rcx,7FFE98917944
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L09
M12_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        short M12_L11
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M12_L08
M12_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M12_L10
       mov       rcx,7FFE98917928
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M12_L07
M12_L08:
       mov       rcx,7FFE9891792C
       call      CORINFO_HELP_COUNTPROFILE32
M12_L09:
       mov       rcx,7FFE98917950
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L10:
       mov       rcx,7FFE9891791C
       call      CORINFO_HELP_COUNTPROFILE32
M12_L11:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M12_L12
       mov       rcx,7FFE98917920
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L04
M12_L12:
       mov       rcx,7FFE98917924
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L09
M12_L13:
       cmp       rbx,4
       jb        short M12_L14
       mov       rcx,7FFE98917910
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M12_L00
M12_L14:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M12_L15
       mov       rcx,7FFE98917908
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M12_L15:
       test      bl,1
       je        short M12_L16
       mov       rcx,7FFE9891790C
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M12_L16:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M12_L00
M12_L17:
       mov       rcx,7FFE98917940
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M12_L05
       jmp       near ptr M12_L02
M12_L18:
       mov       rcx,7FFE9891793C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L09
; Total bytes of code 685
```

