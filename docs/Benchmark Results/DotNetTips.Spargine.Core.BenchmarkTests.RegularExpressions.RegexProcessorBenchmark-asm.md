## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1CE6C4000D0
       mov       rsi,[rcx]
       mov       edi,0E
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,20EEB370698
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
       call      qword ptr [7FF9F81E7510]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F824C348],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1CE6C400168
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
       call      qword ptr [7FF9F81E75A0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81E75A0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F7B05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FF9F81EFEB8]
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
       jmp       qword ptr [7FF9F81EFEE8]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1C9CB8000F0
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
       call      qword ptr [7FF9F821F0F0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L05
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
       jle       short M00_L07
       xor       ecx,ecx
       mov       [rsi+8],rcx
       xor       r14d,r14d
       jmp       short M00_L09
M00_L05:
       mov       rcx,[r13+30]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L10
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[r13+30]
       mov       [rsp+20],r14d
       mov       r8,[r13+30]
       mov       r8d,[r8+44]
       mov       r9,[r13+8]
       mov       rcx,r15
       call      qword ptr [7FF9F821F180]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[r15+68]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       test      byte ptr [7FF9F82C1020],1
       je        near ptr M00_L13
M00_L08:
       mov       rcx,1C9CB8001B0
       mov       r14,[rcx]
M00_L09:
       jmp       near ptr M00_L14
M00_L10:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [rsp+20],r14d
       mov       r8,[r13+30]
       mov       r8d,[r8+44]
       mov       rdx,[r13+30]
       mov       r9,[r13+8]
       mov       rcx,r15
       call      qword ptr [7FF9F821F180]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M00_L06
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
       jmp       near ptr M00_L08
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
       call      qword ptr [7FF9F82D7120]
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
       jmp       qword ptr [7FF9F82D7150]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,239738020F0
       mov       rsi,[rcx]
       mov       edi,10
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,27A08A50698
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
       call      qword ptr [7FF9F822EFE8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82BC908],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,239738021A8
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
       call      qword ptr [7FF9F822F078]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F822F078]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82E6F70]
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
       jmp       qword ptr [7FF9F82E6FA0]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,23FE14020F0
       mov       rsi,[rcx]
       mov       edi,3
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,28076370698
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
       call      qword ptr [7FF9F81FEFD0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       mov       rcx,23FE1402178
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
       call      qword ptr [7FF9F81FF060]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81FF060]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82B6CB8]
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
       jmp       qword ptr [7FF9F82B6DC0]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,217D68020C0
       mov       rsi,[rcx]
       mov       edi,13
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2586B950670
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
       call      qword ptr [7FF9F81D7420]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F823BD38],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,217D6802160
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
       call      qword ptr [7FF9F81D74B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81D74B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F7AF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FF9F81DFF90]
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
       jmp       qword ptr [7FF9F81DFFC0]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7AF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2075A8020C8
       mov       rsi,[rcx]
       mov       edi,24
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,247EF840698
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
       call      qword ptr [7FF9F81D7438]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F8238228],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,2075A802160
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
       call      qword ptr [7FF9F81D74C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81D74C8]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81DFBE8]
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
       jmp       qword ptr [7FF9F81DFC18]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7AF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2213F8020F0
       mov       rsi,[rcx]
       mov       edi,0B
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,261D4960698
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
       call      qword ptr [7FF9F822F0C0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       je        near ptr M00_L08
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
       jg        short M00_L06
       xor       ecx,ecx
       mov       [rdi+8],rcx
       test      byte ptr [7FF9F82D09E8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,2213F8021A8
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
       mov       dword ptr [rsp+20],0B
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF9F822F150]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L10
M00_L09:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],0B
       mov       r8,[r15+30]
       mov       r8d,[r8+44]
       mov       rdx,[r15+30]
       mov       r9,r14
       mov       rcx,rdi
       call      qword ptr [7FF9F822F150]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82E6E38]
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
       jmp       qword ptr [7FF9F82E6E68]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,128E74000F8
       mov       rsi,[rcx]
       mov       edi,27
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,16966420698
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
       call      qword ptr [7FF9F821F078]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82C09E8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,128E74001B0
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
       call      qword ptr [7FF9F821F108]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F821F108]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82D6DA8]
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
       jmp       qword ptr [7FF9F82D6DD8]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1E3A7C020E8
       mov       rsi,[rcx]
       mov       edi,0D
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2243CB30670
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
       call      qword ptr [7FF9F821EEC8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82AC2E8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1E3A7C021A8
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
       call      qword ptr [7FF9F821EF58]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F821EF58]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82D6DF0]
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
       jmp       qword ptr [7FF9F82D6E20]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1BD368020F0
       mov       rsi,[rcx]
       mov       edi,11
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1FDCBAA0698
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
       call      qword ptr [7FF9F820EFD0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F829C908],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,1BD368021A8
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
       call      qword ptr [7FF9F820F060]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F820F060]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82C6C88]
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
       jmp       qword ptr [7FF9F82C6CB8]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7AF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,132038000F8
       mov       rsi,[rcx]
       mov       edi,8
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,17282990698
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
       call      qword ptr [7FF9F821F0A8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82C09C8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,132038001B0
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
       call      qword ptr [7FF9F821F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F821F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82D6F28]
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
       jmp       qword ptr [7FF9F82D6F58]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,282DB0020F0
       mov       rsi,[rcx]
       mov       edi,28
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2C370160698
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
       call      qword ptr [7FF9F821F1E0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82C1650],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,282DB0021A8
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
       call      qword ptr [7FF9F821F270]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F821F270]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82D7030]
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
       jmp       qword ptr [7FF9F82D7060]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,172A88000F8
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,1B3276D0698
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
       call      qword ptr [7FF9F822F0A8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F82D09E8],1
       je        near ptr M00_L13
M00_L05:
       mov       rcx,172A88001B0
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
       call      qword ptr [7FF9F822F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F822F138]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82E6FD0]
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
       jmp       qword ptr [7FF9F82E7000]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,26919C020F0
       mov       rsi,[rcx]
       mov       edi,15
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       [rbp-48],rsi
       mov       r14,2A9AEA20698
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
       call      qword ptr [7FF9F822EFE8]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       mov       rcx,26919C02178
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
       call      qword ptr [7FF9F822F078]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F822F078]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F82E70C0]
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
       jmp       qword ptr [7FF9F82E70F0]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9F8005AA0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rbx,rax
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L29
       mov       rcx,271F9401370
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       mov       rax,271F9400108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       call      qword ptr [7FF9F7D940D8]; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rsi,rax
M00_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F8006058]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L23
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L22
       mov       rcx,rdi
       mov       rdx,2B28E550698
       mov       r9d,1
       call      qword ptr [7FF9F8006A48]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
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
       mov       rcx,271F94020C8
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
       call      qword ptr [7FF9F81F7540]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       test      byte ptr [7FF9F825C378],1
       je        near ptr M00_L17
M00_L09:
       mov       rcx,271F9402160
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
       call      qword ptr [7FF9F82B41B0]
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
       call      qword ptr [7FF9F81F75D0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F81FFEE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L21:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L22:
       mov       rcx,rdi
       mov       rdx,2B28E550698
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
       call      qword ptr [7FF9F81FFF00]
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
       call      qword ptr [7FF9F806DC28]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF9F7C7D950]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L27
       cmp       r14,rdi
       je        short M00_L24
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,2B28E550698
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
       call      qword ptr [7FF9F7B15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       r8,271F9401370
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,2B28E550698
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L30:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F82B4168]
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
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
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
; Total bytes of code 1585
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
       mov       rbx,271F9401368
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
       mov       rcx,2B28E54B988
       call      qword ptr [7FF9F82B43D8]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,2B28E54B910
       call      qword ptr [7FF9F8005AD0]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 101
```
```assembly
; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rax,271F94000F8
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9F7D940F0]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
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
       jne       near ptr M03_L21
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M03_L20
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L23
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M03_L22
M03_L01:
       cmp       rdi,rdx
       jne       near ptr M03_L17
M03_L02:
       mov       rax,271F9400100
       mov       rax,[rax]
       mov       [rbp+18],rax
M03_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L26
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       jne       near ptr M03_L10
       mov       rcx,[rbp-30]
       call      00007FFA57629E20
       test      eax,eax
       je        near ptr M03_L11
M03_L04:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M03_L13
       mov       rcx,[rbp+18]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M03_L12
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+38]
       mov       rdx,[rdx+8]
       cmp       rax,rdx
       jne       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       mov       rbx,[rax+10]
       jmp       near ptr M03_L15
M03_L07:
       test      rax,rax
       je        near ptr M03_L14
       test      rdx,rdx
       je        near ptr M03_L14
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L14
       lea       r10,[rax+0C]
       add       rdx,0C
       mov       r8d,[rax+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L08
       mov       rcx,r10
       call      qword ptr [7FF9F7B1FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L09
M03_L08:
       mov       rax,[r10]
       mov       r8,[r10+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M03_L09:
       test      eax,eax
       je        near ptr M03_L24
       jmp       short M03_L06
M03_L10:
       call      qword ptr [7FF9F81FFF30]
       int       3
M03_L11:
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F81FFF48]
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,2B28E540008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M03_L05
M03_L14:
       xor       eax,eax
       jmp       short M03_L09
M03_L15:
       cmp       byte ptr [rbp-28],0
       je        short M03_L16
       mov       rcx,[rbp-30]
       call      00007FFA576E6030
       test      eax,eax
       jne       near ptr M03_L25
M03_L16:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       test      rdi,rdi
       je        near ptr M03_L03
       test      rdx,rdx
       je        near ptr M03_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L03
       lea       rax,[rdi+0C]
       add       rdx,0C
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L18
       mov       rcx,rax
       call      qword ptr [7FF9F7B1FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L19
M03_L18:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M03_L19:
       test      eax,eax
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L20:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,2B28E540008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L21:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M03_L23
M03_L22:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,2B28E540008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M03_L01
M03_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M03_L01
M03_L24:
       call      M03_L30
       jmp       short M03_L26
M03_L25:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF9F81FFCF0]
       jmp       near ptr M03_L16
M03_L26:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M03_L27
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B89590]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L27
       mov       rcx,rbx
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
M03_L27:
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L29
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+38],0
       je        short M03_L28
       mov       rdx,[rcx+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       lea       rcx,[rax+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L28
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
M03_L28:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L29:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L30:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L31
       mov       rcx,[rbp-30]
       call      00007FFA576E6030
       test      eax,eax
       je        short M03_L31
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF9F81FFCF0]
M03_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
M03_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L33
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
M03_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1123
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
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M04_L37
       mov       rax,[rcx+28]
       mov       [rbp-68],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M04_L38
       test      rbx,rbx
       je        near ptr M04_L38
       mov       [rbp-70],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       jne       near ptr M04_L15
       mov       rcx,rbx
       call      00007FFA57629E20
       test      eax,eax
       je        near ptr M04_L16
M04_L00:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L29
       mov       rsi,[rbx+18]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       jne       near ptr M04_L17
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M04_L02
       lea       r11,[rdx+0C]
M04_L01:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       edi
       jne       short M04_L01
M04_L02:
       mov       edi,ecx
M04_L03:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M04_L33
       mov       r8d,r8d
       lea       rcx,[rcx+r8*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       cmp       [r15+8],r14d
       jbe       near ptr M04_L29
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       jne       near ptr M04_L12
M04_L04:
       mov       ecx,r14d
       shl       rcx,5
       lea       r12,[r15+rcx+10]
       cmp       [r12+8],edi
       jne       near ptr M04_L20
       mov       rax,[r12]
       cmp       rax,rdx
       jne       short M04_L09
       mov       esi,1
M04_L05:
       test      esi,esi
       je        near ptr M04_L20
M04_L06:
       add       r12,10
M04_L07:
       test      r12,r12
       je        near ptr M04_L14
       vmovdqu   xmm0,xmmword ptr [r12]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M04_L30
M04_L08:
       mov       [rbp-78],rsi
       jmp       near ptr M04_L35
M04_L09:
       test      rax,rax
       je        near ptr M04_L19
       mov       ecx,[rax+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       near ptr M04_L19
       lea       rcx,[rax+0C]
       lea       r10,[rdx+0C]
       mov       r8d,[rax+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M04_L10
       mov       rdx,r10
       call      qword ptr [7FF9F7B1FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       esi,eax
       jmp       short M04_L11
M04_L10:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       rax,[r10]
       xor       r8,rax
       xor       rcx,[r10+2]
       or        rcx,r8
       sete      sil
       movzx     esi,sil
M04_L11:
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L05
M04_L12:
       mov       ecx,r14d
       shl       rcx,5
       lea       r12,[r15+rcx+10]
       cmp       [r12+8],edi
       jne       near ptr M04_L27
       mov       rax,[r12]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       jne       near ptr M04_L21
       cmp       rax,rdx
       jne       near ptr M04_L22
       jmp       near ptr M04_L26
M04_L13:
       test      r10d,r10d
       jne       near ptr M04_L06
       jmp       near ptr M04_L27
M04_L14:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9F8006AC0]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M04_L34
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F8006B38]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF9F8006BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L08
M04_L15:
       call      qword ptr [7FF9F81FFF30]
       int       3
M04_L16:
       mov       rcx,rbx
       call      qword ptr [7FF9F81FFF48]
       jmp       near ptr M04_L00
M04_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FF9F7A609C8
       call      qword ptr [r11]
       mov       edi,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L03
M04_L18:
       cmp       [r15+8],r14d
       jbe       near ptr M04_L29
       jmp       near ptr M04_L04
M04_L19:
       xor       esi,esi
       jmp       near ptr M04_L05
M04_L20:
       mov       r14d,[r12+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jae       short M04_L18
       jmp       near ptr M04_L28
M04_L21:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,rax
       mov       r11,7FF9F7A609D0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L13
M04_L22:
       test      rax,rax
       je        short M04_L25
       mov       ecx,[rax+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       short M04_L25
       add       rax,0C
       lea       r10,[rdx+0C]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M04_L23
       mov       rcx,rax
       mov       rdx,r10
       call      qword ptr [7FF9F7B1FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L24
M04_L23:
       mov       rdx,[rbp+18]
       mov       rcx,rax
       mov       r8,r10
       mov       r11,[rcx]
       mov       rcx,[rcx+2]
       mov       rax,[r8]
       xor       r11,rax
       xor       rcx,[r8+2]
       or        rcx,r11
       sete      r10b
       movzx     r10d,r10b
M04_L24:
       jmp       near ptr M04_L13
M04_L25:
       xor       r10d,r10d
       jmp       near ptr M04_L13
M04_L26:
       mov       r10d,1
       jmp       near ptr M04_L13
M04_L27:
       mov       r14d,[r12+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M04_L28
       cmp       [r15+8],r14d
       jbe       short M04_L29
       jmp       near ptr M04_L12
M04_L28:
       call      qword ptr [7FF9F7D979A8]
       int       3
M04_L29:
       xor       r12d,r12d
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L07
M04_L30:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M04_L31
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F81FFFC0]
       jmp       short M04_L32
M04_L31:
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F81766B8]; System.Resources.ResourceReader.LoadString(Int32)
M04_L32:
       mov       [rbp-78],rax
       jmp       short M04_L35
M04_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L34:
       call      M04_L51
       jmp       near ptr M04_L40
M04_L35:
       cmp       byte ptr [rbp-50],0
       je        short M04_L36
       mov       rcx,[rbp-70]
       call      00007FFA576E6030
       test      eax,eax
       jne       short M04_L39
M04_L36:
       mov       rax,[rbp-78]
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
M04_L37:
       mov       ecx,13BFC
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       rcx,rax
       call      qword ptr [7FF9F81FFCD8]
       int       3
M04_L38:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F81FFF90]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F81FFFA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L39:
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9F81FFCF0]
       jmp       short M04_L36
M04_L40:
       cmp       byte ptr [rbp+20],0
       jne       short M04_L41
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
M04_L41:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M04_L42
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,271F9400070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F80068F8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M04_L42:
       mov       [rbp-70],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M04_L45
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FF9F81FFFD8]
       jmp       short M04_L44
M04_L43:
       mov       rcx,rsi
       call      qword ptr [7FF9F8073BD8]
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
       call      qword ptr [7FF9F8006BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M04_L44:
       mov       rcx,rsi
       call      qword ptr [7FF9F8073BD0]
       test      eax,eax
       jne       short M04_L43
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M04_L45:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F8071F60]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M04_L46
       xor       r8d,r8d
       mov       [rbp-78],r8
       jmp       short M04_L49
M04_L46:
       cmp       qword ptr [rbp-48],0
       je        short M04_L47
       mov       r8,[rbp-48]
       mov       [rbp-78],r8
       jmp       short M04_L49
M04_L47:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-68]
       mov       edx,[rbp-40]
       call      qword ptr [7FF9F8006B38]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M04_L48
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF9F8006BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M04_L48:
       cmp       byte ptr [rbp-50],0
       je        short M04_L50
       mov       rcx,[rbp-70]
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M04_L50
M04_L49:
       call      M04_L53
       jmp       near ptr M04_L36
M04_L50:
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
M04_L51:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L52
       mov       rcx,[rbp-70]
       call      00007FFA576E6030
       test      eax,eax
       je        short M04_L52
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9F81FFCF0]
M04_L52:
       nop
       add       rsp,28
       ret
M04_L53:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L54
       mov       rcx,[rbp-70]
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
M04_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1631
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9F82B4198]
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       jmp       qword ptr [7FF9F7B15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA57560D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF9F7B1FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rsi],0
       jne       short M10_L02
       test      rbx,rbx
       je        short M10_L01
       mov       rcx,rbx
       call      qword ptr [7FFA57560C38]
       test      eax,eax
       je        short M10_L03
M10_L00:
       mov       byte ptr [rsi],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA5755B268]
       int       3
M10_L02:
       call      qword ptr [7FFA57560C78]
       int       3
M10_L03:
       mov       rcx,rbx
       call      qword ptr [7FFA57560C48]
       jmp       short M10_L00
; Total bytes of code 72
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      00007FFA576E6030
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FF9F81FFCD8]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F81FFCF0]
; Total bytes of code 56
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,15ED2C020F0
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
       mov       rdx,7FF9F832ACF0
       call      qword ptr [7FF9F7B06E20]
M00_L02:
       jmp       short M00_L04
M00_L03:
       xor       eax,eax
