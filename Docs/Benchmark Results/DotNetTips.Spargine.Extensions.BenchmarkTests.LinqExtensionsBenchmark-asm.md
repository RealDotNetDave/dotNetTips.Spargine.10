## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1A6FF000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574B0DB8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B1F6F0]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5756F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5756F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5756F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D4C780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D4C798]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D45DD0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D4C780]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E793FE14C0
       call      qword ptr [7FFD57D4C798]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E793FD0008
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
       call      qword ptr [7FFD57D4E1F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,16616C00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574F0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B4EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD579ABEA8
       call      qword ptr [7FFD575AF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57875AC0
       call      qword ptr [7FFD575AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD575AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD579ABEA8
       call      qword ptr [7FFD575AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD575AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D8C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D8C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D857A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D8C180]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1A6ABC414C0
       call      qword ptr [7FFD57D8C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       mov       rax,1A6ABC30008
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
       call      qword ptr [7FFD57D8E220]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1A8F3000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574D0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B2F390]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7C210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D75B60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D7C210]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E9880E14C0
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E9880D0008
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
       call      qword ptr [7FFD57D7E190]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2396C800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574E0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B3EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7C168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D756C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D7C168]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27A016914C0
       call      qword ptr [7FFD57D7C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A01680008
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
       call      qword ptr [7FFD57D7E208]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1815B000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574B0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B0EF88]
       mov       ecx,2E3
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57835AC0
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D4C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D4C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D45758]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D4C180]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C1F00D14C0
       call      qword ptr [7FFD57D4C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C1F00C0008
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
       call      qword ptr [7FFD57D4E1A8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2A05DC00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574E0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B3EF88]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7FA80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7DB60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D75740]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57D7FA80]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2E0F2A914C0
       call      qword ptr [7FFD57D7DB60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E0F2A80008
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
       call      qword ptr [7FFD57D7E178]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,17541800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574D0F68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B2EB20]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C6D1B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C6D1D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57D7C018]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57C6D1B8]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B5D69514C0
       call      qword ptr [7FFD57C6D1D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B5D6940008
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
       call      qword ptr [7FFD57D7EA18]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1E915C00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFD574D11E0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD57B2EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C66E38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C66E50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFD57DBDD10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFD57C66E38]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,229AAD51648
       call      qword ptr [7FFD57C66E50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
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
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,229AAD40008
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
       call      qword ptr [7FFD57DBE5B0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,232BC000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,232BC000D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFD574C0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,232BC002A38
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L07
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L08
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,232BC000B40
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
M00_L02:
       mov       rsi,r15
       add       ebp,1
       jo        near ptr M00_L09
       cmp       ebp,2
       jl        near ptr M00_L00
       mov       [rsp+20],rsi
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFD57B1EF70]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C240]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFD57D55710]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFD57D5C228]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,273510214C0
       call      qword ptr [7FFD57D5C240]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,232BC002A28
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D51890
       mov       [r14+18],rcx
       mov       rcx,232BC002A38
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 667
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,232BC002A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L02
       xor       ecx,ecx
       mov       [rdi+20],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,232BC000B40
       mov       rdx,[rcx]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+48],0
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,232BC002A28
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D51890
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,232BC002A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
; Total bytes of code 215
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27351010008
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
       call      qword ptr [7FFD57D5E1C0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,18264400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,18264400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFD574D0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L06
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L00:
       mov       rcx,18264402A38
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L08
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18264400B40
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rsi,r15
       mov       rax,rsi
M00_L02:
       mov       rsi,rax
       add       ebp,1
       jo        near ptr M00_L10
       cmp       ebp,2
       jge       short M00_L04
M00_L03:
       mov       rax,[rdi+rbp*8+10]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rax+18],rdx
       je        near ptr M00_L00
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L02
M00_L04:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       call      qword ptr [7FFD57B2EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D6C180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D6C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFD57D65770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L07
       call      qword ptr [7FFD57D6C180]
       mov       rbx,rax
M00_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C2F93314C0
       call      qword ptr [7FFD57D6C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,18264402A28
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D618F0
       mov       [r14+18],rcx
       mov       rcx,18264402A38
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFD5758F948]
       int       3
M00_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 670
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,18264402A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L02
       xor       ecx,ecx
       mov       [rdi+20],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18264400B40
       mov       rdx,[rcx]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+48],0
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18264402A28
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D618F0
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18264402A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFD5758F948]
       int       3
