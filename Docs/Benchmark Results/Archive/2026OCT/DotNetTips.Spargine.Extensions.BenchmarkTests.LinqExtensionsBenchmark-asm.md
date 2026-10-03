## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,14ED4400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF900E68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5FDB0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDE0A58
       call      qword ptr [7FFCDFBDC030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC957E0
       call      qword ptr [7FFCDFBDC030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0A58
       call      qword ptr [7FFCDFBDC030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE02367F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDFF5F570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE0186D48]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE02367F0]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,18F695D1928
       call      qword ptr [7FFCDFF5F570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,18F695C0008
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
       call      qword ptr [7FFCE018D7E8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1E8C5000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF8F0B18
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF47720]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0177E88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0177EA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE007E640]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE0177E88]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2295A041928
       call      qword ptr [7FFCE0177EA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,2295A030008
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
       call      qword ptr [7FFCE017C108]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1B6AA800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF8F0DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF4F3A8]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE018FAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE0186358]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE018FAC8]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F73F921928
       call      qword ptr [7FFCE018E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,1F73F910008
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
       call      qword ptr [7FFCE018E928]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,24458000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF900DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5ED18]
       mov       ecx,3D5
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254288]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017E328]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE0175C38]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE0254288]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,284ECF41928
       call      qword ptr [7FFCE017E328]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,284ECF30008
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
       call      qword ptr [7FFCE017E910]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,19676400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF900DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5F3C0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE02541F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE0196358]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE02541F8]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D70B2D1928
       call      qword ptr [7FFCE019E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,1D70B2C0008
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
       call      qword ptr [7FFCE019E928]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2D61F000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF3EF28]
       mov       ecx,3D5
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE02341F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE0155EF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE02341F8]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,316B3DE1928
       call      qword ptr [7FFCE015E340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       mov       rax,316B3DD0008
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
       call      qword ptr [7FFCE015E928]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2A6AB000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF8E1000
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF3F3C0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE008FC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE008FC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE018D4B8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE008FC60]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2E7401A19C0
       call      qword ptr [7FFCE008FC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E740190008
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
       call      qword ptr [7FFCE018F6A8]
       int       3
; Total bytes of code 231
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark.IfShouldFalse()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,26FBD000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rdi
       mov       r11,7FFCDF9111D0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L01
       mov       [rsp+28],rsi
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF6F408]
       mov       ecx,3D5
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE00B6CB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE00B6CD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L01:
       call      qword ptr [7FFCE01DE730]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L02
       call      qword ptr [7FFCE00B6CB8]
       mov       rbx,rax
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B051F61AB0
       call      qword ptr [7FFCE00B6CD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 360
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B051F50008
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
       call      qword ptr [7FFCE01DF7B0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1CAF1400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,1CAF1400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFCDF900DA0
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
       mov       rcx,1CB07400A58
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFCDFF5EF10]
       mov       ecx,3D5
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017FE70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFCE0175DB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFCE017FE70]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20B86381928
       call      qword ptr [7FFCE017E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1CB07400A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE0171F08
       mov       [r14+18],rcx
       mov       rcx,1CB07400A58
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
       mov       rdx,1CB07400AE0
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
       call      qword ptr [7FFCDFBD7E58]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1CB07400A58
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
       mov       rdx,1CB07400A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0171F08
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CB07400A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBD7E58]
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
       mov       rdx,1CB07400AE0
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
       call      qword ptr [7FFCE017FD80]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE017FD98]
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
       mov       rax,20B86370008
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
       call      qword ptr [7FFCE017E988]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1A2C3C00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,1A2C3C00D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFCDF8F0DA0
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
       mov       rcx,1A2D9C00A58
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFCDFF4EF88]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016D248]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016D260]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFCE0165E18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFCE016D248]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E358B01928
       call      qword ptr [7FFCE016D260]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1A2D9C00A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE0161F68
       mov       [r14+18],rcx
       mov       rcx,1A2D9C00A58
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
       mov       rdx,1A2D9C00AE0
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
       call      qword ptr [7FFCDFBC7E58]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1A2D9C00A58
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
       mov       rdx,1A2D9C00A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0161F68
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A2D9C00A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rdx,1A2D9C00AE0
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
       call      qword ptr [7FFCE02341B0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE02341C8]
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
       mov       rax,1E358AF0008
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
       call      qword ptr [7FFCE016EDA8]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2597F400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,2597F400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DA0
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
       mov       rcx,2597F402A50
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFCDFF3F1B0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017FE70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFCE0176358]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFCE017FE70]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29A144A1928
       call      qword ptr [7FFCE017E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2597F402A48
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE01724A8
       mov       [r14+18],rcx
       mov       rcx,2597F402A50
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
       mov       rdx,2597F402AD8
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
       call      qword ptr [7FFCDFBB7E58]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,2597F402A50
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
       mov       rdx,2597F402A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE01724A8
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2597F402A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBB7E58]
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
       mov       rdx,2597F402AD8
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
       call      qword ptr [7FFCE017FD80]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE017FD98]
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
       mov       rax,29A14490008
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
       call      qword ptr [7FFCE017E988]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,20E4CC00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,20E4CC00D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       mov       r11,7FFCDF8E0DA0
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
       mov       rcx,20E62C00A58
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
M00_L05:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r13,rax
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFCDFF3EF10]
       mov       ecx,3D5
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244588]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFCE0155EA8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFCE0244588]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24EE1DB1928
       call      qword ptr [7FFCE015E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,20E62C00A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE0151FF8
       mov       [r14+18],rcx
       mov       rcx,20E62C00A58
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
       mov       rdx,20E62C00AE0
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
       call      qword ptr [7FFCDFBB7E58]
       int       3
M00_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,20E62C00A58
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
       mov       rdx,20E62C00A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0151FF8
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20E62C00A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBB7E58]
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
       mov       rdx,20E62C00AE0
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
       call      qword ptr [7FFCE0244498]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE02444B0]
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
       mov       rax,24EE1DA0008
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
       call      qword ptr [7FFCE015E970]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,26BAF400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,26BAF400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFCDF8F0DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       rax,[rdi+rbp*8+10]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rax+18],rdx
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L03
M00_L01:
       mov       rcx,26BC5400A60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L07