M00_L04:
       test      rax,rax
       je        short M00_L05
       mov       [rsp+28],rax
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       mov       rdx,19F67CF0008
       cmp       rcx,rdx
       je        short M00_L09
       jmp       near ptr M00_L14
M00_L05:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,19F67CF0008
       call      qword ptr [7FF9F820EBB0]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L17
       test      r14,r14
       je        short M00_L06
       cmp       qword ptr [7FF9F7A4B020],0
       jne       near ptr M00_L18
M00_L06:
       xor       eax,eax
M00_L07:
       test      r15b,2
       jne       near ptr M00_L19
       test      rax,rax
       jne       near ptr M00_L19
       mov       rcx,r15
       mov       rdx,r14
       call      00007FFA57617580
M00_L08:
       mov       [rsp+28],r14
M00_L09:
       mov       rax,[rsp+28]
       cmp       [rax],al
       mov       rbp,19F67D00698
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
       mov       r8,19F67CF0008
M00_L10:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F820ED78]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L11:
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
M00_L12:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F7B06D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L13
       call      qword ptr [7FF9F82C6850]
       int       3
M00_L13:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFA576EFBA0
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L14:
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L05
       lea       r10,[rcx+0C]
       mov       rdx,19F67CF0014
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
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L16:
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L05
M00_L17:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82CD380]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       rax,[7FF9F7A4B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,r14
       call      qword ptr [7FF9F82CD398]
       jmp       near ptr M00_L07
M00_L19:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF9F82CD3B0]
       jmp       near ptr M00_L08
M00_L20:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F82C76C0]
       int       3
M00_L21:
       mov       r8,[rax+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L23
       mov       r8,[r8+10]
       jmp       near ptr M00_L10
M00_L22:
       mov       [rsp+20],edi
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F82C76D8]
       jmp       near ptr M00_L11
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 765
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
       mov       rax,781CBCFF1E8D
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M01_L07
       mov       rax,15ED2C00100
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
       call      qword ptr [7FF9F820EC10]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M01_L04
M01_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FF9F7FF6880]; System.String.IndexOf(Char, Int32, Int32)
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
       call      qword ptr [7FF9F82CED18]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FF9F82CED30]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F82CED48]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M01_L01
M01_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M01_L08
M01_L05:
       mov       rax,r14
       mov       r8,781CBCFF1E8D
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
       call      qword ptr [7FF9F7D85D88]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M01_L00
M01_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,15ED2C01D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81D1698]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M01_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,15ED2C01D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81D1698]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
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
       mov       rdx,19F67D00D70
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,15ED2C02190
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
       call      qword ptr [7FF9F820F048]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>F84DEA1CB092AF406657C3B70F337DE6861063B8A819E9C09542127B324ABDBC4__RemoveHtmlRegex_14+RunnerFactory+Runner
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
       call      qword ptr [7FF9F7CA7738]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F820F228]; System.Text.RegularExpressions.Generated.<RegexGenerator_g>F84DEA1CB092AF406657C3B70F337DE6861063B8A819E9C09542127B324ABDBC4__RemoveHtmlRegex_14+RunnerFactory+Runner.TryMatchAtCurrentPosition(System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F820F1B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       mov       rcx,15ED2C021B0
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M02_L11
M02_L20:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L12
M02_L21:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
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
       call      qword ptr [7FF9F820F1B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
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
       call      qword ptr [7FF9F7CA7138]
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
       mov       rcx,15ED2C02198
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L58
M02_L40:
       test      r14d,r14d
       jle       near ptr M02_L48
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
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
       mov       rcx,15ED2C01D10
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
       mov       rcx,15ED2C00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L77
M02_L46:
       xor       eax,eax
       mov       [rbp-58],rax
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
       call      qword ptr [7FF9F7D87870]
       int       3
M02_L49:
       mov       r15,19F67CF0008
       jmp       near ptr M02_L41
M02_L50:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L35
M02_L51:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F300]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
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
       mov       rdx,15ED2C02188
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15ED2C02190
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
       call      qword ptr [7FF9F7CA7138]
       int       3
M02_L58:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,15ED2C02188
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15ED2C02198
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L40
M02_L59:
       mov       ecx,7
       call      qword ptr [7FF9F82C6D18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L43
M02_L60:
       mov       rcx,rbx
       call      qword ptr [7FF9F816E1A8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M02_L44
M02_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F82C7510]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,rsi
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
       call      qword ptr [7FF9F82C7528]
M02_L63:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A4B184],0
       je        short M02_L64
       call      qword ptr [7FF9F82C7540]
       mov       [rbp-0A8],eax
       jmp       short M02_L66
M02_L64:
       mov       ecx,9
       call      qword ptr [7FF9F82C7558]
       mov       eax,[rax+10]
       mov       [rbp-0AC],eax
       mov       ecx,9
       call      qword ptr [7FF9F82C7558]
       mov       ecx,[rbp-0AC]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L65
       call      qword ptr [7FF9F82C7570]
       mov       edx,eax
       mov       [rbp-0A8],edx
       jmp       short M02_L66
M02_L65:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rbp-0A8],edx
M02_L66:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0A8]
       xor       edx,edx
       div       dword ptr [7FF9F7A4B178]
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
       call      qword ptr [7FF9F80ED5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-98],eax
       mov       edx,[rsi+8]
       mov       [rbp-9C],edx
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-98]
       mov       r9d,[rbp-9C]
       mov       edx,3
       call      qword ptr [7FF9F82C7588]
       test      r13d,r15d
       jne       near ptr M02_L46
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F82C75A0]
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
; Total bytes of code 3144
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
       call      qword ptr [7FFA575635D8]
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
       call      qword ptr [7FFA57556148]
       test      rax,rax
       jne       short M03_L06
       call      qword ptr [7FFA575483F0]
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
       call      qword ptr [7FFA575635E0]
       jmp       short M03_L00
M03_L05:
       call      qword ptr [7FFA575483F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FFA57559728]
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
       jb        near ptr M04_L14
       cmp       rsi,rdi
       je        near ptr M04_L04
       cmp       rbx,20
       jae       near ptr M04_L06
       mov       rcx,7FF9F82DAFE8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M04_L01
       mov       rcx,7FF9F82DB000
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9F82DB004
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
       mov       rcx,7FF9F82DAFCC
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
       ja        near ptr M04_L18
       mov       rcx,7FF9F82DAFEC
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L10
       mov       rcx,7FF9F82DAFF0
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF9F82DAFD0
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
       mov       rcx,7FF9F82DAFFC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M04_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L08
M04_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M04_L11
       mov       rcx,7FF9F82DAFE0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M04_L07
M04_L08:
       mov       rcx,7FF9F82DAFE4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L09:
       mov       rcx,7FF9F82DB008
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
       mov       rcx,7FF9F82DAFF4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L11:
       mov       rcx,7FF9F82DAFD4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L13
       mov       rcx,7FF9F82DAFD8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L04
M04_L13:
       mov       rcx,7FF9F82DAFDC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L14:
       cmp       rbx,4
       jb        short M04_L15
       mov       rcx,7FF9F82DAFC8
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
M04_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M04_L16
       mov       rcx,7FF9F82DAFC0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M04_L16:
       test      bl,1
       je        short M04_L17
       mov       rcx,7FF9F82DAFC4
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M04_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L18:
       mov       rcx,7FF9F82DAFF8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L05
       jmp       near ptr M04_L02
; Total bytes of code 686
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,20C6C8020F0
       mov       rsi,[rcx]
       mov       edi,0D
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
       mov       rdx,7FF9F8338BF0
       call      qword ptr [7FF9F7B06E20]
M00_L02:
       jmp       short M00_L04
M00_L03:
       xor       eax,eax
M00_L04:
       test      rax,rax
       je        short M00_L05
       mov       [rsp+28],rax
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       mov       rdx,24D01920008
       cmp       rcx,rdx
       je        short M00_L09
       jmp       near ptr M00_L14
M00_L05:
       mov       [rsp+20],r13
       mov       edx,r12d
       mov       r8,r14
       mov       r9d,r15d
       mov       rcx,24D01920008
       call      qword ptr [7FF9F820F000]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       r15,[rbp+8]
       and       r15,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L17
       test      r14,r14
       je        short M00_L06
       cmp       qword ptr [7FF9F7A4B020],0
       jne       near ptr M00_L18
M00_L06:
       xor       eax,eax
M00_L07:
       test      r15b,2
       jne       near ptr M00_L19
       test      rax,rax
       jne       near ptr M00_L19
       mov       rcx,r15
       mov       rdx,r14
       call      00007FFA57617580
M00_L08:
       mov       [rsp+28],r14
M00_L09:
       mov       rax,[rsp+28]
       cmp       [rax],al
       mov       rbp,24D01930698
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
       mov       r8,24D01920008
M00_L10:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F820F1C8]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L11:
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
M00_L12:
       lea       rbp,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F7B06D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rbp,rbp
       jne       short M00_L13
       call      qword ptr [7FF9F82C68C8]
       int       3
M00_L13:
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFA576EFBA0
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L00
       mov       rbp,[rsi+38]
       jmp       near ptr M00_L00
M00_L14:
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L05
       lea       r10,[rcx+0C]
       mov       rdx,24D01920014
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
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L16:
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L05
M00_L17:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82CCAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       rax,[7FF9F7A4B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,r14
       call      qword ptr [7FF9F82CCAF8]
       jmp       near ptr M00_L07
M00_L19:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF9F82CCB10]
       jmp       near ptr M00_L08
M00_L20:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F82C7600]
       int       3
M00_L21:
       mov       r8,[rax+8]
       cmp       dword ptr [r8+8],0
       jbe       short M00_L23
       mov       r8,[r8+10]
       jmp       near ptr M00_L10
M00_L22:
       mov       [rsp+20],edi
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F82C7618]
       jmp       near ptr M00_L11
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 765
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
       mov       rax,8915191971EA
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M01_L07
       mov       rax,20C6C800100
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
       call      qword ptr [7FF9F820F060]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M01_L04
M01_L02:
       mov       edi,[rbp+68]
       mov       rcx,[rbp+38]
       mov       r8d,[rbp+68]
       mov       r9d,[rcx+8]
       sub       r9d,r8d
       mov       edx,24
       call      qword ptr [7FF9F7FF6880]; System.String.IndexOf(Char, Int32, Int32)
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
       call      qword ptr [7FF9F82CEC70]
       mov       ecx,[rbp+68]
       mov       rax,[rbp+38]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L01
       mov       ecx,[rbp+68]
       inc       ecx
       mov       [rbp+68],ecx
       mov       rdi,[rbp+28]
       lea       rcx,[rbp+10]
       call      qword ptr [7FF9F82CEC88]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F82CECA0]
       xor       ecx,ecx
       mov       [rbp+30],rcx
       jmp       near ptr M01_L01
M01_L04:
       mov       rdx,[rbp+88]
       test      rdx,rdx
       jne       short M01_L08
M01_L05:
       mov       rax,r14
       mov       r8,8915191971EA
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
       call      qword ptr [7FF9F7D85D88]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M01_L00
M01_L08:
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,20C6C801D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81ED860]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M01_L05
       sub       rsp,28
       mov       rdx,[rbp+88]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+88],rcx
       mov       rcx,20C6C801D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81ED860]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
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
       sub       rsp,188
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L87
       mov       ecx,[rbx+8]
       mov       rax,rbx
M02_L00:
       mov       [rbp-70],rbx
       mov       [rbp+20],rdi
       mov       [rbp-68],rdi
       mov       rdx,24D01930D70
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       mov       [rbp-48],rax
       mov       [rbp-40],edx
       mov       [rbp-3C],ecx
       mov       [rbp-60],edx
       mov       [rbp-5C],r9d
       mov       r14,rbx
       mov       rcx,20C6C802190
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M02_L88
M02_L01:
       mov       [rbp-108],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M02_L86
       xor       r13d,r13d
       xor       r12d,r12d
M02_L02:
       mov       [rbp-188],r13
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L89
M02_L03:
       mov       [rbp-118],rdx
       mov       [rbp-110],rdx
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-110]
       call      qword ptr [7FF9F820F498]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
       jmp       near ptr M02_L15
M02_L04:
       mov       rdx,r11
       mov       r8,r10
       call      00007FFA576E5D60
       cmp       dword ptr [7FFA57A4F778],0
       jne       near ptr M02_L56
M02_L05:
       mov       r13,[rbp-140]
       mov       rcx,[r13+20]
       mov       ecx,[rcx+8]
       add       [r13+58],ecx
       lea       rcx,[r13+20]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
M02_L06:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M02_L63
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       r13,[rax+28]
       mov       rax,[r13+48]
       mov       [rbp-160],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L63
       cmp       qword ptr [rax+10],0
       je        near ptr M02_L57
M02_L07:
       mov       rax,[r13+48]
       mov       [rbp-168],rax
       mov       r13,[r13+50]
       cmp       dword ptr [r13+8],0
       jbe       near ptr M02_L63
       mov       r8d,[r13+10]
       mov       [rbp-0A0],r8d
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L63
       mov       rdx,[rax+10]
       lea       r11d,[r8+r8]
       mov       [rbp-0FC],r11d
       lea       ecx,[r11+2]
       cmp       [rdx+8],ecx
       jl        near ptr M02_L58
M02_L08:
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L63
       mov       rdx,[rax+10]
       mov       rcx,rdx
       mov       r11d,[rbp-0FC]
       cmp       r11d,[rcx+8]
       jae       near ptr M02_L63
       mov       eax,r11d
       mov       [rcx+rax*4+10],r10d
       inc       r11d
       cmp       r11d,[rdx+8]
       jae       near ptr M02_L63
       mov       ecx,r11d
       sub       r9d,r10d
       mov       [rdx+rcx*4+10],r9d
       cmp       dword ptr [r13+8],0
       jbe       near ptr M02_L63
       inc       r8d
       mov       [r13+10],r8d
M02_L09:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L63
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M02_L28
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L63
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M02_L63
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M02_L63
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M02_L10:
       mov       [rbp-138],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M02_L67
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M02_L64
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L29
       cmp       eax,[rcx+8]
       jae       near ptr M02_L63
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L11:
       mov       r8,[rbp-138]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L30
       cmp       eax,[rcx+8]
       jae       near ptr M02_L63
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L12:
       mov       r8,[rbp-138]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M02_L67
M02_L13:
       mov       ecx,[rsi+4C]
       mov       edx,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M02_L65
M02_L14:
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
       mov       r13,[rbp-188]
M02_L15:
       mov       rdx,[rbp-118]
       mov       dword ptr [rdx+60],1
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-118]
       mov       [rdx+48],esi
       xor       ecx,ecx
       mov       [rdx+40],ecx
       mov       [rdx+44],r12d
       mov       [rdx+4C],esi
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M02_L31
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
       jle       short M02_L17
M02_L16:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M02_L16
M02_L17:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M02_L18
       xor       eax,eax
       mov       [rcx+18],rax
M02_L18:
       mov       rsi,[rbp-118]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L39
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M02_L19:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rdx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>F84DEA1CB092AF406657C3B70F337DE6861063B8A819E9C09542127B324ABDBC4__RemoveSpecialCharRegex_15+RunnerFactory+Runner
       cmp       [rsi],rdx
       jne       near ptr M02_L61
       mov       rax,rsi
       mov       [rbp-140],rax
       mov       edx,r12d
       mov       ecx,[rax+4C]
       cmp       ecx,edx
       jae       near ptr M02_L27
       mov       r8d,ecx
       lea       r8,[r13+r8*2]
       sub       edx,ecx
       mov       r10,20C6C802120
       mov       r10,[r10]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M02_L33
       cmp       word ptr [r8],7F
       ja        near ptr M02_L33
       mov       [rbp-148],r8
       mov       r11d,edx
       lea       r13,[r10+8]
       mov       r9,r8
       cmp       edx,10
       jg        near ptr M02_L42
       vmovups   xmm0,[r13]
       lea       r11d,[rdx-8]
       movsxd    r9,r11d
       lea       r9,[r8+r9*2]
       cmp       r8,r9
       ja        near ptr M02_L50
       mov       r11,r8
M02_L20:
       vmovups   xmm1,[r11]
       vpackuswb xmm1,xmm1,[r9]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9F8394740]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9F8394750]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M02_L49
       vpmovmskb r13d,xmm0
       tzcnt     r13d,r13d
       cmp       r13d,8
       jge       near ptr M02_L51
M02_L21:
       sub       r11,r8
       shr       r11,1
       add       r11d,r13d
M02_L22:
       mov       r9d,r11d
       cmp       r9d,edx
       jae       short M02_L23
       mov       r13d,r9d
       cmp       word ptr [r8+r13*2],7F
       ja        near ptr M02_L52
M02_L23:
       test      r11d,r11d
       jl        near ptr M02_L54
       add       ecx,r11d
       mov       [rax+4C],ecx
       mov       r13d,[rax+4C]
       lea       r8d,[r13+1]
       mov       [rax+4C],r8d
       mov       r10d,r13d
       mov       r9d,r8d
       cmp       r9d,r10d
       jl        near ptr M02_L55
M02_L24:
       cmp       dword ptr [rax+58],0
       jne       near ptr M02_L06
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       mov       r13,[rax+20]
       mov       edx,[r13+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-158],rax
       mov       rcx,r13
       mov       r9d,[r13+8]
       mov       r13d,[r13+8]
       test      rcx,rcx
       je        short M02_L26
       mov       rdx,[rcx]
       cmp       rdx,[rax]
       jne       short M02_L26
       cmp       dword ptr [rdx+4],18
       jne       short M02_L26
       cmp       r13d,[rcx+8]
       ja        short M02_L26
       lea       r8d,[r9+r13]
       cmp       r8d,[rax+8]
       ja        short M02_L26
       movzx     r8d,word ptr [rdx]
       mov       r10d,r13d
       imul      r10,r8
       add       rcx,10
       mov       r11,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rax+rcx+10]
       test      dword ptr [rdx],1000000
       je        short M02_L25
       mov       rax,[rbp-158]
       cmp       r10,4000
       jbe       near ptr M02_L04
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FF9F82C4B28]
       jmp       near ptr M02_L05
M02_L25:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FF9F7B05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L05
M02_L26:
       mov       [rsp+20],r13d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9F82C5698]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L05
M02_L27:
       mov       [rax+4C],r12d
       jmp       near ptr M02_L09