; Total bytes of code 215
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C2F9320008
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
       call      qword ptr [7FFD57D6E238]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1F1E8400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,1F1E8400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rdi
       mov       r11,7FFD574C0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L08
       xor       ebp,ebp
       cmp       ebp,2
       jl        near ptr M00_L06
M00_L00:
       mov       [rsp+20],rsi
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
M00_L01:
       mov       rcx,1F1FE400A38
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L10
M00_L02:
       test      rsi,rsi
       je        near ptr M00_L15
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       r15,rsi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r15],rcx
       je        short M00_L03
       xor       r15d,r15d
M00_L03:
       test      r15,r15
       je        near ptr M00_L13
       cmp       dword ptr [r15+8],0
       je        near ptr M00_L12
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L04:
       mov       rax,rsi
M00_L05:
       mov       rsi,rax
       add       ebp,1
       jo        near ptr M00_L16
       cmp       ebp,2
       jge       near ptr M00_L00
M00_L06:
       mov       rax,[rdi+rbp*8+10]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rax+18],rdx
       je        near ptr M00_L01
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L05
M00_L07:
       call      qword ptr [7FFD57B1EF70]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       call      qword ptr [7FFD57D55668]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFD57D5C258]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2327D5814C0
       call      qword ptr [7FFD57D5C270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1F1FE400A30
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D517B8
       mov       [r14+18],rcx
       mov       rcx,1F1FE400A38
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,rax
       mov       rdx,r14
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r15,rax
       mov       rsi,r15
       jmp       near ptr M00_L04
M00_L12:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1F1FE400AC0
       mov       rsi,[rdx]
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M00_L14
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,r15
       jmp       near ptr M00_L04
M00_L15:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 909
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1F1FE400A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L03
M02_L00:
       test      rbx,rbx
       je        near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M02_L01
       xor       edi,edi
M02_L01:
       test      rdi,rdi
       je        near ptr M02_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F1FE400A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D517B8
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F1FE400A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L04:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M02_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M02_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1F1FE400AC0
       mov       rbp,[rdx]
       jmp       near ptr M02_L02
M02_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D5F630]
       mov       rbp,rbx
       jmp       near ptr M02_L02
M02_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D5F648]
       jmp       near ptr M02_L02
; Total bytes of code 418
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2327D570008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D5E1F0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1C8E7800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,1C8E7800D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFD574C0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L07
       xor       ebp,ebp
       cmp       ebp,2
       jge       near ptr M00_L04
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L05
       mov       rcx,1C8FD800A38
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L09
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       r15,rsi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r15],rcx
       je        short M00_L02
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       je        near ptr M00_L12
       cmp       dword ptr [r15+8],0
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       rsi,r13
       add       ebp,1
       jo        near ptr M00_L15
       cmp       ebp,2
       jl        near ptr M00_L00
M00_L04:
       mov       [rsp+28],rsi
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFD57B1EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C1C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFD57D55788]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFD57D5C1C8]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2097C7814C0
       call      qword ptr [7FFD57D5C1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1C8FD800A30
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D518D8
       mov       [r14+18],rcx
       mov       rcx,1C8FD800A38
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L10:
       mov       rcx,rax
       mov       rdx,r14
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1C8FD800AC0
       mov       r13,[rdx]
       jmp       near ptr M00_L03
M00_L12:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M00_L13
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,rsi
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L14:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 912
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1C8FD800A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C8FD800A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D518D8
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C8FD800A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1C8FD800AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D5F6C0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D5F6D8]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2097C770008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D5E268]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,23877400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,23877400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFD574C0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L07
       xor       ebp,ebp
       cmp       ebp,2
       jge       near ptr M00_L04
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L05
       mov       rcx,2388D400A38
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L09
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       r15,rsi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r15],rcx
       je        short M00_L02
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       je        near ptr M00_L12
       cmp       dword ptr [r15+8],0
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       rsi,r13
       add       ebp,1
       jo        near ptr M00_L15
       cmp       ebp,2
       jl        near ptr M00_L00