M00_L02:
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
       mov       rcx,26BAF400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rsi,r15
       mov       rax,rsi
M00_L03:
       mov       rsi,rax
       add       ebp,1
       jo        near ptr M00_L09
       cmp       ebp,2
       jl        near ptr M00_L00
       mov       [rsp+20],rsi
       mov       rbx,[rbx+90]
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
M00_L04:
       call      qword ptr [7FFCDFF4EF88]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016FE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE0165E48]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE016FE58]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2AC442A1928
       call      qword ptr [7FFCE016E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,26BC5400A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE0161FC8
       mov       [r14+18],rcx
       mov       rcx,26BC5400A60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 668
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,26BC5400A60
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
       mov       rcx,26BAF400A08
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
       mov       rdx,26BC5400A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0161FC8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26BC5400A60
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rax,2AC44290008
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
       call      qword ptr [7FFCE016E970]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,2754B000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,2754B000D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFCDF8F0DA0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,2754B002A58
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
       mov       rcx,2754B000A08
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFCDFF4F360]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244588]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE0186340]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0244588]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B5E0151928
       call      qword ptr [7FFCE018E3A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2754B002A48
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE01824C0
       mov       [r14+18],rcx
       mov       rcx,2754B002A58
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
       int       3
M00_L09:
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
       mov       rcx,2754B002A58
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
       mov       rcx,2754B000A08
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
       mov       rdx,2754B002A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE01824C0
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2754B002A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rax,2B5E0140008
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
       call      qword ptr [7FFCE018E988]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,18871400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,18871400D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFCDF8F0E68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,18887400A60
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
       mov       rcx,18871400A08
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFCDFF47738]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016EC10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016EC28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE0167018]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE016EC10]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C906201928
       call      qword ptr [7FFCE016EC28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,18887400A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE0163198
       mov       [r14+18],rcx
       mov       rcx,18887400A60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
       int       3
M00_L09:
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
       mov       rcx,18887400A60
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
       mov       rcx,18871400A08
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
       mov       rdx,18887400A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0163198
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18887400A60
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rax,1C9061F0008
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
       call      qword ptr [7FFCE016ED30]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,246F5800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,246F5800D50
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       mov       r11,7FFCDF8D1200
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L05
       xor       ebp,ebp
M00_L00:
       mov       r14,[rdi+rbp*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_1(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [r14+18],rcx
       jne       near ptr M00_L03
       mov       rcx,2470B800B08
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
       mov       rcx,246F5800A08
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
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFCDFF2EF40]
       mov       ecx,3D5
       mov       rdx,7FFCDFDA01C0
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC54F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDA01C0
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE00677F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0067810]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE019E658]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE00677F8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2878A801AB0
       call      qword ptr [7FFCE0067810]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2470B800AF8
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCE019A7D8
       mov       [r14+18],rcx
       mov       rcx,2470B800B08
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,11
       call      qword ptr [7FFCDFBA7E58]
       int       3