M02_L28:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,20C6C8021B0
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M02_L10
M02_L29:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F7F8]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L11
M02_L30:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F7F8]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L12
M02_L31:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-190],rax
       test      rax,rax
       je        near ptr M02_L38
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-128],rdx
       mov       rax,rsi
       mov       r10,[rbp-190]
       mov       [rbp-130],r10
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-118]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF9F820F600]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-128]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-128]
M02_L32:
       mov       rsi,[rbp-118]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L33:
       add       r10,88
       mov       r11d,edx
       lea       rdx,[r8+r11*2]
       mov       [rbp-150],rdx
       mov       r11,r8
       mov       r13,[r10]
       mov       r10d,[r10+10]
       mov       [rbp-94],r10d
       cmp       r8,rdx
       je        near ptr M02_L53
M02_L34:
       movzx     edx,word ptr [r11]
       imul      r10d,edx
       mov       edi,[r13+8]
       imul      r10,rdi
       shr       r10,20
       movzx     r10d,word ptr [r13+r10*2+10]
       cmp       r10d,edx
       jne       short M02_L35
       add       r11,2
       mov       rdx,[rbp-150]
       cmp       r11,rdx
       mov       r10d,[rbp-94]
       jne       short M02_L34
       jmp       near ptr M02_L53
M02_L35:
       mov       rdx,r11
       sub       rdx,r8
       shr       rdx,1
M02_L36:
       mov       r11d,edx
       test      r11d,r11d
       jl        short M02_L37
       lea       r11d,[rdx+r9]
M02_L37:
       jmp       near ptr M02_L23
M02_L38:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-120],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-118]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-120]
       call      qword ptr [7FF9F820F600]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-120]
       jmp       near ptr M02_L32
M02_L39:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M02_L40
       mov       r8d,20
M02_L40:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M02_L41
       mov       dword ptr [rbp-8C],10
M02_L41:
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
       jmp       near ptr M02_L19
M02_L42:
       vmovups   ymm0,[r13]
       cmp       r11d,20
       jle       near ptr M02_L45
       add       r11d,0FFFFFFE0
       movsxd    r11,r11d
       mov       r13,[rbp-148]
       lea       r11,[r13+r11*2]
M02_L43:
       vmovups   ymm1,[r9]
       vpackuswb ymm1,ymm1,[r9+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9F8394760]
       vbroadcastsd ymm3,qword ptr [7FF9F8394750]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M02_L44
       add       r9,40
       cmp       r9,r11
       jb        short M02_L43
       jmp       short M02_L45
M02_L44:
       mov       r11,r9
       sub       r11,r8
       shr       r11,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       add       r11d,r9d
       jmp       near ptr M02_L22
M02_L45:
       lea       r11d,[rdx-10]
       movsxd    r11,r11d
       lea       r11,[r8+r11*2]
       cmp       r9,r11
       ja        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       r9,r11
M02_L47:
       vmovups   ymm1,[r9]
       vpackuswb ymm1,ymm1,[r11]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9F8394760]
       vbroadcastsd ymm2,qword ptr [7FF9F8394750]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        short M02_L49
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r13d,ymm0
       tzcnt     r13d,r13d
       cmp       r13d,10
       jl        short M02_L48
       mov       r9,r11
       add       r13d,0FFFFFFF0
M02_L48:
       sub       r9,r8
       shr       r9,1
       lea       r11d,[r9+r13]
       jmp       near ptr M02_L22
M02_L49:
       mov       r11d,0FFFFFFFF
       jmp       near ptr M02_L22
M02_L50:
       mov       r11,r9
       jmp       near ptr M02_L20
M02_L51:
       mov       r11,r9
       add       r13d,0FFFFFFF8
       jmp       near ptr M02_L21
M02_L52:
       mov       r11d,r9d
       lea       r8,[r8+r11*2]
       sub       edx,r9d
       jmp       near ptr M02_L33
M02_L53:
       mov       edx,0FFFFFFFF
       jmp       near ptr M02_L36
M02_L54:
       mov       r13,[rbp-188]
       jmp       near ptr M02_L27
M02_L55:
       mov       [rbp-98],r13d
       mov       [rbp-9C],r8d
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L24
M02_L56:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L05
M02_L57:
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-160]
       xor       edx,edx
       call      qword ptr [7FF9F7B057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L07
M02_L58:
       mov       [rbp-9C],r10d
       mov       [rbp-98],r9d
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L63
       mov       rcx,[rax+10]
       mov       [rbp-170],rcx
       lea       edx,[r8*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       mov       r10d,[rbp-0FC]
       cmp       ecx,r10d
       jl        short M02_L59
       jmp       short M02_L60
M02_L59:
       mov       r8,[rbp-170]
       cmp       ecx,[r8+8]
       jae       short M02_L63
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       short M02_L63
       mov       [rax+rcx*4+10],edx
       inc       ecx
       cmp       ecx,r10d
       jl        short M02_L62
M02_L60:
       mov       rcx,[rbp-168]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9F7B057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-168]
       mov       r8d,[rbp-0A0]
       mov       r9d,[rbp-98]
       mov       r10d,[rbp-9C]
       jmp       near ptr M02_L08
M02_L61:
       mov       [rbp-0D0],r13
       mov       [rbp-0C8],r12d
       lea       rdx,[rbp-0D0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L09
M02_L62:
       mov       r10d,[rbp-0FC]
       jmp       near ptr M02_L59
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-138]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-138]
       je        short M02_L67
       jmp       near ptr M02_L13
M02_L65:
       mov       edx,r12d
       mov       eax,1
       mov       r8,[rbp-108]
       test      byte ptr [r8+40],40
       je        short M02_L66
       xor       edx,edx
       mov       eax,0FFFFFFFF
M02_L66:
       cmp       ecx,edx
       je        short M02_L67
       lea       edx,[rcx+rax]
       jmp       near ptr M02_L14
M02_L67:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-108]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       je        near ptr M02_L75
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L84
       cmp       eax,[rcx+8]
       jae       near ptr M02_L114
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L68:
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L85
       cmp       eax,[rcx+8]
       jae       near ptr M02_L114
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M02_L69:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M02_L90
       cmp       [rax+8],ecx
       jb        near ptr M02_L91
       add       rax,10
M02_L70:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       mov       rdi,[rbp+20]
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M02_L72
M02_L71:
       cmp       edx,ecx
       jae       near ptr M02_L114
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M02_L71
M02_L72:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,20C6C802198
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L92
M02_L73:
       test      rsi,rsi
       je        near ptr M02_L83
       test      r14d,r14d
       jle       near ptr M02_L81
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rdx,[r15+0C]
       mov       [rbp-0E0],rdx
       mov       [rbp-0D8],r14d
       mov       [rbp-0F8],rbx
       mov       [rbp-0F0],rdi
       lea       rdx,[rbp-80]
       mov       [rbp-0E8],rdx
       lea       rdx,[rbp-0E0]
       lea       r8,[rbp-0F8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M02_L74:
       mov       r14,r15
M02_L75:
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L80
       mov       rcx,20C6C801D10
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
       jle       near ptr M02_L93
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L93
M02_L76:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M02_L94
M02_L77:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],edi
       jbe       short M02_L78
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M02_L95
       cmp       edi,[rax+8]
       jae       near ptr M02_L114
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-178],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-178]
       test      r12,r12
       jne       near ptr M02_L96
M02_L78:
       mov       rcx,20C6C800C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L111
M02_L79:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M02_L80:
       mov       rax,r14
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L81:
       test      r14d,r14d
       je        short M02_L82
       mov       ecx,28
       call      qword ptr [7FF9F7D87870]
       int       3
M02_L82:
       mov       r15,24D01920008
       jmp       near ptr M02_L74
M02_L83:
       mov       ecx,1C
       call      qword ptr [7FF9F7D8C1C8]
       int       3
M02_L84:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F7F8]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L68
M02_L85:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F820F7F8]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M02_L69
M02_L86:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M02_L02
M02_L87:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L88:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,20C6C802188
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20C6C802190
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L89:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M02_L03
M02_L90:
       test      ecx,ecx
       jne       short M02_L91
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M02_L70
M02_L91:
       call      qword ptr [7FF9F7CA7138]
       int       3
M02_L92:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20C6C802188
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20C6C802198
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L73
M02_L93:
       mov       ecx,7
       call      qword ptr [7FF9F82C6D90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L76
M02_L94:
       mov       rcx,rbx
       call      qword ptr [7FF9F816E550]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M02_L77
M02_L95:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F82C7480]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L96:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L114
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L97
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F82C7498]
M02_L97:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A4B184],0
       je        short M02_L98
       call      qword ptr [7FF9F82C74B0]
       mov       [rbp-0B4],eax
       jmp       short M02_L100
M02_L98:
       mov       ecx,9
       call      qword ptr [7FF9F82C74C8]
       mov       eax,[rax+10]
       mov       [rbp-0B8],eax
       mov       ecx,9
       call      qword ptr [7FF9F82C74C8]
       mov       ecx,[rbp-0B8]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L99
       call      qword ptr [7FF9F82C74E0]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M02_L100
M02_L99:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rbp-0B4],edx
M02_L100:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FF9F7A4B178]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L107
M02_L101:
       cmp       eax,[r13+8]
       jae       near ptr M02_L114
       mov       [rbp-0AC],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-180],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0BC],r10d
       mov       rcx,r8
       call      qword ptr [7FF9F80ED5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-180]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0C0],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L103
       test      r8d,r8d
       jne       short M02_L104
       xor       edx,edx
       mov       [rax+14],edx
M02_L102:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-180]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M02_L103:
       mov       rcx,rax
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0BC],0
       je        short M02_L105
       jmp       short M02_L108
M02_L104:
       jmp       short M02_L102
M02_L105:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M02_L106
       xor       ecx,ecx
M02_L106:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,ecx
M02_L107:
       mov       [rbp-0B0],edx
       cmp       [r13+8],edx
       jg        near ptr M02_L101
       jmp       short M02_L109
M02_L108:
       mov       r13d,1
       jmp       short M02_L110
M02_L109:
       xor       r13d,r13d
M02_L110:
       jmp       near ptr M02_L78
M02_L111:
       cmp       dword ptr [rsi+8],0
       je        near ptr M02_L79
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A4],eax
       mov       edx,[rsi+8]
       mov       [rbp-0A8],edx
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-0A4]
       mov       r9d,[rbp-0A8]
       mov       edx,3
       call      qword ptr [7FF9F82C74F8]
       test      r13d,r15d
       jne       near ptr M02_L79
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L112
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L113
M02_L112:
       mov       ecx,edi
       xor       edx,edx
M02_L113:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF9F82C7510]
       jmp       near ptr M02_L79
M02_L114:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       xor       ecx,ecx
       mov       rsi,[rbp-118]
       mov       [rsi+8],rcx
       mov       r8,[rbp-108]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 4612
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
       call      qword ptr [7FFA575635D8]
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
       call      qword ptr [7FFA57556148]
       test      rax,rax
       jne       short M03_L06
       call      qword ptr [7FFA575483F0]
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
       call      qword ptr [7FFA575635E0]
       jmp       short M03_L00
M03_L05:
       call      qword ptr [7FFA575483F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FFA57559728]
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
       jb        near ptr M04_L14
       cmp       rsi,rdi
       je        near ptr M04_L04
       cmp       rbx,20
       jae       near ptr M04_L06
       mov       rcx,7FF9F82DB178
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M04_L01
       mov       rcx,7FF9F82DB190
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9F82DB194
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
       mov       rcx,7FF9F82DB15C
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
       ja        near ptr M04_L18
       mov       rcx,7FF9F82DB17C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L10
       mov       rcx,7FF9F82DB180
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF9F82DB160
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
       mov       rcx,7FF9F82DB18C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M04_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L08
M04_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M04_L11
       mov       rcx,7FF9F82DB170
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M04_L07
M04_L08:
       mov       rcx,7FF9F82DB174
       call      CORINFO_HELP_COUNTPROFILE32
M04_L09:
       mov       rcx,7FF9F82DB198
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
       mov       rcx,7FF9F82DB184
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L11:
       mov       rcx,7FF9F82DB164
       call      CORINFO_HELP_COUNTPROFILE32
M04_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L13
       mov       rcx,7FF9F82DB168
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L04
M04_L13:
       mov       rcx,7FF9F82DB16C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L14:
       cmp       rbx,4
       jb        short M04_L15
       mov       rcx,7FF9F82DB158
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
M04_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M04_L16
       mov       rcx,7FF9F82DB150
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M04_L16:
       test      bl,1
       je        short M04_L17
       mov       rcx,7FF9F82DB154
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M04_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L18:
       mov       rcx,7FF9F82DB188
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L05
       jmp       near ptr M04_L02
; Total bytes of code 686
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,17D100020C8
       mov       rsi,[rcx]
       mov       edi,0C
       xor       ecx,ecx
       test      byte ptr [rsi+40],40
       cmove     edi,ecx
       mov       r14,1BDA4F70698
       mov       r15,[rsi+38]
       test      r15,r15
       je        near ptr M00_L34
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
       mov       rdx,7FF9F82E7678
       call      qword ptr [7FF9F7B26E20]
       mov       r10,rax
       mov       r8d,[rbp-3C]
M00_L02:
       jmp       short M00_L04
M00_L03:
       mov       r8d,[rbp-3C]
       xor       r10d,r10d
M00_L04:
       test      r10,r10
       je        near ptr M00_L08
       mov       [rbp-0C8],r10
       mov       rcx,[r10+18]
       cmp       [rcx],cl
       mov       rdx,1BDA4F60008
       cmp       rcx,rdx
       jne       short M00_L05
       mov       r13,[rbp-0C8]
       jmp       near ptr M00_L12
M00_L05:
       cmp       dword ptr [rcx+8],0
       jne       short M00_L08
       lea       r9,[rcx+0C]
       mov       rdx,1BDA4F60014
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r11d,ecx
       cmp       r11,0A
       je        short M00_L06
       mov       rcx,r9
       mov       r8,r11
       call      qword ptr [7FF9F7B2FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       short M00_L07
M00_L06:
       mov       rcx,[r9]
       mov       r9,[r9+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r9,[rdx+2]
       or        r9,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L07:
       test      eax,eax
       je        short M00_L08
       mov       r13,[rbp-0C8]
       jmp       short M00_L12
M00_L08:
       mov       rax,[rbp-0D0]
       mov       [rsp+20],rax
       mov       edx,r8d
       mov       r8,r13
       mov       r9d,r12d
       mov       rcx,1BDA4F60008
       call      qword ptr [7FF9F8207528]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r13,rax
       mov       r12,[r15+8]
       and       r12,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L36
       test      r13,r13
       je        short M00_L09
       cmp       qword ptr [7FF9F7A6B020],0
       jne       near ptr M00_L37
M00_L09:
       xor       eax,eax
M00_L10:
       test      r12b,2
       jne       near ptr M00_L38
       test      rax,rax
       jne       near ptr M00_L38
       mov       rcx,r12
       mov       rdx,r13
       call      00007FFA57617580
M00_L11:
       nop
M00_L12:
       cmp       [r13],r13b
       cmp       edi,0C
       ja        near ptr M00_L39
       mov       eax,[rsi+40]
       and       eax,40
       je        near ptr M00_L40
M00_L13:
       mov       [rbp-70],r13
       mov       rcx,1BDA4F70D80
       mov       [rbp-60],rcx
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       [rbp-50],r14
       mov       [rbp-48],ecx
       mov       dword ptr [rbp-44],0C
       mov       [rbp-68],ecx
       mov       dword ptr [rbp-64],0FFFFFFFF
       test      eax,eax
       je        near ptr M00_L43
       mov       dword ptr [rbp-68],0C
       mov       rcx,17D10002188
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L46
M00_L14:
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
       je        near ptr M00_L47
M00_L15:
       mov       [rbp-0E0],rcx
       mov       [rcx+8],r14
       mov       rdx,[rsi+48]
       call      qword ptr [7FF9F8207A38]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,edi
M00_L16:
       mov       r14,[rbp-0E0]
       mov       [r14+60],r12d
       lea       rcx,[r14+30]
       mov       rdx,[rbp-0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+48],edi
       mov       rdx,0C00000000
       mov       [r14+40],rdx
       mov       [r14+4C],edi
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       rdx,[r14+8]
       mov       r8d,0C
       call      qword ptr [7FF9F8207E28]; System.Text.RegularExpressions.Match.Reset(System.String, Int32)
M00_L17:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        near ptr M00_L24
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       mov       [r14+50],eax
       mov       rax,[r14+18]
       mov       eax,[rax+8]
       mov       [r14+54],eax
       mov       ecx,[rcx+8]
       mov       [r14+58],ecx
M00_L18:
       mov       [r14+4C],esi
       mov       [rsp+20],r14
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],0C
       xor       r8d,r8d
       mov       [rsp+30],r8d
       lea       r8,[rbp-0B0]
       mov       [rsp+28],r8
       mov       r8,1BDA4F70698
       mov       ecx,r12d
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FF9F8207A68]; System.Text.RegularExpressions.Regex.ScanInternal(System.Text.RegularExpressions.RegexRunnerMode, Boolean, System.String, Int32, System.Text.RegularExpressions.RegexRunner, System.ReadOnlySpan`1<Char>, Boolean)
       mov       rdi,rax
       cmp       dword ptr [rdi+30],0
       je        near ptr M00_L30
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M00_L27
       mov       rcx,[r15+8]
       lea       rdx,[rbp-70]
       mov       r8,rdi
       call      qword ptr [7FF9F8207960]; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
M00_L19:
       test      eax,eax
       je        near ptr M00_L30
       mov       ecx,[r14+4C]
       mov       esi,ecx
       mov       ecx,esi
       cmp       dword ptr [rdi+14],0
       je        near ptr M00_L28
M00_L20:
       mov       rdx,[r14+10]
       mov       edx,[rdx+8]
       mov       [r14+50],edx
       mov       rdx,[r14+18]
       mov       edx,[rdx+8]
       mov       [r14+54],edx
       mov       rdx,[r14+20]
       mov       edx,[rdx+8]
       mov       [r14+58],edx
       mov       edi,esi
       mov       esi,ecx
       jmp       near ptr M00_L16
M00_L21:
       mov       rcx,[r14+30]
       cmp       qword ptr [rcx+18],0
       je        short M00_L22
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[r14+30]
       mov       r8,[r14+30]
       mov       rax,[r8+18]
       mov       [rbp-0E8],rax
       mov       dword ptr [rsp+20],0C
       mov       r8,[r14+30]
       mov       r8d,[r8+44]
       mov       r9,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF9F8207BA0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[rdi+68]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L23
M00_L22:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rsp+20],0C
       mov       r8,[r14+30]
       mov       r8d,[r8+44]
       mov       rdx,[r14+30]
       mov       r9,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF9F8207BA0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M00_L23:
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,[r14+5C]
       shl       edi,3
       mov       eax,edi
       cmp       edi,20
       jge       short M00_L25
       mov       eax,20
M00_L25:
       cmp       edi,10
       jge       short M00_L26
       mov       edi,10
M00_L26:
       mov       [rbp-84],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-84]
       mov       [r14+50],edx
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+54],edi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+58],20
       jmp       near ptr M00_L18
M00_L27:
       lea       rdx,[rbp-70]
       mov       r8,rdi
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M00_L19
M00_L28:
       mov       ecx,0C
       mov       edx,1
       mov       rax,[rbp-0D8]
       test      byte ptr [rax+40],40
       je        short M00_L29
       xor       ecx,ecx
       mov       edx,0FFFFFFFF
M00_L29:
       cmp       esi,ecx
       je        short M00_L30
       lea       ecx,[rsi+rdx]
       mov       edi,ecx
       mov       ecx,edi
       jmp       near ptr M00_L20
M00_L30:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       rax,[rbp-0D8]
       lea       rcx,[rax+30]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-58],0
       je        near ptr M00_L48
       mov       r9d,[rbp-68]
       cmp       r9d,[rbp-44]
       ja        near ptr M00_L33
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       lea       rcx,[rbp-98]
       mov       rdx,[rbp-50]
       mov       r8d,[rbp-48]
       call      qword ptr [7FF9F82C5608]; System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]]..ctor(System.Object, Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-98]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F8207CC0]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ReadOnlyMemory`1<Char>)
       lea       rcx,[rbp-60]
       lea       rdx,[rbp-80]
       call      qword ptr [7FF9F8207E70]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].AsSpan()
       lea       rcx,[rbp-80]
       call      qword ptr [7FF9F8207EB8]; System.MemoryExtensions.Reverse[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]](System.Span`1<System.ReadOnlyMemory`1<Char>>)