M00_L04:
       mov       [rsp+28],rsi
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFD57B1EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C1C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFD57D556C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFD57D5C1C8]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2790C4414C0
       call      qword ptr [7FFD57D5C1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2388D400A30
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D51818
       mov       [r14+18],rcx
       mov       rcx,2388D400A38
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L10:
       mov       rcx,rax
       mov       rdx,r14
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2388D400AC0
       mov       r13,[rdx]
       jmp       near ptr M00_L03
M00_L12:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M00_L13
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,rsi
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L14:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 912
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,2388D400A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2388D400A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D51818
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2388D400A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2388D400AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D5F6C0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D5F6D8]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2790C430008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D5E268]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,24AF6000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,24AF6000D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFD574B0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,24B0C000A40
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L07
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L08
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,24AF6000B40
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
M00_L02:
       mov       rsi,r15
       add       ebp,1
       jo        near ptr M00_L09
       cmp       ebp,2
       jl        near ptr M00_L00
       mov       [rsp+20],rsi
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFD57B0EAA8]
       mov       ecx,2E3
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57835AC0
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D2C690]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D2C6A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFD57D25278]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFD57D2C690]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28B8AFB14C0
       call      qword ptr [7FFD57D2C6A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,24B0C000A30
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D213F8
       mov       [r14+18],rcx
       mov       rcx,24B0C000A40
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFD5756F948]
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 667
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,24B0C000A40
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L02
       xor       ecx,ecx
       mov       [rdi+20],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,24AF6000B40
       mov       rdx,[rcx]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+48],0
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24B0C000A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D213F8
       call      qword ptr [7FFD57566BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24B0C000A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFD5756F948]
       int       3
; Total bytes of code 215
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28B8AFA0008
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
       call      qword ptr [7FFD57D2E1D8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,20FBC000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,20FBC000D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFD574D0F28
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,20FD2000A40
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L07
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L08
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20FBC000B40
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
M00_L02:
       mov       rsi,r15
       add       ebp,1
       jo        near ptr M00_L09
       cmp       ebp,2
       jl        near ptr M00_L00
       mov       [rsp+20],rsi
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFD57B2EF70]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C1B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C1C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFD57D56EB0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFD57D5C1B0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25050ED14C0
       call      qword ptr [7FFD57D5C1C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,20FD2000A30
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57D53030
       mov       [r14+18],rcx
       mov       rcx,20FD2000A40
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFD5758F948]
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 667
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,20FD2000A40
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L02
       xor       ecx,ecx
       mov       [rdi+20],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20FBC000B40
       mov       rdx,[rcx]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+48],0
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20FD2000A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D53030
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20FD2000A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFD5758F948]
       int       3
; Total bytes of code 215
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
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25050EC0008
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
       call      qword ptr [7FFD57D5E9D0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrueMultipleTransforms()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1D436000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,1D436000D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFD574E11E8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L07
       xor       ebp,ebp
       cmp       ebp,2
       jge       near ptr M00_L04
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L05
       mov       rcx,1D44C000AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L09
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       r15,rsi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [r15],rcx
       je        short M00_L02
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       je        near ptr M00_L12
       cmp       dword ptr [r15+8],0
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       rsi,r13
       add       ebp,1
       jo        near ptr M00_L15
       cmp       ebp,2
       jl        near ptr M00_L00
M00_L04:
       mov       [rsp+28],rsi
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFD57B3EAA8]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C74E40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C74E58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFD57DCDD10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFD57C74E40]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,214CAE71648
       call      qword ptr [7FFD57C74E58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1D44C000AD8
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD57DC9E60
       mov       [r14+18],rcx
       mov       rcx,1D44C000AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L10:
       mov       rcx,rax
       mov       rdx,r14
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D44C000B28
       mov       r13,[rdx]
       jmp       near ptr M00_L03
M00_L12:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M00_L13
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,rsi
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L14:
       mov       ecx,11
       call      qword ptr [7FFD5759F948]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 912
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1D44C000AE0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D44C000AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57DC9E60
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D44C000AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5759F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D44C000B28
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57EE4EB8]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57EE4ED0]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 88
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
       je        near ptr M03_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L00
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
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
M03_L00:
       test      rbx,rbx
       je        short M03_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L02