M00_L09:
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
       mov       rcx,2470B800B08
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
       mov       rcx,246F5800A08
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
       mov       rdx,2470B800AF8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE019A7D8
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2470B800B08
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,11
       call      qword ptr [7FFCDFBA7E58]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
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
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,2878A7F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFCE019F7F8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1D9D8400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF910B18
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,1D9EE400A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF67738]
       mov       ecx,3D5
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0197F90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0197FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE009E748]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE0197F90]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21A6D281928
       call      qword ptr [7FFCE0197FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D9EE400A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE009A898
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D9EE400A40
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
       call      qword ptr [7FFCDF9C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D9EE400A60
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFCE0197FC0]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE0197FD8]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 772
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1D9EE400A40
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,1D9EE400A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE009A898
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D9EE400A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBE7E58]
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
       call      qword ptr [7FFCDF9C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D9EE400A60
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFCE0197FC0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE0197FD8]
       jmp       near ptr M01_L02
; Total bytes of code 421
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
       mov       rax,21A6D270008
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
       call      qword ptr [7FFCE019C240]
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
       call      qword ptr [7FFCE019E670]
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,26619800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF8E0DA8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,26619802A50
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF3EF10]
       mov       ecx,3D5
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB01C0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE015FBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE0155EA8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE015FBE8]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A6AE7A1928
       call      qword ptr [7FFCE015E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26619802A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE0151FF8
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26619802A50
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
       mov       rdx,26619802AD8
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
       call      qword ptr [7FFCE015FAF8]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE015FB10]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,26619802A50
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
       mov       rdx,26619802A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0151FF8
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26619802A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBB7E58]
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
       mov       rdx,26619802AD8
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
       call      qword ptr [7FFCE015FAF8]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE015FB10]
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
       mov       rax,2A6AE790008
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
       call      qword ptr [7FFCE015E958]
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
       call      qword ptr [7FFCE015D4E8]
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
       jmp       qword ptr [7FFCDF995C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1D0B4C00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF8F0B18
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,1D0B4C02A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF47720]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017C150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE007E688]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE017C150]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21149AC1928
       call      qword ptr [7FFCE017C168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0B4C02A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE007A7D8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D0B4C02A38
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
       call      qword ptr [7FFCDF9A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D0B4C02A58
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFCE017C180]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE017C198]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 772
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1D0B4C02A38
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,1D0B4C02A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE007A7D8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D0B4C02A38
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       call      qword ptr [7FFCDF9A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1D0B4C02A58
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFCE017C180]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE017C198]
       jmp       near ptr M01_L02
; Total bytes of code 421
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
       mov       rax,21149AB0008
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
       call      qword ptr [7FFCE017C258]
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
       call      qword ptr [7FFCE017EB38]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,157C4000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF910D58
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,157DA000A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L05
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF67720]
       mov       ecx,3D5
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE01C0
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE01AC258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE01AC270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE009E778]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE01AC258]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,198591B1928
       call      qword ptr [7FFCE01AC270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,157DA000A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE009A8C8
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,157DA000A40
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
       mov       rdx,157DA000A68
       mov       r14,[rdx]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L09
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFCE01AC288]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE01AC2A0]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 771
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,157DA000A40
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L03
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,157DA000A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE009A8C8
       call      qword ptr [7FFCDF9C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,157DA000A40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBE7E58]
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
       mov       rdx,157DA000A68
       mov       rbp,[rdx]
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCDF9C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L08
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFCE01AC288]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE01AC2A0]
       jmp       near ptr M01_L02