M00_L31:
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F820C0D8]; System.Text.RegularExpressions.Regex.SegmentsToStringAndDispose(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef)
M00_L32:
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-0A0]
       mov       rdx,7FF9F8283ED0
       cmp       [rcx],ecx
       call      qword ptr [7FF9F820C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L33:
       mov       ecx,21
       call      qword ptr [7FF9F7DA7870]
       int       3
M00_L34:
       lea       r15,[rsi+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F7B26D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      r15,r15
       jne       short M00_L35
       call      qword ptr [7FF9F82C4E88]
       int       3
M00_L35:
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFA576EFBA0
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L00
       mov       r15,[rsi+38]
       jmp       near ptr M00_L00
M00_L36:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82C55C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F75D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rax,[7FF9F7A6B020]
       mov       rcx,r13
       call      rax
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,r13
       call      qword ptr [7FF9F82C55D8]
       jmp       near ptr M00_L10
M00_L38:
       lea       rcx,[r15+8]
       mov       rdx,r13
       mov       r8,rax
       call      qword ptr [7FF9F82C55F0]
       jmp       near ptr M00_L11
M00_L39:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F82C4ED0]
       int       3
M00_L40:
       cmp       byte ptr [r13+20],0
       jne       near ptr M00_L13
       mov       rcx,[r13+10]
       cmp       dword ptr [rcx+8],0
       jne       short M00_L41
       mov       r8,1BDA4F60008
       jmp       short M00_L42
M00_L41:
       mov       r8,[r13+8]
       cmp       dword ptr [r8+8],0
       jbe       near ptr M00_L49
       mov       r8,[r8+10]
M00_L42:
       mov       [rsp+20],edi
       mov       rcx,rsi
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F82C4EE8]
       jmp       near ptr M00_L32
M00_L43:
       mov       rcx,17D10002180
       mov       rax,[rcx]
       test      rax,rax
       jne       short M00_L44
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,17D10002168
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,7FF9F82C0F60
       call      qword ptr [7FF9F7B26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17D10002180
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L44:
       mov       ecx,2
       mov       r9d,1
       cmp       byte ptr [r13+20],0
       cmove     ecx,r9d
       lea       r9,[rbp-70]
       mov       [rsp+20],r9
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,7FF9F826F4B0
       mov       r8,r14
       call      qword ptr [7FF9F82077E0]; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       cmp       dword ptr [rbp-58],0
       je        near ptr M00_L48
       mov       edx,[rbp-68]
       cmp       edx,[rbp-44]
       ja        near ptr M00_L33
       mov       rax,[rbp-50]
       mov       esi,edx
       add       esi,[rbp-48]
       mov       edi,[rbp-44]
       sub       edi,edx
       mov       r14,[rbp-60]
       mov       r15d,[rbp-58]
       cmp       [r14+8],r15d
       jbe       short M00_L45
       mov       ecx,r15d
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       mov       rcx,r14
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+8],esi
       mov       [r14+0C],edi
       inc       r15d
       mov       [rbp-58],r15d
       jmp       near ptr M00_L31
M00_L45:
       mov       [rbp-0C0],rax
       mov       [rbp-0B8],esi
       mov       [rbp-0B4],edi
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F8207CD8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
       jmp       near ptr M00_L31
M00_L46:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.Text.RegularExpressions.RegexReplacement, System.Text.StructListBuilder<System.ReadOnlyMemory<System.Char>>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,17D10002168
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF9F7B26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17D10002188
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
M00_L47:
       mov       rcx,[rsi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M00_L15
M00_L48:
       mov       rax,1BDA4F70698
       jmp       near ptr M00_L32
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       xor       ecx,ecx
       mov       r14,[rbp-0E0]
       mov       [r14+8],rcx
       mov       rax,[rbp-0D8]
       lea       rcx,[rax+30]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       ret
; Total bytes of code 2297
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
       mov       rax,0EBB0BCE6CCDF
       mov       [rbp],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       jne       near ptr M02_L03
       call      qword ptr [7FF9F7DA5D88]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F8207558]; System.Text.RegularExpressions.RegexParser..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Span`1<Int32>)
       nop
       lea       rcx,[rbp+18]
       call      qword ptr [7FF9F8207570]; System.Text.RegularExpressions.RegexParser.ScanReplacement()
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF9F8207588]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       nop
       mov       rcx,7FF9F844E77C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       jne       short M02_L04
M02_L01:
       mov       rcx,7FF9F844E780
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
       mov       r8,0EBB0BCE6CCDF
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
       mov       rcx,7FF9F844E778
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,17D10000100
       mov       rax,[rcx]
       jmp       near ptr M02_L00
M02_L04:
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,17D10001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81B3D20]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M02_L01
       sub       rsp,48
       mov       rcx,7FF9F844E77C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+90]
       test      rdx,rdx
       je        short M02_L05
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       rcx,17D10001CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81B3D20]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
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
       jmp       qword ptr [7FF9F82C4F78]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.Match.Reset(System.String, Int32)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+34],eax
       mov       [rbx+5C],esi
       mov       rax,[rbx+50]
       mov       ecx,[rax+8]
       test      ecx,ecx
       jle       short M04_L01
       add       rax,10
M04_L00:
       xor       edx,edx
       mov       [rax],edx
       add       rax,4
       dec       ecx
       jne       short M04_L00
M04_L01:
       mov       byte ptr [rbx+60],0
       mov       rax,[rbx+38]
       test      rax,rax
       jne       short M04_L03
M04_L02:
       pop       rbx
       pop       rsi
       ret
M04_L03:
       xor       ecx,ecx
       mov       [rax+18],rcx
       jmp       short M04_L02
; Total bytes of code 76
```
```assembly
; System.Text.RegularExpressions.Regex.ScanInternal(System.Text.RegularExpressions.RegexRunnerMode, Boolean, System.String, Int32, System.Text.RegularExpressions.RegexRunner, System.ReadOnlySpan`1<Char>, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       esi,ecx
       mov       edi,edx
       mov       r14,r8
       mov       ebp,r9d
       mov       rbx,[rsp+0B0]
       mov       rax,[rsp+0B8]
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>F84DEA1CB092AF406657C3B70F337DE6861063B8A819E9C09542127B324ABDBC4__RemoveCrLfRegex_13+RunnerFactory+Runner
       cmp       [rbx],rcx
       jne       near ptr M05_L20
M05_L00:
       mov       rcx,[rax]
       mov       edx,[rax+8]
       mov       r8d,[rbx+4C]
       test      r8d,r8d
       jle       short M05_L02
       dec       r8d
       mov       r10d,r8d
       cmp       r10d,edx
       jae       short M05_L02
M05_L01:
       mov       r9d,r8d
       movzx     r9d,word ptr [rcx+r9*2]
       cmp       r9d,0A
       sete      r11b
       movzx     r11d,r11b
       cmp       r9d,0D
       sete      r9b
       movzx     r9d,r9b
       or        r9d,r11d
       jne       short M05_L05
       lea       r8d,[r10-1]
       mov       r10d,r8d
       cmp       r10d,edx
       jb        short M05_L01
M05_L02:
       xor       ecx,ecx
       mov       [rbx+4C],ecx