M03_L01:
       mov       rax,214CAE60008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFD57DCE610]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2C2D1800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574B0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,2C2E7800A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B0EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57835AC0
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D4C168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D4C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D45698]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D4C168]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,303669A14C0
       call      qword ptr [7FFD57D4C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2C2E7800A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D417E8
       call      qword ptr [7FFD57566BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C2E7800A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2C2E7800AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D4F3F0]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D4F408]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,2C2E7800A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C2E7800A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D417E8
       call      qword ptr [7FFD57566BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C2E7800A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5756F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2C2E7800AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D4F3F0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D4F408]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,30366990008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D4E208]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D4CE40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57565C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,265A2800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574D0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,265B8800A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B2EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57855AC0
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5798BEA8
       call      qword ptr [7FFD5758F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5758D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D6C168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D6C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D65698]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D6C168]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A6376C14C0
       call      qword ptr [7FFD57D6C180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,265B8800A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D617E8
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,265B8800A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,265B8800AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D6F3F0]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D6F408]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,265B8800A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,265B8800A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D617E8
       call      qword ptr [7FFD57586BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,265B8800A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5758F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,265B8800AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D6F3F0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D6F408]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57585818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2A6376B0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D6E208]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D6CE40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57585C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1FA6F800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574E0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,1FA85800A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B3EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7C210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D75770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D7C210]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23B047914C0
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1FA85800A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D718C0
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FA85800A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1FA85800AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D7F408]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D7F420]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1FA85800A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1FA85800A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D718C0
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FA85800A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5759F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1FA85800AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D7F408]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D7F420]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,23B04780008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D7E220]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D7CE28]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2BFDE000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574E0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,2BFF4000A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B3EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D7C210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D75770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D7C210]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,30072F214C0
       call      qword ptr [7FFD57D7C228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2BFF4000A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D718C0
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2BFF4000A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2BFF4000AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D7F420]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D7F438]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,2BFF4000A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2BFF4000A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D718C0
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2BFF4000A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5759F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2BFF4000AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D7F420]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D7F438]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,30072F10008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D7E220]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D7CE28]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,297CC400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574C0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,297E2400A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B1EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D5C198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D5C1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D55788]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D5C198]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D8615A14C0
       call      qword ptr [7FFD57D5C1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,297E2400A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D518D8
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,297E2400A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,297E2400AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D5F438]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D5F450]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,297E2400A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,297E2400A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D518D8
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,297E2400A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,297E2400AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D5F438]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D5F450]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2D861590008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D5E238]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D5CE58]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,18ABF000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574B0D98
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,18AD5000A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B0EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57835AC0
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5796BEA8
       call      qword ptr [7FFD5756F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5756D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57D4C198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57D4C1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D45788]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57D4C198]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1CB541A14C0
       call      qword ptr [7FFD57D4C1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18AD5000A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D418D8
       call      qword ptr [7FFD57566BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18AD5000A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,18AD5000AC0
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57D4FB40]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57D4FB58]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,18AD5000A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18AD5000A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D418D8
       call      qword ptr [7FFD57566BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18AD5000A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5756F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,18AD5000AC0
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57D4FB40]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57D4FB58]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57565818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1CB54190008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D4E238]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57D4CE70]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57565C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1A95CC00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574C0F68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,1A95CC02A68
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B1EFD0]
       mov       ecx,2E3
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57845AC0
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5797BEA8
       call      qword ptr [7FFD5757F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5757D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C5D1D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C5D1E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57D5C300]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57C5D1D0]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E9F1BF14C0
       call      qword ptr [7FFD57C5D1E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A95CC02A60
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57D58450
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A95CC02A68
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1A95CC02B18
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57E34900]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57E34918]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1A95CC02A68
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A95CC02A60
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57D58450
       call      qword ptr [7FFD57576BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A95CC02A68
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5757F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1A95CC02B18
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57E34900]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57E34918]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
; Total bytes of code 88
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
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
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57575818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1E9F1BE0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFD57D5EA60]
       int       3
; Total bytes of code 244
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57C5DF20]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57575C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldTrue()
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
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2B1DB400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFD574E11E0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,2B1F1400AE0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFD57B3EF70]
       mov       ecx,2E3
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57865AC0
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD5799BEA8
       call      qword ptr [7FFD5759F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5759D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57C74D68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57C74D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFD57DBDCF8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD57C74D68]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2F270541648
       call      qword ptr [7FFD57C74D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2B1F1400AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFD57DB9E48
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B1F1400AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2B1F1400B28
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFD57EE4C18]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD57EE4C30]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 766
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,2B1F1400AE0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L05
       mov       rdi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        short M01_L01
       xor       edi,edi
M01_L01:
       test      rdi,rdi
       je        near ptr M01_L07
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2B1F1400AD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFD57DB9E48
       call      qword ptr [7FFD57596BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B1F1400AE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD5759F948]
       int       3
M01_L05:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L06:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2B1F1400B28
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFD57EE4C18]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFD57EE4C30]
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 88
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
       je        near ptr M03_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L00
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFDB721A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD57595818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
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
M03_L00:
       test      rbx,rbx
       je        short M03_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L02
M03_L01:
       mov       rax,2F270530008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFD57DBE5C8]
       int       3
; Total bytes of code 235
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD57C75A40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFD57595C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