; Total bytes of code 420
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
       mov       rax,198591A0008
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
       call      qword ptr [7FFCE01AC180]
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
       call      qword ptr [7FFCE01AC138]
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
       jmp       qword ptr [7FFCDF9C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,17C14C00D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF8F0DA8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,17C14C02A50
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF4F3A8]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244318]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE0186268]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE0244318]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1BCA9D11928
       call      qword ptr [7FFCE018E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,17C14C02A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE01823B8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17C14C02A50
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
       mov       rdx,17C14C02AD8
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
       call      qword ptr [7FFCE0244228]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE0244240]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,17C14C02A50
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
       mov       rdx,17C14C02A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE01823B8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17C14C02A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rdx,17C14C02AD8
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
       call      qword ptr [7FFCE0244228]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE0244240]
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
       mov       rax,1BCA9D00008
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
       call      qword ptr [7FFCE018E958]
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
       call      qword ptr [7FFCE018D4E8]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,1FD22800D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF900DA8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,1FD38800A58
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF5F3C0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD01C0
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254330]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE0196298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE0254330]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23DB7731928
       call      qword ptr [7FFCE019E388]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1FD38800A50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE01923E8
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FD38800A58
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
       mov       rdx,1FD38800AE0
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
       call      qword ptr [7FFCE0254240]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE0254258]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,1FD38800A58
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
       mov       rdx,1FD38800A50
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE01923E8
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FD38800A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBD7E58]
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
       mov       rdx,1FD38800AE0
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
       call      qword ptr [7FFCE0254240]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE0254258]
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
       mov       rax,23DB7720008
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
       call      qword ptr [7FFCE019E970]
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
       call      qword ptr [7FFCE019D500]
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
       jmp       qword ptr [7FFCDF9B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,22FA2000D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF8F0F68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,22FB8000A98
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF4EFA0]
       mov       ecx,3D5
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC01C0
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE019E5C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019E5E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE019CB58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE019E5C8]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,270370E1928
       call      qword ptr [7FFCE019E5E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22FB8000A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE0198CA8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22FB8000A98
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
       mov       rdx,22FB8000B40
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
       call      qword ptr [7FFCE0254CF0]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE0254D08]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,22FB8000A98
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
       mov       rdx,22FB8000A90
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE0198CA8
       call      qword ptr [7FFCDF9A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22FB8000A98
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBC7E58]
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
       mov       rdx,22FB8000B40
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
       call      qword ptr [7FFCE0254CF0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE0254D08]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,270370D0008
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
       call      qword ptr [7FFCE019F4B0]
       int       3
; Total bytes of code 231
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
       call      qword ptr [7FFCE008E6E8]
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
       jmp       qword ptr [7FFCDF9A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>, System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,21CE4400D48
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       test      rsi,rsi
       je        near ptr M00_L02
       mov       r11,7FFCDF8D11D0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L03
       mov       rdi,[rdi+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L10
       mov       rcx,21CFA400B00
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
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFCDFF2F450]
       mov       ecx,3D5
       mov       rdx,7FFCDFDA01C0
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC54F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDA01C0
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE00758A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE00758C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCE019E658]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFCE00758A8]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25D79511AB0
       call      qword ptr [7FFCE00758C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21CFA400AF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCE019A7A8
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21CFA400B00
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
       mov       rdx,21CFA400B48
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
       call      qword ptr [7FFCE02B56B0]
       mov       r14,rsi
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFCE02B56C8]
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M00_L01
; Total bytes of code 769
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.LinqExtensionsBenchmark+<>c.<.cctor>b__8_0(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,21CFA400B00
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
       mov       rdx,21CFA400AF8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCE019A7A8
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21CFA400B00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFCDFBA7E58]
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
       mov       rdx,21CFA400B48
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
       call      qword ptr [7FFCE02B56B0]
       mov       rbp,rbx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFCE02B56C8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
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
       mov       rax,25D79500008
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
       call      qword ptr [7FFCE019F7C8]
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
       call      qword ptr [7FFCE0076340]
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
       jmp       qword ptr [7FFCDF985C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