M05_L03:
       mov       r15,[rbx+28]
       mov       rax,[r15+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L23
       cmp       dword ptr [rax+10],0
       jle       near ptr M05_L12
       test      dil,dil
       je        near ptr M05_L21
       cmp       byte ptr [rsp+0C0],0
       jne       near ptr M05_L22
M05_L04:
       mov       edx,[rbx+4C]
       mov       rcx,r15
       mov       r8d,ebp
       mov       r9d,esi
       call      qword ptr [7FF9F8207C90]; System.Text.RegularExpressions.Match.Tidy(Int32, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L05:
       inc       r8d
       mov       [rbx+4C],r8d
       mov       rcx,[rax]
       mov       edx,[rax+8]
       mov       r15d,r8d
       cmp       r15d,edx
       ja        near ptr M05_L15
       xor       r10d,r10d
       test      r15d,r15d
       jle       short M05_L07
M05_L06:
       mov       r9d,r15d
       sub       r9d,r10d
       dec       r9d
       cmp       r9d,edx
       jae       near ptr M05_L23
       movzx     r9d,word ptr [rcx+r9*2]
       cmp       r9d,0A
       sete      r11b
       movzx     r11d,r11b
       cmp       r9d,0D
       sete      r9b
       movzx     r9d,r9b
       or        r9d,r11d
       je        short M05_L07
       inc       r10d
       cmp       r15d,r10d
       jg        short M05_L06
M05_L07:
       test      r10d,r10d
       je        near ptr M05_L14
       mov       ecx,r15d
       sub       ecx,r10d
       mov       [rbx+4C],ecx
       mov       r13d,r15d
       mov       r12d,ecx
       cmp       r12d,r13d
       jge       short M05_L08
       mov       r12d,r15d
       mov       r13d,ecx
M05_L08:
       cmp       dword ptr [rbx+58],0
       jne       short M05_L09
       mov       rcx,rbx
       call      qword ptr [7FF9F82C4FA8]
M05_L09:
       mov       rcx,[rbx+20]
       mov       edx,[rbx+58]
       dec       edx
       mov       [rbx+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M05_L23
       xor       eax,eax
       mov       [rcx+rdx*4+10],eax
       mov       r15,[rbx+28]
       mov       rax,[r15+48]
       mov       [rsp+38],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L23
       cmp       qword ptr [rax+10],0
       je        near ptr M05_L16
M05_L10:
       mov       rax,[r15+48]
       mov       [rsp+30],rax
       mov       r15,[r15+50]
       mov       edx,[r15+8]
       test      edx,edx
       je        near ptr M05_L23
       mov       r8d,[r15+10]
       mov       [rsp+44],r8d
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L23
       mov       rdx,[rax+10]
       lea       r10d,[r8+r8]
       mov       [rsp+40],r10d
       lea       ecx,[r10+2]
       cmp       [rdx+8],ecx
       jl        near ptr M05_L17
M05_L11:
       mov       rax,[rax+10]
       mov       rcx,rax
       mov       r10d,[rsp+40]
       cmp       r10d,[rcx+8]
       jae       near ptr M05_L23
       mov       edx,r10d
       mov       [rcx+rdx*4+10],r13d
       inc       r10d
       cmp       r10d,[rax+8]
       jae       near ptr M05_L23
       mov       ecx,r10d
       sub       r12d,r13d
       mov       [rax+rcx*4+10],r12d
       inc       r8d
       mov       [r15+10],r8d
       jmp       near ptr M05_L03
M05_L12:
       xor       eax,eax
       mov       [r15+8],rax
       mov       rax,17D100021A8
       mov       rax,[rax]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L13:
       dec       r8d
       mov       [rbx+4C],r8d
       jmp       near ptr M05_L00
M05_L14:
       cmp       dword ptr [rbx+4C],0
       jne       short M05_L13
       jmp       near ptr M05_L03
M05_L15:
       call      qword ptr [7FF9F7CC7138]
       int       3
M05_L16:
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rsp+38]
       xor       edx,edx
       call      qword ptr [7FF9F7B257B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M05_L10
M05_L17:
       mov       r9,[rax+10]
       mov       [rsp+28],r9
       lea       edx,[r8*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M05_L19
M05_L18:
       mov       r8,[rsp+28]
       cmp       ecx,[r8+8]
       jae       near ptr M05_L23
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       short M05_L23
       mov       [rax+rcx*4+10],edx
       inc       ecx
M05_L19:
       mov       r10d,[rsp+40]
       cmp       ecx,r10d
       jl        short M05_L18
       mov       rcx,[rsp+30]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9F7B257B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rsp+30]
       mov       r8d,[rsp+44]
       jmp       near ptr M05_L11
M05_L20:
       mov       rcx,rbx
       mov       rdx,rax
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M05_L03
M05_L21:
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+28],rdx
       jmp       near ptr M05_L04
M05_L22:
       xor       eax,eax
       mov       [r15+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 861
```
```assembly
; System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceNonSimpleText>b__18_1(System.ValueTuple`5<System.Text.RegularExpressions.RegexReplacement,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
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
       mov       [rsp+28],rax
       mov       rbx,rdx
       mov       rsi,r8
       cmp       [rbx],bl
       lea       rdi,[rbx+10]
       mov       rbp,rdi
       lea       rcx,[rbx+20]
       mov       edx,[rsi+10]
       mov       eax,[rsi+14]
       lea       r14d,[rdx+rax]
       mov       r15d,[rbx+8]
       sub       r15d,edx
       sub       r15d,eax
       mov       edx,r14d
       mov       eax,r15d
       add       rdx,rax
       mov       eax,[rcx+0C]
       cmp       rdx,rax
       ja        short M06_L01
       mov       rdx,[rcx]
       add       r14d,[rcx+8]
       mov       rcx,[rbp]
       mov       r13d,[rbp+8]
       mov       eax,[rcx+8]
       cmp       eax,r13d
       jbe       short M06_L02
       mov       eax,r13d
       shl       rax,4
       lea       r12,[rcx+rax+10]
       mov       rcx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+8],r14d
       mov       [r12+0C],r15d
       inc       r13d
       mov       [rbp+8],r13d
M06_L00:
       mov       ecx,[rsi+10]
       mov       [rbx+8],ecx
       mov       rcx,[rbx]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F8207E10]; System.Text.RegularExpressions.RegexReplacement.ReplacementImplRTL(System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>> ByRef, System.Text.RegularExpressions.Match)
       add       rbx,0C
       mov       eax,[rbx]
       dec       eax
       mov       [rbx],eax
       test      eax,eax
       setne     al
       movzx     eax,al
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
M06_L01:
       mov       ecx,21
       call      qword ptr [7FF9F7DA7870]
       int       3
M06_L02:
       mov       [rsp+28],rdx
       mov       [rsp+30],r14d
       mov       [rsp+34],r15d
       lea       rdx,[rsp+28]
       mov       rcx,rbp
       call      qword ptr [7FF9F8207CD8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
       jmp       short M06_L00
; Total bytes of code 240
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
       call      qword ptr [7FFA699E7E18]
       mov       r8,rax
       mov       rdx,[System.Text.RegularExpressions.RegexRunnerFactory..ctor()]
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFA699E9250]; Precode of System.Text.RegularExpressions.Group..ctor(System.String, Int32[], Int32, System.String)
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E18]
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       movsxd    rcx,esi
       call      qword ptr [7FFA699E7E88]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FFA699E69C8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+48]
       mov       r8,[rbx+18]
       xor       edx,edx
       call      qword ptr [7FFA699E69E0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       mov       r8,rcx
       mov       rax,[r8]
       mov       r10d,[r8+8]
       mov       ecx,[rax+8]
       cmp       ecx,r10d
       jbe       short M09_L00
       mov       ecx,r10d
       shl       rcx,4
       lea       rdi,[rax+rcx+10]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       inc       r10d
       mov       [r8+8],r10d
       pop       rsi
       pop       rdi
       ret
M09_L00:
       mov       rcx,r8
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F8207CD8]; System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].GrowAndAdd(System.ReadOnlyMemory`1<Char>)
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
       call      qword ptr [7FF9F7CC7138]
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
       sub       rsp,98
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       edi,[rbx+8]
       test      rsi,rsi
       je        near ptr M12_L19
       cmp       [rsi+8],edi
       jb        near ptr M12_L11
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
       mov       rcx,17D100021D8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M12_L20
M12_L03:
       test      ebp,ebp
       jle       near ptr M12_L21
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rdx,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       cmp       [r14+18],rdx
       jne       near ptr M12_L23
       xor       r14d,r14d
M12_L04:
       cmp       r14d,edi
       jge       near ptr M12_L12
       mov       r12,r14
       shl       r12,4
       add       r12,rsi
       xor       edx,edx
       xor       eax,eax
       mov       rcx,[r12]
       test      rcx,rcx
       je        short M12_L09
       mov       rax,[rcx]
       mov       rdx,offset MT_System.String
       cmp       rax,rdx
       je        short M12_L06
       mov       rdx,rax
       test      dword ptr [rdx],80000000
       jne       short M12_L05
       lea       rdx,[rsp+80]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       eax,[rsp+88]
       mov       rdx,[rsp+80]
       jmp       short M12_L08
M12_L05:
       lea       rdx,[rcx+10]
       jmp       short M12_L07
M12_L06:
       lea       rdx,[rcx+0C]
M12_L07:
       mov       eax,[rcx+8]
M12_L08:
       mov       r8d,[r12+8]
       and       r8d,7FFFFFFF
       mov       ecx,[r12+0C]
       mov       r10d,ecx
       add       r10,r8
       mov       eax,eax
       cmp       r10,rax
       ja        short M12_L11
       lea       rdx,[rdx+r8*2]
       mov       eax,ecx
M12_L09:
       cmp       eax,ebp
       ja        short M12_L10
       mov       [rsp+94],eax
       mov       r8d,eax
       add       r8,r8
       mov       rcx,r13
       call      qword ptr [7FF9F7B25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,[rsp+94]
       mov       eax,r12d
       mov       ecx,eax
       lea       r13,[r13+rcx*2]
       sub       ebp,eax
       inc       r14d
       jmp       near ptr M12_L04
M12_L10:
       call      qword ptr [7FF9F801C270]
       int       3
M12_L11:
       call      qword ptr [7FF9F7CC7138]
       int       3
M12_L12:
       cmp       qword ptr [rbx],0
       je        near ptr M12_L18
       mov       rcx,17D10002190
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
M12_L13:
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M12_L25
M12_L14:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r14+8],ebp
       jbe       short M12_L16
       mov       r13d,1
       mov       rdx,[rdi]
       movzx     ecx,word ptr [rdx]
       mov       eax,[rdi+8]
       imul      rax,rcx
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M12_L26
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FF9F820C1B0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M12_L15:
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
M12_L16:
       mov       rcx,17D10000C90
       mov       r14,[rcx]
       cmp       byte ptr [r14+9D],0
       jne       near ptr M12_L43
M12_L17:
       xor       eax,eax
       mov       [rbx],rax
M12_L18:
       mov       rax,r15
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L19:
       test      edi,edi
       jne       near ptr M12_L11
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M12_L00
M12_L20:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.Span<System.ReadOnlyMemory<System.Char>>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,17D100021B0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset System.Text.RegularExpressions.Regex+<>c.<SegmentsToStringAndDispose>b__100_0(System.Span`1<Char>, System.Span`1<System.ReadOnlyMemory`1<Char>>)
       call      qword ptr [7FF9F7B26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17D100021D8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L03
M12_L21:
       test      ebp,ebp
       jne       short M12_L22
       mov       r15,1BDA4F60008
       jmp       near ptr M12_L12
M12_L22:
       mov       ecx,28
       call      qword ptr [7FF9F7DA7870]
       int       3
M12_L23:
       mov       [rsp+50],r13
       mov       [rsp+58],ebp
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M12_L12
M12_L24:
       mov       ecx,9
       call      qword ptr [7FF9F82C4C90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M12_L13
M12_L25:
       mov       rcx,rsi
       call      qword ptr [7FF9F8207DC8]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M12_L14
M12_L26:
       mov       rdx,rax
       call      qword ptr [7FF9F7B257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M12_L15
M12_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82C4CA8]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A64000
       call      qword ptr [7FF9F7DA7738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F7F75DD0]
       mov       rcx,rbx
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
       call      qword ptr [7FF9F82C4CC0]
M12_L29:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A6B17C],0
       je        short M12_L30
       call      qword ptr [7FF9F82C4CD8]
       mov       [rsp+6C],eax
       jmp       short M12_L32
M12_L30:
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       mov       eax,[rax+10]
       mov       [rsp+68],eax
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       mov       ecx,[rsp+68]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M12_L31
       call      qword ptr [7FF9F82C4D08]
       mov       edx,eax
       mov       [rsp+6C],edx
       jmp       short M12_L32
M12_L31:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rsp+6C],edx
M12_L32:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+6C]
       xor       edx,edx
       div       dword ptr [7FF9F7A6B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M12_L39
M12_L33:
       cmp       eax,[r12+8]
       jae       near ptr M12_L46
       mov       [rsp+74],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+64],r10d
       mov       rcx,r8
       call      qword ptr [7FF9F810D5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+60],r8d
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
       mov       ecx,[rsp+60]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+64],1
M12_L35:
       mov       rcx,rax
       call      qword ptr [7FF9F7B26820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+64],0
       je        short M12_L37
       jmp       short M12_L40
M12_L36:
       jmp       short M12_L34
M12_L37:
       mov       eax,[rsp+74]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M12_L38
       xor       ecx,ecx
M12_L38:
       mov       edx,[rsp+70]
       inc       edx
       mov       eax,ecx
M12_L39:
       mov       [rsp+70],edx
       cmp       [r12+8],edx
       jg        near ptr M12_L33
       jmp       short M12_L41
M12_L40:
       mov       r12d,1
       jmp       short M12_L42
M12_L41:
       xor       r12d,r12d
M12_L42:
       jmp       near ptr M12_L16
M12_L43:
       cmp       dword ptr [rdi+8],0
       je        near ptr M12_L17
       mov       rcx,rdi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+7C],eax
       mov       edx,[rdi+8]
       mov       [rsp+78],edx
       mov       rcx,rsi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rsp+7C]
       mov       r9d,[rsp+78]
       mov       edx,3
       call      qword ptr [7FF9F82C4D50]
       test      r12d,r13d
       jne       near ptr M12_L17
       mov       rcx,rdi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
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
       call      qword ptr [7FF9F82C4D68]
       jmp       near ptr M12_L17
M12_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1500
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
       call      qword ptr [7FFA575635D8]
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
       call      qword ptr [7FFA57556148]
       test      rax,rax
       jne       short M14_L06
       call      qword ptr [7FFA575483F0]
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
       call      qword ptr [7FFA575635E0]
       jmp       short M14_L00
M14_L05:
       call      qword ptr [7FFA575483F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M14_L01
M14_L06:
       mov       rcx,rbx
       call      qword ptr [7FFA57559728]
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
       call      qword ptr [7FF9F82C7D50]
       int       3
; Total bytes of code 44
```
```assembly
; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M16_L00
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       jmp       short M16_L01
M16_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF9F827ADE8
       call      qword ptr [7FF9F7DA7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M16_L01:
       lea       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9F8017000]; System.MemoryExtensions.AsSpan(System.String)
       vmovdqu   xmm0,xmmword ptr [rbp-20]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       mov       eax,[rbp+28]
       mov       [rsp+20],eax
       mov       rax,[rbp+30]
       mov       [rsp+28],rax
       mov       rax,[rbp+38]
       mov       [rsp+30],rax
       mov       eax,[rbp+40]
       mov       [rsp+38],eax
       movzx     eax,byte ptr [rbp+48]
       mov       [rsp+40],eax
       lea       r9,[rbp-30]
       mov       rdx,[rbp-10]
       mov       r8,[rbp+20]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F8207978]; System.Text.RegularExpressions.Regex.RunAllMatchesWithCallback[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.StructListBuilder`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]], System.Text.RegularExpressions],[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.String, System.ReadOnlySpan`1<Char>, Int32, System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.MatchCallback`1<System.ValueTuple`5<System.__Canon,System.Text.StructListBuilder`1<System.ReadOnlyMemory`1<Char>>,System.ReadOnlyMemory`1<Char>,Int32,Int32>>, System.Text.RegularExpressions.RegexRunnerMode, Boolean)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 198
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
       jne       near ptr M17_L04
       mov       ebp,100
M17_L00:
       mov       rcx,17D10002190
       mov       r14,[rcx]
       mov       r15,r14
       mov       r13,r15
       mov       rcx,17D10000C90
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
       jle       near ptr M17_L11
       mov       rcx,[rcx+240]
       mov       r8,[rcx+48]
       test      r8,r8
       je        near ptr M17_L11
M17_L01:
       mov       [rsp+30],r8
       mov       rcx,[r8+10]
       test      rcx,rcx
       je        near ptr M17_L14
       mov       r10d,[rcx+8]
       mov       edx,[rsp+0B4]
       cmp       r10d,edx
       jbe       near ptr M17_L15
       mov       r10d,edx
       shl       r10,4
       mov       r9,[rcx+r10+10]
       test      r9,r9
       je        near ptr M17_L13
       xor       r11d,r11d
       mov       [rcx+r10+10],r11
       mov       rax,[rsp+68]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M17_L12
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
       ja        short M17_L05
       mov       rcx,rax
       call      00007FFA576E5D60
       cmp       dword ptr [7FFA57A4F778],0
       je        short M17_L06
       jmp       near ptr M17_L31
M17_L04:
       mov       ebp,[rdi+8]
       add       ebp,ebp
       jmp       near ptr M17_L00
M17_L05:
       mov       rcx,rax
       call      qword ptr [7FF9F82C5158]
M17_L06:
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
M17_L07:
       xor       eax,eax
       mov       dword ptr [rsp+90],1
       cmp       [r13+8],r15d
       jbe       near ptr M17_L09
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
       call      qword ptr [7FF9F820C1B0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M17_L08:
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
M17_L09:
       cmp       byte ptr [r12+9D],0
       jne       near ptr M17_L55
M17_L10:
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
M17_L11:
       mov       ecx,9
       call      qword ptr [7FF9F82C4C90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r8,rax
       jmp       near ptr M17_L01
M17_L12:
       mov       [rsp+60],r9
       mov       rcx,r9
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rbp,[rsp+60]
       mov       eax,[rbp+8]
       mov       [rsp+9C],eax
       mov       rcx,r15
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+0B4]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+9C]
       mov       rcx,[rsp+68]
       call      qword ptr [7FF9F82C50F8]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L13:
       mov       edx,[rsp+0B4]
       jmp       short M17_L15
M17_L14:
       mov       edx,[rsp+0B4]
M17_L15:
       mov       rcx,[r13+10]
       cmp       [rcx+8],edx
       jbe       near ptr M17_L28
       mov       r10d,edx
       mov       rcx,[rcx+r10*8+10]
       test      rcx,rcx
       je        near ptr M17_L27
       mov       rbp,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A6B17C],0
       je        short M17_L16
       call      qword ptr [7FF9F82C4CD8]
       mov       r15d,eax
       jmp       short M17_L18
M17_L16:
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       mov       r15d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M17_L17
       call      qword ptr [7FF9F82C4D08]
       mov       r15d,eax
       jmp       short M17_L18
M17_L17:
       sar       r15d,10
M17_L18:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF9F7A6B170]
       mov       r15d,edx
       xor       eax,eax
       jmp       near ptr M17_L22
M17_L19:
       cmp       r15d,[rbp+8]
       jae       near ptr M17_L58
       mov       ecx,r15d
       mov       rdx,[rbp+rcx*8+10]
       mov       [rsp+50],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       rcx,rdx
       call      qword ptr [7FF9F810D5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rsp+50]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M17_L20
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rsp+58],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M17_L20:
       mov       rcx,rdx
       call      qword ptr [7FF9F7B26820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rsp+58]
       test      rcx,rcx
       jne       short M17_L23
       inc       r15d
       cmp       [rbp+8],r15d
       jne       short M17_L21
       xor       r15d,r15d
M17_L21:
       mov       eax,[rsp+98]
       inc       eax
M17_L22:
       mov       [rsp+98],eax
       cmp       [rbp+8],eax
       jg        near ptr M17_L19
       jmp       short M17_L24
M17_L23:
       mov       rbp,rcx
       jmp       short M17_L25
M17_L24:
       xor       ebp,ebp
M17_L25:
       test      rbp,rbp
       je        short M17_L27
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        short M17_L26
       mov       rcx,rbp
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       edx,[rbp+8]
       mov       [rsp+0A0],edx
       mov       rcx,r13
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r13d,[rsp+0B4]
       mov       [rsp+20],r13d
       mov       edx,[rsp+0A4]
       mov       r8d,[rsp+0A0]
       mov       rcx,r15
       call      qword ptr [7FF9F82C50F8]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L26:
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L27:
       mov       ecx,10
       mov       edx,[rsp+0B4]
       shlx      ebp,ecx,edx
       jmp       short M17_L30
M17_L28:
       test      ebp,ebp
       jne       short M17_L29
       mov       rbp,1BDA4F70D80
       jmp       near ptr M17_L03
M17_L29:
       mov       ecx,ebp
       mov       rdx,1BDA4F66F28
       call      qword ptr [7FF9F7DAD770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M17_L30:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.ReadOnlyMemory<System.Char>[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r15,[rsp+68]
       cmp       byte ptr [r15+9D],0
       je        near ptr M17_L32
       mov       rcx,rbp
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0B0],eax
       mov       edx,[rbp+8]
       mov       [rsp+0AC],edx
       mov       rcx,r13
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0AC]
       mov       rcx,r15
       call      qword ptr [7FF9F82C50F8]
       mov       eax,[rbp+8]
       mov       [rsp+0A8],eax
       mov       rcx,r13
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F82C5110]
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L06
M17_L32:
       mov       r9,rbp
       jmp       near ptr M17_L02
M17_L33:
       mov       rcx,rax
       call      qword ptr [7FF9F7B25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M17_L06
M17_L34:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F82C5650]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
       test      rbp,rbp
       jne       short M17_L35
       xor       r9d,r9d
       jmp       short M17_L36
M17_L35:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF9F82C5650]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M17_L36:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FF9F82C5170]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M17_L06
M17_L37:
       mov       rcx,r14
       call      qword ptr [7FF9F8207DC8]; System.Buffers.SharedArrayPool`1[[System.ReadOnlyMemory`1[[System.Char, System.Private.CoreLib]], System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r13,rax
       jmp       near ptr M17_L07
M17_L38:
       mov       rdx,r10
       call      qword ptr [7FF9F7B257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M17_L08
M17_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82C4CA8]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A64000
       call      qword ptr [7FF9F7DA7738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F7F75DD0]
       mov       rcx,rbx
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
       call      qword ptr [7FF9F82C4CC0]
M17_L41:
       mov       rax,[rax+8]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A6B17C],0
       je        short M17_L42
       call      qword ptr [7FF9F82C4CD8]
       mov       [rsp+7C],eax
       jmp       short M17_L44
M17_L42:
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       mov       eax,[rax+10]
       mov       [rsp+78],eax
       mov       ecx,0A
       call      qword ptr [7FF9F82C4CF0]
       mov       ecx,[rsp+78]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M17_L43
       call      qword ptr [7FF9F82C4D08]
       mov       edx,eax
       mov       [rsp+7C],edx
       jmp       short M17_L44
M17_L43:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rsp+7C],edx
M17_L44:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+7C]
       xor       edx,edx
       div       dword ptr [7FF9F7A6B170]
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
       call      qword ptr [7FF9F810D5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF9F7B26820]; System.Threading.Monitor.Exit(System.Object)
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
       jmp       near ptr M17_L09
M17_L55:
       cmp       dword ptr [rdi+8],0
       mov       [rsp+94],eax
       je        near ptr M17_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rdi+8]
       mov       [rsp+8C],eax
       mov       rcx,r14
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,r13d
       mov       r9d,[rsp+8C]
       mov       edx,3
       call      qword ptr [7FF9F82C4D50]
       mov       r13d,[rsp+94]
       test      [rsp+90],r13d
       jne       near ptr M17_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+88],eax
       mov       edi,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FF9F801C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F82C4D68]
       jmp       near ptr M17_L10
M17_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2285
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9F7FF5AA0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rbx,rax
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rcx
       jne       near ptr M00_L26
       mov       rcx,220FA401370
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L17
M00_L00:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,220FA400108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,220FA4000F8
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       call      qword ptr [7FF9F7D840F0]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rsi,rax
M00_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F7FF6058]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L20
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       mov       rcx,rdi
       mov       rdx,2618F5A0698
       mov       r9d,1
       call      qword ptr [7FF9F7FF6A48]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L02
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L18
M00_L02:
       test      r14,r14
       je        near ptr M00_L20
M00_L03:
       test      r14,r14
       je        near ptr M00_L39
       mov       rcx,221104000F8
       mov       rbx,[rcx]
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L27
       xor       esi,esi
M00_L04:
       mov       rdi,[rbx+38]
       test      rdi,rdi
       je        near ptr M00_L28
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
       mov       rdx,7FF9F8346F28
       call      qword ptr [7FF9F7B06E20]
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
       je        short M00_L10
       mov       [rbp-70],r10
       mov       rcx,[r10+18]
       cmp       [rcx],cl
       mov       rdx,2618F5925A8
       cmp       rcx,rdx
       je        short M00_L14
       jmp       near ptr M00_L30
M00_L10:
       mov       [rsp+20],r12
       mov       edx,eax
       mov       r8,r15
       mov       r9d,r13d
       mov       rcx,2618F5925A8
       call      qword ptr [7FF9F821F108]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r15,rax
       mov       r13,[rdi+8]
       and       r13,0FFFFFFFFFFFFFFFE
       je        near ptr M00_L33
       test      r15,r15
       je        short M00_L11
       cmp       qword ptr [7FF9F7A4B020],0
       jne       near ptr M00_L34
M00_L11:
       xor       eax,eax
M00_L12:
       test      r13b,2
       jne       near ptr M00_L35
       test      rax,rax
       jne       near ptr M00_L35
       mov       rcx,r13
       mov       rdx,r15
       call      00007FFA57617580
M00_L13:
       mov       [rbp-70],r15
M00_L14:
       mov       r10,[rbp-70]
       cmp       [r10],r10b
       cmp       [r14+8],esi
       jb        near ptr M00_L36
       test      byte ptr [rbx+40],40
       jne       near ptr M00_L38
       cmp       byte ptr [r10+20],0
       jne       near ptr M00_L38
       mov       rcx,[r10+10]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L37
       mov       rcx,[r10+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L40
       mov       r8,[rcx+10]
M00_L15:
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F821F360]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M00_L16:
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
M00_L17:
       mov       ecx,2
       call      qword ptr [7FF9F82D7180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L18:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L19:
       mov       rcx,rdi
       mov       rdx,2618F5A0698
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L20:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FF9F82D7ED0]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rsi
M00_L21:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF9F805DC28]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L24
       mov       rcx,[rbp-58]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF9F7C6D950]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L24
       cmp       r14,rdi
       je        short M00_L21
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,2618F5A0698
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L22
       mov       rdi,r14
       jmp       short M00_L21
M00_L22:
       cmp       qword ptr [rbx+38],0
       je        short M00_L23
       mov       rdx,[rbx+38]
       mov       [rbp-68],rdx
       mov       byte ptr [rbp-40],0
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9F7B05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        short M00_L23
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M00_L23:
       mov       [rbp-60],r15
       jmp       short M00_L25
M00_L24:
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L03
M00_L25:
       call      M00_L42
       nop
       mov       r14,[rbp-60]
       jmp       near ptr M00_L03
M00_L26:
       mov       r8,220FA401370
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,2618F5A0698
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L27:
       mov       esi,[r14+8]
       jmp       near ptr M00_L04
M00_L28:
       lea       rdi,[rbx+38]
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F7B06D78]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       test      rdi,rdi
       jne       short M00_L29
       call      qword ptr [7FF9F82D6CD0]
       int       3
M00_L29:
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA576EFBA0
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L05
       mov       rdi,[rbx+38]
       jmp       near ptr M00_L05
M00_L30:
       cmp       dword ptr [rcx+8],1
       jne       near ptr M00_L10
       lea       r9,[rcx+0C]
       mov       rdx,2618F5925B4
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M00_L31
       mov       r8,[r9]
       mov       r9,[r9+2]
       mov       rcx,[rdx]
       xor       r8,rcx
       xor       r9,[rdx+2]
       or        r8,r9
       sete      dl
       movzx     edx,dl
       mov       eax,edx
       jmp       short M00_L32
M00_L31:
       mov       rcx,r9
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L32:
       test      eax,eax
       mov       eax,[rbp-44]
       jne       near ptr M00_L14
       jmp       near ptr M00_L10
M00_L33:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82DC420]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rax,[7FF9F7A4B020]
       mov       rcx,r15
       call      rax
       test      eax,eax
       je        near ptr M00_L11
       mov       rcx,r15
       call      qword ptr [7FF9F82DC438]
       jmp       near ptr M00_L12
M00_L35:
       lea       rcx,[rdi+8]
       mov       rdx,r15
       mov       r8,rax
       call      qword ptr [7FF9F82DC450]
       jmp       near ptr M00_L13
M00_L36:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F82D7FD8]
       int       3
M00_L37:
       mov       r8,2618F590008
       jmp       near ptr M00_L15
M00_L38:
       mov       [rsp+20],esi
       mov       rcx,r10
       mov       rdx,rbx
       mov       r8,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9F82DC000]
       jmp       near ptr M00_L16
M00_L39:
       xor       eax,eax
       jmp       near ptr M00_L16
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M00_L41
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M00_L41:
       nop
       add       rsp,28
       ret
M00_L42:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-58]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
; Total bytes of code 1573
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
       mov       rbx,220FA401368
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
       mov       rcx,2618F59B988
       call      qword ptr [7FF9F82DC210]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,2618F59B910
       call      qword ptr [7FF9F7FF5AD0]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
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
       call      qword ptr [7FFA575487D0]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FFA5755FA90]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA57560C28]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFA5755E468]
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
       jne       near ptr M03_L21
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M03_L20
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L23
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M03_L22
M03_L01:
       cmp       rdi,rdx
       jne       near ptr M03_L17
M03_L02:
       mov       rax,220FA400100
       mov       rax,[rax]
       mov       [rbp+18],rax
M03_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L26
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       jne       near ptr M03_L10
       mov       rcx,[rbp-30]
       call      00007FFA57629E20
       test      eax,eax
       je        near ptr M03_L11
M03_L04:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M03_L13
       mov       rcx,[rbp+18]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M03_L12
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+38]
       mov       rdx,[rdx+8]
       cmp       rax,rdx
       jne       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       mov       rbx,[rax+10]
       jmp       near ptr M03_L15
M03_L07:
       test      rax,rax
       je        near ptr M03_L14
       test      rdx,rdx
       je        near ptr M03_L14
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L14
       lea       r10,[rax+0C]
       add       rdx,0C
       mov       r8d,[rax+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L08
       mov       rcx,r10
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L09
M03_L08:
       mov       rax,[r10]
       mov       r8,[r10+2]
       mov       r10,[rdx]
       xor       rax,r10
       xor       r8,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M03_L09:
       test      eax,eax
       je        near ptr M03_L24
       jmp       short M03_L06
M03_L10:
       call      qword ptr [7FF9F82D7798]
       int       3
M03_L11:
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F82D7480]
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,2618F590008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M03_L05
M03_L14:
       xor       eax,eax
       jmp       short M03_L09
M03_L15:
       cmp       byte ptr [rbp-28],0
       je        short M03_L16
       mov       rcx,[rbp-30]
       call      00007FFA576E6030
       test      eax,eax
       jne       near ptr M03_L25
M03_L16:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       test      rdi,rdi
       je        near ptr M03_L03
       test      rdx,rdx
       je        near ptr M03_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L03
       lea       rax,[rdi+0C]
       add       rdx,0C
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L18
       mov       rcx,rax
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L19
M03_L18:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M03_L19:
       test      eax,eax
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L20:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,2618F590008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L21:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M03_L23
M03_L22:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,2618F590008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M03_L01
M03_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M03_L01
M03_L24:
       call      M03_L30
       jmp       short M03_L26
M03_L25:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF9F82D73A8]
       jmp       near ptr M03_L16
M03_L26:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M03_L27
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B79590]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L27
       mov       rcx,rbx
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M03_L27:
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L29
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+38],0
       je        short M03_L28
       mov       rdx,[rcx+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       lea       rcx,[rax+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L28
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M03_L28:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L29:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L30:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L31
       mov       rcx,[rbp-30]
       call      00007FFA576E6030
       test      eax,eax
       je        short M03_L31
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF9F82D73A8]
M03_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M03_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L33
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M03_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 1123
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
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M04_L36
       mov       rax,[rcx+28]
       mov       [rbp-68],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M04_L37
       test      rbx,rbx
       je        near ptr M04_L37
       mov       [rbp-70],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       jne       near ptr M04_L13
       mov       rcx,rbx
       call      00007FFA57629E20
       test      eax,eax
       je        near ptr M04_L14
M04_L00:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L28
       mov       rsi,[rbx+18]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       jne       near ptr M04_L15
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M04_L02
       lea       r11,[rdx+0C]
M04_L01:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       edi
       jne       short M04_L01
M04_L02:
       mov       edi,ecx
M04_L03:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M04_L32
       mov       r8d,r8d
       lea       rcx,[rcx+r8*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       cmp       [r15+8],r14d
       jbe       near ptr M04_L28
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       jne       near ptr M04_L19
M04_L04:
       mov       ecx,r14d
       shl       rcx,5
       lea       r12,[r15+rcx+10]
       cmp       [r12+8],edi
       jne       near ptr M04_L18
       mov       rax,[r12]
       cmp       rax,rdx
       jne       short M04_L09
       mov       esi,1
M04_L05:
       test      esi,esi
       je        near ptr M04_L18
M04_L06:
       add       r12,10
M04_L07:
       test      r12,r12
       je        near ptr M04_L12
       vmovdqu   xmm0,xmmword ptr [r12]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M04_L29
M04_L08:
       mov       [rbp-78],rsi
       jmp       near ptr M04_L34
M04_L09:
       test      rax,rax
       je        near ptr M04_L17
       mov       ecx,[rax+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       near ptr M04_L17
       lea       rcx,[rax+0C]
       lea       r10,[rdx+0C]
       mov       r8d,[rax+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M04_L10
       mov       rdx,r10
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       esi,eax
       jmp       short M04_L11
M04_L10:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       rax,[r10]
       xor       r8,rax
       xor       rcx,[r10+2]
       or        rcx,r8
       sete      sil
       movzx     esi,sil
M04_L11:
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L05
M04_L12:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9F7FF6AC0]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M04_L33
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F7FF6B38]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF9F7FF6BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L08
M04_L13:
       call      qword ptr [7FF9F82D7798]
       int       3
M04_L14:
       mov       rcx,rbx
       call      qword ptr [7FF9F82D7480]
       jmp       near ptr M04_L00
M04_L15:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FF9F7A50A58
       call      qword ptr [r11]
       mov       edi,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L03
M04_L16:
       cmp       [r15+8],r14d
       jbe       near ptr M04_L28
       jmp       near ptr M04_L04
M04_L17:
       xor       esi,esi
       jmp       near ptr M04_L05
M04_L18:
       mov       r14d,[r12+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jae       short M04_L16
       jmp       near ptr M04_L27
M04_L19:
       mov       ecx,r14d
       shl       rcx,5
       lea       r12,[r15+rcx+10]
       cmp       [r12+8],edi
       jne       near ptr M04_L26
       mov       rax,[r12]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       [rsi],rcx
       je        short M04_L20
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,rax
       mov       r11,7FF9F7A50A60
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L25
M04_L20:
       cmp       rax,rdx
       je        short M04_L24
       test      rax,rax
       je        short M04_L23
       mov       ecx,[rax+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       short M04_L23
       add       rax,0C
       lea       r10,[rdx+0C]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M04_L21
       mov       rcx,rax
       mov       rdx,r10
       call      qword ptr [7FF9F7B0FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L22
M04_L21:
       mov       rdx,[rbp+18]
       mov       rcx,rax
       mov       r8,r10
       mov       r11,[rcx]
       mov       rcx,[rcx+2]
       mov       rax,[r8]
       xor       r11,rax
       xor       rcx,[r8+2]
       or        rcx,r11
       sete      r10b
       movzx     r10d,r10b
M04_L22:
       jmp       short M04_L25
M04_L23:
       xor       r10d,r10d
       jmp       short M04_L25
M04_L24:
       mov       r10d,1
M04_L25:
       test      r10d,r10d
       jne       near ptr M04_L06
M04_L26:
       mov       r14d,[r12+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M04_L27
       cmp       [r15+8],r14d
       jbe       short M04_L28
       jmp       near ptr M04_L19
M04_L27:
       call      qword ptr [7FF9F7D879A8]
       int       3
M04_L28:
       xor       r12d,r12d
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L07
M04_L29:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M04_L30
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F82D77F8]
       jmp       short M04_L31
M04_L30:
       mov       rcx,[rbp-68]
       mov       edx,eax
       call      qword ptr [7FF9F816E250]; System.Resources.ResourceReader.LoadString(Int32)
M04_L31:
       mov       [rbp-78],rax
       jmp       short M04_L34
M04_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L33:
       call      M04_L50
       jmp       near ptr M04_L39
M04_L34:
       cmp       byte ptr [rbp-50],0
       je        short M04_L35
       mov       rcx,[rbp-70]
       call      00007FFA576E6030
       test      eax,eax
       jne       short M04_L38
M04_L35:
       mov       rax,[rbp-78]
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
M04_L36:
       mov       ecx,13BFC
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       rcx,rax
       call      qword ptr [7FF9F82D6790]
       int       3
M04_L37:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82D77C8]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F82D77E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L38:
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9F82D73A8]
       jmp       short M04_L35
M04_L39:
       cmp       byte ptr [rbp+20],0
       jne       short M04_L40
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
M04_L40:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M04_L41
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,220FA400070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F7FF68F8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M04_L41:
       mov       [rbp-70],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FF9F7B05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M04_L44
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FF9F82D7810]
       jmp       short M04_L43
M04_L42:
       mov       rcx,rsi
       call      qword ptr [7FF9F8063BD8]
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
       call      qword ptr [7FF9F7FF6BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M04_L43:
       mov       rcx,rsi
       call      qword ptr [7FF9F8063BD0]
       test      eax,eax
       jne       short M04_L42
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M04_L44:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F8061F60]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M04_L45
       xor       r8d,r8d
       mov       [rbp-78],r8
       jmp       short M04_L48
M04_L45:
       cmp       qword ptr [rbp-48],0
       je        short M04_L46
       mov       r8,[rbp-48]
       mov       [rbp-78],r8
       jmp       short M04_L48
M04_L46:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-68]
       mov       edx,[rbp-40]
       call      qword ptr [7FF9F7FF6B38]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M04_L47
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FF9F7FF6BF8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M04_L47:
       cmp       byte ptr [rbp-50],0
       je        short M04_L49
       mov       rcx,[rbp-70]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M04_L49
M04_L48:
       call      M04_L52
       jmp       near ptr M04_L35
M04_L49:
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
M04_L50:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L51
       mov       rcx,[rbp-70]
       call      00007FFA576E6030
       test      eax,eax
       je        short M04_L51
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9F82D73A8]
M04_L51:
       nop
       add       rsp,28
       ret
M04_L52:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L53
       mov       rcx,[rbp-70]
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
M04_L53:
       nop
       add       rsp,28
       ret
; Total bytes of code 1599
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
       mov       rax,0FCCAF6812EEF
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       test      edi,200
       je        near ptr M05_L32
       mov       rax,220FA400100
       mov       r15,[rax]
M05_L00:
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
M05_L01:
       mov       edi,[rbp+88]
       mov       rcx,[rbp+58]
       cmp       edi,[rcx+8]
       jge       near ptr M05_L06
       mov       r14d,edi
       mov       rcx,[rbp+58]
       mov       r8d,[rcx+8]
       mov       edx,r8d
       sub       edx,edi
       cmp       r8d,edi
       jb        near ptr M05_L27
       movsxd    r8,edi
       lea       rcx,[rcx+r8*2+0C]
       mov       r8d,edx
       mov       edx,24
       call      qword ptr [7FF9F7CA7738]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jge       near ptr M05_L07
M05_L02:
       mov       [rbp+88],eax
       cmp       dword ptr [rbp+88],0
       jge       short M05_L03
       mov       rcx,[rbp+58]
       mov       ecx,[rcx+8]
       mov       [rbp+88],ecx
M05_L03:
       mov       edi,[rbp+88]
       sub       edi,r14d
       cmp       edi,1
       jg        near ptr M05_L17
       test      edi,edi
       je        near ptr M05_L05
       cmp       edi,1
       jne       near ptr M05_L21
       mov       rdi,[rbp+48]
       mov       rcx,[rbp+58]
       cmp       r14d,[rcx+8]
       jae       near ptr M05_L28
       mov       eax,r14d
       movzx     r14d,word ptr [rcx+rax*2+0C]
       mov       r15d,[rbp+0A0]
       and       r15d,0FFFFFFFE
       mov       rdx,[rbp+60]
       test      r15b,1
       jne       near ptr M05_L08
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
M05_L04:
       cmp       [rdi],dil
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       call      qword ptr [7FF9F821F1C8]; System.Text.RegularExpressions.RegexNode.Reduce()
       mov       r14,rax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+8],0
       jne       near ptr M05_L10
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M05_L05:
       mov       ecx,[rbp+88]
       mov       rax,[rbp+58]
       cmp       ecx,[rax+8]
       jge       near ptr M05_L01
       jmp       near ptr M05_L26
M05_L06:
       mov       rdi,[rbp+48]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexReplacement
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF9F821F1E0]; System.Text.RegularExpressions.RegexReplacement..ctor(System.String, System.Text.RegularExpressions.RegexNode, System.Collections.Hashtable)
       jmp       near ptr M05_L29
M05_L07:
       add       eax,edi
       jmp       near ptr M05_L02
M05_L08:
       lea       r8,[rbp+8C]
       lea       r9,[rbp+20]
       mov       ecx,r14d
       call      qword ptr [7FF9F82DF318]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+2E],9
       and       r15d,0FFFFFFFE
       mov       [r13+28],r15d
       mov       [r13+2C],r14w
       jmp       near ptr M05_L04
M05_L09:
       vmovdqu   xmm0,xmmword ptr [rbp+20]
       vmovdqu   xmmword ptr [rbp+10],xmm0
       lea       rcx,[rbp+10]
       call      qword ptr [7FF9F82DF330]
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
       jmp       near ptr M05_L04
M05_L10:
       mov       rdx,[rdi+8]
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexNode
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M05_L15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FF9F7F563D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       inc       dword ptr [r13+14]
       mov       r12,[r13+8]
       mov       eax,[r13+10]
       cmp       [r12+8],eax
       jbe       short M05_L11
       lea       ecx,[rax+1]
       mov       [r13+10],ecx
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L12
M05_L11:
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FF9F7CAE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M05_L12:
       inc       dword ptr [r13+14]
       mov       r15,[r13+8]
       mov       r12d,[r13+10]
       cmp       [r15+8],r12d
       jbe       short M05_L13
       lea       ecx,[r12+1]
       mov       [r13+10],ecx
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L14
M05_L13:
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FF9F7CAE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M05_L14:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L05
M05_L15:
       mov       rdx,[rdi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       inc       dword ptr [rax+14]
       mov       rdi,[rax+8]
       mov       r15d,[rax+10]
       cmp       [rdi+8],r15d
       jbe       short M05_L16
       lea       ecx,[r15+1]
       mov       [rax+10],ecx
       mov       ecx,r15d
       lea       rcx,[rdi+rcx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L05
M05_L16:
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FF9F7CAE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M05_L05
M05_L17:
       mov       ecx,[rbp+0A0]
       not       ecx
       and       ecx,1
       or        ecx,1
       jne       short M05_L20
       mov       rcx,[rbp+58]
       test      rcx,rcx
       jne       short M05_L19
M05_L18:
       mov       ecx,21
       call      qword ptr [7FF9F7D87870]
       int       3
M05_L19:
       mov       eax,r14d
       mov       edx,edi
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        short M05_L18
       mov       eax,r14d
       lea       rcx,[rcx+rax*2+0C]
       mov       eax,edi
       mov       [rbp+10],rcx
       mov       [rbp+18],eax
       lea       rcx,[rbp+10]
       call      qword ptr [7FF9F82DF300]
       test      eax,eax
       jne       short M05_L21
M05_L20:
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
       call      qword ptr [7FF9F7CAF3F0]; System.String.Substring(Int32, Int32)
       mov       byte ptr [r12+2E],0C
       mov       [r12+28],r13d
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9F821F1B0]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       jmp       near ptr M05_L05
M05_L21:
       mov       r9,[rbp+58]
       test      r9,r9
       jne       short M05_L22
       or        r14d,edi
       jne       near ptr M05_L18
       xor       r15d,r15d
       xor       edi,edi
       jmp       short M05_L23
M05_L22:
       mov       ecx,r14d
       mov       edx,edi
       add       rcx,rdx
       mov       edx,[r9+8]
       cmp       rcx,rdx
       ja        near ptr M05_L18
       mov       ecx,r14d
       lea       r15,[r9+rcx*2+0C]
M05_L23:
       xor       r14d,r14d
       jmp       short M05_L25
M05_L24:
       movzx     ecx,word ptr [r15+r14*2]
       mov       r13,[rbp+48]
       lea       r9,[rbp+8C]
       mov       edx,[rbp+0A0]
       mov       r8,[rbp+60]
       call      qword ptr [7FF9F821F198]; System.Text.RegularExpressions.RegexNode.CreateOneWithCaseConversion(Char, System.Text.RegularExpressions.RegexOptions, System.Globalization.CultureInfo, System.Text.RegularExpressions.RegexCaseBehavior ByRef)
       mov       rdx,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF9F821F1B0]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       inc       r14d
M05_L25:
       cmp       r14d,edi
       jl        short M05_L24
       jmp       near ptr M05_L05
M05_L26:
       mov       ecx,[rbp+88]
       inc       ecx
       mov       [rbp+88],ecx
       mov       rdi,[rbp+48]
       lea       rcx,[rbp+30]
       call      qword ptr [7FF9F82DF2E8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F821F1B0]; System.Text.RegularExpressions.RegexNode.AddChild(System.Text.RegularExpressions.RegexNode)
       xor       ecx,ecx
       mov       [rbp+50],rcx
       jmp       near ptr M05_L01
M05_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F8165908]
       int       3
M05_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L29:
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       jne       short M05_L33
M05_L30:
       mov       rax,r14
       mov       r8,0FCCAF6812EEF
       cmp       [rbp+8],r8
       je        short M05_L31
       call      CORINFO_HELP_FAIL_FAST
M05_L31:
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
M05_L32:
       call      qword ptr [7FF9F7D85D88]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r15,rax
       jmp       near ptr M05_L00
M05_L33:
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,220FA401D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81F8238]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
       jmp       short M05_L30
       sub       rsp,28
       mov       rdx,[rbp+0A8]
       test      rdx,rdx
       je        short M05_L34
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       mov       rcx,220FA401D10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F81F8238]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M05_L34:
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
       sub       rsp,1C8
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M06_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M06_L00
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M06_L130
       mov       ecx,[rbx+8]
       mov       rax,rbx
M06_L01:
       mov       [rbp-70],rbx
       mov       [rbp+20],rdi
       mov       [rbp-68],rdi
       mov       rdx,2618F5A0D68
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
       mov       rcx,22110400190
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M06_L131
M06_L02:
       mov       [rbp-128],rsi
       cmp       [rsi],sil
       test      r14,r14
       jne       near ptr M06_L127
       xor       r13d,r13d
       xor       r12d,r12d
M06_L03:
       mov       eax,[rbp+30]
       mov       [rbp-84],eax
       lea       rcx,[rsi+30]
       xor       edx,edx
       xchg      rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L132
M06_L04:
       mov       [rbp-138],rdx
       mov       [rbp-130],rdx
       lea       rcx,[rdx+8]
       mov       [rbp-120],r14
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+48]
       mov       rcx,[rbp-130]
       call      qword ptr [7FF9F821F648]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       esi,[rbp-84]
       mov       [rbp-88],esi
       jmp       near ptr M06_L33
M06_L05:
       mov       rsi,[rdx+30]
       mov       rax,[rsi+18]
       mov       [rbp-1C0],rax
       test      rax,rax
       je        near ptr M06_L71
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-148],rdx
       mov       rax,rsi
       mov       r10,[rbp-1C0]
       mov       [rbp-150],r10
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rsi,[rbp-138]
       mov       r9,[rsi+8]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF9F821F7B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-148]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-148]
M06_L06:
       mov       rsi,[rbp-138]
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L36
M06_L07:
       lea       r9d,[rdx-10]
       movsxd    r9,r9d
       lea       r9,[rcx+r9*2]
       mov       [rbp-170],r9
       cmp       r11,r9
       ja        near ptr M06_L77
M06_L08:
       vmovups   ymm1,[r11]
       vpminuw   ymm1,ymm1,[7FF9F835A680]
       vmovups   ymm2,[r9]
       vpminuw   ymm2,ymm2,[7FF9F835A680]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9F835A6A0]
       vbroadcastsd ymm2,qword ptr [7FF9F835A6C0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L79
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r9d,ymm0
       tzcnt     r9d,r9d
       cmp       r9d,10
       jge       near ptr M06_L78
M06_L09:
       sub       r11,rcx
       shr       r11,1
       add       r9d,r11d
       jmp       near ptr M06_L40
M06_L10:
       vmovups   xmm0,[r9]
       lea       r9d,[rdx-8]
       movsxd    r9,r9d
       lea       r9,[rcx+r9*2]
       mov       [rbp-168],r9
       cmp       rcx,r9
       ja        near ptr M06_L80
       mov       r11,rcx
M06_L11:
       vmovups   xmm1,[r11]
       vpminuw   xmm1,xmm1,[7FF9F835A680]
       vmovups   xmm2,[r9]
       vpminuw   xmm2,xmm2,[7FF9F835A680]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9F835A6A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9F835A6C0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L79
       vpmovmskb r9d,xmm0
       tzcnt     r9d,r9d
       cmp       r9d,8
       jge       near ptr M06_L81
M06_L12:
       sub       r11,rcx
       shr       r11,1
       add       r9d,r11d
       jmp       near ptr M06_L40
M06_L13:
       mov       r9d,r11d
       lea       rcx,[rcx+r9*2]
       mov       [rbp-98],r11d
       sub       edx,r11d
       mov       r9d,[rbp-98]
M06_L14:
       mov       r11,rcx
       add       r8,88
       cmp       edx,10
       jge       near ptr M06_L82
       mov       ecx,edx
       lea       rcx,[r11+rcx*2]
       mov       rdx,r11
       mov       rdi,[r8]
       mov       r8d,[r8+10]
       mov       [rbp-9C],r8d
       cmp       r11,rcx
       je        short M06_L16
M06_L15:
       movzx     r14d,word ptr [rdx]
       mov       ebx,r8d
       imul      ebx,r14d
       mov       r8d,[rdi+8]
       imul      r8,rbx
       shr       r8,20
       movzx     r8d,word ptr [rdi+r8*2+10]
       cmp       r8d,r14d
       je        near ptr M06_L83
       add       rdx,2
       cmp       rdx,rcx
       mov       r8d,[rbp-9C]
       jne       short M06_L15
M06_L16:
       mov       r8d,0FFFFFFFF
M06_L17:
       mov       edx,r8d
       test      edx,edx
       jl        short M06_L18
       lea       edx,[r8+r9]
M06_L18:
       mov       r9d,edx
       jmp       near ptr M06_L41
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M06_L19:
       mov       edi,r11d
       shr       edi,9
       mov       [rbp-1D0],rdi
       mov       rdi,7FFA568D7008
       mov       r14,[rbp-1D0]
       movzx     edi,byte ptr [rdi+r14]
       shl       edi,6
       mov       r14d,r11d
       shr       r14d,3
       and       r14d,3E
       add       edi,r14d
       mov       r14,7FFA568D4B10
       movzx     edi,word ptr [r14+rdi]
       shl       edi,4
       and       r11d,0F
       add       r11d,edi
       mov       rdi,7FFA568DCDE8
       movzx     r11d,byte ptr [rdi+r11]
       mov       rdi,7FFA568E58B8
       cmp       byte ptr [rdi+r11],0
       jl        near ptr M06_L43
M06_L20:
       test      r8d,r8d
       je        near ptr M06_L84
       cmp       r8d,ecx
       ja        near ptr M06_L104
       add       r8d,r9d
       mov       [rax+4C],r8d
       mov       r10d,r9d
       mov       r11d,r8d
       cmp       r11d,r10d
       jl        near ptr M06_L85
M06_L21:
       cmp       dword ptr [rax+58],0
       jne       near ptr M06_L24
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       mov       r8,[rax+20]
       mov       [rbp-1C8],r8
       mov       edx,[r8+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-178],rax
       mov       rcx,[rbp-1C8]
       mov       rdx,rcx
       mov       [rbp-180],rdx
       mov       r10d,[rcx+8]
       mov       [rbp-0A8],r10d
       mov       r9d,[rcx+8]
       mov       [rbp-0AC],r9d
       test      rdx,rdx
       je        near ptr M06_L105
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M06_L54
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L54
       cmp       r9d,[rdx+8]
       ja        near ptr M06_L54
       lea       r8d,[r10+r9]
       cmp       r8d,[rax+8]
       ja        near ptr M06_L54
       movzx     r8d,word ptr [rcx]
       mov       r9d,r9d
       imul      r9,r8
       add       rdx,10
       mov       r10d,r10d
       imul      r8,r10
       lea       r10,[rax+r8+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L44
       cmp       r9,4000
       ja        near ptr M06_L88
       mov       rcx,r10
       mov       r8,r9
       call      00007FFA576E5D60
       cmp       dword ptr [7FFA57A4F778],0
       jne       near ptr M06_L86
M06_L22:
       cmp       dword ptr [7FFA57A4F778],0
       jne       near ptr M06_L87
M06_L23:
       mov       rax,[rbp-160]
       mov       rcx,[rax+20]
       mov       ecx,[rcx+8]
       add       [rax+58],ecx
       lea       rcx,[rax+20]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
M06_L24:
       mov       rcx,[rax+20]
       mov       edx,[rax+58]
       dec       edx
       mov       [rax+58],edx
       cmp       edx,[rcx+8]
       jae       near ptr M06_L109
       xor       r8d,r8d
       mov       [rcx+rdx*4+10],r8d
       mov       rax,[rax+28]
       mov       [rbp-188],rax
       mov       r8,[rax+48]
       mov       [rbp-190],r8
       cmp       dword ptr [r8+8],0
       jbe       near ptr M06_L109
       cmp       qword ptr [r8+10],0
       je        near ptr M06_L96
M06_L25:
       mov       rax,[rbp-188]
       mov       r8,[rax+48]
       mov       [rbp-198],r8
       mov       rax,[rax+50]
       mov       [rbp-1A0],rax
       cmp       dword ptr [rax+8],0
       jbe       near ptr M06_L109
       mov       r9d,[rax+10]
       mov       [rbp-0C0],r9d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M06_L109
       mov       rdx,[r8+10]
       lea       ecx,[r9*2+2]
       cmp       [rdx+8],ecx
       jl        near ptr M06_L97
M06_L26:
       cmp       dword ptr [r8+8],0
       jbe       near ptr M06_L109
       mov       rdx,[r8+10]
       mov       rcx,rdx
       lea       r8d,[r9+r9]
       cmp       r8d,[rcx+8]
       jae       near ptr M06_L109
       lea       r8d,[r9+r9]
       mov       [rcx+r8*4+10],r10d
       lea       ecx,[r9*2+1]
       cmp       ecx,[rdx+8]
       jae       near ptr M06_L109
       sub       r11d,r10d
       mov       [rdx+rcx*4+10],r11d
       mov       rax,[rbp-1A0]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M06_L109
       inc       r9d
       mov       [rax+10],r9d
M06_L27:
       mov       rax,[rsi+28]
       mov       rcx,[rax+50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M06_L109
       mov       ecx,[rcx+10]
       test      ecx,ecx
       jle       near ptr M06_L68
       mov       edx,[rsi+4C]
       mov       [rax+30],ecx
       xor       ecx,ecx
       mov       [rax+34],ecx
       mov       [rax+58],edx
       mov       ecx,[rax+5C]
       mov       [rax+5C],ecx
       mov       rcx,[rax+48]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M06_L109
       mov       rcx,[rcx+10]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M06_L109
       mov       edx,[rcx+14]
       mov       [rax+14],edx
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M06_L109
       mov       ecx,[rcx+10]
       mov       [rax+10],ecx
       mov       r8,rax
M06_L28:
       mov       [rbp-158],r8
       cmp       dword ptr [r8+30],0
       je        near ptr M06_L110
       mov       rcx,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       cmp       [r15+18],rcx
       jne       near ptr M06_L101
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M06_L69
       cmp       eax,[rcx+8]
       jae       near ptr M06_L109
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M06_L29:
       mov       r8,[rbp-158]
       mov       edx,[r8+10]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       cmp       [rcx+8],eax
       jbe       near ptr M06_L70
       cmp       eax,[rcx+8]
       jae       near ptr M06_L109
       mov       r10d,eax
       mov       [rcx+r10*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M06_L30:
       mov       r8,[rbp-158]
       mov       edx,[r8+10]
       add       edx,[r8+14]
       mov       [rbp-60],edx
       mov       edx,[rbp-5C]
       dec       edx
       mov       [rbp-5C],edx
       test      edx,edx
       je        near ptr M06_L110
M06_L31:
       mov       ecx,[rsi+4C]
       mov       edx,ecx
       cmp       dword ptr [r8+14],0
       je        near ptr M06_L102
M06_L32:
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
M06_L33:
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
       je        near ptr M06_L05
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
       jle       short M06_L35
M06_L34:
       xor       edx,edx
       mov       [rcx+rax*4+10],edx
       inc       eax
       cmp       [rcx+8],eax
       jg        short M06_L34
M06_L35:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M06_L36
       xor       eax,eax
       mov       [rcx+18],rax
M06_L36:
       mov       rsi,[rbp-138]
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M06_L72
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       mov       [rsi+50],eax
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       mov       [rsi+54],eax
       mov       ecx,[rcx+8]
       mov       [rsi+58],ecx
M06_L37:
       mov       eax,[rbp-88]
       mov       [rsi+4C],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Generated.<RegexGenerator_g>F84DEA1CB092AF406657C3B70F337DE6861063B8A819E9C09542127B324ABDBC4__SpacesRegex_18+RunnerFactory+Runner
       cmp       [rsi],rcx
       jne       near ptr M06_L100
       mov       rax,rsi
       mov       [rbp-160],rax
M06_L38:
       mov       r10d,[rax+4C]
       mov       [rbp-94],r10d
       cmp       r10d,r12d
       jae       near ptr M06_L67
       mov       ecx,r10d
       lea       rcx,[r13+rcx*2]
       mov       edx,r12d
       sub       edx,r10d
       mov       r8,22110400160
       mov       r8,[r8]
       xor       r9d,r9d
       cmp       edx,8
       jl        near ptr M06_L14
       cmp       word ptr [rcx],7F
       ja        near ptr M06_L14
       lea       r9,[r8+48]
       mov       r11,rcx
       cmp       edx,10
       jle       near ptr M06_L10
       vmovups   ymm0,[r9]
       cmp       edx,20
       jle       near ptr M06_L07
       lea       r9d,[rdx-20]
       movsxd    r9,r9d
       lea       r9,[rcx+r9*2]
M06_L39:
       vmovups   ymm1,[r11]
       vpminuw   ymm1,ymm1,[7FF9F835A680]
       vmovups   ymm2,[r11+20]
       vpminuw   ymm2,ymm2,[7FF9F835A680]
       vpackuswb ymm1,ymm1,ymm2
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9F835A6A0]
       vbroadcastsd ymm3,qword ptr [7FF9F835A6C0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       je        near ptr M06_L76
       mov       r9,r11
       sub       r9,rcx
       shr       r9,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r11d,ymm0
       tzcnt     r11d,r11d
       add       r9d,r11d
M06_L40:
       mov       r11d,r9d
       cmp       r11d,edx
       jae       short M06_L41
       mov       edi,r11d
       cmp       word ptr [rcx+rdi*2],7F
       ja        near ptr M06_L13
M06_L41:
       test      r9d,r9d
       jl        near ptr M06_L67
       mov       r10d,[rbp-94]
       add       r10d,r9d
       mov       rax,[rbp-160]
       mov       [rax+4C],r10d
       mov       r8d,r10d
       mov       r9d,r8d
       cmp       r9d,r12d
       ja        near ptr M06_L104
       mov       r8d,r9d
       lea       rdx,[r13+r8*2]
       mov       ecx,r12d
       sub       ecx,r9d
       xor       r8d,r8d
M06_L42:
       cmp       r8d,ecx
       jae       near ptr M06_L20
       movzx     r11d,word ptr [rdx+r8*2]
       cmp       r11d,100
       jge       near ptr M06_L19
       mov       r11d,r11d
       mov       rdi,7FFA568D6920
       test      byte ptr [rdi+r11],80
       je        near ptr M06_L20
M06_L43:
       inc       r8d
       jmp       short M06_L42
M06_L44:
       mov       rcx,r10
       mov       r8,rdx
       mov       r11,r9
       mov       rdi,rcx
       sub       rdi,r8
       cmp       rdi,r11
       jb        near ptr M06_L90
       mov       rdi,r8
       sub       rdi,rcx
       cmp       rdi,r11
       jb        near ptr M06_L90
       lea       rdi,[r8+r11]
       lea       r14,[rcx+r11]
       cmp       r11,10
       ja        short M06_L47
       test      r9b,18
       jne       short M06_L46
       test      r9b,4
       jne       short M06_L45
       test      r9,r9
       je        near ptr M06_L23
       movzx     edx,byte ptr [rdx]
       mov       [r10],dl
       test      r9b,2
       je        near ptr M06_L23
       movsx     r10,word ptr [rdi-2]
       mov       [r14-2],r10w
       jmp       near ptr M06_L23
M06_L45:
       mov       edx,[rdx]
       mov       [r10],edx
       mov       r10d,[rdi-4]
       mov       [r14-4],r10d
       jmp       near ptr M06_L23
M06_L46:
       mov       r11,[rdx]
       mov       [r10],r11
       mov       r10,[rdi-8]
       mov       [r14-8],r10
       jmp       near ptr M06_L23
M06_L47:
       cmp       r11,40
       ja        short M06_L50
M06_L48:
       vmovups   xmm0,[r8]
       vmovups   [rcx],xmm0
       cmp       r11,20
       ja        near ptr M06_L53
M06_L49:
       vmovups   xmm0,[rdi-10]
       vmovups   [r14-10],xmm0
       jmp       near ptr M06_L23
M06_L50:
       cmp       r11,800
       ja        near ptr M06_L91
       cmp       r11,100
       jb        short M06_L51
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
M06_L51:
       mov       r10,r11
       shr       r10,6
M06_L52:
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       r8,40
       dec       r10
       jne       short M06_L52
       and       r11,3F
       cmp       r11,10
       ja        near ptr M06_L48
       jmp       near ptr M06_L49
M06_L53:
       vmovups   xmm0,[r8+10]
       vmovups   [rcx+10],xmm0
       cmp       r11,30
       jbe       near ptr M06_L49
       jmp       near ptr M06_L89
M06_L54:
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M06_L57
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M06_L92
       mov       r8d,1
M06_L55:
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M06_L93
       mov       r11d,1
M06_L56:
       cmp       r8d,r11d
       jne       near ptr M06_L106
M06_L57:
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M06_L59
       xor       r8d,r8d
M06_L58:
       test      r8d,r8d
       jle       short M06_L60
       mov       [rbp-0B8],r8d
       mov       ecx,167
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       edx,[rbp-0B8]
       xor       ecx,ecx
       call      qword ptr [7FF9F82DC528]
       int       3
M06_L59:
       movsxd    r8,ecx
       mov       r8d,[rdx+r8*4+10]
       jmp       short M06_L58
M06_L60:
       neg       r8d
       mov       [rbp-0B0],r8d
       test      r8d,r8d
       jl        near ptr M06_L107
       lea       ecx,[r8+r9]
       cmp       ecx,[rdx+8]
       ja        near ptr M06_L107
       mov       rcx,[rax]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M06_L62
       xor       r11d,r11d
M06_L61:
       cmp       r10d,r11d
       jge       short M06_L63
       mov       [rbp-0BC],r11d
       mov       ecx,17F
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       edx,[rbp-0BC]
       mov       ecx,[rbp-0A8]
       call      qword ptr [7FF9F82DC528]
       int       3
M06_L62:
       movsxd    r11,ecx
       mov       r11d,[rax+r11*4+10]
       jmp       short M06_L61
M06_L63:
       sub       r10d,r11d
       mov       [rbp-0B4],r10d
       test      r10d,r10d
       jl        near ptr M06_L108
       lea       ecx,[r10+r9]
       cmp       ecx,[rax+8]
       ja        near ptr M06_L108
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       je        short M06_L65
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF9F82DC570]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M06_L64
       mov       r10d,[rbp-0AC]
       mov       [rsp+20],r10d
       mov       [rsp+28],eax
       mov       rcx,[rbp-180]
       mov       edx,[rbp-0B0]
       mov       r8,[rbp-178]
       mov       r9d,[rbp-0B4]
       call      qword ptr [7FF9F82DC588]
       jmp       near ptr M06_L23
M06_L64:
       mov       rax,[rbp-178]
       mov       rdx,[rbp-180]
M06_L65:
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
       jne       short M06_L66
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF9F7B05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L23
M06_L66:
       cmp       r9,4000
       ja        near ptr M06_L95
       mov       rcx,r10
       mov       r8,r9
       call      00007FFA576E5D60
       cmp       dword ptr [7FFA57A4F778],0
       je        near ptr M06_L22
       jmp       near ptr M06_L94
M06_L67:
       mov       rax,[rbp-160]
       mov       [rax+4C],r12d
       jmp       near ptr M06_L27
M06_L68:
       xor       r8d,r8d
       mov       [rax+8],r8
       mov       rcx,221104001B0
       mov       r8,[rcx]
       mov       rax,r8
       mov       r8,rax
       jmp       near ptr M06_L28
M06_L69:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F821FA08]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M06_L29
M06_L70:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F821FA08]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M06_L30
M06_L71:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       mov       [rsp+20],r12d
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       rsi,[rbp-138]
       mov       r9,[rsi+8]
       mov       rcx,[rbp-140]
       call      qword ptr [7FF9F821F7B0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       mov       rdx,[rbp-140]
       jmp       near ptr M06_L06
M06_L72:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       eax,[rsi+5C]
       shl       eax,3
       mov       r8d,eax
       cmp       eax,20
       jge       short M06_L73
       mov       r8d,20
M06_L73:
       cmp       eax,10
       mov       [rbp-8C],eax
       jge       short M06_L74
       mov       dword ptr [rbp-8C],10
M06_L74:
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
       jmp       near ptr M06_L37
M06_L75:
       inc       r10d
       mov       [rax+4C],r10d
       jmp       near ptr M06_L38
M06_L76:
       add       r11,40
       cmp       r11,r9
       jb        near ptr M06_L39
       jmp       near ptr M06_L07
M06_L77:
       mov       r11,r9
       jmp       near ptr M06_L08
M06_L78:
       mov       r11,[rbp-170]
       add       r9d,0FFFFFFF0
       jmp       near ptr M06_L09
M06_L79:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M06_L40
M06_L80:
       mov       r11,r9
       jmp       near ptr M06_L11
M06_L81:
       mov       r11,[rbp-168]
       add       r9d,0FFFFFFF8
       jmp       near ptr M06_L12
M06_L82:
       mov       [rbp-98],r9d
       call      qword ptr [7FF9F821FA80]; System.Buffers.ProbabilisticMap.IndexOfAnyVectorized[[System.Buffers.SearchValues+TrueConst, System.Private.CoreLib]](Char ByRef, Int32, System.Buffers.ProbabilisticMapState ByRef)
       mov       r8d,eax
       mov       r9d,[rbp-98]
       jmp       near ptr M06_L17
M06_L83:
       mov       r8,rdx
       sub       r8,r11
       shr       r8,1
       jmp       near ptr M06_L17
M06_L84:
       cmp       [rax+4C],r12d
       jne       near ptr M06_L75
       jmp       near ptr M06_L27
M06_L85:
       mov       [rbp-0A0],r9d
       mov       [rbp-0A4],r8d
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M06_L21
M06_L86:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L22
M06_L87:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L23
M06_L88:
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF9F816DB90]
       jmp       near ptr M06_L23
M06_L89:
       vmovups   xmm0,[r8+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M06_L49
M06_L90:
       cmp       r10,rdx
       jne       short M06_L91
       cmp       [rdx],dl
       jmp       near ptr M06_L23
M06_L91:
       cmp       [r10],r10b
       cmp       [rdx],dl
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF9F7B066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L23
M06_L92:
       mov       r8d,ecx
       jmp       near ptr M06_L55
M06_L93:
       mov       r11d,ecx
       jmp       near ptr M06_L56
M06_L94:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L22
M06_L95:
       mov       rcx,r10
       mov       r8,r9
       call      qword ptr [7FF9F816DB90]
       jmp       near ptr M06_L23
M06_L96:
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       mov       rcx,[rbp-190]
       xor       edx,edx
       call      qword ptr [7FF9F7B057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M06_L25
M06_L97:
       mov       [rbp-0A4],r10d
       mov       [rbp-0A0],r11d
       cmp       dword ptr [r8+8],0
       jbe       near ptr M06_L109
       mov       rcx,[r8+10]
       mov       [rbp-1A8],rcx
       lea       edx,[r9*8]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       xor       ecx,ecx
       jmp       short M06_L99
M06_L98:
       mov       r8,[rbp-1A8]
       cmp       ecx,[r8+8]
       jae       near ptr M06_L109
       mov       edx,[r8+rcx*4+10]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L109
       mov       [rax+rcx*4+10],edx
       inc       ecx
M06_L99:
       mov       r10d,[rbp-0C0]
       lea       r8d,[r10+r10]
       cmp       ecx,r8d
       jl        short M06_L98
       mov       rcx,[rbp-198]
       mov       r8,rax
       xor       edx,edx
       call      qword ptr [7FF9F7B057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r8,[rbp-198]
       mov       r9d,[rbp-0C0]
       mov       r10d,[rbp-0A4]
       mov       r11d,[rbp-0A0]
       jmp       near ptr M06_L26
M06_L100:
       mov       [rbp-0F0],r13
       mov       [rbp-0E8],r12d
       lea       rdx,[rbp-0F0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L27
M06_L101:
       lea       rdx,[rbp-70]
       mov       r8,[rbp-158]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r8,[rbp-158]
       je        near ptr M06_L110
       jmp       near ptr M06_L31
M06_L102:
       mov       edx,r12d
       mov       eax,1
       mov       r8,[rbp-128]
       test      byte ptr [r8+40],40
       je        short M06_L103
       xor       edx,edx
       mov       eax,0FFFFFFFF
M06_L103:
       cmp       ecx,edx
       je        near ptr M06_L110
       lea       edx,[rcx+rax]
       jmp       near ptr M06_L32
M06_L104:
       call      qword ptr [7FF9F7CA7138]
       int       3
M06_L105:
       mov       ecx,12D
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       rcx,rax
       call      qword ptr [7FF9F82D6790]
       int       3
M06_L106:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82DC5A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F82DC5B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L107:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F82DC5D0]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M06_L108:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82DC5E8]
       mov       rdi,rax
       mov       ecx,145
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L109:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L110:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       r8,[rbp-128]
       lea       rcx,[r8+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp-50],0
       mov       r14,[rbp-120]
       je        near ptr M06_L118
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M06_L128
       cmp       eax,r8d
       jae       near ptr M06_L157
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M06_L111:
       mov       rbx,[rbp+18]
       mov       edx,[rbx+8]
       sub       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       eax,[rbp-50]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M06_L129
       cmp       eax,r8d
       jae       near ptr M06_L157
       mov       r8d,eax
       mov       [rcx+r8*4+10],edx
       inc       eax
       mov       [rbp-50],eax
M06_L112:
       mov       rax,[rbp-58]
       mov       ecx,[rbp-50]
       test      rax,rax
       je        near ptr M06_L133
       cmp       [rax+8],ecx
       jb        near ptr M06_L134
       add       rax,10
M06_L113:
       mov       r14d,ecx
       shr       r14d,1
       dec       r14d
       mov       rdi,[rbp+20]
       imul      r14d,[rdi+8]
       mov       edx,1
       cmp       ecx,1
       jle       short M06_L115
M06_L114:
       cmp       edx,ecx
       jae       near ptr M06_L157
       add       r14d,[rax+rdx*4]
       add       edx,2
       cmp       edx,ecx
       jl        short M06_L114
M06_L115:
       mov       [rbp-80],rax
       mov       [rbp-78],ecx
       mov       rcx,22110400198
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M06_L135
M06_L116:
       test      rsi,rsi
       je        near ptr M06_L126
       test      r14d,r14d
       jle       near ptr M06_L124
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
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
M06_L117:
       mov       r14,r15
M06_L118:
       cmp       qword ptr [rbp-58],0
       je        near ptr M06_L123
       mov       rcx,220FA401D10
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
       jle       near ptr M06_L136
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M06_L136
M06_L119:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M06_L137
M06_L120:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M06_L121
       mov       r15d,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rsi+8],edx
       jne       near ptr M06_L138
       cmp       edi,ecx
       jae       near ptr M06_L157
       mov       ecx,edi
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-1B0],rax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-1B0]
       test      r12,r12
       jne       near ptr M06_L139
M06_L121:
       mov       rcx,220FA400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M06_L154
M06_L122:
       xor       eax,eax
       mov       [rbp-58],rax
M06_L123:
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
M06_L124:
       test      r14d,r14d
       je        short M06_L125
       mov       ecx,28
       call      qword ptr [7FF9F7D87870]
       int       3
M06_L125:
       mov       r15,2618F590008
       jmp       near ptr M06_L117
M06_L126:
       mov       ecx,1C
       call      qword ptr [7FF9F7D8C1C8]
       int       3
M06_L127:
       lea       r13,[r14+0C]
       mov       r12d,[r14+8]
       jmp       near ptr M06_L03
M06_L128:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F821FA08]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M06_L111
M06_L129:
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F821FA08]; System.Text.StructListBuilder`1[[System.Int32, System.Private.CoreLib]].GrowAndAdd(Int32)
       jmp       near ptr M06_L112
M06_L130:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M06_L01
M06_L131:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCallback<System.ValueTuple<System.String, System.String, System.Text.StructListBuilder<System.Int32>, System.ReadOnlyMemory<System.Char>, System.Int32, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,22110400188
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_0(System.ValueTuple`6<System.String,System.String,System.Text.StructListBuilder`1<Int32>,System.ReadOnlyMemory`1<Char>,Int32,Int32> ByRef, System.Text.RegularExpressions.Match)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22110400190
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L02
M06_L132:
       mov       rcx,[rsi+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       rdx,rax
       jmp       near ptr M06_L04
M06_L133:
       test      ecx,ecx
       jne       short M06_L134
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M06_L113
M06_L134:
       call      qword ptr [7FF9F7CA7138]
       int       3
M06_L135:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.IntPtr, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22110400188
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Text.RegularExpressions.RegexReplacement+<>c.<ReplaceSimpleText>b__17_1(System.Span`1<Char>, System.ValueTuple`3<IntPtr,System.String,System.String>)
       call      qword ptr [7FF9F7B06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22110400198
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L116
M06_L136:
       mov       ecx,7
       call      qword ptr [7FF9F82D7180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L119
M06_L137:
       mov       rcx,rbx
       call      qword ptr [7FF9F816E5F8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M06_L120
M06_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F82D7D50]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L139:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M06_L157
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M06_L140
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F82D7D68]
M06_L140:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A4B18C],0
       je        short M06_L141
       call      qword ptr [7FF9F82D7D80]
       mov       [rbp-0D4],eax
       jmp       short M06_L143
M06_L141:
       mov       ecx,9
       call      qword ptr [7FF9F82D7D98]
       mov       eax,[rax+10]
       mov       [rbp-0D8],eax
       mov       ecx,9
       call      qword ptr [7FF9F82D7D98]
       mov       ecx,[rbp-0D8]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M06_L142
       call      qword ptr [7FF9F82D7DB0]
       mov       edx,eax
       mov       [rbp-0D4],edx
       jmp       short M06_L143
M06_L142:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rbp-0D4],edx
M06_L143:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0D4]
       xor       edx,edx
       div       dword ptr [7FF9F7A4B180]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M06_L150
M06_L144:
       cmp       eax,[r13+8]
       jae       near ptr M06_L157
       mov       [rbp-0CC],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-1B8],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0DC],r10d
       mov       rcx,r8
       call      qword ptr [7FF9F80ED5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1B8]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0E0],r8d
       cmp       [rcx+8],r8d
       jbe       short M06_L146
       test      r8d,r8d
       jne       short M06_L147
       xor       edx,edx
       mov       [rax+14],edx
M06_L145:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0E0]
       inc       ecx
       mov       rax,[rbp-1B8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0DC],1
M06_L146:
       mov       rcx,rax
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0DC],0
       je        short M06_L148
       jmp       short M06_L151
M06_L147:
       jmp       short M06_L145
M06_L148:
       mov       eax,[rbp-0CC]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M06_L149
       xor       ecx,ecx
M06_L149:
       mov       edx,[rbp-0D0]
       inc       edx
       mov       eax,ecx
M06_L150:
       mov       [rbp-0D0],edx
       cmp       [r13+8],edx
       jg        near ptr M06_L144
       jmp       short M06_L152
M06_L151:
       mov       r13d,1
       jmp       short M06_L153
M06_L152:
       xor       r13d,r13d
M06_L153:
       jmp       near ptr M06_L121
M06_L154:
       cmp       dword ptr [rsi+8],0
       je        near ptr M06_L122
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0C4],eax
       mov       edx,[rsi+8]
       mov       [rbp-0C8],edx
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-0C4]
       mov       r9d,[rbp-0C8]
       mov       edx,3
       call      qword ptr [7FF9F82D7B40]
       test      r13d,r15d
       jne       near ptr M06_L122
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M06_L155
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M06_L156
M06_L155:
       mov       ecx,edi
       xor       edx,edx
M06_L156:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF9F82D7DC8]
       jmp       near ptr M06_L122
M06_L157:
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
; Total bytes of code 6247
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA57560D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF9F7B0FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rsi],0
       jne       short M09_L02
       test      rbx,rbx
       je        short M09_L01
       mov       rcx,rbx
       call      qword ptr [7FFA57560C38]
       test      eax,eax
       je        short M09_L03
M09_L00:
       mov       byte ptr [rsi],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA5755B268]
       int       3
M09_L02:
       call      qword ptr [7FFA57560C78]
       int       3
M09_L03:
       mov       rcx,rbx
       call      qword ptr [7FFA57560C48]
       jmp       short M09_L00
; Total bytes of code 72
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M10_L00
       mov       rcx,rbx
       call      00007FFA576E6030
       test      eax,eax
       jne       short M10_L01
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       xor       ecx,ecx
       call      qword ptr [7FF9F82D6790]
       int       3
M10_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F82D73A8]
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
       call      qword ptr [7FFA575635D8]
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
       call      qword ptr [7FFA57556148]
       test      rax,rax
       jne       short M11_L06
       call      qword ptr [7FFA575483F0]
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
       call      qword ptr [7FFA575635E0]
       jmp       short M11_L00
M11_L05:
       call      qword ptr [7FFA575483F0]
       mov       rax,[rax+8]
       mov       rcx,rbx
       call      rax
       mov       edi,eax
       jmp       short M11_L01
M11_L06:
       mov       rcx,rbx
       call      qword ptr [7FFA57559728]
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
       jb        near ptr M12_L14
       cmp       rsi,rdi
       je        near ptr M12_L04
       cmp       rbx,20
       jae       near ptr M12_L06
       mov       rcx,7FF9F82CD3C8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M12_L01
       mov       rcx,7FF9F82CD3E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9F82CD3E4
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
       mov       rcx,7FF9F82CD3AC
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
       ja        near ptr M12_L18
       mov       rcx,7FF9F82CD3CC
       call      CORINFO_HELP_COUNTPROFILE32
M12_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M12_L10
       mov       rcx,7FF9F82CD3D0
       call      CORINFO_HELP_COUNTPROFILE32
M12_L04:
       mov       rcx,7FF9F82CD3B0
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
       mov       rcx,7FF9F82CD3DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L09
M12_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M12_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M12_L08
M12_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M12_L11
       mov       rcx,7FF9F82CD3C0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M12_L07
M12_L08:
       mov       rcx,7FF9F82CD3C4
       call      CORINFO_HELP_COUNTPROFILE32
M12_L09:
       mov       rcx,7FF9F82CD3E8
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
       mov       rcx,7FF9F82CD3D4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L09
M12_L11:
       mov       rcx,7FF9F82CD3B4
       call      CORINFO_HELP_COUNTPROFILE32
M12_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M12_L13
       mov       rcx,7FF9F82CD3B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L04
M12_L13:
       mov       rcx,7FF9F82CD3BC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L09
M12_L14:
       cmp       rbx,4
       jb        short M12_L15
       mov       rcx,7FF9F82CD3A8
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
M12_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M12_L16
       mov       rcx,7FF9F82CD3A0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M12_L16:
       test      bl,1
       je        short M12_L17
       mov       rcx,7FF9F82CD3A4
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M12_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M12_L00
M12_L18:
       mov       rcx,7FF9F82CD3D8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M12_L05
       jmp       near ptr M12_L02
; Total bytes of code 686
```

